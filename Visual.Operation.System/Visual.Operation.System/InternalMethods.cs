/******************************************************************************
*	Copyright © 2019 by VGF-KernelTeam and Christian 'Tipplin' Kurs.
*                      All Rights Reserved.
* -----------------------------------------------------------------------------
*   Parts of Copyright by Microsoft Corporation with Permission.
*   Many Thanks for this Help !
* 
******************************************************************************/

/* ----------------------------------------------------------------------------
 * ----------------------------------------------------------------------------
 * Visual.Operation.System.dll
 * Maintainer: Christian 'TIPPO' Kurs - Visual C#, C++ Developer and .NET Nerd.
 * ----------------------------------------------------------------------------
 * For Developers:
 * Change all to Visual Studio 2019 - V 16.0.0 - Visual C# 8.0 -
 * more Features and news.
 * ----------------------------------------------------------------------------
 * Copyright © 2018-2019
 * ----------------------------------------------------------------------------
 * ! NOTE ! for Linux Kernel 5.1:
 * Developer have change the 2038 Problem with Unix-Timestamp,
 * old Unix Timestamp time_t is an integer value at 19.01.2038 03:14:08 Hour
 * he overflow ! while the old value run at 01.01.1970, 
 * expired seconds since 32 BIT.
 * New Linux Kernel 5.1 new Functions-calls(syscalls) unterstand the 64BIT
 * Timestamp Values.
 * ----------------------------------------------------------------------------
 * For use: (Linux Kernel 5.1)
 * AIO = Asynchronous I/O, data asyncron read/write, Programs can transfers
 * initialize and then we can do other works, in time the Kernel the I/O
 * Operations starts.
 * Persistent Memory, use by Datas, so anything want cap the Powerline PC,
 * the Datas don't lost, the Data Recovery Points hold the Datas, saved
 * next System starts he point to last save.
 * In Windows 10 make this the 
 * internal 'Resent' Database with next start the App,
 * Visual Studio, Recovery the last Datas.
 * Multi-User-MIMO = Serving multiple clients at the same time
 * SPDK = Storage Performance Development Kit
 * DPDK = Data Plane Development Kit
 * Filewatcher = Fanotify - simple and best Watching by change at File System.
 * io_uring = Exchange of I / O operations and data with 
 * user space takes place via separate ring buffers.
 * ----------------------------------------------------------------------------
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the 
 * along with this program.  If not, see 
 * ----------------------------------------------------------------------------
 * 
 * 
 * ----------------------------------------------------------------------------
 */


// /** in Visual C# not allowed ! more then two asterics  :)

// Insert EMOJI in your Code bzw. Commentblock  🖥 here all emoji's uni color, in Office in Multi Color



/* insert emoji's with Screen - Tastatur 👩‍🦰 - 💥💫💘💓 right mouse click on taskbar, window Screemtastatur show, right on Taskbar show the sign, click it!
 * emoji's show with click smile face, choice an emoji and click it then he insert in document or here in commentblock. 😜
 */

/*** <!-- ⚠ **WARNING** -->
*/

/*** <!-- 👉 **NOTE** -->
 */

/*** <!-- ❌ **Crictical** -->
 */

/*** <!-- ❗ **ATTENTION** -->
 */

/*** <!-- ❔ **QUESTION** -->
 */

/*** <!-- 👁‍🗨 **FOR YOUR EYES ONLY ! -->
*/

/*** <!--  ✅ **OK** Ready for use ! -->
 */




/*** 🚩🏴‍☠️☢🔚🗽🛠🔧⚔👀 ⚡ 👌🗓📌📍 © ® ™
 */







/*-----------------------------------------------------------------------------
    This software is the confidential and proprietary information of
    VGF-KernelTeam - ("Confidential Information").  You shall not
    disclose such Confidential Information and shall use it only in
    accordance with the terms of the License Agreement you entered into
    with VGF-KernelTeam.

    VGF-KERNELTEAM MAKES NO REPRESENTATIONS OR WARRANTIES ABOUT THE SUITABILITY 
    OF
    THE SOFTWARE, EITHER EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE
    IMPLIED WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR
    PURPOSE, OR NON-INFRINGEMENT.

    VGF-KERNELTEAM SHALL NOT BE LIABLE FOR ANY DAMAGES
    SUFFERED BY LICENSEE AS A RESULT OF USING, MODIFYING OR
    DISTRIBUTING THIS SOFTWARE OR ITS DERIVATIVES.

    Copyright_Version_1.0_BETA

    This file is the same as x that comes with y,
    except that the has been changed so that it is compilable
    under more than just
*/

/******************************************************************************
 * MAC, macOS, watchOS, tvOS is a registered trademark of Apple Computer, Inc.
 * ! NOTE ! iOS is a registered trademark of Cisco Corporation.
 * ----------------------------------------------------------------------------
 * Intel is a registered trademark of Intel Corporation.
 * 
 * Active Desktop, ActiveX, Authenticode, BackOffice, FoxPro, FrontPage, 
 * Visual Studio, Jscript, Microsoft, Microsoft Press, MSDN, MS-DOS, MSN,
 * Outlook, PivotTable, PowerPoint, Visual Basic, Visual C++, Visual FoxPro,
 * Visual InterDev, Visual J++, J#, Visual Studio, Win32, Windows,
 * and Windows NT are either registered trademarks or
 * trademarks of Microsoft Corporation in the United States 
 * and/or other countries.
 * ----------------------------------------------------------------------------
 * Live now! Visual FoxPro as Visual FoxPro.NET after 
 * bring sourcecode to FoxPro Community
 * from Microsoft, new written Visual C#.
 * Visual J++, J# end 2007, but look at lot of sample and 
 * Microsoft Java SDK and 
 * Windows Class Foundation --> later .NET Framework in managed C++ and C#.
 * For Developer (Learning about Microsoft Developer):
 * MS Operation System - take free on MS GitHub: (NO COMMERICAL USE !)
 * MS-DOS 1.2 and 2.0 ---- with sourcecode - assembler written .asm
 * Windows File Manager -- with sourcecode - C written .c
 * 
 * 
 * ----------------------------------------------------------------------------
 * *** ATTENTION *** write for Export !
 * 
 * This software is subject to the U.S. Export Administration Regulations and
 * other U.S. law, and may not be exported or re-exported to certain countries
 * ( Cuba, Iran, North Korea, Sudan, Syria, and the Crimea region of Ukraine) 
 * or 
 * to persons or entities prohibited from receiving U.S. exports
 * (including Denied Parties, Specially Designated Nationals,
 * and entities on the Bureau of Export Administration Entity List or
 * involved with missile technology or nuclear, chemical or biological weapons).
 *
 * © 1982 - 2019 by Microsoft Corporation. All rights reserved.
 * 
 * ***************************************************************************/

