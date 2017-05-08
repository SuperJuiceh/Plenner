namespace System.Runtime.CompilerServices {
    internal class __BlockReflectionAttribute : Attribute { }
}

namespace Microsoft.Xml.Serialization.GeneratedAssembly {


    [System.Runtime.CompilerServices.__BlockReflection]
    public class XmlSerializationWriter1 : System.Xml.Serialization.XmlSerializationWriter {

        public void Write36_QuestionPacket(object o, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs ?? @"";
            WriteStartDocument();
            if (o == null) {
                WriteNullTagLiteral(@"QuestionPacket", defaultNamespace);
                return;
            }
            TopLevelElement();
            string namespace1 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write23_QuestionPacket(@"QuestionPacket", namespace1, ((global::Datalab.Server.Packets.QuestionPacket)o), true, false, namespace1, @"");
        }

        public void Write37_ServerDataContainer(object o, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs ?? @"";
            WriteStartDocument();
            if (o == null) {
                WriteNullTagLiteral(@"ServerDataContainer", defaultNamespace);
                return;
            }
            TopLevelElement();
            string namespace2 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write34_ServerDataContainer(@"ServerDataContainer", namespace2, ((global::PlennerServer.Server.ServerDataContainer)o), true, false, namespace2, @"");
        }

        public void Write38_Plan(object o, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs ?? @"";
            WriteStartDocument();
            if (o == null) {
                WriteNullTagLiteral(@"Plan", defaultNamespace);
                return;
            }
            TopLevelElement();
            string namespace3 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write20_Plan(@"Plan", namespace3, ((global::DataLab.Data.Planning.Plan)o), true, false, namespace3, @"");
        }

        public void Write39_PlannerSettings(object o, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs ?? @"";
            WriteStartDocument();
            if (o == null) {
                WriteNullTagLiteral(@"PlannerSettings", defaultNamespace);
                return;
            }
            TopLevelElement();
            string namespace4 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write35_PlannerSettings(@"PlannerSettings", namespace4, ((global::DataLab.Storage.PlannerSettings)o), true, false, namespace4, @"");
        }

        public void Write40_anyType(object o, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs ?? @"";
            WriteStartDocument();
            if (o == null) {
                WriteNullTagLiteral(@"anyType", defaultNamespace);
                return;
            }
            TopLevelElement();
            string namespace5 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write1_Object(@"anyType", namespace5, ((global::System.Object)o), true, false, namespace5, @"");
        }

        public void Write41_Packet(object o, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs ?? @"";
            WriteStartDocument();
            if (o == null) {
                WriteNullTagLiteral(@"Packet", defaultNamespace);
                return;
            }
            TopLevelElement();
            string namespace6 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write2_Packet(@"Packet", namespace6, ((global::Datalab.Server.Packets.Packet)o), true, false, namespace6, @"");
        }

        public void Write42_User(object o, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs ?? @"";
            WriteStartDocument();
            if (o == null) {
                WriteNullTagLiteral(@"User", defaultNamespace);
                return;
            }
            TopLevelElement();
            string namespace7 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write22_User(@"User", namespace7, ((global::DataLab.Data.Users.User)o), true, false, namespace7, @"");
        }

        public void Write43_anyType(object o, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs ?? @"";
            WriteStartDocument();
            if (o == null) {
                WriteNullTagLiteral(@"anyType", defaultNamespace);
                return;
            }
            TopLevelElement();
            string namespace8 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write1_Object(@"anyType", namespace8, ((global::System.Object)o), true, false, namespace8, @"");
        }

