using System;
using System.Collections.Generic;
using System.Text;

namespace RadiSharp.Models
{
    public class ProgramGuide
    {
        // メモ: 生成されたコードは、少なくとも .NET Framework 4.5または .NET Core/Standard 2.0 が必要な可能性があります。
        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
        public partial class radiko
        {

            private ushort ttlField;

            private uint srvtimeField;

            private radikoStation[] stationsField;

            /// <remarks/>
            public ushort ttl
            {
                get
                {
                    return this.ttlField;
                }
                set
                {
                    this.ttlField = value;
                }
            }

            /// <remarks/>
            public uint srvtime
            {
                get
                {
                    return this.srvtimeField;
                }
                set
                {
                    this.srvtimeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlArrayItemAttribute("station", IsNullable = false)]
            public radikoStation[] stations
            {
                get
                {
                    return this.stationsField;
                }
                set
                {
                    this.stationsField = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class radikoStation
        {

            private string nameField;

            private radikoStationProgs progsField;

            private string idField;

            /// <remarks/>
            public string name
            {
                get
                {
                    return this.nameField;
                }
                set
                {
                    this.nameField = value;
                }
            }

            /// <remarks/>
            public radikoStationProgs progs
            {
                get
                {
                    return this.progsField;
                }
                set
                {
                    this.progsField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string id
            {
                get
                {
                    return this.idField;
                }
                set
                {
                    this.idField = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class radikoStationProgs
        {

            private uint dateField;

            private radikoStationProgsProg[] progField;

            /// <remarks/>
            public uint date
            {
                get
                {
                    return this.dateField;
                }
                set
                {
                    this.dateField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("prog")]
            public radikoStationProgsProg[] prog
            {
                get
                {
                    return this.progField;
                }
                set
                {
                    this.progField = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class radikoStationProgsProg
        {

            private string titleField;

            private string urlField;

            private byte failed_recordField;

            private byte ts_in_ngField;

            private byte ts_out_ngField;

            private string descField;

            private string infoField;

            private string pfmField;

            private string imgField;

            private radikoStationProgsProgMeta[] metasField;

            private ulong idField;

            private string master_idField;

            private ulong ftField;

            private ulong toField;

            private ushort ftlField;

            private ushort tolField;

            private ushort durField;

            /// <remarks/>
            public string title
            {
                get
                {
                    return this.titleField;
                }
                set
                {
                    this.titleField = value;
                }
            }

            /// <remarks/>
            public string url
            {
                get
                {
                    return this.urlField;
                }
                set
                {
                    this.urlField = value;
                }
            }

            /// <remarks/>
            public byte failed_record
            {
                get
                {
                    return this.failed_recordField;
                }
                set
                {
                    this.failed_recordField = value;
                }
            }

            /// <remarks/>
            public byte ts_in_ng
            {
                get
                {
                    return this.ts_in_ngField;
                }
                set
                {
                    this.ts_in_ngField = value;
                }
            }

            /// <remarks/>
            public byte ts_out_ng
            {
                get
                {
                    return this.ts_out_ngField;
                }
                set
                {
                    this.ts_out_ngField = value;
                }
            }

            /// <remarks/>
            public string desc
            {
                get
                {
                    return this.descField;
                }
                set
                {
                    this.descField = value;
                }
            }

            /// <remarks/>
            public string info
            {
                get
                {
                    return this.infoField;
                }
                set
                {
                    this.infoField = value;
                }
            }

            /// <remarks/>
            public string pfm
            {
                get
                {
                    return this.pfmField;
                }
                set
                {
                    this.pfmField = value;
                }
            }

            /// <remarks/>
            public string img
            {
                get
                {
                    return this.imgField;
                }
                set
                {
                    this.imgField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlArrayItemAttribute("meta", IsNullable = false)]
            public radikoStationProgsProgMeta[] metas
            {
                get
                {
                    return this.metasField;
                }
                set
                {
                    this.metasField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public ulong id
            {
                get
                {
                    return this.idField;
                }
                set
                {
                    this.idField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string master_id
            {
                get
                {
                    return this.master_idField;
                }
                set
                {
                    this.master_idField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public ulong ft
            {
                get
                {
                    return this.ftField;
                }
                set
                {
                    this.ftField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public ulong to
            {
                get
                {
                    return this.toField;
                }
                set
                {
                    this.toField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public ushort ftl
            {
                get
                {
                    return this.ftlField;
                }
                set
                {
                    this.ftlField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public ushort tol
            {
                get
                {
                    return this.tolField;
                }
                set
                {
                    this.tolField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public ushort dur
            {
                get
                {
                    return this.durField;
                }
                set
                {
                    this.durField = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class radikoStationProgsProgMeta
        {

            private string nameField;

            private string valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string name
            {
                get
                {
                    return this.nameField;
                }
                set
                {
                    this.nameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }


    }
}