// That's is the .NET Base Assembly - all Types, Objects
using System;
using System.IO;

// Set here in us Directives all other are light grayed NOT in use!
// Build run the Compiler delete this, and comments, 
// NOT in use variables and more...!
using Microsoft.Win32;
using System.Threading;

using System.Diagnostics;

/******************************************************************************
 * The own namespaces, with/without static classes here in this Block.
 * this is not a assembly/directive, 
 * is only namespace from other Visual C# - Filename.cs
 * in this Project-Solution, 
 * classname same as namespace written all with static
 * 
 * 
 * 
 *****************************************************************************/

/*!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
 * Here all directives from other Assemblies.
 * and namespaces in other Files - csharp files x.cs
 * project namespaces and static class, so you can directly use Method.
 * 
 * namespace Visual.Operation.System.Base and static class VOSInternalBase.
 * using static Visual.Operation.System.Base.VOSInternalBase;
 * Here internal constants, variables, instances, instancevariables...
 * simplesample set only one instance for registry/registrykey,
 * see in InternalBase.cs
 * 
 * 
 *!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
*/

// all Windows Operation System constants, enumerators, structures
using static Visual.Operation.System.Native.NativeMethods;

// all Windows Operation System Functions: user32, shell32, kernel32.dll,
// A lot of them in .NET Framework but internal written, no use!
using static Visual.Operation.System.Native.UnsafeNativeMethods;

// all C/C++ Runtime Library Functions
// random number generator, exit functions with/without Parameters
// NRMExit(ERROR_CODE exitcode); - all exitcode at enumerators from Runtime.
using static Visual.Operation.System.Native.NativeRuntimeMethods;



// Enumerator STYLES for MessageBox
using static Visual.Operation.System.Internal.InternalUtilities.VOSInternalUtilities;

//
using static Visual.Operation.System.Base.VOSInternalBase;


//-----------------------------------------------------------------------------
// namespace Visual.Operation.System
//-----------------------------------------------------------------------------
// First write Windows Operation System Wrapper Methods for Version and 
// Revisions as Helper Methods or Queries.
//
//-----------------------------------------------------------------------------
namespace Visual.Operation.System.Internal
{


    /// <summary>
    /// class InternalOSMethods
    /// </summary>
    /// <!-- Author TIPPO -->
    /// E-mail-Adress:
    /// 
    /// Community Website TIPPO:
    /// http://www.vgfc.org/Tippo
    /// 
    /// <remarks>
    /// !NOTE! private have now, degree of protection
    /// return is the last in method, after return standing code is not execute!
    /// return -dev slang- jump out!
    /// </remarks>
    public static class InternalOSMethods
    {

        /**********************************************************************
         * Globals in Class Head
         * Global in a Class, if Class is declared static so the Globals too.
         * static object
         * static readonly object
         * static instance for a class
         * static RegistryKey ndpKey = RegistryKey.OpenBaseKey(...);
         * Global variables, constants
         * static same here as const.
         * 
         * BUT NOT METHODS !
         * --------------------------------------------------------------------
         * double slashes, three slashes can shorty with sign @ 
         * is unicode sign
         * ("\\.\\") --- (@"\.\")
         * ("\\\...\\.\\") --- (@"\\...\.\")
         * 
         * TIPPO!TIP:
         * XML-Commentary-Block you can set this or other comments: 
         * (same in JavaScript comment)
         * 
         * <!-- Author TIPPO -->
         * 
         * <!-- Author TIPPO -->
         * 
         * take message to me with:
         * E-mail-Adress:
         * https://kurschristian@gmail.com
         * 
         * Community Website TIPPO:
         * http://www.vgfc.org/Tippo
         * 
         * my own email account by Google can load with:
         * https://mail.google.com/mail/kurschristian
         * 
         * 
         */

        /// <summary>
        /// Class Constructor
        /// Make test with General Information
        /// so when he jump into class show the Message.
        /// 
        /// can write so: 
        /// public static class constructor
        /// without static compile make message "class can't instanceconstrutors!"
        ///
        /// <!-- Author TIPPO -->
        /// by set class instance in a other program, and call,
        /// this Message come first, out Class Constructor
        /// <!-- Author TIPPO -->
        /// </summary>
        /// <remarks>
        /// Query is 64BIT Operation System on current Computer.
        /// </remarks>
        static InternalOSMethods()
        {
            //-------------------------------------------------------------------------
            // make query for current operation system,
            // is 64 System ? - global internal with Lambda-operator => is an Property
            //-------------------------------------------------------------------------
            if (!X64)
            {
                // message is a global string variable for all Methods.
                // for more than one row, set += operator.
                vosmessage = "This is NOT a Windows Operation System 64BIT\n";
                vosmessage += "This Assembly is in 64BIT written !\n";
                vosmessage += "Now Terminate the Thread, but not the Process NOW !.\n";

                VFLMsgBox(vosmessage, "General Information of Visual.Operation.System.dll", STYLES.OkOnly | STYLES.Exclamation | STYLES.MsgBoxSetForeground | STYLES.SystemModal);
                Beep(5000, 2000);

                // 1150 is The specifies program requires a newer Version of Windows Operation System.
                // ERROR_OLD_WIN_VERSION from WinError.h - C/C++ Headerfile
                NRMExit(EXIT_CODES.ERROR_OLD_WIN_VERSION);
            }

            // string message is global and static
            // for more than one messagetext use += and \n newline
            // for message as global variable set short name Visual Operation System vos,
            // so no collision with other assembly with message.
            vosmessage = "THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS \"AS IS \" \n";
            vosmessage += "AND ANY EXPRESS OR IMPLIED WARRANTIES\n";
            vosmessage += "INCLUDING, BUT NOT LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY \n";
            vosmessage += "AND FITNESS FOR A PARTICULAR PURPOSE ARE DISCLAIMED.\n";
            vosmessage += "IN NO EVENT SHALL INTEL CORPORATION BE LIABLE FOR ANY DIRECT, \n";
            vosmessage += "INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES\n";
            vosmessage += "(INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES\n";
            vosmessage += "LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION)\n";
            vosmessage += "HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, \n";
            vosmessage += "STRICT LIABILITY, OR TORT(INCLUDING NEGLIGENCE OR OTHERWISE)\n";
            vosmessage += "ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.\n\n\n";
            vosmessage += "Copyright © 2018 by VGF-KernelTeam and Christian 'TIPPO' Kurs.\n";
            vosmessage += "All Rights Reserved.\n";
            vosmessage += "Portions © 2018 by Microsoft Corporation. All rights reserved.\n";

            // MessageBox from Visual Function Library written in C.
            // enumerator STYLES like VB.NET - Button, Icon, System, Modal
            VFLMsgBox(vosmessage, "Visual Operation System", STYLES.OkOnly | STYLES.Information | STYLES.MsgBoxSetForeground | STYLES.SystemModal);

            //-------------------------------------------------------------------------
            // Microsoft Guideline Three native classes for better safe:
            // class SafeNativeMethods as static
            //
            //----------------- THAT's NEW --------------------------------------------
            // One class of three, Microsoft want it!
            // that's new, [Security Attribute]
            // Allows managed code to call into unmanaged code without a stack walk.
            // SafeNativeMethods NO Dangerous and NO Risk for User Call.
            //-------------------------------------------------------------------------
            //with Attribute: [SuppressUnmanagedCodeSecurity]
            //-------------------------------------------------------------------------

            //
            // define new MessageBox in Visual Function Library - Take here Windows MessageBox
            // see write a Style Enumerator like Visual Basic, with Operator or vertical bar | 
            //
            VFLMsgBox(vosmessage, "General Information of Visual.Operation.System.dll", STYLES.OkOnly | STYLES.Information | STYLES.MsgBoxSetForeground | STYLES.SystemModal);

        }



