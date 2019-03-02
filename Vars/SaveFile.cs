using System;
using System.Collections.Concurrent;
using System.Collections.ObjectModel;

namespace Radium_utxo_server
{
   
        [Serializable()]
        public class SaveFile
        {
            public int sync_height;
            public Collection<utxo> utxos = new Collection<utxo>();
        }
    
}