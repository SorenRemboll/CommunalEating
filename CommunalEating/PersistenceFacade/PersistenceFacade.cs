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

        #region Household

        private static string houseJsonFileName = "Households.dat";

        public static async void SaveHouseholdJason(ObservableCollection<Household> households)
        {
            string householdJsonString = JsonConvert.SerializeObject(households);
            SerializeHousehold(householdJsonString, houseJsonFileName);
        }

        public static async Task<ObservableCollection<Household>> LoadHouseholdJason()
        {
            string householdJsonString = await DeSerializeHousehold(houseJsonFileName);
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

                MessageDialogHelper.Show("Første gang der loades? Tilføj Husinformationer og gem for at kunne loade", "Fil findes ikke!");
                return null;
            }
        }


        #endregion

        #region HostDinner

        private static string dinnerJsonFileName = "Dinners.dat";

        public static async void SaveDinnerJason(ObservableCollection<HostDinner> dinners)
        {
            string dinnerJsonString = JsonConvert.SerializeObject(dinners);
            SerializeDinner(dinnerJsonString, dinnerJsonFileName);
        }

        public static async Task<ObservableCollection<HostDinner>> LoadDinnerJason()
        {
            string householdJsonString = await DeSerializeDinner(dinnerJsonFileName);
            if (householdJsonString != null)
                return (ObservableCollection<HostDinner>)JsonConvert.DeserializeObject(householdJsonString, typeof(ObservableCollection<HostDinner>));
            return null;
        }

        public static async void SerializeDinner(string dinnerString, string fileName)
        {
            StorageFile localFile = await ApplicationData.Current.LocalFolder.CreateFileAsync(fileName, CreationCollisionOption.ReplaceExisting);
            await FileIO.WriteTextAsync(localFile, dinnerString);
        }

        public static async Task<string> DeSerializeDinner(String fileName)
        {
            try
            {
                StorageFile localFile = await ApplicationData.Current.LocalFolder.GetFileAsync(fileName);
                return await FileIO.ReadTextAsync(localFile);
            }
            catch (FileNotFoundException ex)
            {

                MessageDialogHelper.ShowD("Første gang der loades? Tilføj Husinformationer og gem for at kunne loade", "Fil findes ikke!");
                return null;
            }
        }

        #endregion
        private class MessageDialogHelper
        {
            public static async void Show(string content, string title)
            {
                MessageDialog messageDialog = new MessageDialog(content, title);
                await messageDialog.ShowAsync();
            }
            public static async void ShowD(string content, string title)
            {
                MessageDialog messageDialog = new MessageDialog(content, title);
                await messageDialog.ShowAsync();
            }
        }
    }
}