        #region ### Windows Operation System Information ###

        /* -------------------------------------------------------------------
         * Windows 10 Spring Creators Update - April Update Redstone 4 - 
         * OS-Build 17134 actual Revision 191
         * 
         * Windows 10 October Update 2018 - Upcoming feature update 
         * October 2018 Redstone 5 - actual OS-Build 17754
         * This is the last Redstone !, breaking!
         * --------------------------------------------------------------------
         * Windows 10 Defender Anti-Virus-Module
         * Windows 10 Defender Anti-Virus-Anti-Malware Module 1809
         * Antimalware (Antivirus + Antispyware)
         * ("Antivirus-Antischadwareplattform")
         * 
         * This zwo Module everytime new! - with newest Virus Signatures.
         * 
         * --------------------------------------------------------------------
         * 2019:
         * Windows 10 19H1 - Next feature update - 2019 First in Year
         * in develop actual OS-Build 18329.
         * 
         * Windows 10 March Update 2019 - 1903
         * --------------------------------------------------------------------
         * Windows 10 19H2 - 2019 Second in Year
         * 
         * --------------------------------------------------------------------
         * For Developers:
         * ATTENTION:
         * At Windows 10 - Operation System source here from SDK - 19H1 - 2019:
         * in Headerfiles set this, note! 
         * Microsoft next Version Parts removed/set deprecated
         * ** DEPRECATED ** DEPRECATED ** DEPRECATED ** DEPRECATED 
         * winnt.h
         * ****** OBSOLETE functions
         * --------------------------------------------------------------------
         * New SDK's, new API's 
         * (!ATTENTION! some Old Api's, Microsoft removed out OS) 
         * 
         * Windows goes AI/KI, Azure, Cloud, 
         * Machine Learning (Preview last SDK - Windows ML)
         * Have Questions or anything, use the E-Mail from 
         * Windows Developer / Software Engineers,
         * wishes, idea's or other welcome... 
         * Have fun with them nicknames, joke: 'bag on the Head'
         * overcoat: 'Big Mouse'
         * Website: 
         * 
         * 
         * 
         * --------------------------------------------------------------------
        */
        #endregion ### Windows Operation System Information ###





        // TIPPO_UNTESTED the Windows Operation System Method, please wait!

        /// <summary>
        /// Check Windows Operation System
        /// 
        /// </summary>
        /// <!-- Author TIPPO -->
        /// <returns>
        /// returned current Windows Version as string
        /// </returns>
        public static string VOSCheckWindowsOperationSystem()
        {
            // Windows 2000 with 5.0

            if (Environment.OSVersion.Version.Major == 5 && Environment.OSVersion.Version.Minor == 1)
            {
                vosmessage = "Windows XP on this Computer is running !.";
            }
            else if (Environment.OSVersion.Version.Major == 6 && Environment.OSVersion.Version.Minor == 0)
            {
                vosmessage = "Windows Vista on this Computer is running !. Please make directly Update! Technical Uncorrectness in System!.";
            }
            else if (Environment.OSVersion.Version.Major == 6 && Environment.OSVersion.Version.Minor == 1)
            {
                vosmessage = "Windows 7 on this Computer is running !.";
            }
            else if (Environment.OSVersion.Version.Major == 6 && Environment.OSVersion.Version.Minor == 2)
            {
                vosmessage = "Windows 8.0 on this Computer is running !.";
            }
            else if (Environment.OSVersion.Version.Major == 6 && Environment.OSVersion.Version.Minor == 3)
            {
                vosmessage = "Windows 8.1 on this Computer is running !.";
            }
            else if (Environment.OSVersion.Version.Major == 10 && Environment.OSVersion.Version.Minor == 0)
            {
                vosmessage = "Windows Windows 10 on this Computer is running !.";
            }

            return vosmessage;

        } // end of method::VOSCheckWindowsOperationSystem

        #region ### Windows 10 Check Operation System with Revisionnumber ###

        /* ------------------------------------------------------------------------------------
         * New Windows 10 - Major 10 Minor 0 ever!, Build and Revision increment by Microsoft.
         * Operation-System-Build increment after great update most 2 or 3 in Year.
         * ------------------------------------------------------------------------------------
         * Operation-System-Revision increment everytime, bugfixes, improvements, securityfixes
         * most by cumulative updates... but no new functions!.
         * ------------------------------------------------------------------------------------
         * In the next codeline found a constant CVKey for registry key in Class-Head:
         * with sign @ as unicode (UTF16), only one backward slash, 
         * normally two backward slashes.
         * 
         * @"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion";
         * -------------------------------------------------------------------------------------
         * Registry the System Database, settings, information and more
         * 
         * 
         * -------------------------------------------------------------------------------------
         */
        /**********************************************************************
       * 
       * Windows 10 October Update - Information and Revisions -
       * Windows 10 Professional Edition is a Workstation.
       * Windows 10 Home Edition, have no all Features and no Firewall,
       * no more Networking / Cloud.
       * 
       * see below following comments !
       * 
       *********************************************************************/

