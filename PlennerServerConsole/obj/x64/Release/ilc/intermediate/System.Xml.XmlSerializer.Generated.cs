namespace System.Runtime.CompilerServices {
    internal class __BlockReflectionAttribute : Attribute { }
}

namespace Microsoft.Xml.Serialization.GeneratedAssembly {


    [System.Runtime.CompilerServices.__BlockReflection]
    public class XmlSerializationWriter1 : System.Xml.Serialization.XmlSerializationWriter {

        public void Write34_ServerDataContainer(object o, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs ?? @"";
            WriteStartDocument();
            if (o == null) {
                WriteNullTagLiteral(@"ServerDataContainer", defaultNamespace);
                return;
            }
            TopLevelElement();
            string namespace1 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write29_ServerDataContainer(@"ServerDataContainer", namespace1, ((global::PlennerServer.Server.ServerDataContainer)o), true, false, namespace1, @"");
        }

        public void Write35_Plan(object o, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs ?? @"";
            WriteStartDocument();
            if (o == null) {
                WriteNullTagLiteral(@"Plan", defaultNamespace);
                return;
            }
            TopLevelElement();
            string namespace2 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write21_Plan(@"Plan", namespace2, ((global::DataLab.Data.Planning.Plan)o), true, false, namespace2, @"");
        }

        public void Write36_PlannerSettings(object o, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs ?? @"";
            WriteStartDocument();
            if (o == null) {
                WriteNullTagLiteral(@"PlannerSettings", defaultNamespace);
                return;
            }
            TopLevelElement();
            string namespace3 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write30_PlannerSettings(@"PlannerSettings", namespace3, ((global::DataLab.Storage.PlannerSettings)o), true, false, namespace3, @"");
        }

        public void Write37_anyType(object o, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs ?? @"";
            WriteStartDocument();
            if (o == null) {
                WriteNullTagLiteral(@"anyType", defaultNamespace);
                return;
            }
            TopLevelElement();
            string namespace4 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write2_Object(@"anyType", namespace4, ((global::System.Object)o), true, false, namespace4, @"");
        }

        public void Write38_QuestionPacket(object o, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs ?? @"";
            WriteStartDocument();
            if (o == null) {
                WriteNullTagLiteral(@"QuestionPacket", defaultNamespace);
                return;
            }
            TopLevelElement();
            string namespace5 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write33_QuestionPacket(@"QuestionPacket", namespace5, ((global::Datalab.Server.Packets.QuestionPacket)o), true, false, namespace5, @"");
        }

        public void Write39_Packet(object o, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs ?? @"";
            WriteStartDocument();
            if (o == null) {
                WriteNullTagLiteral(@"Packet", defaultNamespace);
                return;
            }
            TopLevelElement();
            string namespace6 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write31_Packet(@"Packet", namespace6, ((global::Datalab.Server.Packets.Packet)o), true, false, namespace6, @"");
        }

        public void Write40_User(object o, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs ?? @"";
            WriteStartDocument();
            if (o == null) {
                WriteNullTagLiteral(@"User", defaultNamespace);
                return;
            }
            TopLevelElement();
            string namespace7 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write23_User(@"User", namespace7, ((global::DataLab.Data.Users.User)o), true, false, namespace7, @"");
        }

        public void Write41_anyType(object o, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs ?? @"";
            WriteStartDocument();
            if (o == null) {
                WriteNullTagLiteral(@"anyType", defaultNamespace);
                return;
            }
            TopLevelElement();
            string namespace8 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write2_Object(@"anyType", namespace8, ((global::System.Object)o), true, false, namespace8, @"");
        }

