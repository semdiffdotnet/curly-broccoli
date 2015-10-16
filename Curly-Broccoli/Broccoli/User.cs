using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Broccoli
{
    /// <summary>
    /// Phasellus et placerat felis. Vestibulum tempor dui consectetur turpis fringilla, dictum vulputate felis fringilla. Fusce blandit faucibus sollicitudin. Donec pretium massa a nisl luctus posuere. Suspendisse euismod rutrum nisi sit amet pretium. Donec elit massa, consequat sit amet lorem quis, ultricies ornare leo. Suspendisse metus arcu, elementum at velit gravida, volutpat efficitur dolor.
    /// </summary>
    public class User
    {
        /// <summary>
        /// Aenean viverra, magna ac tincidunt dapibus, magna ante lacinia nulla, eget bibendum nulla urna eu velit. 
        /// </summary>
        [Key]
        public string _id { get; set; }
        /// <summary>
        /// Phasellus dictum tortor sed mi porttitor, in iaculis libero facilisis. Donec gravida mauris eu sapien viverra egestas. 
        /// </summary>
        [Range(0,100)]
        public int index { get; set; }
        /// <summary>
        /// Ut nisl risus, dictum eu leo ut, auctor commodo nibh. Vestibulum elementum nibh massa, eget commodo nibh aliquam a. Praesent sed justo ut dui iaculis fermentum.
        /// </summary>
        public string guid { get; set; }
        /// <summary>
        /// Maecenas ac dictum velit. Fusce pulvinar dignissim dolor ac rutrum. Quisque volutpat tortor et urna ultrices venenatis. Etiam quis ultrices felis. Nam accumsan luctus erat, ut iaculis enim. Vivamus sit amet leo in ex efficitur malesuada eu pharetra dolor.
        /// </summary>
        [Display(Name="Online")]
        public bool isActive { get; set; }
        /// <summary>
        /// Vivamus metus nunc, posuere et tincidunt a, dapibus congue leo. Morbi mattis, ipsum et ultrices aliquet, ex nunc convallis nisl, non porttitor sem ante vitae ligula. Integer mattis arcu quis lorem volutpat vehicula. Nullam est urna, tristique ac est at, volutpat ultricies orci. Vestibulum massa magna, euismod non auctor sed, maximus quis nibh. 
        /// </summary>
        [DataType(DataType.Currency)]
        public string balance { get; set; }
        /// <summary>
        /// Phasellus dictum tortor sed mi porttitor, in iaculis libero facilisis. Donec gravida mauris eu sapien viverra egestas. 
        /// </summary>
        public string picture { get; set; }
        /// <summary>
        /// Ut nisl risus, dictum eu leo ut, auctor commodo nibh. Vestibulum elementum nibh massa, eget commodo nibh aliquam a. Praesent sed justo ut dui iaculis fermentum.
        /// </summary>
        public int age { get; set; }
        /// <summary>
        /// Maecenas ac dictum velit. Fusce pulvinar dignissim dolor ac rutrum. Quisque volutpat tortor et urna ultrices venenatis. Etiam quis ultrices felis. Nam accumsan luctus erat, ut iaculis enim. Vivamus sit amet leo in ex efficitur malesuada eu pharetra dolor.
        /// </summary>
        public string eyeColor { get; set; }
        /// <summary>
        /// Phasellus vulputate aliquam libero ut vehicula. Maecenas convallis feugiat lectus sit amet condimentum. Nunc interdum blandit orci, vitae mattis arcu tincidunt et. Pellentesque ornare mollis dolor. 
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// Vivamus metus nunc, posuere et tincidunt a, dapibus congue leo. Morbi mattis, ipsum et ultrices aliquet, ex nunc convallis nisl, non porttitor sem ante vitae ligula. Integer mattis arcu quis lorem volutpat vehicula. Nullam est urna, tristique ac est at, volutpat ultricies orci. Vestibulum massa magna, euismod non auctor sed, maximus quis nibh. 
        /// </summary>
        public string gender { get; set; }
        /// <summary>
        /// Ut ligula eros, commodo eu dolor sit amet, euismod rhoncus dui. Quisque lectus nunc, ultricies in efficitur eget, dignissim in elit.
        /// </summary>
        public string company { get; set; }
        /// <summary>
        /// Vivamus metus nunc, posuere et tincidunt a, dapibus congue leo. Morbi mattis, ipsum et ultrices aliquet, ex nunc convallis nisl, non porttitor sem ante vitae ligula. Integer mattis arcu quis lorem volutpat vehicula. 
        /// </summary>
        public string email { get; set; }
        /// <summary>
        /// Phasellus dictum tortor sed mi porttitor, in iaculis libero facilisis. Donec gravida mauris eu sapien viverra egestas. 
        /// </summary>
        public string phone { get; set; }
        /// <summary>
        /// Ut nisl risus, dictum eu leo ut, auctor commodo nibh. Vestibulum elementum nibh massa, eget commodo nibh aliquam a. Praesent sed justo ut dui iaculis fermentum.
        /// </summary>
        public string address { get; set; }
        /// <summary>
        /// Maecenas ac dictum velit. Fusce pulvinar dignissim dolor ac rutrum. Quisque volutpat tortor et urna ultrices venenatis. Etiam quis ultrices felis. Nam accumsan luctus erat, ut iaculis enim. Vivamus sit amet leo in ex efficitur malesuada eu pharetra dolor.
        /// </summary>
        public string about { get; set; }
        /// <summary>
        /// Phasellus vulputate aliquam libero ut vehicula. Maecenas convallis feugiat lectus sit amet condimentum. Nunc interdum blandit orci, vitae mattis arcu tincidunt et. Pellentesque ornare mollis dolor. 
        /// </summary>
        public string registered { get; set; }
        /// <summary>
        /// Vivamus metus nunc, posuere et tincidunt a, dapibus congue leo. Morbi mattis, ipsum et ultrices aliquet, ex nunc convallis nisl, non porttitor sem ante vitae ligula. Integer mattis arcu quis lorem volutpat vehicula. Nullam est urna, tristique ac est at, volutpat ultricies orci. Vestibulum massa magna, euismod non auctor sed, maximus quis nibh. 
        /// </summary>
        public double latitude { get; set; }
        /// <summary>
        /// Ut ligula eros, commodo eu dolor sit amet, euismod rhoncus dui. Quisque lectus nunc, ultricies in efficitur eget, dignissim in elit.
        /// </summary>
        public double longitude { get; set; }
        /// <summary>
        /// Phasellus dictum tortor sed mi porttitor, in iaculis libero facilisis. Donec gravida mauris eu sapien viverra egestas. 
        /// </summary>
        public List<string> tags { get; set; }
        /// <summary>
        /// Ut nisl risus, dictum eu leo ut, auctor commodo nibh. Vestibulum elementum nibh massa, eget commodo nibh aliquam a. Praesent sed justo ut dui iaculis fermentum.
        /// </summary>
        public List<Friend> friends { get; set; }
        /// <summary>
        /// Maecenas ac dictum velit. Fusce pulvinar dignissim dolor ac rutrum. Quisque volutpat tortor et urna ultrices venenatis. Etiam quis ultrices felis. Nam accumsan luctus erat, ut iaculis enim. Vivamus sit amet leo in ex efficitur malesuada eu pharetra dolor.
        /// </summary>
        public string greeting { get; set; }
        /// <summary>
        /// Phasellus vulputate aliquam libero ut vehicula. Maecenas convallis feugiat lectus sit amet condimentum. Nunc interdum blandit orci, vitae mattis arcu tincidunt et. Pellentesque ornare mollis dolor. 
        /// </summary>
        public string favoriteFruit { get; set; }
    }
}