        //--------------------------------------------------------------------------------------------------
        // New Great Update: Windows 10 October Update 2018 - OS-Build 17763.1 - 02.10.2018 -
        //--------------------------------------------------------------------------------------------------
        // TIPPOTIP: Let automatic update's!, Microsoft Cumulative Update are automatic,
        // most by Bugfixes, Security Leaks and Improvements...
        // Microsoft increment then Revisionnumber automatic, see at Command Tool, Registry-Key UBR.
        // More Functionality, more Functions by New Dynamic Link Library's (SDK 17763 C++ New Headerfiles)
        //--------------------------------------------------------------------------------------------------
        // Windows 10 supports Oracle Java, all Java App's runs. 
        //
        // automatic update by new Java and JDK's. (Java 10, 11, next 12)
        // Microsoft Umbrellas Windows API DLL's: --- in folder \bin - Java JRE 1.8.0_201 - 22.01.2019
        // api-ms-win-core-util-l1-1-0.dll - new update Java JRE 22.01.2019
        // JavaAccessBridge-32.dll - Windows to Java ?
        // JAWTAccessBridge-32.dll - AWT
        // WindowsAccessBridge-32.dll - Java to Windows ?
        // wsdetect.dll
        //--------------------------------------------------------------------------------------------------
        // App - Programs and Features --> Windows Features actived/deactived (Window): 
        //--------------------------------------------------------------------------------------------------
        // NEW ! Virtual Machine Platform - Enables Platform Support for Virtual Machines.
        // NEW ! Device Lockdown
        // NEW ! Data Center Bridging (IEEE)
        // NEW ! Guarded Host
        // NEW ! Work Folders Client
        // NEW ! TFTP Client
        // NEW ! Container Image Manager
        // NEW ! Containers
        // NEW ! Host worked WebKernel (IIS)
        // NEW ! ADLDS - Active Directory Lightweight Directory Service
        // NEW ! Windows Process Activation Service:
        // ----.NET Enviroment
        // ---- Configuration API's
        // ---- Processmodell's
        // --------------------------------------------------------------------------------------------------
        // Network Libraries Client/Server only at Professional/Enterprise:
        // Windows 10 Professional Edition is now a Workstation. command line tool:
        // c:\>net accounts under Role of Computer stand WORKSTATION.
        //---------------------------------------------------------------------------------------------------
        // c:\>whoami /all
        // while Windows 10 Multi User System is, one User or more on one Computer,
        // LogScreen one or more users.
        // 
        // --------------------------------------------------------------------------------------------------
        // Any User become a Security ID from Windows 10
        // --------------------------------------------------------------------------------------------------
        // BENUTZERINFORMATIONEN
        // ---------------------
        //
        // Computername\Benutzername             SID
        // ===================== ==============================================
        // desktop-mnk3mvk\tippo S-1-5-21-3373537164-1258717689-2658483839-1002
        // ...
        //
        // Shwo our IP-Configuration on Computer
        // c:\>ipconfig
        // your own IPv4 Adress
        // IPv4-Adresse  . . . . . . . . . . : 192.168.8.110
        // IPv6-Adresse 
        // --------------------------------------------------------------------------------------------------
        // NEW Networking Dynmaic Link Libraries - many more...
        // ATTENTION ! inside Microsoft can make query about License ! Client/Server Connection.
        // TIPPOTIP: Microsoft Essential Server little Brother of Server 2017 - cost: 500 $
        // 25 Users and 50 Devices with CAL.
        // --------------------------------------------------------------------------------------------------
        // WINSTA.dll - Winstation Library Connection Network / Server
        // LOGONCLI.dll - Net LogOn Client DLL
        //
        // NEW Miscellous C/C++ Runtimes Libraries
        // NEW dotnet command tools line Version 2.1.403
        // NEW
        //---------------------------------------------------------------------------------------------------

        /*
         * end of Comments
         * 
         */

        /*
         * For Developers:
         * 1. want returned bool (0 or 1) as literal string, so write true.ToString() or false.ToString() =>
         * True or False as returned string, but you must change returned datatype from bool to string.
         * 
         */

        /// <summary>
        /// Check Windows 10 Version, is OS-Build 17134 and Revision 1
        /// </summary>
        /// <!-- Author TIPPO -->
        /// TIPPO become first Final Release before STOPPED!
        /// Windows 10 'Spring Creators Update' - 17134.1 was the Final Release but Microsoft has STOPPED !,
        /// inside BIG BUG !, after cleanup's rename the Update to Windows 10 April Update.
        /// For Questions at Windows 10, over there my E-Mail or Website, All welcome!
        /// 
        /// <!-- Author TIPPO -->
        /// <returns>
        /// returned True is OS-Version 17134 and Revision 1
        /// NO, False as Literal
        /// </returns>
        public static string VOSIsWindows10_OSBuild_17134_Revision_1()
        {
            /*
             * Open registry key Local Machine.
             * RegistryKey ndpKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry32).OpenSubKey(CVKey);
             * In File InternalBase.cs
             * have write constant key string and class instance in Class-Head as static, so for all Methods use
             * the instancevariable ndpKey only.
             * Directive:
             * using static Visual.Operation.System.Base.VOSInternalBase;
             * 
             * vosmessage same as constant string for use in this Project.
             * 
             */

            //------------------------------------------------------------
            // given returned Value of Registry Key UBR, here hexadecimal,
            // so must convert to integer value.
            // ndpKey as global instancevariable.
            //------------------------------------------------------------
            object releaseKeyAsObject = ndpKey.GetValue("UBR");

            //------------------------------------------------------------
            // convert releaseKeyAsObject to integer 
            // (releaseKeyAsObject is Object)
            // set datatypes for 64BIT System, so no problems!
            // why? 
            // Microsoft Guidelines for Datatypes in 32 BIT and 
            // 64 BIT Systems are different,  integer 4 bytes (32BIT)
            // integer 8 bytes (64BIT).
            // At Buildrun the Compiler make informations about this.
            // so pass on your Datatypes, Declarations, Parameters.
            //------------------------------------------------------------
            // Tipplin: make migration now to 64BIT, 
            // the 32BIT Area goes end!.
            // Next Generation of Windows Operation System is 128BIT !.
            // same Functions, Structs in NEW SDK 2019.
            // (NT 4.0 was 64BIT internal, AS/400 was 128BIT internal)
            // (All Intel Processors 80BIT internal)
            // Avantage is in .NET The Value Converter, convert datatypes
            // among themselves and convert Objecttype to datatype.
            //------------------------------------------------------------
            long releaseKey = Convert.ToInt64(releaseKeyAsObject);

            // set given releasekey as long comparison with Windows Operation System Revisionnumber
            if (releaseKey == 1)
            {
                VFLMsgBox("This Version is Windows 10 OS-Build 17134 and Revision 1", "Check Windows Operation System Version", STYLES.OkOnly | STYLES.Information | STYLES.MsgBoxSetForeground | STYLES.SystemModal);

                // returned boolean as literal True or False.
                // normally as 0 or 1.
                // NOTE! Windows Operation System has special boolean as 1 byte, by Visual C# use byte as datatype by return.
                return true.ToString();
            }
            else
            {
                vosmessage = "This Version is NOT Windows 10 OS-Build 17134 and Revision 1\n";
                vosmessage += "That's was the First Spring Creators Update April 2018, please make update now !\n";
                vosmessage += "Microsoft has STOPPED! this Final Release for other Users, Big Bug - an blocking Bug!\n";
                vosmessage += "Microsoft after cleanup, rebrand the update name to Windows 10 April Update 2018.\n";
                vosmessage += "Microsoft often increment the Revision for Bugfixes and improvements now!.\n\n";
                vosmessage += "Please click Update search button, new great update or cumulatives update or secuirty updates !.\n\n";
                vosmessage += "Cumulative Update for Bugfixes and so... make Revision increment into System adn Registry.\n";
                vosmessage += "Registry Key: CurrentVersion Revision Key is UBR in hexadecimal value:\n";
                vosmessage += "000000a7 is Revision 167 - BuildLab: 17134.rs4_release.180410-1804\n";
                vosmessage += "BuildLab means your Windows Operation System build at 10.04.2018 at 18:04 - Final Release 17134 Redstone 4\n";
                vosmessage += "Microsoft make a break at 2019 with Redstones, new Hatch Tags comes HY1/HY2/HY3 \n";

                // our famous MessageBox withn enumerator STYLES like VB.NET
                // vosmessage in class Base as static string, so for all classes and Methods...
                VFLMsgBox(vosmessage, "Check Windows Operation System Version", STYLES.OkOnly | STYLES.Information | STYLES.MsgBoxSetForeground | STYLES.SystemModal);

                // this bool is boolean literal - returned word True or False.
                // normally 0 or 1 by bool. In Visual C# is hardcoded.
                return false.ToString();
            }


        } // END of Method::VOSIsWIndows10Build17134.1

