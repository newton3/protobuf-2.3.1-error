using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace protobuf
{
    [ProtoContract(UseProtoMembersOnly = true, IgnoreListHandling = true)]
    public class Item
    {
        [ProtoMember(1)]
        public MyDictionary<long, string> Map { get; set; }
    }
}
