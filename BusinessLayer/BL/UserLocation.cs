 //Anusha
 //chandramouli
 //siva
 //Tejaswi

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.BL
{
    public class UserLocation
    {
        string latitude;
        string longitude;
        string address;
        string buildingType;
        string height;
        string width;

       

        public string Latitude { get => latitude; set => latitude = value; }
        public string Longitude { get => longitude; set => longitude = value; }
        public string Address { get => address; set => address = value; }
        public string BuildingType { get => buildingType; set => buildingType = value; }
        public string Height { get => height; set => height = value; }
        public string Width { get => width; set => width = value; }
        
        public string Getuserlocation(string location, string latitude, string longitude)
        {
            string result = "";

       
            /*
             Connection to database and perform select operation
             public async Task<List<PrimaryNode>> GetAllPrimaryNodesAsync()
        {
            List<PrimaryNode> allPrimaryNodes = new List<PrimaryNode>();

            var resultedSnapshot = await 	FirebaseHelper.dbRef.Child("PrimaryNodes").GetValueAsync();

            if (resultedSnapshot == null)
                return allPrimaryNodes;

            var nodesDict = resultedSnapshot.Value as IDictionary<string, object>;

            PrimaryNode currentNode;
            foreach (var nodeItem in nodesDict)
            {
                currentNode = new PrimaryNode();
                currentNode.PrimaryNodeID = nodeItem.Key;
                var nodesData = nodeItem.Value as IDictionary<string, object>;

                if (nodesData.ContainsKey("NodeName"))
                    currentNode.NodeName = nodesData["NodeName"].ToString();

                if (nodesData.ContainsKey("Latitude"))
                    currentNode.Latitude = Convert.ToDouble(nodesData["Latitude"]);

                if (nodesData.ContainsKey("Longitude"))
                    currentNode.Latitude = Convert.ToDouble(nodesData["Longitude"]);

                if (nodesData.ContainsKey("buildingType"))
                    currentNode.BuildingID = nodesData["buildingType"].ToString();

               
                allPrimaryNodes.Add(currentNode);
            }


            return allPrimaryNodes;
        }
             */
            return result;
        }
        public string HouseModel(string buildingType, string height, string width)
        {

            string BuildingType = "";
            /*
             Connection to database and perform select and save operations
             */
            return BuildingType;
        } 
        /*public string BuilderSearch(string buildingType, string userLocation)
        {
            string Builder = " ";
            return Builder;
        }*/
    }
}