        /// <summary>
        ///     Is Windows10 - OSBuild 17134 Revision 48
        /// </summary>
        /// <!-- Author TIPPO -->
        /// Windows 10 April Update 2018 first Revision 48
        /// ! Microsoft increment the Revisionnumber automatic in System.
        /// ! Registry change Key UBR...
        /// <!-- Author TIPPO -->
        /// <returns></returns>
        public static bool VOSIsWindows10_OSBuild_17134_Revision_48()
        {
            // see the new Microsoft Code Convention
            // Klamatur in der if( () ), der compiler nimmt diese als erste auswertung
            // (Environment.Version.Major == 10) && double AND is better, same vertical bar operator ||, better as one vertical bar operator |
            // Compiler check this first than after double operator && the next
            // Better Runtime Tuning !.
            // Version.Major, Version.Minor, Version.Build, Version.Revision
            // 
            // NEW Microsoft Improvements for better runtime tuning
            // (Environment.Version.Major >= 10) Compiler check first!

            // Get Value from Registry Key UBR for Revisionnmuber
            object releaseKeyAsObject = ndpKey.GetValue("UBR");

            Int64 releaseKey = Convert.ToInt64(releaseKeyAsObject);
            if (releaseKey == 48 || releaseKey > 48)
            {
                vosmessage = "This Version is Windows 10 OS-Build 17134 and Revision 48\n";
                vosmessage += "or is higher as Revision 48.";
                vosmessage += "Revision-Update: 08.05.2018\n";

                VFLMsgBox(vosmessage, "Check  Windows Operation System Version", STYLES.OkOnly | STYLES.Information | STYLES.MsgBoxSetForeground | STYLES.SystemModal);
                return true;
            }
            else
            {
                
                VFLMsgBox("This Version is NOT Windows 10 OS-Build 17134 and Revision 48", "Check Windows Operation System Version", STYLES.OkOnly | STYLES.Information | STYLES.MsgBoxSetForeground | STYLES.SystemModal);
                return false;
            }

        } // END of Method::VOSIsWIndows10Build17134_48

        /**********************************************************************
         * 
         * END OF REVISION WRAPPER OS-BUILD 17134 - APRIL UPDATE 2018
         * 
         *********************************************************************/



        /**********************************************************************
        * 
        * BEGIN OF REVISION WRAPPER OS-BUILD 17763 - OCTOBER UPDATE 2018
        * 
        *********************************************************************/

        /// <summary>
        /// Check Windows 10 Version, is OS-Build 17763.1 Final Release
        /// </summary>
        /// <!-- Author TIPPO -->
        /// Windows 10 October Update 2018 - 02.10.2018 - Final
        /// <!-- Author TIPPO -->
        /// <returns>
        /// 
        /// </returns>
        public static bool VOSIsWindows10_OSBuild_17763_Revision_1()
        {


            // Visual Studio 2017 V 15.8.2 class Enviroment
            // Version.Major, Version.Minor, Version.Build, Version.Revision
            // MajorRevision, MinorRevision don't use it !
            // NEW Microsoft Improvements for better runtime tuning
            // (Environment.Version.Major >= 10) Compiler check first!
            //
            // Registry Key for Operation System .Revision
            // is Registry Key UBR: 0x00000011d = 1
            //

            // Get Value from Registry Key UBR for Revisionnmuber
            object releaseKeyAsObject = ndpKey.GetValue("UBR");

            int releaseKey = Convert.ToInt32(releaseKeyAsObject);
            if (releaseKey == 1 || releaseKey > 1)
            {

                vosmessage = "This Version is Windows 10 OS-Build 17763 and Revision 1,\n";
                vosmessage += "or is higher as Revision 1\n";
                vosmessage += "Revision-Update: 02.10.2018\n";

                VFLMsgBox(vosmessage, "Check  Windows Operation System Version", STYLES.OkOnly | STYLES.Information | STYLES.MsgBoxSetForeground | STYLES.SystemModal);
                return true;
            }
            else
            {
                VFLMsgBox("This Version is NOT Windows 10 OS-Build 17763 and Revision 1", "Check Windows Operation System Version", STYLES.OkOnly | STYLES.Critical | STYLES.MsgBoxSetForeground | STYLES.SystemModal);
                return false;
            }

        } // END of Method::VOSIsWIndows10Build17763.1

        



        /*-----------------------------------------------------------------------------------------
         * Windows 10 October 2018 - END HERE -
         * But new Revisions goes on!
         *
         *-----------------------------------------------------------------------------------------
         */








        /*-----------------------------------------------------------------------------------------
         * Windows 10 May Update - 1903 - 2019 - 19h1 
         * OS-Build at time build increment 18362 Revision 1
         * 
         *----------------------------------------------------------------------------------------- 
         * 
         */

