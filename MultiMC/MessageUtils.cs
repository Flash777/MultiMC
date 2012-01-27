// 
//  Copyright 2012  Andrew Okin
// 
//    Licensed under the Apache License, Version 2.0 (the "License");
//    you may not use this file except in compliance with the License.
//    You may obtain a copy of the License at
// 
//        http://www.apache.org/licenses/LICENSE-2.0
// 
//    Unless required by applicable law or agreed to in writing, software
//    distributed under the License is distributed on an "AS IS" BASIS,
//    WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//    See the License for the specific language governing permissions and
//    limitations under the License.
using System;
using Gtk;

namespace MultiMC
{
	public class MessageUtils
	{
		public static void ShowMessageBox(Window parent,
		                                  MessageType mtype, 
		                                  string title, 
		                                  string message, 
		                                  params string[] args)
		{
			MessageDialog msgDlg = 
				new MessageDialog(parent,
				                  DialogFlags.Modal,
				                  mtype,
				                  ButtonsType.Ok,
				                  message,
				                  args);
			msgDlg.Title = title;
			msgDlg.Response += (o, args2) => msgDlg.Destroy();
			msgDlg.Run();
		}
		
		public static void ShowMessageBox(MessageType mtype, 
		                                  string title, 
		                                  string message, 
		                                  params string[] args)
		{
			ShowMessageBox(null, mtype, title, message, args);
		}
		
		public static void ShowMessageBox(MessageType mtype, 
		                                  string message, 
		                                  params string[] args)
		{
			ShowMessageBox(mtype, "Message", message, args);
		}
	}
}

