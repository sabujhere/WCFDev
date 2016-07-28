using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ToDoList
{
    [ServiceContract(Name = "http://wcfclient.codeplex.com")]
    public interface ITodoListService
    {
        [OperationContract]
        List<ToDoItem> GetItem();

        [OperationContract]
        string CreateItem(ToDoItem item);
    }

    [DataContract(Name="http://wcfclient.codeplex.com/schema")]
    public class ToDoItem
    {
        [DataMember(Order= 1, IsRequired= false)]
        public string ID { get; set; }

        [DataMember(Order =2, IsRequired = true)]
        public string Tittle { get; set; }

        [DataMember(Order = 3, IsRequired = true)]
        public string Description { get; set; }
    }
}