        /// <summary>
        ///  Check Windows 10 Version, is OS-Build 18362 and Revision 1
        /// </summary>
        /// <!-- Author TIPPO -->
        /// 
        /// <!-- Author TIPPO -->
        /// <remarks>
        /// Microsoft Right, increment the Revisionnumber by updates.
        /// </remarks>
        /// <returns>
        /// Windows 10 March Update 2019 - final release
        /// </returns>
        public static bool VOSIsWindows10_OSBuild_18362_Revision_1()
        {


            /*
             * Visual Studio 2017 - class Enviroment
             * Version.Major, Version.Minor, Version.Build, Version.Revision
             * MajorRevision, MinorRevision don't use it !
             * 
             * NEW Microsoft Improvements for better runtime tuning
             * (Environment.Version.Major >= 10) Compiler check first!
             * 
             * Registry Key for Operation System .Revision
             * is Registry Key UBR:
             * 
             */

            // Get Value from Registry Key UBR for Revisionnmuber
            object releaseKeyAsObject = ndpKey.GetValue("UBR");

            int releaseKey = Convert.ToInt32(releaseKeyAsObject);
            if (releaseKey == 1)
            {

                vosmessage = "This Version is Windows 10 OS-Build 18356 and Revision 1\n";
                vosmessage += "Revision-Update: 12.03.2019\n";
                vosmessage += "-------------------------------08.03.2019-16:07 Hour\n";
                vosmessage += "Compiled at 18356.19h1_release.190308-1607\n";

                VFLMsgBox(vosmessage, "Check  Windows Operation System Version", STYLES.OkOnly | STYLES.Information | STYLES.MsgBoxSetForeground | STYLES.SystemModal);
                return true;
            }
            else
            {
                VFLMsgBox("This Version is NOT Windows 10 OS-Build 18356 and Revision 1", "Check Windows Operation System Version", STYLES.OkOnly | STYLES.Critical | STYLES.MsgBoxSetForeground | STYLES.SystemModal);
                return false;
            }

        } // END of Method::VOSIsWIndows10Build18362.1

        /// <summary>
        ///  Check Windows 10 Version, is OS-Build 18362 and Revision 116
        /// </summary>
        /// <!-- Author TIPPO -->
        /// This is official May Update Release
        /// <!-- Author TIPPO -->
        /// <remarks>
        /// Microsoft Right, increment the Revisionnumber by updates.
        /// </remarks>
        /// <returns>
        /// Windows 10 March Update 2019 - final release
        /// </returns>
        public static bool VOSIsWindows10_OSBuild_18362_Revision_116()
        {


            /*--------------------------------------------------------------
             * Visual Studio 2017 - class Enviroment
             * Version.Major, Version.Minor, Version.Build, Version.Revision
             * MajorRevision, MinorRevision don't use it !
             * 
             * NEW Microsoft Improvements for better runtime tuning
             * (Environment.Version.Major >= 10) Compiler check first!
             * 
             * Registry Key for Operation System .Revision
             * is Registry Key UBR:
             *--------------------------------------------------------------
             */

            // Get Value from Registry Key UBR for Revisionnmuber
            object releaseKeyAsObject = ndpKey.GetValue("UBR");

            int releaseKey = Convert.ToInt32(releaseKeyAsObject);
            if (releaseKey == 116 || releaseKey > 116)
            {

                vosmessage = "This Version is Windows 10 OS-Build 18356 and Revision 116\n";
                vosmessage += "or is higher as Revision 116\n";
                vosmessage += "Revision-Update: 00.00.2019\n";

                VFLMsgBox(vosmessage, "Check  Windows Operation System Version", STYLES.OkOnly | STYLES.Information | STYLES.MsgBoxSetForeground | STYLES.SystemModal);
                return true;
            }
            else
            {
                VFLMsgBox("This Version is NOT Windows 10 OS-Build 18356 and Revision 116", "Check Windows Operation System Version", STYLES.OkOnly | STYLES.Critical | STYLES.MsgBoxSetForeground | STYLES.SystemModal);
                return false;
            }

        } // END of Method::VOSIsWIndows10Build18362.116








        /// <summary>
        ///  Check Windows 10 Version, is OS-Build 18362 and Revision 10000
        ///  skip into second half year release begin by Revision 10000.
        /// </summary>
        /// <!-- Author TIPPO -->
        /// Microsoft skip Revision to 10000 by 19h2 - to OS-Build 18362.10000
        /// <!-- Author TIPPO -->
        /// <remarks>
        /// Microsoft Right, increment the Revisionnumber by updates.
        /// Microsoft increment automatic Revisionnumber by Bugsfixes, Security Fixes by cumulative update.
        /// change UBR in Registry automatic.
        /// at Time Revision 15.07.2019 by 10005.
        /// second half year 19h2 with new system settings and libraries - Network, Web, Cloud, AI / KI...
        /// Dictionaries in many Languages: 
        /// Tipplin actived English and German Dictionary, spelling-orthography
        /// Multilingual text suggestions must be download languages packages do you want.
        /// AI Statistic - Windows 10 now with AI/KI - Windows 10 uses Artificial Intelligence - 
        /// Word Counter, Automatically complete words, 
        /// Suggested words, keystrokes, Spelling corrections, automatic corrections with SwiftKey
        /// words entered by wiping.
        /// Statistics on AI input support
        /// all this active in every Application, Microsoft Editor with black field with three words,
        /// 
        /// For more Information about System use systemtool: systeninfo.exe on command line.
        /// or call Windows Terminal (at Time Preview 0.2.1715.0) - powershell, command line and Linux Bash Shell in one app.
        /// Windows Terminal an Windows Operation System Compoment as Open Source at GitHub.
        /// for change some settings in Widnows Terminal use profile.json click on arrow down on Menue Bar click on Settings,
        /// if Visual Studio installed he open profile.json:
        /// "cursorHeight" : 15, ---------------> cursor height
        /// "cursorShape" : "vintage", ---------> old cursor style green underline
        /// "cursorShape" : "bar", -------------> normally cursor |
        /// Tipplin Tip: want change in other folder, so input cd -space- and marked foldername right click on it, 
        /// go return to cd -space- left click folder stand now here.
        /// By Microsoft Build Conference:
        /// Microsoft open Windows Operation System for all Developer's part to part all on GitHub.
        /// Windows 10 Terminal, Windows 10 Calculator, Windows Implemantation Libraries (WIL) all in C++ and C#......
        /// Cooperation wanted, please read information
        /// </remarks>
        /// <returns>
        /// Windows 10 Sep Update 2019 first revision
        /// </returns>
        public static bool VOSIsWindows10_OSBuild_18362_Revision_10000()
        {


            /*
             * Visual Studio 2017 - class Enviroment
             * Version.Major, Version.Minor, Version.Build, Version.Revision
             * MajorRevision, MinorRevision don't use it !
             * 
             * NEW Microsoft Improvements for better runtime tuning
             * (Environment.Version.Major >= 10) Compiler check first!
             * 
             * Registry Key for Operation System .Revision
             * is Registry Key UBR:
             * 
             */

            // Get Value from Registry Key UBR for Revisionnmuber
            object releaseKeyAsObject = ndpKey.GetValue("UBR");

            int releaseKey = Convert.ToInt32(releaseKeyAsObject);
            if (releaseKey == 10000 || releaseKey > 10000)
            {

                vosmessage = "This Version is Windows 10 - 19h2 - OS-Build 18362 and Revision 10000\n";
                vosmessage += "or higher as Revision 10000.\n";
                vosmessage += "Revision-Update: 01.07.2019\n";

                VFLMsgBox(vosmessage, "Check  Windows Operation System Version", STYLES.OkOnly | STYLES.Information | STYLES.MsgBoxSetForeground | STYLES.SystemModal);
                return true;
            }
            else
            {
                VFLMsgBox("This Version is NOT Windows 10 OS-Build 18362 and Revision 10000", "Check Windows Operation System Version", STYLES.OkOnly | STYLES.Critical | STYLES.MsgBoxSetForeground | STYLES.SystemModal);
                return false;
            }

        } // END of Method::VOSIsWIndows10Build18362.10000

       




      