        void Write2_Object(string n, string ns, global::System.Object o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::System.Object)) {
                }
                else if (t == typeof(global::Datalab.Server.Packets.Packet)) {
                    Write31_Packet(n, ns,(global::Datalab.Server.Packets.Packet)o, isNullable, true);
                    return;
                }
                else if (t == typeof(global::Datalab.Server.Packets.QuestionPacket)) {
                    Write33_QuestionPacket(n, ns,(global::Datalab.Server.Packets.QuestionPacket)o, isNullable, true);
                    return;
                }
                else if (t == typeof(global::DataLab.Storage.PlannerSettings)) {
                    Write30_PlannerSettings(n, ns,(global::DataLab.Storage.PlannerSettings)o, isNullable, true);
                    return;
                }
                else if (t == typeof(global::PlennerServer.Server.ServerDataContainer)) {
                    Write29_ServerDataContainer(n, ns,(global::PlennerServer.Server.ServerDataContainer)o, isNullable, true);
                    return;
                }
                else if (t == typeof(global::DataLab.Data.Users.Message.MessageManager)) {
                    Write28_MessageManager(n, ns,(global::DataLab.Data.Users.Message.MessageManager)o, isNullable, true);
                    return;
                }
                else if (t == typeof(global::DataLab.Data.Users.Message.ChatManager)) {
                    Write27_ChatManager(n, ns,(global::DataLab.Data.Users.Message.ChatManager)o, isNullable, true);
                    return;
                }
                else if (t == typeof(global::DataLab.Data.Users.Message.Chat.ChatRoom)) {
                    Write26_ChatRoom(n, ns,(global::DataLab.Data.Users.Message.Chat.ChatRoom)o, isNullable, true);
                    return;
                }
                else if (t == typeof(global::DataLab.Data.Users.Message.MailManager)) {
                    Write25_MailManager(n, ns,(global::DataLab.Data.Users.Message.MailManager)o, isNullable, true);
                    return;
                }
                else if (t == typeof(global::DataLab.Data.Users.UserManager)) {
                    Write24_UserManager(n, ns,(global::DataLab.Data.Users.UserManager)o, isNullable, true);
                    return;
                }
                else if (t == typeof(global::DataLab.Data.Users.User)) {
                    Write23_User(n, ns,(global::DataLab.Data.Users.User)o, isNullable, true);
                    return;
                }
                else if (t == typeof(global::DataLab.Data.Users.UserInfo)) {
                    Write22_UserInfo(n, ns,(global::DataLab.Data.Users.UserInfo)o, isNullable, true);
                    return;
                }
                else if (t == typeof(global::DataLab.Data.Planning.Plan)) {
                    Write21_Plan(n, ns,(global::DataLab.Data.Planning.Plan)o, isNullable, true);
                    return;
                }
                else if (t == typeof(global::DataLab.Data.Users.Message.Message)) {
                    Write19_Message(n, ns,(global::DataLab.Data.Users.Message.Message)o, isNullable, true);
                    return;
                }
                else if (t == typeof(global::DataLab.Data.Users.Message.Mail)) {
                    Write20_Mail(n, ns,(global::DataLab.Data.Users.Message.Mail)o, isNullable, true);
                    return;
                }
                else if (t == typeof(global::DataLab.Data.Planning.Diary)) {
                    Write18_Diary(n, ns,(global::DataLab.Data.Planning.Diary)o, isNullable, true);
                    return;
                }
                else if (t == typeof(global::System.TimeSpan)) {
                    Write12_TimeSpan(n, ns,(global::System.TimeSpan)o, true);
                    return;
                }
                else if (t == typeof(global::Windows.Devices.Geolocation.BasicGeoposition)) {
                    Write9_BasicGeoposition(n, ns,(global::Windows.Devices.Geolocation.BasicGeoposition)o, true);
                    return;
                }
                else if (t == typeof(global::DataLab.Data.Planning.PlanningItem)) {
                    Write7_PlanningItem(n, ns,(global::DataLab.Data.Planning.PlanningItem)o, isNullable, true);
                    return;
                }
                else if (t == typeof(global::DataLab.Data.Planning.Reflection)) {
                    Write17_Reflection(n, ns,(global::DataLab.Data.Planning.Reflection)o, isNullable, true);
                    return;
                }
                else if (t == typeof(global::DataLab.Data.Planning.RepeatingPlanningItem)) {
                    Write13_RepeatingPlanningItem(n, ns,(global::DataLab.Data.Planning.RepeatingPlanningItem)o, isNullable, true);
                    return;
                }
                else if (t == typeof(global::DataLab.Data.Planning.Activity)) {
                    Write10_Activity(n, ns,(global::DataLab.Data.Planning.Activity)o, isNullable, true);
                    return;
                }
                else if (t == typeof(global::DataLab.Data.Planning.ToDoItem)) {
                    Write8_ToDoItem(n, ns,(global::DataLab.Data.Planning.ToDoItem)o, isNullable, true);
                    return;
                }
                else if (t == typeof(global::DataLab.Data.Planning.ToDoItemSet)) {
                    Write14_ToDoItemSet(n, ns,(global::DataLab.Data.Planning.ToDoItemSet)o, isNullable, true);
                    return;
                }
                else if (t == typeof(global::DataLab.Server.Controller.Logging.ServerLog)) {
                    Write6_ServerLog(n, ns,(global::DataLab.Server.Controller.Logging.ServerLog)o, isNullable, true);
                    return;
                }
                else if (t == typeof(global::DataLab.Server.Controller.Logging.Log)) {
                    Write5_Log(n, ns,(global::DataLab.Server.Controller.Logging.Log)o, isNullable, true);
                    return;
                }
                else if (t == typeof(global::DataLab.Server.Controller.ServerInfo)) {
                    Write3_ServerInfo(n, ns,(global::DataLab.Server.Controller.ServerInfo)o, isNullable, true);
                    return;
                }
                else if (t == typeof(global::DataLab.Server.Controller.ServerInfo.RunningStatus)) {
                    Writer.WriteStartElement(n, ns);
                    WriteXsiType(@"RunningStatus", @"");
                    Writer.WriteString(Write1_RunningStatus((global::DataLab.Server.Controller.ServerInfo.RunningStatus)o));
                    Writer.WriteEndElement();
                    return;
                }
                else if (t == typeof(global::DataLab.Server.Controller.Logging.Log.LogTypes)) {
                    Writer.WriteStartElement(n, ns);
                    WriteXsiType(@"LogTypes", @"");
                    Writer.WriteString(Write4_LogTypes((global::DataLab.Server.Controller.Logging.Log.LogTypes)o));
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
                                string namespace9 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                                Write5_Log(@"Log", namespace9, ((global::DataLab.Server.Controller.Logging.Log)a[ia]), true, false, namespace9, @"");
                            }
                        }
                    }
                    Writer.WriteEndElement();
                    return;
                }
                else if (t == typeof(global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Planning.ToDoItem>)) {
                    Writer.WriteStartElement(n, ns);
                    WriteXsiType(@"ArrayOfToDoItem", @"");
                    {
                        global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Planning.ToDoItem> a = (global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Planning.ToDoItem>)o;
                        if (a != null) {
                            for (int ia = 0; ia < ((System.Collections.ICollection)a).Count; ia++) {
                                string namespace10 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                                Write8_ToDoItem(@"ToDoItem", namespace10, ((global::DataLab.Data.Planning.ToDoItem)a[ia]), true, false, namespace10, @"");
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
                                string namespace11 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                                Write10_Activity(@"Activity", namespace11, ((global::DataLab.Data.Planning.Activity)a[ia]), true, false, namespace11, @"");
                            }
                        }
                    }
                    Writer.WriteEndElement();
                    return;
                }
                else if (t == typeof(global::System.DayOfWeek)) {
                    Writer.WriteStartElement(n, ns);
                    WriteXsiType(@"DayOfWeek", @"");
                    Writer.WriteString(Write11_DayOfWeek((global::System.DayOfWeek)o));
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
                                string namespace12 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                                WriteElementString(@"DayOfWeek", namespace12, Write11_DayOfWeek(((global::System.DayOfWeek)a[ia])));
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
                                string namespace13 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                                Write13_RepeatingPlanningItem(@"RepeatingPlanningItem", namespace13, ((global::DataLab.Data.Planning.RepeatingPlanningItem)a[ia]), true, false, namespace13, @"");
                            }
                        }
                    }
                    Writer.WriteEndElement();
                    return;
                }
                else if (t == typeof(global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Planning.ToDoItemSet>)) {
                    Writer.WriteStartElement(n, ns);
                    WriteXsiType(@"ArrayOfToDoItemSet", @"");
                    {
                        global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Planning.ToDoItemSet> a = (global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Planning.ToDoItemSet>)o;
                        if (a != null) {
                            for (int ia = 0; ia < ((System.Collections.ICollection)a).Count; ia++) {
                                string namespace14 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                                Write14_ToDoItemSet(@"ToDoItemSet", namespace14, ((global::DataLab.Data.Planning.ToDoItemSet)a[ia]), true, false, namespace14, @"");
                            }
                        }
                    }
                    Writer.WriteEndElement();
                    return;
                }
                else if (t == typeof(global::Windows.Graphics.Imaging.BitmapPixelFormat)) {
                    Writer.WriteStartElement(n, ns);
                    WriteXsiType(@"BitmapPixelFormat", @"");
                    Writer.WriteString(Write15_BitmapPixelFormat((global::Windows.Graphics.Imaging.BitmapPixelFormat)o));
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
                                string namespace15 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                                WriteElementStringRaw(@"int", namespace15, System.Xml.XmlConvert.ToString((global::System.Int32)((global::System.Int32)a[ia])));
                            }
                        }
                    }
                    Writer.WriteEndElement();
                    return;
                }
                else if (t == typeof(global::DataLab.Data.Planning.Reflection.Feelings)) {
                    Writer.WriteStartElement(n, ns);
                    WriteXsiType(@"Feelings", @"");
                    Writer.WriteString(Write16_Feelings((global::DataLab.Data.Planning.Reflection.Feelings)o));
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
                                string namespace16 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                                Write17_Reflection(@"Reflection", namespace16, ((global::DataLab.Data.Planning.Reflection)a[ia]), true, false, namespace16, @"");
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
                                string namespace17 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                                Write7_PlanningItem(@"PlanningItem", namespace17, ((global::DataLab.Data.Planning.PlanningItem)a[ia]), true, false, namespace17, @"");
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
                                string namespace18 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                                Write18_Diary(@"Diary", namespace18, ((global::DataLab.Data.Planning.Diary)a[ia]), true, false, namespace18, @"");
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
                                string namespace19 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                                WriteNullableStringLiteral(@"string", namespace19, ((global::System.String)a[ia]));
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
                                string namespace20 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                                Write20_Mail(@"Mail", namespace20, ((global::DataLab.Data.Users.Message.Mail)a[ia]), true, false, namespace20, @"");
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
                                string namespace21 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                                WriteNullableStringLiteral(@"Hobbie", namespace21, ((global::System.String)a[ia]));
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
                                string namespace22 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                                WriteNullableStringLiteral(@"Friend", namespace22, ((global::System.String)a[ia]));
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
                                string namespace23 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                                Write23_User(@"User", namespace23, ((global::DataLab.Data.Users.User)a[ia]), true, false, namespace23, @"");
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
                                string namespace24 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                                Write20_Mail(@"Mail", namespace24, ((global::DataLab.Data.Users.Message.Mail)a[ia]), true, false, namespace24, @"");
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
                                string namespace25 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                                Write23_User(@"User", namespace25, ((global::DataLab.Data.Users.User)a[ia]), true, false, namespace25, @"");
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
                                string namespace26 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                                Write19_Message(@"Message", namespace26, ((global::DataLab.Data.Users.Message.Message)a[ia]), true, false, namespace26, @"");
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
                                string namespace27 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                                Write26_ChatRoom(@"ChatRoom", namespace27, ((global::DataLab.Data.Users.Message.Chat.ChatRoom)a[ia]), true, false, namespace27, @"");
                            }
                        }
                    }
                    Writer.WriteEndElement();
                    return;
                }
                else if (t == typeof(global::Datalab.Server.Packets.QuestionPacket.Questions)) {
                    Writer.WriteStartElement(n, ns);
                    WriteXsiType(@"Questions", @"");
                    Writer.WriteString(Write32_Questions((global::Datalab.Server.Packets.QuestionPacket.Questions)o));
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
                                string namespace28 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                                Write2_Object(@"anyType", namespace28, ((global::System.Object)a[ia]), true, false, namespace28, @"");
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

        string Write32_Questions(global::Datalab.Server.Packets.QuestionPacket.Questions v) {
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

        void Write26_ChatRoom(string n, string ns, global::DataLab.Data.Users.Message.Chat.ChatRoom o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
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
            string namespace29 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            {
                global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Users.User> a = (global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Users.User>)((global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Users.User>)o.@Participants);
                if (a != null){
                    WriteStartElement(@"Participants", namespace29, null, false);
                    for (int ia = 0; ia < ((System.Collections.ICollection)a).Count; ia++) {
                        string namespace30 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                        Write23_User(@"User", namespace30, ((global::DataLab.Data.Users.User)a[ia]), true, false, namespace30, @"");
                    }
                    WriteEndElement();
                }
            }
            string namespace31 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            {
                global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Users.Message.Message> a = (global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Users.Message.Message>)((global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Users.Message.Message>)o.@ChatMessages);
                if (a != null){
                    WriteStartElement(@"ChatMessages", namespace31, null, false);
                    for (int ia = 0; ia < ((System.Collections.ICollection)a).Count; ia++) {
                        string namespace32 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                        Write19_Message(@"Message", namespace32, ((global::DataLab.Data.Users.Message.Message)a[ia]), true, false, namespace32, @"");
                    }
                    WriteEndElement();
                }
            }
            string namespace33 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            WriteElementStringRaw(@"ID", namespace33, System.Xml.XmlConvert.ToString((global::System.Int32)((global::System.Int32)o.@ID)));
            string namespace34 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            WriteElementString(@"Name", namespace34, ((global::System.String)o.@Name));
            string namespace35 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            WriteElementStringRaw(@"MaxSize", namespace35, System.Xml.XmlConvert.ToString((global::System.Int32)((global::System.Int32)o.@MaxSize)));
            WriteEndElement(o);
        }

        void Write19_Message(string n, string ns, global::DataLab.Data.Users.Message.Message o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
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
                    Write20_Mail(n, ns,(global::DataLab.Data.Users.Message.Mail)o, isNullable, true);
                    return;
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
        }

        void Write20_Mail(string n, string ns, global::DataLab.Data.Users.Message.Mail o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
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
            string namespace36 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            WriteElementString(@"Sender", namespace36, ((global::System.String)o.@Sender));
            string namespace37 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            {
                global::System.Collections.Generic.List<global::System.String> a = (global::System.Collections.Generic.List<global::System.String>)((global::System.Collections.Generic.List<global::System.String>)o.@Recepients);
                if (a != null){
                    WriteStartElement(@"Recepients", namespace37, null, false);
                    for (int ia = 0; ia < ((System.Collections.ICollection)a).Count; ia++) {
                        string namespace38 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                        WriteNullableStringLiteral(@"string", namespace38, ((global::System.String)a[ia]));
                    }
                    WriteEndElement();
                }
            }
            string namespace39 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            WriteElementString(@"Msg", namespace39, ((global::System.String)o.@Msg));
            string namespace40 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            WriteElementString(@"TimeSent", namespace40, ((global::System.String)o.@TimeSent));
            string namespace41 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            WriteElementStringRaw(@"SentOn", namespace41, FromDateTime(((global::System.DateTime)o.@SentOn)));
            string namespace42 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            WriteElementString(@"Subject", namespace42, ((global::System.String)o.@Subject));
            string namespace43 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            WriteElementStringRaw(@"wasRead", namespace43, System.Xml.XmlConvert.ToString((global::System.Boolean)((global::System.Boolean)o.@wasRead)));
            WriteEndElement(o);
        }

        void Write23_User(string n, string ns, global::DataLab.Data.Users.User o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
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
            string namespace44 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write21_Plan(@"Plan", namespace44, ((global::DataLab.Data.Planning.Plan)o.@plan), false, false, namespace44, @"");
            string namespace45 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            {
                global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Users.Message.Mail> a = (global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Users.Message.Mail>)((global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Users.Message.Mail>)o.@Mails);
                if (a != null){
                    WriteStartElement(@"Mails", namespace45, null, false);
                    for (int ia = 0; ia < ((System.Collections.ICollection)a).Count; ia++) {
                        string namespace46 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                        Write20_Mail(@"Mail", namespace46, ((global::DataLab.Data.Users.Message.Mail)a[ia]), true, false, namespace46, @"");
                    }
                    WriteEndElement();
                }
            }
            string namespace47 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            WriteElementStringRaw(@"LastDataSync", namespace47, FromDateTime(((global::System.DateTime)o.@LastDataSync)));
            string namespace48 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write22_UserInfo(@"UserInfo", namespace48, ((global::DataLab.Data.Users.UserInfo)o.@UserInfo), false, false, namespace48, @"");
            string namespace49 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            {
                global::System.Collections.ObjectModel.ObservableCollection<global::System.String> a = (global::System.Collections.ObjectModel.ObservableCollection<global::System.String>)((global::System.Collections.ObjectModel.ObservableCollection<global::System.String>)o.@Friends);
                if (a != null){
                    WriteStartElement(@"Friends", namespace49, null, false);
                    for (int ia = 0; ia < ((System.Collections.ICollection)a).Count; ia++) {
                        string namespace50 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                        WriteNullableStringLiteral(@"Friend", namespace50, ((global::System.String)a[ia]));
                    }
                    WriteEndElement();
                }
            }
            WriteEndElement(o);
        }

        void Write22_UserInfo(string n, string ns, global::DataLab.Data.Users.UserInfo o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
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
            string namespace51 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            {
                global::System.Collections.ObjectModel.ObservableCollection<global::System.String> a = (global::System.Collections.ObjectModel.ObservableCollection<global::System.String>)((global::System.Collections.ObjectModel.ObservableCollection<global::System.String>)o.@Hobbies);
                if (a != null){
                    WriteStartElement(@"Hobbies", namespace51, null, false);
                    for (int ia = 0; ia < ((System.Collections.ICollection)a).Count; ia++) {
                        string namespace52 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                        WriteNullableStringLiteral(@"Hobbie", namespace52, ((global::System.String)a[ia]));
                    }
                    WriteEndElement();
                }
            }
            string namespace53 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            WriteElementString(@"BirthCountry", namespace53, ((global::System.String)o.@BirthCountry));
            string namespace54 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            WriteElementString(@"CountryOfLiving", namespace54, ((global::System.String)o.@CountryOfLiving));
            string namespace55 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            WriteElementString(@"Language", namespace55, ((global::System.String)o.@Language));
            string namespace56 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            {
                global::System.Collections.Generic.List<global::System.String> a = (global::System.Collections.Generic.List<global::System.String>)((global::System.Collections.Generic.List<global::System.String>)o.@FriendNames);
                if (a != null){
                    WriteStartElement(@"FriendNames", namespace56, null, false);
                    for (int ia = 0; ia < ((System.Collections.ICollection)a).Count; ia++) {
                        string namespace57 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                        WriteNullableStringLiteral(@"string", namespace57, ((global::System.String)a[ia]));
                    }
                    WriteEndElement();
                }
            }
            WriteEndElement(o);
        }

        void Write21_Plan(string n, string ns, global::DataLab.Data.Planning.Plan o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
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
            string namespace58 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            {
                global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Planning.ToDoItem> a = (global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Planning.ToDoItem>)((global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Planning.ToDoItem>)o.@ToDoItems);
                if (a != null){
                    WriteStartElement(@"ToDoItems", namespace58, null, false);
                    for (int ia = 0; ia < ((System.Collections.ICollection)a).Count; ia++) {
                        string namespace59 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                        Write8_ToDoItem(@"ToDoItem", namespace59, ((global::DataLab.Data.Planning.ToDoItem)a[ia]), true, false, namespace59, @"");
                    }
                    WriteEndElement();
                }
            }
            string namespace60 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            {
                global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Planning.Activity> a = (global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Planning.Activity>)((global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Planning.Activity>)o.@Activities);
                if (a != null){
                    WriteStartElement(@"Activities", namespace60, null, false);
                    for (int ia = 0; ia < ((System.Collections.ICollection)a).Count; ia++) {
                        string namespace61 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                        Write10_Activity(@"Activity", namespace61, ((global::DataLab.Data.Planning.Activity)a[ia]), true, false, namespace61, @"");
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
                        Write13_RepeatingPlanningItem(@"RepeatingPlanningItem", namespace63, ((global::DataLab.Data.Planning.RepeatingPlanningItem)a[ia]), true, false, namespace63, @"");
                    }
                    WriteEndElement();
                }
            }
            string namespace64 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            {
                global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Planning.ToDoItemSet> a = (global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Planning.ToDoItemSet>)((global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Planning.ToDoItemSet>)o.@tdiSets);
                if (a != null){
                    WriteStartElement(@"tdiSets", namespace64, null, false);
                    for (int ia = 0; ia < ((System.Collections.ICollection)a).Count; ia++) {
                        string namespace65 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                        Write14_ToDoItemSet(@"ToDoItemSet", namespace65, ((global::DataLab.Data.Planning.ToDoItemSet)a[ia]), true, false, namespace65, @"");
                    }
                    WriteEndElement();
                }
            }
            string namespace66 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            {
                global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Planning.Reflection> a = (global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Planning.Reflection>)((global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Planning.Reflection>)o.@Reflections);
                if (a != null){
                    WriteStartElement(@"Reflections", namespace66, null, false);
                    for (int ia = 0; ia < ((System.Collections.ICollection)a).Count; ia++) {
                        string namespace67 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                        Write17_Reflection(@"Reflection", namespace67, ((global::DataLab.Data.Planning.Reflection)a[ia]), true, false, namespace67, @"");
                    }
                    WriteEndElement();
                }
            }
            string namespace68 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            {
                global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Planning.Diary> a = (global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Planning.Diary>)((global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Planning.Diary>)o.@Diaries);
                if (a != null){
                    WriteStartElement(@"Diaries", namespace68, null, false);
                    for (int ia = 0; ia < ((System.Collections.ICollection)a).Count; ia++) {
                        string namespace69 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                        Write18_Diary(@"Diary", namespace69, ((global::DataLab.Data.Planning.Diary)a[ia]), true, false, namespace69, @"");
                    }
                    WriteEndElement();
                }
            }
            string namespace70 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            {
                global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Users.Message.Mail> a = (global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Users.Message.Mail>)((global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Users.Message.Mail>)o.@Mails);
                if (a != null){
                    WriteStartElement(@"Mails", namespace70, null, false);
                    for (int ia = 0; ia < ((System.Collections.ICollection)a).Count; ia++) {
                        string namespace71 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                        Write20_Mail(@"Mail", namespace71, ((global::DataLab.Data.Users.Message.Mail)a[ia]), true, false, namespace71, @"");
                    }
                    WriteEndElement();
                }
            }
            WriteEndElement(o);
        }

        void Write18_Diary(string n, string ns, global::DataLab.Data.Planning.Diary o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
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
            string namespace72 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            WriteElementString(@"Name", namespace72, ((global::System.String)o.@Name));
            string namespace73 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            WriteElementStringRaw(@"StartTime", namespace73, FromDateTime(((global::System.DateTime)o.@StartTime)));
            string namespace74 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            WriteElementStringRaw(@"EndTime", namespace74, FromDateTime(((global::System.DateTime)o.@EndTime)));
            string namespace75 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            {
                global::System.Collections.Generic.List<global::DataLab.Data.Planning.PlanningItem> a = (global::System.Collections.Generic.List<global::DataLab.Data.Planning.PlanningItem>)((global::System.Collections.Generic.List<global::DataLab.Data.Planning.PlanningItem>)o.@PlanningItems);
                if (a != null){
                    WriteStartElement(@"PlanningItems", namespace75, null, false);
                    for (int ia = 0; ia < ((System.Collections.ICollection)a).Count; ia++) {
                        string namespace76 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                        Write7_PlanningItem(@"PlanningItem", namespace76, ((global::DataLab.Data.Planning.PlanningItem)a[ia]), true, false, namespace76, @"");
                    }
                    WriteEndElement();
                }
            }
            WriteEndElement(o);
        }

        void Write7_PlanningItem(string n, string ns, global::DataLab.Data.Planning.PlanningItem o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::DataLab.Data.Planning.PlanningItem)) {
                }
                else if (t == typeof(global::DataLab.Data.Planning.Reflection)) {
                    Write17_Reflection(n, ns,(global::DataLab.Data.Planning.Reflection)o, isNullable, true);
                    return;
                }
                else if (t == typeof(global::DataLab.Data.Planning.RepeatingPlanningItem)) {
                    Write13_RepeatingPlanningItem(n, ns,(global::DataLab.Data.Planning.RepeatingPlanningItem)o, isNullable, true);
                    return;
                }
                else if (t == typeof(global::DataLab.Data.Planning.Activity)) {
                    Write10_Activity(n, ns,(global::DataLab.Data.Planning.Activity)o, isNullable, true);
                    return;
                }
                else if (t == typeof(global::DataLab.Data.Planning.ToDoItem)) {
                    Write8_ToDoItem(n, ns,(global::DataLab.Data.Planning.ToDoItem)o, isNullable, true);
                    return;
                }
                else if (t == typeof(global::DataLab.Data.Planning.ToDoItemSet)) {
                    Write14_ToDoItemSet(n, ns,(global::DataLab.Data.Planning.ToDoItemSet)o, isNullable, true);
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

        void Write14_ToDoItemSet(string n, string ns, global::DataLab.Data.Planning.ToDoItemSet o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::DataLab.Data.Planning.ToDoItemSet)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"ToDoItemSet", defaultNamespace);
            WriteAttribute(@"Name", @"", ((global::System.String)o.@Name));
            WriteAttribute(@"Silent", @"", System.Xml.XmlConvert.ToString((global::System.Boolean)((global::System.Boolean)o.@Silent)));
            WriteAttribute(@"MinutesToAlertBeforeActualAlarm", @"", System.Xml.XmlConvert.ToString((global::System.Int32)((global::System.Int32)o.@MinutesToAlertBeforeActualAlarm)));
            WriteAttribute(@"IsDone", @"", System.Xml.XmlConvert.ToString((global::System.Boolean)((global::System.Boolean)o.@IsDone)));
            WriteAttribute(@"Deadline", @"", FromDateTime(((global::System.DateTime)o.@Deadline)));
            WriteAttribute(@"CompletedAt", @"", FromDateTime(((global::System.DateTime)o.@CompletedAt)));
            WriteAttribute(@"Description", @"", ((global::System.String)o.@Description));
            string namespace77 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            {
                global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Planning.ToDoItem> a = (global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Planning.ToDoItem>)((global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Planning.ToDoItem>)o.@Children);
                if (a != null){
                    WriteStartElement(@"ToDoItemSet", namespace77, null, false);
                    for (int ia = 0; ia < ((System.Collections.ICollection)a).Count; ia++) {
                        string namespace78 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                        Write8_ToDoItem(@"ToDoItem", namespace78, ((global::DataLab.Data.Planning.ToDoItem)a[ia]), true, false, namespace78, @"");
                    }
                    WriteEndElement();
                }
            }
            WriteEndElement(o);
        }

        void Write8_ToDoItem(string n, string ns, global::DataLab.Data.Planning.ToDoItem o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::DataLab.Data.Planning.ToDoItem)) {
                }
                else if (t == typeof(global::DataLab.Data.Planning.ToDoItemSet)) {
                    Write14_ToDoItemSet(n, ns,(global::DataLab.Data.Planning.ToDoItemSet)o, isNullable, true);
                    return;
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"ToDoItem", defaultNamespace);
            WriteAttribute(@"Name", @"", ((global::System.String)o.@Name));
            WriteAttribute(@"Silent", @"", System.Xml.XmlConvert.ToString((global::System.Boolean)((global::System.Boolean)o.@Silent)));
            WriteAttribute(@"MinutesToAlertBeforeActualAlarm", @"", System.Xml.XmlConvert.ToString((global::System.Int32)((global::System.Int32)o.@MinutesToAlertBeforeActualAlarm)));
            WriteAttribute(@"IsDone", @"", System.Xml.XmlConvert.ToString((global::System.Boolean)((global::System.Boolean)o.@IsDone)));
            WriteAttribute(@"Deadline", @"", FromDateTime(((global::System.DateTime)o.@Deadline)));
            WriteAttribute(@"CompletedAt", @"", FromDateTime(((global::System.DateTime)o.@CompletedAt)));
            WriteAttribute(@"Description", @"", ((global::System.String)o.@Description));
            WriteEndElement(o);
        }

        void Write10_Activity(string n, string ns, global::DataLab.Data.Planning.Activity o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
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
            string namespace79 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write9_BasicGeoposition(@"basicgeoloc", namespace79, ((global::Windows.Devices.Geolocation.BasicGeoposition)o.@basicgeoloc), false, namespace79, @"");
            string namespace80 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            WriteElementStringRaw(@"End", namespace80, FromDateTime(((global::System.DateTime)o.@End)));
            WriteEndElement(o);
        }

        void Write9_BasicGeoposition(string n, string ns, global::Windows.Devices.Geolocation.BasicGeoposition o, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
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
            string namespace81 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            WriteElementStringRaw(@"Latitude", namespace81, System.Xml.XmlConvert.ToString((global::System.Double)((global::System.Double)o.@Latitude)));
            string namespace82 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            WriteElementStringRaw(@"Longitude", namespace82, System.Xml.XmlConvert.ToString((global::System.Double)((global::System.Double)o.@Longitude)));
            string namespace83 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            WriteElementStringRaw(@"Altitude", namespace83, System.Xml.XmlConvert.ToString((global::System.Double)((global::System.Double)o.@Altitude)));
            WriteEndElement(o);
        }

        void Write13_RepeatingPlanningItem(string n, string ns, global::DataLab.Data.Planning.RepeatingPlanningItem o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
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
            string namespace84 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write7_PlanningItem(@"Item", namespace84, ((global::DataLab.Data.Planning.PlanningItem)o.@Item), false, false, namespace84, @"");
            string namespace85 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            {
                global::System.Collections.Generic.List<global::System.DayOfWeek> a = (global::System.Collections.Generic.List<global::System.DayOfWeek>)((global::System.Collections.Generic.List<global::System.DayOfWeek>)o.@Days);
                if (a != null){
                    WriteStartElement(@"Days", namespace85, null, false);
                    for (int ia = 0; ia < ((System.Collections.ICollection)a).Count; ia++) {
                        string namespace86 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                        WriteElementString(@"DayOfWeek", namespace86, Write11_DayOfWeek(((global::System.DayOfWeek)a[ia])));
                    }
                    WriteEndElement();
                }
            }
            string namespace87 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write12_TimeSpan(@"Time", namespace87, ((global::System.TimeSpan)o.@Time), false, namespace87, @"");
            WriteEndElement(o);
        }

        void Write12_TimeSpan(string n, string ns, global::System.TimeSpan o, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
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

        string Write11_DayOfWeek(global::System.DayOfWeek v) {
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

        void Write17_Reflection(string n, string ns, global::DataLab.Data.Planning.Reflection o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
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
            WriteAttribute(@"BitmapPixelFormat", @"", Write15_BitmapPixelFormat(((global::Windows.Graphics.Imaging.BitmapPixelFormat)o.@Format)));
            WriteAttribute(@"Description", @"", ((global::System.String)o.@Description));
            WriteAttribute(@"Time", @"", FromDateTime(((global::System.DateTime)o.@Time)));
            WriteAttribute(@"Feeling", @"", Write16_Feelings(((global::DataLab.Data.Planning.Reflection.Feelings)o.@Feeling)));
            string namespace88 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            WriteElementString(@"PhotoLocation", namespace88, ((global::System.String)o.@PhotoLocation));
            string namespace89 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            {
                global::System.Int32[] a = (global::System.Int32[])((global::System.Int32[])o.@Dimension);
                if (a != null){
                    WriteStartElement(@"Dimension", namespace89, null, false);
                    for (int ia = 0; ia < a.Length; ia++) {
                        string namespace90 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                        WriteElementStringRaw(@"int", namespace90, System.Xml.XmlConvert.ToString((global::System.Int32)((global::System.Int32)a[ia])));
                    }
                    WriteEndElement();
                }
            }
            string namespace91 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write9_BasicGeoposition(@"basicgeoloc", namespace91, ((global::Windows.Devices.Geolocation.BasicGeoposition)o.@basicgeoloc), false, namespace91, @"");
            WriteEndElement(o);
        }

        string Write16_Feelings(global::DataLab.Data.Planning.Reflection.Feelings v) {
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

        string Write15_BitmapPixelFormat(global::Windows.Graphics.Imaging.BitmapPixelFormat v) {
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

        void Write5_Log(string n, string ns, global::DataLab.Server.Controller.Logging.Log o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
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
            string namespace92 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            WriteElementStringRaw(@"Time", namespace92, FromDateTime(((global::System.DateTime)o.@Time)));
            string namespace93 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            WriteElementString(@"Message", namespace93, ((global::System.String)o.@Message));
            string namespace94 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            WriteElementString(@"LogType", namespace94, Write4_LogTypes(((global::DataLab.Server.Controller.Logging.Log.LogTypes)o.@LogType)));
            WriteEndElement(o);
        }

        string Write4_LogTypes(global::DataLab.Server.Controller.Logging.Log.LogTypes v) {
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

        string Write1_RunningStatus(global::DataLab.Server.Controller.ServerInfo.RunningStatus v) {
            string s = null;
            switch (v) {
                case global::DataLab.Server.Controller.ServerInfo.RunningStatus.@STOP: s = @"STOP"; break;
                case global::DataLab.Server.Controller.ServerInfo.RunningStatus.@PAUSED: s = @"PAUSED"; break;
                case global::DataLab.Server.Controller.ServerInfo.RunningStatus.@RUNNING: s = @"RUNNING"; break;
                default: throw CreateInvalidEnumValueException(((System.Int64)v).ToString(System.Globalization.CultureInfo.InvariantCulture), @"DataLab.Server.Controller.ServerInfo.RunningStatus");
            }
            return s;
        }

        void Write3_ServerInfo(string n, string ns, global::DataLab.Server.Controller.ServerInfo o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
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
            string namespace95 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            WriteElementString(@"Name", namespace95, ((global::System.String)o.@Name));
            string namespace96 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            WriteElementStringRaw(@"RunningSince", namespace96, FromDateTime(((global::System.DateTime)o.@RunningSince)));
            string namespace97 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            WriteElementString(@"RunStatus", namespace97, Write1_RunningStatus(((global::DataLab.Server.Controller.ServerInfo.RunningStatus)o.@RunStatus)));
            WriteEndElement(o);
        }

        void Write6_ServerLog(string n, string ns, global::DataLab.Server.Controller.Logging.ServerLog o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
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
            string namespace98 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            {
                global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Server.Controller.Logging.Log> a = (global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Server.Controller.Logging.Log>)((global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Server.Controller.Logging.Log>)o.@Logs);
                if (a != null){
                    WriteStartElement(@"Logs", namespace98, null, false);
                    for (int ia = 0; ia < ((System.Collections.ICollection)a).Count; ia++) {
                        string namespace99 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                        Write5_Log(@"Log", namespace99, ((global::DataLab.Server.Controller.Logging.Log)a[ia]), true, false, namespace99, @"");
                    }
                    WriteEndElement();
                }
            }
            string namespace100 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            {
                global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Server.Controller.Logging.Log> a = (global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Server.Controller.Logging.Log>)((global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Server.Controller.Logging.Log>)o.@LogHistory);
                if (a != null){
                    WriteStartElement(@"LogHistory", namespace100, null, false);
                    for (int ia = 0; ia < ((System.Collections.ICollection)a).Count; ia++) {
                        string namespace101 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                        Write5_Log(@"Log", namespace101, ((global::DataLab.Server.Controller.Logging.Log)a[ia]), true, false, namespace101, @"");
                    }
                    WriteEndElement();
                }
            }
            WriteEndElement(o);
        }

        void Write24_UserManager(string n, string ns, global::DataLab.Data.Users.UserManager o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
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
            string namespace102 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            {
                global::System.Collections.Generic.List<global::DataLab.Data.Users.User> a = (global::System.Collections.Generic.List<global::DataLab.Data.Users.User>)((global::System.Collections.Generic.List<global::DataLab.Data.Users.User>)o.@Users);
                if (a != null){
                    WriteStartElement(@"Users", namespace102, null, false);
                    for (int ia = 0; ia < ((System.Collections.ICollection)a).Count; ia++) {
                        string namespace103 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                        Write23_User(@"User", namespace103, ((global::DataLab.Data.Users.User)a[ia]), true, false, namespace103, @"");
                    }
                    WriteEndElement();
                }
            }
            WriteEndElement(o);
        }

        void Write25_MailManager(string n, string ns, global::DataLab.Data.Users.Message.MailManager o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
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
            string namespace104 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            {
                global::System.Collections.Generic.List<global::DataLab.Data.Users.Message.Mail> a = (global::System.Collections.Generic.List<global::DataLab.Data.Users.Message.Mail>)((global::System.Collections.Generic.List<global::DataLab.Data.Users.Message.Mail>)o.@Mails);
                if (a != null){
                    WriteStartElement(@"Mails", namespace104, null, false);
                    for (int ia = 0; ia < ((System.Collections.ICollection)a).Count; ia++) {
                        string namespace105 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                        Write20_Mail(@"Mail", namespace105, ((global::DataLab.Data.Users.Message.Mail)a[ia]), true, false, namespace105, @"");
                    }
                    WriteEndElement();
                }
            }
            WriteEndElement(o);
        }

        void Write27_ChatManager(string n, string ns, global::DataLab.Data.Users.Message.ChatManager o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
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
            string namespace106 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            {
                global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Users.Message.Chat.ChatRoom> a = (global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Users.Message.Chat.ChatRoom>)((global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Users.Message.Chat.ChatRoom>)o.@ChatRooms);
                if (a != null){
                    WriteStartElement(@"ChatRooms", namespace106, null, false);
                    for (int ia = 0; ia < ((System.Collections.ICollection)a).Count; ia++) {
                        string namespace107 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                        Write26_ChatRoom(@"ChatRoom", namespace107, ((global::DataLab.Data.Users.Message.Chat.ChatRoom)a[ia]), true, false, namespace107, @"");
                    }
                    WriteEndElement();
                }
            }
            string namespace108 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            {
                global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Users.Message.Chat.ChatRoom> a = (global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Users.Message.Chat.ChatRoom>)((global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Users.Message.Chat.ChatRoom>)o.@ChatHistory);
                if (a != null){
                    WriteStartElement(@"ChatHistory", namespace108, null, false);
                    for (int ia = 0; ia < ((System.Collections.ICollection)a).Count; ia++) {
                        string namespace109 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                        Write26_ChatRoom(@"ChatRoom", namespace109, ((global::DataLab.Data.Users.Message.Chat.ChatRoom)a[ia]), true, false, namespace109, @"");
                    }
                    WriteEndElement();
                }
            }
            WriteEndElement(o);
        }

        void Write28_MessageManager(string n, string ns, global::DataLab.Data.Users.Message.MessageManager o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
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
            string namespace110 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write25_MailManager(@"MailMan", namespace110, ((global::DataLab.Data.Users.Message.MailManager)o.@MailMan), false, false, namespace110, @"");
            string namespace111 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write27_ChatManager(@"ChatMan", namespace111, ((global::DataLab.Data.Users.Message.ChatManager)o.@ChatMan), false, false, namespace111, @"");
            WriteEndElement(o);
        }

        void Write29_ServerDataContainer(string n, string ns, global::PlennerServer.Server.ServerDataContainer o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
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
            string namespace112 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write3_ServerInfo(@"Info", namespace112, ((global::DataLab.Server.Controller.ServerInfo)o.@Info), false, false, namespace112, @"");
            string namespace113 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write6_ServerLog(@"Log", namespace113, ((global::DataLab.Server.Controller.Logging.ServerLog)o.@Log), false, false, namespace113, @"");
            string namespace114 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write24_UserManager(@"Uman", namespace114, ((global::DataLab.Data.Users.UserManager)o.@Uman), false, false, namespace114, @"");
            string namespace115 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write28_MessageManager(@"MsgMan", namespace115, ((global::DataLab.Data.Users.Message.MessageManager)o.@MsgMan), false, false, namespace115, @"");
            WriteEndElement(o);
        }

        void Write30_PlannerSettings(string n, string ns, global::DataLab.Storage.PlannerSettings o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
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
            string namespace116 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            WriteElementStringRaw(@"SoundEnabled", namespace116, System.Xml.XmlConvert.ToString((global::System.Boolean)((global::System.Boolean)o.@SoundEnabled)));
            string namespace117 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            WriteElementStringRaw(@"AutoSyncAccount", namespace117, System.Xml.XmlConvert.ToString((global::System.Boolean)((global::System.Boolean)o.@AutoSyncAccount)));
            string namespace118 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            WriteElementStringRaw(@"AutoLogIn", namespace118, System.Xml.XmlConvert.ToString((global::System.Boolean)((global::System.Boolean)o.@AutoLogIn)));
            string namespace119 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            {
                global::System.Int32[] a = (global::System.Int32[])((global::System.Int32[])o.@PlanningItemExperationTimeSpanAsIntArray);
                if (a != null){
                    WriteStartElement(@"PlanningItemExperationTimeSpanAsIntArray", namespace119, null, false);
                    for (int ia = 0; ia < a.Length; ia++) {
                        string namespace120 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                        WriteElementStringRaw(@"int", namespace120, System.Xml.XmlConvert.ToString((global::System.Int32)((global::System.Int32)a[ia])));
                    }
                    WriteEndElement();
                }
            }
            string namespace121 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            WriteElementStringRaw(@"EnableNotifications", namespace121, System.Xml.XmlConvert.ToString((global::System.Boolean)((global::System.Boolean)o.@EnableNotifications)));
            WriteEndElement(o);
        }

        void Write33_QuestionPacket(string n, string ns, global::Datalab.Server.Packets.QuestionPacket o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
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
            string namespace122 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            WriteElementString(@"Q", namespace122, Write32_Questions(((global::Datalab.Server.Packets.QuestionPacket.Questions)o.@Q)));
            string namespace123 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            {
                global::System.Object[] a = (global::System.Object[])((global::System.Object[])o.@Question_data);
                if (a != null){
                    WriteStartElement(@"Question_data", namespace123, null, false);
                    for (int ia = 0; ia < a.Length; ia++) {
                        string namespace124 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                        Write2_Object(@"anyType", namespace124, ((global::System.Object)a[ia]), true, false, namespace124, @"");
                    }
                    WriteEndElement();
                }
            }
            string namespace125 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            WriteElementStringRaw(@"A", namespace125, System.Xml.XmlConvert.ToString((global::System.Boolean)((global::System.Boolean)o.@A)));
            WriteEndElement(o);
        }

        void Write31_Packet(string n, string ns, global::Datalab.Server.Packets.Packet o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
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
                    Write33_QuestionPacket(n, ns,(global::Datalab.Server.Packets.QuestionPacket)o, isNullable, true);
                    return;
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
        }

        protected override void InitCallbacks() {
        }
    }

    [System.Runtime.CompilerServices.__BlockReflection]
    public class XmlSerializationReader1 : System.Xml.Serialization.XmlSerializationReader {

        public object Read34_ServerDataContainer(string defaultNamespace = null) {
            object o = null;
            Reader.MoveToContent();
            if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                if (((object) Reader.LocalName == (object)id1_ServerDataContainer && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                    o = Read29_ServerDataContainer(true, true, defaultNamespace);
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

        public object Read35_Plan(string defaultNamespace = null) {
            object o = null;
            Reader.MoveToContent();
            if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                if (((object) Reader.LocalName == (object)id3_Plan && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                    o = Read21_Plan(true, true, defaultNamespace);
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

        public object Read36_PlannerSettings(string defaultNamespace = null) {
            object o = null;
            Reader.MoveToContent();
            if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                if (((object) Reader.LocalName == (object)id4_PlannerSettings && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                    o = Read30_PlannerSettings(true, true, defaultNamespace);
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

        public object Read37_anyType(string defaultNamespace = null) {
            object o = null;
            Reader.MoveToContent();
            if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                if (((object) Reader.LocalName == (object)id5_anyType && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                    o = Read2_Object(true, true, defaultNamespace);
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

        public object Read38_QuestionPacket(string defaultNamespace = null) {
            object o = null;
            Reader.MoveToContent();
            if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                if (((object) Reader.LocalName == (object)id6_QuestionPacket && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                    o = Read33_QuestionPacket(true, true, defaultNamespace);
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

        public object Read39_Packet(string defaultNamespace = null) {
            object o = null;
            Reader.MoveToContent();
            if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                if (((object) Reader.LocalName == (object)id7_Packet && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                    o = Read31_Packet(true, true, defaultNamespace);
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

        public object Read40_User(string defaultNamespace = null) {
            object o = null;
            Reader.MoveToContent();
            if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                if (((object) Reader.LocalName == (object)id8_User && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                    o = Read23_User(true, true, defaultNamespace);
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

        public object Read41_anyType(string defaultNamespace = null) {
            object o = null;
            Reader.MoveToContent();
            if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                if (((object) Reader.LocalName == (object)id5_anyType && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                    o = Read2_Object(true, true, defaultNamespace);
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

        global::System.Object Read2_Object(bool isNullable, bool checkType, string defaultNamespace = null) {
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
                else if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id7_Packet && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item)))
                    return Read31_Packet(isNullable, false, defaultNamespace);
                else if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id6_QuestionPacket && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item)))
                    return Read33_QuestionPacket(isNullable, false, defaultNamespace);
                else if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id4_PlannerSettings && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item)))
                    return Read30_PlannerSettings(isNullable, false, defaultNamespace);
                else if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id1_ServerDataContainer && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item)))
                    return Read29_ServerDataContainer(isNullable, false, defaultNamespace);
                else if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id9_MessageManager && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item)))
                    return Read28_MessageManager(isNullable, false, defaultNamespace);
                else if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id10_ChatManager && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item)))
                    return Read27_ChatManager(isNullable, false, defaultNamespace);
                else if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id11_ChatRoom && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item)))
                    return Read26_ChatRoom(isNullable, false, defaultNamespace);
                else if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id12_MailManager && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item)))
                    return Read25_MailManager(isNullable, false, defaultNamespace);
                else if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id13_UserManager && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item)))
                    return Read24_UserManager(isNullable, false, defaultNamespace);
                else if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id8_User && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item)))
                    return Read23_User(isNullable, false, defaultNamespace);
                else if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id14_UserInfo && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item)))
                    return Read22_UserInfo(isNullable, false, defaultNamespace);
                else if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id3_Plan && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item)))
                    return Read21_Plan(isNullable, false, defaultNamespace);
                else if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id15_Message && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item)))
                    return Read19_Message(isNullable, false, defaultNamespace);
                else if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id16_Mail && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item)))
                    return Read20_Mail(isNullable, false, defaultNamespace);
                else if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id17_Diary && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item)))
                    return Read18_Diary(isNullable, false, defaultNamespace);
                else if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id18_TimeSpan && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item)))
                    return Read12_TimeSpan(false, defaultNamespace);
                else if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id19_BasicGeoposition && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item)))
                    return Read9_BasicGeoposition(false, defaultNamespace);
                else if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id20_PlanningItem && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item)))
                    return Read7_PlanningItem(isNullable, false, defaultNamespace);
                else if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id21_Reflection && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item)))
                    return Read17_Reflection(isNullable, false, defaultNamespace);
                else if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id22_RepeatingPlanningItem && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item)))
                    return Read13_RepeatingPlanningItem(isNullable, false, defaultNamespace);
                else if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id23_Activity && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item)))
                    return Read10_Activity(isNullable, false, defaultNamespace);
                else if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id24_ToDoItem && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item)))
                    return Read8_ToDoItem(isNullable, false, defaultNamespace);
                else if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id25_ToDoItemSet && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item)))
                    return Read14_ToDoItemSet(isNullable, false, defaultNamespace);
                else if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id26_ServerLog && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item)))
                    return Read6_ServerLog(isNullable, false, defaultNamespace);
                else if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id27_Log && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item)))
                    return Read5_Log(isNullable, false, defaultNamespace);
                else if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id28_ServerInfo && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item)))
                    return Read3_ServerInfo(isNullable, false, defaultNamespace);
                else if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id29_RunningStatus && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
                    Reader.ReadStartElement();
                    object e = Read1_RunningStatus(CollapseWhitespace(this.ReadString()));
                    ReadEndElement();
                    return e;
                }
                else if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id30_LogTypes && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
                    Reader.ReadStartElement();
                    object e = Read4_LogTypes(CollapseWhitespace(this.ReadString()));
                    ReadEndElement();
                    return e;
                }
                else if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id31_ArrayOfLog && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
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
                            int whileIterations0 = 0;
                            int readerCount0 = ReaderCount;
                            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                                    if (((object) Reader.LocalName == (object)id27_Log && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                        if ((object)(z_0_0) == null) Reader.Skip(); else z_0_0.Add(Read5_Log(true, true, defaultNamespace));
                                    }
                                    else {
                                        UnknownNode(null, @":Log");
                                    }
                                }
                                else {
                                    UnknownNode(null, @":Log");
                                }
                                Reader.MoveToContent();
                                CheckReaderCount(ref whileIterations0, ref readerCount0);
                            }
                        ReadEndElement();
                        }
                    }
                    return a;
                }
                else if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id32_ArrayOfToDoItem && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
                    global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Planning.ToDoItem> a = null;
                    if (!ReadNull()) {
                        if ((object)(a) == null) a = new global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Planning.ToDoItem>();
                        global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Planning.ToDoItem> z_0_0 = (global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Planning.ToDoItem>)a;
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
                                    if (((object) Reader.LocalName == (object)id24_ToDoItem && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                        if ((object)(z_0_0) == null) Reader.Skip(); else z_0_0.Add(Read8_ToDoItem(true, true, defaultNamespace));
                                    }
                                    else {
                                        UnknownNode(null, @":ToDoItem");
                                    }
                                }
                                else {
                                    UnknownNode(null, @":ToDoItem");
                                }
                                Reader.MoveToContent();
                                CheckReaderCount(ref whileIterations1, ref readerCount1);
                            }
                        ReadEndElement();
                        }
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
                            int whileIterations2 = 0;
                            int readerCount2 = ReaderCount;
                            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                                    if (((object) Reader.LocalName == (object)id23_Activity && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                        if ((object)(z_0_0) == null) Reader.Skip(); else z_0_0.Add(Read10_Activity(true, true, defaultNamespace));
                                    }
                                    else {
                                        UnknownNode(null, @":Activity");
                                    }
                                }
                                else {
                                    UnknownNode(null, @":Activity");
                                }
                                Reader.MoveToContent();
                                CheckReaderCount(ref whileIterations2, ref readerCount2);
                            }
                        ReadEndElement();
                        }
                    }
                    return a;
                }
                else if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id34_DayOfWeek && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
                    Reader.ReadStartElement();
                    object e = Read11_DayOfWeek(CollapseWhitespace(this.ReadString()));
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
                            int whileIterations3 = 0;
                            int readerCount3 = ReaderCount;
                            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                                    if (((object) Reader.LocalName == (object)id34_DayOfWeek && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                        {
                                            z_0_0.Add(Read11_DayOfWeek(Reader.ReadElementContentAsString()));
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
                                CheckReaderCount(ref whileIterations3, ref readerCount3);
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
                            int whileIterations4 = 0;
                            int readerCount4 = ReaderCount;
                            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                                    if (((object) Reader.LocalName == (object)id22_RepeatingPlanningItem && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                        if ((object)(z_0_0) == null) Reader.Skip(); else z_0_0.Add(Read13_RepeatingPlanningItem(true, true, defaultNamespace));
                                    }
                                    else {
                                        UnknownNode(null, @":RepeatingPlanningItem");
                                    }
                                }
                                else {
                                    UnknownNode(null, @":RepeatingPlanningItem");
                                }
                                Reader.MoveToContent();
                                CheckReaderCount(ref whileIterations4, ref readerCount4);
                            }
                        ReadEndElement();
                        }
                    }
                    return a;
                }
                else if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id37_ArrayOfToDoItemSet && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
                    global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Planning.ToDoItemSet> a = null;
                    if (!ReadNull()) {
                        if ((object)(a) == null) a = new global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Planning.ToDoItemSet>();
                        global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Planning.ToDoItemSet> z_0_0 = (global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Planning.ToDoItemSet>)a;
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
                                    if (((object) Reader.LocalName == (object)id25_ToDoItemSet && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                        if ((object)(z_0_0) == null) Reader.Skip(); else z_0_0.Add(Read14_ToDoItemSet(true, true, defaultNamespace));
                                    }
                                    else {
                                        UnknownNode(null, @":ToDoItemSet");
                                    }
                                }
                                else {
                                    UnknownNode(null, @":ToDoItemSet");
                                }
                                Reader.MoveToContent();
                                CheckReaderCount(ref whileIterations5, ref readerCount5);
                            }
                        ReadEndElement();
                        }
                    }
                    return a;
                }
                else if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id38_BitmapPixelFormat && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
                    Reader.ReadStartElement();
                    object e = Read15_BitmapPixelFormat(CollapseWhitespace(this.ReadString()));
                    ReadEndElement();
                    return e;
                }
                else if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id39_ArrayOfInt && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
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
                            int whileIterations6 = 0;
                            int readerCount6 = ReaderCount;
                            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                                    if (((object) Reader.LocalName == (object)id40_int && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
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
                                CheckReaderCount(ref whileIterations6, ref readerCount6);
                            }
                        ReadEndElement();
                        }
                        a = (global::System.Int32[])ShrinkArray(z_0_0, cz_0_0, typeof(global::System.Int32), false);
                    }
                    return a;
                }
                else if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id41_Feelings && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
                    Reader.ReadStartElement();
                    object e = Read16_Feelings(CollapseWhitespace(this.ReadString()));
                    ReadEndElement();
                    return e;
                }
                else if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id42_ArrayOfReflection && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
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
                            int whileIterations7 = 0;
                            int readerCount7 = ReaderCount;
                            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                                    if (((object) Reader.LocalName == (object)id21_Reflection && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                        if ((object)(z_0_0) == null) Reader.Skip(); else z_0_0.Add(Read17_Reflection(true, true, defaultNamespace));
                                    }
                                    else {
                                        UnknownNode(null, @":Reflection");
                                    }
                                }
                                else {
                                    UnknownNode(null, @":Reflection");
                                }
                                Reader.MoveToContent();
                                CheckReaderCount(ref whileIterations7, ref readerCount7);
                            }
                        ReadEndElement();
                        }
                    }
                    return a;
                }
                else if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id43_ArrayOfPlanningItem && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
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
                            int whileIterations8 = 0;
                            int readerCount8 = ReaderCount;
                            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                                    if (((object) Reader.LocalName == (object)id20_PlanningItem && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                        if ((object)(z_0_0) == null) Reader.Skip(); else z_0_0.Add(Read7_PlanningItem(true, true, defaultNamespace));
                                    }
                                    else {
                                        UnknownNode(null, @":PlanningItem");
                                    }
                                }
                                else {
                                    UnknownNode(null, @":PlanningItem");
                                }
                                Reader.MoveToContent();
                                CheckReaderCount(ref whileIterations8, ref readerCount8);
                            }
                        ReadEndElement();
                        }
                    }
                    return a;
                }
                else if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id44_ArrayOfDiary && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
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
                            int whileIterations9 = 0;
                            int readerCount9 = ReaderCount;
                            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                                    if (((object) Reader.LocalName == (object)id17_Diary && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                        if ((object)(z_0_0) == null) Reader.Skip(); else z_0_0.Add(Read18_Diary(true, true, defaultNamespace));
                                    }
                                    else {
                                        UnknownNode(null, @":Diary");
                                    }
                                }
                                else {
                                    UnknownNode(null, @":Diary");
                                }
                                Reader.MoveToContent();
                                CheckReaderCount(ref whileIterations9, ref readerCount9);
                            }
                        ReadEndElement();
                        }
                    }
                    return a;
                }
                else if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id45_ArrayOfString && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
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
                            int whileIterations10 = 0;
                            int readerCount10 = ReaderCount;
                            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                                    if (((object) Reader.LocalName == (object)id46_string && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
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
                                CheckReaderCount(ref whileIterations10, ref readerCount10);
                            }
                        ReadEndElement();
                        }
                    }
                    return a;
                }
                else if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id47_ArrayOfMail && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
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
                            int whileIterations11 = 0;
                            int readerCount11 = ReaderCount;
                            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                                    if (((object) Reader.LocalName == (object)id16_Mail && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                        if ((object)(z_0_0) == null) Reader.Skip(); else z_0_0.Add(Read20_Mail(true, true, defaultNamespace));
                                    }
                                    else {
                                        UnknownNode(null, @":Mail");
                                    }
                                }
                                else {
                                    UnknownNode(null, @":Mail");
                                }
                                Reader.MoveToContent();
                                CheckReaderCount(ref whileIterations11, ref readerCount11);
                            }
                        ReadEndElement();
                        }
                    }
                    return a;
                }
                else if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id45_ArrayOfString && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
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
                            int whileIterations12 = 0;
                            int readerCount12 = ReaderCount;
                            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                                    if (((object) Reader.LocalName == (object)id48_Hobbie && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
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
                                CheckReaderCount(ref whileIterations12, ref readerCount12);
                            }
                        ReadEndElement();
                        }
                    }
                    return a;
                }
                else if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id49_ArrayOfString1 && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
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
                            int whileIterations13 = 0;
                            int readerCount13 = ReaderCount;
                            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                                    if (((object) Reader.LocalName == (object)id50_Friend && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
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
                                CheckReaderCount(ref whileIterations13, ref readerCount13);
                            }
                        ReadEndElement();
                        }
                    }
                    return a;
                }
                else if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id51_ArrayOfUser && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
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
                            int whileIterations14 = 0;
                            int readerCount14 = ReaderCount;
                            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                                    if (((object) Reader.LocalName == (object)id8_User && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                        if ((object)(z_0_0) == null) Reader.Skip(); else z_0_0.Add(Read23_User(true, true, defaultNamespace));
                                    }
                                    else {
                                        UnknownNode(null, @":User");
                                    }
                                }
                                else {
                                    UnknownNode(null, @":User");
                                }
                                Reader.MoveToContent();
                                CheckReaderCount(ref whileIterations14, ref readerCount14);
                            }
                        ReadEndElement();
                        }
                    }
                    return a;
                }
                else if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id47_ArrayOfMail && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
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
                            int whileIterations15 = 0;
                            int readerCount15 = ReaderCount;
                            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                                    if (((object) Reader.LocalName == (object)id16_Mail && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                        if ((object)(z_0_0) == null) Reader.Skip(); else z_0_0.Add(Read20_Mail(true, true, defaultNamespace));
                                    }
                                    else {
                                        UnknownNode(null, @":Mail");
                                    }
                                }
                                else {
                                    UnknownNode(null, @":Mail");
                                }
                                Reader.MoveToContent();
                                CheckReaderCount(ref whileIterations15, ref readerCount15);
                            }
                        ReadEndElement();
                        }
                    }
                    return a;
                }
                else if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id51_ArrayOfUser && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
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
                            int whileIterations16 = 0;
                            int readerCount16 = ReaderCount;
                            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                                    if (((object) Reader.LocalName == (object)id8_User && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                        if ((object)(z_0_0) == null) Reader.Skip(); else z_0_0.Add(Read23_User(true, true, defaultNamespace));
                                    }
                                    else {
                                        UnknownNode(null, @":User");
                                    }
                                }
                                else {
                                    UnknownNode(null, @":User");
                                }
                                Reader.MoveToContent();
                                CheckReaderCount(ref whileIterations16, ref readerCount16);
                            }
                        ReadEndElement();
                        }
                    }
                    return a;
                }
                else if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id52_ArrayOfMessage && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
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
                            int whileIterations17 = 0;
                            int readerCount17 = ReaderCount;
                            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                                    if (((object) Reader.LocalName == (object)id15_Message && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                        if ((object)(z_0_0) == null) Reader.Skip(); else z_0_0.Add(Read19_Message(true, true, defaultNamespace));
                                    }
                                    else {
                                        UnknownNode(null, @":Message");
                                    }
                                }
                                else {
                                    UnknownNode(null, @":Message");
                                }
                                Reader.MoveToContent();
                                CheckReaderCount(ref whileIterations17, ref readerCount17);
                            }
                        ReadEndElement();
                        }
                    }
                    return a;
                }
                else if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id53_ArrayOfChatRoom && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
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
                            int whileIterations18 = 0;
                            int readerCount18 = ReaderCount;
                            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                                    if (((object) Reader.LocalName == (object)id11_ChatRoom && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                        if ((object)(z_0_0) == null) Reader.Skip(); else z_0_0.Add(Read26_ChatRoom(true, true, defaultNamespace));
                                    }
                                    else {
                                        UnknownNode(null, @":ChatRoom");
                                    }
                                }
                                else {
                                    UnknownNode(null, @":ChatRoom");
                                }
                                Reader.MoveToContent();
                                CheckReaderCount(ref whileIterations18, ref readerCount18);
                            }
                        ReadEndElement();
                        }
                    }
                    return a;
                }
                else if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id54_Questions && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
                    Reader.ReadStartElement();
                    object e = Read32_Questions(CollapseWhitespace(this.ReadString()));
                    ReadEndElement();
                    return e;
                }
                else if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id55_ArrayOfAnyType && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
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
                            int whileIterations19 = 0;
                            int readerCount19 = ReaderCount;
                            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                                    if (((object) Reader.LocalName == (object)id5_anyType && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                        z_0_0 = (global::System.Object[])EnsureArrayIndex(z_0_0, cz_0_0, typeof(global::System.Object));z_0_0[cz_0_0++] = Read2_Object(true, true, defaultNamespace);
                                    }
                                    else {
                                        UnknownNode(null, @":anyType");
                                    }
                                }
                                else {
                                    UnknownNode(null, @":anyType");
                                }
                                Reader.MoveToContent();
                                CheckReaderCount(ref whileIterations19, ref readerCount19);
                            }
                        ReadEndElement();
                        }
                        a = (global::System.Object[])ShrinkArray(z_0_0, cz_0_0, typeof(global::System.Object), false);
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
                int whileIterations20 = 0;
                int readerCount20 = ReaderCount;
                while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                    if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                        UnknownNode((object)o, @"");
                    }
                    else {
                        UnknownNode((object)o, @"");
                    }
                    Reader.MoveToContent();
                    CheckReaderCount(ref whileIterations20, ref readerCount20);
                }
                ReadEndElement();
                return o;
            }

            global::Datalab.Server.Packets.QuestionPacket.Questions Read32_Questions(string s) {
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

            global::DataLab.Data.Users.Message.Chat.ChatRoom Read26_ChatRoom(bool isNullable, bool checkType, string defaultNamespace = null) {
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
                int whileIterations21 = 0;
                int readerCount21 = ReaderCount;
                while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                    if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                        if (((object) Reader.LocalName == (object)id56_Participants && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                            if (!ReadNull()) {
                                if ((object)(o.@Participants) == null) o.@Participants = new global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Users.User>();
                                global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Users.User> a_0_0 = (global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Users.User>)o.@Participants;
                                if ((Reader.IsEmptyElement)) {
                                    Reader.Skip();
                                }
                                else {
                                    Reader.ReadStartElement();
                                    Reader.MoveToContent();
                                    int whileIterations22 = 0;
                                    int readerCount22 = ReaderCount;
                                    while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                                        if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                                            if (((object) Reader.LocalName == (object)id8_User && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                                if ((object)(a_0_0) == null) Reader.Skip(); else a_0_0.Add(Read23_User(true, true, defaultNamespace));
                                            }
                                            else {
                                                UnknownNode(null, @":User");
                                            }
                                        }
                                        else {
                                            UnknownNode(null, @":User");
                                        }
                                        Reader.MoveToContent();
                                        CheckReaderCount(ref whileIterations22, ref readerCount22);
                                    }
                                ReadEndElement();
                                }
                            }
                        }
                        else if (((object) Reader.LocalName == (object)id57_ChatMessages && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                            if (!ReadNull()) {
                                if ((object)(o.@ChatMessages) == null) o.@ChatMessages = new global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Users.Message.Message>();
                                global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Users.Message.Message> a_1_0 = (global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Users.Message.Message>)o.@ChatMessages;
                                if ((Reader.IsEmptyElement)) {
                                    Reader.Skip();
                                }
                                else {
                                    Reader.ReadStartElement();
                                    Reader.MoveToContent();
                                    int whileIterations23 = 0;
                                    int readerCount23 = ReaderCount;
                                    while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                                        if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                                            if (((object) Reader.LocalName == (object)id15_Message && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                                if ((object)(a_1_0) == null) Reader.Skip(); else a_1_0.Add(Read19_Message(true, true, defaultNamespace));
                                            }
                                            else {
                                                UnknownNode(null, @":Message");
                                            }
                                        }
                                        else {
                                            UnknownNode(null, @":Message");
                                        }
                                        Reader.MoveToContent();
                                        CheckReaderCount(ref whileIterations23, ref readerCount23);
                                    }
                                ReadEndElement();
                                }
                            }
                        }
                        else if (!paramsRead[2] && ((object) Reader.LocalName == (object)id58_ID && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                            {
                                o.@ID = System.Xml.XmlConvert.ToInt32(Reader.ReadElementContentAsString());
                            }
                            paramsRead[2] = true;
                        }
                        else if (!paramsRead[3] && ((object) Reader.LocalName == (object)id59_Name && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                            {
                                o.@Name = Reader.ReadElementContentAsString();
                            }
                            paramsRead[3] = true;
                        }
                        else if (!paramsRead[4] && ((object) Reader.LocalName == (object)id60_MaxSize && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
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
                    CheckReaderCount(ref whileIterations21, ref readerCount21);
                }
                ReadEndElement();
                return o;
            }

            global::DataLab.Data.Users.Message.Message Read19_Message(bool isNullable, bool checkType, string defaultNamespace = null) {
                System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
                bool isNull = false;
                if (isNullable) isNull = ReadNull();
                if (checkType) {
                if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id15_Message && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
                }
                else if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id16_Mail && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item)))
                    return Read20_Mail(isNullable, false, defaultNamespace);
                else
                    throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
                }
                if (isNull) return null;
                throw CreateAbstractTypeException(@"Message", @"");
            }

            global::DataLab.Data.Users.Message.Mail Read20_Mail(bool isNullable, bool checkType, string defaultNamespace = null) {
                System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
                bool isNull = false;
                if (isNullable) isNull = ReadNull();
                if (checkType) {
                if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id16_Mail && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
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
                int whileIterations24 = 0;
                int readerCount24 = ReaderCount;
                while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                    if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                        if (!paramsRead[0] && ((object) Reader.LocalName == (object)id61_Sender && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                            {
                                o.@Sender = Reader.ReadElementContentAsString();
                            }
                            paramsRead[0] = true;
                        }
                        else if (((object) Reader.LocalName == (object)id62_Recepients && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                            if (!ReadNull()) {
                                if ((object)(o.@Recepients) == null) o.@Recepients = new global::System.Collections.Generic.List<global::System.String>();
                                global::System.Collections.Generic.List<global::System.String> a_1_0 = (global::System.Collections.Generic.List<global::System.String>)o.@Recepients;
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
                                            if (((object) Reader.LocalName == (object)id46_string && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
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
                                        CheckReaderCount(ref whileIterations25, ref readerCount25);
                                    }
                                ReadEndElement();
                                }
                            }
                        }
                        else if (!paramsRead[2] && ((object) Reader.LocalName == (object)id63_Msg && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                            {
                                o.@Msg = Reader.ReadElementContentAsString();
                            }
                            paramsRead[2] = true;
                        }
                        else if (!paramsRead[3] && ((object) Reader.LocalName == (object)id64_TimeSent && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                            {
                                o.@TimeSent = Reader.ReadElementContentAsString();
                            }
                            paramsRead[3] = true;
                        }
                        else if (!paramsRead[4] && ((object) Reader.LocalName == (object)id65_SentOn && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                            {
                                o.@SentOn = ToDateTime(Reader.ReadElementContentAsString());
                            }
                            paramsRead[4] = true;
                        }
                        else if (!paramsRead[5] && ((object) Reader.LocalName == (object)id66_Subject && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                            {
                                o.@Subject = Reader.ReadElementContentAsString();
                            }
                            paramsRead[5] = true;
                        }
                        else if (!paramsRead[6] && ((object) Reader.LocalName == (object)id67_wasRead && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
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
                    CheckReaderCount(ref whileIterations24, ref readerCount24);
                }
                ReadEndElement();
                return o;
            }

            global::DataLab.Data.Users.User Read23_User(bool isNullable, bool checkType, string defaultNamespace = null) {
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
                    if (!paramsRead[0] && ((object) Reader.LocalName == (object)id68_UserName && string.Equals(Reader.NamespaceURI, id2_Item))) {
                        o.@UserName = Reader.Value;
                        paramsRead[0] = true;
                    }
                    else if (!paramsRead[1] && ((object) Reader.LocalName == (object)id69_password && string.Equals(Reader.NamespaceURI, id2_Item))) {
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
                int whileIterations26 = 0;
                int readerCount26 = ReaderCount;
                while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                    if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                        if (!paramsRead[2] && ((object) Reader.LocalName == (object)id3_Plan && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                            o.@plan = Read21_Plan(false, true, defaultNamespace);
                            paramsRead[2] = true;
                        }
                        else if (((object) Reader.LocalName == (object)id70_Mails && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                            if (!ReadNull()) {
                                if ((object)(o.@Mails) == null) o.@Mails = new global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Users.Message.Mail>();
                                global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Users.Message.Mail> a_3_0 = (global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Users.Message.Mail>)o.@Mails;
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
                                            if (((object) Reader.LocalName == (object)id16_Mail && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                                if ((object)(a_3_0) == null) Reader.Skip(); else a_3_0.Add(Read20_Mail(true, true, defaultNamespace));
                                            }
                                            else {
                                                UnknownNode(null, @":Mail");
                                            }
                                        }
                                        else {
                                            UnknownNode(null, @":Mail");
                                        }
                                        Reader.MoveToContent();
                                        CheckReaderCount(ref whileIterations27, ref readerCount27);
                                    }
                                ReadEndElement();
                                }
                            }
                        }
                        else if (!paramsRead[4] && ((object) Reader.LocalName == (object)id71_LastDataSync && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                            {
                                o.@LastDataSync = ToDateTime(Reader.ReadElementContentAsString());
                            }
                            paramsRead[4] = true;
                        }
                        else if (!paramsRead[5] && ((object) Reader.LocalName == (object)id14_UserInfo && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                            o.@UserInfo = Read22_UserInfo(false, true, defaultNamespace);
                            paramsRead[5] = true;
                        }
                        else if (((object) Reader.LocalName == (object)id72_Friends && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                            if (!ReadNull()) {
                                if ((object)(o.@Friends) == null) o.@Friends = new global::System.Collections.ObjectModel.ObservableCollection<global::System.String>();
                                global::System.Collections.ObjectModel.ObservableCollection<global::System.String> a_6_0 = (global::System.Collections.ObjectModel.ObservableCollection<global::System.String>)o.@Friends;
                                if ((Reader.IsEmptyElement)) {
                                    Reader.Skip();
                                }
                                else {
                                    Reader.ReadStartElement();
                                    Reader.MoveToContent();
                                    int whileIterations28 = 0;
                                    int readerCount28 = ReaderCount;
                                    while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                                        if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                                            if (((object) Reader.LocalName == (object)id50_Friend && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
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
                                        CheckReaderCount(ref whileIterations28, ref readerCount28);
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
                    CheckReaderCount(ref whileIterations26, ref readerCount26);
                }
                ReadEndElement();
                return o;
            }

            global::DataLab.Data.Users.UserInfo Read22_UserInfo(bool isNullable, bool checkType, string defaultNamespace = null) {
                System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
                bool isNull = false;
                if (isNullable) isNull = ReadNull();
                if (checkType) {
                if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id14_UserInfo && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
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
                    if (!paramsRead[0] && ((object) Reader.LocalName == (object)id73_FirstName && string.Equals(Reader.NamespaceURI, id2_Item))) {
                        o.@FirstName = Reader.Value;
                        paramsRead[0] = true;
                    }
                    else if (!paramsRead[1] && ((object) Reader.LocalName == (object)id74_LastName && string.Equals(Reader.NamespaceURI, id2_Item))) {
                        o.@LastName = Reader.Value;
                        paramsRead[1] = true;
                    }
                    else if (!paramsRead[2] && ((object) Reader.LocalName == (object)id75_BirthDay && string.Equals(Reader.NamespaceURI, id2_Item))) {
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
                int whileIterations29 = 0;
                int readerCount29 = ReaderCount;
                while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                    if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                        if (((object) Reader.LocalName == (object)id76_Hobbies && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                            if (!ReadNull()) {
                                if ((object)(o.@Hobbies) == null) o.@Hobbies = new global::System.Collections.ObjectModel.ObservableCollection<global::System.String>();
                                global::System.Collections.ObjectModel.ObservableCollection<global::System.String> a_3_0 = (global::System.Collections.ObjectModel.ObservableCollection<global::System.String>)o.@Hobbies;
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
                                            if (((object) Reader.LocalName == (object)id48_Hobbie && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
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
                                        CheckReaderCount(ref whileIterations30, ref readerCount30);
                                    }
                                ReadEndElement();
                                }
                            }
                        }
                        else if (!paramsRead[4] && ((object) Reader.LocalName == (object)id77_BirthCountry && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                            {
                                o.@BirthCountry = Reader.ReadElementContentAsString();
                            }
                            paramsRead[4] = true;
                        }
                        else if (!paramsRead[5] && ((object) Reader.LocalName == (object)id78_CountryOfLiving && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                            {
                                o.@CountryOfLiving = Reader.ReadElementContentAsString();
                            }
                            paramsRead[5] = true;
                        }
                        else if (!paramsRead[6] && ((object) Reader.LocalName == (object)id79_Language && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                            {
                                o.@Language = Reader.ReadElementContentAsString();
                            }
                            paramsRead[6] = true;
                        }
                        else if (((object) Reader.LocalName == (object)id80_FriendNames && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                            if (!ReadNull()) {
                                if ((object)(o.@FriendNames) == null) o.@FriendNames = new global::System.Collections.Generic.List<global::System.String>();
                                global::System.Collections.Generic.List<global::System.String> a_7_0 = (global::System.Collections.Generic.List<global::System.String>)o.@FriendNames;
                                if ((Reader.IsEmptyElement)) {
                                    Reader.Skip();
                                }
                                else {
                                    Reader.ReadStartElement();
                                    Reader.MoveToContent();
                                    int whileIterations31 = 0;
                                    int readerCount31 = ReaderCount;
                                    while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                                        if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                                            if (((object) Reader.LocalName == (object)id46_string && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
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
                                        CheckReaderCount(ref whileIterations31, ref readerCount31);
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
                    CheckReaderCount(ref whileIterations29, ref readerCount29);
                }
                ReadEndElement();
                return o;
            }

            global::DataLab.Data.Planning.Plan Read21_Plan(bool isNullable, bool checkType, string defaultNamespace = null) {
                System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
                bool isNull = false;
                if (isNullable) isNull = ReadNull();
                if (checkType) {
                if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id3_Plan && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
                }
                else
                    throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
                }
                if (isNull) return null;
                global::DataLab.Data.Planning.Plan o;
                o = new global::DataLab.Data.Planning.Plan();
                if ((object)(o.@ToDoItems) == null) o.@ToDoItems = new global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Planning.ToDoItem>();
                global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Planning.ToDoItem> a_0 = (global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Planning.ToDoItem>)o.@ToDoItems;
                if ((object)(o.@Activities) == null) o.@Activities = new global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Planning.Activity>();
                global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Planning.Activity> a_1 = (global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Planning.Activity>)o.@Activities;
                if ((object)(o.@rpi) == null) o.@rpi = new global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Planning.RepeatingPlanningItem>();
                global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Planning.RepeatingPlanningItem> a_2 = (global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Planning.RepeatingPlanningItem>)o.@rpi;
                if ((object)(o.@tdiSets) == null) o.@tdiSets = new global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Planning.ToDoItemSet>();
                global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Planning.ToDoItemSet> a_3 = (global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Planning.ToDoItemSet>)o.@tdiSets;
                if ((object)(o.@Reflections) == null) o.@Reflections = new global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Planning.Reflection>();
                global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Planning.Reflection> a_4 = (global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Planning.Reflection>)o.@Reflections;
                if ((object)(o.@Diaries) == null) o.@Diaries = new global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Planning.Diary>();
                global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Planning.Diary> a_5 = (global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Planning.Diary>)o.@Diaries;
                if ((object)(o.@Mails) == null) o.@Mails = new global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Users.Message.Mail>();
                global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Users.Message.Mail> a_6 = (global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Users.Message.Mail>)o.@Mails;
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
                int whileIterations32 = 0;
                int readerCount32 = ReaderCount;
                while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                    if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                        if (((object) Reader.LocalName == (object)id81_ToDoItems && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                            if (!ReadNull()) {
                                if ((object)(o.@ToDoItems) == null) o.@ToDoItems = new global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Planning.ToDoItem>();
                                global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Planning.ToDoItem> a_0_0 = (global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Planning.ToDoItem>)o.@ToDoItems;
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
                                            if (((object) Reader.LocalName == (object)id24_ToDoItem && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                                if ((object)(a_0_0) == null) Reader.Skip(); else a_0_0.Add(Read8_ToDoItem(true, true, defaultNamespace));
                                            }
                                            else {
                                                UnknownNode(null, @":ToDoItem");
                                            }
                                        }
                                        else {
                                            UnknownNode(null, @":ToDoItem");
                                        }
                                        Reader.MoveToContent();
                                        CheckReaderCount(ref whileIterations33, ref readerCount33);
                                    }
                                ReadEndElement();
                                }
                            }
                        }
                        else if (((object) Reader.LocalName == (object)id82_Activities && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                            if (!ReadNull()) {
                                if ((object)(o.@Activities) == null) o.@Activities = new global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Planning.Activity>();
                                global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Planning.Activity> a_1_0 = (global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Planning.Activity>)o.@Activities;
                                if ((Reader.IsEmptyElement)) {
                                    Reader.Skip();
                                }
                                else {
                                    Reader.ReadStartElement();
                                    Reader.MoveToContent();
                                    int whileIterations34 = 0;
                                    int readerCount34 = ReaderCount;
                                    while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                                        if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                                            if (((object) Reader.LocalName == (object)id23_Activity && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                                if ((object)(a_1_0) == null) Reader.Skip(); else a_1_0.Add(Read10_Activity(true, true, defaultNamespace));
                                            }
                                            else {
                                                UnknownNode(null, @":Activity");
                                            }
                                        }
                                        else {
                                            UnknownNode(null, @":Activity");
                                        }
                                        Reader.MoveToContent();
                                        CheckReaderCount(ref whileIterations34, ref readerCount34);
                                    }
                                ReadEndElement();
                                }
                            }
                        }
                        else if (((object) Reader.LocalName == (object)id83_rpi && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                            if (!ReadNull()) {
                                if ((object)(o.@rpi) == null) o.@rpi = new global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Planning.RepeatingPlanningItem>();
                                global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Planning.RepeatingPlanningItem> a_2_0 = (global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Planning.RepeatingPlanningItem>)o.@rpi;
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
                                            if (((object) Reader.LocalName == (object)id22_RepeatingPlanningItem && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                                if ((object)(a_2_0) == null) Reader.Skip(); else a_2_0.Add(Read13_RepeatingPlanningItem(true, true, defaultNamespace));
                                            }
                                            else {
                                                UnknownNode(null, @":RepeatingPlanningItem");
                                            }
                                        }
                                        else {
                                            UnknownNode(null, @":RepeatingPlanningItem");
                                        }
                                        Reader.MoveToContent();
                                        CheckReaderCount(ref whileIterations35, ref readerCount35);
                                    }
                                ReadEndElement();
                                }
                            }
                        }
                        else if (((object) Reader.LocalName == (object)id84_tdiSets && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                            if (!ReadNull()) {
                                if ((object)(o.@tdiSets) == null) o.@tdiSets = new global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Planning.ToDoItemSet>();
                                global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Planning.ToDoItemSet> a_3_0 = (global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Planning.ToDoItemSet>)o.@tdiSets;
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
                                            if (((object) Reader.LocalName == (object)id25_ToDoItemSet && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                                if ((object)(a_3_0) == null) Reader.Skip(); else a_3_0.Add(Read14_ToDoItemSet(true, true, defaultNamespace));
                                            }
                                            else {
                                                UnknownNode(null, @":ToDoItemSet");
                                            }
                                        }
                                        else {
                                            UnknownNode(null, @":ToDoItemSet");
                                        }
                                        Reader.MoveToContent();
                                        CheckReaderCount(ref whileIterations36, ref readerCount36);
                                    }
                                ReadEndElement();
                                }
                            }
                        }
                        else if (((object) Reader.LocalName == (object)id85_Reflections && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                            if (!ReadNull()) {
                                if ((object)(o.@Reflections) == null) o.@Reflections = new global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Planning.Reflection>();
                                global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Planning.Reflection> a_4_0 = (global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Planning.Reflection>)o.@Reflections;
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
                                            if (((object) Reader.LocalName == (object)id21_Reflection && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                                if ((object)(a_4_0) == null) Reader.Skip(); else a_4_0.Add(Read17_Reflection(true, true, defaultNamespace));
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
                        else if (((object) Reader.LocalName == (object)id86_Diaries && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                            if (!ReadNull()) {
                                if ((object)(o.@Diaries) == null) o.@Diaries = new global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Planning.Diary>();
                                global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Planning.Diary> a_5_0 = (global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Planning.Diary>)o.@Diaries;
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
                                            if (((object) Reader.LocalName == (object)id17_Diary && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                                if ((object)(a_5_0) == null) Reader.Skip(); else a_5_0.Add(Read18_Diary(true, true, defaultNamespace));
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
                        else if (((object) Reader.LocalName == (object)id70_Mails && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                            if (!ReadNull()) {
                                if ((object)(o.@Mails) == null) o.@Mails = new global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Users.Message.Mail>();
                                global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Users.Message.Mail> a_6_0 = (global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Users.Message.Mail>)o.@Mails;
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
                                            if (((object) Reader.LocalName == (object)id16_Mail && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                                if ((object)(a_6_0) == null) Reader.Skip(); else a_6_0.Add(Read20_Mail(true, true, defaultNamespace));
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
                        else {
                            UnknownNode((object)o, @":ToDoItems, :Activities, :rpi, :tdiSets, :Reflections, :Diaries, :Mails");
                        }
                    }
                    else {
                        UnknownNode((object)o, @":ToDoItems, :Activities, :rpi, :tdiSets, :Reflections, :Diaries, :Mails");
                    }
                    Reader.MoveToContent();
                    CheckReaderCount(ref whileIterations32, ref readerCount32);
                }
                ReadEndElement();
                return o;
            }

            global::DataLab.Data.Planning.Diary Read18_Diary(bool isNullable, bool checkType, string defaultNamespace = null) {
                System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
                bool isNull = false;
                if (isNullable) isNull = ReadNull();
                if (checkType) {
                if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id17_Diary && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
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
                int whileIterations40 = 0;
                int readerCount40 = ReaderCount;
                while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                    if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                        if (!paramsRead[0] && ((object) Reader.LocalName == (object)id59_Name && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                            {
                                o.@Name = Reader.ReadElementContentAsString();
                            }
                            paramsRead[0] = true;
                        }
                        else if (!paramsRead[1] && ((object) Reader.LocalName == (object)id87_StartTime && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                            {
                                o.@StartTime = ToDateTime(Reader.ReadElementContentAsString());
                            }
                            paramsRead[1] = true;
                        }
                        else if (!paramsRead[2] && ((object) Reader.LocalName == (object)id88_EndTime && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                            {
                                o.@EndTime = ToDateTime(Reader.ReadElementContentAsString());
                            }
                            paramsRead[2] = true;
                        }
                        else if (((object) Reader.LocalName == (object)id89_PlanningItems && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                            if (!ReadNull()) {
                                // Non-public setter. if ((object)(o.@PlanningItems) == null) o.@PlanningItems = new global::System.Collections.Generic.List<global::DataLab.Data.Planning.PlanningItem>();
                                global::System.Collections.Generic.List<global::DataLab.Data.Planning.PlanningItem> a_3_0 = (global::System.Collections.Generic.List<global::DataLab.Data.Planning.PlanningItem>)o.@PlanningItems;
                                if ((Reader.IsEmptyElement)) {
                                    Reader.Skip();
                                }
                                else {
                                    Reader.ReadStartElement();
                                    Reader.MoveToContent();
                                    int whileIterations41 = 0;
                                    int readerCount41 = ReaderCount;
                                    while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                                        if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                                            if (((object) Reader.LocalName == (object)id20_PlanningItem && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                                if ((object)(a_3_0) == null) Reader.Skip(); else a_3_0.Add(Read7_PlanningItem(true, true, defaultNamespace));
                                            }
                                            else {
                                                UnknownNode(null, @":PlanningItem");
                                            }
                                        }
                                        else {
                                            UnknownNode(null, @":PlanningItem");
                                        }
                                        Reader.MoveToContent();
                                        CheckReaderCount(ref whileIterations41, ref readerCount41);
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
                    CheckReaderCount(ref whileIterations40, ref readerCount40);
                }
                ReadEndElement();
                return o;
            }

            global::DataLab.Data.Planning.PlanningItem Read7_PlanningItem(bool isNullable, bool checkType, string defaultNamespace = null) {
                System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
                bool isNull = false;
                if (isNullable) isNull = ReadNull();
                if (checkType) {
                if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id20_PlanningItem && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
                }
                else if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id21_Reflection && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item)))
                    return Read17_Reflection(isNullable, false, defaultNamespace);
                else if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id22_RepeatingPlanningItem && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item)))
                    return Read13_RepeatingPlanningItem(isNullable, false, defaultNamespace);
                else if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id23_Activity && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item)))
                    return Read10_Activity(isNullable, false, defaultNamespace);
                else if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id24_ToDoItem && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item)))
                    return Read8_ToDoItem(isNullable, false, defaultNamespace);
                else if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id25_ToDoItemSet && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item)))
                    return Read14_ToDoItemSet(isNullable, false, defaultNamespace);
                else
                    throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
                }
                if (isNull) return null;
                global::DataLab.Data.Planning.PlanningItem o;
                o = new global::DataLab.Data.Planning.PlanningItem();
                bool[] paramsRead = new bool[3];
                while (Reader.MoveToNextAttribute()) {
                    if (!paramsRead[0] && ((object) Reader.LocalName == (object)id59_Name && string.Equals(Reader.NamespaceURI, id2_Item))) {
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
                int whileIterations42 = 0;
                int readerCount42 = ReaderCount;
                while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                    if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                        UnknownNode((object)o, @"");
                    }
                    else {
                        UnknownNode((object)o, @"");
                    }
                    Reader.MoveToContent();
                    CheckReaderCount(ref whileIterations42, ref readerCount42);
                }
                ReadEndElement();
                return o;
            }

            global::DataLab.Data.Planning.ToDoItemSet Read14_ToDoItemSet(bool isNullable, bool checkType, string defaultNamespace = null) {
                System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
                bool isNull = false;
                if (isNullable) isNull = ReadNull();
                if (checkType) {
                if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id25_ToDoItemSet && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
                }
                else
                    throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
                }
                if (isNull) return null;
                global::DataLab.Data.Planning.ToDoItemSet o;
                o = new global::DataLab.Data.Planning.ToDoItemSet();
                if ((object)(o.@Children) == null) o.@Children = new global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Planning.ToDoItem>();
                global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Planning.ToDoItem> a_7 = (global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Planning.ToDoItem>)o.@Children;
                bool[] paramsRead = new bool[8];
                while (Reader.MoveToNextAttribute()) {
                    if (!paramsRead[0] && ((object) Reader.LocalName == (object)id59_Name && string.Equals(Reader.NamespaceURI, id2_Item))) {
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
                    else if (!paramsRead[3] && ((object) Reader.LocalName == (object)id92_IsDone && string.Equals(Reader.NamespaceURI, id2_Item))) {
                        o.@IsDone = System.Xml.XmlConvert.ToBoolean(Reader.Value);
                        paramsRead[3] = true;
                    }
                    else if (!paramsRead[4] && ((object) Reader.LocalName == (object)id93_Deadline && string.Equals(Reader.NamespaceURI, id2_Item))) {
                        o.@Deadline = ToDateTime(Reader.Value);
                        paramsRead[4] = true;
                    }
                    else if (!paramsRead[5] && ((object) Reader.LocalName == (object)id94_CompletedAt && string.Equals(Reader.NamespaceURI, id2_Item))) {
                        o.@CompletedAt = ToDateTime(Reader.Value);
                        paramsRead[5] = true;
                    }
                    else if (!paramsRead[6] && ((object) Reader.LocalName == (object)id95_Description && string.Equals(Reader.NamespaceURI, id2_Item))) {
                        o.@Description = Reader.Value;
                        paramsRead[6] = true;
                    }
                    else if (!IsXmlnsAttribute(Reader.Name)) {
                        UnknownNode((object)o, @":Name, :Silent, :MinutesToAlertBeforeActualAlarm, :IsDone, :Deadline, :CompletedAt, :Description");
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
                        if (((object) Reader.LocalName == (object)id25_ToDoItemSet && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                            if (!ReadNull()) {
                                if ((object)(o.@Children) == null) o.@Children = new global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Planning.ToDoItem>();
                                global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Planning.ToDoItem> a_7_0 = (global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Planning.ToDoItem>)o.@Children;
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
                                            if (((object) Reader.LocalName == (object)id24_ToDoItem && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                                if ((object)(a_7_0) == null) Reader.Skip(); else a_7_0.Add(Read8_ToDoItem(true, true, defaultNamespace));
                                            }
                                            else {
                                                UnknownNode(null, @":ToDoItem");
                                            }
                                        }
                                        else {
                                            UnknownNode(null, @":ToDoItem");
                                        }
                                        Reader.MoveToContent();
                                        CheckReaderCount(ref whileIterations44, ref readerCount44);
                                    }
                                ReadEndElement();
                                }
                            }
                        }
                        else {
                            UnknownNode((object)o, @":ToDoItemSet");
                        }
                    }
                    else {
                        UnknownNode((object)o, @":ToDoItemSet");
                    }
                    Reader.MoveToContent();
                    CheckReaderCount(ref whileIterations43, ref readerCount43);
                }
                ReadEndElement();
                return o;
            }

            global::DataLab.Data.Planning.ToDoItem Read8_ToDoItem(bool isNullable, bool checkType, string defaultNamespace = null) {
                System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
                bool isNull = false;
                if (isNullable) isNull = ReadNull();
                if (checkType) {
                if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id24_ToDoItem && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
                }
                else if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id25_ToDoItemSet && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item)))
                    return Read14_ToDoItemSet(isNullable, false, defaultNamespace);
                else
                    throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
                }
                if (isNull) return null;
                global::DataLab.Data.Planning.ToDoItem o;
                o = new global::DataLab.Data.Planning.ToDoItem();
                bool[] paramsRead = new bool[7];
                while (Reader.MoveToNextAttribute()) {
                    if (!paramsRead[0] && ((object) Reader.LocalName == (object)id59_Name && string.Equals(Reader.NamespaceURI, id2_Item))) {
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
                    else if (!paramsRead[3] && ((object) Reader.LocalName == (object)id92_IsDone && string.Equals(Reader.NamespaceURI, id2_Item))) {
                        o.@IsDone = System.Xml.XmlConvert.ToBoolean(Reader.Value);
                        paramsRead[3] = true;
                    }
                    else if (!paramsRead[4] && ((object) Reader.LocalName == (object)id93_Deadline && string.Equals(Reader.NamespaceURI, id2_Item))) {
                        o.@Deadline = ToDateTime(Reader.Value);
                        paramsRead[4] = true;
                    }
                    else if (!paramsRead[5] && ((object) Reader.LocalName == (object)id94_CompletedAt && string.Equals(Reader.NamespaceURI, id2_Item))) {
                        o.@CompletedAt = ToDateTime(Reader.Value);
                        paramsRead[5] = true;
                    }
                    else if (!paramsRead[6] && ((object) Reader.LocalName == (object)id95_Description && string.Equals(Reader.NamespaceURI, id2_Item))) {
                        o.@Description = Reader.Value;
                        paramsRead[6] = true;
                    }
                    else if (!IsXmlnsAttribute(Reader.Name)) {
                        UnknownNode((object)o, @":Name, :Silent, :MinutesToAlertBeforeActualAlarm, :IsDone, :Deadline, :CompletedAt, :Description");
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
                        UnknownNode((object)o, @"");
                    }
                    else {
                        UnknownNode((object)o, @"");
                    }
                    Reader.MoveToContent();
                    CheckReaderCount(ref whileIterations45, ref readerCount45);
                }
                ReadEndElement();
                return o;
            }

            global::DataLab.Data.Planning.Activity Read10_Activity(bool isNullable, bool checkType, string defaultNamespace = null) {
                System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
                bool isNull = false;
                if (isNullable) isNull = ReadNull();
                if (checkType) {
                if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id23_Activity && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
                }
                else
                    throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
                }
                if (isNull) return null;
                global::DataLab.Data.Planning.Activity o;
                o = new global::DataLab.Data.Planning.Activity();
                bool[] paramsRead = new bool[5];
                while (Reader.MoveToNextAttribute()) {
                    if (!paramsRead[0] && ((object) Reader.LocalName == (object)id59_Name && string.Equals(Reader.NamespaceURI, id2_Item))) {
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
                int whileIterations46 = 0;
                int readerCount46 = ReaderCount;
                while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                    if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                        if (!paramsRead[3] && ((object) Reader.LocalName == (object)id96_basicgeoloc && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                            o.@basicgeoloc = Read9_BasicGeoposition(true, defaultNamespace);
                            paramsRead[3] = true;
                        }
                        else if (!paramsRead[4] && ((object) Reader.LocalName == (object)id97_End && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                            {
                                o.@End = ToDateTime(Reader.ReadElementContentAsString());
                            }
                            paramsRead[4] = true;
                        }
                        else {
                            UnknownNode((object)o, @":basicgeoloc, :End");
                        }
                    }
                    else {
                        UnknownNode((object)o, @":basicgeoloc, :End");
                    }
                    Reader.MoveToContent();
                    CheckReaderCount(ref whileIterations46, ref readerCount46);
                }
                ReadEndElement();
                return o;
            }

            global::Windows.Devices.Geolocation.BasicGeoposition Read9_BasicGeoposition(bool checkType, string defaultNamespace = null) {
                System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
                bool isNull = false;
                if (checkType) {
                if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id19_BasicGeoposition && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
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
                int whileIterations47 = 0;
                int readerCount47 = ReaderCount;
                while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                    if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                        if (!paramsRead[0] && ((object) Reader.LocalName == (object)id98_Latitude && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                            {
                                o.@Latitude = System.Xml.XmlConvert.ToDouble(Reader.ReadElementContentAsString());
                            }
                            paramsRead[0] = true;
                        }
                        else if (!paramsRead[1] && ((object) Reader.LocalName == (object)id99_Longitude && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                            {
                                o.@Longitude = System.Xml.XmlConvert.ToDouble(Reader.ReadElementContentAsString());
                            }
                            paramsRead[1] = true;
                        }
                        else if (!paramsRead[2] && ((object) Reader.LocalName == (object)id100_Altitude && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
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
                    CheckReaderCount(ref whileIterations47, ref readerCount47);
                }
                ReadEndElement();
                return o;
            }

            global::DataLab.Data.Planning.RepeatingPlanningItem Read13_RepeatingPlanningItem(bool isNullable, bool checkType, string defaultNamespace = null) {
                System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
                bool isNull = false;
                if (isNullable) isNull = ReadNull();
                if (checkType) {
                if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id22_RepeatingPlanningItem && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
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
                    if (!paramsRead[0] && ((object) Reader.LocalName == (object)id59_Name && string.Equals(Reader.NamespaceURI, id2_Item))) {
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
                int whileIterations48 = 0;
                int readerCount48 = ReaderCount;
                while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                    if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                        if (!paramsRead[3] && ((object) Reader.LocalName == (object)id101_Item && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                            o.@Item = Read7_PlanningItem(false, true, defaultNamespace);
                            paramsRead[3] = true;
                        }
                        else if (((object) Reader.LocalName == (object)id102_Days && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                            if (!ReadNull()) {
                                if ((object)(o.@Days) == null) o.@Days = new global::System.Collections.Generic.List<global::System.DayOfWeek>();
                                global::System.Collections.Generic.List<global::System.DayOfWeek> a_4_0 = (global::System.Collections.Generic.List<global::System.DayOfWeek>)o.@Days;
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
                                            if (((object) Reader.LocalName == (object)id34_DayOfWeek && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                                {
                                                    a_4_0.Add(Read11_DayOfWeek(Reader.ReadElementContentAsString()));
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
                                        CheckReaderCount(ref whileIterations49, ref readerCount49);
                                    }
                                ReadEndElement();
                                }
                            }
                        }
                        else if (!paramsRead[5] && ((object) Reader.LocalName == (object)id103_Time && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                            o.@Time = Read12_TimeSpan(true, defaultNamespace);
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
                    CheckReaderCount(ref whileIterations48, ref readerCount48);
                }
                ReadEndElement();
                return o;
            }

            global::System.TimeSpan Read12_TimeSpan(bool checkType, string defaultNamespace = null) {
                System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
                bool isNull = false;
                if (checkType) {
                if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id18_TimeSpan && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
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

            global::System.DayOfWeek Read11_DayOfWeek(string s) {
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

            global::DataLab.Data.Planning.Reflection Read17_Reflection(bool isNullable, bool checkType, string defaultNamespace = null) {
                System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
                bool isNull = false;
                if (isNullable) isNull = ReadNull();
                if (checkType) {
                if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id21_Reflection && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
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
                    if (!paramsRead[0] && ((object) Reader.LocalName == (object)id59_Name && string.Equals(Reader.NamespaceURI, id2_Item))) {
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
                    else if (!paramsRead[4] && ((object) Reader.LocalName == (object)id38_BitmapPixelFormat && string.Equals(Reader.NamespaceURI, id2_Item))) {
                        o.@Format = Read15_BitmapPixelFormat(Reader.Value);
                        paramsRead[4] = true;
                    }
                    else if (!paramsRead[7] && ((object) Reader.LocalName == (object)id95_Description && string.Equals(Reader.NamespaceURI, id2_Item))) {
                        o.@Description = Reader.Value;
                        paramsRead[7] = true;
                    }
                    else if (!paramsRead[8] && ((object) Reader.LocalName == (object)id103_Time && string.Equals(Reader.NamespaceURI, id2_Item))) {
                        o.@Time = ToDateTime(Reader.Value);
                        paramsRead[8] = true;
                    }
                    else if (!paramsRead[9] && ((object) Reader.LocalName == (object)id104_Feeling && string.Equals(Reader.NamespaceURI, id2_Item))) {
                        o.@Feeling = Read16_Feelings(Reader.Value);
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
                int whileIterations51 = 0;
                int readerCount51 = ReaderCount;
                while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                    if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                        if (!paramsRead[3] && ((object) Reader.LocalName == (object)id105_PhotoLocation && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                            {
                                o.@PhotoLocation = Reader.ReadElementContentAsString();
                            }
                            paramsRead[3] = true;
                        }
                        else if (((object) Reader.LocalName == (object)id106_Dimension && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                            if (!ReadNull()) {
                                global::System.Int32[] a_5_0 = null;
                                int ca_5_0 = 0;
                                if ((Reader.IsEmptyElement)) {
                                    Reader.Skip();
                                }
                                else {
                                    Reader.ReadStartElement();
                                    Reader.MoveToContent();
                                    int whileIterations52 = 0;
                                    int readerCount52 = ReaderCount;
                                    while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                                        if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                                            if (((object) Reader.LocalName == (object)id40_int && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
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
                                        CheckReaderCount(ref whileIterations52, ref readerCount52);
                                    }
                                ReadEndElement();
                                }
                                o.@Dimension = (global::System.Int32[])ShrinkArray(a_5_0, ca_5_0, typeof(global::System.Int32), false);
                            }
                        }
                        else if (!paramsRead[6] && ((object) Reader.LocalName == (object)id96_basicgeoloc && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                            o.@basicgeoloc = Read9_BasicGeoposition(true, defaultNamespace);
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
                    CheckReaderCount(ref whileIterations51, ref readerCount51);
                }
                ReadEndElement();
                return o;
            }

            global::DataLab.Data.Planning.Reflection.Feelings Read16_Feelings(string s) {
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

            global::Windows.Graphics.Imaging.BitmapPixelFormat Read15_BitmapPixelFormat(string s) {
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

            global::DataLab.Server.Controller.Logging.Log Read5_Log(bool isNullable, bool checkType, string defaultNamespace = null) {
                System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
                bool isNull = false;
                if (isNullable) isNull = ReadNull();
                if (checkType) {
                if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id27_Log && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
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
                int whileIterations53 = 0;
                int readerCount53 = ReaderCount;
                while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                    if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                        if (!paramsRead[0] && ((object) Reader.LocalName == (object)id103_Time && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                            {
                                o.@Time = ToDateTime(Reader.ReadElementContentAsString());
                            }
                            paramsRead[0] = true;
                        }
                        else if (!paramsRead[1] && ((object) Reader.LocalName == (object)id15_Message && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                            {
                                o.@Message = Reader.ReadElementContentAsString();
                            }
                            paramsRead[1] = true;
                        }
                        else if (!paramsRead[2] && ((object) Reader.LocalName == (object)id107_LogType && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                            {
                                o.@LogType = Read4_LogTypes(Reader.ReadElementContentAsString());
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
                    CheckReaderCount(ref whileIterations53, ref readerCount53);
                }
                ReadEndElement();
                return o;
            }

            global::DataLab.Server.Controller.Logging.Log.LogTypes Read4_LogTypes(string s) {
                switch (s) {
                    case @"Command_result": return global::DataLab.Server.Controller.Logging.Log.LogTypes.@Command_result;
                    case @"Error": return global::DataLab.Server.Controller.Logging.Log.LogTypes.@Error;
                    case @"Server_Status": return global::DataLab.Server.Controller.Logging.Log.LogTypes.@Server_Status;
                    case @"User_Activity": return global::DataLab.Server.Controller.Logging.Log.LogTypes.@User_Activity;
                    case @"Warning": return global::DataLab.Server.Controller.Logging.Log.LogTypes.@Warning;
                    default: throw CreateUnknownConstantException(s, typeof(global::DataLab.Server.Controller.Logging.Log.LogTypes));
                }
            }

            global::DataLab.Server.Controller.ServerInfo.RunningStatus Read1_RunningStatus(string s) {
                switch (s) {
                    case @"STOP": return global::DataLab.Server.Controller.ServerInfo.RunningStatus.@STOP;
                    case @"PAUSED": return global::DataLab.Server.Controller.ServerInfo.RunningStatus.@PAUSED;
                    case @"RUNNING": return global::DataLab.Server.Controller.ServerInfo.RunningStatus.@RUNNING;
                    default: throw CreateUnknownConstantException(s, typeof(global::DataLab.Server.Controller.ServerInfo.RunningStatus));
                }
            }

            global::DataLab.Server.Controller.ServerInfo Read3_ServerInfo(bool isNullable, bool checkType, string defaultNamespace = null) {
                System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
                bool isNull = false;
                if (isNullable) isNull = ReadNull();
                if (checkType) {
                if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id28_ServerInfo && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
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
                int whileIterations54 = 0;
                int readerCount54 = ReaderCount;
                while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                    if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                        if (!paramsRead[0] && ((object) Reader.LocalName == (object)id59_Name && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                            {
                                o.@Name = Reader.ReadElementContentAsString();
                            }
                            paramsRead[0] = true;
                        }
                        else if (!paramsRead[1] && ((object) Reader.LocalName == (object)id108_RunningSince && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                            {
                                o.@RunningSince = ToDateTime(Reader.ReadElementContentAsString());
                            }
                            paramsRead[1] = true;
                        }
                        else if (!paramsRead[2] && ((object) Reader.LocalName == (object)id109_RunStatus && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                            {
                                o.@RunStatus = Read1_RunningStatus(Reader.ReadElementContentAsString());
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
                    CheckReaderCount(ref whileIterations54, ref readerCount54);
                }
                ReadEndElement();
                return o;
            }

            global::DataLab.Server.Controller.Logging.ServerLog Read6_ServerLog(bool isNullable, bool checkType, string defaultNamespace = null) {
                System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
                bool isNull = false;
                if (isNullable) isNull = ReadNull();
                if (checkType) {
                if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id26_ServerLog && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
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
                int whileIterations55 = 0;
                int readerCount55 = ReaderCount;
                while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                    if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                        if (((object) Reader.LocalName == (object)id110_Logs && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                            if (!ReadNull()) {
                                if ((object)(o.@Logs) == null) o.@Logs = new global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Server.Controller.Logging.Log>();
                                global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Server.Controller.Logging.Log> a_0_0 = (global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Server.Controller.Logging.Log>)o.@Logs;
                                if ((Reader.IsEmptyElement)) {
                                    Reader.Skip();
                                }
                                else {
                                    Reader.ReadStartElement();
                                    Reader.MoveToContent();
                                    int whileIterations56 = 0;
                                    int readerCount56 = ReaderCount;
                                    while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                                        if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                                            if (((object) Reader.LocalName == (object)id27_Log && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                                if ((object)(a_0_0) == null) Reader.Skip(); else a_0_0.Add(Read5_Log(true, true, defaultNamespace));
                                            }
                                            else {
                                                UnknownNode(null, @":Log");
                                            }
                                        }
                                        else {
                                            UnknownNode(null, @":Log");
                                        }
                                        Reader.MoveToContent();
                                        CheckReaderCount(ref whileIterations56, ref readerCount56);
                                    }
                                ReadEndElement();
                                }
                            }
                        }
                        else if (((object) Reader.LocalName == (object)id111_LogHistory && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                            if (!ReadNull()) {
                                if ((object)(o.@LogHistory) == null) o.@LogHistory = new global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Server.Controller.Logging.Log>();
                                global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Server.Controller.Logging.Log> a_1_0 = (global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Server.Controller.Logging.Log>)o.@LogHistory;
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
                                            if (((object) Reader.LocalName == (object)id27_Log && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                                if ((object)(a_1_0) == null) Reader.Skip(); else a_1_0.Add(Read5_Log(true, true, defaultNamespace));
                                            }
                                            else {
                                                UnknownNode(null, @":Log");
                                            }
                                        }
                                        else {
                                            UnknownNode(null, @":Log");
                                        }
                                        Reader.MoveToContent();
                                        CheckReaderCount(ref whileIterations57, ref readerCount57);
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
                    CheckReaderCount(ref whileIterations55, ref readerCount55);
                }
                ReadEndElement();
                return o;
            }

            global::DataLab.Data.Users.UserManager Read24_UserManager(bool isNullable, bool checkType, string defaultNamespace = null) {
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
                int whileIterations58 = 0;
                int readerCount58 = ReaderCount;
                while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                    if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                        if (((object) Reader.LocalName == (object)id112_Users && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                            if (!ReadNull()) {
                                if ((object)(o.@Users) == null) o.@Users = new global::System.Collections.Generic.List<global::DataLab.Data.Users.User>();
                                global::System.Collections.Generic.List<global::DataLab.Data.Users.User> a_0_0 = (global::System.Collections.Generic.List<global::DataLab.Data.Users.User>)o.@Users;
                                if ((Reader.IsEmptyElement)) {
                                    Reader.Skip();
                                }
                                else {
                                    Reader.ReadStartElement();
                                    Reader.MoveToContent();
                                    int whileIterations59 = 0;
                                    int readerCount59 = ReaderCount;
                                    while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                                        if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                                            if (((object) Reader.LocalName == (object)id8_User && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                                if ((object)(a_0_0) == null) Reader.Skip(); else a_0_0.Add(Read23_User(true, true, defaultNamespace));
                                            }
                                            else {
                                                UnknownNode(null, @":User");
                                            }
                                        }
                                        else {
                                            UnknownNode(null, @":User");
                                        }
                                        Reader.MoveToContent();
                                        CheckReaderCount(ref whileIterations59, ref readerCount59);
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
                    CheckReaderCount(ref whileIterations58, ref readerCount58);
                }
                ReadEndElement();
                return o;
            }

            global::DataLab.Data.Users.Message.MailManager Read25_MailManager(bool isNullable, bool checkType, string defaultNamespace = null) {
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
                int whileIterations60 = 0;
                int readerCount60 = ReaderCount;
                while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                    if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                        if (((object) Reader.LocalName == (object)id70_Mails && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                            if (!ReadNull()) {
                                if ((object)(o.@Mails) == null) o.@Mails = new global::System.Collections.Generic.List<global::DataLab.Data.Users.Message.Mail>();
                                global::System.Collections.Generic.List<global::DataLab.Data.Users.Message.Mail> a_0_0 = (global::System.Collections.Generic.List<global::DataLab.Data.Users.Message.Mail>)o.@Mails;
                                if ((Reader.IsEmptyElement)) {
                                    Reader.Skip();
                                }
                                else {
                                    Reader.ReadStartElement();
                                    Reader.MoveToContent();
                                    int whileIterations61 = 0;
                                    int readerCount61 = ReaderCount;
                                    while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                                        if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                                            if (((object) Reader.LocalName == (object)id16_Mail && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                                if ((object)(a_0_0) == null) Reader.Skip(); else a_0_0.Add(Read20_Mail(true, true, defaultNamespace));
                                            }
                                            else {
                                                UnknownNode(null, @":Mail");
                                            }
                                        }
                                        else {
                                            UnknownNode(null, @":Mail");
                                        }
                                        Reader.MoveToContent();
                                        CheckReaderCount(ref whileIterations61, ref readerCount61);
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
                    CheckReaderCount(ref whileIterations60, ref readerCount60);
                }
                ReadEndElement();
                return o;
            }

            global::DataLab.Data.Users.Message.ChatManager Read27_ChatManager(bool isNullable, bool checkType, string defaultNamespace = null) {
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
                int whileIterations62 = 0;
                int readerCount62 = ReaderCount;
                while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                    if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                        if (((object) Reader.LocalName == (object)id113_ChatRooms && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                            if (!ReadNull()) {
                                if ((object)(o.@ChatRooms) == null) o.@ChatRooms = new global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Users.Message.Chat.ChatRoom>();
                                global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Users.Message.Chat.ChatRoom> a_0_0 = (global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Users.Message.Chat.ChatRoom>)o.@ChatRooms;
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
                                            if (((object) Reader.LocalName == (object)id11_ChatRoom && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                                if ((object)(a_0_0) == null) Reader.Skip(); else a_0_0.Add(Read26_ChatRoom(true, true, defaultNamespace));
                                            }
                                            else {
                                                UnknownNode(null, @":ChatRoom");
                                            }
                                        }
                                        else {
                                            UnknownNode(null, @":ChatRoom");
                                        }
                                        Reader.MoveToContent();
                                        CheckReaderCount(ref whileIterations63, ref readerCount63);
                                    }
                                ReadEndElement();
                                }
                            }
                        }
                        else if (((object) Reader.LocalName == (object)id114_ChatHistory && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                            if (!ReadNull()) {
                                if ((object)(o.@ChatHistory) == null) o.@ChatHistory = new global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Users.Message.Chat.ChatRoom>();
                                global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Users.Message.Chat.ChatRoom> a_1_0 = (global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Users.Message.Chat.ChatRoom>)o.@ChatHistory;
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
                                            if (((object) Reader.LocalName == (object)id11_ChatRoom && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                                if ((object)(a_1_0) == null) Reader.Skip(); else a_1_0.Add(Read26_ChatRoom(true, true, defaultNamespace));
                                            }
                                            else {
                                                UnknownNode(null, @":ChatRoom");
                                            }
                                        }
                                        else {
                                            UnknownNode(null, @":ChatRoom");
                                        }
                                        Reader.MoveToContent();
                                        CheckReaderCount(ref whileIterations64, ref readerCount64);
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
                    CheckReaderCount(ref whileIterations62, ref readerCount62);
                }
                ReadEndElement();
                return o;
            }

            global::DataLab.Data.Users.Message.MessageManager Read28_MessageManager(bool isNullable, bool checkType, string defaultNamespace = null) {
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
                int whileIterations65 = 0;
                int readerCount65 = ReaderCount;
                while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                    if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                        if (!paramsRead[0] && ((object) Reader.LocalName == (object)id115_MailMan && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                            o.@MailMan = Read25_MailManager(false, true, defaultNamespace);
                            paramsRead[0] = true;
                        }
                        else if (!paramsRead[1] && ((object) Reader.LocalName == (object)id116_ChatMan && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                            o.@ChatMan = Read27_ChatManager(false, true, defaultNamespace);
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
                    CheckReaderCount(ref whileIterations65, ref readerCount65);
                }
                ReadEndElement();
                return o;
            }

            global::PlennerServer.Server.ServerDataContainer Read29_ServerDataContainer(bool isNullable, bool checkType, string defaultNamespace = null) {
                System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
                bool isNull = false;
                if (isNullable) isNull = ReadNull();
                if (checkType) {
                if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id1_ServerDataContainer && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
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
                int whileIterations66 = 0;
                int readerCount66 = ReaderCount;
                while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                    if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                        if (!paramsRead[0] && ((object) Reader.LocalName == (object)id117_Info && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                            o.@Info = Read3_ServerInfo(false, true, defaultNamespace);
                            paramsRead[0] = true;
                        }
                        else if (!paramsRead[1] && ((object) Reader.LocalName == (object)id27_Log && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                            o.@Log = Read6_ServerLog(false, true, defaultNamespace);
                            paramsRead[1] = true;
                        }
                        else if (!paramsRead[2] && ((object) Reader.LocalName == (object)id118_Uman && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                            o.@Uman = Read24_UserManager(false, true, defaultNamespace);
                            paramsRead[2] = true;
                        }
                        else if (!paramsRead[3] && ((object) Reader.LocalName == (object)id119_MsgMan && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                            o.@MsgMan = Read28_MessageManager(false, true, defaultNamespace);
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
                    CheckReaderCount(ref whileIterations66, ref readerCount66);
                }
                ReadEndElement();
                return o;
            }

            global::DataLab.Storage.PlannerSettings Read30_PlannerSettings(bool isNullable, bool checkType, string defaultNamespace = null) {
                System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
                bool isNull = false;
                if (isNullable) isNull = ReadNull();
                if (checkType) {
                if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id4_PlannerSettings && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
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
                int whileIterations67 = 0;
                int readerCount67 = ReaderCount;
                while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                    if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                        if (!paramsRead[0] && ((object) Reader.LocalName == (object)id120_SoundEnabled && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                            {
                                o.@SoundEnabled = System.Xml.XmlConvert.ToBoolean(Reader.ReadElementContentAsString());
                            }
                            paramsRead[0] = true;
                        }
                        else if (!paramsRead[1] && ((object) Reader.LocalName == (object)id121_AutoSyncAccount && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                            {
                                o.@AutoSyncAccount = System.Xml.XmlConvert.ToBoolean(Reader.ReadElementContentAsString());
                            }
                            paramsRead[1] = true;
                        }
                        else if (!paramsRead[2] && ((object) Reader.LocalName == (object)id122_AutoLogIn && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                            {
                                o.@AutoLogIn = System.Xml.XmlConvert.ToBoolean(Reader.ReadElementContentAsString());
                            }
                            paramsRead[2] = true;
                        }
                        else if (((object) Reader.LocalName == (object)id123_Item && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                            if (!ReadNull()) {
                                global::System.Int32[] a_3_0 = null;
                                int ca_3_0 = 0;
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
                                            if (((object) Reader.LocalName == (object)id40_int && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
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
                                        CheckReaderCount(ref whileIterations68, ref readerCount68);
                                    }
                                ReadEndElement();
                                }
                                o.@PlanningItemExperationTimeSpanAsIntArray = (global::System.Int32[])ShrinkArray(a_3_0, ca_3_0, typeof(global::System.Int32), false);
                            }
                        }
                        else if (!paramsRead[4] && ((object) Reader.LocalName == (object)id124_EnableNotifications && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
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
                    CheckReaderCount(ref whileIterations67, ref readerCount67);
                }
                ReadEndElement();
                return o;
            }

            global::Datalab.Server.Packets.QuestionPacket Read33_QuestionPacket(bool isNullable, bool checkType, string defaultNamespace = null) {
                System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
                bool isNull = false;
                if (isNullable) isNull = ReadNull();
                if (checkType) {
                if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id6_QuestionPacket && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
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
                int whileIterations69 = 0;
                int readerCount69 = ReaderCount;
                while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                    if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                        if (!paramsRead[0] && ((object) Reader.LocalName == (object)id125_Q && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                            {
                                o.@Q = Read32_Questions(Reader.ReadElementContentAsString());
                            }
                            paramsRead[0] = true;
                        }
                        else if (((object) Reader.LocalName == (object)id126_Question_data && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                            if (!ReadNull()) {
                                global::System.Object[] a_1_0 = null;
                                int ca_1_0 = 0;
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
                                            if (((object) Reader.LocalName == (object)id5_anyType && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                                a_1_0 = (global::System.Object[])EnsureArrayIndex(a_1_0, ca_1_0, typeof(global::System.Object));a_1_0[ca_1_0++] = Read2_Object(true, true, defaultNamespace);
                                            }
                                            else {
                                                UnknownNode(null, @":anyType");
                                            }
                                        }
                                        else {
                                            UnknownNode(null, @":anyType");
                                        }
                                        Reader.MoveToContent();
                                        CheckReaderCount(ref whileIterations70, ref readerCount70);
                                    }
                                ReadEndElement();
                                }
                                o.@Question_data = (global::System.Object[])ShrinkArray(a_1_0, ca_1_0, typeof(global::System.Object), false);
                            }
                        }
                        else if (!paramsRead[2] && ((object) Reader.LocalName == (object)id127_A && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
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
                    CheckReaderCount(ref whileIterations69, ref readerCount69);
                }
                ReadEndElement();
                return o;
            }

            global::Datalab.Server.Packets.Packet Read31_Packet(bool isNullable, bool checkType, string defaultNamespace = null) {
                System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
                bool isNull = false;
                if (isNullable) isNull = ReadNull();
                if (checkType) {
                if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id7_Packet && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
                }
                else if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id6_QuestionPacket && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item)))
                    return Read33_QuestionPacket(isNullable, false, defaultNamespace);
                else
                    throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
                }
                if (isNull) return null;
                throw CreateAbstractTypeException(@"Packet", @"");
            }

            protected override void InitCallbacks() {
            }

            string id102_Days;
            string id20_PlanningItem;
            string id70_Mails;
            string id127_A;
            string id116_ChatMan;
            string id86_Diaries;
            string id105_PhotoLocation;
            string id75_BirthDay;
            string id40_int;
            string id32_ArrayOfToDoItem;
            string id23_Activity;
            string id97_End;
            string id84_tdiSets;
            string id88_EndTime;
            string id50_Friend;
            string id5_anyType;
            string id117_Info;
            string id118_Uman;
            string id106_Dimension;
            string id15_Message;
            string id19_BasicGeoposition;
            string id14_UserInfo;
            string id91_Item;
            string id119_MsgMan;
            string id103_Time;
            string id74_LastName;
            string id11_ChatRoom;
            string id42_ArrayOfReflection;
            string id1_ServerDataContainer;
            string id120_SoundEnabled;
            string id24_ToDoItem;
            string id8_User;
            string id34_DayOfWeek;
            string id63_Msg;
            string id122_AutoLogIn;
            string id87_StartTime;
            string id68_UserName;
            string id121_AutoSyncAccount;
            string id109_RunStatus;
            string id27_Log;
            string id9_MessageManager;
            string id38_BitmapPixelFormat;
            string id113_ChatRooms;
            string id111_LogHistory;
            string id7_Packet;
            string id2_Item;
            string id65_SentOn;
            string id85_Reflections;
            string id35_ArrayOfDayOfWeek;
            string id93_Deadline;
            string id56_Participants;
            string id48_Hobbie;
            string id124_EnableNotifications;
            string id58_ID;
            string id3_Plan;
            string id64_TimeSent;
            string id82_Activities;
            string id46_string;
            string id81_ToDoItems;
            string id125_Q;
            string id90_Silent;
            string id92_IsDone;
            string id69_password;
            string id30_LogTypes;
            string id29_RunningStatus;
            string id71_LastDataSync;
            string id6_QuestionPacket;
            string id67_wasRead;
            string id95_Description;
            string id33_ArrayOfActivity;
            string id36_ArrayOfRepeatingPlanningItem;
            string id10_ChatManager;
            string id12_MailManager;
            string id51_ArrayOfUser;
            string id73_FirstName;
            string id80_FriendNames;
            string id101_Item;
            string id72_Friends;
            string id57_ChatMessages;
            string id28_ServerInfo;
            string id76_Hobbies;
            string id22_RepeatingPlanningItem;
            string id123_Item;
            string id44_ArrayOfDiary;
            string id61_Sender;
            string id47_ArrayOfMail;
            string id98_Latitude;
            string id99_Longitude;
            string id16_Mail;
            string id107_LogType;
            string id114_ChatHistory;
            string id115_MailMan;
            string id39_ArrayOfInt;
            string id18_TimeSpan;
            string id41_Feelings;
            string id78_CountryOfLiving;
            string id62_Recepients;
            string id49_ArrayOfString1;
            string id126_Question_data;
            string id59_Name;
            string id112_Users;
            string id66_Subject;
            string id52_ArrayOfMessage;
            string id94_CompletedAt;
            string id43_ArrayOfPlanningItem;
            string id77_BirthCountry;
            string id4_PlannerSettings;
            string id96_basicgeoloc;
            string id55_ArrayOfAnyType;
            string id54_Questions;
            string id21_Reflection;
            string id13_UserManager;
            string id89_PlanningItems;
            string id60_MaxSize;
            string id108_RunningSince;
            string id37_ArrayOfToDoItemSet;
            string id53_ArrayOfChatRoom;
            string id79_Language;
            string id26_ServerLog;
            string id100_Altitude;
            string id83_rpi;
            string id45_ArrayOfString;
            string id104_Feeling;
            string id17_Diary;
            string id31_ArrayOfLog;
            string id110_Logs;
            string id25_ToDoItemSet;

            protected override void InitIDs() {
                id102_Days = Reader.NameTable.Add(@"Days");
                id20_PlanningItem = Reader.NameTable.Add(@"PlanningItem");
                id70_Mails = Reader.NameTable.Add(@"Mails");
                id127_A = Reader.NameTable.Add(@"A");
                id116_ChatMan = Reader.NameTable.Add(@"ChatMan");
                id86_Diaries = Reader.NameTable.Add(@"Diaries");
                id105_PhotoLocation = Reader.NameTable.Add(@"PhotoLocation");
                id75_BirthDay = Reader.NameTable.Add(@"BirthDay");
                id40_int = Reader.NameTable.Add(@"int");
                id32_ArrayOfToDoItem = Reader.NameTable.Add(@"ArrayOfToDoItem");
                id23_Activity = Reader.NameTable.Add(@"Activity");
                id97_End = Reader.NameTable.Add(@"End");
                id84_tdiSets = Reader.NameTable.Add(@"tdiSets");
                id88_EndTime = Reader.NameTable.Add(@"EndTime");
                id50_Friend = Reader.NameTable.Add(@"Friend");
                id5_anyType = Reader.NameTable.Add(@"anyType");
                id117_Info = Reader.NameTable.Add(@"Info");
                id118_Uman = Reader.NameTable.Add(@"Uman");
                id106_Dimension = Reader.NameTable.Add(@"Dimension");
                id15_Message = Reader.NameTable.Add(@"Message");
                id19_BasicGeoposition = Reader.NameTable.Add(@"BasicGeoposition");
                id14_UserInfo = Reader.NameTable.Add(@"UserInfo");
                id91_Item = Reader.NameTable.Add(@"MinutesToAlertBeforeActualAlarm");
                id119_MsgMan = Reader.NameTable.Add(@"MsgMan");
                id103_Time = Reader.NameTable.Add(@"Time");
                id74_LastName = Reader.NameTable.Add(@"LastName");
                id11_ChatRoom = Reader.NameTable.Add(@"ChatRoom");
                id42_ArrayOfReflection = Reader.NameTable.Add(@"ArrayOfReflection");
                id1_ServerDataContainer = Reader.NameTable.Add(@"ServerDataContainer");
                id120_SoundEnabled = Reader.NameTable.Add(@"SoundEnabled");
                id24_ToDoItem = Reader.NameTable.Add(@"ToDoItem");
                id8_User = Reader.NameTable.Add(@"User");
                id34_DayOfWeek = Reader.NameTable.Add(@"DayOfWeek");
                id63_Msg = Reader.NameTable.Add(@"Msg");
                id122_AutoLogIn = Reader.NameTable.Add(@"AutoLogIn");
                id87_StartTime = Reader.NameTable.Add(@"StartTime");
                id68_UserName = Reader.NameTable.Add(@"UserName");
                id121_AutoSyncAccount = Reader.NameTable.Add(@"AutoSyncAccount");
                id109_RunStatus = Reader.NameTable.Add(@"RunStatus");
                id27_Log = Reader.NameTable.Add(@"Log");
                id9_MessageManager = Reader.NameTable.Add(@"MessageManager");
                id38_BitmapPixelFormat = Reader.NameTable.Add(@"BitmapPixelFormat");
                id113_ChatRooms = Reader.NameTable.Add(@"ChatRooms");
                id111_LogHistory = Reader.NameTable.Add(@"LogHistory");
                id7_Packet = Reader.NameTable.Add(@"Packet");
                id2_Item = Reader.NameTable.Add(@"");
                id65_SentOn = Reader.NameTable.Add(@"SentOn");
                id85_Reflections = Reader.NameTable.Add(@"Reflections");
                id35_ArrayOfDayOfWeek = Reader.NameTable.Add(@"ArrayOfDayOfWeek");
                id93_Deadline = Reader.NameTable.Add(@"Deadline");
                id56_Participants = Reader.NameTable.Add(@"Participants");
                id48_Hobbie = Reader.NameTable.Add(@"Hobbie");
                id124_EnableNotifications = Reader.NameTable.Add(@"EnableNotifications");
                id58_ID = Reader.NameTable.Add(@"ID");
                id3_Plan = Reader.NameTable.Add(@"Plan");
                id64_TimeSent = Reader.NameTable.Add(@"TimeSent");
                id82_Activities = Reader.NameTable.Add(@"Activities");
                id46_string = Reader.NameTable.Add(@"string");
                id81_ToDoItems = Reader.NameTable.Add(@"ToDoItems");
                id125_Q = Reader.NameTable.Add(@"Q");
                id90_Silent = Reader.NameTable.Add(@"Silent");
                id92_IsDone = Reader.NameTable.Add(@"IsDone");
                id69_password = Reader.NameTable.Add(@"password");
                id30_LogTypes = Reader.NameTable.Add(@"LogTypes");
                id29_RunningStatus = Reader.NameTable.Add(@"RunningStatus");
                id71_LastDataSync = Reader.NameTable.Add(@"LastDataSync");
                id6_QuestionPacket = Reader.NameTable.Add(@"QuestionPacket");
                id67_wasRead = Reader.NameTable.Add(@"wasRead");
                id95_Description = Reader.NameTable.Add(@"Description");
                id33_ArrayOfActivity = Reader.NameTable.Add(@"ArrayOfActivity");
                id36_ArrayOfRepeatingPlanningItem = Reader.NameTable.Add(@"ArrayOfRepeatingPlanningItem");
                id10_ChatManager = Reader.NameTable.Add(@"ChatManager");
                id12_MailManager = Reader.NameTable.Add(@"MailManager");
                id51_ArrayOfUser = Reader.NameTable.Add(@"ArrayOfUser");
                id73_FirstName = Reader.NameTable.Add(@"FirstName");
                id80_FriendNames = Reader.NameTable.Add(@"FriendNames");
                id101_Item = Reader.NameTable.Add(@"Item");
                id72_Friends = Reader.NameTable.Add(@"Friends");
                id57_ChatMessages = Reader.NameTable.Add(@"ChatMessages");
                id28_ServerInfo = Reader.NameTable.Add(@"ServerInfo");
                id76_Hobbies = Reader.NameTable.Add(@"Hobbies");
                id22_RepeatingPlanningItem = Reader.NameTable.Add(@"RepeatingPlanningItem");
                id123_Item = Reader.NameTable.Add(@"PlanningItemExperationTimeSpanAsIntArray");
                id44_ArrayOfDiary = Reader.NameTable.Add(@"ArrayOfDiary");
                id61_Sender = Reader.NameTable.Add(@"Sender");
                id47_ArrayOfMail = Reader.NameTable.Add(@"ArrayOfMail");
                id98_Latitude = Reader.NameTable.Add(@"Latitude");
                id99_Longitude = Reader.NameTable.Add(@"Longitude");
                id16_Mail = Reader.NameTable.Add(@"Mail");
                id107_LogType = Reader.NameTable.Add(@"LogType");
                id114_ChatHistory = Reader.NameTable.Add(@"ChatHistory");
                id115_MailMan = Reader.NameTable.Add(@"MailMan");
                id39_ArrayOfInt = Reader.NameTable.Add(@"ArrayOfInt");
                id18_TimeSpan = Reader.NameTable.Add(@"TimeSpan");
                id41_Feelings = Reader.NameTable.Add(@"Feelings");
                id78_CountryOfLiving = Reader.NameTable.Add(@"CountryOfLiving");
                id62_Recepients = Reader.NameTable.Add(@"Recepients");
                id49_ArrayOfString1 = Reader.NameTable.Add(@"ArrayOfString1");
                id126_Question_data = Reader.NameTable.Add(@"Question_data");
                id59_Name = Reader.NameTable.Add(@"Name");
                id112_Users = Reader.NameTable.Add(@"Users");
                id66_Subject = Reader.NameTable.Add(@"Subject");
                id52_ArrayOfMessage = Reader.NameTable.Add(@"ArrayOfMessage");
                id94_CompletedAt = Reader.NameTable.Add(@"CompletedAt");
                id43_ArrayOfPlanningItem = Reader.NameTable.Add(@"ArrayOfPlanningItem");
                id77_BirthCountry = Reader.NameTable.Add(@"BirthCountry");
                id4_PlannerSettings = Reader.NameTable.Add(@"PlannerSettings");
                id96_basicgeoloc = Reader.NameTable.Add(@"basicgeoloc");
                id55_ArrayOfAnyType = Reader.NameTable.Add(@"ArrayOfAnyType");
                id54_Questions = Reader.NameTable.Add(@"Questions");
                id21_Reflection = Reader.NameTable.Add(@"Reflection");
                id13_UserManager = Reader.NameTable.Add(@"UserManager");
                id89_PlanningItems = Reader.NameTable.Add(@"PlanningItems");
                id60_MaxSize = Reader.NameTable.Add(@"MaxSize");
                id108_RunningSince = Reader.NameTable.Add(@"RunningSince");
                id37_ArrayOfToDoItemSet = Reader.NameTable.Add(@"ArrayOfToDoItemSet");
                id53_ArrayOfChatRoom = Reader.NameTable.Add(@"ArrayOfChatRoom");
                id79_Language = Reader.NameTable.Add(@"Language");
                id26_ServerLog = Reader.NameTable.Add(@"ServerLog");
                id100_Altitude = Reader.NameTable.Add(@"Altitude");
                id83_rpi = Reader.NameTable.Add(@"rpi");
                id45_ArrayOfString = Reader.NameTable.Add(@"ArrayOfString");
                id104_Feeling = Reader.NameTable.Add(@"Feeling");
                id17_Diary = Reader.NameTable.Add(@"Diary");
                id31_ArrayOfLog = Reader.NameTable.Add(@"ArrayOfLog");
                id110_Logs = Reader.NameTable.Add(@"Logs");
                id25_ToDoItemSet = Reader.NameTable.Add(@"ToDoItemSet");
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
        public sealed class ServerDataContainerSerializer : XmlSerializer1 {

            public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
                return xmlReader.IsStartElement(@"ServerDataContainer", this.DefaultNamespace ?? @"");
            }

            protected override void Serialize(object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer) {
                ((XmlSerializationWriter1)writer).Write34_ServerDataContainer(objectToSerialize, this.DefaultNamespace, @"");
            }

            protected override object Deserialize(System.Xml.Serialization.XmlSerializationReader reader) {
                return ((XmlSerializationReader1)reader).Read34_ServerDataContainer(this.DefaultNamespace);
            }
        }

        [System.Runtime.CompilerServices.__BlockReflection]
        public sealed class PlanSerializer : XmlSerializer1 {

            public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
                return xmlReader.IsStartElement(@"Plan", this.DefaultNamespace ?? @"");
            }

            protected override void Serialize(object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer) {
                ((XmlSerializationWriter1)writer).Write35_Plan(objectToSerialize, this.DefaultNamespace, @"");
            }

            protected override object Deserialize(System.Xml.Serialization.XmlSerializationReader reader) {
                return ((XmlSerializationReader1)reader).Read35_Plan(this.DefaultNamespace);
            }
        }

        [System.Runtime.CompilerServices.__BlockReflection]
        public sealed class PlannerSettingsSerializer : XmlSerializer1 {

            public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
                return xmlReader.IsStartElement(@"PlannerSettings", this.DefaultNamespace ?? @"");
            }

            protected override void Serialize(object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer) {
                ((XmlSerializationWriter1)writer).Write36_PlannerSettings(objectToSerialize, this.DefaultNamespace, @"");
            }

            protected override object Deserialize(System.Xml.Serialization.XmlSerializationReader reader) {
                return ((XmlSerializationReader1)reader).Read36_PlannerSettings(this.DefaultNamespace);
            }
        }

        [System.Runtime.CompilerServices.__BlockReflection]
        public sealed class ObjectSerializer : XmlSerializer1 {

            public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
                return xmlReader.IsStartElement(@"anyType", this.DefaultNamespace ?? @"");
            }

            protected override void Serialize(object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer) {
                ((XmlSerializationWriter1)writer).Write37_anyType(objectToSerialize, this.DefaultNamespace, @"");
            }

            protected override object Deserialize(System.Xml.Serialization.XmlSerializationReader reader) {
                return ((XmlSerializationReader1)reader).Read37_anyType(this.DefaultNamespace);
            }
        }

        [System.Runtime.CompilerServices.__BlockReflection]
        public sealed class QuestionPacketSerializer : XmlSerializer1 {

            public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
                return xmlReader.IsStartElement(@"QuestionPacket", this.DefaultNamespace ?? @"");
            }

            protected override void Serialize(object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer) {
                ((XmlSerializationWriter1)writer).Write38_QuestionPacket(objectToSerialize, this.DefaultNamespace, @"");
            }

            protected override object Deserialize(System.Xml.Serialization.XmlSerializationReader reader) {
                return ((XmlSerializationReader1)reader).Read38_QuestionPacket(this.DefaultNamespace);
            }
        }

        [System.Runtime.CompilerServices.__BlockReflection]
        public sealed class PacketSerializer : XmlSerializer1 {

            public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
                return xmlReader.IsStartElement(@"Packet", this.DefaultNamespace ?? @"");
            }

            protected override void Serialize(object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer) {
                ((XmlSerializationWriter1)writer).Write39_Packet(objectToSerialize, this.DefaultNamespace, @"");
            }

            protected override object Deserialize(System.Xml.Serialization.XmlSerializationReader reader) {
                return ((XmlSerializationReader1)reader).Read39_Packet(this.DefaultNamespace);
            }
        }

        [System.Runtime.CompilerServices.__BlockReflection]
        public sealed class UserSerializer : XmlSerializer1 {

            public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
                return xmlReader.IsStartElement(@"User", this.DefaultNamespace ?? @"");
            }

            protected override void Serialize(object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer) {
                ((XmlSerializationWriter1)writer).Write40_User(objectToSerialize, this.DefaultNamespace, @"");
            }

            protected override object Deserialize(System.Xml.Serialization.XmlSerializationReader reader) {
                return ((XmlSerializationReader1)reader).Read40_User(this.DefaultNamespace);
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
                        _tmp[@"PlennerServer.Server.ServerDataContainer::ServerDataContainer:True:"] = @"Read34_ServerDataContainer";
                        _tmp[@"DataLab.Data.Planning.Plan::Plan:True:"] = @"Read35_Plan";
                        _tmp[@"DataLab.Storage.PlannerSettings::"] = @"Read36_PlannerSettings";
                        _tmp[@"System.Object::"] = @"Read37_anyType";
                        _tmp[@"Datalab.Server.Packets.QuestionPacket::"] = @"Read38_QuestionPacket";
                        _tmp[@"Datalab.Server.Packets.Packet::"] = @"Read39_Packet";
                        _tmp[@"DataLab.Data.Users.User::User:True:"] = @"Read40_User";
                        _tmp[@"System.Object::"] = @"Read41_anyType";
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
                        _tmp[@"PlennerServer.Server.ServerDataContainer::ServerDataContainer:True:"] = @"Write34_ServerDataContainer";
                        _tmp[@"DataLab.Data.Planning.Plan::Plan:True:"] = @"Write35_Plan";
                        _tmp[@"DataLab.Storage.PlannerSettings::"] = @"Write36_PlannerSettings";
                        _tmp[@"System.Object::"] = @"Write37_anyType";
                        _tmp[@"Datalab.Server.Packets.QuestionPacket::"] = @"Write38_QuestionPacket";
                        _tmp[@"Datalab.Server.Packets.Packet::"] = @"Write39_Packet";
                        _tmp[@"DataLab.Data.Users.User::User:True:"] = @"Write40_User";
                        _tmp[@"System.Object::"] = @"Write41_anyType";
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
                if (type == typeof(global::PlennerServer.Server.ServerDataContainer)) return true;
                if (type == typeof(global::DataLab.Data.Planning.Plan)) return true;
                if (type == typeof(global::DataLab.Storage.PlannerSettings)) return true;
                if (type == typeof(global::System.Object)) return true;
                if (type == typeof(global::Datalab.Server.Packets.QuestionPacket)) return true;
                if (type == typeof(global::Datalab.Server.Packets.Packet)) return true;
                if (type == typeof(global::DataLab.Data.Users.User)) return true;
                if (type == typeof(global::System.Reflection.TypeInfo)) return true;
                return false;
            }
            public override System.Xml.Serialization.XmlSerializer GetSerializer(System.Type type) {
                if (type == typeof(global::PlennerServer.Server.ServerDataContainer)) return new ServerDataContainerSerializer();
                if (type == typeof(global::DataLab.Data.Planning.Plan)) return new PlanSerializer();
                if (type == typeof(global::DataLab.Storage.PlannerSettings)) return new PlannerSettingsSerializer();
                if (type == typeof(global::System.Object)) return new ObjectSerializer();
                if (type == typeof(global::Datalab.Server.Packets.QuestionPacket)) return new QuestionPacketSerializer();
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
