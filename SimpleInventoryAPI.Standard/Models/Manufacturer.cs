/*
 * SimpleInventoryAPI.Standard
 *
 * This file was automatically generated by APIMATIC v2.0 ( https://apimatic.io ).
 */
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using SimpleInventoryAPI.Standard;
using SimpleInventoryAPI.Standard.Utilities;


namespace SimpleInventoryAPI.Standard.Models
{
    public class Manufacturer : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string name;
        private string homePage;
        private string phone;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("name")]
        public string Name 
        { 
            get 
            {
                return this.name; 
            } 
            set 
            {
                this.name = value;
                onPropertyChanged("Name");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("homePage")]
        public string HomePage 
        { 
            get 
            {
                return this.homePage; 
            } 
            set 
            {
                this.homePage = value;
                onPropertyChanged("HomePage");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("phone")]
        public string Phone 
        { 
            get 
            {
                return this.phone; 
            } 
            set 
            {
                this.phone = value;
                onPropertyChanged("Phone");
            }
        }
    }
} 