        /*----------------------------------------------------------------------------------------
         * Windows 10 - 2020 - Open Branch 2020 -
         * OS-Build at time build increment - 20H1 - at Time OS-Build 18945 - 31.07.2019 
         * ---------------------------------------------------------------------------------------
         * Microsoft make new builds at time for 2020 increment Build Number.
         * 
         * Developer Tippo Senior Member of Windows Kernel Team Blog:
         * make sure, is come unicode in Windows only?! for International!:
         * 
         * 1. implement Unicode V 12.0, emojis 🧑👩🎅👩‍🎨, katemojis, symbols into Windows 10 - 2020 -
         * (Windows 10 May Update 2019 - OS-Build 18362.116 - 
         * emoji's over Screen-Keybroad set of On, Mouse move to Taskbar, 
         * right click Screen-Keybroad click on. Show it Taskbar right side, click open, 🤩
         * click on Face that's emoji's and chat symbols)
         * 👁‍🗨 in Editor, Visual Studio are uni color, in Office with Color and Resize.🧑
         * 
         * 
         * 2. katemojis with chat symbols.
         * 
         * 3. ATTENTION ! same Functions and other remove or fall out of Windows OS! see SDK!.
         * there are marked!
         * 
         * 4. The best more .NET, Visual C++.NET and Visual C# ! into Windows 10 and make same.
         * 
         * ----------------------------------------------------------------------------------------
         * ----------------------------------------------------------------------------------------
         * Windows 10 Open Source - Parts of Operation System on GitHub with sourcecodes in C/C++ :
         * Cooperation wanted on GitHub.
         * ----------------------------------------------------------------------------------------
         * 1. was the Windows 10 Calculator written in Visual C++.NET,
         * as sourcecode on GitHub, want to work with Developer Team, more features!.
         * ----------------------------------------------------------------------------------------
         * 2. WRK-Master.zip is the Windows Research Kernel Sourcecode written in C.
         *    Windows 10 OS-Build 14393 - 2016 -
         * ----------------------------------------------------------------------------------------
         * 3. WIL = Windows Implementation Libraries with sourcecode in C++ 
         *-----------------------------------------------------------------------------------------
         * 4. New Windows Terminal, old Windows Console -conhost.exe- with sourcecode in C++
         *    Cooperation wanted on GitHub. (NEW Windows Terminal in Alpha/Beta State)
         *----------------------------------------------------------------------------------------- 
         * 5. Task explorer new TAB 
         *-----------------------------------------------------------------------------------------
         * 6. Microsoft Editor with German Spelling (German Dictionary) on German System.
         *    New coding: Ansi, UTF 8, UTF-8 with BOM (Binary Object M), 
         *    UTF-16 LE (Low Endian), UTF-16 BE (Big Endian)
         *    Bing search over Web.
         *    make sure have set Grammar Rules of on in Windows settings option:
         *----------------------------------------------------------------------------------------- 
         * 7.
         *-----------------------------------------------------------------------------------------
         * 8.
         *-----------------------------------------------------------------------------------------
         * 9.
         *-----------------------------------------------------------------------------------------
         * 10.
         *-----------------------------------------------------------------------------------------
         * 
         * 
         * 
         * 
         */

        /// <summary>
        ///  Check Windows 10 Version, is now OS-Build 18865
        ///  First Build for Windows 10 - 20H1 - 2020
        ///  Open Branch 2020 at 03.04.2019
        /// </summary>
        /// <!-- Author TIPPO -->
        /// Preview Build
        /// <!-- Author TIPPO -->
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>
        /// Windows 10 March Update 2020 - 20H1 -
        /// </returns>
        public static string VOSCompareWindows10_OSBuild_And_OSRevision(int OSBuildNummer, int OSRevisionNumber)
        {


            // Visual Studio 2017 V 15.8.2 class Enviroment
            // Version.Major, Version.Minor, Version.Build, Version.Revision
            // MajorRevision, MinorRevision don't use it !
            // NEW Microsoft Improvements for better runtime tuning
            // (Environment.Version.Major >= 10) Compiler check first!
            //

            object releaseKeyAsObject = ndpKey.GetValue("CurrentBuild");


            // Registry Key for Operation System .Revision
            // is Registry Key UBR:
            //
            // Get Value from Registry Key UBR for Revisionnmuber
            object releaseKeyAsObject2 = ndpKey.GetValue("UBR");


            int releaseKey = Convert.ToInt32(releaseKeyAsObject);
            int releaseKey2 = Convert.ToInt32(releaseKeyAsObject2);

            if (releaseKey == OSBuildNummer && releaseKey2 == OSRevisionNumber)
            {

                vosmessage = "This Version is Windows 10 OS-Build {0} and Revision {1} \n"+ OSBuildNummer + OSRevisionNumber;
                
                VFLMsgBox(vosmessage, "Check  Windows Operation System Version", STYLES.OkOnly | STYLES.Information | STYLES.MsgBoxSetForeground | STYLES.SystemModal);
                
                // returned bool as string, here 'True'
                return true.ToString();
            }
            else if(releaseKey <= OSBuildNummer || releaseKey > OSBuildNummer ||  releaseKey2 <= OSRevisionNumber || releaseKey2 > OSRevisionNumber)
            {
                vosmessage = "This Version is Windows 10 OS-Build {0} and Revision {1}\n"+ releaseKey + releaseKey2;
                vosmessage += "NOTE: better make update of newer Build and Revision\n";
                vosmessage += "new Functions, Settings, Security and more."
                VFLMsgBox(vosmessage, "Check Windows Operation System Version", STYLES.OkOnly | STYLES.Critical | STYLES.MsgBoxSetForeground | STYLES.SystemModal);
                
                // returned bool as string, here 'False'
                return false.ToString();
                

            }
            
            return true.ToString();
           
        } // END of Method::VOSCompareWindows10_OSBuild_And_OSRevision




