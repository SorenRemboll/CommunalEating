using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Windows.Storage;
using Windows.UI.Popups;
using CommunalEating.Models;
using Newtonsoft.Json;

namespace CommunalEating
{
    class PersistenceFacade
    {
        private static string jsonFileName = "Households.dat";

        public static async void SaveHouseholdJason(ObservableCollection<Household> households)
        {
            string householdJsonString = JsonConvert.SerializeObject(households);
            SerializeHousehold(householdJsonString, jsonFileName);
        }

        public static async Task<ObservableCollection<Household>> LoadHouseholdJason()
        {
            string householdJsonString = await DeSerializeHousehold(jsonFileName);
            if (householdJsonString != null)
                return (ObservableCollection<Household>)JsonConvert.DeserializeObject(householdJsonString, typeof(ObservableCollection<Household>));
            return null;
        }

        public static async void SerializeHousehold(string householdString, string fileName)
        {
            StorageFile localFile = await ApplicationData.Current.LocalFolder.CreateFileAsync(fileName, CreationCollisionOption.ReplaceExisting);
            await FileIO.WriteTextAsync(localFile, householdString);
        }

        public static async Task<string> DeSerializeHousehold(String fileName)
        {
            try
            {
                StorageFile localFile = await ApplicationData.Current.LocalFolder.GetFileAsync(fileName);
                return await FileIO.ReadTextAsync(localFile);
            }
            catch (FileNotFoundException ex)
            {

                MessageDialogHelper.Show("Loading for the first time? Try Adding and Save some Persons before you are trying to Load Persons!", "File not found!");
                return null;
            }
        }

        private class MessageDialogHelper
        {
            public static async void Show(string content, string title)
            {
                MessageDialog messageDialog = new MessageDialog(content, title);
                await messageDialog.ShowAsync();
            }
        }

    }
}