        void Write1_Object(string n, string ns, global::System.Object o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::System.Object)) {
                }
                else if (t == typeof(global::DataLab.Storage.PlannerSettings)) {
                    Write35_PlannerSettings(n, ns,(global::DataLab.Storage.PlannerSettings)o, isNullable, true);
                    return;
                }
                else if (t == typeof(global::PlennerServer.Server.ServerDataContainer)) {
                    Write34_ServerDataContainer(n, ns,(global::PlennerServer.Server.ServerDataContainer)o, isNullable, true);
                    return;
                }
                else if (t == typeof(global::DataLab.Data.Users.Message.MessageManager)) {
                    Write33_MessageManager(n, ns,(global::DataLab.Data.Users.Message.MessageManager)o, isNullable, true);
                    return;
                }
                else if (t == typeof(global::DataLab.Data.Users.Message.ChatManager)) {
                    Write32_ChatManager(n, ns,(global::DataLab.Data.Users.Message.ChatManager)o, isNullable, true);
                    return;
                }
                else if (t == typeof(global::DataLab.Data.Users.Message.Chat.ChatRoom)) {
                    Write31_ChatRoom(n, ns,(global::DataLab.Data.Users.Message.Chat.ChatRoom)o, isNullable, true);
                    return;
                }
                else if (t == typeof(global::DataLab.Data.Users.Message.MailManager)) {
                    Write30_MailManager(n, ns,(global::DataLab.Data.Users.Message.MailManager)o, isNullable, true);
                    return;
                }
                else if (t == typeof(global::DataLab.Data.Users.UserManager)) {
                    Write29_UserManager(n, ns,(global::DataLab.Data.Users.UserManager)o, isNullable, true);
                    return;
                }
                else if (t == typeof(global::DataLab.Server.Controller.Logging.ServerLog)) {
                    Write28_ServerLog(n, ns,(global::DataLab.Server.Controller.Logging.ServerLog)o, isNullable, true);
                    return;
                }
                else if (t == typeof(global::DataLab.Server.Controller.Logging.Log)) {
                    Write27_Log(n, ns,(global::DataLab.Server.Controller.Logging.Log)o, isNullable, true);
                    return;
                }
                else if (t == typeof(global::DataLab.Server.Controller.ServerInfo)) {
                    Write25_ServerInfo(n, ns,(global::DataLab.Server.Controller.ServerInfo)o, isNullable, true);
                    return;
                }
                else if (t == typeof(global::DataLab.Data.Users.User)) {
                    Write22_User(n, ns,(global::DataLab.Data.Users.User)o, isNullable, true);
                    return;
                }
                else if (t == typeof(global::DataLab.Data.Users.UserInfo)) {
                    Write21_UserInfo(n, ns,(global::DataLab.Data.Users.UserInfo)o, isNullable, true);
                    return;
                }
                else if (t == typeof(global::DataLab.Data.Planning.Plan)) {
                    Write20_Plan(n, ns,(global::DataLab.Data.Planning.Plan)o, isNullable, true);
                    return;
                }
                else if (t == typeof(global::DataLab.Data.Cijfers.CijferPeriode)) {
                    Write18_CijferPeriode(n, ns,(global::DataLab.Data.Cijfers.CijferPeriode)o, isNullable, true);
                    return;
                }
                else if (t == typeof(global::DataLab.Data.Cijfers.CijferTaak.Cijfertaak)) {
                    Write17_Cijfertaak(n, ns,(global::DataLab.Data.Cijfers.CijferTaak.Cijfertaak)o, isNullable, true);
                    return;
                }
                else if (t == typeof(global::DataLab.Data.Cijfers.CijferTaak.Cijfer)) {
                    Write16_Cijfer(n, ns,(global::DataLab.Data.Cijfers.CijferTaak.Cijfer)o, isNullable, true);
                    return;
                }
                else if (t == typeof(global::DataLab.Data.Users.Message.Message)) {
                    Write14_Message(n, ns,(global::DataLab.Data.Users.Message.Message)o, isNullable, true);
                    return;
                }
                else if (t == typeof(global::DataLab.Data.Users.Message.Mail)) {
                    Write15_Mail(n, ns,(global::DataLab.Data.Users.Message.Mail)o, isNullable, true);
                    return;
                }
                else if (t == typeof(global::DataLab.Data.Planning.Diary)) {
                    Write13_Diary(n, ns,(global::DataLab.Data.Planning.Diary)o, isNullable, true);
                    return;
                }
                else if (t == typeof(global::System.TimeSpan)) {
                    Write8_TimeSpan(n, ns,(global::System.TimeSpan)o, true);
                    return;
                }
                else if (t == typeof(global::Windows.Devices.Geolocation.BasicGeoposition)) {
                    Write5_BasicGeoposition(n, ns,(global::Windows.Devices.Geolocation.BasicGeoposition)o, true);
                    return;
                }
                else if (t == typeof(global::DataLab.Data.Planning.PlanningItem)) {
                    Write4_PlanningItem(n, ns,(global::DataLab.Data.Planning.PlanningItem)o, isNullable, true);
                    return;
                }
                else if (t == typeof(global::DataLab.Data.Cijfers.CijferLijst)) {
                    Write19_CijferLijst(n, ns,(global::DataLab.Data.Cijfers.CijferLijst)o, isNullable, true);
                    return;
                }
                else if (t == typeof(global::DataLab.Data.Planning.Reflection)) {
                    Write12_Reflection(n, ns,(global::DataLab.Data.Planning.Reflection)o, isNullable, true);
                    return;
                }
                else if (t == typeof(global::DataLab.Data.Planning.RepeatingPlanningItem)) {
                    Write9_RepeatingPlanningItem(n, ns,(global::DataLab.Data.Planning.RepeatingPlanningItem)o, isNullable, true);
                    return;
                }
                else if (t == typeof(global::DataLab.Data.Planning.Activity)) {
                    Write6_Activity(n, ns,(global::DataLab.Data.Planning.Activity)o, isNullable, true);
                    return;
                }
                else if (t == typeof(global::Datalab.Server.Packets.Packet)) {
                    Write2_Packet(n, ns,(global::Datalab.Server.Packets.Packet)o, isNullable, true);
                    return;
                }
                else if (t == typeof(global::Datalab.Server.Packets.QuestionPacket)) {
                    Write23_QuestionPacket(n, ns,(global::Datalab.Server.Packets.QuestionPacket)o, isNullable, true);
                    return;
                }
                else if (t == typeof(global::Datalab.Server.Packets.QuestionPacket.Questions)) {
                    Writer.WriteStartElement(n, ns);
                    WriteXsiType(@"Questions", @"");
                    Writer.WriteString(Write3_Questions((global::Datalab.Server.Packets.QuestionPacket.Questions)o));
                    Writer.WriteEndElement();
                    return;
                }
                else if (t == typeof(global::System.Object[])) {
                    Writer.WriteStartElement(n, ns);
                    WriteXsiType(@"ArrayOfAnyType", @"");
                    {
                        global::System.Object[] a = (global::System.Object[])o;
                        if (a != null) {
                            for (int ia = 0; ia < a.Length; ia++) {
                                string namespace9 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                                Write1_Object(@"anyType", namespace9, ((global::System.Object)a[ia]), true, false, namespace9, @"");
                            }
                        }
                    }
                    Writer.WriteEndElement();
                    return;
                }
                else if (t == typeof(global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Planning.Activity>)) {
                    Writer.WriteStartElement(n, ns);
                    WriteXsiType(@"ArrayOfActivity", @"");
                    {
                        global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Planning.Activity> a = (global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Planning.Activity>)o;
                        if (a != null) {
                            for (int ia = 0; ia < ((System.Collections.ICollection)a).Count; ia++) {
                                string namespace10 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                                Write6_Activity(@"Activity", namespace10, ((global::DataLab.Data.Planning.Activity)a[ia]), true, false, namespace10, @"");
                            }
                        }
                    }
                    Writer.WriteEndElement();
                    return;
                }
                else if (t == typeof(global::System.DayOfWeek)) {
                    Writer.WriteStartElement(n, ns);
                    WriteXsiType(@"DayOfWeek", @"");
                    Writer.WriteString(Write7_DayOfWeek((global::System.DayOfWeek)o));
                    Writer.WriteEndElement();
                    return;
                }
                else if (t == typeof(global::System.Collections.Generic.List<global::System.DayOfWeek>)) {
                    Writer.WriteStartElement(n, ns);
                    WriteXsiType(@"ArrayOfDayOfWeek", @"");
                    {
                        global::System.Collections.Generic.List<global::System.DayOfWeek> a = (global::System.Collections.Generic.List<global::System.DayOfWeek>)o;
                        if (a != null) {
                            for (int ia = 0; ia < ((System.Collections.ICollection)a).Count; ia++) {
                                string namespace11 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                                WriteElementString(@"DayOfWeek", namespace11, Write7_DayOfWeek(((global::System.DayOfWeek)a[ia])));
                            }
                        }
                    }
                    Writer.WriteEndElement();
                    return;
                }
                else if (t == typeof(global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Planning.RepeatingPlanningItem>)) {
                    Writer.WriteStartElement(n, ns);
                    WriteXsiType(@"ArrayOfRepeatingPlanningItem", @"");
                    {
                        global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Planning.RepeatingPlanningItem> a = (global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Planning.RepeatingPlanningItem>)o;
                        if (a != null) {
                            for (int ia = 0; ia < ((System.Collections.ICollection)a).Count; ia++) {
                                string namespace12 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                                Write9_RepeatingPlanningItem(@"RepeatingPlanningItem", namespace12, ((global::DataLab.Data.Planning.RepeatingPlanningItem)a[ia]), true, false, namespace12, @"");
                            }
                        }
                    }
                    Writer.WriteEndElement();
                    return;
                }
                else if (t == typeof(global::Windows.Graphics.Imaging.BitmapPixelFormat)) {
                    Writer.WriteStartElement(n, ns);
                    WriteXsiType(@"BitmapPixelFormat", @"");
                    Writer.WriteString(Write10_BitmapPixelFormat((global::Windows.Graphics.Imaging.BitmapPixelFormat)o));
                    Writer.WriteEndElement();
                    return;
                }
                else if (t == typeof(global::System.Int32[])) {
                    Writer.WriteStartElement(n, ns);
                    WriteXsiType(@"ArrayOfInt", @"");
                    {
                        global::System.Int32[] a = (global::System.Int32[])o;
                        if (a != null) {
                            for (int ia = 0; ia < a.Length; ia++) {
                                string namespace13 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                                WriteElementStringRaw(@"int", namespace13, System.Xml.XmlConvert.ToString((global::System.Int32)((global::System.Int32)a[ia])));
                            }
                        }
                    }
                    Writer.WriteEndElement();
                    return;
                }
                else if (t == typeof(global::DataLab.Data.Planning.Reflection.Feelings)) {
                    Writer.WriteStartElement(n, ns);
                    WriteXsiType(@"Feelings", @"");
                    Writer.WriteString(Write11_Feelings((global::DataLab.Data.Planning.Reflection.Feelings)o));
                    Writer.WriteEndElement();
                    return;
                }
                else if (t == typeof(global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Planning.Reflection>)) {
                    Writer.WriteStartElement(n, ns);
                    WriteXsiType(@"ArrayOfReflection", @"");
                    {
                        global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Planning.Reflection> a = (global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Planning.Reflection>)o;
                        if (a != null) {
                            for (int ia = 0; ia < ((System.Collections.ICollection)a).Count; ia++) {
                                string namespace14 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                                Write12_Reflection(@"Reflection", namespace14, ((global::DataLab.Data.Planning.Reflection)a[ia]), true, false, namespace14, @"");
                            }
                        }
                    }
                    Writer.WriteEndElement();
                    return;
                }
                else if (t == typeof(global::System.Collections.Generic.List<global::DataLab.Data.Planning.PlanningItem>)) {
                    Writer.WriteStartElement(n, ns);
                    WriteXsiType(@"ArrayOfPlanningItem", @"");
                    {
                        global::System.Collections.Generic.List<global::DataLab.Data.Planning.PlanningItem> a = (global::System.Collections.Generic.List<global::DataLab.Data.Planning.PlanningItem>)o;
                        if (a != null) {
                            for (int ia = 0; ia < ((System.Collections.ICollection)a).Count; ia++) {
                                string namespace15 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                                Write4_PlanningItem(@"PlanningItem", namespace15, ((global::DataLab.Data.Planning.PlanningItem)a[ia]), true, false, namespace15, @"");
                            }
                        }
                    }
                    Writer.WriteEndElement();
                    return;
                }
                else if (t == typeof(global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Planning.Diary>)) {
                    Writer.WriteStartElement(n, ns);
                    WriteXsiType(@"ArrayOfDiary", @"");
                    {
                        global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Planning.Diary> a = (global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Planning.Diary>)o;
                        if (a != null) {
                            for (int ia = 0; ia < ((System.Collections.ICollection)a).Count; ia++) {
                                string namespace16 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                                Write13_Diary(@"Diary", namespace16, ((global::DataLab.Data.Planning.Diary)a[ia]), true, false, namespace16, @"");
                            }
                        }
                    }
                    Writer.WriteEndElement();
                    return;
                }
                else if (t == typeof(global::System.Collections.Generic.List<global::System.String>)) {
                    Writer.WriteStartElement(n, ns);
                    WriteXsiType(@"ArrayOfString", @"");
                    {
                        global::System.Collections.Generic.List<global::System.String> a = (global::System.Collections.Generic.List<global::System.String>)o;
                        if (a != null) {
                            for (int ia = 0; ia < ((System.Collections.ICollection)a).Count; ia++) {
                                string namespace17 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                                WriteNullableStringLiteral(@"string", namespace17, ((global::System.String)a[ia]));
                            }
                        }
                    }
                    Writer.WriteEndElement();
                    return;
                }
                else if (t == typeof(global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Users.Message.Mail>)) {
                    Writer.WriteStartElement(n, ns);
                    WriteXsiType(@"ArrayOfMail", @"");
                    {
                        global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Users.Message.Mail> a = (global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Users.Message.Mail>)o;
                        if (a != null) {
                            for (int ia = 0; ia < ((System.Collections.ICollection)a).Count; ia++) {
                                string namespace18 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                                Write15_Mail(@"Mail", namespace18, ((global::DataLab.Data.Users.Message.Mail)a[ia]), true, false, namespace18, @"");
                            }
                        }
                    }
                    Writer.WriteEndElement();
                    return;
                }
                else if (t == typeof(global::System.Collections.Generic.List<global::DataLab.Data.Cijfers.CijferTaak.Cijfer>)) {
                    Writer.WriteStartElement(n, ns);
                    WriteXsiType(@"ArrayOfCijfer", @"");
                    {
                        global::System.Collections.Generic.List<global::DataLab.Data.Cijfers.CijferTaak.Cijfer> a = (global::System.Collections.Generic.List<global::DataLab.Data.Cijfers.CijferTaak.Cijfer>)o;
                        if (a != null) {
                            for (int ia = 0; ia < ((System.Collections.ICollection)a).Count; ia++) {
                                string namespace19 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                                Write16_Cijfer(@"Cijfer", namespace19, ((global::DataLab.Data.Cijfers.CijferTaak.Cijfer)a[ia]), true, false, namespace19, @"");
                            }
                        }
                    }
                    Writer.WriteEndElement();
                    return;
                }
                else if (t == typeof(global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Cijfers.CijferTaak.Cijfertaak>)) {
                    Writer.WriteStartElement(n, ns);
                    WriteXsiType(@"ArrayOfCijfertaak", @"");
                    {
                        global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Cijfers.CijferTaak.Cijfertaak> a = (global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Cijfers.CijferTaak.Cijfertaak>)o;
                        if (a != null) {
                            for (int ia = 0; ia < ((System.Collections.ICollection)a).Count; ia++) {
                                string namespace20 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                                Write17_Cijfertaak(@"Cijfertaak", namespace20, ((global::DataLab.Data.Cijfers.CijferTaak.Cijfertaak)a[ia]), true, false, namespace20, @"");
                            }
                        }
                    }
                    Writer.WriteEndElement();
                    return;
                }
                else if (t == typeof(global::System.Collections.Generic.List<global::DataLab.Data.Cijfers.CijferPeriode>)) {
                    Writer.WriteStartElement(n, ns);
                    WriteXsiType(@"ArrayOfCijferPeriode", @"");
                    {
                        global::System.Collections.Generic.List<global::DataLab.Data.Cijfers.CijferPeriode> a = (global::System.Collections.Generic.List<global::DataLab.Data.Cijfers.CijferPeriode>)o;
                        if (a != null) {
                            for (int ia = 0; ia < ((System.Collections.ICollection)a).Count; ia++) {
                                string namespace21 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                                Write18_CijferPeriode(@"CijferPeriode", namespace21, ((global::DataLab.Data.Cijfers.CijferPeriode)a[ia]), true, false, namespace21, @"");
                            }
                        }
                    }
                    Writer.WriteEndElement();
                    return;
                }
                else if (t == typeof(global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Cijfers.CijferLijst>)) {
                    Writer.WriteStartElement(n, ns);
                    WriteXsiType(@"ArrayOfCijferLijst", @"");
                    {
                        global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Cijfers.CijferLijst> a = (global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Cijfers.CijferLijst>)o;
                        if (a != null) {
                            for (int ia = 0; ia < ((System.Collections.ICollection)a).Count; ia++) {
                                string namespace22 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                                Write19_CijferLijst(@"CijferLijst", namespace22, ((global::DataLab.Data.Cijfers.CijferLijst)a[ia]), true, false, namespace22, @"");
                            }
                        }
                    }
                    Writer.WriteEndElement();
                    return;
                }
                else if (t == typeof(global::System.Collections.ObjectModel.ObservableCollection<global::System.String>)) {
                    Writer.WriteStartElement(n, ns);
                    WriteXsiType(@"ArrayOfString", @"");
                    {
                        global::System.Collections.ObjectModel.ObservableCollection<global::System.String> a = (global::System.Collections.ObjectModel.ObservableCollection<global::System.String>)o;
                        if (a != null) {
                            for (int ia = 0; ia < ((System.Collections.ICollection)a).Count; ia++) {
                                string namespace23 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                                WriteNullableStringLiteral(@"Hobbie", namespace23, ((global::System.String)a[ia]));
                            }
                        }
                    }
                    Writer.WriteEndElement();
                    return;
                }
                else if (t == typeof(global::System.Collections.ObjectModel.ObservableCollection<global::System.String>)) {
                    Writer.WriteStartElement(n, ns);
                    WriteXsiType(@"ArrayOfString1", @"");
                    {
                        global::System.Collections.ObjectModel.ObservableCollection<global::System.String> a = (global::System.Collections.ObjectModel.ObservableCollection<global::System.String>)o;
                        if (a != null) {
                            for (int ia = 0; ia < ((System.Collections.ICollection)a).Count; ia++) {
                                string namespace24 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                                WriteNullableStringLiteral(@"Friend", namespace24, ((global::System.String)a[ia]));
                            }
                        }
                    }
                    Writer.WriteEndElement();
                    return;
                }
                else if (t == typeof(global::DataLab.Server.Controller.ServerInfo.RunningStatus)) {
                    Writer.WriteStartElement(n, ns);
                    WriteXsiType(@"RunningStatus", @"");
                    Writer.WriteString(Write24_RunningStatus((global::DataLab.Server.Controller.ServerInfo.RunningStatus)o));
                    Writer.WriteEndElement();
                    return;
                }
                else if (t == typeof(global::DataLab.Server.Controller.Logging.Log.LogTypes)) {
                    Writer.WriteStartElement(n, ns);
                    WriteXsiType(@"LogTypes", @"");
                    Writer.WriteString(Write26_LogTypes((global::DataLab.Server.Controller.Logging.Log.LogTypes)o));
                    Writer.WriteEndElement();
                    return;
                }
                else if (t == typeof(global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Server.Controller.Logging.Log>)) {
                    Writer.WriteStartElement(n, ns);
                    WriteXsiType(@"ArrayOfLog", @"");
                    {
                        global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Server.Controller.Logging.Log> a = (global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Server.Controller.Logging.Log>)o;
                        if (a != null) {
                            for (int ia = 0; ia < ((System.Collections.ICollection)a).Count; ia++) {
                                string namespace25 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                                Write27_Log(@"Log", namespace25, ((global::DataLab.Server.Controller.Logging.Log)a[ia]), true, false, namespace25, @"");
                            }
                        }
                    }
                    Writer.WriteEndElement();
                    return;
                }
                else if (t == typeof(global::System.Collections.Generic.List<global::DataLab.Data.Users.User>)) {
                    Writer.WriteStartElement(n, ns);
                    WriteXsiType(@"ArrayOfUser", @"");
                    {
                        global::System.Collections.Generic.List<global::DataLab.Data.Users.User> a = (global::System.Collections.Generic.List<global::DataLab.Data.Users.User>)o;
                        if (a != null) {
                            for (int ia = 0; ia < ((System.Collections.ICollection)a).Count; ia++) {
                                string namespace26 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                                Write22_User(@"User", namespace26, ((global::DataLab.Data.Users.User)a[ia]), true, false, namespace26, @"");
                            }
                        }
                    }
                    Writer.WriteEndElement();
                    return;
                }
                else if (t == typeof(global::System.Collections.Generic.List<global::DataLab.Data.Users.Message.Mail>)) {
                    Writer.WriteStartElement(n, ns);
                    WriteXsiType(@"ArrayOfMail", @"");
                    {
                        global::System.Collections.Generic.List<global::DataLab.Data.Users.Message.Mail> a = (global::System.Collections.Generic.List<global::DataLab.Data.Users.Message.Mail>)o;
                        if (a != null) {
                            for (int ia = 0; ia < ((System.Collections.ICollection)a).Count; ia++) {
                                string namespace27 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                                Write15_Mail(@"Mail", namespace27, ((global::DataLab.Data.Users.Message.Mail)a[ia]), true, false, namespace27, @"");
                            }
                        }
                    }
                    Writer.WriteEndElement();
                    return;
                }
                else if (t == typeof(global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Users.User>)) {
                    Writer.WriteStartElement(n, ns);
                    WriteXsiType(@"ArrayOfUser", @"");
                    {
                        global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Users.User> a = (global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Users.User>)o;
                        if (a != null) {
                            for (int ia = 0; ia < ((System.Collections.ICollection)a).Count; ia++) {
                                string namespace28 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                                Write22_User(@"User", namespace28, ((global::DataLab.Data.Users.User)a[ia]), true, false, namespace28, @"");
                            }
                        }
                    }
                    Writer.WriteEndElement();
                    return;
                }
                else if (t == typeof(global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Users.Message.Message>)) {
                    Writer.WriteStartElement(n, ns);
                    WriteXsiType(@"ArrayOfMessage", @"");
                    {
                        global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Users.Message.Message> a = (global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Users.Message.Message>)o;
                        if (a != null) {
                            for (int ia = 0; ia < ((System.Collections.ICollection)a).Count; ia++) {
                                string namespace29 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                                Write14_Message(@"Message", namespace29, ((global::DataLab.Data.Users.Message.Message)a[ia]), true, false, namespace29, @"");
                            }
                        }
                    }
                    Writer.WriteEndElement();
                    return;
                }
                else if (t == typeof(global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Users.Message.Chat.ChatRoom>)) {
                    Writer.WriteStartElement(n, ns);
                    WriteXsiType(@"ArrayOfChatRoom", @"");
                    {
                        global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Users.Message.Chat.ChatRoom> a = (global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Users.Message.Chat.ChatRoom>)o;
                        if (a != null) {
                            for (int ia = 0; ia < ((System.Collections.ICollection)a).Count; ia++) {
                                string namespace30 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                                Write31_ChatRoom(@"ChatRoom", namespace30, ((global::DataLab.Data.Users.Message.Chat.ChatRoom)a[ia]), true, false, namespace30, @"");
                            }
                        }
                    }
                    Writer.WriteEndElement();
                    return;
                }
                else {
                    WriteTypedPrimitive(n, ns, o, true);
                    return;
                }
            }
            WriteStartElement(n, ns, o, false, null);
            WriteEndElement(o);
        }

        void Write31_ChatRoom(string n, string ns, global::DataLab.Data.Users.Message.Chat.ChatRoom o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::DataLab.Data.Users.Message.Chat.ChatRoom)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"ChatRoom", defaultNamespace);
            string namespace31 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            {
                global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Users.User> a = (global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Users.User>)((global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Users.User>)o.@Participants);
                if (a != null){
                    WriteStartElement(@"Participants", namespace31, null, false);
                    for (int ia = 0; ia < ((System.Collections.ICollection)a).Count; ia++) {
                        string namespace32 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                        Write22_User(@"User", namespace32, ((global::DataLab.Data.Users.User)a[ia]), true, false, namespace32, @"");
                    }
                    WriteEndElement();
                }
            }
            string namespace33 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            {
                global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Users.Message.Message> a = (global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Users.Message.Message>)((global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Users.Message.Message>)o.@ChatMessages);
                if (a != null){
                    WriteStartElement(@"ChatMessages", namespace33, null, false);
                    for (int ia = 0; ia < ((System.Collections.ICollection)a).Count; ia++) {
                        string namespace34 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                        Write14_Message(@"Message", namespace34, ((global::DataLab.Data.Users.Message.Message)a[ia]), true, false, namespace34, @"");
                    }
                    WriteEndElement();
                }
            }
            string namespace35 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            WriteElementStringRaw(@"ID", namespace35, System.Xml.XmlConvert.ToString((global::System.Int32)((global::System.Int32)o.@ID)));
            string namespace36 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            WriteElementString(@"Name", namespace36, ((global::System.String)o.@Name));
            string namespace37 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            WriteElementStringRaw(@"MaxSize", namespace37, System.Xml.XmlConvert.ToString((global::System.Int32)((global::System.Int32)o.@MaxSize)));
            WriteEndElement(o);
        }

        void Write14_Message(string n, string ns, global::DataLab.Data.Users.Message.Message o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::DataLab.Data.Users.Message.Message)) {
                }
                else if (t == typeof(global::DataLab.Data.Users.Message.Mail)) {
                    Write15_Mail(n, ns,(global::DataLab.Data.Users.Message.Mail)o, isNullable, true);
                    return;
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
        }

        void Write15_Mail(string n, string ns, global::DataLab.Data.Users.Message.Mail o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::DataLab.Data.Users.Message.Mail)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"Mail", defaultNamespace);
            string namespace38 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            WriteElementString(@"Sender", namespace38, ((global::System.String)o.@Sender));
            string namespace39 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            {
                global::System.Collections.Generic.List<global::System.String> a = (global::System.Collections.Generic.List<global::System.String>)((global::System.Collections.Generic.List<global::System.String>)o.@Recepients);
                if (a != null){
                    WriteStartElement(@"Recepients", namespace39, null, false);
                    for (int ia = 0; ia < ((System.Collections.ICollection)a).Count; ia++) {
                        string namespace40 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                        WriteNullableStringLiteral(@"string", namespace40, ((global::System.String)a[ia]));
                    }
                    WriteEndElement();
                }
            }
            string namespace41 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            WriteElementString(@"Msg", namespace41, ((global::System.String)o.@Msg));
            string namespace42 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            WriteElementString(@"TimeSent", namespace42, ((global::System.String)o.@TimeSent));
            string namespace43 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            WriteElementStringRaw(@"SentOn", namespace43, FromDateTime(((global::System.DateTime)o.@SentOn)));
            string namespace44 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            WriteElementString(@"Subject", namespace44, ((global::System.String)o.@Subject));
            string namespace45 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            WriteElementStringRaw(@"wasRead", namespace45, System.Xml.XmlConvert.ToString((global::System.Boolean)((global::System.Boolean)o.@wasRead)));
            WriteEndElement(o);
        }

        void Write22_User(string n, string ns, global::DataLab.Data.Users.User o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::DataLab.Data.Users.User)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"User", defaultNamespace);
            WriteAttribute(@"UserName", @"", ((global::System.String)o.@UserName));
            WriteAttribute(@"password", @"", ((global::System.String)o.@Password));
            string namespace46 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write20_Plan(@"Plan", namespace46, ((global::DataLab.Data.Planning.Plan)o.@plan), false, false, namespace46, @"");
            string namespace47 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            {
                global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Users.Message.Mail> a = (global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Users.Message.Mail>)((global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Users.Message.Mail>)o.@Mails);
                if (a != null){
                    WriteStartElement(@"Mails", namespace47, null, false);
                    for (int ia = 0; ia < ((System.Collections.ICollection)a).Count; ia++) {
                        string namespace48 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                        Write15_Mail(@"Mail", namespace48, ((global::DataLab.Data.Users.Message.Mail)a[ia]), true, false, namespace48, @"");
                    }
                    WriteEndElement();
                }
            }
            string namespace49 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            WriteElementStringRaw(@"LastDataSync", namespace49, FromDateTime(((global::System.DateTime)o.@LastDataSync)));
            string namespace50 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write21_UserInfo(@"UserInfo", namespace50, ((global::DataLab.Data.Users.UserInfo)o.@UserInfo), false, false, namespace50, @"");
            string namespace51 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            {
                global::System.Collections.ObjectModel.ObservableCollection<global::System.String> a = (global::System.Collections.ObjectModel.ObservableCollection<global::System.String>)((global::System.Collections.ObjectModel.ObservableCollection<global::System.String>)o.@Friends);
                if (a != null){
                    WriteStartElement(@"Friends", namespace51, null, false);
                    for (int ia = 0; ia < ((System.Collections.ICollection)a).Count; ia++) {
                        string namespace52 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                        WriteNullableStringLiteral(@"Friend", namespace52, ((global::System.String)a[ia]));
                    }
                    WriteEndElement();
                }
            }
            WriteEndElement(o);
        }

        void Write21_UserInfo(string n, string ns, global::DataLab.Data.Users.UserInfo o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::DataLab.Data.Users.UserInfo)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"UserInfo", defaultNamespace);
            WriteAttribute(@"FirstName", @"", ((global::System.String)o.@FirstName));
            WriteAttribute(@"LastName", @"", ((global::System.String)o.@LastName));
            WriteAttribute(@"BirthDay", @"", FromDateTime(((global::System.DateTime)o.@BirthDay)));
            string namespace53 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            {
                global::System.Collections.ObjectModel.ObservableCollection<global::System.String> a = (global::System.Collections.ObjectModel.ObservableCollection<global::System.String>)((global::System.Collections.ObjectModel.ObservableCollection<global::System.String>)o.@Hobbies);
                if (a != null){
                    WriteStartElement(@"Hobbies", namespace53, null, false);
                    for (int ia = 0; ia < ((System.Collections.ICollection)a).Count; ia++) {
                        string namespace54 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                        WriteNullableStringLiteral(@"Hobbie", namespace54, ((global::System.String)a[ia]));
                    }
                    WriteEndElement();
                }
            }
            string namespace55 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            WriteElementString(@"BirthCountry", namespace55, ((global::System.String)o.@BirthCountry));
            string namespace56 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            WriteElementString(@"CountryOfLiving", namespace56, ((global::System.String)o.@CountryOfLiving));
            string namespace57 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            WriteElementString(@"Language", namespace57, ((global::System.String)o.@Language));
            string namespace58 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            {
                global::System.Collections.Generic.List<global::System.String> a = (global::System.Collections.Generic.List<global::System.String>)((global::System.Collections.Generic.List<global::System.String>)o.@FriendNames);
                if (a != null){
                    WriteStartElement(@"FriendNames", namespace58, null, false);
                    for (int ia = 0; ia < ((System.Collections.ICollection)a).Count; ia++) {
                        string namespace59 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                        WriteNullableStringLiteral(@"string", namespace59, ((global::System.String)a[ia]));
                    }
                    WriteEndElement();
                }
            }
            WriteEndElement(o);
        }

        void Write20_Plan(string n, string ns, global::DataLab.Data.Planning.Plan o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::DataLab.Data.Planning.Plan)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"Plan", defaultNamespace);
            string namespace60 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            {
                global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Planning.Activity> a = (global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Planning.Activity>)((global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Planning.Activity>)o.@Activities);
                if (a != null){
                    WriteStartElement(@"Activities", namespace60, null, false);
                    for (int ia = 0; ia < ((System.Collections.ICollection)a).Count; ia++) {
                        string namespace61 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                        Write6_Activity(@"Activity", namespace61, ((global::DataLab.Data.Planning.Activity)a[ia]), true, false, namespace61, @"");
                    }
                    WriteEndElement();
                }
            }
            string namespace62 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            {
                global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Planning.RepeatingPlanningItem> a = (global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Planning.RepeatingPlanningItem>)((global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Planning.RepeatingPlanningItem>)o.@rpi);
                if (a != null){
                    WriteStartElement(@"rpi", namespace62, null, false);
                    for (int ia = 0; ia < ((System.Collections.ICollection)a).Count; ia++) {
                        string namespace63 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                        Write9_RepeatingPlanningItem(@"RepeatingPlanningItem", namespace63, ((global::DataLab.Data.Planning.RepeatingPlanningItem)a[ia]), true, false, namespace63, @"");
                    }
                    WriteEndElement();
                }
            }
            string namespace64 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            {
                global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Planning.Reflection> a = (global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Planning.Reflection>)((global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Planning.Reflection>)o.@Reflections);
                if (a != null){
                    WriteStartElement(@"Reflections", namespace64, null, false);
                    for (int ia = 0; ia < ((System.Collections.ICollection)a).Count; ia++) {
                        string namespace65 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                        Write12_Reflection(@"Reflection", namespace65, ((global::DataLab.Data.Planning.Reflection)a[ia]), true, false, namespace65, @"");
                    }
                    WriteEndElement();
                }
            }
            string namespace66 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            {
                global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Planning.Diary> a = (global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Planning.Diary>)((global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Planning.Diary>)o.@Diaries);
                if (a != null){
                    WriteStartElement(@"Diaries", namespace66, null, false);
                    for (int ia = 0; ia < ((System.Collections.ICollection)a).Count; ia++) {
                        string namespace67 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                        Write13_Diary(@"Diary", namespace67, ((global::DataLab.Data.Planning.Diary)a[ia]), true, false, namespace67, @"");
                    }
                    WriteEndElement();
                }
            }
            string namespace68 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            {
                global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Users.Message.Mail> a = (global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Users.Message.Mail>)((global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Users.Message.Mail>)o.@Mails);
                if (a != null){
                    WriteStartElement(@"Mails", namespace68, null, false);
                    for (int ia = 0; ia < ((System.Collections.ICollection)a).Count; ia++) {
                        string namespace69 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                        Write15_Mail(@"Mail", namespace69, ((global::DataLab.Data.Users.Message.Mail)a[ia]), true, false, namespace69, @"");
                    }
                    WriteEndElement();
                }
            }
            string namespace70 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            {
                global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Cijfers.CijferLijst> a = (global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Cijfers.CijferLijst>)((global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Cijfers.CijferLijst>)o.@CijferLijsten);
                if (a != null){
                    WriteStartElement(@"CijferLijsten", namespace70, null, false);
                    for (int ia = 0; ia < ((System.Collections.ICollection)a).Count; ia++) {
                        string namespace71 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                        Write19_CijferLijst(@"CijferLijst", namespace71, ((global::DataLab.Data.Cijfers.CijferLijst)a[ia]), true, false, namespace71, @"");
                    }
                    WriteEndElement();
                }
            }
            WriteEndElement(o);
        }

        void Write19_CijferLijst(string n, string ns, global::DataLab.Data.Cijfers.CijferLijst o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::DataLab.Data.Cijfers.CijferLijst)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"CijferLijst", defaultNamespace);
            WriteAttribute(@"Name", @"", ((global::System.String)o.@Name));
            WriteAttribute(@"Silent", @"", System.Xml.XmlConvert.ToString((global::System.Boolean)((global::System.Boolean)o.@Silent)));
            WriteAttribute(@"MinutesToAlertBeforeActualAlarm", @"", System.Xml.XmlConvert.ToString((global::System.Int32)((global::System.Int32)o.@MinutesToAlertBeforeActualAlarm)));
            string namespace72 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            {
                global::System.Collections.Generic.List<global::DataLab.Data.Cijfers.CijferPeriode> a = (global::System.Collections.Generic.List<global::DataLab.Data.Cijfers.CijferPeriode>)((global::System.Collections.Generic.List<global::DataLab.Data.Cijfers.CijferPeriode>)o.@Periodes);
                if (a != null){
                    WriteStartElement(@"Periodes", namespace72, null, false);
                    for (int ia = 0; ia < ((System.Collections.ICollection)a).Count; ia++) {
                        string namespace73 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                        Write18_CijferPeriode(@"CijferPeriode", namespace73, ((global::DataLab.Data.Cijfers.CijferPeriode)a[ia]), true, false, namespace73, @"");
                    }
                    WriteEndElement();
                }
            }
            WriteEndElement(o);
        }

        void Write18_CijferPeriode(string n, string ns, global::DataLab.Data.Cijfers.CijferPeriode o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::DataLab.Data.Cijfers.CijferPeriode)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"CijferPeriode", defaultNamespace);
            string namespace74 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            WriteElementString(@"Name", namespace74, ((global::System.String)o.@Name));
            string namespace75 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            {
                global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Cijfers.CijferTaak.Cijfertaak> a = (global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Cijfers.CijferTaak.Cijfertaak>)((global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Cijfers.CijferTaak.Cijfertaak>)o.@ToComplete);
                if (a != null){
                    WriteStartElement(@"ToComplete", namespace75, null, false);
                    for (int ia = 0; ia < ((System.Collections.ICollection)a).Count; ia++) {
                        string namespace76 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                        Write17_Cijfertaak(@"Cijfertaak", namespace76, ((global::DataLab.Data.Cijfers.CijferTaak.Cijfertaak)a[ia]), true, false, namespace76, @"");
                    }
                    WriteEndElement();
                }
            }
            string namespace77 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            WriteElementStringRaw(@"Start", namespace77, FromDateTime(((global::System.DateTime)o.@Start)));
            string namespace78 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            WriteElementStringRaw(@"End", namespace78, FromDateTime(((global::System.DateTime)o.@End)));
            WriteEndElement(o);
        }

        void Write17_Cijfertaak(string n, string ns, global::DataLab.Data.Cijfers.CijferTaak.Cijfertaak o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::DataLab.Data.Cijfers.CijferTaak.Cijfertaak)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"Cijfertaak", defaultNamespace);
            string namespace79 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            WriteElementString(@"Name", namespace79, ((global::System.String)o.@Name));
            string namespace80 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            {
                global::System.Collections.Generic.List<global::DataLab.Data.Cijfers.CijferTaak.Cijfer> a = (global::System.Collections.Generic.List<global::DataLab.Data.Cijfers.CijferTaak.Cijfer>)((global::System.Collections.Generic.List<global::DataLab.Data.Cijfers.CijferTaak.Cijfer>)o.@Attempts);
                if (a != null){
                    WriteStartElement(@"Attempts", namespace80, null, false);
                    for (int ia = 0; ia < ((System.Collections.ICollection)a).Count; ia++) {
                        string namespace81 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                        Write16_Cijfer(@"Cijfer", namespace81, ((global::DataLab.Data.Cijfers.CijferTaak.Cijfer)a[ia]), true, false, namespace81, @"");
                    }
                    WriteEndElement();
                }
            }
            string namespace82 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            WriteElementStringRaw(@"MaxTeBehalenPunt", namespace82, System.Xml.XmlConvert.ToString((global::System.Double)((global::System.Double)o.@MaxTeBehalenPunt)));
            string namespace83 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            WriteElementStringRaw(@"MinTeBehalenPunt", namespace83, System.Xml.XmlConvert.ToString((global::System.Double)((global::System.Double)o.@MinTeBehalenPunt)));
            WriteEndElement(o);
        }

        void Write16_Cijfer(string n, string ns, global::DataLab.Data.Cijfers.CijferTaak.Cijfer o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::DataLab.Data.Cijfers.CijferTaak.Cijfer)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"Cijfer", defaultNamespace);
            string namespace84 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            WriteElementStringRaw(@"Punt", namespace84, System.Xml.XmlConvert.ToString((global::System.Int32)((global::System.Int32)o.@Punt)));
            WriteEndElement(o);
        }

        void Write13_Diary(string n, string ns, global::DataLab.Data.Planning.Diary o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::DataLab.Data.Planning.Diary)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"Diary", defaultNamespace);
            string namespace85 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            WriteElementString(@"Name", namespace85, ((global::System.String)o.@Name));
            string namespace86 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            WriteElementStringRaw(@"StartTime", namespace86, FromDateTime(((global::System.DateTime)o.@StartTime)));
            string namespace87 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            WriteElementStringRaw(@"EndTime", namespace87, FromDateTime(((global::System.DateTime)o.@EndTime)));
            string namespace88 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            {
                global::System.Collections.Generic.List<global::DataLab.Data.Planning.PlanningItem> a = (global::System.Collections.Generic.List<global::DataLab.Data.Planning.PlanningItem>)((global::System.Collections.Generic.List<global::DataLab.Data.Planning.PlanningItem>)o.@PlanningItems);
                if (a != null){
                    WriteStartElement(@"PlanningItems", namespace88, null, false);
                    for (int ia = 0; ia < ((System.Collections.ICollection)a).Count; ia++) {
                        string namespace89 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                        Write4_PlanningItem(@"PlanningItem", namespace89, ((global::DataLab.Data.Planning.PlanningItem)a[ia]), true, false, namespace89, @"");
                    }
                    WriteEndElement();
                }
            }
            WriteEndElement(o);
        }

        void Write4_PlanningItem(string n, string ns, global::DataLab.Data.Planning.PlanningItem o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::DataLab.Data.Planning.PlanningItem)) {
                }
                else if (t == typeof(global::DataLab.Data.Cijfers.CijferLijst)) {
                    Write19_CijferLijst(n, ns,(global::DataLab.Data.Cijfers.CijferLijst)o, isNullable, true);
                    return;
                }
                else if (t == typeof(global::DataLab.Data.Planning.Reflection)) {
                    Write12_Reflection(n, ns,(global::DataLab.Data.Planning.Reflection)o, isNullable, true);
                    return;
                }
                else if (t == typeof(global::DataLab.Data.Planning.RepeatingPlanningItem)) {
                    Write9_RepeatingPlanningItem(n, ns,(global::DataLab.Data.Planning.RepeatingPlanningItem)o, isNullable, true);
                    return;
                }
                else if (t == typeof(global::DataLab.Data.Planning.Activity)) {
                    Write6_Activity(n, ns,(global::DataLab.Data.Planning.Activity)o, isNullable, true);
                    return;
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"PlanningItem", defaultNamespace);
            WriteAttribute(@"Name", @"", ((global::System.String)o.@Name));
            WriteAttribute(@"Silent", @"", System.Xml.XmlConvert.ToString((global::System.Boolean)((global::System.Boolean)o.@Silent)));
            WriteAttribute(@"MinutesToAlertBeforeActualAlarm", @"", System.Xml.XmlConvert.ToString((global::System.Int32)((global::System.Int32)o.@MinutesToAlertBeforeActualAlarm)));
            WriteEndElement(o);
        }

        void Write6_Activity(string n, string ns, global::DataLab.Data.Planning.Activity o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::DataLab.Data.Planning.Activity)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"Activity", defaultNamespace);
            WriteAttribute(@"Name", @"", ((global::System.String)o.@Name));
            WriteAttribute(@"Silent", @"", System.Xml.XmlConvert.ToString((global::System.Boolean)((global::System.Boolean)o.@Silent)));
            WriteAttribute(@"MinutesToAlertBeforeActualAlarm", @"", System.Xml.XmlConvert.ToString((global::System.Int32)((global::System.Int32)o.@MinutesToAlertBeforeActualAlarm)));
            string namespace90 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            WriteElementStringRaw(@"Start", namespace90, FromDateTime(((global::System.DateTime)o.@Start)));
            string namespace91 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write5_BasicGeoposition(@"basicgeoloc", namespace91, ((global::Windows.Devices.Geolocation.BasicGeoposition)o.@basicgeoloc), false, namespace91, @"");
            string namespace92 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            WriteElementStringRaw(@"End", namespace92, FromDateTime(((global::System.DateTime)o.@End)));
            WriteEndElement(o);
        }

        void Write5_BasicGeoposition(string n, string ns, global::Windows.Devices.Geolocation.BasicGeoposition o, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::Windows.Devices.Geolocation.BasicGeoposition)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"BasicGeoposition", defaultNamespace);
            string namespace93 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            WriteElementStringRaw(@"Latitude", namespace93, System.Xml.XmlConvert.ToString((global::System.Double)((global::System.Double)o.@Latitude)));
            string namespace94 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            WriteElementStringRaw(@"Longitude", namespace94, System.Xml.XmlConvert.ToString((global::System.Double)((global::System.Double)o.@Longitude)));
            string namespace95 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            WriteElementStringRaw(@"Altitude", namespace95, System.Xml.XmlConvert.ToString((global::System.Double)((global::System.Double)o.@Altitude)));
            WriteEndElement(o);
        }

        void Write9_RepeatingPlanningItem(string n, string ns, global::DataLab.Data.Planning.RepeatingPlanningItem o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::DataLab.Data.Planning.RepeatingPlanningItem)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"RepeatingPlanningItem", defaultNamespace);
            WriteAttribute(@"Name", @"", ((global::System.String)o.@Name));
            WriteAttribute(@"Silent", @"", System.Xml.XmlConvert.ToString((global::System.Boolean)((global::System.Boolean)o.@Silent)));
            WriteAttribute(@"MinutesToAlertBeforeActualAlarm", @"", System.Xml.XmlConvert.ToString((global::System.Int32)((global::System.Int32)o.@MinutesToAlertBeforeActualAlarm)));
            string namespace96 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write4_PlanningItem(@"Item", namespace96, ((global::DataLab.Data.Planning.PlanningItem)o.@Item), false, false, namespace96, @"");
            string namespace97 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            {
                global::System.Collections.Generic.List<global::System.DayOfWeek> a = (global::System.Collections.Generic.List<global::System.DayOfWeek>)((global::System.Collections.Generic.List<global::System.DayOfWeek>)o.@Days);
                if (a != null){
                    WriteStartElement(@"Days", namespace97, null, false);
                    for (int ia = 0; ia < ((System.Collections.ICollection)a).Count; ia++) {
                        string namespace98 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                        WriteElementString(@"DayOfWeek", namespace98, Write7_DayOfWeek(((global::System.DayOfWeek)a[ia])));
                    }
                    WriteEndElement();
                }
            }
            string namespace99 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write8_TimeSpan(@"Time", namespace99, ((global::System.TimeSpan)o.@Time), false, namespace99, @"");
            WriteEndElement(o);
        }

        void Write8_TimeSpan(string n, string ns, global::System.TimeSpan o, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::System.TimeSpan)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"TimeSpan", defaultNamespace);
            WriteEndElement(o);
        }

        string Write7_DayOfWeek(global::System.DayOfWeek v) {
            string s = null;
            switch (v) {
                case global::System.DayOfWeek.@Sunday: s = @"Sunday"; break;
                case global::System.DayOfWeek.@Monday: s = @"Monday"; break;
                case global::System.DayOfWeek.@Tuesday: s = @"Tuesday"; break;
                case global::System.DayOfWeek.@Wednesday: s = @"Wednesday"; break;
                case global::System.DayOfWeek.@Thursday: s = @"Thursday"; break;
                case global::System.DayOfWeek.@Friday: s = @"Friday"; break;
                case global::System.DayOfWeek.@Saturday: s = @"Saturday"; break;
                default: throw CreateInvalidEnumValueException(((System.Int64)v).ToString(System.Globalization.CultureInfo.InvariantCulture), @"System.DayOfWeek");
            }
            return s;
        }

        void Write12_Reflection(string n, string ns, global::DataLab.Data.Planning.Reflection o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::DataLab.Data.Planning.Reflection)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"Reflection", defaultNamespace);
            WriteAttribute(@"Name", @"", ((global::System.String)o.@Name));
            WriteAttribute(@"Silent", @"", System.Xml.XmlConvert.ToString((global::System.Boolean)((global::System.Boolean)o.@Silent)));
            WriteAttribute(@"MinutesToAlertBeforeActualAlarm", @"", System.Xml.XmlConvert.ToString((global::System.Int32)((global::System.Int32)o.@MinutesToAlertBeforeActualAlarm)));
            WriteAttribute(@"BitmapPixelFormat", @"", Write10_BitmapPixelFormat(((global::Windows.Graphics.Imaging.BitmapPixelFormat)o.@Format)));
            WriteAttribute(@"Description", @"", ((global::System.String)o.@Description));
            WriteAttribute(@"Time", @"", FromDateTime(((global::System.DateTime)o.@Time)));
            WriteAttribute(@"Feeling", @"", Write11_Feelings(((global::DataLab.Data.Planning.Reflection.Feelings)o.@Feeling)));
            string namespace100 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            WriteElementString(@"PhotoLocation", namespace100, ((global::System.String)o.@PhotoLocation));
            string namespace101 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            {
                global::System.Int32[] a = (global::System.Int32[])((global::System.Int32[])o.@Dimension);
                if (a != null){
                    WriteStartElement(@"Dimension", namespace101, null, false);
                    for (int ia = 0; ia < a.Length; ia++) {
                        string namespace102 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                        WriteElementStringRaw(@"int", namespace102, System.Xml.XmlConvert.ToString((global::System.Int32)((global::System.Int32)a[ia])));
                    }
                    WriteEndElement();
                }
            }
            string namespace103 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write5_BasicGeoposition(@"basicgeoloc", namespace103, ((global::Windows.Devices.Geolocation.BasicGeoposition)o.@basicgeoloc), false, namespace103, @"");
            WriteEndElement(o);
        }

        string Write11_Feelings(global::DataLab.Data.Planning.Reflection.Feelings v) {
            string s = null;
            switch (v) {
                case global::DataLab.Data.Planning.Reflection.Feelings.@DELIGHTED: s = @"DELIGHTED"; break;
                case global::DataLab.Data.Planning.Reflection.Feelings.@DREAMY: s = @"DREAMY"; break;
                case global::DataLab.Data.Planning.Reflection.Feelings.@HAPPY: s = @"HAPPY"; break;
                case global::DataLab.Data.Planning.Reflection.Feelings.@MAD: s = @"MAD"; break;
                case global::DataLab.Data.Planning.Reflection.Feelings.@NEUTRAL: s = @"NEUTRAL"; break;
                case global::DataLab.Data.Planning.Reflection.Feelings.@SAD: s = @"SAD"; break;
                case global::DataLab.Data.Planning.Reflection.Feelings.@SURPRISED: s = @"SURPRISED"; break;
                case global::DataLab.Data.Planning.Reflection.Feelings.@VAGUE: s = @"VAGUE"; break;
                default: throw CreateInvalidEnumValueException(((System.Int64)v).ToString(System.Globalization.CultureInfo.InvariantCulture), @"DataLab.Data.Planning.Reflection.Feelings");
            }
            return s;
        }

        string Write10_BitmapPixelFormat(global::Windows.Graphics.Imaging.BitmapPixelFormat v) {
            string s = null;
            switch (v) {
                case global::Windows.Graphics.Imaging.BitmapPixelFormat.@Unknown: s = @"Unknown"; break;
                case global::Windows.Graphics.Imaging.BitmapPixelFormat.@Rgba16: s = @"Rgba16"; break;
                case global::Windows.Graphics.Imaging.BitmapPixelFormat.@Rgba8: s = @"Rgba8"; break;
                case global::Windows.Graphics.Imaging.BitmapPixelFormat.@Gray16: s = @"Gray16"; break;
                case global::Windows.Graphics.Imaging.BitmapPixelFormat.@Gray8: s = @"Gray8"; break;
                case global::Windows.Graphics.Imaging.BitmapPixelFormat.@Bgra8: s = @"Bgra8"; break;
                case global::Windows.Graphics.Imaging.BitmapPixelFormat.@Nv12: s = @"Nv12"; break;
                case global::Windows.Graphics.Imaging.BitmapPixelFormat.@Yuy2: s = @"Yuy2"; break;
                default: throw CreateInvalidEnumValueException(((System.Int64)v).ToString(System.Globalization.CultureInfo.InvariantCulture), @"Windows.Graphics.Imaging.BitmapPixelFormat");
            }
            return s;
        }

        void Write27_Log(string n, string ns, global::DataLab.Server.Controller.Logging.Log o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::DataLab.Server.Controller.Logging.Log)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"Log", defaultNamespace);
            string namespace104 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            WriteElementStringRaw(@"Time", namespace104, FromDateTime(((global::System.DateTime)o.@Time)));
            string namespace105 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            WriteElementString(@"Message", namespace105, ((global::System.String)o.@Message));
            string namespace106 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            WriteElementString(@"LogType", namespace106, Write26_LogTypes(((global::DataLab.Server.Controller.Logging.Log.LogTypes)o.@LogType)));
            WriteEndElement(o);
        }

        string Write26_LogTypes(global::DataLab.Server.Controller.Logging.Log.LogTypes v) {
            string s = null;
            switch (v) {
                case global::DataLab.Server.Controller.Logging.Log.LogTypes.@Command_result: s = @"Command_result"; break;
                case global::DataLab.Server.Controller.Logging.Log.LogTypes.@Error: s = @"Error"; break;
                case global::DataLab.Server.Controller.Logging.Log.LogTypes.@Server_Status: s = @"Server_Status"; break;
                case global::DataLab.Server.Controller.Logging.Log.LogTypes.@User_Activity: s = @"User_Activity"; break;
                case global::DataLab.Server.Controller.Logging.Log.LogTypes.@Warning: s = @"Warning"; break;
                default: throw CreateInvalidEnumValueException(((System.Int64)v).ToString(System.Globalization.CultureInfo.InvariantCulture), @"DataLab.Server.Controller.Logging.Log.LogTypes");
            }
            return s;
        }

        string Write24_RunningStatus(global::DataLab.Server.Controller.ServerInfo.RunningStatus v) {
            string s = null;
            switch (v) {
                case global::DataLab.Server.Controller.ServerInfo.RunningStatus.@STOP: s = @"STOP"; break;
                case global::DataLab.Server.Controller.ServerInfo.RunningStatus.@PAUSED: s = @"PAUSED"; break;
                case global::DataLab.Server.Controller.ServerInfo.RunningStatus.@RUNNING: s = @"RUNNING"; break;
                default: throw CreateInvalidEnumValueException(((System.Int64)v).ToString(System.Globalization.CultureInfo.InvariantCulture), @"DataLab.Server.Controller.ServerInfo.RunningStatus");
            }
            return s;
        }

        string Write3_Questions(global::Datalab.Server.Packets.QuestionPacket.Questions v) {
            string s = null;
            switch (v) {
                case global::Datalab.Server.Packets.QuestionPacket.Questions.@Valid_username: s = @"Valid_username"; break;
                case global::Datalab.Server.Packets.QuestionPacket.Questions.@Valid_password: s = @"Valid_password"; break;
                case global::Datalab.Server.Packets.QuestionPacket.Questions.@Is_Online: s = @"Is_Online"; break;
                case global::Datalab.Server.Packets.QuestionPacket.Questions.@Permissions_check: s = @"Permissions_check"; break;
                case global::Datalab.Server.Packets.QuestionPacket.Questions.@Registration: s = @"Registration"; break;
                case global::Datalab.Server.Packets.QuestionPacket.Questions.@Is_username_available: s = @"Is_username_available"; break;
                case global::Datalab.Server.Packets.QuestionPacket.Questions.@Get_user: s = @"Get_user"; break;
                case global::Datalab.Server.Packets.QuestionPacket.Questions.@Sync_user: s = @"Sync_user"; break;
                default: throw CreateInvalidEnumValueException(((System.Int64)v).ToString(System.Globalization.CultureInfo.InvariantCulture), @"Datalab.Server.Packets.QuestionPacket.Questions");
            }
            return s;
        }

        void Write23_QuestionPacket(string n, string ns, global::Datalab.Server.Packets.QuestionPacket o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::Datalab.Server.Packets.QuestionPacket)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"QuestionPacket", defaultNamespace);
            string namespace107 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            WriteElementString(@"Q", namespace107, Write3_Questions(((global::Datalab.Server.Packets.QuestionPacket.Questions)o.@Q)));
            string namespace108 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            {
                global::System.Object[] a = (global::System.Object[])((global::System.Object[])o.@Question_data);
                if (a != null){
                    WriteStartElement(@"Question_data", namespace108, null, false);
                    for (int ia = 0; ia < a.Length; ia++) {
                        string namespace109 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                        Write1_Object(@"anyType", namespace109, ((global::System.Object)a[ia]), true, false, namespace109, @"");
                    }
                    WriteEndElement();
                }
            }
            string namespace110 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            WriteElementStringRaw(@"A", namespace110, System.Xml.XmlConvert.ToString((global::System.Boolean)((global::System.Boolean)o.@A)));
            WriteEndElement(o);
        }

        void Write2_Packet(string n, string ns, global::Datalab.Server.Packets.Packet o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::Datalab.Server.Packets.Packet)) {
                }
                else if (t == typeof(global::Datalab.Server.Packets.QuestionPacket)) {
                    Write23_QuestionPacket(n, ns,(global::Datalab.Server.Packets.QuestionPacket)o, isNullable, true);
                    return;
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
        }

        void Write25_ServerInfo(string n, string ns, global::DataLab.Server.Controller.ServerInfo o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::DataLab.Server.Controller.ServerInfo)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"ServerInfo", defaultNamespace);
            string namespace111 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            WriteElementString(@"Name", namespace111, ((global::System.String)o.@Name));
            string namespace112 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            WriteElementStringRaw(@"RunningSince", namespace112, FromDateTime(((global::System.DateTime)o.@RunningSince)));
            string namespace113 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            WriteElementString(@"RunStatus", namespace113, Write24_RunningStatus(((global::DataLab.Server.Controller.ServerInfo.RunningStatus)o.@RunStatus)));
            WriteEndElement(o);
        }

        void Write28_ServerLog(string n, string ns, global::DataLab.Server.Controller.Logging.ServerLog o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::DataLab.Server.Controller.Logging.ServerLog)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"ServerLog", defaultNamespace);
            string namespace114 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            {
                global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Server.Controller.Logging.Log> a = (global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Server.Controller.Logging.Log>)((global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Server.Controller.Logging.Log>)o.@Logs);
                if (a != null){
                    WriteStartElement(@"Logs", namespace114, null, false);
                    for (int ia = 0; ia < ((System.Collections.ICollection)a).Count; ia++) {
                        string namespace115 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                        Write27_Log(@"Log", namespace115, ((global::DataLab.Server.Controller.Logging.Log)a[ia]), true, false, namespace115, @"");
                    }
                    WriteEndElement();
                }
            }
            string namespace116 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            {
                global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Server.Controller.Logging.Log> a = (global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Server.Controller.Logging.Log>)((global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Server.Controller.Logging.Log>)o.@LogHistory);
                if (a != null){
                    WriteStartElement(@"LogHistory", namespace116, null, false);
                    for (int ia = 0; ia < ((System.Collections.ICollection)a).Count; ia++) {
                        string namespace117 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                        Write27_Log(@"Log", namespace117, ((global::DataLab.Server.Controller.Logging.Log)a[ia]), true, false, namespace117, @"");
                    }
                    WriteEndElement();
                }
            }
            WriteEndElement(o);
        }

        void Write29_UserManager(string n, string ns, global::DataLab.Data.Users.UserManager o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::DataLab.Data.Users.UserManager)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"UserManager", defaultNamespace);
            string namespace118 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            {
                global::System.Collections.Generic.List<global::DataLab.Data.Users.User> a = (global::System.Collections.Generic.List<global::DataLab.Data.Users.User>)((global::System.Collections.Generic.List<global::DataLab.Data.Users.User>)o.@Users);
                if (a != null){
                    WriteStartElement(@"Users", namespace118, null, false);
                    for (int ia = 0; ia < ((System.Collections.ICollection)a).Count; ia++) {
                        string namespace119 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                        Write22_User(@"User", namespace119, ((global::DataLab.Data.Users.User)a[ia]), true, false, namespace119, @"");
                    }
                    WriteEndElement();
                }
            }
            WriteEndElement(o);
        }

        void Write30_MailManager(string n, string ns, global::DataLab.Data.Users.Message.MailManager o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::DataLab.Data.Users.Message.MailManager)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"MailManager", defaultNamespace);
            string namespace120 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            {
                global::System.Collections.Generic.List<global::DataLab.Data.Users.Message.Mail> a = (global::System.Collections.Generic.List<global::DataLab.Data.Users.Message.Mail>)((global::System.Collections.Generic.List<global::DataLab.Data.Users.Message.Mail>)o.@Mails);
                if (a != null){
                    WriteStartElement(@"Mails", namespace120, null, false);
                    for (int ia = 0; ia < ((System.Collections.ICollection)a).Count; ia++) {
                        string namespace121 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                        Write15_Mail(@"Mail", namespace121, ((global::DataLab.Data.Users.Message.Mail)a[ia]), true, false, namespace121, @"");
                    }
                    WriteEndElement();
                }
            }
            WriteEndElement(o);
        }

        void Write32_ChatManager(string n, string ns, global::DataLab.Data.Users.Message.ChatManager o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::DataLab.Data.Users.Message.ChatManager)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"ChatManager", defaultNamespace);
            string namespace122 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            {
                global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Users.Message.Chat.ChatRoom> a = (global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Users.Message.Chat.ChatRoom>)((global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Users.Message.Chat.ChatRoom>)o.@ChatRooms);
                if (a != null){
                    WriteStartElement(@"ChatRooms", namespace122, null, false);
                    for (int ia = 0; ia < ((System.Collections.ICollection)a).Count; ia++) {
                        string namespace123 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                        Write31_ChatRoom(@"ChatRoom", namespace123, ((global::DataLab.Data.Users.Message.Chat.ChatRoom)a[ia]), true, false, namespace123, @"");
                    }
                    WriteEndElement();
                }
            }
            string namespace124 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            {
                global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Users.Message.Chat.ChatRoom> a = (global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Users.Message.Chat.ChatRoom>)((global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Users.Message.Chat.ChatRoom>)o.@ChatHistory);
                if (a != null){
                    WriteStartElement(@"ChatHistory", namespace124, null, false);
                    for (int ia = 0; ia < ((System.Collections.ICollection)a).Count; ia++) {
                        string namespace125 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                        Write31_ChatRoom(@"ChatRoom", namespace125, ((global::DataLab.Data.Users.Message.Chat.ChatRoom)a[ia]), true, false, namespace125, @"");
                    }
                    WriteEndElement();
                }
            }
            WriteEndElement(o);
        }

        void Write33_MessageManager(string n, string ns, global::DataLab.Data.Users.Message.MessageManager o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::DataLab.Data.Users.Message.MessageManager)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"MessageManager", defaultNamespace);
            string namespace126 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write30_MailManager(@"MailMan", namespace126, ((global::DataLab.Data.Users.Message.MailManager)o.@MailMan), false, false, namespace126, @"");
            string namespace127 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write32_ChatManager(@"ChatMan", namespace127, ((global::DataLab.Data.Users.Message.ChatManager)o.@ChatMan), false, false, namespace127, @"");
            WriteEndElement(o);
        }

        void Write34_ServerDataContainer(string n, string ns, global::PlennerServer.Server.ServerDataContainer o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::PlennerServer.Server.ServerDataContainer)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"ServerDataContainer", defaultNamespace);
            string namespace128 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write25_ServerInfo(@"Info", namespace128, ((global::DataLab.Server.Controller.ServerInfo)o.@Info), false, false, namespace128, @"");
            string namespace129 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write28_ServerLog(@"Log", namespace129, ((global::DataLab.Server.Controller.Logging.ServerLog)o.@Log), false, false, namespace129, @"");
            string namespace130 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write29_UserManager(@"Uman", namespace130, ((global::DataLab.Data.Users.UserManager)o.@Uman), false, false, namespace130, @"");
            string namespace131 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write33_MessageManager(@"MsgMan", namespace131, ((global::DataLab.Data.Users.Message.MessageManager)o.@MsgMan), false, false, namespace131, @"");
            WriteEndElement(o);
        }

        void Write35_PlannerSettings(string n, string ns, global::DataLab.Storage.PlannerSettings o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::DataLab.Storage.PlannerSettings)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"PlannerSettings", defaultNamespace);
            string namespace132 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            WriteElementStringRaw(@"SoundEnabled", namespace132, System.Xml.XmlConvert.ToString((global::System.Boolean)((global::System.Boolean)o.@SoundEnabled)));
            string namespace133 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            WriteElementStringRaw(@"AutoSyncAccount", namespace133, System.Xml.XmlConvert.ToString((global::System.Boolean)((global::System.Boolean)o.@AutoSyncAccount)));
            string namespace134 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            WriteElementStringRaw(@"AutoLogIn", namespace134, System.Xml.XmlConvert.ToString((global::System.Boolean)((global::System.Boolean)o.@AutoLogIn)));
            string namespace135 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            {
                global::System.Int32[] a = (global::System.Int32[])((global::System.Int32[])o.@PlanningItemExperationTimeSpanAsIntArray);
                if (a != null){
                    WriteStartElement(@"PlanningItemExperationTimeSpanAsIntArray", namespace135, null, false);
                    for (int ia = 0; ia < a.Length; ia++) {
                        string namespace136 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                        WriteElementStringRaw(@"int", namespace136, System.Xml.XmlConvert.ToString((global::System.Int32)((global::System.Int32)a[ia])));
                    }
                    WriteEndElement();
                }
            }
            string namespace137 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            WriteElementStringRaw(@"EnableNotifications", namespace137, System.Xml.XmlConvert.ToString((global::System.Boolean)((global::System.Boolean)o.@EnableNotifications)));
            WriteEndElement(o);
        }

        protected override void InitCallbacks() {
        }
    }

    [System.Runtime.CompilerServices.__BlockReflection]
    public class XmlSerializationReader1 : System.Xml.Serialization.XmlSerializationReader {

        public object Read36_QuestionPacket(string defaultNamespace = null) {
            object o = null;
            Reader.MoveToContent();
            if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                if (((object) Reader.LocalName == (object)id1_QuestionPacket && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                    o = Read23_QuestionPacket(true, true, defaultNamespace);
                }
                else {
                    throw CreateUnknownNodeException();
                }
            }
            else {
                UnknownNode(null, defaultNamespace ?? @":QuestionPacket");
            }
            return (object)o;
        }

        public object Read37_ServerDataContainer(string defaultNamespace = null) {
            object o = null;
            Reader.MoveToContent();
            if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                if (((object) Reader.LocalName == (object)id3_ServerDataContainer && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                    o = Read34_ServerDataContainer(true, true, defaultNamespace);
                }
                else {
                    throw CreateUnknownNodeException();
                }
            }
            else {
                UnknownNode(null, defaultNamespace ?? @":ServerDataContainer");
            }
            return (object)o;
        }

        public object Read38_Plan(string defaultNamespace = null) {
            object o = null;
            Reader.MoveToContent();
            if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                if (((object) Reader.LocalName == (object)id4_Plan && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                    o = Read20_Plan(true, true, defaultNamespace);
                }
                else {
                    throw CreateUnknownNodeException();
                }
            }
            else {
                UnknownNode(null, defaultNamespace ?? @":Plan");
            }
            return (object)o;
        }

        public object Read39_PlannerSettings(string defaultNamespace = null) {
            object o = null;
            Reader.MoveToContent();
            if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                if (((object) Reader.LocalName == (object)id5_PlannerSettings && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                    o = Read35_PlannerSettings(true, true, defaultNamespace);
                }
                else {
                    throw CreateUnknownNodeException();
                }
            }
            else {
                UnknownNode(null, defaultNamespace ?? @":PlannerSettings");
            }
            return (object)o;
        }

        public object Read40_anyType(string defaultNamespace = null) {
            object o = null;
            Reader.MoveToContent();
            if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                if (((object) Reader.LocalName == (object)id6_anyType && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                    o = Read1_Object(true, true, defaultNamespace);
                }
                else {
                    throw CreateUnknownNodeException();
                }
            }
            else {
                UnknownNode(null, defaultNamespace ?? @":anyType");
            }
            return (object)o;
        }

        public object Read41_Packet(string defaultNamespace = null) {
            object o = null;
            Reader.MoveToContent();
            if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                if (((object) Reader.LocalName == (object)id7_Packet && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                    o = Read2_Packet(true, true, defaultNamespace);
                }
                else {
                    throw CreateUnknownNodeException();
                }
            }
            else {
                UnknownNode(null, defaultNamespace ?? @":Packet");
            }
            return (object)o;
        }

        public object Read42_User(string defaultNamespace = null) {
            object o = null;
            Reader.MoveToContent();
            if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                if (((object) Reader.LocalName == (object)id8_User && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                    o = Read22_User(true, true, defaultNamespace);
                }
                else {
                    throw CreateUnknownNodeException();
                }
            }
            else {
                UnknownNode(null, defaultNamespace ?? @":User");
            }
            return (object)o;
        }

        public object Read43_anyType(string defaultNamespace = null) {
            object o = null;
            Reader.MoveToContent();
            if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                if (((object) Reader.LocalName == (object)id6_anyType && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                    o = Read1_Object(true, true, defaultNamespace);
                }
                else {
                    throw CreateUnknownNodeException();
                }
            }
            else {
                UnknownNode(null, defaultNamespace ?? @":anyType");
            }
            return (object)o;
        }

        global::System.Object Read1_Object(bool isNullable, bool checkType, string defaultNamespace = null) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
                if (isNull) {
                    if (xsiType != null) return (global::System.Object)ReadTypedNull(xsiType);
                    else return null;
                }
                if (xsiType == null) {
                    return ReadTypedPrimitive(new System.Xml.XmlQualifiedName("anyType", "http://www.w3.org/2001/XMLSchema"));
                }
                else if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id5_PlannerSettings && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item)))
                    return Read35_PlannerSettings(isNullable, false, defaultNamespace);
                else if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id3_ServerDataContainer && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item)))
                    return Read34_ServerDataContainer(isNullable, false, defaultNamespace);
                else if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id9_MessageManager && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item)))
                    return Read33_MessageManager(isNullable, false, defaultNamespace);
                else if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id10_ChatManager && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item)))
                    return Read32_ChatManager(isNullable, false, defaultNamespace);
                else if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id11_ChatRoom && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item)))
                    return Read31_ChatRoom(isNullable, false, defaultNamespace);
                else if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id12_MailManager && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item)))
                    return Read30_MailManager(isNullable, false, defaultNamespace);
                else if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id13_UserManager && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item)))
                    return Read29_UserManager(isNullable, false, defaultNamespace);
                else if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id14_ServerLog && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item)))
                    return Read28_ServerLog(isNullable, false, defaultNamespace);
                else if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id15_Log && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item)))
                    return Read27_Log(isNullable, false, defaultNamespace);
                else if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id16_ServerInfo && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item)))
                    return Read25_ServerInfo(isNullable, false, defaultNamespace);
                else if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id8_User && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item)))
                    return Read22_User(isNullable, false, defaultNamespace);
                else if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id17_UserInfo && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item)))
                    return Read21_UserInfo(isNullable, false, defaultNamespace);
                else if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id4_Plan && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item)))
                    return Read20_Plan(isNullable, false, defaultNamespace);
                else if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id18_CijferPeriode && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item)))
                    return Read18_CijferPeriode(isNullable, false, defaultNamespace);
                else if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id19_Cijfertaak && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item)))
                    return Read17_Cijfertaak(isNullable, false, defaultNamespace);
                else if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id20_Cijfer && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item)))
                    return Read16_Cijfer(isNullable, false, defaultNamespace);
                else if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id21_Message && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item)))
                    return Read14_Message(isNullable, false, defaultNamespace);
                else if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id22_Mail && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item)))
                    return Read15_Mail(isNullable, false, defaultNamespace);
                else if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id23_Diary && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item)))
                    return Read13_Diary(isNullable, false, defaultNamespace);
                else if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id24_TimeSpan && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item)))
                    return Read8_TimeSpan(false, defaultNamespace);
                else if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id25_BasicGeoposition && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item)))
                    return Read5_BasicGeoposition(false, defaultNamespace);
                else if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id26_PlanningItem && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item)))
                    return Read4_PlanningItem(isNullable, false, defaultNamespace);
                else if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id27_CijferLijst && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item)))
                    return Read19_CijferLijst(isNullable, false, defaultNamespace);
                else if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id28_Reflection && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item)))
                    return Read12_Reflection(isNullable, false, defaultNamespace);
                else if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id29_RepeatingPlanningItem && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item)))
                    return Read9_RepeatingPlanningItem(isNullable, false, defaultNamespace);
                else if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id30_Activity && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item)))
                    return Read6_Activity(isNullable, false, defaultNamespace);
                else if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id7_Packet && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item)))
                    return Read2_Packet(isNullable, false, defaultNamespace);
                else if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id1_QuestionPacket && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item)))
                    return Read23_QuestionPacket(isNullable, false, defaultNamespace);
                else if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id31_Questions && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
                    Reader.ReadStartElement();
                    object e = Read3_Questions(CollapseWhitespace(this.ReadString()));
                    ReadEndElement();
                    return e;
                }
                else if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id32_ArrayOfAnyType && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
                    global::System.Object[] a = null;
                    if (!ReadNull()) {
                        global::System.Object[] z_0_0 = null;
                        int cz_0_0 = 0;
                        if ((Reader.IsEmptyElement)) {
                            Reader.Skip();
                        }
                        else {
                            Reader.ReadStartElement();
                            Reader.MoveToContent();
                            int whileIterations0 = 0;
                            int readerCount0 = ReaderCount;
                            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                                    if (((object) Reader.LocalName == (object)id6_anyType && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                        z_0_0 = (global::System.Object[])EnsureArrayIndex(z_0_0, cz_0_0, typeof(global::System.Object));z_0_0[cz_0_0++] = Read1_Object(true, true, defaultNamespace);
                                    }
                                    else {
                                        UnknownNode(null, @":anyType");
                                    }
                                }
                                else {
                                    UnknownNode(null, @":anyType");
                                }
                                Reader.MoveToContent();
                                CheckReaderCount(ref whileIterations0, ref readerCount0);
                            }
                        ReadEndElement();
                        }
                        a = (global::System.Object[])ShrinkArray(z_0_0, cz_0_0, typeof(global::System.Object), false);
                    }
                    return a;
                }
                else if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id33_ArrayOfActivity && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
                    global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Planning.Activity> a = null;
                    if (!ReadNull()) {
                        if ((object)(a) == null) a = new global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Planning.Activity>();
                        global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Planning.Activity> z_0_0 = (global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Planning.Activity>)a;
                        if ((Reader.IsEmptyElement)) {
                            Reader.Skip();
                        }
                        else {
                            Reader.ReadStartElement();
                            Reader.MoveToContent();
                            int whileIterations1 = 0;
                            int readerCount1 = ReaderCount;
                            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                                    if (((object) Reader.LocalName == (object)id30_Activity && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                        if ((object)(z_0_0) == null) Reader.Skip(); else z_0_0.Add(Read6_Activity(true, true, defaultNamespace));
                                    }
                                    else {
                                        UnknownNode(null, @":Activity");
                                    }
                                }
                                else {
                                    UnknownNode(null, @":Activity");
                                }
                                Reader.MoveToContent();
                                CheckReaderCount(ref whileIterations1, ref readerCount1);
                            }
                        ReadEndElement();
                        }
                    }
                    return a;
                }
                else if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id34_DayOfWeek && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
                    Reader.ReadStartElement();
                    object e = Read7_DayOfWeek(CollapseWhitespace(this.ReadString()));
                    ReadEndElement();
                    return e;
                }
                else if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id35_ArrayOfDayOfWeek && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
                    global::System.Collections.Generic.List<global::System.DayOfWeek> a = null;
                    if (!ReadNull()) {
                        if ((object)(a) == null) a = new global::System.Collections.Generic.List<global::System.DayOfWeek>();
                        global::System.Collections.Generic.List<global::System.DayOfWeek> z_0_0 = (global::System.Collections.Generic.List<global::System.DayOfWeek>)a;
                        if ((Reader.IsEmptyElement)) {
                            Reader.Skip();
                        }
                        else {
                            Reader.ReadStartElement();
                            Reader.MoveToContent();
                            int whileIterations2 = 0;
                            int readerCount2 = ReaderCount;
                            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                                    if (((object) Reader.LocalName == (object)id34_DayOfWeek && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                        {
                                            z_0_0.Add(Read7_DayOfWeek(Reader.ReadElementContentAsString()));
                                        }
                                    }
                                    else {
                                        UnknownNode(null, @":DayOfWeek");
                                    }
                                }
                                else {
                                    UnknownNode(null, @":DayOfWeek");
                                }
                                Reader.MoveToContent();
                                CheckReaderCount(ref whileIterations2, ref readerCount2);
                            }
                        ReadEndElement();
                        }
                    }
                    return a;
                }
                else if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id36_ArrayOfRepeatingPlanningItem && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
                    global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Planning.RepeatingPlanningItem> a = null;
                    if (!ReadNull()) {
                        if ((object)(a) == null) a = new global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Planning.RepeatingPlanningItem>();
                        global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Planning.RepeatingPlanningItem> z_0_0 = (global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Planning.RepeatingPlanningItem>)a;
                        if ((Reader.IsEmptyElement)) {
                            Reader.Skip();
                        }
                        else {
                            Reader.ReadStartElement();
                            Reader.MoveToContent();
                            int whileIterations3 = 0;
                            int readerCount3 = ReaderCount;
                            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                                    if (((object) Reader.LocalName == (object)id29_RepeatingPlanningItem && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                        if ((object)(z_0_0) == null) Reader.Skip(); else z_0_0.Add(Read9_RepeatingPlanningItem(true, true, defaultNamespace));
                                    }
                                    else {
                                        UnknownNode(null, @":RepeatingPlanningItem");
                                    }
                                }
                                else {
                                    UnknownNode(null, @":RepeatingPlanningItem");
                                }
                                Reader.MoveToContent();
                                CheckReaderCount(ref whileIterations3, ref readerCount3);
                            }
                        ReadEndElement();
                        }
                    }
                    return a;
                }
                else if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id37_BitmapPixelFormat && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
                    Reader.ReadStartElement();
                    object e = Read10_BitmapPixelFormat(CollapseWhitespace(this.ReadString()));
                    ReadEndElement();
                    return e;
                }
                else if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id38_ArrayOfInt && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
                    global::System.Int32[] a = null;
                    if (!ReadNull()) {
                        global::System.Int32[] z_0_0 = null;
                        int cz_0_0 = 0;
                        if ((Reader.IsEmptyElement)) {
                            Reader.Skip();
                        }
                        else {
                            Reader.ReadStartElement();
                            Reader.MoveToContent();
                            int whileIterations4 = 0;
                            int readerCount4 = ReaderCount;
                            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                                    if (((object) Reader.LocalName == (object)id39_int && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                        {
                                            z_0_0 = (global::System.Int32[])EnsureArrayIndex(z_0_0, cz_0_0, typeof(global::System.Int32));z_0_0[cz_0_0++] = System.Xml.XmlConvert.ToInt32(Reader.ReadElementContentAsString());
                                        }
                                    }
                                    else {
                                        UnknownNode(null, @":int");
                                    }
                                }
                                else {
                                    UnknownNode(null, @":int");
                                }
                                Reader.MoveToContent();
                                CheckReaderCount(ref whileIterations4, ref readerCount4);
                            }
                        ReadEndElement();
                        }
                        a = (global::System.Int32[])ShrinkArray(z_0_0, cz_0_0, typeof(global::System.Int32), false);
                    }
                    return a;
                }
                else if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id40_Feelings && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
                    Reader.ReadStartElement();
                    object e = Read11_Feelings(CollapseWhitespace(this.ReadString()));
                    ReadEndElement();
                    return e;
                }
                else if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id41_ArrayOfReflection && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
                    global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Planning.Reflection> a = null;
                    if (!ReadNull()) {
                        if ((object)(a) == null) a = new global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Planning.Reflection>();
                        global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Planning.Reflection> z_0_0 = (global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Planning.Reflection>)a;
                        if ((Reader.IsEmptyElement)) {
                            Reader.Skip();
                        }
                        else {
                            Reader.ReadStartElement();
                            Reader.MoveToContent();
                            int whileIterations5 = 0;
                            int readerCount5 = ReaderCount;
                            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                                    if (((object) Reader.LocalName == (object)id28_Reflection && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                        if ((object)(z_0_0) == null) Reader.Skip(); else z_0_0.Add(Read12_Reflection(true, true, defaultNamespace));
                                    }
                                    else {
                                        UnknownNode(null, @":Reflection");
                                    }
                                }
                                else {
                                    UnknownNode(null, @":Reflection");
                                }
                                Reader.MoveToContent();
                                CheckReaderCount(ref whileIterations5, ref readerCount5);
                            }
                        ReadEndElement();
                        }
                    }
                    return a;
                }
                else if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id42_ArrayOfPlanningItem && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
                    global::System.Collections.Generic.List<global::DataLab.Data.Planning.PlanningItem> a = null;
                    if (!ReadNull()) {
                        if ((object)(a) == null) a = new global::System.Collections.Generic.List<global::DataLab.Data.Planning.PlanningItem>();
                        global::System.Collections.Generic.List<global::DataLab.Data.Planning.PlanningItem> z_0_0 = (global::System.Collections.Generic.List<global::DataLab.Data.Planning.PlanningItem>)a;
                        if ((Reader.IsEmptyElement)) {
                            Reader.Skip();
                        }
                        else {
                            Reader.ReadStartElement();
                            Reader.MoveToContent();
                            int whileIterations6 = 0;
                            int readerCount6 = ReaderCount;
                            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                                    if (((object) Reader.LocalName == (object)id26_PlanningItem && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                        if ((object)(z_0_0) == null) Reader.Skip(); else z_0_0.Add(Read4_PlanningItem(true, true, defaultNamespace));
                                    }
                                    else {
                                        UnknownNode(null, @":PlanningItem");
                                    }
                                }
                                else {
                                    UnknownNode(null, @":PlanningItem");
                                }
                                Reader.MoveToContent();
                                CheckReaderCount(ref whileIterations6, ref readerCount6);
                            }
                        ReadEndElement();
                        }
                    }
                    return a;
                }
                else if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id43_ArrayOfDiary && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
                    global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Planning.Diary> a = null;
                    if (!ReadNull()) {
                        if ((object)(a) == null) a = new global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Planning.Diary>();
                        global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Planning.Diary> z_0_0 = (global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Planning.Diary>)a;
                        if ((Reader.IsEmptyElement)) {
                            Reader.Skip();
                        }
                        else {
                            Reader.ReadStartElement();
                            Reader.MoveToContent();
                            int whileIterations7 = 0;
                            int readerCount7 = ReaderCount;
                            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                                    if (((object) Reader.LocalName == (object)id23_Diary && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                        if ((object)(z_0_0) == null) Reader.Skip(); else z_0_0.Add(Read13_Diary(true, true, defaultNamespace));
                                    }
                                    else {
                                        UnknownNode(null, @":Diary");
                                    }
                                }
                                else {
                                    UnknownNode(null, @":Diary");
                                }
                                Reader.MoveToContent();
                                CheckReaderCount(ref whileIterations7, ref readerCount7);
                            }
                        ReadEndElement();
                        }
                    }
                    return a;
                }
                else if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id44_ArrayOfString && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
                    global::System.Collections.Generic.List<global::System.String> a = null;
                    if (!ReadNull()) {
                        if ((object)(a) == null) a = new global::System.Collections.Generic.List<global::System.String>();
                        global::System.Collections.Generic.List<global::System.String> z_0_0 = (global::System.Collections.Generic.List<global::System.String>)a;
                        if ((Reader.IsEmptyElement)) {
                            Reader.Skip();
                        }
                        else {
                            Reader.ReadStartElement();
                            Reader.MoveToContent();
                            int whileIterations8 = 0;
                            int readerCount8 = ReaderCount;
                            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                                    if (((object) Reader.LocalName == (object)id45_string && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                        if (ReadNull()) {
                                            z_0_0.Add(null);
                                        }
                                        else {
                                            z_0_0.Add(Reader.ReadElementContentAsString());
                                        }
                                    }
                                    else {
                                        UnknownNode(null, @":string");
                                    }
                                }
                                else {
                                    UnknownNode(null, @":string");
                                }
                                Reader.MoveToContent();
                                CheckReaderCount(ref whileIterations8, ref readerCount8);
                            }
                        ReadEndElement();
                        }
                    }
                    return a;
                }
                else if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id46_ArrayOfMail && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
                    global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Users.Message.Mail> a = null;
                    if (!ReadNull()) {
                        if ((object)(a) == null) a = new global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Users.Message.Mail>();
                        global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Users.Message.Mail> z_0_0 = (global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Users.Message.Mail>)a;
                        if ((Reader.IsEmptyElement)) {
                            Reader.Skip();
                        }
                        else {
                            Reader.ReadStartElement();
                            Reader.MoveToContent();
                            int whileIterations9 = 0;
                            int readerCount9 = ReaderCount;
                            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                                    if (((object) Reader.LocalName == (object)id22_Mail && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                        if ((object)(z_0_0) == null) Reader.Skip(); else z_0_0.Add(Read15_Mail(true, true, defaultNamespace));
                                    }
                                    else {
                                        UnknownNode(null, @":Mail");
                                    }
                                }
                                else {
                                    UnknownNode(null, @":Mail");
                                }
                                Reader.MoveToContent();
                                CheckReaderCount(ref whileIterations9, ref readerCount9);
                            }
                        ReadEndElement();
                        }
                    }
                    return a;
                }
                else if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id47_ArrayOfCijfer && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
                    global::System.Collections.Generic.List<global::DataLab.Data.Cijfers.CijferTaak.Cijfer> a = null;
                    if (!ReadNull()) {
                        if ((object)(a) == null) a = new global::System.Collections.Generic.List<global::DataLab.Data.Cijfers.CijferTaak.Cijfer>();
                        global::System.Collections.Generic.List<global::DataLab.Data.Cijfers.CijferTaak.Cijfer> z_0_0 = (global::System.Collections.Generic.List<global::DataLab.Data.Cijfers.CijferTaak.Cijfer>)a;
                        if ((Reader.IsEmptyElement)) {
                            Reader.Skip();
                        }
                        else {
                            Reader.ReadStartElement();
                            Reader.MoveToContent();
                            int whileIterations10 = 0;
                            int readerCount10 = ReaderCount;
                            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                                    if (((object) Reader.LocalName == (object)id20_Cijfer && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                        if ((object)(z_0_0) == null) Reader.Skip(); else z_0_0.Add(Read16_Cijfer(true, true, defaultNamespace));
                                    }
                                    else {
                                        UnknownNode(null, @":Cijfer");
                                    }
                                }
                                else {
                                    UnknownNode(null, @":Cijfer");
                                }
                                Reader.MoveToContent();
                                CheckReaderCount(ref whileIterations10, ref readerCount10);
                            }
                        ReadEndElement();
                        }
                    }
                    return a;
                }
                else if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id48_ArrayOfCijfertaak && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
                    global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Cijfers.CijferTaak.Cijfertaak> a = null;
                    if (!ReadNull()) {
                        if ((object)(a) == null) a = new global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Cijfers.CijferTaak.Cijfertaak>();
                        global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Cijfers.CijferTaak.Cijfertaak> z_0_0 = (global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Cijfers.CijferTaak.Cijfertaak>)a;
                        if ((Reader.IsEmptyElement)) {
                            Reader.Skip();
                        }
                        else {
                            Reader.ReadStartElement();
                            Reader.MoveToContent();
                            int whileIterations11 = 0;
                            int readerCount11 = ReaderCount;
                            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                                    if (((object) Reader.LocalName == (object)id19_Cijfertaak && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                        if ((object)(z_0_0) == null) Reader.Skip(); else z_0_0.Add(Read17_Cijfertaak(true, true, defaultNamespace));
                                    }
                                    else {
                                        UnknownNode(null, @":Cijfertaak");
                                    }
                                }
                                else {
                                    UnknownNode(null, @":Cijfertaak");
                                }
                                Reader.MoveToContent();
                                CheckReaderCount(ref whileIterations11, ref readerCount11);
                            }
                        ReadEndElement();
                        }
                    }
                    return a;
                }
                else if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id49_ArrayOfCijferPeriode && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
                    global::System.Collections.Generic.List<global::DataLab.Data.Cijfers.CijferPeriode> a = null;
                    if (!ReadNull()) {
                        if ((object)(a) == null) a = new global::System.Collections.Generic.List<global::DataLab.Data.Cijfers.CijferPeriode>();
                        global::System.Collections.Generic.List<global::DataLab.Data.Cijfers.CijferPeriode> z_0_0 = (global::System.Collections.Generic.List<global::DataLab.Data.Cijfers.CijferPeriode>)a;
                        if ((Reader.IsEmptyElement)) {
                            Reader.Skip();
                        }
                        else {
                            Reader.ReadStartElement();
                            Reader.MoveToContent();
                            int whileIterations12 = 0;
                            int readerCount12 = ReaderCount;
                            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                                    if (((object) Reader.LocalName == (object)id18_CijferPeriode && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                        if ((object)(z_0_0) == null) Reader.Skip(); else z_0_0.Add(Read18_CijferPeriode(true, true, defaultNamespace));
                                    }
                                    else {
                                        UnknownNode(null, @":CijferPeriode");
                                    }
                                }
                                else {
                                    UnknownNode(null, @":CijferPeriode");
                                }
                                Reader.MoveToContent();
                                CheckReaderCount(ref whileIterations12, ref readerCount12);
                            }
                        ReadEndElement();
                        }
                    }
                    return a;
                }
                else if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id50_ArrayOfCijferLijst && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
                    global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Cijfers.CijferLijst> a = null;
                    if (!ReadNull()) {
                        if ((object)(a) == null) a = new global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Cijfers.CijferLijst>();
                        global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Cijfers.CijferLijst> z_0_0 = (global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Cijfers.CijferLijst>)a;
                        if ((Reader.IsEmptyElement)) {
                            Reader.Skip();
                        }
                        else {
                            Reader.ReadStartElement();
                            Reader.MoveToContent();
                            int whileIterations13 = 0;
                            int readerCount13 = ReaderCount;
                            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                                    if (((object) Reader.LocalName == (object)id27_CijferLijst && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                        if ((object)(z_0_0) == null) Reader.Skip(); else z_0_0.Add(Read19_CijferLijst(true, true, defaultNamespace));
                                    }
                                    else {
                                        UnknownNode(null, @":CijferLijst");
                                    }
                                }
                                else {
                                    UnknownNode(null, @":CijferLijst");
                                }
                                Reader.MoveToContent();
                                CheckReaderCount(ref whileIterations13, ref readerCount13);
                            }
                        ReadEndElement();
                        }
                    }
                    return a;
                }
                else if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id44_ArrayOfString && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
                    global::System.Collections.ObjectModel.ObservableCollection<global::System.String> a = null;
                    if (!ReadNull()) {
                        if ((object)(a) == null) a = new global::System.Collections.ObjectModel.ObservableCollection<global::System.String>();
                        global::System.Collections.ObjectModel.ObservableCollection<global::System.String> z_0_0 = (global::System.Collections.ObjectModel.ObservableCollection<global::System.String>)a;
                        if ((Reader.IsEmptyElement)) {
                            Reader.Skip();
                        }
                        else {
                            Reader.ReadStartElement();
                            Reader.MoveToContent();
                            int whileIterations14 = 0;
                            int readerCount14 = ReaderCount;
                            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                                    if (((object) Reader.LocalName == (object)id51_Hobbie && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                        if (ReadNull()) {
                                            z_0_0.Add(null);
                                        }
                                        else {
                                            z_0_0.Add(Reader.ReadElementContentAsString());
                                        }
                                    }
                                    else {
                                        UnknownNode(null, @":Hobbie");
                                    }
                                }
                                else {
                                    UnknownNode(null, @":Hobbie");
                                }
                                Reader.MoveToContent();
                                CheckReaderCount(ref whileIterations14, ref readerCount14);
                            }
                        ReadEndElement();
                        }
                    }
                    return a;
                }
                else if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id52_ArrayOfString1 && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
                    global::System.Collections.ObjectModel.ObservableCollection<global::System.String> a = null;
                    if (!ReadNull()) {
                        if ((object)(a) == null) a = new global::System.Collections.ObjectModel.ObservableCollection<global::System.String>();
                        global::System.Collections.ObjectModel.ObservableCollection<global::System.String> z_0_0 = (global::System.Collections.ObjectModel.ObservableCollection<global::System.String>)a;
                        if ((Reader.IsEmptyElement)) {
                            Reader.Skip();
                        }
                        else {
                            Reader.ReadStartElement();
                            Reader.MoveToContent();
                            int whileIterations15 = 0;
                            int readerCount15 = ReaderCount;
                            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                                    if (((object) Reader.LocalName == (object)id53_Friend && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                        if (ReadNull()) {
                                            z_0_0.Add(null);
                                        }
                                        else {
                                            z_0_0.Add(Reader.ReadElementContentAsString());
                                        }
                                    }
                                    else {
                                        UnknownNode(null, @":Friend");
                                    }
                                }
                                else {
                                    UnknownNode(null, @":Friend");
                                }
                                Reader.MoveToContent();
                                CheckReaderCount(ref whileIterations15, ref readerCount15);
                            }
                        ReadEndElement();
                        }
                    }
                    return a;
                }
                else if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id54_RunningStatus && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
                    Reader.ReadStartElement();
                    object e = Read24_RunningStatus(CollapseWhitespace(this.ReadString()));
                    ReadEndElement();
                    return e;
                }
                else if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id55_LogTypes && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
                    Reader.ReadStartElement();
                    object e = Read26_LogTypes(CollapseWhitespace(this.ReadString()));
                    ReadEndElement();
                    return e;
                }
                else if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id56_ArrayOfLog && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
                    global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Server.Controller.Logging.Log> a = null;
                    if (!ReadNull()) {
                        if ((object)(a) == null) a = new global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Server.Controller.Logging.Log>();
                        global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Server.Controller.Logging.Log> z_0_0 = (global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Server.Controller.Logging.Log>)a;
                        if ((Reader.IsEmptyElement)) {
                            Reader.Skip();
                        }
                        else {
                            Reader.ReadStartElement();
                            Reader.MoveToContent();
                            int whileIterations16 = 0;
                            int readerCount16 = ReaderCount;
                            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                                    if (((object) Reader.LocalName == (object)id15_Log && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                        if ((object)(z_0_0) == null) Reader.Skip(); else z_0_0.Add(Read27_Log(true, true, defaultNamespace));
                                    }
                                    else {
                                        UnknownNode(null, @":Log");
                                    }
                                }
                                else {
                                    UnknownNode(null, @":Log");
                                }
                                Reader.MoveToContent();
                                CheckReaderCount(ref whileIterations16, ref readerCount16);
                            }
                        ReadEndElement();
                        }
                    }
                    return a;
                }
                else if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id57_ArrayOfUser && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
                    global::System.Collections.Generic.List<global::DataLab.Data.Users.User> a = null;
                    if (!ReadNull()) {
                        if ((object)(a) == null) a = new global::System.Collections.Generic.List<global::DataLab.Data.Users.User>();
                        global::System.Collections.Generic.List<global::DataLab.Data.Users.User> z_0_0 = (global::System.Collections.Generic.List<global::DataLab.Data.Users.User>)a;
                        if ((Reader.IsEmptyElement)) {
                            Reader.Skip();
                        }
                        else {
                            Reader.ReadStartElement();
                            Reader.MoveToContent();
                            int whileIterations17 = 0;
                            int readerCount17 = ReaderCount;
                            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                                    if (((object) Reader.LocalName == (object)id8_User && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                        if ((object)(z_0_0) == null) Reader.Skip(); else z_0_0.Add(Read22_User(true, true, defaultNamespace));
                                    }
                                    else {
                                        UnknownNode(null, @":User");
                                    }
                                }
                                else {
                                    UnknownNode(null, @":User");
                                }
                                Reader.MoveToContent();
                                CheckReaderCount(ref whileIterations17, ref readerCount17);
                            }
                        ReadEndElement();
                        }
                    }
                    return a;
                }
                else if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id46_ArrayOfMail && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
                    global::System.Collections.Generic.List<global::DataLab.Data.Users.Message.Mail> a = null;
                    if (!ReadNull()) {
                        if ((object)(a) == null) a = new global::System.Collections.Generic.List<global::DataLab.Data.Users.Message.Mail>();
                        global::System.Collections.Generic.List<global::DataLab.Data.Users.Message.Mail> z_0_0 = (global::System.Collections.Generic.List<global::DataLab.Data.Users.Message.Mail>)a;
                        if ((Reader.IsEmptyElement)) {
                            Reader.Skip();
                        }
                        else {
                            Reader.ReadStartElement();
                            Reader.MoveToContent();
                            int whileIterations18 = 0;
                            int readerCount18 = ReaderCount;
                            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                                    if (((object) Reader.LocalName == (object)id22_Mail && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                        if ((object)(z_0_0) == null) Reader.Skip(); else z_0_0.Add(Read15_Mail(true, true, defaultNamespace));
                                    }
                                    else {
                                        UnknownNode(null, @":Mail");
                                    }
                                }
                                else {
                                    UnknownNode(null, @":Mail");
                                }
                                Reader.MoveToContent();
                                CheckReaderCount(ref whileIterations18, ref readerCount18);
                            }
                        ReadEndElement();
                        }
                    }
                    return a;
                }
                else if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id57_ArrayOfUser && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
                    global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Users.User> a = null;
                    if (!ReadNull()) {
                        if ((object)(a) == null) a = new global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Users.User>();
                        global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Users.User> z_0_0 = (global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Users.User>)a;
                        if ((Reader.IsEmptyElement)) {
                            Reader.Skip();
                        }
                        else {
                            Reader.ReadStartElement();
                            Reader.MoveToContent();
                            int whileIterations19 = 0;
                            int readerCount19 = ReaderCount;
                            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                                    if (((object) Reader.LocalName == (object)id8_User && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                        if ((object)(z_0_0) == null) Reader.Skip(); else z_0_0.Add(Read22_User(true, true, defaultNamespace));
                                    }
                                    else {
                                        UnknownNode(null, @":User");
                                    }
                                }
                                else {
                                    UnknownNode(null, @":User");
                                }
                                Reader.MoveToContent();
                                CheckReaderCount(ref whileIterations19, ref readerCount19);
                            }
                        ReadEndElement();
                        }
                    }
                    return a;
                }
                else if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id58_ArrayOfMessage && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
                    global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Users.Message.Message> a = null;
                    if (!ReadNull()) {
                        if ((object)(a) == null) a = new global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Users.Message.Message>();
                        global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Users.Message.Message> z_0_0 = (global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Users.Message.Message>)a;
                        if ((Reader.IsEmptyElement)) {
                            Reader.Skip();
                        }
                        else {
                            Reader.ReadStartElement();
                            Reader.MoveToContent();
                            int whileIterations20 = 0;
                            int readerCount20 = ReaderCount;
                            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                                    if (((object) Reader.LocalName == (object)id21_Message && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                        if ((object)(z_0_0) == null) Reader.Skip(); else z_0_0.Add(Read14_Message(true, true, defaultNamespace));
                                    }
                                    else {
                                        UnknownNode(null, @":Message");
                                    }
                                }
                                else {
                                    UnknownNode(null, @":Message");
                                }
                                Reader.MoveToContent();
                                CheckReaderCount(ref whileIterations20, ref readerCount20);
                            }
                        ReadEndElement();
                        }
                    }
                    return a;
                }
                else if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id59_ArrayOfChatRoom && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
                    global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Users.Message.Chat.ChatRoom> a = null;
                    if (!ReadNull()) {
                        if ((object)(a) == null) a = new global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Users.Message.Chat.ChatRoom>();
                        global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Users.Message.Chat.ChatRoom> z_0_0 = (global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Users.Message.Chat.ChatRoom>)a;
                        if ((Reader.IsEmptyElement)) {
                            Reader.Skip();
                        }
                        else {
                            Reader.ReadStartElement();
                            Reader.MoveToContent();
                            int whileIterations21 = 0;
                            int readerCount21 = ReaderCount;
                            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                                    if (((object) Reader.LocalName == (object)id11_ChatRoom && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                        if ((object)(z_0_0) == null) Reader.Skip(); else z_0_0.Add(Read31_ChatRoom(true, true, defaultNamespace));
                                    }
                                    else {
                                        UnknownNode(null, @":ChatRoom");
                                    }
                                }
                                else {
                                    UnknownNode(null, @":ChatRoom");
                                }
                                Reader.MoveToContent();
                                CheckReaderCount(ref whileIterations21, ref readerCount21);
                            }
                        ReadEndElement();
                        }
                    }
                    return a;
                }
                else
                    return ReadTypedPrimitive((System.Xml.XmlQualifiedName)xsiType);
                }
                if (isNull) return null;
                global::System.Object o;
                o = new global::System.Object();
                bool[] paramsRead = new bool[0];
                while (Reader.MoveToNextAttribute()) {
                    if (!IsXmlnsAttribute(Reader.Name)) {
                        UnknownNode((object)o);
                    }
                }
                Reader.MoveToElement();
                if (Reader.IsEmptyElement) {
                    Reader.Skip();
                    return o;
                }
                Reader.ReadStartElement();
                Reader.MoveToContent();
                int whileIterations22 = 0;
                int readerCount22 = ReaderCount;
                while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                    if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                        UnknownNode((object)o, @"");
                    }
                    else {
                        UnknownNode((object)o, @"");
                    }
                    Reader.MoveToContent();
                    CheckReaderCount(ref whileIterations22, ref readerCount22);
                }
                ReadEndElement();
                return o;
            }

            global::DataLab.Data.Users.Message.Chat.ChatRoom Read31_ChatRoom(bool isNullable, bool checkType, string defaultNamespace = null) {
                System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
                bool isNull = false;
                if (isNullable) isNull = ReadNull();
                if (checkType) {
                if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id11_ChatRoom && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
                }
                else
                    throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
                }
                if (isNull) return null;
                global::DataLab.Data.Users.Message.Chat.ChatRoom o;
                o = new global::DataLab.Data.Users.Message.Chat.ChatRoom();
                if ((object)(o.@Participants) == null) o.@Participants = new global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Users.User>();
                global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Users.User> a_0 = (global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Users.User>)o.@Participants;
                if ((object)(o.@ChatMessages) == null) o.@ChatMessages = new global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Users.Message.Message>();
                global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Users.Message.Message> a_1 = (global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Users.Message.Message>)o.@ChatMessages;
                bool[] paramsRead = new bool[5];
                while (Reader.MoveToNextAttribute()) {
                    if (!IsXmlnsAttribute(Reader.Name)) {
                        UnknownNode((object)o);
                    }
                }
                Reader.MoveToElement();
                if (Reader.IsEmptyElement) {
                    Reader.Skip();
                    return o;
                }
                Reader.ReadStartElement();
                Reader.MoveToContent();
                int whileIterations23 = 0;
                int readerCount23 = ReaderCount;
                while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                    if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                        if (((object) Reader.LocalName == (object)id60_Participants && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                            if (!ReadNull()) {
                                if ((object)(o.@Participants) == null) o.@Participants = new global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Users.User>();
                                global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Users.User> a_0_0 = (global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Users.User>)o.@Participants;
                                if ((Reader.IsEmptyElement)) {
                                    Reader.Skip();
                                }
                                else {
                                    Reader.ReadStartElement();
                                    Reader.MoveToContent();
                                    int whileIterations24 = 0;
                                    int readerCount24 = ReaderCount;
                                    while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                                        if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                                            if (((object) Reader.LocalName == (object)id8_User && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                                if ((object)(a_0_0) == null) Reader.Skip(); else a_0_0.Add(Read22_User(true, true, defaultNamespace));
                                            }
                                            else {
                                                UnknownNode(null, @":User");
                                            }
                                        }
                                        else {
                                            UnknownNode(null, @":User");
                                        }
                                        Reader.MoveToContent();
                                        CheckReaderCount(ref whileIterations24, ref readerCount24);
                                    }
                                ReadEndElement();
                                }
                            }
                        }
                        else if (((object) Reader.LocalName == (object)id61_ChatMessages && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                            if (!ReadNull()) {
                                if ((object)(o.@ChatMessages) == null) o.@ChatMessages = new global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Users.Message.Message>();
                                global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Users.Message.Message> a_1_0 = (global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Users.Message.Message>)o.@ChatMessages;
                                if ((Reader.IsEmptyElement)) {
                                    Reader.Skip();
                                }
                                else {
                                    Reader.ReadStartElement();
                                    Reader.MoveToContent();
                                    int whileIterations25 = 0;
                                    int readerCount25 = ReaderCount;
                                    while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                                        if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                                            if (((object) Reader.LocalName == (object)id21_Message && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                                if ((object)(a_1_0) == null) Reader.Skip(); else a_1_0.Add(Read14_Message(true, true, defaultNamespace));
                                            }
                                            else {
                                                UnknownNode(null, @":Message");
                                            }
                                        }
                                        else {
                                            UnknownNode(null, @":Message");
                                        }
                                        Reader.MoveToContent();
                                        CheckReaderCount(ref whileIterations25, ref readerCount25);
                                    }
                                ReadEndElement();
                                }
                            }
                        }
                        else if (!paramsRead[2] && ((object) Reader.LocalName == (object)id62_ID && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                            {
                                o.@ID = System.Xml.XmlConvert.ToInt32(Reader.ReadElementContentAsString());
                            }
                            paramsRead[2] = true;
                        }
                        else if (!paramsRead[3] && ((object) Reader.LocalName == (object)id63_Name && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                            {
                                o.@Name = Reader.ReadElementContentAsString();
                            }
                            paramsRead[3] = true;
                        }
                        else if (!paramsRead[4] && ((object) Reader.LocalName == (object)id64_MaxSize && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                            {
                                o.@MaxSize = System.Xml.XmlConvert.ToInt32(Reader.ReadElementContentAsString());
                            }
                            paramsRead[4] = true;
                        }
                        else {
                            UnknownNode((object)o, @":Participants, :ChatMessages, :ID, :Name, :MaxSize");
                        }
                    }
                    else {
                        UnknownNode((object)o, @":Participants, :ChatMessages, :ID, :Name, :MaxSize");
                    }
                    Reader.MoveToContent();
                    CheckReaderCount(ref whileIterations23, ref readerCount23);
                }
                ReadEndElement();
                return o;
            }

            global::DataLab.Data.Users.Message.Message Read14_Message(bool isNullable, bool checkType, string defaultNamespace = null) {
                System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
                bool isNull = false;
                if (isNullable) isNull = ReadNull();
                if (checkType) {
                if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id21_Message && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
                }
                else if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id22_Mail && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item)))
                    return Read15_Mail(isNullable, false, defaultNamespace);
                else
                    throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
                }
                if (isNull) return null;
                throw CreateAbstractTypeException(@"Message", @"");
            }

            global::DataLab.Data.Users.Message.Mail Read15_Mail(bool isNullable, bool checkType, string defaultNamespace = null) {
                System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
                bool isNull = false;
                if (isNullable) isNull = ReadNull();
                if (checkType) {
                if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id22_Mail && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
                }
                else
                    throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
                }
                if (isNull) return null;
                global::DataLab.Data.Users.Message.Mail o;
                o = new global::DataLab.Data.Users.Message.Mail();
                if ((object)(o.@Recepients) == null) o.@Recepients = new global::System.Collections.Generic.List<global::System.String>();
                global::System.Collections.Generic.List<global::System.String> a_1 = (global::System.Collections.Generic.List<global::System.String>)o.@Recepients;
                bool[] paramsRead = new bool[7];
                while (Reader.MoveToNextAttribute()) {
                    if (!IsXmlnsAttribute(Reader.Name)) {
                        UnknownNode((object)o);
                    }
                }
                Reader.MoveToElement();
                if (Reader.IsEmptyElement) {
                    Reader.Skip();
                    return o;
                }
                Reader.ReadStartElement();
                Reader.MoveToContent();
                int whileIterations26 = 0;
                int readerCount26 = ReaderCount;
                while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                    if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                        if (!paramsRead[0] && ((object) Reader.LocalName == (object)id65_Sender && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                            {
                                o.@Sender = Reader.ReadElementContentAsString();
                            }
                            paramsRead[0] = true;
                        }
                        else if (((object) Reader.LocalName == (object)id66_Recepients && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                            if (!ReadNull()) {
                                if ((object)(o.@Recepients) == null) o.@Recepients = new global::System.Collections.Generic.List<global::System.String>();
                                global::System.Collections.Generic.List<global::System.String> a_1_0 = (global::System.Collections.Generic.List<global::System.String>)o.@Recepients;
                                if ((Reader.IsEmptyElement)) {
                                    Reader.Skip();
                                }
                                else {
                                    Reader.ReadStartElement();
                                    Reader.MoveToContent();
                                    int whileIterations27 = 0;
                                    int readerCount27 = ReaderCount;
                                    while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                                        if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                                            if (((object) Reader.LocalName == (object)id45_string && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                                if (ReadNull()) {
                                                    a_1_0.Add(null);
                                                }
                                                else {
                                                    a_1_0.Add(Reader.ReadElementContentAsString());
                                                }
                                            }
                                            else {
                                                UnknownNode(null, @":string");
                                            }
                                        }
                                        else {
                                            UnknownNode(null, @":string");
                                        }
                                        Reader.MoveToContent();
                                        CheckReaderCount(ref whileIterations27, ref readerCount27);
                                    }
                                ReadEndElement();
                                }
                            }
                        }
                        else if (!paramsRead[2] && ((object) Reader.LocalName == (object)id67_Msg && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                            {
                                o.@Msg = Reader.ReadElementContentAsString();
                            }
                            paramsRead[2] = true;
                        }
                        else if (!paramsRead[3] && ((object) Reader.LocalName == (object)id68_TimeSent && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                            {
                                o.@TimeSent = Reader.ReadElementContentAsString();
                            }
                            paramsRead[3] = true;
                        }
                        else if (!paramsRead[4] && ((object) Reader.LocalName == (object)id69_SentOn && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                            {
                                o.@SentOn = ToDateTime(Reader.ReadElementContentAsString());
                            }
                            paramsRead[4] = true;
                        }
                        else if (!paramsRead[5] && ((object) Reader.LocalName == (object)id70_Subject && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                            {
                                o.@Subject = Reader.ReadElementContentAsString();
                            }
                            paramsRead[5] = true;
                        }
                        else if (!paramsRead[6] && ((object) Reader.LocalName == (object)id71_wasRead && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                            {
                                o.@wasRead = System.Xml.XmlConvert.ToBoolean(Reader.ReadElementContentAsString());
                            }
                            paramsRead[6] = true;
                        }
                        else {
                            UnknownNode((object)o, @":Sender, :Recepients, :Msg, :TimeSent, :SentOn, :Subject, :wasRead");
                        }
                    }
                    else {
                        UnknownNode((object)o, @":Sender, :Recepients, :Msg, :TimeSent, :SentOn, :Subject, :wasRead");
                    }
                    Reader.MoveToContent();
                    CheckReaderCount(ref whileIterations26, ref readerCount26);
                }
                ReadEndElement();
                return o;
            }

            global::DataLab.Data.Users.User Read22_User(bool isNullable, bool checkType, string defaultNamespace = null) {
                System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
                bool isNull = false;
                if (isNullable) isNull = ReadNull();
                if (checkType) {
                if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id8_User && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
                }
                else
                    throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
                }
                if (isNull) return null;
                global::DataLab.Data.Users.User o;
                o = new global::DataLab.Data.Users.User();
                if ((object)(o.@Mails) == null) o.@Mails = new global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Users.Message.Mail>();
                global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Users.Message.Mail> a_3 = (global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Users.Message.Mail>)o.@Mails;
                if ((object)(o.@Friends) == null) o.@Friends = new global::System.Collections.ObjectModel.ObservableCollection<global::System.String>();
                global::System.Collections.ObjectModel.ObservableCollection<global::System.String> a_6 = (global::System.Collections.ObjectModel.ObservableCollection<global::System.String>)o.@Friends;
                bool[] paramsRead = new bool[7];
                while (Reader.MoveToNextAttribute()) {
                    if (!paramsRead[0] && ((object) Reader.LocalName == (object)id72_UserName && string.Equals(Reader.NamespaceURI, id2_Item))) {
                        o.@UserName = Reader.Value;
                        paramsRead[0] = true;
                    }
                    else if (!paramsRead[1] && ((object) Reader.LocalName == (object)id73_password && string.Equals(Reader.NamespaceURI, id2_Item))) {
                        o.@Password = Reader.Value;
                        paramsRead[1] = true;
                    }
                    else if (!IsXmlnsAttribute(Reader.Name)) {
                        UnknownNode((object)o, @":UserName, :password");
                    }
                }
                Reader.MoveToElement();
                if (Reader.IsEmptyElement) {
                    Reader.Skip();
                    return o;
                }
                Reader.ReadStartElement();
                Reader.MoveToContent();
                int whileIterations28 = 0;
                int readerCount28 = ReaderCount;
                while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                    if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                        if (!paramsRead[2] && ((object) Reader.LocalName == (object)id4_Plan && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                            o.@plan = Read20_Plan(false, true, defaultNamespace);
                            paramsRead[2] = true;
                        }
                        else if (((object) Reader.LocalName == (object)id74_Mails && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                            if (!ReadNull()) {
                                if ((object)(o.@Mails) == null) o.@Mails = new global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Users.Message.Mail>();
                                global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Users.Message.Mail> a_3_0 = (global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Users.Message.Mail>)o.@Mails;
                                if ((Reader.IsEmptyElement)) {
                                    Reader.Skip();
                                }
                                else {
                                    Reader.ReadStartElement();
                                    Reader.MoveToContent();
                                    int whileIterations29 = 0;
                                    int readerCount29 = ReaderCount;
                                    while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                                        if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                                            if (((object) Reader.LocalName == (object)id22_Mail && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                                if ((object)(a_3_0) == null) Reader.Skip(); else a_3_0.Add(Read15_Mail(true, true, defaultNamespace));
                                            }
                                            else {
                                                UnknownNode(null, @":Mail");
                                            }
                                        }
                                        else {
                                            UnknownNode(null, @":Mail");
                                        }
                                        Reader.MoveToContent();
                                        CheckReaderCount(ref whileIterations29, ref readerCount29);
                                    }
                                ReadEndElement();
                                }
                            }
                        }
                        else if (!paramsRead[4] && ((object) Reader.LocalName == (object)id75_LastDataSync && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                            {
                                o.@LastDataSync = ToDateTime(Reader.ReadElementContentAsString());
                            }
                            paramsRead[4] = true;
                        }
                        else if (!paramsRead[5] && ((object) Reader.LocalName == (object)id17_UserInfo && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                            o.@UserInfo = Read21_UserInfo(false, true, defaultNamespace);
                            paramsRead[5] = true;
                        }
                        else if (((object) Reader.LocalName == (object)id76_Friends && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                            if (!ReadNull()) {
                                if ((object)(o.@Friends) == null) o.@Friends = new global::System.Collections.ObjectModel.ObservableCollection<global::System.String>();
                                global::System.Collections.ObjectModel.ObservableCollection<global::System.String> a_6_0 = (global::System.Collections.ObjectModel.ObservableCollection<global::System.String>)o.@Friends;
                                if ((Reader.IsEmptyElement)) {
                                    Reader.Skip();
                                }
                                else {
                                    Reader.ReadStartElement();
                                    Reader.MoveToContent();
                                    int whileIterations30 = 0;
                                    int readerCount30 = ReaderCount;
                                    while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                                        if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                                            if (((object) Reader.LocalName == (object)id53_Friend && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                                if (ReadNull()) {
                                                    a_6_0.Add(null);
                                                }
                                                else {
                                                    a_6_0.Add(Reader.ReadElementContentAsString());
                                                }
                                            }
                                            else {
                                                UnknownNode(null, @":Friend");
                                            }
                                        }
                                        else {
                                            UnknownNode(null, @":Friend");
                                        }
                                        Reader.MoveToContent();
                                        CheckReaderCount(ref whileIterations30, ref readerCount30);
                                    }
                                ReadEndElement();
                                }
                            }
                        }
                        else {
                            UnknownNode((object)o, @":Plan, :Mails, :LastDataSync, :UserInfo, :Friends");
                        }
                    }
                    else {
                        UnknownNode((object)o, @":Plan, :Mails, :LastDataSync, :UserInfo, :Friends");
                    }
                    Reader.MoveToContent();
                    CheckReaderCount(ref whileIterations28, ref readerCount28);
                }
                ReadEndElement();
                return o;
            }

            global::DataLab.Data.Users.UserInfo Read21_UserInfo(bool isNullable, bool checkType, string defaultNamespace = null) {
                System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
                bool isNull = false;
                if (isNullable) isNull = ReadNull();
                if (checkType) {
                if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id17_UserInfo && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
                }
                else
                    throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
                }
                if (isNull) return null;
                global::DataLab.Data.Users.UserInfo o;
                o = new global::DataLab.Data.Users.UserInfo();
                if ((object)(o.@Hobbies) == null) o.@Hobbies = new global::System.Collections.ObjectModel.ObservableCollection<global::System.String>();
                global::System.Collections.ObjectModel.ObservableCollection<global::System.String> a_3 = (global::System.Collections.ObjectModel.ObservableCollection<global::System.String>)o.@Hobbies;
                if ((object)(o.@FriendNames) == null) o.@FriendNames = new global::System.Collections.Generic.List<global::System.String>();
                global::System.Collections.Generic.List<global::System.String> a_7 = (global::System.Collections.Generic.List<global::System.String>)o.@FriendNames;
                bool[] paramsRead = new bool[8];
                while (Reader.MoveToNextAttribute()) {
                    if (!paramsRead[0] && ((object) Reader.LocalName == (object)id77_FirstName && string.Equals(Reader.NamespaceURI, id2_Item))) {
                        o.@FirstName = Reader.Value;
                        paramsRead[0] = true;
                    }
                    else if (!paramsRead[1] && ((object) Reader.LocalName == (object)id78_LastName && string.Equals(Reader.NamespaceURI, id2_Item))) {
                        o.@LastName = Reader.Value;
                        paramsRead[1] = true;
                    }
                    else if (!paramsRead[2] && ((object) Reader.LocalName == (object)id79_BirthDay && string.Equals(Reader.NamespaceURI, id2_Item))) {
                        o.@BirthDay = ToDateTime(Reader.Value);
                        paramsRead[2] = true;
                    }
                    else if (!IsXmlnsAttribute(Reader.Name)) {
                        UnknownNode((object)o, @":FirstName, :LastName, :BirthDay");
                    }
                }
                Reader.MoveToElement();
                if (Reader.IsEmptyElement) {
                    Reader.Skip();
                    return o;
                }
                Reader.ReadStartElement();
                Reader.MoveToContent();
                int whileIterations31 = 0;
                int readerCount31 = ReaderCount;
                while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                    if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                        if (((object) Reader.LocalName == (object)id80_Hobbies && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                            if (!ReadNull()) {
                                if ((object)(o.@Hobbies) == null) o.@Hobbies = new global::System.Collections.ObjectModel.ObservableCollection<global::System.String>();
                                global::System.Collections.ObjectModel.ObservableCollection<global::System.String> a_3_0 = (global::System.Collections.ObjectModel.ObservableCollection<global::System.String>)o.@Hobbies;
                                if ((Reader.IsEmptyElement)) {
                                    Reader.Skip();
                                }
                                else {
                                    Reader.ReadStartElement();
                                    Reader.MoveToContent();
                                    int whileIterations32 = 0;
                                    int readerCount32 = ReaderCount;
                                    while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                                        if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                                            if (((object) Reader.LocalName == (object)id51_Hobbie && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                                if (ReadNull()) {
                                                    a_3_0.Add(null);
                                                }
                                                else {
                                                    a_3_0.Add(Reader.ReadElementContentAsString());
                                                }
                                            }
                                            else {
                                                UnknownNode(null, @":Hobbie");
                                            }
                                        }
                                        else {
                                            UnknownNode(null, @":Hobbie");
                                        }
                                        Reader.MoveToContent();
                                        CheckReaderCount(ref whileIterations32, ref readerCount32);
                                    }
                                ReadEndElement();
                                }
                            }
                        }
                        else if (!paramsRead[4] && ((object) Reader.LocalName == (object)id81_BirthCountry && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                            {
                                o.@BirthCountry = Reader.ReadElementContentAsString();
                            }
                            paramsRead[4] = true;
                        }
                        else if (!paramsRead[5] && ((object) Reader.LocalName == (object)id82_CountryOfLiving && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                            {
                                o.@CountryOfLiving = Reader.ReadElementContentAsString();
                            }
                            paramsRead[5] = true;
                        }
                        else if (!paramsRead[6] && ((object) Reader.LocalName == (object)id83_Language && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                            {
                                o.@Language = Reader.ReadElementContentAsString();
                            }
                            paramsRead[6] = true;
                        }
                        else if (((object) Reader.LocalName == (object)id84_FriendNames && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                            if (!ReadNull()) {
                                if ((object)(o.@FriendNames) == null) o.@FriendNames = new global::System.Collections.Generic.List<global::System.String>();
                                global::System.Collections.Generic.List<global::System.String> a_7_0 = (global::System.Collections.Generic.List<global::System.String>)o.@FriendNames;
                                if ((Reader.IsEmptyElement)) {
                                    Reader.Skip();
                                }
                                else {
                                    Reader.ReadStartElement();
                                    Reader.MoveToContent();
                                    int whileIterations33 = 0;
                                    int readerCount33 = ReaderCount;
                                    while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                                        if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                                            if (((object) Reader.LocalName == (object)id45_string && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                                if (ReadNull()) {
                                                    a_7_0.Add(null);
                                                }
                                                else {
                                                    a_7_0.Add(Reader.ReadElementContentAsString());
                                                }
                                            }
                                            else {
                                                UnknownNode(null, @":string");
                                            }
                                        }
                                        else {
                                            UnknownNode(null, @":string");
                                        }
                                        Reader.MoveToContent();
                                        CheckReaderCount(ref whileIterations33, ref readerCount33);
                                    }
                                ReadEndElement();
                                }
                            }
                        }
                        else {
                            UnknownNode((object)o, @":Hobbies, :BirthCountry, :CountryOfLiving, :Language, :FriendNames");
                        }
                    }
                    else {
                        UnknownNode((object)o, @":Hobbies, :BirthCountry, :CountryOfLiving, :Language, :FriendNames");
                    }
                    Reader.MoveToContent();
                    CheckReaderCount(ref whileIterations31, ref readerCount31);
                }
                ReadEndElement();
                return o;
            }

            global::DataLab.Data.Planning.Plan Read20_Plan(bool isNullable, bool checkType, string defaultNamespace = null) {
                System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
                bool isNull = false;
                if (isNullable) isNull = ReadNull();
                if (checkType) {
                if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id4_Plan && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
                }
                else
                    throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
                }
                if (isNull) return null;
                global::DataLab.Data.Planning.Plan o;
                o = new global::DataLab.Data.Planning.Plan();
                if ((object)(o.@Activities) == null) o.@Activities = new global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Planning.Activity>();
                global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Planning.Activity> a_0 = (global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Planning.Activity>)o.@Activities;
                if ((object)(o.@rpi) == null) o.@rpi = new global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Planning.RepeatingPlanningItem>();
                global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Planning.RepeatingPlanningItem> a_1 = (global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Planning.RepeatingPlanningItem>)o.@rpi;
                if ((object)(o.@Reflections) == null) o.@Reflections = new global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Planning.Reflection>();
                global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Planning.Reflection> a_2 = (global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Planning.Reflection>)o.@Reflections;
                if ((object)(o.@Diaries) == null) o.@Diaries = new global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Planning.Diary>();
                global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Planning.Diary> a_3 = (global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Planning.Diary>)o.@Diaries;
                if ((object)(o.@Mails) == null) o.@Mails = new global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Users.Message.Mail>();
                global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Users.Message.Mail> a_4 = (global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Users.Message.Mail>)o.@Mails;
                if ((object)(o.@CijferLijsten) == null) o.@CijferLijsten = new global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Cijfers.CijferLijst>();
                global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Cijfers.CijferLijst> a_5 = (global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Cijfers.CijferLijst>)o.@CijferLijsten;
                bool[] paramsRead = new bool[6];
                while (Reader.MoveToNextAttribute()) {
                    if (!IsXmlnsAttribute(Reader.Name)) {
                        UnknownNode((object)o);
                    }
                }
                Reader.MoveToElement();
                if (Reader.IsEmptyElement) {
                    Reader.Skip();
                    return o;
                }
                Reader.ReadStartElement();
                Reader.MoveToContent();
                int whileIterations34 = 0;
                int readerCount34 = ReaderCount;
                while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                    if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                        if (((object) Reader.LocalName == (object)id85_Activities && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                            if (!ReadNull()) {
                                if ((object)(o.@Activities) == null) o.@Activities = new global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Planning.Activity>();
                                global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Planning.Activity> a_0_0 = (global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Planning.Activity>)o.@Activities;
                                if ((Reader.IsEmptyElement)) {
                                    Reader.Skip();
                                }
                                else {
                                    Reader.ReadStartElement();
                                    Reader.MoveToContent();
                                    int whileIterations35 = 0;
                                    int readerCount35 = ReaderCount;
                                    while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                                        if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                                            if (((object) Reader.LocalName == (object)id30_Activity && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                                if ((object)(a_0_0) == null) Reader.Skip(); else a_0_0.Add(Read6_Activity(true, true, defaultNamespace));
                                            }
                                            else {
                                                UnknownNode(null, @":Activity");
                                            }
                                        }
                                        else {
                                            UnknownNode(null, @":Activity");
                                        }
                                        Reader.MoveToContent();
                                        CheckReaderCount(ref whileIterations35, ref readerCount35);
                                    }
                                ReadEndElement();
                                }
                            }
                        }
                        else if (((object) Reader.LocalName == (object)id86_rpi && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                            if (!ReadNull()) {
                                if ((object)(o.@rpi) == null) o.@rpi = new global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Planning.RepeatingPlanningItem>();
                                global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Planning.RepeatingPlanningItem> a_1_0 = (global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Planning.RepeatingPlanningItem>)o.@rpi;
                                if ((Reader.IsEmptyElement)) {
                                    Reader.Skip();
                                }
                                else {
                                    Reader.ReadStartElement();
                                    Reader.MoveToContent();
                                    int whileIterations36 = 0;
                                    int readerCount36 = ReaderCount;
                                    while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                                        if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                                            if (((object) Reader.LocalName == (object)id29_RepeatingPlanningItem && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                                if ((object)(a_1_0) == null) Reader.Skip(); else a_1_0.Add(Read9_RepeatingPlanningItem(true, true, defaultNamespace));
                                            }
                                            else {
                                                UnknownNode(null, @":RepeatingPlanningItem");
                                            }
                                        }
                                        else {
                                            UnknownNode(null, @":RepeatingPlanningItem");
                                        }
                                        Reader.MoveToContent();
                                        CheckReaderCount(ref whileIterations36, ref readerCount36);
                                    }
                                ReadEndElement();
                                }
                            }
                        }
                        else if (((object) Reader.LocalName == (object)id87_Reflections && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                            if (!ReadNull()) {
                                if ((object)(o.@Reflections) == null) o.@Reflections = new global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Planning.Reflection>();
                                global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Planning.Reflection> a_2_0 = (global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Planning.Reflection>)o.@Reflections;
                                if ((Reader.IsEmptyElement)) {
                                    Reader.Skip();
                                }
                                else {
                                    Reader.ReadStartElement();
                                    Reader.MoveToContent();
                                    int whileIterations37 = 0;
                                    int readerCount37 = ReaderCount;
                                    while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                                        if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                                            if (((object) Reader.LocalName == (object)id28_Reflection && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                                if ((object)(a_2_0) == null) Reader.Skip(); else a_2_0.Add(Read12_Reflection(true, true, defaultNamespace));
                                            }
                                            else {
                                                UnknownNode(null, @":Reflection");
                                            }
                                        }
                                        else {
                                            UnknownNode(null, @":Reflection");
                                        }
                                        Reader.MoveToContent();
                                        CheckReaderCount(ref whileIterations37, ref readerCount37);
                                    }
                                ReadEndElement();
                                }
                            }
                        }
                        else if (((object) Reader.LocalName == (object)id88_Diaries && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                            if (!ReadNull()) {
                                if ((object)(o.@Diaries) == null) o.@Diaries = new global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Planning.Diary>();
                                global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Planning.Diary> a_3_0 = (global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Planning.Diary>)o.@Diaries;
                                if ((Reader.IsEmptyElement)) {
                                    Reader.Skip();
                                }
                                else {
                                    Reader.ReadStartElement();
                                    Reader.MoveToContent();
                                    int whileIterations38 = 0;
                                    int readerCount38 = ReaderCount;
                                    while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                                        if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                                            if (((object) Reader.LocalName == (object)id23_Diary && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                                if ((object)(a_3_0) == null) Reader.Skip(); else a_3_0.Add(Read13_Diary(true, true, defaultNamespace));
                                            }
                                            else {
                                                UnknownNode(null, @":Diary");
                                            }
                                        }
                                        else {
                                            UnknownNode(null, @":Diary");
                                        }
                                        Reader.MoveToContent();
                                        CheckReaderCount(ref whileIterations38, ref readerCount38);
                                    }
                                ReadEndElement();
                                }
                            }
                        }
                        else if (((object) Reader.LocalName == (object)id74_Mails && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                            if (!ReadNull()) {
                                if ((object)(o.@Mails) == null) o.@Mails = new global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Users.Message.Mail>();
                                global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Users.Message.Mail> a_4_0 = (global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Users.Message.Mail>)o.@Mails;
                                if ((Reader.IsEmptyElement)) {
                                    Reader.Skip();
                                }
                                else {
                                    Reader.ReadStartElement();
                                    Reader.MoveToContent();
                                    int whileIterations39 = 0;
                                    int readerCount39 = ReaderCount;
                                    while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                                        if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                                            if (((object) Reader.LocalName == (object)id22_Mail && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                                if ((object)(a_4_0) == null) Reader.Skip(); else a_4_0.Add(Read15_Mail(true, true, defaultNamespace));
                                            }
                                            else {
                                                UnknownNode(null, @":Mail");
                                            }
                                        }
                                        else {
                                            UnknownNode(null, @":Mail");
                                        }
                                        Reader.MoveToContent();
                                        CheckReaderCount(ref whileIterations39, ref readerCount39);
                                    }
                                ReadEndElement();
                                }
                            }
                        }
                        else if (((object) Reader.LocalName == (object)id89_CijferLijsten && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                            if (!ReadNull()) {
                                if ((object)(o.@CijferLijsten) == null) o.@CijferLijsten = new global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Cijfers.CijferLijst>();
                                global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Cijfers.CijferLijst> a_5_0 = (global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Cijfers.CijferLijst>)o.@CijferLijsten;
                                if ((Reader.IsEmptyElement)) {
                                    Reader.Skip();
                                }
                                else {
                                    Reader.ReadStartElement();
                                    Reader.MoveToContent();
                                    int whileIterations40 = 0;
                                    int readerCount40 = ReaderCount;
                                    while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                                        if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                                            if (((object) Reader.LocalName == (object)id27_CijferLijst && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                                if ((object)(a_5_0) == null) Reader.Skip(); else a_5_0.Add(Read19_CijferLijst(true, true, defaultNamespace));
                                            }
                                            else {
                                                UnknownNode(null, @":CijferLijst");
                                            }
                                        }
                                        else {
                                            UnknownNode(null, @":CijferLijst");
                                        }
                                        Reader.MoveToContent();
                                        CheckReaderCount(ref whileIterations40, ref readerCount40);
                                    }
                                ReadEndElement();
                                }
                            }
                        }
                        else {
                            UnknownNode((object)o, @":Activities, :rpi, :Reflections, :Diaries, :Mails, :CijferLijsten");
                        }
                    }
                    else {
                        UnknownNode((object)o, @":Activities, :rpi, :Reflections, :Diaries, :Mails, :CijferLijsten");
                    }
                    Reader.MoveToContent();
                    CheckReaderCount(ref whileIterations34, ref readerCount34);
                }
                ReadEndElement();
                return o;
            }

            global::DataLab.Data.Cijfers.CijferLijst Read19_CijferLijst(bool isNullable, bool checkType, string defaultNamespace = null) {
                System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
                bool isNull = false;
                if (isNullable) isNull = ReadNull();
                if (checkType) {
                if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id27_CijferLijst && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
                }
                else
                    throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
                }
                if (isNull) return null;
                global::DataLab.Data.Cijfers.CijferLijst o;
                o = new global::DataLab.Data.Cijfers.CijferLijst();
                if ((object)(o.@Periodes) == null) o.@Periodes = new global::System.Collections.Generic.List<global::DataLab.Data.Cijfers.CijferPeriode>();
                global::System.Collections.Generic.List<global::DataLab.Data.Cijfers.CijferPeriode> a_3 = (global::System.Collections.Generic.List<global::DataLab.Data.Cijfers.CijferPeriode>)o.@Periodes;
                bool[] paramsRead = new bool[4];
                while (Reader.MoveToNextAttribute()) {
                    if (!paramsRead[0] && ((object) Reader.LocalName == (object)id63_Name && string.Equals(Reader.NamespaceURI, id2_Item))) {
                        o.@Name = Reader.Value;
                        paramsRead[0] = true;
                    }
                    else if (!paramsRead[1] && ((object) Reader.LocalName == (object)id90_Silent && string.Equals(Reader.NamespaceURI, id2_Item))) {
                        o.@Silent = System.Xml.XmlConvert.ToBoolean(Reader.Value);
                        paramsRead[1] = true;
                    }
                    else if (!paramsRead[2] && ((object) Reader.LocalName == (object)id91_Item && string.Equals(Reader.NamespaceURI, id2_Item))) {
                        o.@MinutesToAlertBeforeActualAlarm = System.Xml.XmlConvert.ToInt32(Reader.Value);
                        paramsRead[2] = true;
                    }
                    else if (!IsXmlnsAttribute(Reader.Name)) {
                        UnknownNode((object)o, @":Name, :Silent, :MinutesToAlertBeforeActualAlarm");
                    }
                }
                Reader.MoveToElement();
                if (Reader.IsEmptyElement) {
                    Reader.Skip();
                    return o;
                }
                Reader.ReadStartElement();
                Reader.MoveToContent();
                int whileIterations41 = 0;
                int readerCount41 = ReaderCount;
                while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                    if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                        if (((object) Reader.LocalName == (object)id92_Periodes && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                            if (!ReadNull()) {
                                if ((object)(o.@Periodes) == null) o.@Periodes = new global::System.Collections.Generic.List<global::DataLab.Data.Cijfers.CijferPeriode>();
                                global::System.Collections.Generic.List<global::DataLab.Data.Cijfers.CijferPeriode> a_3_0 = (global::System.Collections.Generic.List<global::DataLab.Data.Cijfers.CijferPeriode>)o.@Periodes;
                                if ((Reader.IsEmptyElement)) {
                                    Reader.Skip();
                                }
                                else {
                                    Reader.ReadStartElement();
                                    Reader.MoveToContent();
                                    int whileIterations42 = 0;
                                    int readerCount42 = ReaderCount;
                                    while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                                        if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                                            if (((object) Reader.LocalName == (object)id18_CijferPeriode && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                                if ((object)(a_3_0) == null) Reader.Skip(); else a_3_0.Add(Read18_CijferPeriode(true, true, defaultNamespace));
                                            }
                                            else {
                                                UnknownNode(null, @":CijferPeriode");
                                            }
                                        }
                                        else {
                                            UnknownNode(null, @":CijferPeriode");
                                        }
                                        Reader.MoveToContent();
                                        CheckReaderCount(ref whileIterations42, ref readerCount42);
                                    }
                                ReadEndElement();
                                }
                            }
                        }
                        else {
                            UnknownNode((object)o, @":Periodes");
                        }
                    }
                    else {
                        UnknownNode((object)o, @":Periodes");
                    }
                    Reader.MoveToContent();
                    CheckReaderCount(ref whileIterations41, ref readerCount41);
                }
                ReadEndElement();
                return o;
            }

            global::DataLab.Data.Cijfers.CijferPeriode Read18_CijferPeriode(bool isNullable, bool checkType, string defaultNamespace = null) {
                System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
                bool isNull = false;
                if (isNullable) isNull = ReadNull();
                if (checkType) {
                if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id18_CijferPeriode && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
                }
                else
                    throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
                }
                if (isNull) return null;
                global::DataLab.Data.Cijfers.CijferPeriode o;
                o = new global::DataLab.Data.Cijfers.CijferPeriode();
                if ((object)(o.@ToComplete) == null) o.@ToComplete = new global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Cijfers.CijferTaak.Cijfertaak>();
                global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Cijfers.CijferTaak.Cijfertaak> a_1 = (global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Cijfers.CijferTaak.Cijfertaak>)o.@ToComplete;
                bool[] paramsRead = new bool[4];
                while (Reader.MoveToNextAttribute()) {
                    if (!IsXmlnsAttribute(Reader.Name)) {
                        UnknownNode((object)o);
                    }
                }
                Reader.MoveToElement();
                if (Reader.IsEmptyElement) {
                    Reader.Skip();
                    return o;
                }
                Reader.ReadStartElement();
                Reader.MoveToContent();
                int whileIterations43 = 0;
                int readerCount43 = ReaderCount;
                while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                    if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                        if (!paramsRead[0] && ((object) Reader.LocalName == (object)id63_Name && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                            {
                                o.@Name = Reader.ReadElementContentAsString();
                            }
                            paramsRead[0] = true;
                        }
                        else if (((object) Reader.LocalName == (object)id93_ToComplete && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                            if (!ReadNull()) {
                                if ((object)(o.@ToComplete) == null) o.@ToComplete = new global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Cijfers.CijferTaak.Cijfertaak>();
                                global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Cijfers.CijferTaak.Cijfertaak> a_1_0 = (global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Cijfers.CijferTaak.Cijfertaak>)o.@ToComplete;
                                if ((Reader.IsEmptyElement)) {
                                    Reader.Skip();
                                }
                                else {
                                    Reader.ReadStartElement();
                                    Reader.MoveToContent();
                                    int whileIterations44 = 0;
                                    int readerCount44 = ReaderCount;
                                    while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                                        if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                                            if (((object) Reader.LocalName == (object)id19_Cijfertaak && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                                if ((object)(a_1_0) == null) Reader.Skip(); else a_1_0.Add(Read17_Cijfertaak(true, true, defaultNamespace));
                                            }
                                            else {
                                                UnknownNode(null, @":Cijfertaak");
                                            }
                                        }
                                        else {
                                            UnknownNode(null, @":Cijfertaak");
                                        }
                                        Reader.MoveToContent();
                                        CheckReaderCount(ref whileIterations44, ref readerCount44);
                                    }
                                ReadEndElement();
                                }
                            }
                        }
                        else if (!paramsRead[2] && ((object) Reader.LocalName == (object)id94_Start && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                            {
                                o.@Start = ToDateTime(Reader.ReadElementContentAsString());
                            }
                            paramsRead[2] = true;
                        }
                        else if (!paramsRead[3] && ((object) Reader.LocalName == (object)id95_End && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                            {
                                o.@End = ToDateTime(Reader.ReadElementContentAsString());
                            }
                            paramsRead[3] = true;
                        }
                        else {
                            UnknownNode((object)o, @":Name, :ToComplete, :Start, :End");
                        }
                    }
                    else {
                        UnknownNode((object)o, @":Name, :ToComplete, :Start, :End");
                    }
                    Reader.MoveToContent();
                    CheckReaderCount(ref whileIterations43, ref readerCount43);
                }
                ReadEndElement();
                return o;
            }

            global::DataLab.Data.Cijfers.CijferTaak.Cijfertaak Read17_Cijfertaak(bool isNullable, bool checkType, string defaultNamespace = null) {
                System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
                bool isNull = false;
                if (isNullable) isNull = ReadNull();
                if (checkType) {
                if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id19_Cijfertaak && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
                }
                else
                    throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
                }
                if (isNull) return null;
                global::DataLab.Data.Cijfers.CijferTaak.Cijfertaak o;
                o = new global::DataLab.Data.Cijfers.CijferTaak.Cijfertaak();
                if ((object)(o.@Attempts) == null) o.@Attempts = new global::System.Collections.Generic.List<global::DataLab.Data.Cijfers.CijferTaak.Cijfer>();
                global::System.Collections.Generic.List<global::DataLab.Data.Cijfers.CijferTaak.Cijfer> a_1 = (global::System.Collections.Generic.List<global::DataLab.Data.Cijfers.CijferTaak.Cijfer>)o.@Attempts;
                bool[] paramsRead = new bool[4];
                while (Reader.MoveToNextAttribute()) {
                    if (!IsXmlnsAttribute(Reader.Name)) {
                        UnknownNode((object)o);
                    }
                }
                Reader.MoveToElement();
                if (Reader.IsEmptyElement) {
                    Reader.Skip();
                    return o;
                }
                Reader.ReadStartElement();
                Reader.MoveToContent();
                int whileIterations45 = 0;
                int readerCount45 = ReaderCount;
                while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                    if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                        if (!paramsRead[0] && ((object) Reader.LocalName == (object)id63_Name && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                            {
                                o.@Name = Reader.ReadElementContentAsString();
                            }
                            paramsRead[0] = true;
                        }
                        else if (((object) Reader.LocalName == (object)id96_Attempts && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                            if (!ReadNull()) {
                                if ((object)(o.@Attempts) == null) o.@Attempts = new global::System.Collections.Generic.List<global::DataLab.Data.Cijfers.CijferTaak.Cijfer>();
                                global::System.Collections.Generic.List<global::DataLab.Data.Cijfers.CijferTaak.Cijfer> a_1_0 = (global::System.Collections.Generic.List<global::DataLab.Data.Cijfers.CijferTaak.Cijfer>)o.@Attempts;
                                if ((Reader.IsEmptyElement)) {
                                    Reader.Skip();
                                }
                                else {
                                    Reader.ReadStartElement();
                                    Reader.MoveToContent();
                                    int whileIterations46 = 0;
                                    int readerCount46 = ReaderCount;
                                    while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                                        if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                                            if (((object) Reader.LocalName == (object)id20_Cijfer && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                                if ((object)(a_1_0) == null) Reader.Skip(); else a_1_0.Add(Read16_Cijfer(true, true, defaultNamespace));
                                            }
                                            else {
                                                UnknownNode(null, @":Cijfer");
                                            }
                                        }
                                        else {
                                            UnknownNode(null, @":Cijfer");
                                        }
                                        Reader.MoveToContent();
                                        CheckReaderCount(ref whileIterations46, ref readerCount46);
                                    }
                                ReadEndElement();
                                }
                            }
                        }
                        else if (!paramsRead[2] && ((object) Reader.LocalName == (object)id97_MaxTeBehalenPunt && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                            {
                                o.@MaxTeBehalenPunt = System.Xml.XmlConvert.ToDouble(Reader.ReadElementContentAsString());
                            }
                            paramsRead[2] = true;
                        }
                        else if (!paramsRead[3] && ((object) Reader.LocalName == (object)id98_MinTeBehalenPunt && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                            {
                                o.@MinTeBehalenPunt = System.Xml.XmlConvert.ToDouble(Reader.ReadElementContentAsString());
                            }
                            paramsRead[3] = true;
                        }
                        else {
                            UnknownNode((object)o, @":Name, :Attempts, :MaxTeBehalenPunt, :MinTeBehalenPunt");
                        }
                    }
                    else {
                        UnknownNode((object)o, @":Name, :Attempts, :MaxTeBehalenPunt, :MinTeBehalenPunt");
                    }
                    Reader.MoveToContent();
                    CheckReaderCount(ref whileIterations45, ref readerCount45);
                }
                ReadEndElement();
                return o;
            }

            global::DataLab.Data.Cijfers.CijferTaak.Cijfer Read16_Cijfer(bool isNullable, bool checkType, string defaultNamespace = null) {
                System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
                bool isNull = false;
                if (isNullable) isNull = ReadNull();
                if (checkType) {
                if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id20_Cijfer && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
                }
                else
                    throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
                }
                if (isNull) return null;
                global::DataLab.Data.Cijfers.CijferTaak.Cijfer o;
                o = new global::DataLab.Data.Cijfers.CijferTaak.Cijfer();
                bool[] paramsRead = new bool[1];
                while (Reader.MoveToNextAttribute()) {
                    if (!IsXmlnsAttribute(Reader.Name)) {
                        UnknownNode((object)o);
                    }
                }
                Reader.MoveToElement();
                if (Reader.IsEmptyElement) {
                    Reader.Skip();
                    return o;
                }
                Reader.ReadStartElement();
                Reader.MoveToContent();
                int whileIterations47 = 0;
                int readerCount47 = ReaderCount;
                while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                    if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                        if (!paramsRead[0] && ((object) Reader.LocalName == (object)id99_Punt && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                            {
                                o.@Punt = System.Xml.XmlConvert.ToInt32(Reader.ReadElementContentAsString());
                            }
                            paramsRead[0] = true;
                        }
                        else {
                            UnknownNode((object)o, @":Punt");
                        }
                    }
                    else {
                        UnknownNode((object)o, @":Punt");
                    }
                    Reader.MoveToContent();
                    CheckReaderCount(ref whileIterations47, ref readerCount47);
                }
                ReadEndElement();
                return o;
            }

            global::DataLab.Data.Planning.Diary Read13_Diary(bool isNullable, bool checkType, string defaultNamespace = null) {
                System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
                bool isNull = false;
                if (isNullable) isNull = ReadNull();
                if (checkType) {
                if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id23_Diary && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
                }
                else
                    throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
                }
                if (isNull) return null;
                global::DataLab.Data.Planning.Diary o;
                o = new global::DataLab.Data.Planning.Diary();
                // Non-public setter. if ((object)(o.@PlanningItems) == null) o.@PlanningItems = new global::System.Collections.Generic.List<global::DataLab.Data.Planning.PlanningItem>();
                global::System.Collections.Generic.List<global::DataLab.Data.Planning.PlanningItem> a_3 = (global::System.Collections.Generic.List<global::DataLab.Data.Planning.PlanningItem>)o.@PlanningItems;
                bool[] paramsRead = new bool[4];
                while (Reader.MoveToNextAttribute()) {
                    if (!IsXmlnsAttribute(Reader.Name)) {
                        UnknownNode((object)o);
                    }
                }
                Reader.MoveToElement();
                if (Reader.IsEmptyElement) {
                    Reader.Skip();
                    return o;
                }
                Reader.ReadStartElement();
                Reader.MoveToContent();
                int whileIterations48 = 0;
                int readerCount48 = ReaderCount;
                while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                    if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                        if (!paramsRead[0] && ((object) Reader.LocalName == (object)id63_Name && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                            {
                                o.@Name = Reader.ReadElementContentAsString();
                            }
                            paramsRead[0] = true;
                        }
                        else if (!paramsRead[1] && ((object) Reader.LocalName == (object)id100_StartTime && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                            {
                                o.@StartTime = ToDateTime(Reader.ReadElementContentAsString());
                            }
                            paramsRead[1] = true;
                        }
                        else if (!paramsRead[2] && ((object) Reader.LocalName == (object)id101_EndTime && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                            {
                                o.@EndTime = ToDateTime(Reader.ReadElementContentAsString());
                            }
                            paramsRead[2] = true;
                        }
                        else if (((object) Reader.LocalName == (object)id102_PlanningItems && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                            if (!ReadNull()) {
                                // Non-public setter. if ((object)(o.@PlanningItems) == null) o.@PlanningItems = new global::System.Collections.Generic.List<global::DataLab.Data.Planning.PlanningItem>();
                                global::System.Collections.Generic.List<global::DataLab.Data.Planning.PlanningItem> a_3_0 = (global::System.Collections.Generic.List<global::DataLab.Data.Planning.PlanningItem>)o.@PlanningItems;
                                if ((Reader.IsEmptyElement)) {
                                    Reader.Skip();
                                }
                                else {
                                    Reader.ReadStartElement();
                                    Reader.MoveToContent();
                                    int whileIterations49 = 0;
                                    int readerCount49 = ReaderCount;
                                    while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                                        if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                                            if (((object) Reader.LocalName == (object)id26_PlanningItem && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                                if ((object)(a_3_0) == null) Reader.Skip(); else a_3_0.Add(Read4_PlanningItem(true, true, defaultNamespace));
                                            }
                                            else {
                                                UnknownNode(null, @":PlanningItem");
                                            }
                                        }
                                        else {
                                            UnknownNode(null, @":PlanningItem");
                                        }
                                        Reader.MoveToContent();
                                        CheckReaderCount(ref whileIterations49, ref readerCount49);
                                    }
                                ReadEndElement();
                                }
                            }
                        }
                        else {
                            UnknownNode((object)o, @":Name, :StartTime, :EndTime, :PlanningItems");
                        }
                    }
                    else {
                        UnknownNode((object)o, @":Name, :StartTime, :EndTime, :PlanningItems");
                    }
                    Reader.MoveToContent();
                    CheckReaderCount(ref whileIterations48, ref readerCount48);
                }
                ReadEndElement();
                return o;
            }

            global::DataLab.Data.Planning.PlanningItem Read4_PlanningItem(bool isNullable, bool checkType, string defaultNamespace = null) {
                System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
                bool isNull = false;
                if (isNullable) isNull = ReadNull();
                if (checkType) {
                if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id26_PlanningItem && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
                }
                else if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id27_CijferLijst && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item)))
                    return Read19_CijferLijst(isNullable, false, defaultNamespace);
                else if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id28_Reflection && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item)))
                    return Read12_Reflection(isNullable, false, defaultNamespace);
                else if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id29_RepeatingPlanningItem && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item)))
                    return Read9_RepeatingPlanningItem(isNullable, false, defaultNamespace);
                else if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id30_Activity && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item)))
                    return Read6_Activity(isNullable, false, defaultNamespace);
                else
                    throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
                }
                if (isNull) return null;
                global::DataLab.Data.Planning.PlanningItem o;
                o = new global::DataLab.Data.Planning.PlanningItem();
                bool[] paramsRead = new bool[3];
                while (Reader.MoveToNextAttribute()) {
                    if (!paramsRead[0] && ((object) Reader.LocalName == (object)id63_Name && string.Equals(Reader.NamespaceURI, id2_Item))) {
                        o.@Name = Reader.Value;
                        paramsRead[0] = true;
                    }
                    else if (!paramsRead[1] && ((object) Reader.LocalName == (object)id90_Silent && string.Equals(Reader.NamespaceURI, id2_Item))) {
                        o.@Silent = System.Xml.XmlConvert.ToBoolean(Reader.Value);
                        paramsRead[1] = true;
                    }
                    else if (!paramsRead[2] && ((object) Reader.LocalName == (object)id91_Item && string.Equals(Reader.NamespaceURI, id2_Item))) {
                        o.@MinutesToAlertBeforeActualAlarm = System.Xml.XmlConvert.ToInt32(Reader.Value);
                        paramsRead[2] = true;
                    }
                    else if (!IsXmlnsAttribute(Reader.Name)) {
                        UnknownNode((object)o, @":Name, :Silent, :MinutesToAlertBeforeActualAlarm");
                    }
                }
                Reader.MoveToElement();
                if (Reader.IsEmptyElement) {
                    Reader.Skip();
                    return o;
                }
                Reader.ReadStartElement();
                Reader.MoveToContent();
                int whileIterations50 = 0;
                int readerCount50 = ReaderCount;
                while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                    if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                        UnknownNode((object)o, @"");
                    }
                    else {
                        UnknownNode((object)o, @"");
                    }
                    Reader.MoveToContent();
                    CheckReaderCount(ref whileIterations50, ref readerCount50);
                }
                ReadEndElement();
                return o;
            }

            global::DataLab.Data.Planning.Activity Read6_Activity(bool isNullable, bool checkType, string defaultNamespace = null) {
                System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
                bool isNull = false;
                if (isNullable) isNull = ReadNull();
                if (checkType) {
                if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id30_Activity && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
                }
                else
                    throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
                }
                if (isNull) return null;
                global::DataLab.Data.Planning.Activity o;
                o = new global::DataLab.Data.Planning.Activity();
                bool[] paramsRead = new bool[6];
                while (Reader.MoveToNextAttribute()) {
                    if (!paramsRead[0] && ((object) Reader.LocalName == (object)id63_Name && string.Equals(Reader.NamespaceURI, id2_Item))) {
                        o.@Name = Reader.Value;
                        paramsRead[0] = true;
                    }
                    else if (!paramsRead[1] && ((object) Reader.LocalName == (object)id90_Silent && string.Equals(Reader.NamespaceURI, id2_Item))) {
                        o.@Silent = System.Xml.XmlConvert.ToBoolean(Reader.Value);
                        paramsRead[1] = true;
                    }
                    else if (!paramsRead[2] && ((object) Reader.LocalName == (object)id91_Item && string.Equals(Reader.NamespaceURI, id2_Item))) {
                        o.@MinutesToAlertBeforeActualAlarm = System.Xml.XmlConvert.ToInt32(Reader.Value);
                        paramsRead[2] = true;
                    }
                    else if (!IsXmlnsAttribute(Reader.Name)) {
                        UnknownNode((object)o, @":Name, :Silent, :MinutesToAlertBeforeActualAlarm");
                    }
                }
                Reader.MoveToElement();
                if (Reader.IsEmptyElement) {
                    Reader.Skip();
                    return o;
                }
                Reader.ReadStartElement();
                Reader.MoveToContent();
                int whileIterations51 = 0;
                int readerCount51 = ReaderCount;
                while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                    if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                        if (!paramsRead[3] && ((object) Reader.LocalName == (object)id94_Start && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                            {
                                o.@Start = ToDateTime(Reader.ReadElementContentAsString());
                            }
                            paramsRead[3] = true;
                        }
                        else if (!paramsRead[4] && ((object) Reader.LocalName == (object)id103_basicgeoloc && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                            o.@basicgeoloc = Read5_BasicGeoposition(true, defaultNamespace);
                            paramsRead[4] = true;
                        }
                        else if (!paramsRead[5] && ((object) Reader.LocalName == (object)id95_End && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                            {
                                o.@End = ToDateTime(Reader.ReadElementContentAsString());
                            }
                            paramsRead[5] = true;
                        }
                        else {
                            UnknownNode((object)o, @":Start, :basicgeoloc, :End");
                        }
                    }
                    else {
                        UnknownNode((object)o, @":Start, :basicgeoloc, :End");
                    }
                    Reader.MoveToContent();
                    CheckReaderCount(ref whileIterations51, ref readerCount51);
                }
                ReadEndElement();
                return o;
            }

            global::Windows.Devices.Geolocation.BasicGeoposition Read5_BasicGeoposition(bool checkType, string defaultNamespace = null) {
                System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
                bool isNull = false;
                if (checkType) {
                if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id25_BasicGeoposition && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
                }
                else
                    throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
                }
                global::Windows.Devices.Geolocation.BasicGeoposition o;
                try {
                    o = (global::Windows.Devices.Geolocation.BasicGeoposition)ActivatorHelper.CreateInstance(typeof(global::Windows.Devices.Geolocation.BasicGeoposition));
                }
                catch (System.MissingMemberException) {
                    throw CreateInaccessibleConstructorException(@"global::Windows.Devices.Geolocation.BasicGeoposition");
                }
                catch (System.Security.SecurityException) {
                    throw CreateCtorHasSecurityException(@"global::Windows.Devices.Geolocation.BasicGeoposition");
                }
                bool[] paramsRead = new bool[3];
                while (Reader.MoveToNextAttribute()) {
                    if (!IsXmlnsAttribute(Reader.Name)) {
                        UnknownNode((object)o);
                    }
                }
                Reader.MoveToElement();
                if (Reader.IsEmptyElement) {
                    Reader.Skip();
                    return o;
                }
                Reader.ReadStartElement();
                Reader.MoveToContent();
                int whileIterations52 = 0;
                int readerCount52 = ReaderCount;
                while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                    if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                        if (!paramsRead[0] && ((object) Reader.LocalName == (object)id104_Latitude && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                            {
                                o.@Latitude = System.Xml.XmlConvert.ToDouble(Reader.ReadElementContentAsString());
                            }
                            paramsRead[0] = true;
                        }
                        else if (!paramsRead[1] && ((object) Reader.LocalName == (object)id105_Longitude && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                            {
                                o.@Longitude = System.Xml.XmlConvert.ToDouble(Reader.ReadElementContentAsString());
                            }
                            paramsRead[1] = true;
                        }
                        else if (!paramsRead[2] && ((object) Reader.LocalName == (object)id106_Altitude && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                            {
                                o.@Altitude = System.Xml.XmlConvert.ToDouble(Reader.ReadElementContentAsString());
                            }
                            paramsRead[2] = true;
                        }
                        else {
                            UnknownNode((object)o, @":Latitude, :Longitude, :Altitude");
                        }
                    }
                    else {
                        UnknownNode((object)o, @":Latitude, :Longitude, :Altitude");
                    }
                    Reader.MoveToContent();
                    CheckReaderCount(ref whileIterations52, ref readerCount52);
                }
                ReadEndElement();
                return o;
            }

            global::DataLab.Data.Planning.RepeatingPlanningItem Read9_RepeatingPlanningItem(bool isNullable, bool checkType, string defaultNamespace = null) {
                System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
                bool isNull = false;
                if (isNullable) isNull = ReadNull();
                if (checkType) {
                if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id29_RepeatingPlanningItem && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
                }
                else
                    throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
                }
                if (isNull) return null;
                global::DataLab.Data.Planning.RepeatingPlanningItem o;
                o = new global::DataLab.Data.Planning.RepeatingPlanningItem();
                if ((object)(o.@Days) == null) o.@Days = new global::System.Collections.Generic.List<global::System.DayOfWeek>();
                global::System.Collections.Generic.List<global::System.DayOfWeek> a_4 = (global::System.Collections.Generic.List<global::System.DayOfWeek>)o.@Days;
                bool[] paramsRead = new bool[6];
                while (Reader.MoveToNextAttribute()) {
                    if (!paramsRead[0] && ((object) Reader.LocalName == (object)id63_Name && string.Equals(Reader.NamespaceURI, id2_Item))) {
                        o.@Name = Reader.Value;
                        paramsRead[0] = true;
                    }
                    else if (!paramsRead[1] && ((object) Reader.LocalName == (object)id90_Silent && string.Equals(Reader.NamespaceURI, id2_Item))) {
                        o.@Silent = System.Xml.XmlConvert.ToBoolean(Reader.Value);
                        paramsRead[1] = true;
                    }
                    else if (!paramsRead[2] && ((object) Reader.LocalName == (object)id91_Item && string.Equals(Reader.NamespaceURI, id2_Item))) {
                        o.@MinutesToAlertBeforeActualAlarm = System.Xml.XmlConvert.ToInt32(Reader.Value);
                        paramsRead[2] = true;
                    }
                    else if (!IsXmlnsAttribute(Reader.Name)) {
                        UnknownNode((object)o, @":Name, :Silent, :MinutesToAlertBeforeActualAlarm");
                    }
                }
                Reader.MoveToElement();
                if (Reader.IsEmptyElement) {
                    Reader.Skip();
                    return o;
                }
                Reader.ReadStartElement();
                Reader.MoveToContent();
                int whileIterations53 = 0;
                int readerCount53 = ReaderCount;
                while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                    if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                        if (!paramsRead[3] && ((object) Reader.LocalName == (object)id107_Item && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                            o.@Item = Read4_PlanningItem(false, true, defaultNamespace);
                            paramsRead[3] = true;
                        }
                        else if (((object) Reader.LocalName == (object)id108_Days && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                            if (!ReadNull()) {
                                if ((object)(o.@Days) == null) o.@Days = new global::System.Collections.Generic.List<global::System.DayOfWeek>();
                                global::System.Collections.Generic.List<global::System.DayOfWeek> a_4_0 = (global::System.Collections.Generic.List<global::System.DayOfWeek>)o.@Days;
                                if ((Reader.IsEmptyElement)) {
                                    Reader.Skip();
                                }
                                else {
                                    Reader.ReadStartElement();
                                    Reader.MoveToContent();
                                    int whileIterations54 = 0;
                                    int readerCount54 = ReaderCount;
                                    while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                                        if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                                            if (((object) Reader.LocalName == (object)id34_DayOfWeek && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                                {
                                                    a_4_0.Add(Read7_DayOfWeek(Reader.ReadElementContentAsString()));
                                                }
                                            }
                                            else {
                                                UnknownNode(null, @":DayOfWeek");
                                            }
                                        }
                                        else {
                                            UnknownNode(null, @":DayOfWeek");
                                        }
                                        Reader.MoveToContent();
                                        CheckReaderCount(ref whileIterations54, ref readerCount54);
                                    }
                                ReadEndElement();
                                }
                            }
                        }
                        else if (!paramsRead[5] && ((object) Reader.LocalName == (object)id109_Time && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                            o.@Time = Read8_TimeSpan(true, defaultNamespace);
                            paramsRead[5] = true;
                        }
                        else {
                            UnknownNode((object)o, @":Item, :Days, :Time");
                        }
                    }
                    else {
                        UnknownNode((object)o, @":Item, :Days, :Time");
                    }
                    Reader.MoveToContent();
                    CheckReaderCount(ref whileIterations53, ref readerCount53);
                }
                ReadEndElement();
                return o;
            }

            global::System.TimeSpan Read8_TimeSpan(bool checkType, string defaultNamespace = null) {
                System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
                bool isNull = false;
                if (checkType) {
                if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id24_TimeSpan && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
                }
                else
                    throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
                }
                global::System.TimeSpan o;
                try {
                    o = (global::System.TimeSpan)ActivatorHelper.CreateInstance(typeof(global::System.TimeSpan));
                }
                catch (System.MissingMemberException) {
                    throw CreateInaccessibleConstructorException(@"global::System.TimeSpan");
                }
                catch (System.Security.SecurityException) {
                    throw CreateCtorHasSecurityException(@"global::System.TimeSpan");
                }
                bool[] paramsRead = new bool[0];
                while (Reader.MoveToNextAttribute()) {
                    if (!IsXmlnsAttribute(Reader.Name)) {
                        UnknownNode((object)o);
                    }
                }
                Reader.MoveToElement();
                if (Reader.IsEmptyElement) {
                    Reader.Skip();
                    return o;
                }
                Reader.ReadStartElement();
                Reader.MoveToContent();
                int whileIterations55 = 0;
                int readerCount55 = ReaderCount;
                while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                    if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                        UnknownNode((object)o, @"");
                    }
                    else {
                        UnknownNode((object)o, @"");
                    }
                    Reader.MoveToContent();
                    CheckReaderCount(ref whileIterations55, ref readerCount55);
                }
                ReadEndElement();
                return o;
            }

            global::System.DayOfWeek Read7_DayOfWeek(string s) {
                switch (s) {
                    case @"Sunday": return global::System.DayOfWeek.@Sunday;
                    case @"Monday": return global::System.DayOfWeek.@Monday;
                    case @"Tuesday": return global::System.DayOfWeek.@Tuesday;
                    case @"Wednesday": return global::System.DayOfWeek.@Wednesday;
                    case @"Thursday": return global::System.DayOfWeek.@Thursday;
                    case @"Friday": return global::System.DayOfWeek.@Friday;
                    case @"Saturday": return global::System.DayOfWeek.@Saturday;
                    default: throw CreateUnknownConstantException(s, typeof(global::System.DayOfWeek));
                }
            }

            global::DataLab.Data.Planning.Reflection Read12_Reflection(bool isNullable, bool checkType, string defaultNamespace = null) {
                System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
                bool isNull = false;
                if (isNullable) isNull = ReadNull();
                if (checkType) {
                if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id28_Reflection && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
                }
                else
                    throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
                }
                if (isNull) return null;
                global::DataLab.Data.Planning.Reflection o;
                o = new global::DataLab.Data.Planning.Reflection();
                global::System.Int32[] a_5 = null;
                int ca_5 = 0;
                bool[] paramsRead = new bool[10];
                while (Reader.MoveToNextAttribute()) {
                    if (!paramsRead[0] && ((object) Reader.LocalName == (object)id63_Name && string.Equals(Reader.NamespaceURI, id2_Item))) {
                        o.@Name = Reader.Value;
                        paramsRead[0] = true;
                    }
                    else if (!paramsRead[1] && ((object) Reader.LocalName == (object)id90_Silent && string.Equals(Reader.NamespaceURI, id2_Item))) {
                        o.@Silent = System.Xml.XmlConvert.ToBoolean(Reader.Value);
                        paramsRead[1] = true;
                    }
                    else if (!paramsRead[2] && ((object) Reader.LocalName == (object)id91_Item && string.Equals(Reader.NamespaceURI, id2_Item))) {
                        o.@MinutesToAlertBeforeActualAlarm = System.Xml.XmlConvert.ToInt32(Reader.Value);
                        paramsRead[2] = true;
                    }
                    else if (!paramsRead[4] && ((object) Reader.LocalName == (object)id37_BitmapPixelFormat && string.Equals(Reader.NamespaceURI, id2_Item))) {
                        o.@Format = Read10_BitmapPixelFormat(Reader.Value);
                        paramsRead[4] = true;
                    }
                    else if (!paramsRead[7] && ((object) Reader.LocalName == (object)id110_Description && string.Equals(Reader.NamespaceURI, id2_Item))) {
                        o.@Description = Reader.Value;
                        paramsRead[7] = true;
                    }
                    else if (!paramsRead[8] && ((object) Reader.LocalName == (object)id109_Time && string.Equals(Reader.NamespaceURI, id2_Item))) {
                        o.@Time = ToDateTime(Reader.Value);
                        paramsRead[8] = true;
                    }
                    else if (!paramsRead[9] && ((object) Reader.LocalName == (object)id111_Feeling && string.Equals(Reader.NamespaceURI, id2_Item))) {
                        o.@Feeling = Read11_Feelings(Reader.Value);
                        paramsRead[9] = true;
                    }
                    else if (!IsXmlnsAttribute(Reader.Name)) {
                        UnknownNode((object)o, @":Name, :Silent, :MinutesToAlertBeforeActualAlarm, :BitmapPixelFormat, :Description, :Time, :Feeling");
                    }
                }
                Reader.MoveToElement();
                if (Reader.IsEmptyElement) {
                    Reader.Skip();
                    return o;
                }
                Reader.ReadStartElement();
                Reader.MoveToContent();
                int whileIterations56 = 0;
                int readerCount56 = ReaderCount;
                while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                    if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                        if (!paramsRead[3] && ((object) Reader.LocalName == (object)id112_PhotoLocation && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                            {
                                o.@PhotoLocation = Reader.ReadElementContentAsString();
                            }
                            paramsRead[3] = true;
                        }
                        else if (((object) Reader.LocalName == (object)id113_Dimension && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                            if (!ReadNull()) {
                                global::System.Int32[] a_5_0 = null;
                                int ca_5_0 = 0;
                                if ((Reader.IsEmptyElement)) {
                                    Reader.Skip();
                                }
                                else {
                                    Reader.ReadStartElement();
                                    Reader.MoveToContent();
                                    int whileIterations57 = 0;
                                    int readerCount57 = ReaderCount;
                                    while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                                        if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                                            if (((object) Reader.LocalName == (object)id39_int && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                                {
                                                    a_5_0 = (global::System.Int32[])EnsureArrayIndex(a_5_0, ca_5_0, typeof(global::System.Int32));a_5_0[ca_5_0++] = System.Xml.XmlConvert.ToInt32(Reader.ReadElementContentAsString());
                                                }
                                            }
                                            else {
                                                UnknownNode(null, @":int");
                                            }
                                        }
                                        else {
                                            UnknownNode(null, @":int");
                                        }
                                        Reader.MoveToContent();
                                        CheckReaderCount(ref whileIterations57, ref readerCount57);
                                    }
                                ReadEndElement();
                                }
                                o.@Dimension = (global::System.Int32[])ShrinkArray(a_5_0, ca_5_0, typeof(global::System.Int32), false);
                            }
                        }
                        else if (!paramsRead[6] && ((object) Reader.LocalName == (object)id103_basicgeoloc && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                            o.@basicgeoloc = Read5_BasicGeoposition(true, defaultNamespace);
                            paramsRead[6] = true;
                        }
                        else {
                            UnknownNode((object)o, @":PhotoLocation, :Dimension, :basicgeoloc");
                        }
                    }
                    else {
                        UnknownNode((object)o, @":PhotoLocation, :Dimension, :basicgeoloc");
                    }
                    Reader.MoveToContent();
                    CheckReaderCount(ref whileIterations56, ref readerCount56);
                }
                ReadEndElement();
                return o;
            }

            global::DataLab.Data.Planning.Reflection.Feelings Read11_Feelings(string s) {
                switch (s) {
                    case @"DELIGHTED": return global::DataLab.Data.Planning.Reflection.Feelings.@DELIGHTED;
                    case @"DREAMY": return global::DataLab.Data.Planning.Reflection.Feelings.@DREAMY;
                    case @"HAPPY": return global::DataLab.Data.Planning.Reflection.Feelings.@HAPPY;
                    case @"MAD": return global::DataLab.Data.Planning.Reflection.Feelings.@MAD;
                    case @"NEUTRAL": return global::DataLab.Data.Planning.Reflection.Feelings.@NEUTRAL;
                    case @"SAD": return global::DataLab.Data.Planning.Reflection.Feelings.@SAD;
                    case @"SURPRISED": return global::DataLab.Data.Planning.Reflection.Feelings.@SURPRISED;
                    case @"VAGUE": return global::DataLab.Data.Planning.Reflection.Feelings.@VAGUE;
                    default: throw CreateUnknownConstantException(s, typeof(global::DataLab.Data.Planning.Reflection.Feelings));
                }
            }

            global::Windows.Graphics.Imaging.BitmapPixelFormat Read10_BitmapPixelFormat(string s) {
                switch (s) {
                    case @"Unknown": return global::Windows.Graphics.Imaging.BitmapPixelFormat.@Unknown;
                    case @"Rgba16": return global::Windows.Graphics.Imaging.BitmapPixelFormat.@Rgba16;
                    case @"Rgba8": return global::Windows.Graphics.Imaging.BitmapPixelFormat.@Rgba8;
                    case @"Gray16": return global::Windows.Graphics.Imaging.BitmapPixelFormat.@Gray16;
                    case @"Gray8": return global::Windows.Graphics.Imaging.BitmapPixelFormat.@Gray8;
                    case @"Bgra8": return global::Windows.Graphics.Imaging.BitmapPixelFormat.@Bgra8;
                    case @"Nv12": return global::Windows.Graphics.Imaging.BitmapPixelFormat.@Nv12;
                    case @"Yuy2": return global::Windows.Graphics.Imaging.BitmapPixelFormat.@Yuy2;
                    default: throw CreateUnknownConstantException(s, typeof(global::Windows.Graphics.Imaging.BitmapPixelFormat));
                }
            }

            global::DataLab.Server.Controller.Logging.Log Read27_Log(bool isNullable, bool checkType, string defaultNamespace = null) {
                System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
                bool isNull = false;
                if (isNullable) isNull = ReadNull();
                if (checkType) {
                if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id15_Log && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
                }
                else
                    throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
                }
                if (isNull) return null;
                global::DataLab.Server.Controller.Logging.Log o;
                o = new global::DataLab.Server.Controller.Logging.Log();
                bool[] paramsRead = new bool[3];
                while (Reader.MoveToNextAttribute()) {
                    if (!IsXmlnsAttribute(Reader.Name)) {
                        UnknownNode((object)o);
                    }
                }
                Reader.MoveToElement();
                if (Reader.IsEmptyElement) {
                    Reader.Skip();
                    return o;
                }
                Reader.ReadStartElement();
                Reader.MoveToContent();
                int whileIterations58 = 0;
                int readerCount58 = ReaderCount;
                while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                    if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                        if (!paramsRead[0] && ((object) Reader.LocalName == (object)id109_Time && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                            {
                                o.@Time = ToDateTime(Reader.ReadElementContentAsString());
                            }
                            paramsRead[0] = true;
                        }
                        else if (!paramsRead[1] && ((object) Reader.LocalName == (object)id21_Message && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                            {
                                o.@Message = Reader.ReadElementContentAsString();
                            }
                            paramsRead[1] = true;
                        }
                        else if (!paramsRead[2] && ((object) Reader.LocalName == (object)id114_LogType && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                            {
                                o.@LogType = Read26_LogTypes(Reader.ReadElementContentAsString());
                            }
                            paramsRead[2] = true;
                        }
                        else {
                            UnknownNode((object)o, @":Time, :Message, :LogType");
                        }
                    }
                    else {
                        UnknownNode((object)o, @":Time, :Message, :LogType");
                    }
                    Reader.MoveToContent();
                    CheckReaderCount(ref whileIterations58, ref readerCount58);
                }
                ReadEndElement();
                return o;
            }

            global::DataLab.Server.Controller.Logging.Log.LogTypes Read26_LogTypes(string s) {
                switch (s) {
                    case @"Command_result": return global::DataLab.Server.Controller.Logging.Log.LogTypes.@Command_result;
                    case @"Error": return global::DataLab.Server.Controller.Logging.Log.LogTypes.@Error;
                    case @"Server_Status": return global::DataLab.Server.Controller.Logging.Log.LogTypes.@Server_Status;
                    case @"User_Activity": return global::DataLab.Server.Controller.Logging.Log.LogTypes.@User_Activity;
                    case @"Warning": return global::DataLab.Server.Controller.Logging.Log.LogTypes.@Warning;
                    default: throw CreateUnknownConstantException(s, typeof(global::DataLab.Server.Controller.Logging.Log.LogTypes));
                }
            }

            global::DataLab.Server.Controller.ServerInfo.RunningStatus Read24_RunningStatus(string s) {
                switch (s) {
                    case @"STOP": return global::DataLab.Server.Controller.ServerInfo.RunningStatus.@STOP;
                    case @"PAUSED": return global::DataLab.Server.Controller.ServerInfo.RunningStatus.@PAUSED;
                    case @"RUNNING": return global::DataLab.Server.Controller.ServerInfo.RunningStatus.@RUNNING;
                    default: throw CreateUnknownConstantException(s, typeof(global::DataLab.Server.Controller.ServerInfo.RunningStatus));
                }
            }

            global::Datalab.Server.Packets.QuestionPacket.Questions Read3_Questions(string s) {
                switch (s) {
                    case @"Valid_username": return global::Datalab.Server.Packets.QuestionPacket.Questions.@Valid_username;
                    case @"Valid_password": return global::Datalab.Server.Packets.QuestionPacket.Questions.@Valid_password;
                    case @"Is_Online": return global::Datalab.Server.Packets.QuestionPacket.Questions.@Is_Online;
                    case @"Permissions_check": return global::Datalab.Server.Packets.QuestionPacket.Questions.@Permissions_check;
                    case @"Registration": return global::Datalab.Server.Packets.QuestionPacket.Questions.@Registration;
                    case @"Is_username_available": return global::Datalab.Server.Packets.QuestionPacket.Questions.@Is_username_available;
                    case @"Get_user": return global::Datalab.Server.Packets.QuestionPacket.Questions.@Get_user;
                    case @"Sync_user": return global::Datalab.Server.Packets.QuestionPacket.Questions.@Sync_user;
                    default: throw CreateUnknownConstantException(s, typeof(global::Datalab.Server.Packets.QuestionPacket.Questions));
                }
            }

            global::Datalab.Server.Packets.QuestionPacket Read23_QuestionPacket(bool isNullable, bool checkType, string defaultNamespace = null) {
                System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
                bool isNull = false;
                if (isNullable) isNull = ReadNull();
                if (checkType) {
                if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id1_QuestionPacket && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
                }
                else
                    throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
                }
                if (isNull) return null;
                global::Datalab.Server.Packets.QuestionPacket o;
                o = new global::Datalab.Server.Packets.QuestionPacket();
                global::System.Object[] a_1 = null;
                int ca_1 = 0;
                bool[] paramsRead = new bool[3];
                while (Reader.MoveToNextAttribute()) {
                    if (!IsXmlnsAttribute(Reader.Name)) {
                        UnknownNode((object)o);
                    }
                }
                Reader.MoveToElement();
                if (Reader.IsEmptyElement) {
                    Reader.Skip();
                    return o;
                }
                Reader.ReadStartElement();
                Reader.MoveToContent();
                int whileIterations59 = 0;
                int readerCount59 = ReaderCount;
                while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                    if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                        if (!paramsRead[0] && ((object) Reader.LocalName == (object)id115_Q && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                            {
                                o.@Q = Read3_Questions(Reader.ReadElementContentAsString());
                            }
                            paramsRead[0] = true;
                        }
                        else if (((object) Reader.LocalName == (object)id116_Question_data && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                            if (!ReadNull()) {
                                global::System.Object[] a_1_0 = null;
                                int ca_1_0 = 0;
                                if ((Reader.IsEmptyElement)) {
                                    Reader.Skip();
                                }
                                else {
                                    Reader.ReadStartElement();
                                    Reader.MoveToContent();
                                    int whileIterations60 = 0;
                                    int readerCount60 = ReaderCount;
                                    while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                                        if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                                            if (((object) Reader.LocalName == (object)id6_anyType && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                                a_1_0 = (global::System.Object[])EnsureArrayIndex(a_1_0, ca_1_0, typeof(global::System.Object));a_1_0[ca_1_0++] = Read1_Object(true, true, defaultNamespace);
                                            }
                                            else {
                                                UnknownNode(null, @":anyType");
                                            }
                                        }
                                        else {
                                            UnknownNode(null, @":anyType");
                                        }
                                        Reader.MoveToContent();
                                        CheckReaderCount(ref whileIterations60, ref readerCount60);
                                    }
                                ReadEndElement();
                                }
                                o.@Question_data = (global::System.Object[])ShrinkArray(a_1_0, ca_1_0, typeof(global::System.Object), false);
                            }
                        }
                        else if (!paramsRead[2] && ((object) Reader.LocalName == (object)id117_A && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                            {
                                o.@A = System.Xml.XmlConvert.ToBoolean(Reader.ReadElementContentAsString());
                            }
                            paramsRead[2] = true;
                        }
                        else {
                            UnknownNode((object)o, @":Q, :Question_data, :A");
                        }
                    }
                    else {
                        UnknownNode((object)o, @":Q, :Question_data, :A");
                    }
                    Reader.MoveToContent();
                    CheckReaderCount(ref whileIterations59, ref readerCount59);
                }
                ReadEndElement();
                return o;
            }

            global::Datalab.Server.Packets.Packet Read2_Packet(bool isNullable, bool checkType, string defaultNamespace = null) {
                System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
                bool isNull = false;
                if (isNullable) isNull = ReadNull();
                if (checkType) {
                if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id7_Packet && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
                }
                else if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id1_QuestionPacket && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item)))
                    return Read23_QuestionPacket(isNullable, false, defaultNamespace);
                else
                    throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
                }
                if (isNull) return null;
                throw CreateAbstractTypeException(@"Packet", @"");
            }

            global::DataLab.Server.Controller.ServerInfo Read25_ServerInfo(bool isNullable, bool checkType, string defaultNamespace = null) {
                System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
                bool isNull = false;
                if (isNullable) isNull = ReadNull();
                if (checkType) {
                if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id16_ServerInfo && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
                }
                else
                    throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
                }
                if (isNull) return null;
                global::DataLab.Server.Controller.ServerInfo o;
                o = new global::DataLab.Server.Controller.ServerInfo();
                bool[] paramsRead = new bool[3];
                while (Reader.MoveToNextAttribute()) {
                    if (!IsXmlnsAttribute(Reader.Name)) {
                        UnknownNode((object)o);
                    }
                }
                Reader.MoveToElement();
                if (Reader.IsEmptyElement) {
                    Reader.Skip();
                    return o;
                }
                Reader.ReadStartElement();
                Reader.MoveToContent();
                int whileIterations61 = 0;
                int readerCount61 = ReaderCount;
                while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                    if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                        if (!paramsRead[0] && ((object) Reader.LocalName == (object)id63_Name && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                            {
                                o.@Name = Reader.ReadElementContentAsString();
                            }
                            paramsRead[0] = true;
                        }
                        else if (!paramsRead[1] && ((object) Reader.LocalName == (object)id118_RunningSince && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                            {
                                o.@RunningSince = ToDateTime(Reader.ReadElementContentAsString());
                            }
                            paramsRead[1] = true;
                        }
                        else if (!paramsRead[2] && ((object) Reader.LocalName == (object)id119_RunStatus && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                            {
                                o.@RunStatus = Read24_RunningStatus(Reader.ReadElementContentAsString());
                            }
                            paramsRead[2] = true;
                        }
                        else {
                            UnknownNode((object)o, @":Name, :RunningSince, :RunStatus");
                        }
                    }
                    else {
                        UnknownNode((object)o, @":Name, :RunningSince, :RunStatus");
                    }
                    Reader.MoveToContent();
                    CheckReaderCount(ref whileIterations61, ref readerCount61);
                }
                ReadEndElement();
                return o;
            }

            global::DataLab.Server.Controller.Logging.ServerLog Read28_ServerLog(bool isNullable, bool checkType, string defaultNamespace = null) {
                System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
                bool isNull = false;
                if (isNullable) isNull = ReadNull();
                if (checkType) {
                if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id14_ServerLog && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
                }
                else
                    throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
                }
                if (isNull) return null;
                global::DataLab.Server.Controller.Logging.ServerLog o;
                o = new global::DataLab.Server.Controller.Logging.ServerLog();
                if ((object)(o.@Logs) == null) o.@Logs = new global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Server.Controller.Logging.Log>();
                global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Server.Controller.Logging.Log> a_0 = (global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Server.Controller.Logging.Log>)o.@Logs;
                if ((object)(o.@LogHistory) == null) o.@LogHistory = new global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Server.Controller.Logging.Log>();
                global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Server.Controller.Logging.Log> a_1 = (global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Server.Controller.Logging.Log>)o.@LogHistory;
                bool[] paramsRead = new bool[2];
                while (Reader.MoveToNextAttribute()) {
                    if (!IsXmlnsAttribute(Reader.Name)) {
                        UnknownNode((object)o);
                    }
                }
                Reader.MoveToElement();
                if (Reader.IsEmptyElement) {
                    Reader.Skip();
                    return o;
                }
                Reader.ReadStartElement();
                Reader.MoveToContent();
                int whileIterations62 = 0;
                int readerCount62 = ReaderCount;
                while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                    if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                        if (((object) Reader.LocalName == (object)id120_Logs && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                            if (!ReadNull()) {
                                if ((object)(o.@Logs) == null) o.@Logs = new global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Server.Controller.Logging.Log>();
                                global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Server.Controller.Logging.Log> a_0_0 = (global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Server.Controller.Logging.Log>)o.@Logs;
                                if ((Reader.IsEmptyElement)) {
                                    Reader.Skip();
                                }
                                else {
                                    Reader.ReadStartElement();
                                    Reader.MoveToContent();
                                    int whileIterations63 = 0;
                                    int readerCount63 = ReaderCount;
                                    while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                                        if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                                            if (((object) Reader.LocalName == (object)id15_Log && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                                if ((object)(a_0_0) == null) Reader.Skip(); else a_0_0.Add(Read27_Log(true, true, defaultNamespace));
                                            }
                                            else {
                                                UnknownNode(null, @":Log");
                                            }
                                        }
                                        else {
                                            UnknownNode(null, @":Log");
                                        }
                                        Reader.MoveToContent();
                                        CheckReaderCount(ref whileIterations63, ref readerCount63);
                                    }
                                ReadEndElement();
                                }
                            }
                        }
                        else if (((object) Reader.LocalName == (object)id121_LogHistory && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                            if (!ReadNull()) {
                                if ((object)(o.@LogHistory) == null) o.@LogHistory = new global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Server.Controller.Logging.Log>();
                                global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Server.Controller.Logging.Log> a_1_0 = (global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Server.Controller.Logging.Log>)o.@LogHistory;
                                if ((Reader.IsEmptyElement)) {
                                    Reader.Skip();
                                }
                                else {
                                    Reader.ReadStartElement();
                                    Reader.MoveToContent();
                                    int whileIterations64 = 0;
                                    int readerCount64 = ReaderCount;
                                    while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                                        if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                                            if (((object) Reader.LocalName == (object)id15_Log && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                                if ((object)(a_1_0) == null) Reader.Skip(); else a_1_0.Add(Read27_Log(true, true, defaultNamespace));
                                            }
                                            else {
                                                UnknownNode(null, @":Log");
                                            }
                                        }
                                        else {
                                            UnknownNode(null, @":Log");
                                        }
                                        Reader.MoveToContent();
                                        CheckReaderCount(ref whileIterations64, ref readerCount64);
                                    }
                                ReadEndElement();
                                }
                            }
                        }
                        else {
                            UnknownNode((object)o, @":Logs, :LogHistory");
                        }
                    }
                    else {
                        UnknownNode((object)o, @":Logs, :LogHistory");
                    }
                    Reader.MoveToContent();
                    CheckReaderCount(ref whileIterations62, ref readerCount62);
                }
                ReadEndElement();
                return o;
            }

            global::DataLab.Data.Users.UserManager Read29_UserManager(bool isNullable, bool checkType, string defaultNamespace = null) {
                System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
                bool isNull = false;
                if (isNullable) isNull = ReadNull();
                if (checkType) {
                if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id13_UserManager && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
                }
                else
                    throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
                }
                if (isNull) return null;
                global::DataLab.Data.Users.UserManager o;
                o = new global::DataLab.Data.Users.UserManager();
                if ((object)(o.@Users) == null) o.@Users = new global::System.Collections.Generic.List<global::DataLab.Data.Users.User>();
                global::System.Collections.Generic.List<global::DataLab.Data.Users.User> a_0 = (global::System.Collections.Generic.List<global::DataLab.Data.Users.User>)o.@Users;
                bool[] paramsRead = new bool[1];
                while (Reader.MoveToNextAttribute()) {
                    if (!IsXmlnsAttribute(Reader.Name)) {
                        UnknownNode((object)o);
                    }
                }
                Reader.MoveToElement();
                if (Reader.IsEmptyElement) {
                    Reader.Skip();
                    return o;
                }
                Reader.ReadStartElement();
                Reader.MoveToContent();
                int whileIterations65 = 0;
                int readerCount65 = ReaderCount;
                while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                    if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                        if (((object) Reader.LocalName == (object)id122_Users && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                            if (!ReadNull()) {
                                if ((object)(o.@Users) == null) o.@Users = new global::System.Collections.Generic.List<global::DataLab.Data.Users.User>();
                                global::System.Collections.Generic.List<global::DataLab.Data.Users.User> a_0_0 = (global::System.Collections.Generic.List<global::DataLab.Data.Users.User>)o.@Users;
                                if ((Reader.IsEmptyElement)) {
                                    Reader.Skip();
                                }
                                else {
                                    Reader.ReadStartElement();
                                    Reader.MoveToContent();
                                    int whileIterations66 = 0;
                                    int readerCount66 = ReaderCount;
                                    while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                                        if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                                            if (((object) Reader.LocalName == (object)id8_User && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                                if ((object)(a_0_0) == null) Reader.Skip(); else a_0_0.Add(Read22_User(true, true, defaultNamespace));
                                            }
                                            else {
                                                UnknownNode(null, @":User");
                                            }
                                        }
                                        else {
                                            UnknownNode(null, @":User");
                                        }
                                        Reader.MoveToContent();
                                        CheckReaderCount(ref whileIterations66, ref readerCount66);
                                    }
                                ReadEndElement();
                                }
                            }
                        }
                        else {
                            UnknownNode((object)o, @":Users");
                        }
                    }
                    else {
                        UnknownNode((object)o, @":Users");
                    }
                    Reader.MoveToContent();
                    CheckReaderCount(ref whileIterations65, ref readerCount65);
                }
                ReadEndElement();
                return o;
            }

            global::DataLab.Data.Users.Message.MailManager Read30_MailManager(bool isNullable, bool checkType, string defaultNamespace = null) {
                System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
                bool isNull = false;
                if (isNullable) isNull = ReadNull();
                if (checkType) {
                if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id12_MailManager && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
                }
                else
                    throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
                }
                if (isNull) return null;
                global::DataLab.Data.Users.Message.MailManager o;
                o = new global::DataLab.Data.Users.Message.MailManager();
                if ((object)(o.@Mails) == null) o.@Mails = new global::System.Collections.Generic.List<global::DataLab.Data.Users.Message.Mail>();
                global::System.Collections.Generic.List<global::DataLab.Data.Users.Message.Mail> a_0 = (global::System.Collections.Generic.List<global::DataLab.Data.Users.Message.Mail>)o.@Mails;
                bool[] paramsRead = new bool[1];
                while (Reader.MoveToNextAttribute()) {
                    if (!IsXmlnsAttribute(Reader.Name)) {
                        UnknownNode((object)o);
                    }
                }
                Reader.MoveToElement();
                if (Reader.IsEmptyElement) {
                    Reader.Skip();
                    return o;
                }
                Reader.ReadStartElement();
                Reader.MoveToContent();
                int whileIterations67 = 0;
                int readerCount67 = ReaderCount;
                while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                    if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                        if (((object) Reader.LocalName == (object)id74_Mails && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                            if (!ReadNull()) {
                                if ((object)(o.@Mails) == null) o.@Mails = new global::System.Collections.Generic.List<global::DataLab.Data.Users.Message.Mail>();
                                global::System.Collections.Generic.List<global::DataLab.Data.Users.Message.Mail> a_0_0 = (global::System.Collections.Generic.List<global::DataLab.Data.Users.Message.Mail>)o.@Mails;
                                if ((Reader.IsEmptyElement)) {
                                    Reader.Skip();
                                }
                                else {
                                    Reader.ReadStartElement();
                                    Reader.MoveToContent();
                                    int whileIterations68 = 0;
                                    int readerCount68 = ReaderCount;
                                    while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                                        if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                                            if (((object) Reader.LocalName == (object)id22_Mail && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                                if ((object)(a_0_0) == null) Reader.Skip(); else a_0_0.Add(Read15_Mail(true, true, defaultNamespace));
                                            }
                                            else {
                                                UnknownNode(null, @":Mail");
                                            }
                                        }
                                        else {
                                            UnknownNode(null, @":Mail");
                                        }
                                        Reader.MoveToContent();
                                        CheckReaderCount(ref whileIterations68, ref readerCount68);
                                    }
                                ReadEndElement();
                                }
                            }
                        }
                        else {
                            UnknownNode((object)o, @":Mails");
                        }
                    }
                    else {
                        UnknownNode((object)o, @":Mails");
                    }
                    Reader.MoveToContent();
                    CheckReaderCount(ref whileIterations67, ref readerCount67);
                }
                ReadEndElement();
                return o;
            }

            global::DataLab.Data.Users.Message.ChatManager Read32_ChatManager(bool isNullable, bool checkType, string defaultNamespace = null) {
                System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
                bool isNull = false;
                if (isNullable) isNull = ReadNull();
                if (checkType) {
                if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id10_ChatManager && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
                }
                else
                    throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
                }
                if (isNull) return null;
                global::DataLab.Data.Users.Message.ChatManager o;
                o = new global::DataLab.Data.Users.Message.ChatManager();
                if ((object)(o.@ChatRooms) == null) o.@ChatRooms = new global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Users.Message.Chat.ChatRoom>();
                global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Users.Message.Chat.ChatRoom> a_0 = (global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Users.Message.Chat.ChatRoom>)o.@ChatRooms;
                if ((object)(o.@ChatHistory) == null) o.@ChatHistory = new global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Users.Message.Chat.ChatRoom>();
                global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Users.Message.Chat.ChatRoom> a_1 = (global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Users.Message.Chat.ChatRoom>)o.@ChatHistory;
                bool[] paramsRead = new bool[2];
                while (Reader.MoveToNextAttribute()) {
                    if (!IsXmlnsAttribute(Reader.Name)) {
                        UnknownNode((object)o);
                    }
                }
                Reader.MoveToElement();
                if (Reader.IsEmptyElement) {
                    Reader.Skip();
                    return o;
                }
                Reader.ReadStartElement();
                Reader.MoveToContent();
                int whileIterations69 = 0;
                int readerCount69 = ReaderCount;
                while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                    if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                        if (((object) Reader.LocalName == (object)id123_ChatRooms && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                            if (!ReadNull()) {
                                if ((object)(o.@ChatRooms) == null) o.@ChatRooms = new global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Users.Message.Chat.ChatRoom>();
                                global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Users.Message.Chat.ChatRoom> a_0_0 = (global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Users.Message.Chat.ChatRoom>)o.@ChatRooms;
                                if ((Reader.IsEmptyElement)) {
                                    Reader.Skip();
                                }
                                else {
                                    Reader.ReadStartElement();
                                    Reader.MoveToContent();
                                    int whileIterations70 = 0;
                                    int readerCount70 = ReaderCount;
                                    while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                                        if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                                            if (((object) Reader.LocalName == (object)id11_ChatRoom && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                                if ((object)(a_0_0) == null) Reader.Skip(); else a_0_0.Add(Read31_ChatRoom(true, true, defaultNamespace));
                                            }
                                            else {
                                                UnknownNode(null, @":ChatRoom");
                                            }
                                        }
                                        else {
                                            UnknownNode(null, @":ChatRoom");
                                        }
                                        Reader.MoveToContent();
                                        CheckReaderCount(ref whileIterations70, ref readerCount70);
                                    }
                                ReadEndElement();
                                }
                            }
                        }
                        else if (((object) Reader.LocalName == (object)id124_ChatHistory && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                            if (!ReadNull()) {
                                if ((object)(o.@ChatHistory) == null) o.@ChatHistory = new global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Users.Message.Chat.ChatRoom>();
                                global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Users.Message.Chat.ChatRoom> a_1_0 = (global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Users.Message.Chat.ChatRoom>)o.@ChatHistory;
                                if ((Reader.IsEmptyElement)) {
                                    Reader.Skip();
                                }
                                else {
                                    Reader.ReadStartElement();
                                    Reader.MoveToContent();
                                    int whileIterations71 = 0;
                                    int readerCount71 = ReaderCount;
                                    while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                                        if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                                            if (((object) Reader.LocalName == (object)id11_ChatRoom && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                                if ((object)(a_1_0) == null) Reader.Skip(); else a_1_0.Add(Read31_ChatRoom(true, true, defaultNamespace));
                                            }
                                            else {
                                                UnknownNode(null, @":ChatRoom");
                                            }
                                        }
                                        else {
                                            UnknownNode(null, @":ChatRoom");
                                        }
                                        Reader.MoveToContent();
                                        CheckReaderCount(ref whileIterations71, ref readerCount71);
                                    }
                                ReadEndElement();
                                }
                            }
                        }
                        else {
                            UnknownNode((object)o, @":ChatRooms, :ChatHistory");
                        }
                    }
                    else {
                        UnknownNode((object)o, @":ChatRooms, :ChatHistory");
                    }
                    Reader.MoveToContent();
                    CheckReaderCount(ref whileIterations69, ref readerCount69);
                }
                ReadEndElement();
                return o;
            }

            global::DataLab.Data.Users.Message.MessageManager Read33_MessageManager(bool isNullable, bool checkType, string defaultNamespace = null) {
                System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
                bool isNull = false;
                if (isNullable) isNull = ReadNull();
                if (checkType) {
                if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id9_MessageManager && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
                }
                else
                    throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
                }
                if (isNull) return null;
                global::DataLab.Data.Users.Message.MessageManager o;
                o = new global::DataLab.Data.Users.Message.MessageManager();
                bool[] paramsRead = new bool[2];
                while (Reader.MoveToNextAttribute()) {
                    if (!IsXmlnsAttribute(Reader.Name)) {
                        UnknownNode((object)o);
                    }
                }
                Reader.MoveToElement();
                if (Reader.IsEmptyElement) {
                    Reader.Skip();
                    return o;
                }
                Reader.ReadStartElement();
                Reader.MoveToContent();
                int whileIterations72 = 0;
                int readerCount72 = ReaderCount;
                while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                    if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                        if (!paramsRead[0] && ((object) Reader.LocalName == (object)id125_MailMan && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                            o.@MailMan = Read30_MailManager(false, true, defaultNamespace);
                            paramsRead[0] = true;
                        }
                        else if (!paramsRead[1] && ((object) Reader.LocalName == (object)id126_ChatMan && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                            o.@ChatMan = Read32_ChatManager(false, true, defaultNamespace);
                            paramsRead[1] = true;
                        }
                        else {
                            UnknownNode((object)o, @":MailMan, :ChatMan");
                        }
                    }
                    else {
                        UnknownNode((object)o, @":MailMan, :ChatMan");
                    }
                    Reader.MoveToContent();
                    CheckReaderCount(ref whileIterations72, ref readerCount72);
                }
                ReadEndElement();
                return o;
            }

            global::PlennerServer.Server.ServerDataContainer Read34_ServerDataContainer(bool isNullable, bool checkType, string defaultNamespace = null) {
                System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
                bool isNull = false;
                if (isNullable) isNull = ReadNull();
                if (checkType) {
                if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id3_ServerDataContainer && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
                }
                else
                    throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
                }
                if (isNull) return null;
                global::PlennerServer.Server.ServerDataContainer o;
                o = new global::PlennerServer.Server.ServerDataContainer();
                bool[] paramsRead = new bool[4];
                while (Reader.MoveToNextAttribute()) {
                    if (!IsXmlnsAttribute(Reader.Name)) {
                        UnknownNode((object)o);
                    }
                }
                Reader.MoveToElement();
                if (Reader.IsEmptyElement) {
                    Reader.Skip();
                    return o;
                }
                Reader.ReadStartElement();
                Reader.MoveToContent();
                int whileIterations73 = 0;
                int readerCount73 = ReaderCount;
                while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                    if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                        if (!paramsRead[0] && ((object) Reader.LocalName == (object)id127_Info && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                            o.@Info = Read25_ServerInfo(false, true, defaultNamespace);
                            paramsRead[0] = true;
                        }
                        else if (!paramsRead[1] && ((object) Reader.LocalName == (object)id15_Log && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                            o.@Log = Read28_ServerLog(false, true, defaultNamespace);
                            paramsRead[1] = true;
                        }
                        else if (!paramsRead[2] && ((object) Reader.LocalName == (object)id128_Uman && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                            o.@Uman = Read29_UserManager(false, true, defaultNamespace);
                            paramsRead[2] = true;
                        }
                        else if (!paramsRead[3] && ((object) Reader.LocalName == (object)id129_MsgMan && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                            o.@MsgMan = Read33_MessageManager(false, true, defaultNamespace);
                            paramsRead[3] = true;
                        }
                        else {
                            UnknownNode((object)o, @":Info, :Log, :Uman, :MsgMan");
                        }
                    }
                    else {
                        UnknownNode((object)o, @":Info, :Log, :Uman, :MsgMan");
                    }
                    Reader.MoveToContent();
                    CheckReaderCount(ref whileIterations73, ref readerCount73);
                }
                ReadEndElement();
                return o;
            }

            global::DataLab.Storage.PlannerSettings Read35_PlannerSettings(bool isNullable, bool checkType, string defaultNamespace = null) {
                System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
                bool isNull = false;
                if (isNullable) isNull = ReadNull();
                if (checkType) {
                if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id5_PlannerSettings && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
                }
                else
                    throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
                }
                if (isNull) return null;
                global::DataLab.Storage.PlannerSettings o;
                o = new global::DataLab.Storage.PlannerSettings();
                global::System.Int32[] a_3 = null;
                int ca_3 = 0;
                bool[] paramsRead = new bool[5];
                while (Reader.MoveToNextAttribute()) {
                    if (!IsXmlnsAttribute(Reader.Name)) {
                        UnknownNode((object)o);
                    }
                }
                Reader.MoveToElement();
                if (Reader.IsEmptyElement) {
                    Reader.Skip();
                    return o;
                }
                Reader.ReadStartElement();
                Reader.MoveToContent();
                int whileIterations74 = 0;
                int readerCount74 = ReaderCount;
                while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                    if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                        if (!paramsRead[0] && ((object) Reader.LocalName == (object)id130_SoundEnabled && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                            {
                                o.@SoundEnabled = System.Xml.XmlConvert.ToBoolean(Reader.ReadElementContentAsString());
                            }
                            paramsRead[0] = true;
                        }
                        else if (!paramsRead[1] && ((object) Reader.LocalName == (object)id131_AutoSyncAccount && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                            {
                                o.@AutoSyncAccount = System.Xml.XmlConvert.ToBoolean(Reader.ReadElementContentAsString());
                            }
                            paramsRead[1] = true;
                        }
                        else if (!paramsRead[2] && ((object) Reader.LocalName == (object)id132_AutoLogIn && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                            {
                                o.@AutoLogIn = System.Xml.XmlConvert.ToBoolean(Reader.ReadElementContentAsString());
                            }
                            paramsRead[2] = true;
                        }
                        else if (((object) Reader.LocalName == (object)id133_Item && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                            if (!ReadNull()) {
                                global::System.Int32[] a_3_0 = null;
                                int ca_3_0 = 0;
                                if ((Reader.IsEmptyElement)) {
                                    Reader.Skip();
                                }
                                else {
                                    Reader.ReadStartElement();
                                    Reader.MoveToContent();
                                    int whileIterations75 = 0;
                                    int readerCount75 = ReaderCount;
                                    while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                                        if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                                            if (((object) Reader.LocalName == (object)id39_int && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                                {
                                                    a_3_0 = (global::System.Int32[])EnsureArrayIndex(a_3_0, ca_3_0, typeof(global::System.Int32));a_3_0[ca_3_0++] = System.Xml.XmlConvert.ToInt32(Reader.ReadElementContentAsString());
                                                }
                                            }
                                            else {
                                                UnknownNode(null, @":int");
                                            }
                                        }
                                        else {
                                            UnknownNode(null, @":int");
                                        }
                                        Reader.MoveToContent();
                                        CheckReaderCount(ref whileIterations75, ref readerCount75);
                                    }
                                ReadEndElement();
                                }
                                o.@PlanningItemExperationTimeSpanAsIntArray = (global::System.Int32[])ShrinkArray(a_3_0, ca_3_0, typeof(global::System.Int32), false);
                            }
                        }
                        else if (!paramsRead[4] && ((object) Reader.LocalName == (object)id134_EnableNotifications && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                            {
                                o.@EnableNotifications = System.Xml.XmlConvert.ToBoolean(Reader.ReadElementContentAsString());
                            }
                            paramsRead[4] = true;
                        }
                        else {
                            UnknownNode((object)o, @":SoundEnabled, :AutoSyncAccount, :AutoLogIn, :PlanningItemExperationTimeSpanAsIntArray, :EnableNotifications");
                        }
                    }
                    else {
                        UnknownNode((object)o, @":SoundEnabled, :AutoSyncAccount, :AutoLogIn, :PlanningItemExperationTimeSpanAsIntArray, :EnableNotifications");
                    }
                    Reader.MoveToContent();
                    CheckReaderCount(ref whileIterations74, ref readerCount74);
                }
                ReadEndElement();
                return o;
            }

            protected override void InitCallbacks() {
            }

            string id99_Punt;
            string id26_PlanningItem;
            string id74_Mails;
            string id117_A;
            string id108_Days;
            string id110_Description;
            string id112_PhotoLocation;
            string id79_BirthDay;
            string id39_int;
            string id30_Activity;
            string id95_End;
            string id88_Diaries;
            string id128_Uman;
            string id49_ArrayOfCijferPeriode;
            string id53_Friend;
            string id6_anyType;
            string id127_Info;
            string id126_ChatMan;
            string id113_Dimension;
            string id21_Message;
            string id25_BasicGeoposition;
            string id17_UserInfo;
            string id91_Item;
            string id129_MsgMan;
            string id20_Cijfer;
            string id109_Time;
            string id48_ArrayOfCijfertaak;
            string id11_ChatRoom;
            string id41_ArrayOfReflection;
            string id3_ServerDataContainer;
            string id115_Q;
            string id8_User;
            string id34_DayOfWeek;
            string id61_ChatMessages;
            string id132_AutoLogIn;
            string id107_Item;
            string id100_StartTime;
            string id72_UserName;
            string id131_AutoSyncAccount;
            string id119_RunStatus;
            string id15_Log;
            string id9_MessageManager;
            string id37_BitmapPixelFormat;
            string id123_ChatRooms;
            string id121_LogHistory;
            string id96_Attempts;
            string id7_Packet;
            string id2_Item;
            string id98_MinTeBehalenPunt;
            string id69_SentOn;
            string id87_Reflections;
            string id35_ArrayOfDayOfWeek;
            string id101_EndTime;
            string id60_Participants;
            string id27_CijferLijst;
            string id134_EnableNotifications;
            string id62_ID;
            string id4_Plan;
            string id19_Cijfertaak;
            string id68_TimeSent;
            string id85_Activities;
            string id45_string;
            string id90_Silent;
            string id47_ArrayOfCijfer;
            string id73_password;
            string id55_LogTypes;
            string id54_RunningStatus;
            string id75_LastDataSync;
            string id1_QuestionPacket;
            string id71_wasRead;
            string id33_ArrayOfActivity;
            string id36_ArrayOfRepeatingPlanningItem;
            string id10_ChatManager;
            string id12_MailManager;
            string id57_ArrayOfUser;
            string id77_FirstName;
            string id84_FriendNames;
            string id50_ArrayOfCijferLijst;
            string id51_Hobbie;
            string id93_ToComplete;
            string id97_MaxTeBehalenPunt;
            string id18_CijferPeriode;
            string id16_ServerInfo;
            string id80_Hobbies;
            string id29_RepeatingPlanningItem;
            string id133_Item;
            string id43_ArrayOfDiary;
            string id65_Sender;
            string id76_Friends;
            string id46_ArrayOfMail;
            string id104_Latitude;
            string id105_Longitude;
            string id22_Mail;
            string id114_LogType;
            string id124_ChatHistory;
            string id125_MailMan;
            string id89_CijferLijsten;
            string id38_ArrayOfInt;
            string id24_TimeSpan;
            string id40_Feelings;
            string id82_CountryOfLiving;
            string id66_Recepients;
            string id52_ArrayOfString1;
            string id116_Question_data;
            string id63_Name;
            string id67_Msg;
            string id70_Subject;
            string id58_ArrayOfMessage;
            string id122_Users;
            string id42_ArrayOfPlanningItem;
            string id81_BirthCountry;
            string id5_PlannerSettings;
            string id103_basicgeoloc;
            string id32_ArrayOfAnyType;
            string id92_Periodes;
            string id31_Questions;
            string id28_Reflection;
            string id13_UserManager;
            string id78_LastName;
            string id102_PlanningItems;
            string id64_MaxSize;
            string id118_RunningSince;
            string id59_ArrayOfChatRoom;
            string id83_Language;
            string id14_ServerLog;
            string id106_Altitude;
            string id86_rpi;
            string id44_ArrayOfString;
            string id111_Feeling;
            string id23_Diary;
            string id130_SoundEnabled;
            string id56_ArrayOfLog;
            string id94_Start;
            string id120_Logs;

            protected override void InitIDs() {
                id99_Punt = Reader.NameTable.Add(@"Punt");
                id26_PlanningItem = Reader.NameTable.Add(@"PlanningItem");
                id74_Mails = Reader.NameTable.Add(@"Mails");
                id117_A = Reader.NameTable.Add(@"A");
                id108_Days = Reader.NameTable.Add(@"Days");
                id110_Description = Reader.NameTable.Add(@"Description");
                id112_PhotoLocation = Reader.NameTable.Add(@"PhotoLocation");
                id79_BirthDay = Reader.NameTable.Add(@"BirthDay");
                id39_int = Reader.NameTable.Add(@"int");
                id30_Activity = Reader.NameTable.Add(@"Activity");
                id95_End = Reader.NameTable.Add(@"End");
                id88_Diaries = Reader.NameTable.Add(@"Diaries");
                id128_Uman = Reader.NameTable.Add(@"Uman");
                id49_ArrayOfCijferPeriode = Reader.NameTable.Add(@"ArrayOfCijferPeriode");
                id53_Friend = Reader.NameTable.Add(@"Friend");
                id6_anyType = Reader.NameTable.Add(@"anyType");
                id127_Info = Reader.NameTable.Add(@"Info");
                id126_ChatMan = Reader.NameTable.Add(@"ChatMan");
                id113_Dimension = Reader.NameTable.Add(@"Dimension");
                id21_Message = Reader.NameTable.Add(@"Message");
                id25_BasicGeoposition = Reader.NameTable.Add(@"BasicGeoposition");
                id17_UserInfo = Reader.NameTable.Add(@"UserInfo");
                id91_Item = Reader.NameTable.Add(@"MinutesToAlertBeforeActualAlarm");
                id129_MsgMan = Reader.NameTable.Add(@"MsgMan");
                id20_Cijfer = Reader.NameTable.Add(@"Cijfer");
                id109_Time = Reader.NameTable.Add(@"Time");
                id48_ArrayOfCijfertaak = Reader.NameTable.Add(@"ArrayOfCijfertaak");
                id11_ChatRoom = Reader.NameTable.Add(@"ChatRoom");
                id41_ArrayOfReflection = Reader.NameTable.Add(@"ArrayOfReflection");
                id3_ServerDataContainer = Reader.NameTable.Add(@"ServerDataContainer");
                id115_Q = Reader.NameTable.Add(@"Q");
                id8_User = Reader.NameTable.Add(@"User");
                id34_DayOfWeek = Reader.NameTable.Add(@"DayOfWeek");
                id61_ChatMessages = Reader.NameTable.Add(@"ChatMessages");
                id132_AutoLogIn = Reader.NameTable.Add(@"AutoLogIn");
                id107_Item = Reader.NameTable.Add(@"Item");
                id100_StartTime = Reader.NameTable.Add(@"StartTime");
                id72_UserName = Reader.NameTable.Add(@"UserName");
                id131_AutoSyncAccount = Reader.NameTable.Add(@"AutoSyncAccount");
                id119_RunStatus = Reader.NameTable.Add(@"RunStatus");
                id15_Log = Reader.NameTable.Add(@"Log");
                id9_MessageManager = Reader.NameTable.Add(@"MessageManager");
                id37_BitmapPixelFormat = Reader.NameTable.Add(@"BitmapPixelFormat");
                id123_ChatRooms = Reader.NameTable.Add(@"ChatRooms");
                id121_LogHistory = Reader.NameTable.Add(@"LogHistory");
                id96_Attempts = Reader.NameTable.Add(@"Attempts");
                id7_Packet = Reader.NameTable.Add(@"Packet");
                id2_Item = Reader.NameTable.Add(@"");
                id98_MinTeBehalenPunt = Reader.NameTable.Add(@"MinTeBehalenPunt");
                id69_SentOn = Reader.NameTable.Add(@"SentOn");
                id87_Reflections = Reader.NameTable.Add(@"Reflections");
                id35_ArrayOfDayOfWeek = Reader.NameTable.Add(@"ArrayOfDayOfWeek");
                id101_EndTime = Reader.NameTable.Add(@"EndTime");
                id60_Participants = Reader.NameTable.Add(@"Participants");
                id27_CijferLijst = Reader.NameTable.Add(@"CijferLijst");
                id134_EnableNotifications = Reader.NameTable.Add(@"EnableNotifications");
                id62_ID = Reader.NameTable.Add(@"ID");
                id4_Plan = Reader.NameTable.Add(@"Plan");
                id19_Cijfertaak = Reader.NameTable.Add(@"Cijfertaak");
                id68_TimeSent = Reader.NameTable.Add(@"TimeSent");
                id85_Activities = Reader.NameTable.Add(@"Activities");
                id45_string = Reader.NameTable.Add(@"string");
                id90_Silent = Reader.NameTable.Add(@"Silent");
                id47_ArrayOfCijfer = Reader.NameTable.Add(@"ArrayOfCijfer");
                id73_password = Reader.NameTable.Add(@"password");
                id55_LogTypes = Reader.NameTable.Add(@"LogTypes");
                id54_RunningStatus = Reader.NameTable.Add(@"RunningStatus");
                id75_LastDataSync = Reader.NameTable.Add(@"LastDataSync");
                id1_QuestionPacket = Reader.NameTable.Add(@"QuestionPacket");
                id71_wasRead = Reader.NameTable.Add(@"wasRead");
                id33_ArrayOfActivity = Reader.NameTable.Add(@"ArrayOfActivity");
                id36_ArrayOfRepeatingPlanningItem = Reader.NameTable.Add(@"ArrayOfRepeatingPlanningItem");
                id10_ChatManager = Reader.NameTable.Add(@"ChatManager");
                id12_MailManager = Reader.NameTable.Add(@"MailManager");
                id57_ArrayOfUser = Reader.NameTable.Add(@"ArrayOfUser");
                id77_FirstName = Reader.NameTable.Add(@"FirstName");
                id84_FriendNames = Reader.NameTable.Add(@"FriendNames");
                id50_ArrayOfCijferLijst = Reader.NameTable.Add(@"ArrayOfCijferLijst");
                id51_Hobbie = Reader.NameTable.Add(@"Hobbie");
                id93_ToComplete = Reader.NameTable.Add(@"ToComplete");
                id97_MaxTeBehalenPunt = Reader.NameTable.Add(@"MaxTeBehalenPunt");
                id18_CijferPeriode = Reader.NameTable.Add(@"CijferPeriode");
                id16_ServerInfo = Reader.NameTable.Add(@"ServerInfo");
                id80_Hobbies = Reader.NameTable.Add(@"Hobbies");
                id29_RepeatingPlanningItem = Reader.NameTable.Add(@"RepeatingPlanningItem");
                id133_Item = Reader.NameTable.Add(@"PlanningItemExperationTimeSpanAsIntArray");
                id43_ArrayOfDiary = Reader.NameTable.Add(@"ArrayOfDiary");
                id65_Sender = Reader.NameTable.Add(@"Sender");
                id76_Friends = Reader.NameTable.Add(@"Friends");
                id46_ArrayOfMail = Reader.NameTable.Add(@"ArrayOfMail");
                id104_Latitude = Reader.NameTable.Add(@"Latitude");
                id105_Longitude = Reader.NameTable.Add(@"Longitude");
                id22_Mail = Reader.NameTable.Add(@"Mail");
                id114_LogType = Reader.NameTable.Add(@"LogType");
                id124_ChatHistory = Reader.NameTable.Add(@"ChatHistory");
                id125_MailMan = Reader.NameTable.Add(@"MailMan");
                id89_CijferLijsten = Reader.NameTable.Add(@"CijferLijsten");
                id38_ArrayOfInt = Reader.NameTable.Add(@"ArrayOfInt");
                id24_TimeSpan = Reader.NameTable.Add(@"TimeSpan");
                id40_Feelings = Reader.NameTable.Add(@"Feelings");
                id82_CountryOfLiving = Reader.NameTable.Add(@"CountryOfLiving");
                id66_Recepients = Reader.NameTable.Add(@"Recepients");
                id52_ArrayOfString1 = Reader.NameTable.Add(@"ArrayOfString1");
                id116_Question_data = Reader.NameTable.Add(@"Question_data");
                id63_Name = Reader.NameTable.Add(@"Name");
                id67_Msg = Reader.NameTable.Add(@"Msg");
                id70_Subject = Reader.NameTable.Add(@"Subject");
                id58_ArrayOfMessage = Reader.NameTable.Add(@"ArrayOfMessage");
                id122_Users = Reader.NameTable.Add(@"Users");
                id42_ArrayOfPlanningItem = Reader.NameTable.Add(@"ArrayOfPlanningItem");
                id81_BirthCountry = Reader.NameTable.Add(@"BirthCountry");
                id5_PlannerSettings = Reader.NameTable.Add(@"PlannerSettings");
                id103_basicgeoloc = Reader.NameTable.Add(@"basicgeoloc");
                id32_ArrayOfAnyType = Reader.NameTable.Add(@"ArrayOfAnyType");
                id92_Periodes = Reader.NameTable.Add(@"Periodes");
                id31_Questions = Reader.NameTable.Add(@"Questions");
                id28_Reflection = Reader.NameTable.Add(@"Reflection");
                id13_UserManager = Reader.NameTable.Add(@"UserManager");
                id78_LastName = Reader.NameTable.Add(@"LastName");
                id102_PlanningItems = Reader.NameTable.Add(@"PlanningItems");
                id64_MaxSize = Reader.NameTable.Add(@"MaxSize");
                id118_RunningSince = Reader.NameTable.Add(@"RunningSince");
                id59_ArrayOfChatRoom = Reader.NameTable.Add(@"ArrayOfChatRoom");
                id83_Language = Reader.NameTable.Add(@"Language");
                id14_ServerLog = Reader.NameTable.Add(@"ServerLog");
                id106_Altitude = Reader.NameTable.Add(@"Altitude");
                id86_rpi = Reader.NameTable.Add(@"rpi");
                id44_ArrayOfString = Reader.NameTable.Add(@"ArrayOfString");
                id111_Feeling = Reader.NameTable.Add(@"Feeling");
                id23_Diary = Reader.NameTable.Add(@"Diary");
                id130_SoundEnabled = Reader.NameTable.Add(@"SoundEnabled");
                id56_ArrayOfLog = Reader.NameTable.Add(@"ArrayOfLog");
                id94_Start = Reader.NameTable.Add(@"Start");
                id120_Logs = Reader.NameTable.Add(@"Logs");
            }
        }

        [System.Runtime.CompilerServices.__BlockReflection]
        public abstract class XmlSerializer1 : System.Xml.Serialization.XmlSerializer {
            protected override System.Xml.Serialization.XmlSerializationReader CreateReader() {
                return new XmlSerializationReader1();
            }
            protected override System.Xml.Serialization.XmlSerializationWriter CreateWriter() {
                return new XmlSerializationWriter1();
            }
        }

        [System.Runtime.CompilerServices.__BlockReflection]
        public sealed class QuestionPacketSerializer : XmlSerializer1 {

            public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
                return xmlReader.IsStartElement(@"QuestionPacket", this.DefaultNamespace ?? @"");
            }

            protected override void Serialize(object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer) {
                ((XmlSerializationWriter1)writer).Write36_QuestionPacket(objectToSerialize, this.DefaultNamespace, @"");
            }

            protected override object Deserialize(System.Xml.Serialization.XmlSerializationReader reader) {
                return ((XmlSerializationReader1)reader).Read36_QuestionPacket(this.DefaultNamespace);
            }
        }

        [System.Runtime.CompilerServices.__BlockReflection]
        public sealed class ServerDataContainerSerializer : XmlSerializer1 {

            public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
                return xmlReader.IsStartElement(@"ServerDataContainer", this.DefaultNamespace ?? @"");
            }

            protected override void Serialize(object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer) {
                ((XmlSerializationWriter1)writer).Write37_ServerDataContainer(objectToSerialize, this.DefaultNamespace, @"");
            }

            protected override object Deserialize(System.Xml.Serialization.XmlSerializationReader reader) {
                return ((XmlSerializationReader1)reader).Read37_ServerDataContainer(this.DefaultNamespace);
            }
        }

        [System.Runtime.CompilerServices.__BlockReflection]
        public sealed class PlanSerializer : XmlSerializer1 {

            public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
                return xmlReader.IsStartElement(@"Plan", this.DefaultNamespace ?? @"");
            }

            protected override void Serialize(object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer) {
                ((XmlSerializationWriter1)writer).Write38_Plan(objectToSerialize, this.DefaultNamespace, @"");
            }

            protected override object Deserialize(System.Xml.Serialization.XmlSerializationReader reader) {
                return ((XmlSerializationReader1)reader).Read38_Plan(this.DefaultNamespace);
            }
        }

        [System.Runtime.CompilerServices.__BlockReflection]
        public sealed class PlannerSettingsSerializer : XmlSerializer1 {

            public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
                return xmlReader.IsStartElement(@"PlannerSettings", this.DefaultNamespace ?? @"");
            }

            protected override void Serialize(object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer) {
                ((XmlSerializationWriter1)writer).Write39_PlannerSettings(objectToSerialize, this.DefaultNamespace, @"");
            }

            protected override object Deserialize(System.Xml.Serialization.XmlSerializationReader reader) {
                return ((XmlSerializationReader1)reader).Read39_PlannerSettings(this.DefaultNamespace);
            }
        }

        [System.Runtime.CompilerServices.__BlockReflection]
        public sealed class ObjectSerializer : XmlSerializer1 {

            public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
                return xmlReader.IsStartElement(@"anyType", this.DefaultNamespace ?? @"");
            }

            protected override void Serialize(object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer) {
                ((XmlSerializationWriter1)writer).Write40_anyType(objectToSerialize, this.DefaultNamespace, @"");
            }

            protected override object Deserialize(System.Xml.Serialization.XmlSerializationReader reader) {
                return ((XmlSerializationReader1)reader).Read40_anyType(this.DefaultNamespace);
            }
        }

        [System.Runtime.CompilerServices.__BlockReflection]
        public sealed class PacketSerializer : XmlSerializer1 {

            public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
                return xmlReader.IsStartElement(@"Packet", this.DefaultNamespace ?? @"");
            }

            protected override void Serialize(object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer) {
                ((XmlSerializationWriter1)writer).Write41_Packet(objectToSerialize, this.DefaultNamespace, @"");
            }

            protected override object Deserialize(System.Xml.Serialization.XmlSerializationReader reader) {
                return ((XmlSerializationReader1)reader).Read41_Packet(this.DefaultNamespace);
            }
        }

        [System.Runtime.CompilerServices.__BlockReflection]
        public sealed class UserSerializer : XmlSerializer1 {

            public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
                return xmlReader.IsStartElement(@"User", this.DefaultNamespace ?? @"");
            }

            protected override void Serialize(object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer) {
                ((XmlSerializationWriter1)writer).Write42_User(objectToSerialize, this.DefaultNamespace, @"");
            }

            protected override object Deserialize(System.Xml.Serialization.XmlSerializationReader reader) {
                return ((XmlSerializationReader1)reader).Read42_User(this.DefaultNamespace);
            }
        }

        [System.Runtime.CompilerServices.__BlockReflection]
        public class XmlSerializerContract : global::System.Xml.Serialization.XmlSerializerImplementation {
            public override global::System.Xml.Serialization.XmlSerializationReader Reader { get { return new XmlSerializationReader1(); } }
            public override global::System.Xml.Serialization.XmlSerializationWriter Writer { get { return new XmlSerializationWriter1(); } }
            System.Collections.IDictionary readMethods = null;
            public override System.Collections.IDictionary ReadMethods {
                get {
                    if (readMethods == null) {
                        System.Collections.IDictionary _tmp = new System.Collections.Generic.Dictionary<string, string>();
                        _tmp[@"Datalab.Server.Packets.QuestionPacket::"] = @"Read36_QuestionPacket";
                        _tmp[@"PlennerServer.Server.ServerDataContainer::ServerDataContainer:True:"] = @"Read37_ServerDataContainer";
                        _tmp[@"DataLab.Data.Planning.Plan::Plan:True:"] = @"Read38_Plan";
                        _tmp[@"DataLab.Storage.PlannerSettings::"] = @"Read39_PlannerSettings";
                        _tmp[@"System.Object::"] = @"Read40_anyType";
                        _tmp[@"Datalab.Server.Packets.Packet::"] = @"Read41_Packet";
                        _tmp[@"DataLab.Data.Users.User::User:True:"] = @"Read42_User";
                        _tmp[@"System.Object::"] = @"Read43_anyType";
                        if (readMethods == null) readMethods = _tmp;
                    }
                    return readMethods;
                }
            }
            System.Collections.IDictionary writeMethods = null;
            public override System.Collections.IDictionary WriteMethods {
                get {
                    if (writeMethods == null) {
                        System.Collections.IDictionary _tmp = new System.Collections.Generic.Dictionary<string, string>();
                        _tmp[@"Datalab.Server.Packets.QuestionPacket::"] = @"Write36_QuestionPacket";
                        _tmp[@"PlennerServer.Server.ServerDataContainer::ServerDataContainer:True:"] = @"Write37_ServerDataContainer";
                        _tmp[@"DataLab.Data.Planning.Plan::Plan:True:"] = @"Write38_Plan";
                        _tmp[@"DataLab.Storage.PlannerSettings::"] = @"Write39_PlannerSettings";
                        _tmp[@"System.Object::"] = @"Write40_anyType";
                        _tmp[@"Datalab.Server.Packets.Packet::"] = @"Write41_Packet";
                        _tmp[@"DataLab.Data.Users.User::User:True:"] = @"Write42_User";
                        _tmp[@"System.Object::"] = @"Write43_anyType";
                        if (writeMethods == null) writeMethods = _tmp;
                    }
                    return writeMethods;
                }
            }
            System.Collections.IDictionary typedSerializers = null;
            public override System.Collections.IDictionary TypedSerializers {
                get {
                    if (typedSerializers == null) {
                        System.Collections.IDictionary _tmp = new System.Collections.Generic.Dictionary<string, System.Xml.Serialization.XmlSerializer>();
                        _tmp.Add(@"DataLab.Data.Users.User::User:True:", new UserSerializer());
                        _tmp.Add(@"Datalab.Server.Packets.QuestionPacket::", new QuestionPacketSerializer());
                        _tmp.Add(@"PlennerServer.Server.ServerDataContainer::ServerDataContainer:True:", new ServerDataContainerSerializer());
                        _tmp.Add(@"System.Object::", new ObjectSerializer());
                        _tmp.Add(@"DataLab.Data.Planning.Plan::Plan:True:", new PlanSerializer());
                        _tmp.Add(@"Datalab.Server.Packets.Packet::", new PacketSerializer());
                        _tmp.Add(@"DataLab.Storage.PlannerSettings::", new PlannerSettingsSerializer());
                        if (typedSerializers == null) typedSerializers = _tmp;
                    }
                    return typedSerializers;
                }
            }
            public override System.Boolean CanSerialize(System.Type type) {
                if (type == typeof(global::Datalab.Server.Packets.QuestionPacket)) return true;
                if (type == typeof(global::PlennerServer.Server.ServerDataContainer)) return true;
                if (type == typeof(global::DataLab.Data.Planning.Plan)) return true;
                if (type == typeof(global::DataLab.Storage.PlannerSettings)) return true;
                if (type == typeof(global::System.Object)) return true;
                if (type == typeof(global::Datalab.Server.Packets.Packet)) return true;
                if (type == typeof(global::DataLab.Data.Users.User)) return true;
                if (type == typeof(global::System.Reflection.TypeInfo)) return true;
                return false;
            }
            public override System.Xml.Serialization.XmlSerializer GetSerializer(System.Type type) {
                if (type == typeof(global::Datalab.Server.Packets.QuestionPacket)) return new QuestionPacketSerializer();
                if (type == typeof(global::PlennerServer.Server.ServerDataContainer)) return new ServerDataContainerSerializer();
                if (type == typeof(global::DataLab.Data.Planning.Plan)) return new PlanSerializer();
                if (type == typeof(global::DataLab.Storage.PlannerSettings)) return new PlannerSettingsSerializer();
                if (type == typeof(global::System.Object)) return new ObjectSerializer();
                if (type == typeof(global::Datalab.Server.Packets.Packet)) return new PacketSerializer();
                if (type == typeof(global::DataLab.Data.Users.User)) return new UserSerializer();
                if (type == typeof(global::System.Object)) return new ObjectSerializer();
                return null;
            }
            public static global::System.Xml.Serialization.XmlSerializerImplementation GetXmlSerializerContract() { return new XmlSerializerContract(); }
        }

        [System.Runtime.CompilerServices.__BlockReflection]
        public static class ActivatorHelper {
            public static object CreateInstance(System.Type type) {
                System.Reflection.TypeInfo ti = System.Reflection.IntrospectionExtensions.GetTypeInfo(type);
                foreach (System.Reflection.ConstructorInfo ci in ti.DeclaredConstructors) {
                    if (!ci.IsStatic && ci.GetParameters().Length == 0) {
                        return ci.Invoke(null);
                    }
                }
                return System.Activator.CreateInstance(type);
            }
        }
    }