        /*-----------------------------------------------------------------------------------------
         * Windows 10 - OS-Build at time build increment 19536 and Revision 1000 - 20H2
         * Microsoft Skip Head the BuildNumber at Dec 2019 to 19536 as Active Development Branch
         * the active develop from Microsoft Software Engineers.
         * Windows 10 Build 19536.1000 is an .rs_pre_release by Pro Insider Preview.
         * Microsoft increment OS-Build now, make cleanup's
         * Microsoft Windows 10 Spring Update Apr 2004 - 2020
         *----------------------------------------------------------------------------------------- 
         * 2020 following changes comes:
         * Windows 10 now modular, Shell Update Agent, only updating Modules who has new issues,
         * features and new functions and more...
         *----------------------------------------------------------------------------------------- 
         * 
         *----------------------------------------------------------------------------------------- 
         */






















        #endregion ### Windows 10 Check Operation System with Revisionnumber ###

        /// <summary>
        /// Get the Name of Windows 10 Edition Name, how is installed!
        /// </summary>
        /// <!-- Author TIPPO 🧑 -->
        /// 
        /// <!-- Author TIPPO 🧑 -->
        /// <remarks>
        /// Registry - EditionID
        /// Windows 10 Home
        /// Professional, 
        /// Enterprise, 
        /// Professional for Workstations, 
        /// S = School, 
        /// E = Education, 
        /// Lean = Cloud Edition -End 2018
        /// Special Edition for China, 
        /// Special Edition for China Government,
        /// </remarks>
        /// <returns>
        /// 
        /// </returns>
        public static string VOSGetWindows10EditionName()
        {
            /*
             * RegistryKey ndpKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry32).OpenSubKey(CVKey);
             * this instance stand in an other File: InternalBase.cs,
             * set here in Class, the using namespace Base and static Class VOSInternalBase.
             * using static Visual.Operation.System.Base.VOSInternalBase;
             * set this in all Files, you can used.
             */
            object releaseKeyAsObjectEdition = ndpKey.GetValue("EditionID");

            string releaseEditionKey = Convert.ToString(releaseKeyAsObjectEdition);

            /* ----------------------------------------------------------------
             * Windows 10 Home, Professional, Enterprise
             * Special Editions:
             * China, China Government, School, Education, Cloud, 
             * ----------------------------------------------------------------
             * Windows 10 Professional Edition best of:
             * More Security: Firewall, Antivirusscanner, AntiVirusMalware and
             * AntiRansomware (March update 2019), Network Protection - Domain,
             * Private, Public Network with Firewall actived.
             * Kernel isolation make admin, 
             * Kernel isolation against malicious code injection
             * ----------------------------------------------------------------
             * returned Edition Name as string
             */
            return releaseEditionKey;

        }

        /// <summary>
        /// Get Windows 10 current Buildnumber
        /// </summary>
        /// <!-- Author TIPPO -->
        /// 
        /// <!-- Author TIPPO -->
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>
        /// 
        /// </returns>
        public static string VOSGetWindows10CurrentBuild()
        {



            object releaseKeyAsObjectCurrentBuild = ndpKey.GetValue("CurrentBuild");

            string releaseCurrentBuildKey = Convert.ToString(releaseKeyAsObjectCurrentBuild);

            // returned Current Build for Windows 10
            return releaseCurrentBuildKey;

        }

        /// <summary>
        /// Get current registered Organization of Windows
        /// </summary>
        /// <returns>
        /// 
        /// </returns>
        public static string VOSGetWindows10RegisteredOrganization()
        {



            object releaseKeyAsObjectRegisteredOrganization = ndpKey.GetValue("RegisteredOrganization");

            string releaseCurrentRegisteredOrganization = Convert.ToString(releaseKeyAsObjectRegisteredOrganization);

            // returned Current Build for Windows 10
            return releaseCurrentRegisteredOrganization;

        }

        /// <summary>
        /// Get current registered Owner of Windows
        /// </summary>
        /// <returns></returns>
        public static string VOSGetWindows10RegisteredOwner()
        {

            object releaseKeyAsObjectRegisteredOwner = ndpKey.GetValue("RegisteredOwner");

            string releaseCurrentRegisteredOwner = Convert.ToString(releaseKeyAsObjectRegisteredOwner);

            // returned Current Build for Windows 10
            return releaseCurrentRegisteredOwner;

        }

        /// <summary>
        /// Check is Remote Debugger present on System 
        /// </summary>
        /// <returns></returns>
        public static bool VOSCheckIsRemoteDebuggerPresent()
        {

            bool isDebuggerPresent = false;

            return CheckRemoteDebuggerPresent(Process.GetCurrentProcess().Handle, isDebuggerPresent);
        }




        /// <summary>
        /// Show Copyright Message
        /// </summary>
        /// <!-- Author Tipplin -->
        /// Info about Copyright Assembly Visual.Operation.Library.dll 
        /// <!-- Author Tipplin -->
        internal static void VOSShowDeveloperMessage()
        {
            string vosmessage1 = "© Visual.Operation.System.dll";

            vosmessage = "Info about Copyright Assembly Visual.Operation.Library.dll\n\n";
            vosmessage += "Copyright © 2019  by VGF-Community KernelTeam and Christian 'Tipplin' 🐻 Kurs\n";
            vosmessage += "Portions © 1982 - 2019 Microsoft Corporation. All rights reserved.\n";

            VFLMsgBox(vosmessage, vosmessage1, STYLES.OkOnly | STYLES.Information | STYLES.MsgBoxSetForeground | STYLES.SystemModal);
        }















    } // end of class::InternalOSMethods

} // end of namespace::Visual.Operation.System.Internal

/*****************************************************************************/
/********************** END OF FILE::InternalMethods.cs **********************/
/*****************************************************************************/