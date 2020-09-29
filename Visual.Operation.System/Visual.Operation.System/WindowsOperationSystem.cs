
//#############################################################################
//
// Project			:	Visual.Galaxy.Framework
//
//#############################################################################
//
//-----------------------------------------------------------------------------
// Programmer       :	Project-Founder and Main-Author Christian "TIPPO" Kurs
//-----------------------------------------------------------------------------
// Part				:	VGF.Application
//-----------------------------------------------------------------------------
// Base Class       :	
//-----------------------------------------------------------------------------
// Copyright © 2020
// by  Visual Galaxy Framework Community Kernel Developer Team.
//-----------------------------------------------------------------------------
// by Head-Author: Christian "TIPPO" Kurs - Visual C# Developer
// Portions Copyright © 1982 - 2020 by Microsoft Corporation GmbH.
//-----------------------------------------------------------------------------
//
// For same secured Assemblies set inside internal for class, Methods...
// for use in Visual Galaxy Framework, 
// give free with:
//
// [InternalsVisibleAttribute("Visual.Galaxy.Framework", 
// AllInternalsVisible = true)]
//
// ============================================================================
// Warning:  
// ============================================================================
// This product is licensed to you pursuant to the terms of the 
// VGF license agreement included with the original software, and is
// protected by copyright law and international treaties.Unauthorized
// reproduction or distribution may result in severe civil and criminal
// penalties, and will be prosecuted to the maximum extent possible under
// the law.
// You cannot distribute a compiled version 
// of this code without prior registration.
//
// Please see the documentation supplied with
// the VGF Libraries for further details.
//
// Authored by 
// Copyright © 2020
// by  Visual Galaxy Framework Community Kernel Developer Team.
// all rights reserved.
// May be redistributed for free,
// but may not be sold without the author's explicit permission
//
// This software is Copyright © 2020 by VGF-Technologies at VGF-KernelTeam
// You may only use this software if you are an authorized licensee
// of an VGF developer tools product.
//
// This software is considered a Redistributable as defined under
// the software license agreement that comes with the VGF Products
// and is subject to that software license agreement.
//
//-----------------------------------------------------------------------------
// Microsoft make Restrictions of Export for following Countries:
// ----------------------------------------------------------------------------
// This software is subject to the U.S. Export Administration Regulations and 
// other U.S.law, and may not be exported or re-exported to certain countries
// (Cuba, Iran, North Korea, Sudan, Syria, and the Crimea region of Ukraine) or
// to persons or entities prohibited from receiving U.S.exports
// (including Denied Parties, Specially Designated Nationals,
// and entities on the Bureau of Export Administration Entity List or
//involved with missile technology or nuclear, chemical or biological weapons).
//
// © 1982 - 2020 Microsoft Corporation.All rights reserved.
//-----------------------------------------------------------------------------

//-----------------------------------------------------------------------------
// VFGCore
// written by 		
//						Christian "TIPPO" Kurs
//						Ahornweg 1
//				  -G -  53177 Bonn
//						Germany - Allemagne - Duitsland
//-----------------------------------------------------------------------------
// 				    voice               :	  
//					international phone :	
//					Skype               :
//					e-mail				:	kurschristian.Kurs@gmail.com
//					community Website	:	
//										
//-----------------------------------------------------------------------------
// This software is supplied as is. Use it at your own  RISK !!!!.
// Obviously I've tried to do the best job possible.
// If you find any problem with it, let me know.
//
// With any luck, Visual Galaxy Framework will make it obsolete anyway
//----------------------------------------------------------------------------
// License:	
//				NO fee for NON-Commercial use.
//				our Community Website:
// 
//						
//
//				Honest Business Users, to use our compiled Versions, 
//				please call us to send you our Business Licenses.
//				or our Business Website:
//				
//
//-----------------------------------------------------------------------------

/*********************** Developer Disclaimer *********************************
 *
 * Copyright © 2020 by Christian 'TIPPO' Kurs - Germany
 * 
 ******************************************************************************
 * 
 * English
 * 
 * Permission is hereby granted, free of charge, to any person obtaining a copy 
 * of this software and associated documentation files (the "Software"), 
 * to deal in the Software without restriction,
 * including without limitation the rights to use, copy, modify, merge, 
 * publish, distribute, sublicense, and/or sell copies of the Software, and 
 * to permit persons to whom the Software is furnished to do so, 
 * 
 * subject to the following conditions:
 * The above copyright notice and this permission notice shall be included 
 * in all copies or substantial portions of the Software.
 * 
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, 
 * EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE 
 * WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE 
 * AND NONINFRINGEMENT.
 * 
 * IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM,
 * DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, 
 * TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE
 * OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
 * ----------------------------------------------------------------------------
 * 
 * German:
 * 
 * Personen, die eine Kopie dieser Software und der dazugehörigen 
 * Dokumentationsdateien (die "Software") erhalten, 
 * wird hiermit die kostenlose Erlaubnis erteilt.
 * uneingeschränkt mit der Software zu handeln, 
 * einschließlich der Rechte zur Verwendung, zum Kopieren, Ändern, 
 * Zusammenführen, Veröffentlichen, Verteilen,
 * Unterlizenzen und / oder Verkauf von Kopien der Software und 
 * Erlaubnis von Personen, an die die Software geliefert wird,
 * 
 * unter den folgenden Bedingungen:
 * 
 * Der obige Copyright-Hinweis und dieser Erlaubnisschein sind in 
 * allen Kopien oder wesentlichen Teilen der Software enthalten.
 * 
 * DIE SOFTWARE WIRD "WIE BESEHEN" OHNE JEGLICHE GARANTIE, 
 * AUSDRÜCKLICH ODER IMPLIZIERT, EINSCHLIESSLICH, ABER NICHT BESCHRÄNKT 
 * AUF DIE GEWÄHRLEISTUNG DER MARKTFÄHIGKEIT, 
 * EIGNUNG FÜR EINEN BESTIMMTEN ZWECK UND NICHTVERLETZUNG.
 * 
 * IN KEINEM FALL HAFTEN DIE AUTOREN ODER COPYRIGHT-INHABER FÜR ANSPRÜCHE, 
 * SCHADEN ODER ANDERE HAFTUNG.
 * 
 * WENN SIE AUSSCHLIESSLICH EINES VERTRAGS, TORTES ODER ANDERWEITIG SIND, 
 * HERAUSGEGEBEN, ABER ODER IN VERBINDUNG MIT DER SOFTWARE 
 * ODER DIE NUTZUNG ODER ANDERE ABKOMMEN IN DER SOFTWARE.
 * 
 * ----------------------------------------------------------------------------
 *
 * Frensh:
 * Par la présente, une autorisation est accordée gratuitement à toute personne 
 * obtenant une copie de ce logiciel et des fichiers de documentation associée 
 * (le "Logiciel"),
 * traiter le logiciel sans restriction, y compris, sans limitation, 
 * les droits d'utilisation, de copie, de modification, de fusion, 
 * de publication, de distribution, sous-licence, 
 * et / ou vendre des copies du logiciel, 
 * et permettre aux personnes à qui le logiciel est fourni de le faire,
 * 
 * sous réserve des conditions suivantes:
 * 
 * L'avis de copyright ci-dessus et cet avis de permission doivent être inclus 
 * dans toutes les copies ou parties substantielles du logiciel.
 * 
 * LE LOGICIEL EST FOURNI "EN l’ETAT", SANS AUCUNE GARANTIE, 
 * EXPRESSE OU IMPLICITE,
 * Y COMPRIS, MAIS SANS S'Y LIMITER, LES GARANTIES DE VALEUR MARCHANDE, 
 * D'ADÉQUATION À UN USAGE PARTICULIER ET D'ABSENCE DE VIOLATION.
 * EN AUCUN CAS, LES AUTEURS OU LES TITULAIRES DU DROIT D'AUTEUR NE PEUVENT 
 * ÊTRE TENUS RESPONSABLES DE TOUTE RÉCLAMATION, 
 * DE DOMMAGES OU D'AUTRE RESPONSABILITÉ
 * QU'IL SOIT DANS UN ACTION DE CONTRAT, DE LORT OU DE AUTRE FACILITÉ, 
 * RÉSULTANT DU LOGICIEL, OU NON OU LIÉ AVEC CE LOGICIEL
 * OU L'UTILISATION OU D'AUTRES TRANSACTIONS DANS LE LOGICIEL.
 * 
 * ----------------------------------------------------------------------------
 * 
 * Spanish:
 * 
 * Por la presente se otorga el permiso, sin cargo, a cualquier persona que 
 * obtenga una copia de este software y los archivos de 
 * documentación asociados (el "Software"), para operar en el Software sin 
 * restricciones, incluidos, entre otros, los derechos de uso, copia, 
 * modificación, combinación, publicación, distribución, sublicenciar, 
 * y / o vender copias del Software, y para permitir que las 
 * personas a quienes se suministra el Software lo hagan,
 * 
 * sujeto a las siguientes condiciones:
 * 
 * El aviso de copyright anterior y este aviso de permiso se incluirán 
 * en todas las copias o partes sustanciales del Software.
 * 
 * EL SOFTWARE SE PROPORCIONA "TAL CUAL", SIN GARANTÍA DE NINGÚN TIPO, 
 * EXPRESA O IMPLÍCITA, INCLUYENDO PERO NO LIMITADO A LAS 
 * GARANTÍAS DE COMERCIABILIDAD, APTITUD PARA UN PROPÓSITO 
 * PARTICULAR Y NO INCUMPLIMIENTO. EN NINGÚN CASO, LOS AUTORES O TITULARES DE 
 * DERECHOS DE AUTOR SERÁN RESPONSABLES POR CUALQUIER RECLAMACIÓN, 
 * DAÑOS U OTRAS RESPONSABILIDADES, SI EN UNA ACCIÓN DE CONTRATO, 
 * CORTE O DE OTRA MANERA, DERIVADO DE, FUERA DE O EN CONEXIÓN CON EL SOFTWARE
 * O EL USO O OTROS TRATOS EN EL SOFTWARE.
 * 
 * -----------------------------------------------------------------------------
 * 
 * Italian:
 * 
 * L'autorizzazione è concessa, a titolo gratuito, a chiunque ottenga una copia 
 * di questo software e dei relativi file di documentazione (il "Software"),
 * trattare il Software senza limitazioni, 
 * inclusi senza limitazione i diritti di utilizzo, copia, modifica, fusione, 
 * pubblicazione, distribuzione, concedere in sub-licenza e / o vendere 
 * copie del Software e consentire alle persone a cui è fornito 
 * il Software di farlo, 
 * soggetto alle seguenti condizioni:
 * 
 * La suddetta nota sul copyright e questa nota di autorizzazione devono 
 * essere incluse in tutte le copie o parti sostanziali del Software.
 * 
 * IL SOFTWARE VIENE FORNITO "COSÌ COM'È", SENZA GARANZIA DI ALCUN TIPO, 
 * ESPRESSA O IMPLICITA, INCLUSE, A TITOLO ESEMPLIFICATIVO, 
 * LE GARANZIE DI COMMERCIABILITÀ, 
 * IDONEITÀ PER UN PARTICOLARE SCOPO E NON VIOLAZIONE. 
 * IN NESSUN CASO GLI AUTORI OI DETENTORI DEL COPYRIGHT SARANNO 
 * RITENUTI RESPONSABILI PER QUALSIASI RECLAMO, DANNO O ALTRO RESPONSABILITÀ,
 * SE IN UN AZIONE DI CONTRATTO, TORT O ALTRO, DERIVANTE DA, FUORI O IN 
 * CONNESSIONE CON IL SOFTWARE OPPURE L'USO O ALTRE RACCOLTE DEL SOFTWARE.
 *
 *****************************************************************************/

 //-----------------------------------------------------------------------------
// Microsoft make Restrictions of Export for following Countries:
// ============================================================================
// This software is subject to the U.S. Export Administration Regulations and 
// other U.S.law, and may not be exported or re-exported to certain countries
// (Cuba, Iran, North Korea, Sudan, Syria, and the Crimea region of Ukraine) 
// or
// to persons or entities prohibited from receiving U.S.exports
// (including Denied Parties, Specially Designated Nationals,
// and entities on the Bureau of Export Administration Entity List or
// involved with missile technology or nuclear, chemical or biological weapons)
//-----------------------------------------------------------------------------
// © 1982 - 2020 Microsoft Corporation.All rights reserved.
//-----------------------------------------------------------------------------

//-------------------------------------------------------------------------------
// <!-- Microsoft New Name Convention and Rule Guideline ----------------------->
// <!-- in Visual Studio guilty, First Letter must be upper by Method ---------->
// <!-- = Method-declaration. -------------------------------------------------->
// <!-- make check by Code Analysis, is better for your Code inserts.
// <!-- Microsoft Portability, Globalization, Design automatic active! --------->
// <!-- Microsoft.Interoperability -------------------------------------------->
// <!-- Microsoft Portability 
// <!-------------------------------------------------------------------------->
//----------------------------------------------------------------------------->
// Most Important this Microsoft Rule !
//----------------------------------------------------------------------------->
// <!-- For native unmanaged Methods, must be written in three Classes: ------->
// <!--> class NativeMethods-------- Stackwalk execute 
// <!--> No [SuppressUnmanagedCodeSecurityAttribute]
// <!-------------------------------------------------------------------------->
// <!--> class SafeNativeMethods---- Stackwalk non execute
// <!--> with [SuppressUnmanagedCodeSecurityAttribute]
// <!--> without public Full Security Check with Attribute
// <!--> non dangerous and Risk for User Calls.
// <!----------------------------------------------------------------------------->
// <!--> class UnsafeNativeMethods-- Stackwalk non execute
// <!--> with [SuppressUnmanagedCodeSecurityAttribute]
// <!--> with Security-Risk, so public Full Security Check with Attribute.
// <!----------------------------------------------------------------------------->
// <!-- VGF-KernelTeam and Project-Founder Christian 'TIPPO' Kurs have a --------->
// <!-- Permission to use it. ---------------------------------------------------->
// <!----------------------------------------------------------------------------->
// <!-- Project "Visual Galaxy Framework" - Codename 'PARIS' ---------------------> 
// <!-- Copyright © 2020 by VGF-Kernelteam and ----------------------------------->
// <!-- Project-Founder: Christian 🧑 'TIPPO' 🧑 Kurs. -------------------------->
// <!-- For use this in our Project. --------------------------------------------->
// <!----------------------------------------------------------------------------->

/* 
 * .NET Framework Directives - System namespaces -
 * grayed directives not in use !
 * 
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security;
using System.Security.Principal;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

//
// SafeHandles long time internal, now public for use, so many mistakes by Developers
// forgotten to close the Windows Handles or others, so the handles continue open, but no access!
// Windows Handles have returned values 0 and -1
// NOTE Special: 
// In Windows Operation System give an unicate boolean Windows Boolean 1 byte only!
// so use NOT bool in Visual C#, take byte as datatype by returned value.
// 32BIT System - 4 bytes and 64BIT System 8 bytes
// In Visual C# hardcoded true and false ! - 
// Tip: want return the bool name, so user True.ToString(); returns 'True' 'False' as string
// Methoddeclaration datatype string as return value not bool.

/*
 * Microsoft Directives - Microsoft namespaces
 * 
 */
using Microsoft.Win32;
using Microsoft.Win32.SafeHandles;

/*
 * Windows Directives - Windows namespaces
 * 
 */
// static Windows.System.RemoteSystems.RemoteSystem;







//----------------------------------------------------------------------------------------
// write here your Namespaces / Directives from Project-Solution
//
// or
//
// for show a other namespace and class from other source-file: <csharpfilename.cs>
// in the same Project-Solution:
// write class as static and methods, so you can directly use the method without instance!
//----------------------------------------------------------------------------------------

//
using static Visual.Operation.System.Internal.InternalUtilities.VOSInternalUtilities;

//
using static Visual.Operation.System.Native.NativeMethods;

using static Visual.Operation.System.Base.VOSInternalBase;

// namespace-bundles !




/*---------------------------------------------------------------------------
 * BEGIN_NAMESPACE::Visual.Operation.System.Native
 *---------------------------------------------------------------------------
 * To Windows 10 May Update 1903 - OS-Build 18362.116 - 21.05.2019 Official -
 *--------------------------------------------------------------------------- 
 * ATTENTION !
 * 
 *--------------------------------------------------------------------------- 
 */
namespace Visual.Operation.System.Native
{
    //---------------------------------------------------------------------
    // my own Account by Google G-Mail
    // so can open directly account, insert password and Start my Account.
    //
    // https://mail.google.com/mail/kurschristian
    //
    //---------------------------------------------------------------------
    
    /// <summary>
    /// 
    /// </summary>
    internal static class NativeMethods
    {
       
      
        #region Windows Operation System - native Dll's - Specials - short names with Lambda Operator ###

        /// <summary>
        /// Get Last Error from Windows Operation System
        /// If set in [DllImportAttribute] SetLastError = true.
        /// by unmanaged Method in dll.
        /// </summary>
        /// <!-- Author Tipplin -->
        /// set short name and lambda operator of class and methodname
        /// <!-- Author Tipplin -->
        internal static int WinLastError => Marshal.GetLastWin32Error();

        /// <summary>
        /// Code Value from occured Exception Type
        /// </summary>
        /// <!-- Author Tipplin -->
        /// set short name and lambda operator of class and methodname
        /// <!-- Author Tipplin -->

        internal static int ExceptionType => Marshal.GetExceptionCode();

        /// <summary>
        /// Last Error, returned HRESULT Value, with Marshal throwing Win32 Code.
        /// </summary>
        /// <!-- Author Tipplin -->
        /// set short name and lambda operator of class and methodname
        /// <!-- Author Tipplin -->

        internal static int Win32HRType => Marshal.GetHRForLastWin32Error();



        /// <summary>
        /// 
        /// </summary>
        internal static readonly Version ThreadErrorModeMinOsVersion = new Version(6, 1, 7600);

        /// <summary>
        /// 
        /// </summary>
        public const int CLSCTX_INPROC_SERVER = 0x1;

        /// <summary>
        /// see the new write for constants one line for all at end , 
        /// at end of constants with semicolon ;
        /// </summary>
        public const int S_FALSE = 0x00000001,
                            S_OK = 0x00000000,
                            // MessageBox results by button click
                            IDOK = 1,
                            IDCANCEL = 2,
                            IDABORT = 3,
                            IDRETRY = 4,
                            IDIGNORE = 5,
                            IDYES = 6,
                            IDNO = 7,
                            IDCLOSE = 8,
                            IDHELP = 9,
                            IDTRYAGAIN = 10,
                            IDCONTINUE = 11,

                            OLECMDERR_E_NOTSUPPORTED = unchecked((int)0x80040100),
                            OLECMDERR_E_UNKNOWNGROUP = unchecked((int)0x80040104),

                            UNDO_E_CLIENTABORT = unchecked((int)0x80044001),
                            E_OUTOFMEMORY = unchecked((int)0x8007000E),
                            E_INVALIDARG = unchecked((int)0x80070057),
                            E_FAIL = unchecked((int)0x80004005),
                            E_NOINTERFACE = unchecked((int)0x80004002),
                            E_POINTER = unchecked((int)0x80004003),
                            E_NOTIMPL = unchecked((int)0x80004001),
                            E_UNEXPECTED = unchecked((int)0x8000FFFF),
                            E_HANDLE = unchecked((int)0x80070006),
                            E_ABORT = unchecked((int)0x80004004),
                            E_ACCESSDENIED = unchecked((int)0x80070005),
                            E_PENDING = unchecked((int)0x8000000A); // semicolon at end

        /// <summary>
        /// 
        /// </summary>
        public const int OLECLOSE_SAVEIFDIRTY = 0,
                         OLECLOSE_NOSAVE = 1,
                         OLECLOSE_PROMPTSAVE = 2;

        /// <summary>
        /// 
        /// </summary>
        public const int OLEIVERB_PRIMARY = 0,
                         OLEIVERB_SHOW = -1,
                         OLEIVERB_OPEN = -2,
                         OLEIVERB_HIDE = -3,
                         OLEIVERB_UIACTIVATE = -4,
                         OLEIVERB_INPLACEACTIVATE = -5,
                         OLEIVERB_DISCARDUNDOSTATE = -6,
                         OLEIVERB_PROPERTIES = -7;
         
        /// <summary>
        /// 
        /// </summary>
        public const int OFN_READONLY = unchecked((int)0x00000001),
                        OFN_OVERWRITEPROMPT = unchecked((int)0x00000002),
                        OFN_HIDEREADONLY = unchecked((int)0x00000004),
                        OFN_NOCHANGEDIR = unchecked((int)0x00000008),
                        OFN_SHOWHELP = unchecked((int)0x00000010),
                        OFN_ENABLEHOOK = unchecked((int)0x00000020),
                        OFN_ENABLETEMPLATE = unchecked((int)0x00000040),
                        OFN_ENABLETEMPLATEHANDLE = unchecked((int)0x00000080),
                        OFN_NOVALIDATE = unchecked((int)0x00000100),
                        OFN_ALLOWMULTISELECT = unchecked((int)0x00000200),
                        OFN_EXTENSIONDIFFERENT = unchecked((int)0x00000400),
                        OFN_PATHMUSTEXIST = unchecked((int)0x00000800),
                        OFN_FILEMUSTEXIST = unchecked((int)0x00001000),
                        OFN_CREATEPROMPT = unchecked((int)0x00002000),
                        OFN_SHAREAWARE = unchecked((int)0x00004000),
                        OFN_NOREADONLYRETURN = unchecked((int)0x00008000),
                        OFN_NOTESTFILECREATE = unchecked((int)0x00010000),
                        OFN_NONETWORKBUTTON = unchecked((int)0x00020000),
                        OFN_NOLONGNAMES = unchecked((int)0x00040000),
                        OFN_EXPLORER = unchecked((int)0x00080000),
                        OFN_NODEREFERENCELINKS = unchecked((int)0x00100000),
                        OFN_LONGNAMES = unchecked((int)0x00200000),
                        OFN_ENABLEINCLUDENOTIFY = unchecked((int)0x00400000),
                        OFN_ENABLESIZING = unchecked((int)0x00800000),
                        OFN_USESHELLITEM = unchecked((int)0x01000000),
                        OFN_DONTADDTORECENT = unchecked((int)0x02000000),
                        OFN_FORCESHOWHIDDEN = unchecked((int)0x10000000);

        // for READONLYSTATUS

        /// <summary>
        /// 
        /// </summary>
        public const int ROSTATUS_NotReadOnly = 0x0,
                        ROSTATUS_ReadOnly = 0x1,
                        ROSTATUS_Unknown = unchecked((int)0xFFFFFFFF);

        /// <summary>
        /// 
        /// </summary>
        public const int IEI_DoNotLoadDocData = 0x10000000;

        public const int CB_SETDROPPEDWIDTH = 0x0160,

                        GWL_STYLE = (-16),
                        GWL_EXSTYLE = (-20),

                        DWL_MSGRESULT = 0,

                        SW_SHOWNORMAL = 1,

                        HTMENU = 5,

                        WS_POPUP = unchecked((int)0x80000000),
                        WS_CHILD = 0x40000000,
                        WS_MINIMIZE = 0x20000000,
                        WS_VISIBLE = 0x10000000,
                        WS_DISABLED = 0x08000000,
                        WS_CLIPSIBLINGS = 0x04000000,
                        WS_CLIPCHILDREN = 0x02000000,
                        WS_MAXIMIZE = 0x01000000,
                        WS_CAPTION = 0x00C00000,
                        WS_BORDER = 0x00800000,
                        WS_DLGFRAME = 0x00400000,
                        WS_VSCROLL = 0x00200000,
                        WS_HSCROLL = 0x00100000,
                        WS_SYSMENU = 0x00080000,
                        WS_THICKFRAME = 0x00040000,
                        WS_TABSTOP = 0x00010000,
                        WS_MINIMIZEBOX = 0x00020000,
                        WS_MAXIMIZEBOX = 0x00010000,
                        WS_EX_DLGMODALFRAME = 0x00000001,
                        WS_EX_MDICHILD = 0x00000040,
                        WS_EX_TOOLWINDOW = 0x00000080,
                        WS_EX_CLIENTEDGE = 0x00000200,
                        WS_EX_CONTEXTHELP = 0x00000400,
                        WS_EX_RIGHT = 0x00001000,
                        WS_EX_LEFT = 0x00000000,
                        WS_EX_RTLREADING = 0x00002000,
                        WS_EX_LEFTSCROLLBAR = 0x00004000,
                        WS_EX_CONTROLPARENT = 0x00010000,
                        WS_EX_STATICEDGE = 0x00020000,
                        WS_EX_APPWINDOW = 0x00040000,
                        WS_EX_LAYERED = 0x00080000,
                        WS_EX_TOPMOST = 0x00000008,
                        WS_EX_NOPARENTNOTIFY = 0x00000004,

                        LVM_SETEXTENDEDLISTVIEWSTYLE = (0x1000 + 54),

                        LVS_EX_LABELTIP = 0x00004000,

                        // winuser.h
                        WH_JOURNALPLAYBACK = 1,
                        WH_GETMESSAGE = 3,
                        WH_MOUSE = 7,
                        WSF_VISIBLE = 0x0001,
                        WM_NULL = 0x0000,
                        WM_CREATE = 0x0001,
                        WM_DELETEITEM = 0x002D,
                        WM_DESTROY = 0x0002,
                        WM_MOVE = 0x0003,
                        WM_SIZE = 0x0005,
                        WM_ACTIVATE = 0x0006,
                        WA_INACTIVE = 0,
                        WA_ACTIVE = 1,
                        WA_CLICKACTIVE = 2,
                        WM_SETFOCUS = 0x0007,
                        WM_KILLFOCUS = 0x0008,
                        WM_ENABLE = 0x000A,
                        WM_SETREDRAW = 0x000B,
                        WM_SETTEXT = 0x000C,
                        WM_GETTEXT = 0x000D,
                        WM_GETTEXTLENGTH = 0x000E,
                        WM_PAINT = 0x000F,
                        WM_CLOSE = 0x0010,
                        WM_QUERYENDSESSION = 0x0011,
                        WM_QUIT = 0x0012,
                        WM_QUERYOPEN = 0x0013,
                        WM_ERASEBKGND = 0x0014,
                        WM_SYSCOLORCHANGE = 0x0015,
                        WM_ENDSESSION = 0x0016,
                        WM_SHOWWINDOW = 0x0018,
                        WM_WININICHANGE = 0x001A,
                        WM_SETTINGCHANGE = 0x001A,
                        WM_DEVMODECHANGE = 0x001B,
                        WM_ACTIVATEAPP = 0x001C,
                        WM_FONTCHANGE = 0x001D,
                        WM_TIMECHANGE = 0x001E,
                        WM_CANCELMODE = 0x001F,
                        WM_SETCURSOR = 0x0020,
                        WM_MOUSEACTIVATE = 0x0021,
                        WM_CHILDACTIVATE = 0x0022,
                        WM_QUEUESYNC = 0x0023,
                        WM_GETMINMAXINFO = 0x0024,
                        WM_PAINTICON = 0x0026,
                        WM_ICONERASEBKGND = 0x0027,
                        WM_NEXTDLGCTL = 0x0028,
                        WM_SPOOLERSTATUS = 0x002A,
                        WM_DRAWITEM = 0x002B,
                        WM_MEASUREITEM = 0x002C,
                        WM_VKEYTOITEM = 0x002E,
                        WM_CHARTOITEM = 0x002F,
                        WM_SETFONT = 0x0030,
                        WM_GETFONT = 0x0031,
                        WM_SETHOTKEY = 0x0032,
                        WM_GETHOTKEY = 0x0033,
                        WM_QUERYDRAGICON = 0x0037,
                        WM_COMPAREITEM = 0x0039,
                        WM_GETOBJECT = 0x003D,
                        WM_COMPACTING = 0x0041,
                        WM_COMMNOTIFY = 0x0044,
                        WM_WINDOWPOSCHANGING = 0x0046,
                        WM_WINDOWPOSCHANGED = 0x0047,
                        WM_POWER = 0x0048,
                        WM_COPYDATA = 0x004A,
                        WM_CANCELJOURNAL = 0x004B,
                        WM_NOTIFY = 0x004E,
                        WM_INPUTLANGCHANGEREQUEST = 0x0050,
                        WM_INPUTLANGCHANGE = 0x0051,
                        WM_TCARD = 0x0052,
                        WM_HELP = 0x0053,
                        WM_USERCHANGED = 0x0054,
                        WM_NOTIFYFORMAT = 0x0055,
                        WM_CONTEXTMENU = 0x007B,
                        WM_STYLECHANGING = 0x007C,
                        WM_STYLECHANGED = 0x007D,
                        WM_DISPLAYCHANGE = 0x007E,
                        WM_GETICON = 0x007F,
                        WM_SETICON = 0x0080,
                        WM_NCCREATE = 0x0081,
                        WM_NCDESTROY = 0x0082,
                        WM_NCCALCSIZE = 0x0083,
                        WM_NCHITTEST = 0x0084,
                        WM_NCPAINT = 0x0085,
                        WM_NCACTIVATE = 0x0086,
                        WM_GETDLGCODE = 0x0087,
                        WM_NCMOUSEMOVE = 0x00A0,
                        WM_NCLBUTTONDOWN = 0x00A1,
                        WM_NCLBUTTONUP = 0x00A2,
                        WM_NCLBUTTONDBLCLK = 0x00A3,
                        WM_NCRBUTTONDOWN = 0x00A4,
                        WM_NCRBUTTONUP = 0x00A5,
                        WM_NCRBUTTONDBLCLK = 0x00A6,
                        WM_NCMBUTTONDOWN = 0x00A7,
                        WM_NCMBUTTONUP = 0x00A8,
                        WM_NCMBUTTONDBLCLK = 0x00A9,
                        WM_NCXBUTTONDOWN = 0x00AB,
                        WM_NCXBUTTONUP = 0x00AC,
                        WM_NCXBUTTONDBLCLK = 0x00AD,
                        WM_KEYFIRST = 0x0100,
                        WM_KEYDOWN = 0x0100,
                        WM_KEYUP = 0x0101,
                        WM_CHAR = 0x0102,
                        WM_DEADCHAR = 0x0103,
                        WM_CTLCOLOR = 0x0019,
                        WM_SYSKEYDOWN = 0x0104,
                        WM_SYSKEYUP = 0x0105,
                        WM_SYSCHAR = 0x0106,
                        WM_SYSDEADCHAR = 0x0107,
                        WM_KEYLAST = 0x0108,
                        WM_IME_STARTCOMPOSITION = 0x010D,
                        WM_IME_ENDCOMPOSITION = 0x010E,
                        WM_IME_COMPOSITION = 0x010F,
                        WM_IME_KEYLAST = 0x010F,
                        WM_INITDIALOG = 0x0110,
                        WM_COMMAND = 0x0111,
                        WM_SYSCOMMAND = 0x0112,
                        WM_TIMER = 0x0113,
                        WM_HSCROLL = 0x0114,
                        WM_VSCROLL = 0x0115,
                        WM_INITMENU = 0x0116,
                        WM_INITMENUPOPUP = 0x0117,
                        WM_MENUSELECT = 0x011F,
                        WM_MENUCHAR = 0x0120,
                        WM_ENTERIDLE = 0x0121,
                        WM_CHANGEUISTATE = 0x0127,
                        WM_UPDATEUISTATE = 0x0128,
                        WM_QUERYUISTATE = 0x0129,
                        WM_CTLCOLORMSGBOX = 0x0132,
                        WM_CTLCOLOREDIT = 0x0133,
                        WM_CTLCOLORLISTBOX = 0x0134,
                        WM_CTLCOLORBTN = 0x0135,
                        WM_CTLCOLORDLG = 0x0136,
                        WM_CTLCOLORSCROLLBAR = 0x0137,
                        WM_CTLCOLORSTATIC = 0x0138,
                        WM_MOUSEFIRST = 0x0200,
                        WM_MOUSEMOVE = 0x0200,
                        WM_LBUTTONDOWN = 0x0201,
                        WM_LBUTTONUP = 0x0202,
                        WM_LBUTTONDBLCLK = 0x0203,
                        WM_RBUTTONDOWN = 0x0204,
                        WM_RBUTTONUP = 0x0205,
                        WM_RBUTTONDBLCLK = 0x0206,
                        WM_MBUTTONDOWN = 0x0207,
                        WM_MBUTTONUP = 0x0208,
                        WM_MBUTTONDBLCLK = 0x0209,
                        WM_XBUTTONDOWN = 0x020B,
                        WM_XBUTTONUP = 0x020C,
                        WM_XBUTTONDBLCLK = 0x020D,
                        WM_MOUSEWHEEL = 0x020A,
                        WM_MOUSELAST = 0x020A,
                        WM_PARENTNOTIFY = 0x0210,
                        WM_ENTERMENULOOP = 0x0211,
                        WM_EXITMENULOOP = 0x0212,
                        WM_NEXTMENU = 0x0213,
                        WM_SIZING = 0x0214,
                        WM_CAPTURECHANGED = 0x0215,
                        WM_MOVING = 0x0216,
                        WM_POWERBROADCAST = 0x0218,
                        WM_DEVICECHANGE = 0x0219,
                        WM_IME_SETCONTEXT = 0x0281,
                        WM_IME_NOTIFY = 0x0282,
                        WM_IME_CONTROL = 0x0283,
                        WM_IME_COMPOSITIONFULL = 0x0284,
                        WM_IME_SELECT = 0x0285,
                        WM_IME_CHAR = 0x0286,
                        WM_IME_KEYDOWN = 0x0290,
                        WM_IME_KEYUP = 0x0291,
                        WM_MDICREATE = 0x0220,
                        WM_MDIDESTROY = 0x0221,
                        WM_MDIACTIVATE = 0x0222,
                        WM_MDIRESTORE = 0x0223,
                        WM_MDINEXT = 0x0224,
                        WM_MDIMAXIMIZE = 0x0225,
                        WM_MDITILE = 0x0226,
                        WM_MDICASCADE = 0x0227,
                        WM_MDIICONARRANGE = 0x0228,
                        WM_MDIGETACTIVE = 0x0229,
                        WM_MDISETMENU = 0x0230,
                        WM_ENTERSIZEMOVE = 0x0231,
                        WM_EXITSIZEMOVE = 0x0232,
                        WM_DROPFILES = 0x0233,
                        WM_MDIREFRESHMENU = 0x0234,
                        WM_MOUSEHOVER = 0x02A1,
                        WM_MOUSELEAVE = 0x02A3,
                        WM_CUT = 0x0300,
                        WM_COPY = 0x0301,
                        WM_PASTE = 0x0302,
                        WM_CLEAR = 0x0303,
                        WM_UNDO = 0x0304,
                        WM_RENDERFORMAT = 0x0305,
                        WM_RENDERALLFORMATS = 0x0306,
                        WM_DESTROYCLIPBOARD = 0x0307,
                        WM_DRAWCLIPBOARD = 0x0308,
                        WM_PAINTCLIPBOARD = 0x0309,
                        WM_VSCROLLCLIPBOARD = 0x030A,
                        WM_SIZECLIPBOARD = 0x030B,
                        WM_ASKCBFORMATNAME = 0x030C,
                        WM_CHANGECBCHAIN = 0x030D,
                        WM_HSCROLLCLIPBOARD = 0x030E,
                        WM_QUERYNEWPALETTE = 0x030F,
                        WM_PALETTEISCHANGING = 0x0310,
                        WM_PALETTECHANGED = 0x0311,
                        WM_HOTKEY = 0x0312,
                        WM_PRINT = 0x0317,
                        WM_PRINTCLIENT = 0x0318,
                        WM_HANDHELDFIRST = 0x0358,
                        WM_HANDHELDLAST = 0x035F,
                        WM_AFXFIRST = 0x0360,
                        WM_AFXLAST = 0x037F,
                        WM_PENWINFIRST = 0x0380,
                        WM_PENWINLAST = 0x038F,
                        WM_APP = unchecked((int)0x8000),
                        WM_USER = 0x0400,
                        WM_REFLECT =
                        WM_USER + 0x1C00,
                        WS_OVERLAPPED = 0x00000000,
                        WPF_SETMINPOSITION = 0x0001,
                        WM_CHOOSEFONT_GETLOGFONT = (0x0400 + 1),

                        WHEEL_DELTA = 120,
                        DWLP_MSGRESULT = 0,
                        PSNRET_NOERROR = 0,
                        PSNRET_INVALID = 1,
                        // at great constant block don't forget ; semicolon !
                        PSNRET_INVALID_NOCHANGEPAGE = 2;

        public const int
                        PSN_APPLY = ((0 - 200) - 2),
                        PSN_KILLACTIVE = ((0 - 200) - 1),
                        PSN_RESET = ((0 - 200) - 3),
                        PSN_SETACTIVE = ((0 - 200) - 0);

        public const int
                        GMEM_MOVEABLE = 0x0002,
                        GMEM_ZEROINIT = 0x0040,
                        GMEM_DDESHARE = 0x2000;

        public const int
                        SWP_NOACTIVATE = 0x0010,
                        SWP_NOZORDER = 0x0004,
                        SWP_NOSIZE = 0x0001,
                        SWP_NOMOVE = 0x0002,
                        SWP_FRAMECHANGED = 0x0020;

        public const ushort CF_HDROP = 15; // winuser.h
        public const uint MK_CONTROL = 0x0008; //winuser.h
        public const uint MK_SHIFT = 0x0004;


        //-----------------------------------------------------------------------------

        public static readonly IntPtr NULL_POINTER = IntPtr.Zero;

        public static readonly IntPtr INVALID_HANDLE_VALUE = new IntPtr(-1);

        public const uint NORMAL_PRIORITY_CLASS = 0x0020u,
                            CREATE_NO_WINDOW = 0x08000000u;

        public const int STARTF_USESTDHANDLES = 0x00000100;




        public const int ERROR_SUCCESS = 0,
                         ERROR_FAILURE = 1;

        public const int KEY_QUERY_VALUE = 1,
                         KEY_SET_VALUE = 2,
                         KEY_CREATE_SUB_KEY = 4,
                         KEY_ENUMERATE_SUB_KEYS = 8,
                         KEY_NOTIFY = 16,
                         KEY_CREATE_LINK = 32,
                         KEY_READ = 131097,
                         KEY_WRITE = 131078,
                         KEY_WOW64_64KEY = 256,
                         KEY_WOW64_32KEY = 512;


        public const int REG_OPTION_NON_VOLATILE = 0,
                        REG_OPTION_VOLATILE = 1,
                        REG_OPTION_CREATE_LINK = 2,
                        REG_OPTION_BACKUP_RESTORE = 4,
                        REG_NONE = 0,
                        REG_SZ = 1,
                        REG_EXPAND_SZ = 2,
                        REG_BINARY = 3,
                        REG_DWORD = 4,
                        REG_DWORD_LITTLE_ENDIAN = 4,
                        REG_DWORD_BIG_ENDIAN = 5,
                        REG_LINK = 6,
                        REG_MULTI_SZ = 7,
                        REG_RESOURCE_LIST = 8,
                        REG_FULL_RESOURCE_DESCRIPTOR = 9,
                        REG_RESOURCE_REQUIREMENTS_LIST = 10,
                        REG_QWORD = 11;


        public const int HWND_BROADCAST = 65535;




        public const uint CRYPTPROTECTMEMORY_BLOCK_SIZE = 16u,
                          CRYPTPROTECTMEMORY_SAME_PROCESS = 0u,
                          CRYPTPROTECTMEMORY_CROSS_PROCESS = 1u,
                          CRYPTPROTECTMEMORY_SAME_LOGON = 2u;


        public const uint ANONYMOUS_LOGON_LUID = 998u;

        public const int SECURITY_ANONYMOUS = 0,
                         SECURITY_SQOS_PRESENT = 1048576,
                         SECURITY_ANONYMOUS_LOGON_RID = 7,
                         SECURITY_AUTHENTICATED_USER_RID = 11,
                         SECURITY_LOCAL_SYSTEM_RID = 18,
                         SECURITY_BUILTIN_DOMAIN_RID = 32;





        
       
        public const uint SE_PRIVILEGE_DISABLED = 0u,
                          SE_PRIVILEGE_ENABLED_BY_DEFAULT = 1u,
                          SE_PRIVILEGE_ENABLED = 2u,
                          SE_PRIVILEGE_USED_FOR_ACCESS = 2147483648u,
                          SE_GROUP_MANDATORY = 1u,
                          SE_GROUP_ENABLED_BY_DEFAULT = 2u,
                          SE_GROUP_ENABLED = 4u,
                          SE_GROUP_OWNER = 8u,
                          SE_GROUP_USE_FOR_DENY_ONLY = 16u,
                          SE_GROUP_LOGON_ID = 3221225472u,
                          SE_GROUP_RESOURCE = 536870912u;


        public const uint DUPLICATE_CLOSE_SOURCE = 1u,
                          DUPLICATE_SAME_ACCESS = 2u,
                          DUPLICATE_SAME_ATTRIBUTES = 4u;


        public const int TIME_ZONE_ID_INVALID = -1,
                         TIME_ZONE_ID_UNKNOWN = 0,
                         TIME_ZONE_ID_STANDARD = 1,
                         TIME_ZONE_ID_DAYLIGHT = 2;


        // ATTENTION ! by Drag and Drop !
        // 260 chars minus 1 is the Limit by Filename -1 for anti overflow
        // 248 chars minus 1 is the Limit by Pathname
        //
        // From Windows Explorer drag and drop into Visual Studio Project-Solution !
        // All your Documents for the Project, click on Document and be open by Word, Excel.
        //
        // If over limit !, Visual Studio show Message!, and shorts the Filename! 8.3
        // Same by Control textbox for overflow the limit set limit 260 minus -1:
        // text1.lenght -1, so come no exception!, or catch them !

        /// <summary>
        /// Filename Limit Drag and Drop
        ///-------------------------------------------------
        /// the suffix is now open of limit (255 chars)
        /// filename.txt:
        /// prefix.suffix
        /// tell windows with what app you open the file
        /// use systemtool assoc.exe - .yoursuffix = txt;
        /// so Windows open the file with Editor
        /// if NOT: Windows open Window with Message:
        /// Open File with ?
        ///--------------------------------------------------
        /// standard is 260, but use 260 -1, so no overflow ! 
        ///
        /// </summary>
        public const int MAX_FILE_NAME = 260;

        /// <summary>
        /// Pathname Limit Drag and Drop
        /// </summary>
        public const int MAX_PATH_NAME = 248;

        /// <summary>
        /// General Path Limit
        /// </summary>
        public const int MAX_PATH = 260;


        /// <summary>
        /// MUI
        /// </summary>
        public const int MUI_LANGUAGE_ID = 4,
                         MUI_LANGUAGE_NAME = 8,
                         MUI_PREFERRED_UI_LANGUAGES = 16,
                         MUI_INSTALLED_LANGUAGES = 32,
                         MUI_ALL_LANGUAGES = 64,
                         MUI_LANG_NEUTRAL_PE_FILE = 256,
                         MUI_NON_LANG_NEUTRAL_FILE = 512;

        /// <summary>
        /// LOAD_LIBRARY
        /// </summary>
        public const int LOAD_LIBRARY_AS_DATAFILE = 2,

                         LOAD_STRING_MAX_LENGTH = 500,

                         READ_CONTROL = 131072,

                         SYNCHRONIZE = 1048576,

                         STANDARD_RIGHTS_READ = 131072,

                         STANDARD_RIGHTS_WRITE = 131072,

                         SEMAPHORE_MODIFY_STATE = 2,

                         EVENT_MODIFY_STATE = 2,

                         MUTEX_MODIFY_STATE = 1,

                         MUTEX_ALL_ACCESS = 2031617,

                         LMEM_FIXED = 0,

                         LMEM_ZEROINIT = 64,

                         LPTR = 64,

                         SEM_FAILCRITICALERRORS = 1,

                         FIND_STARTSWITH = 1048576,

                         FIND_ENDSWITH = 2097152,

                         FIND_FROMSTART = 4194304,

                         FIND_FROMEND = 8388608,

                         STD_INPUT_HANDLE = -10,

                         STD_OUTPUT_HANDLE = -11,

                         STD_ERROR_HANDLE = -12,

                         CTRL_C_EVENT = 0,

                         CTRL_BREAK_EVENT = 1,

                         CTRL_CLOSE_EVENT = 2,

                         CTRL_LOGOFF_EVENT = 5,

                         CTRL_SHUTDOWN_EVENT = 6;

        /// <summary>
        /// KEY_EVENT
        /// </summary>
        public const short KEY_EVENT = 1;

        /// <summary>
        /// FILE
        /// </summary>
        public const int FILE_TYPE_DISK = 1,
                         FILE_TYPE_CHAR = 2,
                         FILE_TYPE_PIPE = 3,
                         REPLACEFILE_WRITE_THROUGH = 1,
                         REPLACEFILE_IGNORE_MERGE_ERRORS = 2;


        /// <summary>
        /// FormatMessage Flags
        /// </summary>
        public const int FORMAT_MESSAGE_IGNORE_INSERTS = 512,
                         FORMAT_MESSAGE_FROM_SYSTEM = 4096,
                         FORMAT_MESSAGE_ARGUMENT_ARRAY = 8192;

        /// <summary>
        /// FILE_MAO_WRITE
        /// </summary>
        /// <remarks>
        /// unsigned value can have sign 2 and u - 2u
        /// </remarks>
        public const uint FILE_MAP_WRITE = 2u;

        /// <summary>
        /// by ulong set 1610612733ul
        /// </summary>
        public const long IO_REPARSE_TAG_MOUNT_POINT = -1610612733;


        // u for unsigned here UInt32 datatype
        // source from Microsoft Developer .NET FX
        /// <summary>
        /// 
        /// </summary>
        public const uint FILE_MAP_READ = 4u,
                         
                         FILE_ATTRIBUTE_READONLY = 1u,

                         FILE_ATTRIBUTE_DIRECTORY = 16u,

                         FILE_ATTRIBUTE_REPARSE_POINT = 1024u,

                         PAGE_READWRITE = 4u,

                         MEM_COMMIT = 4096u,

                         MEM_RESERVE = 8192u,

                         MEM_RELEASE = 32768u,

                         MEM_FREE = 65536u,

                         STATUS_SUCCESS = 0u,

                         STATUS_SOME_NOT_MAPPED = 263u,

                         STATUS_NO_MEMORY = 3221225495u,

                         STATUS_OBJECT_NAME_NOT_FOUND = 3221225524u,

                         STATUS_NONE_MAPPED = 3221225587u,

                         STATUS_INSUFFICIENT_RESOURCES = 3221225626u,

                         STATUS_ACCESS_DENIED = 3221225506u;


        /// <summary>
        /// FILE
        /// </summary>
        public const int INVALID_FILE_SIZE = -1;

        /// <summary>
        /// ACCOUNT
        /// </summary>
        public const int STATUS_ACCOUNT_RESTRICTION = -1073741714;

        /// <summary>
        /// LCID
        /// </summary>
        public const int LCID_SUPPORTED = 2;

        /// <summary>
        /// INPUT
        /// </summary>
        public const int ENABLE_PROCESSED_INPUT = 1,
                         ENABLE_LINE_INPUT = 2,
                         ENABLE_ECHO_INPUT = 4;

        /// <summary>
        /// SHGFP
        /// </summary>
        public const int SHGFP_TYPE_CURRENT = 0;

        /// <summary>
        /// UOI
        /// </summary>
        public const int UOI_FLAGS = 1;

        /// <summary>
        /// CSIDL
        /// </summary>
        public const int CSIDL_FLAG_CREATE = 32768,
                         CSIDL_FLAG_DONT_VERIFY = 16384,
                         CSIDL_ADMINTOOLS = 48,
                         CSIDL_CDBURN_AREA = 59,
                         CSIDL_COMMON_ADMINTOOLS = 47,
                         CSIDL_COMMON_DOCUMENTS = 46,
                         CSIDL_COMMON_MUSIC = 53,
                         CSIDL_COMMON_OEM_LINKS = 58,
                         CSIDL_COMMON_PICTURES = 54,
                         CSIDL_COMMON_STARTMENU = 22,
                         CSIDL_COMMON_PROGRAMS = 23,
                         CSIDL_COMMON_STARTUP = 24,
                         CSIDL_COMMON_DESKTOPDIRECTORY = 25,
                         CSIDL_COMMON_TEMPLATES = 45,
                         CSIDL_COMMON_VIDEO = 55,
                         CSIDL_FONTS = 20,
                         CSIDL_MYVIDEO = 14,
                         CSIDL_NETHOOD = 19,
                         CSIDL_PRINTHOOD = 27,
                         CSIDL_PROFILE = 40,
                         CSIDL_PROGRAM_FILES_COMMONX86 = 44,
                         CSIDL_PROGRAM_FILESX86 = 42,
                         CSIDL_RESOURCES = 56,
                         CSIDL_RESOURCES_LOCALIZED = 57,
                         CSIDL_SYSTEMX86 = 41,
                         CSIDL_WINDOWS = 36,
                         CSIDL_APPDATA = 26,
                         CSIDL_COMMON_APPDATA = 35,
                         CSIDL_LOCAL_APPDATA = 28,
                         CSIDL_COOKIES = 33,
                         CSIDL_FAVORITES = 6,
                         CSIDL_HISTORY = 34,
                         CSIDL_INTERNET_CACHE = 32,
                         CSIDL_PROGRAMS = 2,
                         CSIDL_RECENT = 8,
                         CSIDL_SENDTO = 9,
                         CSIDL_STARTMENU = 11,
                         CSIDL_STARTUP = 7,
                         CSIDL_SYSTEM = 37,
                         CSIDL_TEMPLATES = 21,
                         CSIDL_DESKTOPDIRECTORY = 16,
                         CSIDL_PERSONAL = 5,
                         CSIDL_PROGRAM_FILES = 38,
                         CSIDL_PROGRAM_FILES_COMMON = 43,
                         CSIDL_DESKTOP = 0,
                         CSIDL_DRIVES = 17,
                         CSIDL_MYMUSIC = 13,
                         CSIDL_MYPICTURES = 39;

        /// <summary>
        /// NAME
        /// </summary>
        public const int NameSamCompatible = 2;

        /// <summary>
        /// CLAIM
        /// </summary>
        public const int CLAIM_SECURITY_ATTRIBUTE_TYPE_INVALID = 0,
                         CLAIM_SECURITY_ATTRIBUTE_TYPE_INT64 = 1,
                         CLAIM_SECURITY_ATTRIBUTE_TYPE_UINT64 = 2,
                         CLAIM_SECURITY_ATTRIBUTE_TYPE_STRING = 3,
                         CLAIM_SECURITY_ATTRIBUTE_TYPE_FQBN = 4,
                         CLAIM_SECURITY_ATTRIBUTE_TYPE_SID = 5,
                         CLAIM_SECURITY_ATTRIBUTE_TYPE_BOOLEAN = 6,
                         CLAIM_SECURITY_ATTRIBUTE_TYPE_OCTET_STRING = 16,
                         CLAIM_SECURITY_ATTRIBUTE_NON_INHERITABLE = 1,
                         CLAIM_SECURITY_ATTRIBUTE_VALUE_CASE_SENSITIVE = 2,
                         CLAIM_SECURITY_ATTRIBUTE_USE_FOR_DENY_ONLY = 4,
                         CLAIM_SECURITY_ATTRIBUTE_DISABLED_BY_DEFAULT = 8,
                         CLAIM_SECURITY_ATTRIBUTE_DISABLED = 16,
                         CLAIM_SECURITY_ATTRIBUTE_MANDATORY = 32,
                         CLAIM_SECURITY_ATTRIBUTE_VALID_FLAGS = 63;



        /*
         * same as .NET Framework, but the constants as public.
         * Specifies the number of time units (100 nanoseconds) per millisecond.
         * 
         * .NET Framework expired at Year 9999 23:59:59
         * 
         * ATTENTION 2018 - Leap Second in USA, but in Europe later
         * old:
         * 10:59:59 -> 11:00:00
         * new:
         * 10:59:60 -> 11:00:00
         * 
         */

        /// <summary>
        /// UNITS
        /// </summary>
        public const long UNITS_PER_MILLISECOND = 10000,
                          // Specifies the number of time units (100 nanoseconds) units per second.
                          UNITS_PER_SECOND = UNITS_PER_MILLISECOND * 1000,
                          // Specifies the number of time units (100 nanoseconds) units per minute.
                          UNITS_PER_MINUTE = UNITS_PER_SECOND * 60,
                          // Specifies the number of time units (100 nanoseconds) per hour.
                          UNITS_PER_HOUR = UNITS_PER_MINUTE * 60,
                          // Specifies the number of time units (100 nanoseconds) per day.
                          UNITS_PER_DAY = UNITS_PER_HOUR * 24,
                          // Specifies the number of time units milliseconds per day.
                          MILLIS_PER_DAY = UNITS_PER_DAY * 10000;


        public const long MIN_YEAR = 100,
                          MAX_YEAR = 10000;

        public const long DAYS_TO_1601 = 548229, // 1511 change julian calendar to geogrian calendar, but the microsoft developer have Year 1601 better and sure.
                          DAYS_TO_1899 = 657434;

        public const long DAYS_TO_10000 = 3615900;

        public const long FILETIME_OFFSET = DAYS_TO_1601 * UNITS_PER_DAY;

        public const long DOUBLE_OFFSET = DAYS_TO_1899 * UNITS_PER_DAY;

        public const long MIN_UNITS = 0;

        public const long MIN_SYSTEM_UNITS = FILETIME_OFFSET;

        public const long MAX_UNITS = DAYS_TO_10000 * UNITS_PER_DAY - 1;

        public const double MIN_DOUBLE = -657434.0,
                            MAX_DOUBLE = 2958466;

        public const int NO_ERROR = 0,
                         ERROR_INSUFFICIENT_BUFFER = 122;

        //-------------------------------------------------------------------------------------------------
        // Gauss-Formular are OUT ! - going incorrect values!
        // Meeuws-Forumlar is better and sure, Meeuw Belgian Mathe.
        //-------------------------------------------------------------------------------------------------

        /*-------------------------------------------------------------------------------------------------
         * International System of Units from 20 May 2019 comes into force.
         * New SI Units.
         * ------------------------------------------------------------------------------------------------
         * 20 May 2019 ! NEW ! International System of Units -
         * ------------------------------------------------------------------------------------------------
         * Ade, base units - welcome, natural constants!
         * ------------------------------------------------------------------------------------------------
         * bang !
         * On November 16, 2018, the world decided
         * (more precisely, the International Conference on Dimensions and Weights) 
         * a fundamental change in the International System of Units(SI).
         * 
         * After a transitional period of 7 months, it will no longer be 7 basic units 
         * that form the basis of all measurement, but 7 natural constants.
         * The changes will come into force on 20 May 2019.
         * ------------------------------------------------------------------------------------------------
         * The Meter (symbol m) is the SI unit for the length.
         * ------------------------------------------------------------------------------------------------
         * The Candela (symbol cd) is the SI unit for the light intensity.
         * ------------------------------------------------------------------------------------------------
         * The Ampere
         * What will change for the Ampere from 20 May 2019, learn from 20 January 2019.
         * ------------------------------------------------------------------------------------------------
         * The Kelvin
         * What will change for the Kelvin from 20 May 2019, you will learn from 20 February 2019
         * ------------------------------------------------------------------------------------------------
         * The Second
         * What will change for the Second from May 20, 2019, you will learn from March 20, 2019.
         * ------------------------------------------------------------------------------------------------
         * The MOL
         * MOL What will change for the Mole from 20 May 2019, learn from 20 April 2019. 
         * The Mole (unit symbol: mol) is the SI base unit of the molar amount.
         * It is used to quantify chemical reactions.
         * ------------------------------------------------------------------------------------------------
         * The Kilogram
         * What will change for the Kilogram from 20 May 2019, learn from 20 May2019. new definition!
         * ------------------------------------------------------------------------------------------------
         * For Germany Physical Technical Federal Office in Braunschweig/Berlin more info.
         * ------------------------------------------------------------------------------------------------
         * PTB Clock with correctness Clock Time: https://uhr.ptb.de/
         * 
         * three network adress for correctness Network Time at Server. Syncronization
         * ------------------------------------------------------------------------------------------------
         * Seit dem 1.1.1958 ist so bis Mitte 2016 eine Zeitdifferenz von ca. 36 Sekunden aufgelaufen: 
         * Die Uhr mit der Bezeichnung TAI (Temps Atomique International) geht im Vergleich zu der Uhr 
         * mit der Bezeichnung UTC um 36 Sekunden vor. 
         * 
         * Mitteleuropäische Zeit ist dann UTC + 1 Stunde, Sommerzeit + 2 Stunden.
         * 
         * Der Internationale Erdrotationsdienst 
         * ------------------------------------------------------------------------------------------------
         * (International Earth Rotation and Reference Systems Service, IERS) 
         * (TIPPO: Source Microsoft USA: The earth Rotation goes lowly)
         * 
         * hatte mit Bulletin C 52 vom 6. Juli 2016 eine Schaltsekunde für 
         * das Ende des 31. Dezember 2016 angekündigt.
         * 
         */

        // ------------------------------------------------------------------------------------------------
        // German PTB Braunschweig and Berlin, syncronic Clock for PC, Server...
        // three Network Adresses over Network Protocol:
        // so everytime the right Clock and Time!
        // German PTB Atomic Clock change Caesium to Light/Laser (correctness Factor 17).
        // on Website, correct definition for one second.

        //-------------------------------------------------------------------------------------------------
        // All come to Bonn/Germany the UN-City - https://www.unbonn.org/de - Welcome!:
        //-------------------------------------------------------------------------------------------------
        // All 10000 Calculators of the World and Computer Museum Atherium - 
        // Owner Uni Bonn - Leader of Museum Prof. Prinz -
        // (Bonn Lennestr./Am Hofgarten was School of TIPPO - GHS Bonn)
        //
        // Zuse Z 25 (full active)
        // VEB Robotron
        // IBM's
        // Leibniz - calculator - full function - 
        // Hollerith
        //
        // Hand Calucator the first of the World - Texas Instruments
        // Cashes,
        // Mathematic Books and Documents ca. 3000.
        //
        //--------------------------------------------------------------------------------------------------
        // TIPPO TIP:
        // Windows 10 have a Calculator for Measures, Weights, Currency, Science, developer, Normal,
        // Kbyte, Mbyte, Gbyte, Tbyte - old definition wrong!, Kebibyte, Mebibyte, Gebibyte, tebibyte,
        // bi = binary: Tera Binary Bytes that's rights values!
        // Zebibytes (Zettabytes 2020) - Factor 17 - Big Data -
        // -------------------------------------------------------------------------------------------------
        // German Weatherservice have zwo - CRAY XC 30 Supercomputer -
        // for everyone Information's (German Law)
        // Insert the City for information, warning, crictical Weather (Storm, strong Rain...)
        // Weather Radar on Uni Bonn, Information: Infrared Pictures, Clouds on...,
        // Weather Web Cam's,
        // The Cray make marked Labels, green, yellow and red, actually 30 M. see Video's.
        //
        //--------------------------------------------------------------------------------------------------

        #endregion

        // same Windows System Enumerators
        #region ### Windows Operation System - Enumerators ###


        /// <summary>
        /// Enumerator System Restrictions
        /// </summary>
        /// <!-- Author Tippo -->
        /// System Restrictions can only set an Administrator on Windows Membership.
        /// ! ATTENTION ! at Runtime is directly active !.
        /// simplesample:
        /// NOUSB - Admin has forbidden User USB-Interface.
        /// NORUN - Admin has set Applications for User he can run, all others are blocked for execution.
        /// <!-- Author tippo -->
        /// <remarks>
        /// Shell restriction values, parameter for Systemfunction SHRestricted(enum RESTRICTIONS);
        /// ! NOTE ! 
        /// Windows Developer Info:
        /// 
        /// 
        /// </remarks>
        internal enum RESTRICTIONS
        {
            REST_NONE = 0x00000000,
            REST_NORUN = 0x00000001,
            REST_NOCLOSE = 0x00000002,
            REST_NOSAVESET = 0x00000004,
            REST_NOFILEMENU = 0x00000008,
            REST_NOSETFOLDERS = 0x00000010,
            REST_NOSETTASKBAR = 0x00000020,
            REST_NODESKTOP = 0x00000040,
            REST_NOFIND = 0x00000080,
            /// <summary>
            /// NODRIVES - Drive A to Drive Z
            /// Set Bit like for Drive F is Bit 5,
            /// so the Drive is no show in Explorer.
            /// </summary>
            REST_NODRIVES = 0x00000100,
            REST_NODRIVEAUTORUN = 0x00000200,
            REST_NODRIVETYPEAUTORUN = 0x00000400,
            REST_NONETHOOD = 0x00000800,
            REST_STARTBANNER = 0x00001000,
            REST_RESTRICTRUN = 0x00002000,
            REST_NOPRINTERTABS = 0x00004000,
            REST_NOPRINTERDELETE = 0x00008000,
            REST_NOPRINTERADD = 0x00010000,
            REST_NOSTARTMENUSUBFOLDERS = 0x00020000,
            REST_MYDOCSONNET = 0x00040000,
            REST_NOEXITTODOS = 0x00080000,
            REST_ENFORCESHELLEXTSECURITY = 0x00100000,
            REST_LINKRESOLVEIGNORELINKINFO = 0x00200000,
            REST_NOCOMMONGROUPS = 0x00400000,
            REST_SEPARATEDESKTOPPROCESS = 0x00800000,
            REST_NOWEB = 0x01000000,
            REST_NOTRAYCONTEXTMENU = 0x02000000,
            REST_NOVIEWCONTEXTMENU = 0x04000000,
            REST_NONETCONNECTDISCONNECT = 0x08000000,
            REST_STARTMENULOGOFF = 0x10000000,
            REST_NOSETTINGSASSIST = 0x20000000,
            REST_NOINTERNETICON = 0x40000001,
            REST_NORECENTDOCSHISTORY = 0x40000002,
            REST_NORECENTDOCSMENU = 0x40000003,
            REST_NOACTIVEDESKTOP = 0x40000004,
            REST_NOACTIVEDESKTOPCHANGES = 0x40000005,
            REST_NOFAVORITESMENU = 0x40000006,
            REST_CLEARRECENTDOCSONEXIT = 0x40000007,
            REST_CLASSICSHELL = 0x40000008,
            REST_NOCUSTOMIZEWEBVIEW = 0x40000009,
            REST_NOHTMLWALLPAPER = 0x40000010,
            REST_NOCHANGINGWALLPAPER = 0x40000011,
            REST_NODESKCOMP = 0x40000012,
            REST_NOADDDESKCOMP = 0x40000013,
            REST_NODELDESKCOMP = 0x40000014,
            REST_NOCLOSEDESKCOMP = 0x40000015,
            REST_NOCLOSE_DRAGDROPBAND = 0x40000016,   // Disable Close and Drag & Drop on ALL Bands
            REST_NOMOVINGBAND = 0x40000017,   // Disable Moving ALL Bands
            REST_NOEDITDESKCOMP = 0x40000018,
            REST_NORESOLVESEARCH = 0x40000019,
            REST_NORESOLVETRACK = 0x4000001A,
            REST_FORCECOPYACLWITHFILE = 0x4000001B,
            REST_NOLOGO3CHANNELNOTIFY       = 0x4000001C,
            REST_NOFORGETSOFTWAREUPDATE = 0x4000001D,
            REST_NOSETACTIVEDESKTOP = 0x4000001E,   // No Active desktop on Settings Menu
            REST_NOUPDATEWINDOWS = 0x4000001F,   // No Windows Update on Settings Menu
            REST_NOCHANGESTARMENU = 0x40000020,   // No Context menu or Drag and Drop on Start menu
            REST_NOFOLDEROPTIONS = 0x40000021,   // No Folder Options on Settings Menu
            REST_HASFINDCOMPUTERS = 0x40000022,   // Show Start/Search/Computers
            REST_INTELLIMENUS = 0x40000023,
            REST_RUNDLGMEMCHECKBOX = 0x40000024,
            REST_ARP_ShowPostSetup = 0x40000025,   // ARP: Show Post-Setup page
            REST_NOCSC = 0x40000026,   // Disable the ClientSide caching on SM
            REST_NOCONTROLPANEL = 0x40000027,   // Remove the Control Panel only from SM|Settings
            REST_ENUMWORKGROUP = 0x40000028,   // Enumerate workgroup in root of nethood
            REST_ARP_NOARP = 0x40000029,   // ARP: Don't Allow ARP to come up at all
            REST_ARP_NOREMOVEPAGE = 0x4000002A,   // ARP: Don't allow Remove page
            REST_ARP_NOADDPAGE = 0x4000002B,   // ARP: Don't allow Add page
            REST_ARP_NOWINSETUPPAGE = 0x4000002C,   // ARP: Don't allow opt components page
            REST_GREYMSIADS = 0x4000002D,    // SM: Allow the greying of Darwin Ads in SM
            REST_NOCHANGEMAPPEDDRIVELABEL = 0x4000002E,   // Don't enable the UI which allows users to rename mapped drive labels
            REST_NOCHANGEMAPPEDDRIVECOMMENT = 0x4000002F,   // Don't enable the UI which allows users to change mapped drive comments
            REST_MaxRecentDocs = 0x40000030,
            REST_NONETWORKCONNECTIONS = 0x40000031,   // No Start Menu | Settings |Network Connections
            REST_FORCESTARTMENULOGOFF = 0x40000032,   // Force logoff on the Start Menu
            REST_NOWEBVIEW = 0x40000033,   // Disable Web View
            REST_NOCUSTOMIZETHISFOLDER = 0x40000034,   // Disable Customize This Folder
            REST_NOENCRYPTION = 0x40000035,   // Don't allow file encryption
                                              //  Do NOT use me                     0x40000036,
            REST_DONTSHOWSUPERHIDDEN = 0x40000037,   // don't show super hidden files
            REST_NOSHELLSEARCHBUTTON = 0x40000038,
            REST_NOHARDWARETAB = 0x40000039,   // No Hardware tab on Drives or in control panel
            REST_NORUNASINSTALLPROMPT = 0x4000003A,   // Don't bring up "Run As" prompt for install programs
            REST_PROMPTRUNASINSTALLNETPATH = 0x4000003B,   // Force the  "Run As" prompt for install programs on unc/network shares
            REST_NOMANAGEMYCOMPUTERVERB = 0x4000003C,   // No Manage verb on My Computer
                                                        //  Do NOT use me                     0x4000003D,
            REST_DISALLOWRUN = 0x4000003E,   // don't allow certain apps to be run
            REST_NOWELCOMESCREEN = 0x4000003F,   // don't allow the welcome screen to be displayed.
            REST_RESTRICTCPL = 0x40000040,   // only allow certain cpls to be run
            REST_DISALLOWCPL = 0x40000041,   // don't allow certain cpls to be run
            REST_NOSMBALLOONTIP = 0x40000042,   // No Start Menu Balloon Tip
            REST_NOSMHELP = 0x40000043,   // No Help on the Start Menu
            REST_NOWINKEYS = 0x40000044,   // No Windows-X Hot keys
            REST_NOENCRYPTONMOVE = 0x40000045,   // Don't automatically try to encrypt files that are moved to encryped directories
            REST_NOLOCALMACHINERUN = 0x40000046,   // ignore HKLM\sw\ms\win\cv\Run and all of it's sub keys
            REST_NOCURRENTUSERRUN = 0x40000047,   // ignore HKCU\sw\ms\win\cv\Run and all of it's sub keys
            REST_NOLOCALMACHINERUNONCE = 0x40000048,   // ignore HKLM\sw\ms\win\cv\RunOnce and all of it's sub keys
            REST_NOCURRENTUSERRUNONCE = 0x40000049,   // ignore HKCU\sw\ms\win\cv\RunOnce and all of it's sub keys
            REST_FORCEACTIVEDESKTOPON = 0x4000004A,   // Force ActiveDesktop to be turned ON all the time.
                                                      //  Do NOT use me                     0x4000004B,
            REST_NOVIEWONDRIVE = 0x4000004C,   // disallows CreateViewObject() on specified drives (CFSFolder only)
            REST_NONETCRAWL                 = 0x4000004D,   // disables the crawling of the WNet namespace.
            REST_NOSHAREDDOCUMENTS          = 0x4000004E,   // don't auto share the Shared Documents/create link
            REST_NOSMMYDOCS = 0x4000004F,   // Don't show the My Documents item on the Start Menu.
            REST_NOSMMYPICS                 = 0x40000050,   // Don't show the My Pictures item on the Start Menu
            REST_ALLOWBITBUCKDRIVES         = 0x40000051,   // Bit mask indicating which which drives have bit bucket support
            REST_NONLEGACYSHELLMODE         = 0x40000052,   // new consumer shell modes
            REST_NOCONTROLPANELBARRICADE    = 0x40000053,   // The webview barricade in Control Panel
            REST_NOSTARTPAGE                = 0x40000054,   // Whistler Start Page on desktop.
            REST_NOAUTOTRAYNOTIFY           = 0x40000055,   // Whistler auto-tray notify feature
            REST_NOTASKGROUPING             = 0x40000056,   // Whistler taskbar button grouping feature
            REST_NOCDBURNING                = 0x40000057,   // whistler cd burning feature
            REST_MYCOMPNOPROP               = 0x40000058,   // disables Properties on My Computer's context menu
            REST_MYDOCSNOPROP               = 0x40000059,   // disables Properties on My Documents' context menu
            REST_NOSTARTPANEL               = 0x4000005A,   // Windows start panel (New start menu) for Whistler.
            REST_NODISPLAYAPPEARANCEPAGE    = 0x4000005B,   // disable Themes and Appearance tabs in the Display Control Panel.
            REST_NOTHEMESTAB                = 0x4000005C,   // disable the Themes tab in the Display Control Panel.
            REST_NOVISUALSTYLECHOICE        = 0x4000005D,   // disable the visual style drop down in the Appearance tab of the Display Control Panel.
            REST_NOSIZECHOICE               = 0x4000005E,   // disable the size drop down in the Appearance tab of the Display Control Panel.
            REST_NOCOLORCHOICE              = 0x4000005F,   // disable the color drop down in the Appearance tab of the Display Control Panel.
            REST_SETVISUALSTYLE             = 0x40000060,   // Load the specified file as the visual style.
            REST_STARTRUNNOHOMEPATH         = 0x40000061,   // dont use the %HOMEPATH% env var for the Start-Run dialog
            REST_NOUSERNAMEINSTARTPANEL     = 0x40000062,   // don't show the username is the startpanel.
            REST_NOMYCOMPUTERICON           = 0x40000063,   // don't show my computer anywhere, hide its contents
            REST_NOSMNETWORKPLACES          = 0x40000064,   // don't show network places in startpanel.
            REST_NOSMPINNEDLIST             = 0x40000065,   // don't show the pinned list in startpanel.
            REST_NOSMMYMUSIC                = 0x40000066,   // don't show MyMusic folder in startpanel
            REST_NOSMEJECTPC                = 0x40000067,   // don't show "Undoc PC" command in startmenu
            REST_NOSMMOREPROGRAMS           = 0x40000068,   // don't show "More Programs" button in StartPanel.
            REST_NOSMMFUPROGRAMS            = 0x40000069,   // don't show the MFU programs list in StartPanel.
            REST_NOTRAYITEMSDISPLAY         = 0x4000006A,   // disables the display of the system tray
            REST_NOTOOLBARSONTASKBAR        = 0x4000006B,   // disables toolbar display on the taskbar
            REST_NOSMCONFIGUREPROGRAMS      = 0x4000006F,   // No Configure Programs on Settings Menu
            REST_HIDECLOCK                  = 0x40000070,   // don't show the clock
            REST_NOLOWDISKSPACECHECKS       = 0x40000071,   // disable the low disk space checking
            REST_NOENTIRENETWORK            = 0x40000072,   // removes the "Entire Network" link (i.e. from "My Network Places")
            REST_NODESKTOPCLEANUP           = 0x40000073,   // disable the desktop cleanup wizard
            REST_BITBUCKNUKEONDELETE        = 0x40000074,   // disables recycling of files
            REST_BITBUCKCONFIRMDELETE       = 0x40000075,   // always show the delete confirmation dialog when deleting files
            REST_BITBUCKNOPROP              = 0x40000076,   // disables Properties on Recycle Bin's context menu
            REST_NODISPBACKGROUND           = 0x40000077,   // disables the Desktop tab in the Display CPL
            REST_NODISPSCREENSAVEPG         = 0x40000078,   // disables the Screen Saver tab in the Display CPL
            REST_NODISPSETTINGSPG           = 0x40000079,   // disables the Settings tab in the Display CPL
            REST_NODISPSCREENSAVEPREVIEW    = 0x4000007A,   // disables the screen saver on the Screen Saver tab in the Display CPL
            REST_NODISPLAYCPL               = 0x4000007B,   // disables the Display CPL
            REST_HIDERUNASVERB              = 0x4000007C,   // hides the "Run As..." context menu item
            REST_NOTHUMBNAILCACHE           = 0x4000007D,   // disables use of the thumbnail cache
            REST_NOSTRCMPLOGICAL            = 0x4000007E,   // dont use StrCmpLogical() instead use default CompareString()
            REST_NOPUBLISHWIZARD            = 0x4000007F,   // disables publishing wizard (WPW)
            REST_NOONLINEPRINTSWIZARD       = 0x40000080,   // disables online prints wizard (OPW)
            REST_NOWEBSERVICES              = 0x40000081,   // disables the web specified services for both OPW and WPW
            REST_ALLOWUNHASHEDWEBVIEW       = 0x40000082,   // allow the user to be promted to accept web view templates that don't already have an md5 hash in the registry
            REST_ALLOWLEGACYWEBVIEW = 0x40000083,   // allow legacy webview template to be shown.
            REST_REVERTWEBVIEWSECURITY      = 0x40000084,   // disable added webview security measures (revert to w2k functionality).
            REST_INHERITCONSOLEHANDLES      = 0x40000086,   // ShellExec() will check for the current process and target process being console processes to inherit handles
            REST_SORTMAXITEMCOUNT           = 0x40000087,   // Do not sort views with more items than this key. Useful for viewing big amount of files in one folder.
            REST_NOREMOTERECURSIVEEVENTS    = 0x40000089,   // Dont register network change events recursively to avoid network traffic
            REST_NOREMOTECHANGENOTIFY       = 0x40000091,   // Do not notify for remote changy notifies
            REST_NOSIMPLENETIDLIST          = 0x40000092,   // No simple network IDLists
            REST_NOENUMENTIRENETWORK        = 0x40000093,   // Don't enumerate entire network if we happen to get to it (in conjunction with REST_NOENTIRENETWORK)
            REST_NODETAILSTHUMBNAILONNETWORK= 0x40000094,   // Disable Thumbnail for Network files in DUI Details pane
            REST_NOINTERNETOPENWITH         = 0x40000095,   // dont allow looking on the internet for file associations
            REST_DONTRETRYBADNETNAME        = 0x4000009B,   // In Network Places: if provider returns ERROR_BAD_NET_NAME, give up
            REST_ALLOWFILECLSIDJUNCTIONS    = 0x4000009C,   // re-enable legacy support for file.{guid} junctions in FileSystem Folder
            REST_NOUPNPINSTALL              = 0x4000009D,   // disable "install UPnP" task in My Net Places
            REST_ARP_DONTGROUPPATCHES = 0x400000AC,   //List individual patches in Add/Remove Programs
            REST_ARP_NOCHOOSEPROGRAMSPAGE = 0x400000AD,   //Choose programs page
            REST_NODISCONNECT = 0x41000001,   // No Disconnect option in Start menu
            REST_NOSECURITY = 0x41000002,   // No Security option in start menu
            REST_NOFILEASSOCIATE = 0x41000003,   // Do not allow user to change file association
            REST_ALLOWCOMMENTTOGGLE         = 0x41000004,   // Allow the user to toggle the positions of the Comment and the Computer Name
            REST_USEDESKTOPINICACHE         = 0x41000005,   // Cache desktop.ini entries from network folders
        }
        
        /// <summary>
        /// 
        /// </summary>
        internal enum SID_NAME_USE
        {
            SidTypeUser = 1,
            SidTypeGroup,
            SidTypeDomain,
            SidTypeAlias,
            SidTypeWellKnownGroup,
            SidTypeDeletedAccount,
            SidTypeInvalid,
            SidTypeUnknown,
            SidTypeComputer
        }


        internal enum SHERB_TRASH
        {
            // No dialog box confirming the deletion of the objects will be displayed.
            SHERB_NOCONFIRMATION = 0x00000001,
            // No dialog box indicating the progress will be displayed.
            SHERB_NOPROGRESSUI = 0x00000002,
            // No sound will be played when the operation is complete.
            SHERB_NOSOUND = 0x00000004
        }



        /// <summary>
        /// Shutdown Reasons for ExitWindowsEx
        /// </summary>
        /// <!-- Author Tipplin -->
        /// unsigned behind the value you can write with u
        /// ul and L for long
        /// <!-- Author Tipplin-->
        /// <remarks>
        /// Method inside:
        /// UnsafeNativeMethods.ExitWindowsEx(
        /// Visual.Operation.System.Native.NativeMethods.EWX_SHUTDOWN_FLAGS, Visual.Operation.System.Native.NativeMethods.SHTDN_REASON_CODES)>
        /// </remarks>
        internal enum SHTDN_REASON_CODES : uint
        {
            /*
             * ----------------------------------------------------------
             * New can write by value for unsigned values at end u 32BIT
             * 0x00000000u <-------------------------------------^
             * -------------------------------------------------- uint
             * ----------------------------------------------------------
             * New can write by value for usigned values  at end ul 64BIT
             * 0x00000000ul <----------------------------------------^
             * -------------------------------------------------- ulong
             * ----------------------------------------------------------
             * By turned on Microsoft Guidelines and Code Analysis,
             * check all datatypes, if 64BIT System the compiler gripe
             * at build run, incompatible datatypes, uint are 4 bytes
             * on 32 BIT on 64BIT 8 Bytes, please pass on!.
             * ----------------------------------------------------------
             * Windows Operation System:
             * native Functions for use.
             * ----------------------------------------------------------
             * Microsoft want for native Methods, three classes:
             * NativeMethods
             * SafeNativeMethods
             * UnSafeNativeMethods
             * one with SecurityAttribute [SuppressSecurityAttribute]
             * means a Security Check for Methods in this class,
             * 
             * zwo others without this Attribute, but make Stackwalk.
             * so this Methods are secure for User Call, without Risk.
             * 
             * ----------------------------------------------------------
            */


 
            /// <summary>
            /// Shutdown Reason Major as none
            /// </summary>
            SHTDN_REASON_MAJOR_NONE = 0x00000000u,
            
            /// <summary>
            /// Shutdown reason for Hardware
            /// </summary>
            SHTDN_REASON_MAJOR_HARDWARE = 0x00010000u,
            
            /// <summary>
            /// ! Microsoft ! Operation System
            /// </summary>
            SHTDN_REASON_MAJOR_OPERATINGSYSTEM = 0x00020000u,

            /// <summary>
            /// Shutdown Reason for Software as Major Flag, can us it for Fixes, upgrades...
            /// </summary>
            SHTDN_REASON_MAJOR_SOFTWARE = 0x00030000u,
            
            /// <summary>
            /// Shutdown Reason for Application as Major Flag, Bugfix, SecurityFix, Quickfix, Update planned...
            /// </summary>
            SHTDN_REASON_MAJOR_APPLICATION = 0x00040000u,

            /// <summary>
            ///  ! Microsoft ! 
            /// </summary>
            SHTDN_REASON_MAJOR_SYSTEM = 0x00050000u,

            /// <summary>
            ///  ! Microsoft ! 
            /// </summary>
            SHTDN_REASON_MAJOR_POWER = 0x00060000u,

            /// <summary>
            ///  ! Microsoft ! 
            /// </summary>
            SHTDN_REASON_MAJOR_LEGACY_API = 0x00070000u,


            // <summary>
            // Microsoft Minor Reasons for parameter Reason by function ExitWindowsEx();
            // reason everytime zwo flags Major and Minor: APPLICATION | UPGRADE
            // </summary>

            /// <summary>
            ///  ! Microsoft ! 
            /// </summary>
            SHTDN_REASON_MINOR_OTHER = 0x00000000u,

            /// <summary>
            ///  ! Microsoft ! 
            /// </summary>
            SHTDN_REASON_MINOR_NONE = 0x000000ffu,

            /// <summary>
            ///  ! Microsoft !
            /// </summary>
            SHTDN_REASON_MINOR_MAINTENANCE = 0x00000001u,

            // with Major SHTDN_REASON_MAJOR_APPLICATION

            /// <summary>
            /// ExitWindowsEx(EWX_REBOOT, SHTDN_REASON_MAJOR_APPLICATION | SHTDN_REASON_MINOR_INSTALLATION | SHTDN_REASON_FLAG_PLANNED);
            /// </summary>
            SHTDN_REASON_MINOR_INSTALLATION = 0x00000002u,

            // with Major SHTDN_REASON_MAJOR_APPLICATION

            /// <summary>
            /// Shutdown Reason Minor for Application Upgrade plus Flag SHTDN_REASON_FLAG_PLANNED
            /// ExitWindowsEx(EWX_REBOOT, SHTDN_REASON_MAJOR_APPLICATION | SHTDN_REASON_MINOR_UPGRADE | SHTDN_REASON_FLAG_PLANNED);
            /// Next shutdown Windows and can install Upgrade then the System reboot.
            /// </summary>
            SHTDN_REASON_MINOR_UPGRADE = 0x00000003u,

            /// <summary>
            /// 
            /// </summary>
            SHTDN_REASON_MINOR_RECONFIG = 0x00000004u,
            /// <summary>
            /// 
            /// </summary>
            SHTDN_REASON_MINOR_HUNG = 0x00000005u,
            /// <summary>
            /// 
            /// </summary>
            SHTDN_REASON_MINOR_UNSTABLE = 0x00000006u,
            /// <summary>
            /// 
            /// </summary>
            SHTDN_REASON_MINOR_DISK = 0x00000007u,
            /// <summary>
            /// 
            /// </summary>
            SHTDN_REASON_MINOR_PROCESSOR = 0x00000008u,
            /// <summary>
            /// 
            /// </summary>
            SHTDN_REASON_MINOR_NETWORKCARD = 0x00000009u,
            /// <summary>
            /// 
            /// </summary>
            SHTDN_REASON_MINOR_POWER_SUPPLY = 0x0000000au,
            /// <summary>
            /// 
            /// </summary>
            SHTDN_REASON_MINOR_CORDUNPLUGGED = 0x0000000bu,
            /// <summary>
            /// 
            /// </summary>
            SHTDN_REASON_MINOR_ENVIRONMENT = 0x0000000cu,
            /// <summary>
            /// 
            /// </summary>
            SHTDN_REASON_MINOR_HARDWARE_DRIVER = 0x0000000du,
            /// <summary>
            /// 
            /// </summary>
            SHTDN_REASON_MINOR_OTHERDRIVER = 0x0000000eu,
            /// <summary>
            /// 
            /// </summary>
            SHTDN_REASON_MINOR_BLUESCREEN = 0x0000000Fu,
            /// <summary>
            /// with Major SHTDN_REASON_MAJOR_APPLICATION
            /// </summary>
            SHTDN_REASON_MINOR_SERVICEPACK = 0x00000010u,
            /// <summary>
            ///  with Major SHTDN_REASON_MAJOR_APPLICATION
            /// </summary>
            SHTDN_REASON_MINOR_HOTFIX = 0x00000011u,
            /// <summary>
            /// with Major SHTDN_REASON_MAJOR_APPLICATION
            /// </summary>
            SHTDN_REASON_MINOR_SECURITYFIX = 0x00000012u,
            /// <summary>
            /// 
            /// </summary>
            SHTDN_REASON_MINOR_SECURITY = 0x00000013u,
            /// <summary>
            /// 
            /// </summary>
            SHTDN_REASON_MINOR_NETWORK_CONNECTIVITY = 0x00000014u,
            /// <summary>
            /// 
            /// </summary>
            SHTDN_REASON_MINOR_WMI = 0x00000015,
            /// <summary>
            /// 
            /// </summary>
            SHTDN_REASON_MINOR_SERVICEPACK_UNINSTALL = 0x00000016u,
            /// <summary>
            /// 
            /// </summary>
            SHTDN_REASON_MINOR_HOTFIX_UNINSTALL = 0x00000017u,
            /// <summary>
            /// 
            /// </summary>
            SHTDN_REASON_MINOR_SECURITYFIX_UNINSTALL = 0x00000018u,
            /// <summary>
            /// 
            /// </summary>
            SHTDN_REASON_MINOR_MMC = 0x00000019u,
            /// <summary>
            /// 
            /// </summary>
            SHTDN_REASON_MINOR_SYSTEMRESTORE = 0x0000001au,
            /// <summary>
            /// 
            /// </summary>
            SHTDN_REASON_MINOR_TERMSRV = 0x00000020u,
            /// <summary>
            /// 
            /// </summary>
            SHTDN_REASON_MINOR_DC_PROMOTION = 0x00000021u,
            /// <summary>
            /// 
            /// </summary>
            SHTDN_REASON_MINOR_DC_DEMOTION = 0x00000022u,
            /// <summary>
            /// 
            /// </summary>
            SHTDN_REASON_FLAG_USER_DEFINED = 0x40000000u,
            /// <summary>
            /// 
            /// </summary>
            SHTDN_REASON_FLAG_PLANNED = 0x80000000u
        }


        /*---------------------------------------------------------------------
         * Windows 10 Professional is Workstation ---- (!in a Network) - 64 BIT
         * Limit RAM 2 Terabyte, 2 Processors.
         * --------------------------------------------------------------------
         * Special Edition for Workgroups:
         * Windows 10 Professional for Workstations - 64 BIT -
         * Limit RAM 6 Terabyte, 4 Processors.
         * --------------------------------------------------------------------
         * (Windows 10 is Multi User System, one or more User on one Computer)
         * 
         * Windows 10 has an internal Database Codename Yukon - 'Resent', 
         * same as Microsoft SQL Server Embedded Edition.
         * 
         * --------------------------------------------------------------------
         * maximal 16 Terabyte storage:
         * (Microsoft SQL Server Enterprise Edition Limit 524 Terabyte ==
         * same is Microsoft SQL Server Developer Edition free download !
         * NO COMMERCIAL USE!)
         * 
         * Recent managed this in Windows:
         * all Windows Services,
         * same Network Libraries, OS-Build 17763 more and more.
         * stand: 
         * netapi32.dll
         * 
         * WinSTAT.dll = Winstation Library Connection Network / Server
         * Windows 10 Professional works as Client/Server System,
         * Function ServerLicensingOpenW proof CAL License!
         * 
         * LOGONCLI.dll = Net LogOn Client DLL
         * --------------------------------------------------------------------
         * Microsoft Tool:
         * RemoteServerAdministrationTool - free download -
         * Windows Server Dashboard
         * Connect to Servers or create Servergroup...
         * Windows Server Tools, Windows Server Products on Web
         *---------------------------------------------------------------------
         */


        /// <summary>
        /// Enumerator WOW64PROCESS_MACHINE
        /// </summary>
        /// <!-- Author Tipplin -->
        /// Determines which architectures are supported (under WOW64) on the given machine architecture.
        /// 
        /// <!-- Author Tipplin -->
        /// <remarks>
        /// UnsafeNativeMethods.IsWow64GuestMachineSupported
        /// (Visual.Operation.System.Native.NativeMethods.WOW64PROCESS_MACHINE, bool* MachineIsSupported)
        /// </remarks>
        internal enum WOW64PROCESS_MACHINE : ushort
        {
            
            /// <summary>
            ///  Unknown Machine
            /// </summary>
            IMAGE_FILE_MACHINE_UNKNOWN = 0,

            /// <summary>
            /// Interacts with the host and not a WOW64 guest
            /// </summary>
            IMAGE_FILE_MACHINE_TARGET_HOST = 0x0001,

            /// <summary>
            /// Intel 386
            /// </summary>
            IMAGE_FILE_MACHINE_I386 = 0x014c,

            /// <summary>
            /// MIPS little-endian, 0x160 big-endian
            /// </summary>
            IMAGE_FILE_MACHINE_R3000 = 0x0162,

            // MIPS little-endian
            IMAGE_FILE_MACHINE_R4000 = 0x0166,

            // MIPS little-endian
            IMAGE_FILE_MACHINE_R10000 = 0x0168,

            // MIPS little-endian WCE v2
            IMAGE_FILE_MACHINE_WCEMIPSV2 = 0x0169,

            // Alpha_AXP
            IMAGE_FILE_MACHINE_ALPHA = 0x0184,

            // SH3 little-endian
            IMAGE_FILE_MACHINE_SH3 = 0x01a2,

            // SH3DSP 
            IMAGE_FILE_MACHINE_SH3DSP = 0x01a3,

            // SH3E little-endian
            IMAGE_FILE_MACHINE_SH3E = 0x01a4,

            // SH4 little-endian
            IMAGE_FILE_MACHINE_SH4 = 0x01a6,

            // SH5
            IMAGE_FILE_MACHINE_SH5 = 0x01a8,

            // ARM Little-Endian
            IMAGE_FILE_MACHINE_ARM = 0x01c0,

            // ARM Thumb/Thumb-2 Little-Endian
            IMAGE_FILE_MACHINE_THUMB = 0x01c2,

            // ARM Thumb-2 Little-Endian
            IMAGE_FILE_MACHINE_ARMNT = 0x01c4,

            // This constant is available starting with Windows 7 and Windows Server 2008 R2.

            // TAM33BD
            IMAGE_FILE_MACHINE_AM33 = 0x01d3,

            // IBM PowerPC Little-Endian
            IMAGE_FILE_MACHINE_POWERPC = 0x01F0,

            // POWERPCFP
            IMAGE_FILE_MACHINE_POWERPCFP = 0x01f1,

            // Intel 64 BIT
            IMAGE_FILE_MACHINE_IA64 = 0x0200,

            // MIPS
            IMAGE_FILE_MACHINE_MIPS16 = 0x0266,

            // ALPHA64
            IMAGE_FILE_MACHINE_ALPHA64 = 0x0284,

            // MIPS
            IMAGE_FILE_MACHINE_MIPSFPU = 0x0366,

            // MIPS
            IMAGE_FILE_MACHINE_MIPSFPU16 = 0x0466,

            // AXP64
            IMAGE_FILE_MACHINE_AXP64 = 0x0284,

            // Infineon
            IMAGE_FILE_MACHINE_TRICORE = 0x0520,

            // CEF
            IMAGE_FILE_MACHINE_CEF = 0x0CEF,

            // EFI Byte Code
            IMAGE_FILE_MACHINE_EBC = 0x0EBC,

            // AMD64 (K8)
            IMAGE_FILE_MACHINE_AMD64 = 0x8664,

            // M32R little-endian
            IMAGE_FILE_MACHINE_M32R = 0x9041,

            // ARM64 Little-Endian
            IMAGE_FILE_MACHINE_ARM64 = 0xAA64,

            // Windows CEE
            IMAGE_FILE_MACHINE_CEE = 0xC0EE
        }

        /// <summary>
        /// Enumerator PROCESSOR_FEATURE_PRESENT
        /// </summary>
        /// <!-- Author Tipplin -->
        /// ! NOTE ! 
        /// Windows Operation Systems at Windows XP to 
        /// Windows 10 but more and more new!,
        /// Base Windows 10 SDK 18632 !.
        /// Everytime you can check one Feature for Processor,
        /// Windows 10 have more Feature Flags for Processor,
        /// are 32BIT/64BIT, so 64BIT Flags only on 64BIT System.
        /// Same Flags are not supported by older Windows Operation Systems,
        /// see at comment!.
        /// Processor Featurs hidden, can free at next time.
        /// <!-- Author Tipplin -->
        /// <remarks>
        /// UnsafeNativeMethods.IsProcessorFeaturePresent(Visual.Operation.System.Native.NativeMethods.PROCESSOR_FEATURE_PRESENT)
        /// So you query is this Processor Feature on this Processor
        /// </remarks>
        internal enum PROCESSOR_FEATURE_PRESENT : uint
        {
            
                /// <summary>
                /// The 64-bit load/store atomic instructions are available.
                /// </summary>
                PF_ARM_64BIT_LOADSTORE_ATOMIC = 25,

                /// <summary>
                /// The divide instructions are available.
                /// </summary>
                PF_ARM_DIVIDE_INSTRUCTION_AVAILABLE = 24,

                /// <summary>
                /// The external cache is available.
                /// </summary>
                PF_ARM_EXTERNAL_CACHE_AVAILABLE = 26,

                /// <summary>
                /// The floating-point multiply-accumulate instruction is available.
                /// </summary>
                PF_ARM_FMAC_INSTRUCTIONS_AVAILABLE = 27,

                /// <summary>
                /// The VFP/Neon: 32 x 64bit register bank is present. This flag has the same meaning as PF_ARM_VFP_EXTENDED_REGISTERS.
                /// </summary>
                PF_ARM_VFP_32_REGISTERS_AVAILABLE = 18,

                /// <summary>
                /// The 3D-Now instruction set is available.
                /// </summary>
                PF_3DNOW_INSTRUCTIONS_AVAILABLE = 7,

                /// <summary>
                /// The processor channels are enabled.
                /// </summary>
                PF_CHANNELS_ENABLED = 16,

                /// <summary>
                /// The atomic compare and exchange operation (cmpxchg) is available.
                /// </summary>
                PF_COMPARE_EXCHANGE_DOUBLE = 2,

                /// <summary>
                /// The atomic compare and exchange 128-bit operation (cmpxchg16b) is available.
                /// Windows Server 2003 and Windows XP/2000 ---> This feature is not supported.
                /// </summary>
                PF_COMPARE_EXCHANGE128 = 14,

                /// <summary>
                /// The atomic compare 64 and exchange 128-bit operation 
                /// (cmp8xchg16) is available.Windows Server 2003 and Windows XP/2000 ---> This feature is not supported.
                /// </summary>
                PF_COMPARE64_EXCHANGE128 = 15,

                /// <summary>
                /// _fastfail() is available.
                /// </summary>
                PF_FASTFAIL_AVAILABLE = 23,
                /// <summary>
                /// Floating-point operations are emulated using a software emulator.
                /// This function returns a nonzero value if floating-point operations are emulated; otherwise, it returns zero.
                /// </summary>
                PF_FLOATING_POINT_EMULATED = 1,

                /// <summary>
                /// On a Pentium, a floating-point precision error can occur in rare circumstances.
                /// </summary>
                PF_FLOATING_POINT_PRECISION_ERRATA = 0,
                /// <summary>
                /// The MMX instruction set is available.
                /// </summary>
                PF_MMX_INSTRUCTIONS_AVAILABLE = 3,
                /// <summary>
                /// Data execution prevention is enabled.
                /// Windows XP/2000:  This feature is not supported until Windows XP with SP2 and Windows Server 2003 with SP1.
                /// </summary>
                PF_NX_ENABLED = 12,
                /// <summary>
                /// The processor is PAE-enabled.For more information, see Physical Address Extension.
                /// All x64 processors always return a nonzero value for this feature.
                /// </summary>
                PF_PAE_ENABLED = 9,
                /// <summary>
                /// The RDTSC instruction is available.
                /// </summary>
                PF_RDTSC_INSTRUCTION_AVAILABLE = 8,
                /// <summary>
                /// RDFSBASE, RDGSBASE, WRFSBASE, and WRGSBASE instructions are available.
                /// </summary>
                PF_RDWRFSGSBASE_AVAILABLE = 22,
                /// <summary>
                /// Second Level Address Translation is supported by the hardware.
                /// </summary>
                PF_SECOND_LEVEL_ADDRESS_TRANSLATION = 20,
                /// <summary>
                /// The SSE3 instruction set is available.
                /// Windows Server 2003 and Windows XP/2000 ---> This feature is not supported.
                /// </summary>
                PF_SSE3_INSTRUCTIONS_AVAILABLE = 13,
                /// <summary>
                /// Virtualization is enabled in the firmware.
                /// </summary>
                PF_VIRT_FIRMWARE_ENABLED = 21,
                /// <summary>
                /// The SSE instruction set is available.
                /// </summary>
                PF_XMMI_INSTRUCTIONS_AVAILABLE = 6,
                /// <summary>
                /// The SSE2 instruction set is available,
                /// Windows 2000 ---> This feature is not supported.
                /// </summary>
                PF_XMMI64_INSTRUCTIONS_AVAILABLE = 10,
                /// <summary>
                /// The processor implements the XSAVE and XRSTOR instructions.
                /// Windows Server 2008, Windows Vista, Windows Server 2003 and Windows XP/2000.
                /// This feature is not supported until Windows 7 and Windows Server 2008 R2.
                /// </summary>
                PF_XSAVE_ENABLED = 17
        }


        /// <summary>
        /// Enumerator for COMPUTER_NAME_FORMAT
        /// GetComputerNameEx
        /// </summary>
        /// <!-- Author Tipplin -->
        /// Networking in Windows 10 Professional or higher >
        /// more and more,
        /// one Network Library as Client/Server.
        /// Windows Server Client Library, but ATTENTION you must have Client Access License!
        /// In this Network Libraries Functions make check do have Server License.
        /// WinSAT.dll is Network Connection to Server.
        /// OpenServerLicense(...);
        /// 
        /// <!-- Author Tipplin -->
        /// <remarks>
        /// Get the NetBIOS or DNS Name for the local Computer.
        /// </remarks>
    internal enum COMPUTER_NAME_FORMAT
        {
            /// <summary>
            /// 
            /// </summary>
            ComputerNameNetBIOS,
            /// <summary>
            /// 
            /// </summary>
            ComputerNameDnsHostname,
            /// <summary>
            /// 
            /// </summary>
            ComputerNameDnsDomain,
            /// <summary>
            /// 
            /// </summary>
            ComputerNameDnsFullyQualified,
            /// <summary>
            /// 
            /// </summary>
            ComputerNamePhysicalNetBIOS,
            /// <summary>
            /// 
            /// </summary>
            ComputerNamePhysicalDnsHostname,
            /// <summary>
            /// 
            /// </summary>
            ComputerNamePhysicalDnsDomain,
            /// <summary>
            /// 
            /// </summary>
            ComputerNamePhysicalDnsFullyQualified,
            /// <summary>
            /// 
            /// </summary>
            ComputerNameMax
        }

        /// <summary>
        ///  Enumerator for EXTENDED_NAME_FORMAT
        ///  GetUserNameEx
        /// </summary>
        /// <!-- Author Tipplin -->
        /// Networking in Windows 10 Professional or higher
        /// <!-- Author Tipplin -->
        /// <remarks>
        /// Get the NetBIOS or DNS Name for User on the local Computer
        /// </remarks>
        internal enum EXTENDED_NAME_FORMAT
        {
            /// <summary>
            /// Unknown Name type
            /// </summary>
            NameUnknown = 0,
            /// <summary>
            /// Fully Qualified distinguished Name
            /// </summary>
            NameFullyQualifiedDN = 1,
            /// <summary>
            /// Sam like: Engineering\JSmith
            /// </summary>
            NameSamCompatible = 2,
            /// <summary>
            /// Friendly Display Name
            /// </summary>
            NameDisplay = 3,
            /// <summary>
            /// Guid
            /// </summary>
            NameUniqueId = 6,
            /// <summary>
            /// engineering.microsoft.com/software/sameone
            /// </summary>
            NameCanonical = 7,
            /// <summary>
            /// user email adress
            /// </summary>
            NameUserPrincipal = 8,
            /// <summary>
            /// 
            /// </summary>
            NameCanonicalEx = 9,
            /// <summary>
            /// www/www.microsoft.com@microsoft.com
            /// </summary>
            NameServicePrincipal = 10,
            /// <summary>
            /// Engineering.microsoft.com/JSmith
            /// </summary>
            NameDnsDomain = 12
        }

        /// <summary>
        /// Flags for Window
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        internal enum SHOW_FLAGS
        {


            /* Hides the window and activates another window.
             * Create an App with GUI and Console App for Messages like critical, exclamation and Information Messages about APP.
             * the Console App goes in background (HIDE) as first option or behind the App with GUI .exe
             * If HIDE, only by crictical message comes in Foreground and show the Critical Messages, than set SHOWNORMAL as flag
             * but listen the Window is not direct show, wait moment, he must be redrawed that's make Windows Operation System.
             * Other Option write logging into Console App, separate Log-File and/or in Windows Operation System EventLog.
             * Windows 10 Console App's with minimal Overhead, Forms have an greather Overhead.
             * Windows 10 Console outer Windows Kernel now, as separate Application, Console App is smaller, faster and System directly!
             * Console App's for Administrators the best, all what you want, 
             * Information/Security/Network/Operation System/Settings directly via command line tools.
             * Admin or Account Operator can add users, delete users, Privileges, Permissions and more...
             * Console App is running all is active.
             * 
             * Create automatic (Work) Job's with Date/Time, help tool is Start.exe system-tool
             * start Job1 - simplesample as Print Job at Time, most after working hours in the afternoon/night.
             * 
             * can set REALTIME (Priority-class) is avantage to other App's, but must be after work set on NORMAL (Priority-class) !
             * 
             * 
             * START ["Titel"] [/D Pfad] [/I] [/MIN] [/MAX] [/SEPARATE | /SHARED]
                  [/LOW | /NORMAL | /HIGH | /REALTIME] | /ABOVENORMAL | /BELOWNORMAL]
                  [/NODE <NUMA-Knoten>] [/AFFINITY <Hex.-Affinitätsmaske>] [/WAIT] [/B]
                  [Befehl/Programm] [Parameter]

                  "Titel"       Der Titel des neuen Fensters.
                  Pfad          Startverzeichnis.
                  B             Startet Anwendung, ohne ein neues Fenster zu öffnen. Die
                                Anwendung ignoriert STRG+C. Wenn die Anwendung nicht
                                selbständig STRG+C überprüft, ist STRG+UNTBR die einzige
                                Möglichkeit, um die Anwendung abzubrechen.
                  I             Die CMD.EXE beim Aufruf übergebene Umgebung soll die neue
                                aktuelle Umgebung sein.
                  MIN           Startet das Fenster minimiert.
                  MAX           Startet das Fenster maximiert.
                  SEPARATE      Startet 16-Bit-Windows-Programm in separatem Speicherbereich.
                  SHARED        Startet 16-Bit-Windows-Programm in gemeinsamen
                                Speicherbereich.
                  LOW           Startet Anwendung in IDLE-Prioritätsklasse.
                  NORMAL        Startet Anwendung in der NORMAL-Prioritätsklasse.
                  HIGH          Startet Anwendung in der HIGH-Prioritätsklasse.
                  REALTIME      Startet Anwendung in der REALTIME-Prioritätsklasse.
                  ABOVENORMAL   Startet Anwendung in der ABOVENORMAL-Prioritätsklasse.
                  BELOWNORMAL   Startet Anwendung in der BELOWNORMAL-Prioritätsklasse.
                  NODE          Legt den Knoten der bevorzugten NUMA-Architektur
                  AFFINITY      Legt die Prozessoraffinitätsmaske als Hexadezimalzahl fest.
                                Der Prozess kann nur auf diesen Prozessoren ausgeführt werden.

                                Die Affinitätsmaske wird abweichend interpretiert, wenn
                                /AFFINITY und /NODE kombiniert werden.  Legt die
                                Affinitätsmaske so fest, als würde die Prozessormaske
                                des NUMA-Knotens nach rechts verschoben, um bei Bit null zu
                                beginnen. Der Prozess kann nur auf diesen gemeinsamen
                                Prozessoren zwischen der festgelegten Affinitätsmaske und dem
                                NUMA-Knoten ausgeführt werden. Wenn keine gemeinsamen
                                Prozessoren vorhanden sind, wird der Prozess auf
                                die Ausführung auf dem festgelegten NUMA-Knoten beschränkt.
                  WAIT          Startet die Anwendung und wartet auf ihre Beendigung.
                  NEWWINDOW     Startet die Anwendung nicht ein einer neuen Registerkarte,
                                sondern in einem neuen Fenster.
                  Befehl/Programm
                                Wenn es sich um einen internen "cmd"-Befehl oder eine
                                Batchdatei handelt, wird der Befehlszeilenprozessor "cmd.exe"
                                mit dem Parameter "/K" gestartet. Dies bedeutet, dass das
                                Fenster nach der Ausführung des Befehls nicht geschlossen
                                wird.

                                Wenn es sich nicht um einen internen "cmd"-Befehl oder eine
                                Batchdatei handelt, dann handelt es sich um ein Programm und
                                wird entweder in einem Fenster ausgeführt oder als
                                Konsolenanwendung.
                                 Parameter     Dies sind die an den Befehl oder das Programm übergebenen
                Parameter.

                HINWEIS: Die Optionen SEPARATE und SHARED werden auf 64-Bit-Plattformen nicht
                unterstützt.

                Durch die Festlegung von /NODE werden Prozesse auf eine Weise erstellt, durch
                die Speicherorte auf NUMA-Systemen verwendet wird. Beispielsweise können zwei
                Prozesse, die im hohen Maße über gemeinsam genutzten Speicher miteinander
                kommunizieren, so erstellt werden, dass sie den gleichen bevorzugten
                NUMA-Knoten gemeinsam verwenden, um die Speicherlatenz zu verringern. Sie
                weisen nach Möglichkeit Speicher vom gleichen NUMA-Knoten zu, und sie können
                auf Prozessoren außerhalb des festgelegten Knotens ausgeführt werden.

                    start /NODE 1 application1.exe
                    start /NODE 1 application2.exe

                Diese beiden Prozesse können weiter eingeschränkt werden, damit sie auf
                bestimmten Prozessoren innerhalb des gleichen NUMA-Knotens ausgeführt werden.
                Im folgenden Beispiel wird application1 auf den beiden niedrigen Prozessoren
                des Knotens ausgeführt, während application2 auf den folgenden beiden
                Prozessoren des Knotens ausgeführt wird. In diesem Beispiel wird davon
                ausgegangen, dass der angegebene Knoten über mindestens vier logische
                Prozessoren verfügt.  Beachten Sie, dass die Knotennummer für diesen Computer
                zu jeder gültigen Knotennummer geändert werden kann, ohne, dass die
                Affinitätsmaske geändert werden muss.

                    start /NODE 1 /AFFINITY 0x3 application1.exe
                    start /NODE 1 /AFFINITY 0xc application2.exe

                Wenn die Befehlserweiterungen aktiviert sind, wird der Aufruf von externen
                Befehlen durch die Befehlszeile oder den START-Befehl folgendermaßen verändert:

                Nicht-ausführbare Dateien können durch ihre Zuordnung zu einem Dateityp
                    einfach durch Eingabe des Namens als Befehl aufgerufen werden (z. B. würde
                    WORD.DOC die Anwendung starten, die der .DOC-Erweiterung zugeordnet ist).
                    Weitere Informationen, wie Sie diese Zuordnungen innerhalb eines Befehls-
                    skripts ändern, finden Sie beim ASSOC- bzw. FTYPE-Befehl.

                Wird eine grafische 32-Bit-Anwendung aufgerufen, wartet CMD.EXE nicht auf
                    das Beenden dieser Anwendung, sondern kehrt sofort zur Eingabeauforderung
                    zurück. Das gilt NICHT, wenn diese Anwendung aus einem Befehlsskript
                    heraus aufgerufen wird.

                Wenn eine Befehlszeile ausgeführt wird, die mit den Zeichen CMD ohne
                    Erweiterung oder Pfadname beginnt, wird CMD durch den Wert der
                    COMSPEC-Variablen ersetzt. Damit wird vermieden, dass man versehentlich
                    eine andere, ggf. zufällige Version der CMD.EXE verwendet.

                Wenn eine Befehlszeile ausgeführt wird, die mit Zeichen beginnt, die keine
                    Dateierweiterung enthalten, dann verwendet CMD.EXE den Wert der Umgebungs-
                    variablen PATHEXT, um zu bestimmen, welche Erweiterungen in welcher
                    Reihenfolge verwendet werden. Der Standardwert für die PATHEXT-Variable
                    ist:

                        .COM;.EXE;.BAT;.CMD
                    Dabei ist die Syntax dieselbe wie in der PATH-Variablen, das heißt, die
                    einzelnen Einträge werden durch Semikolon getrennt.

                Wenn mit dem START-Befehl ein Programm bzw. Befehl aufgerufen wird und keine
                entsprechende Dateierweiterung gefunden wird, aber der Name ohne Erweiterung
                einem Verzeichnisnamen entspricht, wird der Explorer mit diesem Pfad
                aufgerufen. Von der Befehlszeile ausgeführt entspricht das einem CD /D mit
                diesem Pfad.
             * 
             * 
             */
            SW_HIDE = 0,

            /* Activates and displays a window. If the window is minimized or maximized, 
             * the system restores it to its original size and position. 
             * An application should specify this flag when displaying the window for the first time.
             */
            SW_SHOWNORMAL = 1,
            
            // Activates the window and displays it as a minimized window.
            SW_SHOWMINIMIZED = 2,
            
            //Activates the window and displays it as a maximized window.
            SW_SHOWMAXIMIZED = 3,
            
            /* Displays a window in its most recent size and position.
             * This value is similar to SW_SHOWNORMAL, 
             * except that the window is not activated.
             */
            SW_SHOWNOACTIVATE = 4,
            
            // Activates the window and displays it in its current size and position.
            SW_SHOW = 5,

            // Minimizes the specified window and activates the next top-level window in the Z order.
            SW_MINIMIZE = 6,

            /* Displays the window as a minimized window.
             * This value is similar to SW_SHOWMINIMIZED, 
             * except the window is not activated.
             */
            SW_SHOWMINNOACTIVE = 7,

            /* Displays the window in its current size and position.
             * This value is similar to SW_SHOW, 
             * except that the window is not activated.
             */
            SW_SHOWNA = 8,
            
            /* Activates and displays the window.
             * If the window is minimized or maximized, 
             * the system restores it to its original size and position.
             * An application should specify this flag when restoring a minimized window.  
             */
            SW_RESTORE = 9,

            /* Sets the show state based on the SW_ value specified in the STARTUPINFO structure 
             * passed to the CreateProcess function by the program that started the application.
             */
            SW_SHOWDEFAULT = 10,

            /* Minimizes a window, even if the thread that owns the window is not responding. 
             * This flag should only be used when minimizing windows from a different thread. 
             */
            SW_FORCEMINIMIZE = 11
        }

        /// <summary>
        /// Enumerator for FlashWindow,
        /// Flash Flags, Flash All or Caption or Taskbar,
        /// plus TimerStop.
        /// </summary>
        [Flags]
        internal enum FlashWindow
        {
            /// <summary>
            /// Stop flashing. The system restores the window to its original state. 
            /// </summary>    
            FLASHW_STOP = 0,

            /// <summary>
            /// Flash the window caption 
            /// </summary>
            FLASHW_CAPTION = 1,

            /// <summary>
            /// Flash the taskbar button. 
            /// </summary>
            FLASHW_TRAY = 2,

            /// <summary>
            /// Flash both the window caption and taskbar button.
            /// This is equivalent to setting the FLASHW_CAPTION | FLASHW_TRAY flags. 
            /// </summary>
            FLASHW_ALL = 3,

            /// <summary>
            /// Flash continuously, until the FLASHW_STOP flag is set.
            /// </summary>
            FLASHW_TIMER = 4,

            /// <summary>
            /// Flash continuously until the window comes to the foreground. 
            /// </summary>
            FLASHW_TIMERNOFG = 12
        }

        /// <summary>
        /// RegistryValueKind
        /// </summary>
        /// <remarks>
        /// Means the sets for Registry Key as value:
        /// STRING, DWORD, QWORD (64BIT Value), BINARY, MULTISTRING (make open multi string window)
        /// </remarks>
        internal enum RegistryValueKind
        {
            String = 1,
            ExpandString,
            Binary,
            DWord,
            MultiString = 7,
            QWord = 11,
            Unknown = 0,
            None = -1
        }

        /// <summary>
        /// Token Access Levels
        /// </summary>
        [Flags]
        internal enum TokenAccessLevels
        {
            /// <summary>
            /// 
            /// </summary>
            AssignPrimary = 0x1,
            Duplicate = 0x2,
            Impersonate = 0x4,
            Query = 0x8,
            QuerySource = 0x10,
            AdjustPrivileges = 0x20,
            AdjustGroups = 0x40,
            AdjustDefault = 0x80,
            AdjustSessionId = 0x100,
            Read = 0x20008,
            Write = 0x200E0,
            AllAccess = 0xF01FF,
            MaximumAllowed = 0x2000000
        }



        /// <summary>
        /// Set Color for Forground and Background
        /// </summary>
        [Flags]
        internal enum Color : short
        {
            Black = 0x0,
            ForegroundBlue = 0x1,
            ForegroundGreen = 0x2,
            ForegroundRed = 0x4,
            ForegroundYellow = 0x6,
            ForegroundIntensity = 0x8,
            BackgroundBlue = 0x10,
            BackgroundGreen = 0x20,
            BackgroundRed = 0x40,
            BackgroundYellow = 0x60,
            BackgroundIntensity = 0x80,
            ForegroundMask = 0xF,
            BackgroundMask = 0xF0,
            ColorMask = 0xFF
        }

        /// <summary>
        /// Security Impersonation Level
        /// </summary>
        internal enum SECURITY_IMPERSONATION_LEVEL
        {
            /// <summary>
            /// 
            /// </summary>
            Anonymous,
            /// <summary>
            /// 
            /// </summary>
            Identification,
            /// <summary>
            /// 
            /// </summary>
            Impersonation,
            /// <summary>
            /// 
            /// </summary>
            Delegation
        }

        /// <summary>
        /// Processor Architecture
        /// </summary>
        /// <remarks>
        /// Intel, Arm, AMD for all 32/64BIT
        /// ! NOTE !: The 32BIT goes END !
        /// Vendors supports only 64BIT - programming:
        /// (AMD)Nvidia, IBM, Apple,
        /// Intel AI/KI Processor 'Tangle lake'
        /// Intel Cloud Processor 'Cascade Lake'
        /// Huawei AI/KI Processor
        /// </remarks>
        internal enum ProcessorArchitecture : ushort
        {
            /// <summary>
            /// INTEL 32 BIT Processor
            /// </summary>
            Processor_Architecture_INTEL,
            /// <summary>
            ///  ARM 32 BIT Processor
            /// </summary>
            Processor_Architecture_ARM = 5,
            /// <summary>
            /// INTEL 64 BIT Processor
            /// </summary>
            Processor_Architecture_IA64,
            /// <summary>
            /// AMD 64 BIT Processor
            /// </summary>
            Processor_Architecture_AMD64 = 9,
            /// <summary>
            /// ARM 64 BIT Processor
            /// </summary>
            Processor_Architecture_ARM64 = 12,
            /// <summary>
            /// UNKNOWN
            /// </summary>
            Processor_Architecture_UNKNOWN = ushort.MaxValue
        }

        /// <summary>
        /// Enumerator for ALL EXIT_CODES
        /// </summary>
        /// <!-- Author TIPPO -->
        /// GetLastError------ Windows Operation System
        /// RestoreLastError-- new  
        /// <!-- Author TIPPO -->
        /// <remarks>
        /// use here inside for VOLExit(enum EXIT_CODES);
        /// Original is form Visual C++ Runtime Library Exit(int ErrorCode);
        /// Windows 10 has any C++ Runtimes Libraries, 
        /// the Main Runtime is ucrt140.dll is the System-Compoment,
        /// (ucrt = universal c runtime library)
        /// equalvalent is vcruntime140.dll for Visual Studio.
        /// in SDK C++ headerfiles 
        /// C:\Program Files (x86)\Windows Kits\10\Include\10.0.18309.0\ .h
        /// and 
        /// source code in C++:
        /// C:\Program Files (x86)\Windows Kits\10\Source\10.0.18309.0\ucrt\ 'C++ folders'
        /// 
        /// msvcrt.dll is 64BIT only written.
        /// </remarks>
        internal enum EXIT_CODES : int
        {
            /// <summary>
            /// The operation completed successfully.
            /// </summary>
            ERROR_SUCCESS = 0,
            /// <summary>
            /// Incorrect function.
            /// </summary>
            ERROR_INVALID_FUNCTION = 1,
            /// <summary>
            /// The system cannot find the file specified.
            /// </summary>
            ERROR_FILE_NOT_FOUND = 2,
            /// <summary>
            /// The system cannot find the path specified.
            /// </summary>
            ERROR_PATH_NOT_FOUND = 3,
            /// <summary>
            /// The system cannot open the file.
            /// </summary>
            ERROR_TOO_MANY_OPEN_FILES = 4,
            /// <summary>
            /// Access is denied.
            /// </summary>
            ERROR_ACCESS_DENIED = 5,
            /// <summary>
            /// The handle is invalid.
            /// </summary>
            ERROR_INVALID_HANDLE = 6,
            /// <summary>
            /// The storage control blocks were destroyed.
            /// </summary>
            ERROR_ARENA_TRASHED = 7,
            /// <summary>
            /// Not enough storage is available to process this command.
            /// </summary>
            ERROR_NOT_ENOUGH_MEMORY = 8,
            /// <summary>
            /// The storage control block address is invalid.
            /// </summary>
            ERROR_INVALID_BLOCK = 9,
            /// <summary>
            /// The environment is incorrect.
            /// </summary>
            ERROR_BAD_ENVIRONMENT = 10,
            /// <summary>
            /// An attempt was made to load a program with an incorrect format.
            /// </summary>
            ERROR_BAD_FORMAT = 11,
            /// <summary>
            /// The access code is invalid.
            /// </summary>
            ERROR_INVALID_ACCESS = 12,
            /// <summary>
            /// The data is invalid.
            /// </summary>
            ERROR_INVALID_DATA = 13,
            /// <summary>
            /// Not enough storage is available to complete this operation.
            /// </summary>
            ERROR_OUTOFMEMORY = 14,
            /// <summary>
            /// The system cannot find the drive specified.
            /// </summary>
            ERROR_INVALID_DRIVE = 15,
            /// <summary>
            /// The directory cannot be removed.
            /// </summary>
            ERROR_CURRENT_DIRECTORY = 16,
            /// <summary>
            /// The system cannot move the file to a different disk drive.
            /// </summary>
            ERROR_NOT_SAME_DEVICE = 17,
            /// <summary>
            /// There are no more files.
            /// </summary>
            ERROR_NO_MORE_FILES = 18,
            /// <summary>
            /// The media is write protected.
            /// </summary>
            ERROR_WRITE_PROTECT = 19,
            /// <summary>
            /// The system cannot find the device specified.
            /// </summary>
            ERROR_BAD_UNIT = 20,
            /// <summary>
            /// The device is not ready.
            /// </summary>
            ERROR_NOT_READY = 21,
            /// <summary>
            /// The device does not recognize the command.
            /// </summary>
            ERROR_BAD_COMMAND = 22,
            /// <summary>
            /// Data error (cyclic redundancy check).
            /// </summary>
            ERROR_CRC = 23,
            /// <summary>
            /// The program issued a command but the command length is incorrect.
            /// </summary>
            ERROR_BAD_LENGTH = 24,
            /// <summary>
            /// The drive cannot locate a specific area or track on the disk.
            /// </summary>
            ERROR_SEEK = 25,
            /// <summary>
            /// The specified disk or diskette cannot be accessed.
            /// </summary>
            ERROR_NOT_DOS_DISK = 26,
            /// <summary>
            /// The drive cannot find the sector requested.
            /// </summary>
            ERROR_SECTOR_NOT_FOUND = 27,
            /// <summary>
            /// The printer is out of paper.
            /// </summary>
            ERROR_OUT_OF_PAPER = 28,
            /// <summary>
            /// The system cannot write to the specified device.
            /// </summary>
            ERROR_WRITE_FAULT = 29,
            /// <summary>
            /// The system cannot read from the specified device.
            /// </summary>
            ERROR_READ_FAULT = 30,
            /// <summary>
            /// A device attached to the system is not functioning.
            /// </summary>
            ERROR_GEN_FAILURE = 31,
            /// <summary>
            /// The process cannot access the file because it is being used by another process.
            /// </summary>
            ERROR_SHARING_VIOLATION = 32,
            /// <summary>
            /// The process cannot access the file because another process has locked a portion of the file.
            /// </summary>
            ERROR_LOCK_VIOLATION = 33,
            /// <summary>
            /// The wrong diskette is in the drive.
            /// Insert %2 (Volume Serial Number: %3) into drive %1.
            /// </summary>
            ERROR_WRONG_DISK = 34,
            /// <summary>
            /// Too many files opened for sharing.
            /// </summary>
            ERROR_SHARING_BUFFER_EXCEEDED = 36,
            /// <summary>
            /// Reached the end of the file.
            /// </summary>
            ERROR_HANDLE_EOF = 38,
            /// <summary>
            /// The disk is full.
            /// </summary>
            ERROR_HANDLE_DISK_FULL = 39,
            /// <summary>
            /// The request is not supported.
            /// </summary>
            ERROR_NOT_SUPPORTED = 50,
            /// <summary>
            /// Windows cannot find the network path. Verify that the network path is correct and the destination computer is not busy or turned off. If Windows still cannot find the network path, contact your network administrator.
            /// </summary>
            ERROR_REM_NOT_LIST = 51,
            /// <summary>
            /// You were not connected because a duplicate name exists on the network. Go to System in Control Panel to change the computer name and try again.
            /// </summary>
            ERROR_DUP_NAME = 52,
            /// <summary>
            /// The network path was not found.
            /// </summary>
            ERROR_BAD_NETPATH = 53,
            /// <summary>
            /// The network is busy.
            /// </summary>
            ERROR_NETWORK_BUSY = 54,
            /// <summary>
            /// The specified network resource or device is no longer available.
            /// </summary>
            ERROR_DEV_NOT_EXIST = 55,
            /// <summary>
            /// The network BIOS command limit has been reached.
            /// </summary>
            ERROR_TOO_MANY_CMDS = 56,
            /// <summary>
            /// A network adapter hardware error occurred.
            /// </summary>
            ERROR_ADAP_HDW_ERR = 57,
            /// <summary>
            /// The specified server cannot perform the requested operation.
            /// </summary>
            ERROR_BAD_NET_RESP = 58,
            /// <summary>
            /// An unexpected network error occurred.
            /// </summary>
            ERROR_UNEXP_NET_ERR = 59,
            /// <summary>
            /// The remote adapter is not compatible.
            /// </summary>
            ERROR_BAD_REM_ADAP = 60,
            /// <summary>
            /// The printer queue is full.
            /// </summary>
            ERROR_PRINTQ_FULL = 61,
            /// <summary>
            /// Space to store the file waiting to be printed is not available on the server.
            /// </summary>
            ERROR_NO_SPOOL_SPACE = 62,
            /// <summary>
            /// Your file waiting to be printed was deleted.
            /// </summary>
            ERROR_PRINT_CANCELLED = 63,
            /// <summary>
            /// The specified network name is no longer available.
            /// </summary>
            ERROR_NETNAME_DELETED = 64,
            /// <summary>
            /// Network access is denied.
            /// </summary>
            ERROR_NETWORK_ACCESS_DENIED = 65,
            /// <summary>
            /// The network resource type is not correct.
            /// </summary>
            ERROR_BAD_DEV_TYPE = 66,
            /// <summary>
            /// The network name cannot be found.
            /// </summary>
            ERROR_BAD_NET_NAME = 67,
            /// <summary>
            /// The name limit for the local computer network adapter card was exceeded.
            /// </summary>
            ERROR_TOO_MANY_NAMES = 68,
            /// <summary>
            /// The network BIOS session limit was exceeded.
            /// </summary>
            ERROR_TOO_MANY_SESS = 69,
            /// <summary>
            /// The remote server has been paused or is in the process of being started.
            /// </summary>
            ERROR_SHARING_PAUSED = 70,
            /// <summary>
            /// No more connections can be made to this remote computer at this time because there are already as many connections as the computer can accept.
            /// </summary>
            ERROR_REQ_NOT_ACCEP = 71,
            /// <summary>
            /// The specified printer or disk device has been paused.
            /// </summary>
            ERROR_REDIR_PAUSED = 72,
            /// <summary>
            /// The file exists.
            /// </summary>
            ERROR_FILE_EXISTS = 80,
            /// <summary>
            /// The directory or file cannot be created.
            /// </summary>
            ERROR_CANNOT_MAKE = 82,
            /// <summary>
            /// Fail on INT 24.
            /// </summary>
            ERROR_FAIL_I24 = 83,
            /// <summary>
            /// Storage to process this request is not available.
            /// </summary>
            ERROR_OUT_OF_STRUCTURES = 84,
            /// <summary>
            /// The local device name is already in use.
            /// </summary>
            ERROR_ALREADY_ASSIGNED = 85,
            /// <summary>
            /// The specified network password is not correct.
            /// </summary>
            ERROR_INVALID_PASSWORD = 86,
            /// <summary>
            /// The parameter is incorrect.
            /// </summary>
            ERROR_INVALID_PARAMETER = 87,
            /// <summary>
            /// A write fault occurred on the network.
            /// </summary>
            ERROR_NET_WRITE_FAULT = 88,
            /// <summary>
            /// The system cannot start another process at this time.
            /// </summary>
            ERROR_NO_PROC_SLOTS = 89,
            /// <summary>
            /// Cannot create another system semaphore.
            /// </summary>
            ERROR_TOO_MANY_SEMAPHORES = 100,
            /// <summary>
            /// The exclusive semaphore is owned by another process.
            /// </summary>
            ERROR_EXCL_SEM_ALREADY_OWNED = 101,
            /// <summary>
            /// The semaphore is set and cannot be closed.
            /// </summary>
            ERROR_SEM_IS_SET = 102,
            /// <summary>
            /// The semaphore cannot be set again.
            /// </summary>
            ERROR_TOO_MANY_SEM_REQUESTS = 103,
            /// <summary>
            /// Cannot request exclusive semaphores at interrupt time.
            /// </summary>
            ERROR_INVALID_AT_INTERRUPT_TIME = 104,
            /// <summary>
            /// The previous ownership of this semaphore has ended.
            /// </summary>
            ERROR_SEM_OWNER_DIED = 105,
            /// <summary>
            /// Insert the diskette for drive %1.
            /// </summary>
            ERROR_SEM_USER_LIMIT = 106,
            /// <summary>
            /// The program stopped because an alternate diskette was not inserted.
            /// </summary>
            ERROR_DISK_CHANGE = 107,
            /// <summary>
            /// The disk is in use or locked by another process.
            /// </summary>
            ERROR_DRIVE_LOCKED = 108,
            /// <summary>
            /// The pipe has been ended.
            /// </summary>
            ERROR_BROKEN_PIPE = 109,
            /// <summary>
            /// The system cannot open the device or file specified.
            /// </summary>
            ERROR_OPEN_FAILED = 110,
            /// <summary>
            /// The file name is too long.
            /// </summary>
            ERROR_BUFFER_OVERFLOW = 111,
            /// <summary>
            /// There is not enough space on the disk.
            /// </summary>
            ERROR_DISK_FULL = 112,
            /// <summary>
            /// No more internal file identifiers available.
            /// </summary>
            ERROR_NO_MORE_SEARCH_HANDLES = 113,
            /// <summary>
            /// The target internal file identifier is incorrect.
            /// </summary>
            ERROR_INVALID_TARGET_HANDLE = 114,
            /// <summary>
            /// The IOCTL call made by the application program is not correct.
            /// </summary>
            ERROR_INVALID_CATEGORY = 117,
            /// <summary>
            /// The verify-on-write switch parameter value is not correct.
            /// </summary>
            ERROR_INVALID_VERIFY_SWITCH = 118,
            /// <summary>
            /// The system does not support the command requested.
            /// </summary>
            ERROR_BAD_DRIVER_LEVEL = 119,
            /// <summary>
            /// This function is not supported on this system.
            /// </summary>
            ERROR_CALL_NOT_IMPLEMENTED = 120,
            /// <summary>
            /// The semaphore timeout period has expired.
            /// </summary>
            ERROR_SEM_TIMEOUT = 121,
            /// <summary>
            /// The data area passed to a system call is too small.
            /// </summary>
            ERROR_INSUFFICIENT_BUFFER = 122,
            /// <summary>
            /// The filename, directory name, or volume label syntax is incorrect.
            /// </summary>
            ERROR_INVALID_NAME = 123,
            /// <summary>
            /// The system call level is not correct.
            /// </summary>
            ERROR_INVALID_LEVEL = 124,
            /// <summary>
            /// The disk has no volume label.
            /// </summary>
            ERROR_NO_VOLUME_LABEL = 125,
            /// <summary>
            /// The specified module could not be found.
            /// </summary>
            ERROR_MOD_NOT_FOUND = 126,
            /// <summary>
            /// The specified procedure could not be found.
            /// </summary>
            ERROR_PROC_NOT_FOUND = 127,
            /// <summary>
            /// There are no child processes to wait for.
            /// </summary>
            ERROR_WAIT_NO_CHILDREN = 128,
            /// <summary>
            /// The %1 application cannot be run in Win32 mode.
            /// </summary>
            ERROR_CHILD_NOT_COMPLETE = 129,
            /// <summary>
            /// Attempt to use a file handle to an open disk partition for an operation other than raw disk I/O.
            /// </summary>
            ERROR_DIRECT_ACCESS_HANDLE = 130,
            /// <summary>
            /// An attempt was made to move the file pointer before the beginning of the file.
            /// </summary>
            ERROR_NEGATIVE_SEEK = 131,
            /// <summary>
            /// The file pointer cannot be set on the specified device or file.
            /// </summary>
            ERROR_SEEK_ON_DEVICE = 132,
            /// <summary>
            /// A JOIN or SUBST command cannot be used for a drive that contains previously joined drives.
            /// </summary>
            ERROR_IS_JOIN_TARGET = 133,
            /// <summary>
            /// An attempt was made to use a JOIN or SUBST command on a drive that has already been joined.
            /// </summary>
            ERROR_IS_JOINED = 134,
            /// <summary>
            /// An attempt was made to use a JOIN or SUBST command on a drive that has already been substituted.
            /// </summary>
            ERROR_IS_SUBSTED = 135,
            /// <summary>
            /// The system tried to delete the JOIN of a drive that is not joined.
            /// </summary>
            ERROR_NOT_JOINED = 136,
            /// <summary>
            /// The system tried to delete the substitution of a drive that is not substituted.
            /// </summary>
            ERROR_NOT_SUBSTED = 137,
            /// <summary>
            /// The system tried to join a drive to a directory on a joined drive.
            /// </summary>
            ERROR_JOIN_TO_JOIN = 138,
            /// <summary>
            /// The system tried to substitute a drive to a directory on a substituted drive.
            /// </summary>
            ERROR_SUBST_TO_SUBST = 139,
            /// <summary>
            /// The system tried to join a drive to a directory on a substituted drive.
            /// </summary>
            ERROR_JOIN_TO_SUBST = 140,
            /// <summary>
            /// The system tried to SUBST a drive to a directory on a joined drive.
            /// </summary>
            ERROR_SUBST_TO_JOIN = 141,
            /// <summary>
            /// The system cannot perform a JOIN or SUBST at this time.
            /// </summary>
            ERROR_BUSY_DRIVE = 142,
            /// <summary>
            /// The system cannot join or substitute a drive to or for a directory on the same drive.
            /// </summary>
            ERROR_SAME_DRIVE = 143,
            /// <summary>
            /// The directory is not a subdirectory of the root directory.
            /// </summary>
            ERROR_DIR_NOT_ROOT = 144,
            /// <summary>
            /// The directory is not empty.
            /// </summary>
            ERROR_DIR_NOT_EMPTY = 145,
            /// <summary>
            /// The path specified is being used in a substitute.
            /// </summary>
            ERROR_IS_SUBST_PATH = 146,
            /// <summary>
            /// Not enough resources are available to process this command.
            /// </summary>
            ERROR_IS_JOIN_PATH = 147,
            /// <summary>
            /// The path specified cannot be used at this time.
            /// </summary>
            ERROR_PATH_BUSY = 148,
            /// <summary>
            /// An attempt was made to join or substitute a drive for which a directory on the drive is the target of a previous substitute.
            /// </summary>
            ERROR_IS_SUBST_TARGET = 149,
            /// <summary>
            /// System trace information was not specified in your CONFIG.SYS file, or tracing is disallowed.
            /// </summary>
            ERROR_SYSTEM_TRACE = 150,
            /// <summary>
            /// The number of specified semaphore events for DosMuxSemWait is not correct.
            /// </summary>
            ERROR_INVALID_EVENT_COUNT = 151,
            /// <summary>
            /// DosMuxSemWait did not execute, too many semaphores are already set.
            /// </summary>
            ERROR_TOO_MANY_MUXWAITERS = 152,
            /// <summary>
            /// The DosMuxSemWait list is not correct.
            /// </summary>
            ERROR_INVALID_LIST_FORMAT = 153,
            /// <summary>
            /// The volume label you entered exceeds the label character limit of the target file system.
            /// </summary>
            ERROR_LABEL_TOO_Int32 = 154,
            /// <summary>
            /// Cannot create another thread.
            /// </summary>
            ERROR_TOO_MANY_TCBS = 155,
            /// <summary>
            /// The recipient process has refused the signal.
            /// </summary>
            ERROR_SIGNAL_REFUSED = 156,
            /// <summary>
            /// The segment is already discarded and cannot be locked.
            /// </summary>
            ERROR_DISCARDED = 157,
            /// <summary>
            /// The segment is already unlocked.
            /// </summary>
            ERROR_NOT_LOCKED = 158,
            /// <summary>
            /// The address for the thread ID is not correct.
            /// </summary>
            ERROR_BAD_THREADID_ADDR = 159,
            /// <summary>
            /// One or more arguments are not correct.
            /// </summary>
            ERROR_BAD_ARGUMENTS = 160,
            /// <summary>
            /// The specified path is invalid.
            /// </summary>
            ERROR_BAD_PATHNAME = 161,
            /// <summary>
            /// A signal is already pending.
            /// </summary>
            ERROR_SIGNAL_PENDING = 162,
            /// <summary>
            /// No more threads can be created in the system.
            /// </summary>
            ERROR_MAX_THRDS_REACHED = 164,
            /// <summary>
            /// Unable to lock a region of a file.
            /// </summary>
            ERROR_LOCK_FAILED = 167,
            /// <summary>
            /// The requested resource is in use.
            /// </summary>
            ERROR_BUSY = 170,
            /// <summary>
            /// A lock request was not outstanding for the supplied cancel region.
            /// </summary>
            ERROR_CANCEL_VIOLATION = 173,
            /// <summary>
            /// The file system does not support atomic changes to the lock type.
            /// </summary>
            ERROR_ATOMIC_LOCKS_NOT_SUPPORTED = 174,
            /// <summary>
            /// The system detected a segment number that was not correct.
            /// </summary>
            ERROR_INVALID_SEGMENT_NUMBER = 180,
            /// <summary>
            /// The operating system cannot run %1.
            /// </summary>
            ERROR_INVALID_ORDINAL = 182,
            /// <summary>
            /// Cannot create a file when that file already exists.
            /// </summary>
            ERROR_ALREADY_EXISTS = 183,
            /// <summary>
            /// The flag passed is not correct.
            /// </summary>
            ERROR_INVALID_FLAG_NUMBER = 186,
            /// <summary>
            /// The specified system semaphore name was not found.
            /// </summary>
            ERROR_SEM_NOT_FOUND = 187,
            /// <summary>
            /// The operating system cannot run %1.
            /// </summary>
            ERROR_INVALID_STARTING_CODESEG = 188,
            /// <summary>
            /// The operating system cannot run %1.
            /// </summary>
            ERROR_INVALID_STACKSEG = 189,
            /// <summary>
            /// The operating system cannot run %1.
            /// </summary>
            ERROR_INVALID_MODULETYPE = 190,
            /// <summary>
            /// Cannot run %1 in Win32 mode.
            /// </summary>
            ERROR_INVALID_EXE_SIGNATURE = 191,
            /// <summary>
            /// The operating system cannot run %1.
            /// </summary>
            ERROR_EXE_MARKED_INVALID = 192,
            /// <summary>
            /// %1 is not a valid Win32 application.
            /// </summary>
            ERROR_BAD_EXE_FORMAT = 193,
            /// <summary>
            /// The operating system cannot run %1.
            /// </summary>
            ERROR_ITERATED_DATA_EXCEEDS_64k = 194,
            /// <summary>
            /// The operating system cannot run %1.
            /// </summary>
            ERROR_INVALID_MINALLOCSIZE = 195,
            /// <summary>
            /// The operating system cannot run this application program.
            /// </summary>
            ERROR_DYNLINK_FROM_INVALID_RING = 196,
            /// <summary>
            /// The operating system is not presently configured to run this application.
            /// </summary>
            ERROR_IOPL_NOT_ENABLED = 197,
            /// <summary>
            /// The operating system cannot run %1.
            /// </summary>
            ERROR_INVALID_SEGDPL = 198,
            /// <summary>
            /// The operating system cannot run this application program.
            /// </summary>
            ERROR_AUTODATASEG_EXCEEDS_64k = 199,
            /// <summary>
            /// The code segment cannot be greater than or equal to 64K.
            /// </summary>
            ERROR_RING2SEG_MUST_BE_MOVABLE = 200,
            /// <summary>
            /// The operating system cannot run %1.
            /// </summary>
            ERROR_RELOC_CHAIN_XEEDS_SEGLIM = 201,
            /// <summary>
            /// The operating system cannot run %1.
            /// </summary>
            ERROR_INFLOOP_IN_RELOC_CHAIN = 202,
            /// <summary>
            /// The system could not find the environment option that was entered.
            /// </summary>
            ERROR_ENVVAR_NOT_FOUND = 203,
            /// <summary>
            /// No process in the command subtree has a signal handler.
            /// </summary>
            ERROR_NO_SIGNAL_SENT = 205,
            /// <summary>
            /// The filename or extension is too long.
            /// </summary>
            ERROR_FILENAME_EXCED_RANGE = 206,
            /// <summary>
            /// The ring 2 stack is in use.
            /// </summary>
            ERROR_RING2_STACK_IN_USE = 207,
            /// <summary>
            /// The global filename characters, * or ?, are entered incorrectly or too many global filename characters are specified.
            /// </summary>
            ERROR_META_EXPANSION_TOO_Int32 = 208,
            /// <summary>
            /// The signal being posted is not correct.
            /// </summary>
            ERROR_INVALID_SIGNAL_NUMBER = 209,
            /// <summary>
            /// The signal handler cannot be set.
            /// </summary>
            ERROR_THREAD_1_INACTIVE = 210,
            /// <summary>
            /// The segment is locked and cannot be reallocated.
            /// </summary>
            ERROR_LOCKED = 212,
            /// <summary>
            /// Too many dynamic-link modules are attached to this program or dynamic-link module.
            /// </summary>
            ERROR_TOO_MANY_MODULES = 214,
            /// <summary>
            /// Cannot nest calls to LoadModule.
            /// </summary>
            ERROR_NESTING_NOT_ALLOWED = 215,
            /// <summary>
            /// The image file %1 is valid, but is for a machine type other than the current machine.
            /// </summary>
            ERROR_EXE_MACHINE_TYPE_MISMATCH = 216,
            /// <summary>
            /// No information avialable.
            /// </summary>
            ERROR_EXE_CANNOT_MODIFY_SIGNED_BINARY = 217,
            /// <summary>
            /// No information avialable.
            /// </summary>
            ERROR_EXE_CANNOT_MODIFY_STRONG_SIGNED_BINARY = 218,
            /// <summary>
            /// The pipe state is invalid.
            /// </summary>
            ERROR_BAD_PIPE = 230,
            /// <summary>
            /// All pipe instances are busy.
            /// </summary>
            ERROR_PIPE_BUSY = 231,
            /// <summary>
            /// The pipe is being closed.
            /// </summary>
            ERROR_NO_DATA = 232,
            /// <summary>
            /// No process is on the other end of the pipe.
            /// </summary>
            ERROR_PIPE_NOT_CONNECTED = 233,
            /// <summary>
            /// More data is available.
            /// </summary>
            ERROR_MORE_DATA = 234,
            /// <summary>
            /// The session was canceled.
            /// </summary>
            ERROR_VC_DISCONNECTED = 240,
            /// <summary>
            /// The specified extended attribute name was invalid.
            /// </summary>
            ERROR_INVALID_EA_NAME = 254,
            /// <summary>
            /// The extended attributes are inconsistent.
            /// </summary>
            ERROR_EA_LIST_INCONSISTENT = 255,
            /// <summary>
            /// The wait operation timed out.
            /// </summary>
            WAIT_TIMEOUT = 258,
            /// <summary>
            /// No more data is available.
            /// </summary>
            ERROR_NO_MORE_ITEMS = 259,
            /// <summary>
            /// The copy functions cannot be used.
            /// </summary>
            ERROR_CANNOT_COPY = 266,
            /// <summary>
            /// The directory name is invalid.
            /// </summary>
            ERROR_DIRECTORY = 267,
            /// <summary>
            /// The extended attributes did not fit in the buffer.
            /// </summary>
            ERROR_EAS_DIDNT_FIT = 275,
            /// <summary>
            /// The extended attribute file on the mounted file system is corrupt.
            /// </summary>
            ERROR_EA_FILE_CORRUPT = 276,
            /// <summary>
            /// The extended attribute table file is full.
            /// </summary>
            ERROR_EA_TABLE_FULL = 277,
            /// <summary>
            /// The specified extended attribute handle is invalid.
            /// </summary>
            ERROR_INVALID_EA_HANDLE = 278,
            /// <summary>
            /// The mounted file system does not support extended attributes.
            /// </summary>
            ERROR_EAS_NOT_SUPPORTED = 282,
            /// <summary>
            /// Attempt to release mutex not owned by caller.
            /// </summary>
            ERROR_NOT_OWNER = 288,
            /// <summary>
            /// Too many posts were made to a semaphore.
            /// </summary>
            ERROR_TOO_MANY_POSTS = 298,
            /// <summary>
            /// Only part of a ReadProcessMemory or WriteProcessMemory request was completed.
            /// </summary>
            ERROR_PARTIAL_COPY = 299,
            /// <summary>
            /// The oplock request is denied.
            /// </summary>
            ERROR_OPLOCK_NOT_GRANTED = 300,
            /// <summary>
            /// An invalid oplock acknowledgment was received by the system.
            /// </summary>
            ERROR_INVALID_OPLOCK_PROTOCOL = 301,
            /// <summary>
            /// The volume is too fragmented to complete this operation.
            /// </summary>
            ERROR_DISK_TOO_FRAGMENTED = 302,
            /// <summary>
            /// The file cannot be opened because it is in the process of being deleted.
            /// </summary>
            ERROR_DELETE_PENDING = 303,
            /// <summary>
            /// The system cannot find message text for message number 0x%1 in the message file for %2.
            /// </summary>
            ERROR_MR_MID_NOT_FOUND = 317,
            /// <summary>
            /// No information avialable.
            /// </summary>
            ERROR_SCOPE_NOT_FOUND = 318,
            /// <summary>
            /// Attempt to access invalid address.
            /// </summary>
            ERROR_INVALID_ADDRESS = 487,
            /// <summary>
            /// Arithmetic result exceeded 32 bits.
            /// </summary>
            ERROR_ARITHMETIC_OVERFLOW = 534,
            /// <summary>
            /// There is a process on other end of the pipe.
            /// </summary>
            ERROR_PIPE_CONNECTED = 535,
            /// <summary>
            /// Waiting for a process to open the other end of the pipe.
            /// </summary>
            ERROR_PIPE_LISTENING = 536,
            /// <summary>
            /// Access to the extended attribute was denied.
            /// </summary>
            ERROR_EA_ACCESS_DENIED = 994,
            /// <summary>
            /// The I/O operation has been aborted because of either a thread exit or an application request.
            /// </summary>
            ERROR_OPERATION_ABORTED = 995,
            /// <summary>
            /// Overlapped I/O event is not in a signaled state.
            /// </summary>
            ERROR_IO_INCOMPLETE = 996,
            /// <summary>
            /// Overlapped I/O operation is in progress.
            /// </summary>
            ERROR_IO_PENDING = 997,
            /// <summary>
            /// Invalid access to memory location.
            /// </summary>
            ERROR_NOACCESS = 998,
            /// <summary>
            /// Error performing inpage operation.
            /// </summary>
            ERROR_SWAPERROR = 999,
            /// <summary>
            /// Recursion too deep, the stack overflowed.
            /// </summary>
            ERROR_STACK_OVERFLOW = 1001,
            /// <summary>
            /// The window cannot act on the sent message.
            /// </summary>
            ERROR_INVALID_MESSAGE = 1002,
            /// <summary>
            /// Cannot complete this function.
            /// </summary>
            ERROR_CAN_NOT_COMPLETE = 1003,
            /// <summary>
            /// Invalid flags.
            /// </summary>
            ERROR_INVALID_FLAGS = 1004,
            /// <summary>
            /// The volume does not contain a recognized file system.
            /// Please make sure that all required file system drivers are loaded and that the volume is not corrupted.
            /// </summary>
            ERROR_UNRECOGNIZED_VOLUME = 1005,
            /// <summary>
            /// The volume for a file has been externally altered so that the opened file is no longer valid.
            /// </summary>
            ERROR_FILE_INVALID = 1006,
            /// <summary>
            /// The requested operation cannot be performed in full-screen mode.
            /// </summary>
            ERROR_FULLSCREEN_MODE = 1007,
            /// <summary>
            /// An attempt was made to reference a token that does not exist.
            /// </summary>
            ERROR_NO_TOKEN = 1008,
            /// <summary>
            /// The configuration registry database is corrupt.
            /// </summary>
            ERROR_BADDB = 1009,
            /// <summary>
            /// The configuration registry key is invalid.
            /// </summary>
            ERROR_BADKEY = 1010,
            /// <summary>
            /// The configuration registry key could not be opened.
            /// </summary>
            ERROR_CANTOPEN = 1011,
            /// <summary>
            /// The configuration registry key could not be read.
            /// </summary>
            ERROR_CANTREAD = 1012,
            /// <summary>
            /// The configuration registry key could not be written.
            /// </summary>
            ERROR_CANTWRITE = 1013,
            /// <summary>
            /// One of the files in the registry database had to be recovered by use of a log or alternate copy. The recovery was successful.
            /// </summary>
            ERROR_REGISTRY_RECOVERED = 1014,
            /// <summary>
            /// The registry is corrupted. The structure of one of the files containing registry data is corrupted, or the system's memory image of the file is corrupted, or the file could not be recovered because the alternate copy or log was absent or corrupted.
            /// </summary>
            ERROR_REGISTRY_CORRUPT = 1015,
            /// <summary>
            /// An I/O operation initiated by the registry failed unrecoverably. The registry could not read in, or write out, or flush, one of the files that contain the system's image of the registry.
            /// </summary>
            ERROR_REGISTRY_IO_FAILED = 1016,
            /// <summary>
            /// The system has attempted to load or restore a file into the registry, but the specified file is not in a registry file format.
            /// </summary>
            ERROR_NOT_REGISTRY_FILE = 1017,
            /// <summary>
            /// Illegal operation attempted on a registry key that has been marked for deletion.
            /// </summary>
            ERROR_KEY_DELETED = 1018,
            /// <summary>
            /// System could not allocate the required space in a registry log.
            /// </summary>
            ERROR_NO_LOG_SPACE = 1019,
            /// <summary>
            /// Cannot create a symbolic link in a registry key that already has subkeys or values.
            /// </summary>
            ERROR_KEY_HAS_CHILDREN = 1020,
            /// <summary>
            /// Cannot create a stable subkey under a volatile parent key.
            /// </summary>
            ERROR_CHILD_MUST_BE_VOLATILE = 1021,
            /// <summary>
            /// A notify change request is being completed and the information is not being returned in the caller's buffer. The caller now needs to enumerate the files to find the changes.
            /// </summary>
            ERROR_NOTIFY_ENUM_DIR = 1022,
            /// <summary>
            /// A stop control has been sent to a service that other running services are dependent on.
            /// </summary>
            ERROR_DEPENDENT_SERVICES_RUNNING = 1051,
            /// <summary>
            /// The requested control is not valid for this service.
            /// </summary>
            ERROR_INVALID_SERVICE_CONTROL = 1052,
            /// <summary>
            /// The service did not respond to the start or control request in a timely fashion.
            /// </summary>
            ERROR_SERVICE_REQUEST_TIMEOUT = 1053,
            /// <summary>
            /// A thread could not be created for the service.
            /// </summary>
            ERROR_SERVICE_NO_THREAD = 1054,
            /// <summary>
            /// The service database is locked.
            /// </summary>
            ERROR_SERVICE_DATABASE_LOCKED = 1055,
            /// <summary>
            /// An instance of the service is already running.
            /// </summary>
            ERROR_SERVICE_ALREADY_RUNNING = 1056,
            /// <summary>
            /// The account name is invalid or does not exist, or the password is invalid for the account name specified.
            /// </summary>
            ERROR_INVALID_SERVICE_ACCOUNT = 1057,
            /// <summary>
            /// The service cannot be started, either because it is disabled or because it has no enabled devices associated with it.
            /// </summary>
            ERROR_SERVICE_DISABLED = 1058,
            /// <summary>
            /// Circular service dependency was specified.
            /// </summary>
            ERROR_CIRCULAR_DEPENDENCY = 1059,
            /// <summary>
            /// The specified service does not exist as an installed service.
            /// </summary>
            ERROR_SERVICE_DOES_NOT_EXIST = 1060,
            /// <summary>
            /// The service cannot accept control messages at this time.
            /// </summary>
            ERROR_SERVICE_CANNOT_ACCEPT_CTRL = 1061,
            /// <summary>
            /// The service has not been started.
            /// </summary>
            ERROR_SERVICE_NOT_ACTIVE = 1062,
            /// <summary>
            /// The service process could not connect to the service controller.
            /// </summary>
            ERROR_FAILED_SERVICE_CONTROLLER_CONNECT = 1063,
            /// <summary>
            /// An exception occurred in the service when handling the control request.
            /// </summary>
            ERROR_EXCEPTION_IN_SERVICE = 1064,
            /// <summary>
            /// The database specified does not exist.
            /// </summary>
            ERROR_DATABASE_DOES_NOT_EXIST = 1065,
            /// <summary>
            /// The service has returned a service-specific error code.
            /// </summary>
            ERROR_SERVICE_SPECIFIC_ERROR = 1066,
            /// <summary>
            /// The process terminated unexpectedly.
            /// </summary>
            ERROR_PROCESS_ABORTED = 1067,
            /// <summary>
            /// The dependency service or group failed to start.
            /// </summary>
            ERROR_SERVICE_DEPENDENCY_FAIL = 1068,
            /// <summary>
            /// The service did not start due to a logon failure.
            /// </summary>
            ERROR_SERVICE_LOGON_FAILED = 1069,
            /// <summary>
            /// After starting, the service hung in a start-pending state.
            /// </summary>
            ERROR_SERVICE_START_HANG = 1070,
            /// <summary>
            /// The specified service database lock is invalid.
            /// </summary>
            ERROR_INVALID_SERVICE_LOCK = 1071,
            /// <summary>
            /// The specified service has been marked for deletion.
            /// </summary>
            ERROR_SERVICE_MARKED_FOR_DELETE = 1072,
            /// <summary>
            /// The specified service already exists.
            /// </summary>
            ERROR_SERVICE_EXISTS = 1073,
            /// <summary>
            /// The system is currently running with the last-known-good configuration.
            /// </summary>
            ERROR_ALREADY_RUNNING_LKG = 1074,
            /// <summary>
            /// The dependency service does not exist or has been marked for deletion.
            /// </summary>
            ERROR_SERVICE_DEPENDENCY_DELETED = 1075,
            /// <summary>
            /// The current boot has already been accepted for use as the last-known-good control set.
            /// </summary>
            ERROR_BOOT_ALREADY_ACCEPTED = 1076,
            /// <summary>
            /// No attempts to start the service have been made since the last boot.
            /// </summary>
            ERROR_SERVICE_NEVER_STARTED = 1077,
            /// <summary>
            /// The name is already in use as either a service name or a service display name.
            /// </summary>
            ERROR_DUPLICATE_SERVICE_NAME = 1078,
            /// <summary>
            /// The account specified for this service is different from the account specified for other services running in the same process.
            /// </summary>
            ERROR_DIFFERENT_SERVICE_ACCOUNT = 1079,
            /// <summary>
            /// Failure actions can only be set for Win32 services, not for drivers.
            /// </summary>
            ERROR_CANNOT_DETECT_DRIVER_FAILURE = 1080,
            /// <summary>
            /// This service runs in the same process as the service control manager.
            /// Therefore, the service control manager cannot take action if this service's process terminates unexpectedly.
            /// </summary>
            ERROR_CANNOT_DETECT_PROCESS_ABORT = 1081,
            /// <summary>
            /// No recovery program has been configured for this service.
            /// </summary>
            ERROR_NO_RECOVERY_PROGRAM = 1082,
            /// <summary>
            /// The executable program that this service is configured to run in does not implement the service.
            /// </summary>
            ERROR_SERVICE_NOT_IN_EXE = 1083,
            /// <summary>
            /// This service cannot be started in Safe Mode
            /// </summary>
            ERROR_NOT_SAFEBOOT_SERVICE = 1084,
            /// <summary>
            /// The physical end of the tape has been reached.
            /// </summary>
            ERROR_END_OF_MEDIA = 1100,
            /// <summary>
            /// A tape access reached a filemark.
            /// </summary>
            ERROR_FILEMARK_DETECTED = 1101,
            /// <summary>
            /// The beginning of the tape or a partition was encountered.
            /// </summary>
            ERROR_BEGINNING_OF_MEDIA = 1102,
            /// <summary>
            /// A tape access reached the end of a set of files.
            /// </summary>
            ERROR_SETMARK_DETECTED = 1103,
            /// <summary>
            /// No more data is on the tape.
            /// </summary>
            ERROR_NO_DATA_DETECTED = 1104,
            /// <summary>
            /// Tape could not be partitioned.
            /// </summary>
            ERROR_PARTITION_FAILURE = 1105,
            /// <summary>
            /// When accessing a new tape of a multivolume partition, the current block size is incorrect.
            /// </summary>
            ERROR_INVALID_BLOCK_LENGTH = 1106,
            /// <summary>
            /// Tape partition information could not be found when loading a tape.
            /// </summary>
            ERROR_DEVICE_NOT_PARTITIONED = 1107,
            /// <summary>
            /// Unable to lock the media eject mechanism.
            /// </summary>
            ERROR_UNABLE_TO_LOCK_MEDIA = 1108,
            /// <summary>
            /// Unable to unload the media.
            /// </summary>
            ERROR_UNABLE_TO_UNLOAD_MEDIA = 1109,
            /// <summary>
            /// The media in the drive may have changed.
            /// </summary>
            ERROR_MEDIA_CHANGED = 1110,
            /// <summary>
            /// The I/O bus was reset.
            /// </summary>
            ERROR_BUS_RESET = 1111,
            /// <summary>
            /// No media in drive.
            /// </summary>
            ERROR_NO_MEDIA_IN_DRIVE = 1112,
            /// <summary>
            /// No mapping for the Unicode character exists in the target multi-byte code page.
            /// </summary>
            ERROR_NO_UNICODE_TRANSLATION = 1113,
            /// <summary>
            /// A dynamic link library (DLL) initialization routine failed.
            /// </summary>
            ERROR_DLL_INIT_FAILED = 1114,
            /// <summary>
            /// A system shutdown is in progress.
            /// </summary>
            ERROR_SHUTDOWN_IN_PROGRESS = 1115,
            /// <summary>
            /// Unable to abort the system shutdown because no shutdown was in progress.
            /// </summary>
            ERROR_NO_SHUTDOWN_IN_PROGRESS = 1116,
            /// <summary>
            /// The request could not be performed because of an I/O device error.
            /// </summary>
            ERROR_IO_DEVICE = 1117,
            /// <summary>
            /// No serial device was successfully initialized. The serial driver will unload.
            /// </summary>
            ERROR_SERIAL_NO_DEVICE = 1118,
            /// <summary>
            /// Unable to open a device that was sharing an interrupt request (IRQ) with other devices. At least one other device that uses that IRQ was already opened.
            /// </summary>
            ERROR_IRQ_BUSY = 1119,
            /// <summary>
            /// A serial I/O operation was completed by another write to the serial port.
            /// (The IOCTL_SERIAL_XOFF_COUNTER reached zero.)
            /// </summary>
            ERROR_MORE_WRITES = 1120,
            /// <summary>
            /// A serial I/O operation completed because the timeout period expired.
            /// (The IOCTL_SERIAL_XOFF_COUNTER did not reach zero.)
            /// </summary>
            ERROR_COUNTER_TIMEOUT = 1121,
            /// <summary>
            /// No ID address mark was found on the floppy disk.
            /// </summary>
            ERROR_FLOPPY_ID_MARK_NOT_FOUND = 1122,
            /// <summary>
            /// Mismatch between the floppy disk sector ID field and the floppy disk controller track address.
            /// </summary>
            ERROR_FLOPPY_WRONG_CYLINDER = 1123,
            /// <summary>
            /// The floppy disk controller reported an error that is not recognized by the floppy disk driver.
            /// </summary>
            ERROR_FLOPPY_UNKNOWN_ERROR = 1124,
            /// <summary>
            /// The floppy disk controller returned inconsistent results in its registers.
            /// </summary>
            ERROR_FLOPPY_BAD_REGISTERS = 1125,
            /// <summary>
            /// While accessing the hard disk, a recalibrate operation failed, even after retries.
            /// </summary>
            ERROR_DISK_RECALIBRATE_FAILED = 1126,
            /// <summary>
            /// While accessing the hard disk, a disk operation failed even after retries.
            /// </summary>
            ERROR_DISK_OPERATION_FAILED = 1127,
            /// <summary>
            /// While accessing the hard disk, a disk controller reset was needed, but even that failed.
            /// </summary>
            ERROR_DISK_RESET_FAILED = 1128,
            /// <summary>
            /// Physical end of tape encountered.
            /// </summary>
            ERROR_EOM_OVERFLOW = 1129,
            /// <summary>
            /// Not enough server storage is available to process this command.
            /// </summary>
            ERROR_NOT_ENOUGH_SERVER_MEMORY = 1130,
            /// <summary>
            /// A potential deadlock condition has been detected.
            /// </summary>
            ERROR_POSSIBLE_DEADLOCK = 1131,
            /// <summary>
            /// The base address or the file offset specified does not have the proper alignment.
            /// </summary>
            ERROR_MAPPED_ALIGNMENT = 1132,
            /// <summary>
            /// An attempt to change the system power state was vetoed by another application or driver.
            /// </summary>
            ERROR_SET_POWER_STATE_VETOED = 1140,
            /// <summary>
            /// The system BIOS failed an attempt to change the system power state.
            /// </summary>
            ERROR_SET_POWER_STATE_FAILED = 1141,
            /// <summary>
            /// An attempt was made to create more links on a file than the file system supports.
            /// </summary>
            ERROR_TOO_MANY_LINKS = 1142,
            /// <summary>
            /// The specified program requires a newer version of Windows.
            /// </summary>
            ERROR_OLD_WIN_VERSION = 1150,
            /// <summary>
            /// The specified program is not a Windows or MS-DOS program.
            /// </summary>
            ERROR_APP_WRONG_OS = 1151,
            /// <summary>
            /// Cannot start more than one instance of the specified program.
            /// </summary>
            ERROR_SINGLE_INSTANCE_APP = 1152,
            /// <summary>
            /// The specified program was written for an earlier version of Windows.
            /// </summary>
            ERROR_RMODE_APP = 1153,
            /// <summary>
            /// One of the library files needed to run this application is damaged.
            /// </summary>
            ERROR_INVALID_DLL = 1154,
            /// <summary>
            /// No application is associated with the specified file for this operation.
            /// </summary>
            ERROR_NO_ASSOCIATION = 1155,
            /// <summary>
            /// An error occurred in sending the command to the application.
            /// </summary>
            ERROR_DDE_FAIL = 1156,
            /// <summary>
            /// One of the library files needed to run this application cannot be found.
            /// </summary>
            ERROR_DLL_NOT_FOUND = 1157,
            /// <summary>
            /// The current process has used all of its system allowance of handles for Window Manager objects.
            /// </summary>
            ERROR_NO_MORE_USER_HANDLES = 1158,
            /// <summary>
            /// The message can be used only with synchronous operations.
            /// </summary>
            ERROR_MESSAGE_SYNC_ONLY = 1159,
            /// <summary>
            /// The indicated source element has no media.
            /// </summary>
            ERROR_SOURCE_ELEMENT_EMPTY = 1160,
            /// <summary>
            /// The indicated destination element already contains media.
            /// </summary>
            ERROR_DESTINATION_ELEMENT_FULL = 1161,
            /// <summary>
            /// The indicated element does not exist.
            /// </summary>
            ERROR_ILLEGAL_ELEMENT_ADDRESS = 1162,
            /// <summary>
            /// The indicated element is part of a magazine that is not present.
            /// </summary>
            ERROR_MAGAZINE_NOT_PRESENT = 1163,
            /// <summary>
            /// The indicated device requires reinitialization due to hardware errors.
            /// </summary>
            ERROR_DEVICE_REINITIALIZATION_NEEDED = 1164,
            /// <summary>
            /// The device has indicated that cleaning is required before further operations are attempted.
            /// </summary>
            ERROR_DEVICE_REQUIRES_CLEANING = 1165,
            /// <summary>
            /// The device has indicated that its door is open.
            /// </summary>
            ERROR_DEVICE_DOOR_OPEN = 1166,
            /// <summary>
            /// The device is not connected.
            /// </summary>
            ERROR_DEVICE_NOT_CONNECTED = 1167,
            /// <summary>
            /// Element not found.
            /// </summary>
            ERROR_NOT_FOUND = 1168,
            /// <summary>
            /// There was no match for the specified key in the index.
            /// </summary>
            ERROR_NO_MATCH = 1169,
            /// <summary>
            /// The property set specified does not exist on the object.
            /// </summary>
            ERROR_SET_NOT_FOUND = 1170,
            /// <summary>
            /// The point passed to GetMouseMovePoints is not in the buffer.
            /// </summary>
            ERROR_POINT_NOT_FOUND = 1171,
            /// <summary>
            /// The tracking (workstation) service is not running.
            /// </summary>
            ERROR_NO_TRACKING_SERVICE = 1172,
            /// <summary>
            /// The Volume ID could not be found.
            /// </summary>
            ERROR_NO_VOLUME_ID = 1173,
            /// <summary>
            /// Unable to remove the file to be replaced.
            /// </summary>
            ERROR_UNABLE_TO_REMOVE_REPLACED = 1175,
            /// <summary>
            /// Unable to move the replacement file to the file to be replaced. The file to be replaced has retained its original name.
            /// </summary>
            ERROR_UNABLE_TO_MOVE_REPLACEMENT = 1176,
            /// <summary>
            /// Unable to move the replacement file to the file to be replaced. The file to be replaced has been renamed using the backup name.
            /// </summary>
            ERROR_UNABLE_TO_MOVE_REPLACEMENT_2 = 1177,
            /// <summary>
            /// The volume change journal is being deleted.
            /// </summary>
            ERROR_JOURNAL_DELETE_IN_PROGRESS = 1178,
            /// <summary>
            /// The volume change journal is not active.
            /// </summary>
            ERROR_JOURNAL_NOT_ACTIVE = 1179,
            /// <summary>
            /// A file was found, but it may not be the correct file.
            /// </summary>
            ERROR_POTENTIAL_FILE_FOUND = 1180,
            /// <summary>
            /// The journal entry has been deleted from the journal.
            /// </summary>
            ERROR_JOURNAL_ENTRY_DELETED = 1181,
            /// <summary>
            /// The specified device name is invalid.
            /// </summary>
            ERROR_BAD_DEVICE = 1200,
            /// <summary>
            /// The device is not currently connected but it is a remembered connection.
            /// </summary>
            ERROR_CONNECTION_UNAVAIL = 1201,
            /// <summary>
            /// The local device name has a remembered connection to another network resource.
            /// </summary>
            ERROR_DEVICE_ALREADY_REMEMBERED = 1202,
            /// <summary>
            /// No network provider accepted the given network path.
            /// </summary>
            ERROR_NO_NET_OR_BAD_PATH = 1203,
            /// <summary>
            /// The specified network provider name is invalid.
            /// </summary>
            ERROR_BAD_PROVIDER = 1204,
            /// <summary>
            /// Unable to open the network connection profile.
            /// </summary>
            ERROR_CANNOT_OPEN_PROFILE = 1205,
            /// <summary>
            /// The network connection profile is corrupted.
            /// </summary>
            ERROR_BAD_PROFILE = 1206,
            /// <summary>
            /// Cannot enumerate a noncontainer.
            /// </summary>
            ERROR_NOT_CONTAINER = 1207,
            /// <summary>
            /// An extended error has occurred.
            /// </summary>
            ERROR_EXTENDED_ERROR = 1208,
            /// <summary>
            /// The format of the specified group name is invalid.
            /// </summary>
            ERROR_INVALID_GROUPNAME = 1209,
            /// <summary>
            /// The format of the specified computer name is invalid.
            /// </summary>
            ERROR_INVALID_COMPUTERNAME = 1210,
            /// <summary>
            /// The format of the specified event name is invalid.
            /// </summary>
            ERROR_INVALID_EVENTNAME = 1211,
            /// <summary>
            /// The format of the specified domain name is invalid.
            /// </summary>
            ERROR_INVALID_DOMAINNAME = 1212,
            /// <summary>
            /// The format of the specified service name is invalid.
            /// </summary>
            ERROR_INVALID_SERVICENAME = 1213,
            /// <summary>
            /// The format of the specified network name is invalid.
            /// </summary>
            ERROR_INVALID_NETNAME = 1214,
            /// <summary>
            /// The format of the specified share name is invalid.
            /// </summary>
            ERROR_INVALID_SHARENAME = 1215,
            /// <summary>
            /// The format of the specified password is invalid.
            /// </summary>
            ERROR_INVALID_PASSUInt16NAME = 1216,
            /// <summary>
            /// The format of the specified message name is invalid.
            /// </summary>
            ERROR_INVALID_MESSAGENAME = 1217,
            /// <summary>
            /// The format of the specified message destination is invalid.
            /// </summary>
            ERROR_INVALID_MESSAGEDEST = 1218,
            /// <summary>
            /// Multiple connections to a server or shared resource by the same user, using more than one user name, are not allowed. Disconnect all previous connections to the server or shared resource and try again..
            /// </summary>
            ERROR_SESSION_CREDENTIAL_CONFLICT = 1219,
            /// <summary>
            /// An attempt was made to establish a session to a network server, but there are already too many sessions established to that server.
            /// </summary>
            ERROR_REMOTE_SESSION_LIMIT_EXCEEDED = 1220,
            /// <summary>
            /// The workgroup or domain name is already in use by another computer on the network.
            /// </summary>
            ERROR_DUP_DOMAINNAME = 1221,
            /// <summary>
            /// The network is not present or not started.
            /// </summary>
            ERROR_NO_NETWORK = 1222,
            /// <summary>
            /// The operation was canceled by the user.
            /// </summary>
            ERROR_CANCELLED = 1223,
            /// <summary>
            /// The requested operation cannot be performed on a file with a user-mapped section open.
            /// </summary>
            ERROR_USER_MAPPED_FILE = 1224,
            /// <summary>
            /// The remote system refused the network connection.
            /// </summary>
            ERROR_CONNECTION_REFUSED = 1225,
            /// <summary>
            /// The network connection was gracefully closed.
            /// </summary>
            ERROR_GRACEFUL_DISCONNECT = 1226,
            /// <summary>
            /// The network transport endpoint already has an address associated with it.
            /// </summary>
            ERROR_ADDRESS_ALREADY_ASSOCIATED = 1227,
            /// <summary>
            /// An address has not yet been associated with the network endpoint.
            /// </summary>
            ERROR_ADDRESS_NOT_ASSOCIATED = 1228,
            /// <summary>
            /// An operation was attempted on a nonexistent network connection.
            /// </summary>
            ERROR_CONNECTION_INVALID = 1229,
            /// <summary>
            /// An invalid operation was attempted on an active network connection.
            /// </summary>
            ERROR_CONNECTION_ACTIVE = 1230,
            /// <summary>
            /// The network location cannot be reached. For information about network troubleshooting, see Windows Help.
            /// </summary>
            ERROR_NETWORK_UNREACHABLE = 1231,
            /// <summary>
            /// The network location cannot be reached. For information about network troubleshooting, see Windows Help.
            /// </summary>
            ERROR_HOST_UNREACHABLE = 1232,
            /// <summary>
            /// The network location cannot be reached. For information about network troubleshooting, see Windows Help.
            /// </summary>
            ERROR_PROTOCOL_UNREACHABLE = 1233,
            /// <summary>
            /// No service is operating at the destination network endpoint on the remote system.
            /// </summary>
            ERROR_PORT_UNREACHABLE = 1234,
            /// <summary>
            /// The request was aborted.
            /// </summary>
            ERROR_REQUEST_ABORTED = 1235,
            /// <summary>
            /// The network connection was aborted by the local system.
            /// </summary>
            ERROR_CONNECTION_ABORTED = 1236,
            /// <summary>
            /// The operation could not be completed. A retry should be performed.
            /// </summary>
            ERROR_RETRY = 1237,
            /// <summary>
            /// A connection to the server could not be made because the limit on the number of concurrent connections for this account has been reached.
            /// </summary>
            ERROR_CONNECTION_COUNT_LIMIT = 1238,
            /// <summary>
            /// Attempting to log in during an unauthorized time of day for this account.
            /// </summary>
            ERROR_LOGIN_TIME_RESTRICTION = 1239,
            /// <summary>
            /// The account is not authorized to log in from this station.
            /// </summary>
            ERROR_LOGIN_WKSTA_RESTRICTION = 1240,
            /// <summary>
            /// The network address could not be used for the operation requested.
            /// </summary>
            ERROR_INCORRECT_ADDRESS = 1241,
            /// <summary>
            /// The service is already registered.
            /// </summary>
            ERROR_ALREADY_REGISTERED = 1242,
            /// <summary>
            /// The specified service does not exist.
            /// </summary>
            ERROR_SERVICE_NOT_FOUND = 1243,
            /// <summary>
            /// The operation being requested was not performed because the user has not been authenticated.
            /// </summary>
            ERROR_NOT_AUTHENTICATED = 1244,
            /// <summary>
            /// The operation being requested was not performed because the user has not logged on to the network.
            /// The specified service does not exist.
            /// </summary>
            ERROR_NOT_LOGGED_ON = 1245,
            /// <summary>
            /// Continue with work in progress.
            /// </summary>
            ERROR_CONTINUE = 1246,
            /// <summary>
            /// An attempt was made to perform an initialization operation when initialization has already been completed.
            /// </summary>
            ERROR_ALREADY_INITIALIZED = 1247,
            /// <summary>
            /// No more local devices.
            /// </summary>
            ERROR_NO_MORE_DEVICES = 1248,
            /// <summary>
            /// The specified site does not exist.
            /// </summary>
            ERROR_NO_SUCH_SITE = 1249,
            /// <summary>
            /// A domain controller with the specified name already exists.
            /// </summary>
            ERROR_DOMAIN_CONTROLLER_EXISTS = 1250,
            /// <summary>
            /// This operation is supported only when you are connected to the server.
            /// </summary>
            ERROR_ONLY_IF_CONNECTED = 1251,
            /// <summary>
            /// The group policy framework should call the extension even if there are no changes.
            /// </summary>
            ERROR_OVERRIDE_NOCHANGES = 1252,
            /// <summary>
            /// The specified user does not have a valid profile.
            /// </summary>
            ERROR_BAD_USER_PROFILE = 1253,
            /// <summary>
            /// This operation is not supported on a Microsoft Small Business Server
            /// </summary>
            ERROR_NOT_SUPPORTED_ON_SBS = 1254,
            /// <summary>
            /// The server machine is shutting down.
            /// </summary>
            ERROR_SERVER_SHUTDOWN_IN_PROGRESS = 1255,
            /// <summary>
            /// The remote system is not available. For information about network troubleshooting, see Windows Help.
            /// </summary>
            ERROR_HOST_DOWN = 1256,
            /// <summary>
            /// The security identifier provided is not from an account domain.
            /// </summary>
            ERROR_NON_ACCOUNT_SID = 1257,
            /// <summary>
            /// The security identifier provided does not have a domain component.
            /// </summary>
            ERROR_NON_DOMAIN_SID = 1258,
            /// <summary>
            /// AppHelp dialog canceled thus preventing the application from starting.
            /// </summary>
            ERROR_APPHELP_BLOCK = 1259,
            /// <summary>
            /// Windows cannot open this program because it has been prevented by a software restriction policy. For more information, open Event Viewer or contact your system administrator.
            /// </summary>
            ERROR_ACCESS_DISABLED_BY_POLICY = 1260,
            /// <summary>
            /// A program attempt to use an invalid register value.  Normally caused by an uninitialized register. This error is Itanium specific.
            /// </summary>
            ERROR_REG_NAT_CONSUMPTION = 1261,
            /// <summary>
            /// The share is currently offline or does not exist.
            /// </summary>
            ERROR_CSCSHARE_OFFLINE = 1262,
            /// <summary>
            /// The kerberos protocol encountered an error while validating the
            /// KDC certificate during smartcard logon.
            /// </summary>
            ERROR_PKINIT_FAILURE = 1263,
            /// <summary>
            /// The kerberos protocol encountered an error while attempting to utilize
            /// the smartcard subsystem.
            /// </summary>
            ERROR_SMARTCARD_SUBSYSTEM_FAILURE = 1264,
            /// <summary>
            /// The system detected a possible attempt to compromise security. Please ensure that you can contact the server that authenticated you.
            /// </summary>
            ERROR_DOWNGRADE_DETECTED = 1265,
            /// <summary>
            /// The machine is locked and can not be shut down without the force option.
            /// </summary>
            ERROR_MACHINE_LOCKED = 1271,
            /// <summary>
            /// An application-defined callback gave invalid data when called.
            /// </summary>
            ERROR_CALLBACK_SUPPLIED_INVALID_DATA = 1273,
            /// <summary>
            /// The group policy framework should call the extension in the synchronous foreground policy refresh.
            /// </summary>
            ERROR_SYNC_FOREGROUND_REFRESH_REQUIRED = 1274,
            /// <summary>
            /// This driver has been blocked from loading
            /// </summary>
            ERROR_DRIVER_BLOCKED = 1275,
            /// <summary>
            /// A dynamic link library (DLL) referenced a module that was neither a DLL nor the process's executable image.
            /// </summary>
            ERROR_INVALID_IMPORT_OF_NON_DLL = 1276,
            /// <summary>
            /// No information avialable.
            /// </summary>
            ERROR_ACCESS_DISABLED_WEBBLADE = 1277,
            /// <summary>
            /// No information avialable.
            /// </summary>
            ERROR_ACCESS_DISABLED_WEBBLADE_TAMPER = 1278,
            /// <summary>
            /// No information avialable.
            /// </summary>
            ERROR_RECOVERY_FAILURE = 1279,
            /// <summary>
            /// No information avialable.
            /// </summary>
            ERROR_ALREADY_FIBER = 1280,
            /// <summary>
            /// No information avialable.
            /// </summary>
            ERROR_ALREADY_THREAD = 1281,
            /// <summary>
            /// No information avialable.
            /// </summary>
            ERROR_STACK_BUFFER_OVERRUN = 1282,
            /// <summary>
            /// No information avialable.
            /// </summary>
            ERROR_PARAMETER_QUOTA_EXCEEDED = 1283,
            /// <summary>
            /// No information avialable.
            /// </summary>
            ERROR_DEBUGGER_INACTIVE = 1284,
            /// <summary>
            /// No information avialable.
            /// </summary>
            ERROR_DELAY_LOAD_FAILED = 1285,
            /// <summary>
            /// No information avialable.
            /// </summary>
            ERROR_VDM_DISALLOWED = 1286,
            /// <summary>
            /// Not all privileges referenced are assigned to the caller.
            /// </summary>
            ERROR_NOT_ALL_ASSIGNED = 1300,
            /// <summary>
            /// Some mapping between account names and security IDs was not done.
            /// </summary>
            ERROR_SOME_NOT_MAPPED = 1301,
            /// <summary>
            /// No system quota limits are specifically set for this account.
            /// </summary>
            ERROR_NO_QUOTAS_FOR_ACCOUNT = 1302,
            /// <summary>
            /// No encryption key is available. A well-known encryption key was returned.
            /// </summary>
            ERROR_LOCAL_USER_SESSION_KEY = 1303,
            /// <summary>
            /// The password is too complex to be converted to a LAN Manager password. The LAN Manager password returned is a NULL string.
            /// </summary>
            ERROR_NULL_LM_PASSUInt16 = 1304,
            /// <summary>
            /// The revision level is unknown.
            /// </summary>
            ERROR_UNKNOWN_REVISION = 1305,
            /// <summary>
            /// Indicates two revision levels are incompatible.
            /// </summary>
            ERROR_REVISION_MISMATCH = 1306,
            /// <summary>
            /// This security ID may not be assigned as the owner of this object.
            /// </summary>
            ERROR_INVALID_OWNER = 1307,
            /// <summary>
            /// This security ID may not be assigned as the primary group of an object.
            /// </summary>
            ERROR_INVALID_PRIMARY_GROUP = 1308,
            /// <summary>
            /// An attempt has been made to operate on an impersonation token by a thread that is not currently impersonating a client.
            /// </summary>
            ERROR_NO_IMPERSONATION_TOKEN = 1309,
            /// <summary>
            /// The group may not be disabled.
            /// </summary>
            ERROR_CANT_DISABLE_MANDATORY = 1310,
            /// <summary>
            /// There are currently no logon servers available to service the logon request.
            /// </summary>
            ERROR_NO_LOGON_SERVERS = 1311,
            /// <summary>
            /// A specified logon session does not exist. It may already have been terminated.
            /// </summary>
            ERROR_NO_SUCH_LOGON_SESSION = 1312,
            /// <summary>
            /// A specified privilege does not exist.
            /// </summary>
            ERROR_NO_SUCH_PRIVILEGE = 1313,
            /// <summary>
            /// A required privilege is not held by the client.
            /// </summary>
            ERROR_PRIVILEGE_NOT_HELD = 1314,
            /// <summary>
            /// The name provided is not a properly formed account name.
            /// </summary>
            ERROR_INVALID_ACCOUNT_NAME = 1315,
            /// <summary>
            /// The specified user already exists.
            /// </summary>
            ERROR_USER_EXISTS = 1316,
            /// <summary>
            /// The specified user does not exist.
            /// </summary>
            ERROR_NO_SUCH_USER = 1317,
            /// <summary>
            /// The specified group already exists.
            /// </summary>
            ERROR_GROUP_EXISTS = 1318,
            /// <summary>
            /// The specified group does not exist.
            /// </summary>
            ERROR_NO_SUCH_GROUP = 1319,
            /// <summary>
            /// Either the specified user account is already a member of the specified group, or the specified group cannot be deleted because it contains a member.
            /// </summary>
            ERROR_MEMBER_IN_GROUP = 1320,
            /// <summary>
            /// The specified user account is not a member of the specified group account.
            /// </summary>
            ERROR_MEMBER_NOT_IN_GROUP = 1321,
            /// <summary>
            /// The last remaining administration account cannot be disabled or deleted.
            /// </summary>
            ERROR_LAST_ADMIN = 1322,
            /// <summary>
            /// Unable to update the password. The value provided as the current password is incorrect.
            /// </summary>
            ERROR_WRONG_PASSWORD = 1323,
            /// <summary>
            /// Unable to update the password. The value provided for the new password contains values that are not allowed in passwords.
            /// </summary>
            ERROR_ILL_FORMED_PASSWORD = 1324,
            /// <summary>
            /// Unable to update the password. The value provided for the new password does not meet the length, complexity, or history requirement of the domain.
            /// </summary>
            ERROR_PASSWORD_RESTRICTION = 1325,
            /// <summary>
            /// Logon failure: unknown user name or bad password.
            /// </summary>
            ERROR_LOGON_FAILURE = 1326,
            /// <summary>
            /// Logon failure: user account restriction.  Possible reasons are blank passwords not allowed, logon hour restrictions, or a policy restriction has been enforced.
            /// </summary>
            ERROR_ACCOUNT_RESTRICTION = 1327,
            /// <summary>
            /// Logon failure: account logon time restriction violation.
            /// </summary>
            ERROR_INVALID_LOGON_HOURS = 1328,
            /// <summary>
            /// Logon failure: user not allowed to log on to this computer.
            /// </summary>
            ERROR_INVALID_WORKSTATION = 1329,
            /// <summary>
            /// Logon failure: the specified account password has expired.
            /// </summary>
            ERROR_PASSUInt16_EXPIRED = 1330,
            /// <summary>
            /// Logon failure: account currently disabled.
            /// </summary>
            ERROR_ACCOUNT_DISABLED = 1331,
            /// <summary>
            /// No mapping between account names and security IDs was done.
            /// </summary>
            ERROR_NONE_MAPPED = 1332,
            /// <summary>
            /// Too many local user identifiers (LUIDs) were requested at one time.
            /// </summary>
            ERROR_TOO_MANY_LUIDS_REQUESTED = 1333,
            /// <summary>
            /// No more local user identifiers (LUIDs) are available.
            /// </summary>
            ERROR_LUIDS_EXHAUSTED = 1334,
            /// <summary>
            /// The subauthority part of a security ID is invalid for this particular use.
            /// </summary>
            ERROR_INVALID_SUB_AUTHORITY = 1335,
            /// <summary>
            /// The access control list (ACL) structure is invalid.
            /// </summary>
            ERROR_INVALID_ACL = 1336,
            /// <summary>
            /// The security ID structure is invalid.
            /// </summary>
            ERROR_INVALID_SID = 1337,
            /// <summary>
            /// The security descriptor structure is invalid.
            /// </summary>
            ERROR_INVALID_SECURITY_DESCR = 1338,
            /// <summary>
            /// The inherited access control list (ACL) or access control entry (ACE) could not be built.
            /// </summary>
            ERROR_BAD_INHERITANCE_ACL = 1340,
            /// <summary>
            /// The server is currently disabled.
            /// </summary>
            ERROR_SERVER_DISABLED = 1341,
            /// <summary>
            /// The server is currently enabled.
            /// </summary>
            ERROR_SERVER_NOT_DISABLED = 1342,
            /// <summary>
            /// The value provided was an invalid value for an identifier authority.
            /// </summary>
            ERROR_INVALID_ID_AUTHORITY = 1343,
            /// <summary>
            /// No more memory is available for security information updates.
            /// </summary>
            ERROR_ALLOTTED_SPACE_EXCEEDED = 1344,
            /// <summary>
            /// The specified attributes are invalid, or incompatible with the attributes for the group as a whole.
            /// </summary>
            ERROR_INVALID_GROUP_ATTRIBUTES = 1345,
            /// <summary>
            /// Either a required impersonation level was not provided, or the provided impersonation level is invalid.
            /// </summary>
            ERROR_BAD_IMPERSONATION_LEVEL = 1346,
            /// <summary>
            /// Cannot open an anonymous level security token.
            /// </summary>
            ERROR_CANT_OPEN_ANONYMOUS = 1347,
            /// <summary>
            /// The validation information class requested was invalid.
            /// </summary>
            ERROR_BAD_VALIDATION_CLASS = 1348,
            /// <summary>
            /// The type of the token is inappropriate for its attempted use.
            /// </summary>
            ERROR_BAD_TOKEN_TYPE = 1349,
            /// <summary>
            /// Unable to perform a security operation on an object that has no associated security.
            /// </summary>
            ERROR_NO_SECURITY_ON_OBJECT = 1350,
            /// <summary>
            /// Configuration information could not be read from the domain controller, either because the machine is unavailable, or access has been denied.
            /// </summary>
            ERROR_CANT_ACCESS_DOMAIN_INFO = 1351,
            /// <summary>
            /// The security account manager (SAM) or local security authority (LSA) server was in the wrong state to perform the security operation.
            /// </summary>
            ERROR_INVALID_SERVER_STATE = 1352,
            /// <summary>
            /// The domain was in the wrong state to perform the security operation.
            /// </summary>
            ERROR_INVALID_DOMAIN_STATE = 1353,
            /// <summary>
            /// This operation is only allowed for the Primary Domain Controller of the domain.
            /// </summary>
            ERROR_INVALID_DOMAIN_ROLE = 1354,
            /// <summary>
            /// The specified domain either does not exist or could not be contacted.
            /// </summary>
            ERROR_NO_SUCH_DOMAIN = 1355,
            /// <summary>
            /// The specified domain already exists.
            /// </summary>
            ERROR_DOMAIN_EXISTS = 1356,
            /// <summary>
            /// An attempt was made to exceed the limit on the number of domains per server.
            /// </summary>
            ERROR_DOMAIN_LIMIT_EXCEEDED = 1357,
            /// <summary>
            /// Unable to complete the requested operation because of either a catastrophic media failure or a data structure corruption on the disk.
            /// </summary>
            ERROR_INTERNAL_DB_CORRUPTION = 1358,
            /// <summary>
            /// An internal error occurred.
            /// </summary>
            ERROR_INTERNAL_ERROR = 1359,
            /// <summary>
            /// Generic access types were contained in an access mask which should already be mapped to nongeneric types.
            /// </summary>
            ERROR_GENERIC_NOT_MAPPED = 1360,
            /// <summary>
            /// A security descriptor is not in the right format (absolute or self-relative).
            /// </summary>
            ERROR_BAD_DESCRIPTOR_FORMAT = 1361,
            /// <summary>
            /// The requested action is restricted for use by logon processes only. The calling process has not registered as a logon process.
            /// </summary>
            ERROR_NOT_LOGON_PROCESS = 1362,
            /// <summary>
            /// Cannot start a new logon session with an ID that is already in use.
            /// </summary>
            ERROR_LOGON_SESSION_EXISTS = 1363,
            /// <summary>
            /// A specified authentication package is unknown.
            /// </summary>
            ERROR_NO_SUCH_PACKAGE = 1364,
            /// <summary>
            /// The logon session is not in a state that is consistent with the requested operation.
            /// </summary>
            ERROR_BAD_LOGON_SESSION_STATE = 1365,
            /// <summary>
            /// The logon session ID is already in use.
            /// </summary>
            ERROR_LOGON_SESSION_COLLISION = 1366,
            /// <summary>
            /// A logon request contained an invalid logon type value.
            /// </summary>
            ERROR_INVALID_LOGON_TYPE = 1367,
            /// <summary>
            /// Unable to impersonate using a named pipe until data has been read from that pipe.
            /// </summary>
            ERROR_CANNOT_IMPERSONATE = 1368,
            /// <summary>
            /// The transaction state of a registry subtree is incompatible with the requested operation.
            /// </summary>
            ERROR_RXACT_INVALID_STATE = 1369,
            /// <summary>
            /// An internal security database corruption has been encountered.
            /// </summary>
            ERROR_RXACT_COMMIT_FAILURE = 1370,
            /// <summary>
            /// Cannot perform this operation on built-in accounts.
            /// </summary>
            ERROR_SPECIAL_ACCOUNT = 1371,
            /// <summary>
            /// Cannot perform this operation on this built-in special group.
            /// </summary>
            ERROR_SPECIAL_GROUP = 1372,
            /// <summary>
            /// Cannot perform this operation on this built-in special user.
            /// </summary>
            ERROR_SPECIAL_USER = 1373,
            /// <summary>
            /// The user cannot be removed from a group because the group is currently the user's primary group.
            /// </summary>
            ERROR_MEMBERS_PRIMARY_GROUP = 1374,
            /// <summary>
            /// The token is already in use as a primary token.
            /// </summary>
            ERROR_TOKEN_ALREADY_IN_USE = 1375,
            /// <summary>
            /// The specified local group does not exist.
            /// </summary>
            ERROR_NO_SUCH_ALIAS = 1376,
            /// <summary>
            /// The specified account name is not a member of the local group.
            /// </summary>
            ERROR_MEMBER_NOT_IN_ALIAS = 1377,
            /// <summary>
            /// The specified account name is already a member of the local group.
            /// </summary>
            ERROR_MEMBER_IN_ALIAS = 1378,
            /// <summary>
            /// The specified local group already exists.
            /// </summary>
            ERROR_ALIAS_EXISTS = 1379,
            /// <summary>
            /// Logon failure: the user has not been granted the requested logon type at this computer.
            /// </summary>
            ERROR_LOGON_NOT_GRANTED = 1380,
            /// <summary>
            /// The maximum number of secrets that may be stored in a single system has been exceeded.
            /// </summary>
            ERROR_TOO_MANY_SECRETS = 1381,
            /// <summary>
            /// The length of a secret exceeds the maximum length allowed.
            /// </summary>
            ERROR_SECRET_TOO_Int32 = 1382,
            /// <summary>
            /// The local security authority database contains an internal inconsistency.
            /// </summary>
            ERROR_INTERNAL_DB_ERROR = 1383,
            /// <summary>
            /// During a logon attempt, the user's security context accumulated too many security IDs.
            /// </summary>
            ERROR_TOO_MANY_CONTEXT_IDS = 1384,
            /// <summary>
            /// Logon failure: the user has not been granted the requested logon type at this computer.
            /// </summary>
            ERROR_LOGON_TYPE_NOT_GRANTED = 1385,
            /// <summary>
            /// A cross-encrypted password is necessary to change a user password.
            /// </summary>
            ERROR_NT_CROSS_ENCRYPTION_REQUIRED = 1386,
            /// <summary>
            /// A member could not be added to or removed from the local group because the member does not exist.
            /// </summary>
            ERROR_NO_SUCH_MEMBER = 1387,
            /// <summary>
            /// A new member could not be added to a local group because the member has the wrong account type.
            /// </summary>
            ERROR_INVALID_MEMBER = 1388,
            /// <summary>
            /// Too many security IDs have been specified.
            /// </summary>
            ERROR_TOO_MANY_SIDS = 1389,
            /// <summary>
            /// A cross-encrypted password is necessary to change this user password.
            /// </summary>
            ERROR_LM_CROSS_ENCRYPTION_REQUIRED = 1390,
            /// <summary>
            /// Indicates an ACL contains no inheritable components.
            /// </summary>
            ERROR_NO_INHERITANCE = 1391,
            /// <summary>
            /// The file or directory is corrupted and unreadable.
            /// </summary>
            ERROR_FILE_CORRUPT = 1392,
            /// <summary>
            /// The disk structure is corrupted and unreadable.
            /// </summary>
            ERROR_DISK_CORRUPT = 1393,
            /// <summary>
            /// There is no user session key for the specified logon session.
            /// </summary>
            ERROR_NO_USER_SESSION_KEY = 1394,
            /// <summary>
            /// The service being accessed is licensed for a particular number of connections.
            /// No more connections can be made to the service at this time because there are already as many connections as the service can accept.
            /// </summary>
            ERROR_LICENSE_QUOTA_EXCEEDED = 1395,
            /// <summary>
            /// Logon Failure: The target account name is incorrect.
            /// </summary>
            ERROR_WRONG_TARGET_NAME = 1396,
            /// <summary>
            /// Mutual Authentication failed. The server's password is out of date at the domain controller.
            /// </summary>
            ERROR_MUTUAL_AUTH_FAILED = 1397,
            /// <summary>
            /// There is a time and/or date difference between the client and server.
            /// </summary>
            ERROR_TIME_SKEW = 1398,
            /// <summary>
            /// This operation can not be performed on the current domain.
            /// </summary>
            ERROR_CURRENT_DOMAIN_NOT_ALLOWED = 1399,
            /// <summary>
            /// Invalid window handle.
            /// </summary>
            ERROR_INVALID_WINDOW_HANDLE = 1400,
            /// <summary>
            /// Invalid menu handle.
            /// </summary>
            ERROR_INVALID_MENU_HANDLE = 1401,
            /// <summary>
            /// Invalid cursor handle.
            /// </summary>
            ERROR_INVALID_CURSOR_HANDLE = 1402,
            /// <summary>
            /// Invalid accelerator table handle.
            /// </summary>
            ERROR_INVALID_ACCEL_HANDLE = 1403,
            /// <summary>
            /// Invalid hook handle.
            /// </summary>
            ERROR_INVALID_HOOK_HANDLE = 1404,
            /// <summary>
            /// Invalid handle to a multiple-window position structure.
            /// </summary>
            ERROR_INVALID_DWP_HANDLE = 1405,
            /// <summary>
            /// Cannot create a top-level child window.
            /// </summary>
            ERROR_TLW_WITH_WSCHILD = 1406,
            /// <summary>
            /// Cannot find window class.
            /// </summary>
            ERROR_CANNOT_FIND_WND_CLASS = 1407,
            /// <summary>
            /// Invalid window, it belongs to other thread.
            /// </summary>
            ERROR_WINDOW_OF_OTHER_THREAD = 1408,
            /// <summary>
            /// Hot key is already registered.
            /// </summary>
            ERROR_HOTKEY_ALREADY_REGISTERED = 1409,
            /// <summary>
            /// Class already exists.
            /// </summary>
            ERROR_CLASS_ALREADY_EXISTS = 1410,
            /// <summary>
            /// Class does not exist.
            /// </summary>
            ERROR_CLASS_DOES_NOT_EXIST = 1411,
            /// <summary>
            /// Class still has open windows.
            /// </summary>
            ERROR_CLASS_HAS_WINDOWS = 1412,
            /// <summary>
            /// Invalid index.
            /// </summary>
            ERROR_INVALID_INDEX = 1413,
            /// <summary>
            /// Invalid icon handle.
            /// </summary>
            ERROR_INVALID_ICON_HANDLE = 1414,
            /// <summary>
            /// Using private DIALOG window words.
            /// </summary>
            ERROR_PRIVATE_DIALOG_INDEX = 1415,
            /// <summary>
            /// The list box identifier was not found.
            /// </summary>
            ERROR_LISTBOX_ID_NOT_FOUND = 1416,
            /// <summary>
            /// No wildcards were found.
            /// </summary>
            ERROR_NO_WILDCARD_CHARACTERS = 1417,
            /// <summary>
            /// Thread does not have a clipboard open.
            /// </summary>
            ERROR_CLIPBOARD_NOT_OPEN = 1418,
            /// <summary>
            /// Hot key is not registered.
            /// </summary>
            ERROR_HOTKEY_NOT_REGISTERED = 1419,
            /// <summary>
            /// The window is not a valid dialog window.
            /// </summary>
            ERROR_WINDOW_NOT_DIALOG = 1420,
            /// <summary>
            /// Control ID not found.
            /// </summary>
            ERROR_CONTROL_ID_NOT_FOUND = 1421,
            /// <summary>
            /// Invalid message for a combo box because it does not have an edit control.
            /// </summary>
            ERROR_INVALID_COMBOBOX_MESSAGE = 1422,
            /// <summary>
            /// The window is not a combo box.
            /// </summary>
            ERROR_WINDOW_NOT_COMBOBOX = 1423,
            /// <summary>
            /// Height must be less than 256.
            /// </summary>
            ERROR_INVALID_EDIT_HEIGHT = 1424,
            /// <summary>
            /// Invalid device context (DC) handle.
            /// </summary>
            ERROR_DC_NOT_FOUND = 1425,
            /// <summary>
            /// Invalid hook procedure type.
            /// </summary>
            ERROR_INVALID_HOOK_FILTER = 1426,
            /// <summary>
            /// Invalid hook procedure.
            /// </summary>
            ERROR_INVALID_FILTER_PROC = 1427,
            /// <summary>
            /// Cannot set nonlocal hook without a module handle.
            /// </summary>
            ERROR_HOOK_NEEDS_HMOD = 1428,
            /// <summary>
            /// This hook procedure can only be set globally.
            /// </summary>
            ERROR_GLOBAL_ONLY_HOOK = 1429,
            /// <summary>
            /// The journal hook procedure is already installed.
            /// </summary>
            ERROR_JOURNAL_HOOK_SET = 1430,
            /// <summary>
            /// The hook procedure is not installed.
            /// </summary>
            ERROR_HOOK_NOT_INSTALLED = 1431,
            /// <summary>
            /// Invalid message for single-selection list box.
            /// </summary>
            ERROR_INVALID_LB_MESSAGE = 1432,
            /// <summary>
            /// LB_SETCOUNT sent to non-lazy list box.
            /// </summary>
            ERROR_SETCOUNT_ON_BAD_LB = 1433,
            /// <summary>
            /// This list box does not support tab stops.
            /// </summary>
            ERROR_LB_WITHOUT_TABSTOPS = 1434,
            /// <summary>
            /// Cannot destroy object created by another thread.
            /// </summary>
            ERROR_DESTROY_OBJECT_OF_OTHER_THREAD = 1435,
            /// <summary>
            /// Child windows cannot have menus.
            /// </summary>
            ERROR_CHILD_WINDOW_MENU = 1436,
            /// <summary>
            /// The window does not have a system menu.
            /// </summary>
            ERROR_NO_SYSTEM_MENU = 1437,
            /// <summary>
            /// Invalid message box style.
            /// </summary>
            ERROR_INVALID_MSGBOX_STYLE = 1438,
            /// <summary>
            /// Invalid system-wide (SPI_*) parameter.
            /// </summary>
            ERROR_INVALID_SPI_VALUE = 1439,
            /// <summary>
            /// Screen already locked.
            /// </summary>
            ERROR_SCREEN_ALREADY_LOCKED = 1440,
            /// <summary>
            /// All handles to windows in a multiple-window position structure must have the same parent.
            /// </summary>
            ERROR_HWNDS_HAVE_DIFF_PARENT = 1441,
            /// <summary>
            /// The window is not a child window.
            /// </summary>
            ERROR_NOT_CHILD_WINDOW = 1442,
            /// <summary>
            /// Invalid GW_* command.
            /// </summary>
            ERROR_INVALID_GW_COMMAND = 1443,
            /// <summary>
            /// Invalid thread identifier.
            /// </summary>
            ERROR_INVALID_THREAD_ID = 1444,
            /// <summary>
            /// Cannot process a message from a window that is not a multiple document interface (MDI) window.
            /// </summary>
            ERROR_NON_MDICHILD_WINDOW = 1445,
            /// <summary>
            /// Popup menu already active.
            /// </summary>
            ERROR_POPUP_ALREADY_ACTIVE = 1446,
            /// <summary>
            /// The window does not have scroll bars.
            /// </summary>
            ERROR_NO_SCROLLBARS = 1447,
            /// <summary>
            /// Scroll bar range cannot be greater than MAXLONG.
            /// </summary>
            ERROR_INVALID_SCROLLBAR_RANGE = 1448,
            /// <summary>
            /// Cannot show or remove the window in the way specified.
            /// </summary>
            ERROR_INVALID_SHOWWIN_COMMAND = 1449,
            /// <summary>
            /// Insufficient system resources exist to complete the requested service.
            /// </summary>
            ERROR_NO_SYSTEM_RESOURCES = 1450,
            /// <summary>
            /// Insufficient system resources exist to complete the requested service.
            /// </summary>
            ERROR_NONPAGED_SYSTEM_RESOURCES = 1451,
            /// <summary>
            /// Insufficient system resources exist to complete the requested service.
            /// </summary>
            ERROR_PAGED_SYSTEM_RESOURCES = 1452,
            /// <summary>
            /// Insufficient quota to complete the requested service.
            /// </summary>
            ERROR_WORKING_SET_QUOTA = 1453,
            /// <summary>
            /// Insufficient quota to complete the requested service.
            /// </summary>
            ERROR_PAGEFILE_QUOTA = 1454,
            /// <summary>
            /// The paging file is too small for this operation to complete.
            /// </summary>
            ERROR_COMMITMENT_LIMIT = 1455,
            /// <summary>
            /// A menu item was not found.
            /// </summary>
            ERROR_MENU_ITEM_NOT_FOUND = 1456,
            /// <summary>
            /// Invalid keyboard layout handle.
            /// </summary>
            ERROR_INVALID_KEYBOARD_HANDLE = 1457,
            /// <summary>
            /// Hook type not allowed.
            /// </summary>
            ERROR_HOOK_TYPE_NOT_ALLOWED = 1458,
            /// <summary>
            /// This operation requires an interactive window station.
            /// </summary>
            ERROR_REQUIRES_INTERACTIVE_WINDOWSTATION = 1459,
            /// <summary>
            /// This operation returned because the timeout period expired.
            /// </summary>
            ERROR_TIMEOUT = 1460,
            /// <summary>
            /// Invalid monitor handle.
            /// </summary>
            ERROR_INVALID_MONITOR_HANDLE = 1461,
            /// <summary>
            /// The event log file is corrupted.
            /// </summary>
            ERROR_EVENTLOG_FILE_CORRUPT = 1500,
            /// <summary>
            /// No event log file could be opened, so the event logging service did not start.
            /// </summary>
            ERROR_EVENTLOG_CANT_START = 1501,
            /// <summary>
            /// The event log file is full.
            /// </summary>
            ERROR_LOG_FILE_FULL = 1502,
            /// <summary>
            /// The event log file has changed between read operations.
            /// </summary>
            ERROR_EVENTLOG_FILE_CHANGED = 1503,
            /// <summary>
            /// The Windows Installer Service could not be accessed. This can occur if you are running Windows in safe mode, or if the Windows Installer is not correctly installed. Contact your support personnel for assistance.
            /// </summary>
            ERROR_INSTALL_SERVICE_FAILURE = 1601,
            /// <summary>
            /// User cancelled installation.
            /// </summary>
            ERROR_INSTALL_USEREXIT = 1602,
            /// <summary>
            /// Fatal error during installation.
            /// </summary>
            ERROR_INSTALL_FAILURE = 1603,
            /// <summary>
            /// Installation suspended, incomplete.
            /// </summary>
            ERROR_INSTALL_SUSPEND = 1604,
            /// <summary>
            /// This action is only valid for products that are currently installed.
            /// </summary>
            ERROR_UNKNOWN_PRODUCT = 1605,
            /// <summary>
            /// Feature ID not registered.
            /// </summary>
            ERROR_UNKNOWN_FEATURE = 1606,
            /// <summary>
            /// Component ID not registered.
            /// </summary>
            ERROR_UNKNOWN_COMPONENT = 1607,
            /// <summary>
            /// Unknown property.
            /// </summary>
            ERROR_UNKNOWN_PROPERTY = 1608,
            /// <summary>
            /// Handle is in an invalid state.
            /// </summary>
            ERROR_INVALID_HANDLE_STATE = 1609,
            /// <summary>
            /// The configuration data for this product is corrupt.  Contact your support personnel.
            /// </summary>
            ERROR_BAD_CONFIGURATION = 1610,
            /// <summary>
            /// Component qualifier not present.
            /// </summary>
            ERROR_INDEX_ABSENT = 1611,
            /// <summary>
            /// The installation source for this product is not available.  Verify that the source exists and that you can access it.
            /// </summary>
            ERROR_INSTALL_SOURCE_ABSENT = 1612,
            /// <summary>
            /// This installation package cannot be installed by the Windows Installer service.  You must install a Windows service pack that contains a newer version of the Windows Installer service.
            /// </summary>
            ERROR_INSTALL_PACKAGE_VERSION = 1613,
            /// <summary>
            /// Product is uninstalled.
            /// </summary>
            ERROR_PRODUCT_UNINSTALLED = 1614,
            /// <summary>
            /// SQL query syntax invalid or unsupported.
            /// </summary>
            ERROR_BAD_QUERY_SYNTAX = 1615,
            /// <summary>
            /// Record field does not exist.
            /// </summary>
            ERROR_INVALID_FIELD = 1616,
            /// <summary>
            /// The device has been removed.
            /// </summary>
            ERROR_DEVICE_REMOVED = 1617,
            /// <summary>
            /// Another installation is already in progress.  Complete that installation before proceeding with this install.
            /// </summary>
            ERROR_INSTALL_ALREADY_RUNNING = 1618,
            /// <summary>
            /// This installation package could not be opened.  Verify that the package exists and that you can access it, or contact the application vendor to verify that this is a valid Windows Installer package.
            /// </summary>
            ERROR_INSTALL_PACKAGE_OPEN_FAILED = 1619,
            /// <summary>
            /// This installation package could not be opened.  Contact the application vendor to verify that this is a valid Windows Installer package.
            /// </summary>
            ERROR_INSTALL_PACKAGE_INVALID = 1620,
            /// <summary>
            /// There was an error starting the Windows Installer service user interface.  Contact your support personnel.
            /// </summary>
            ERROR_INSTALL_UI_FAILURE = 1621,
            /// <summary>
            /// Error opening installation log file. Verify that the specified log file location exists and that you can write to it.
            /// </summary>
            ERROR_INSTALL_LOG_FAILURE = 1622,
            /// <summary>
            /// The language of this installation package is not supported by your system.
            /// </summary>
            ERROR_INSTALL_LANGUAGE_UNSUPPORTED = 1623,
            /// <summary>
            /// Error applying transforms.  Verify that the specified transform paths are valid.
            /// </summary>
            ERROR_INSTALL_TRANSFORM_FAILURE = 1624,
            /// <summary>
            /// This installation is forbidden by system policy.  Contact your system administrator.
            /// </summary>
            ERROR_INSTALL_PACKAGE_REJECTED = 1625,
            /// <summary>
            /// Function could not be executed.
            /// </summary>
            ERROR_FUNCTION_NOT_CALLED = 1626,
            /// <summary>
            /// Function failed during execution.
            /// </summary>
            ERROR_FUNCTION_FAILED = 1627,
            /// <summary>
            /// Invalid or unknown table specified.
            /// </summary>
            ERROR_INVALID_TABLE = 1628,
            /// <summary>
            /// Data supplied is of wrong type.
            /// </summary>
            ERROR_DATATYPE_MISMATCH = 1629,
            /// <summary>
            /// Data of this type is not supported.
            /// </summary>
            ERROR_UNSUPPORTED_TYPE = 1630,
            /// <summary>
            /// The Windows Installer service failed to start.  Contact your support personnel.
            /// </summary>
            ERROR_CREATE_FAILED = 1631,
            /// <summary>
            /// The Temp folder is on a drive that is full or is inaccessible. Free up space on the drive or verify that you have write permission on the Temp folder.
            /// </summary>
            ERROR_INSTALL_TEMP_UNWRITABLE = 1632,
            /// <summary>
            /// This installation package is not supported by this processor type. Contact your product vendor.
            /// </summary>
            ERROR_INSTALL_PLATFORM_UNSUPPORTED = 1633,
            /// <summary>
            /// Component not used on this computer.
            /// </summary>
            ERROR_INSTALL_NOTUSED = 1634,
            /// <summary>
            /// This patch package could not be opened.  Verify that the patch package exists and that you can access it, or contact the application vendor to verify that this is a valid Windows Installer patch package.
            /// </summary>
            ERROR_PATCH_PACKAGE_OPEN_FAILED = 1635,
            /// <summary>
            /// This patch package could not be opened.  Contact the application vendor to verify that this is a valid Windows Installer patch package.
            /// </summary>
            ERROR_PATCH_PACKAGE_INVALID = 1636,
            /// <summary>
            /// This patch package cannot be processed by the Windows Installer service.  You must install a Windows service pack that contains a newer version of the Windows Installer service.
            /// </summary>
            ERROR_PATCH_PACKAGE_UNSUPPORTED = 1637,
            /// <summary>
            /// Another version of this product is already installed.  Installation of this version cannot continue.  To configure or remove the existing version of this product, use Add/Remove Programs on the Control Panel.
            /// </summary>
            ERROR_PRODUCT_VERSION = 1638,
            /// <summary>
            /// Invalid command line argument.  Consult the Windows Installer SDK for detailed command line help.
            /// </summary>
            ERROR_INVALID_COMMAND_LINE = 1639,
            /// <summary>
            /// Only administrators have permission to add, remove, or configure server software during a Terminal services remote session. If you want to install or configure software on the server, contact your network administrator.
            /// </summary>
            ERROR_INSTALL_REMOTE_DISALLOWED = 1640,
            /// <summary>
            /// The requested operation completed successfully.  The system will be restarted so the changes can take effect.
            /// </summary>
            ERROR_SUCCESS_REBOOT_INITIATED = 1641,
            /// <summary>
            /// The upgrade patch cannot be installed by the Windows Installer service because the program to be upgraded may be missing, or the upgrade patch may update a different version of the program. Verify that the program to be upgraded exists on your computer an
            /// d that you have the correct upgrade patch.
            /// </summary>
            ERROR_PATCH_TARGET_NOT_FOUND = 1642,
            /// <summary>
            /// The patch package is not permitted by software restriction policy.
            /// </summary>
            ERROR_PATCH_PACKAGE_REJECTED = 1643,
            /// <summary>
            /// One or more customizations are not permitted by software restriction policy.
            /// </summary>
            ERROR_INSTALL_TRANSFORM_REJECTED = 1644,
            /// <summary>
            /// No information avialable.
            /// </summary>
            ERROR_INSTALL_REMOTE_PROHIBITED = 1645

        }

        /// <summary>
        /// Enumerator for SetLastErrorEx(int ErrorCode, enum ErrorType) - Parameter ErrorType
        /// </summary>
        /// <remarks>
        /// ! NOTE ! this is in new Windows 10 SDK OS-Build 18362 - 19H1 - 2019
        /// before this OS, the Error-Type is ignore!
        /// 
        /// TIPPOINFO:
        /// At new in Visual Studio programming on 64BIT Datatypen  by 64BIT!
        /// Make Message, pass on your Datatypen!
        /// 
        /// The only one out is IntPtr = Integral Pointer make it automatic.
        /// IntPtr is a Pointer with very correctness Pointer Value.
        /// 
        /// IntPtr for Windows Handles (better use Microsoft.Win32.SafeHandles)
        /// </remarks>
        internal enum SLE : int
        {
            /// <summary>
            /// Type is Error
            /// </summary>
            SLE_ERROR = 0x00000001,

            /// <summary>
            /// Type is Minor Error
            /// </summary>
            SLE_MINORERROR = 0x00000002,

            /// <summary>
            ///  Type is Warning
            /// </summary>
            SLE_WARNING = 0x00000003
        }

        ///-------------------------------------------------
        /// GetVolumeInformation
        ///
        ///
        ///
        ///-------------------------------------------------
        [Flags]
        public enum FileSystemFeature : uint
        {
            /// <summary>
            /// The file system supports case-sensitive file names.
            /// </summary>
            CaseSensitiveSearch = 1,
            /// <summary>
            /// The file system preserves the case of file names when it places a name on disk.
            /// </summary>
            CasePreservedNames = 2,
            /// <summary>
            /// The file system supports Unicode in file names as they appear on disk.
            /// </summary>
            UnicodeOnDisk = 4,
            /// <summary>
            /// The file system preserves and enforces access control lists (ACL).
            /// </summary>
            PersistentACLS = 8,
            /// <summary>
            /// The file system supports file-based compression.
            /// </summary>
            FileCompression = 0x10,
            /// <summary>
            /// The file system supports disk quotas.
            /// </summary>
            VolumeQuotas = 0x20,
            /// <summary>
            /// The file system supports sparse files.
            /// </summary>
            SupportsSparseFiles = 0x40,
            /// <summary>
            /// The file system supports re-parse points.
            /// </summary>
            SupportsReparsePoints = 0x80,
            /// <summary>
            /// The specified volume is a compressed volume, for example, a DoubleSpace volume.
            /// </summary>
            VolumeIsCompressed = 0x8000,
            /// <summary>
            /// The file system supports object identifiers.
            /// </summary>
            SupportsObjectIDs = 0x10000,
            /// <summary>
            /// The file system supports the Encrypted File System (EFS).
            /// </summary>
            SupportsEncryption = 0x20000,
            /// <summary>
            /// The file system supports named streams.
            /// </summary>
            NamedStreams = 0x40000,
            /// <summary>
            /// The specified volume is read-only.
            /// </summary>
            ReadOnlyVolume = 0x80000,
            /// <summary>
            /// The volume supports a single sequential write.
            /// </summary>
            SequentialWriteOnce = 0x100000,
            /// <summary>
            /// The volume supports transactions.
            /// </summary>
            SupportsTransactions = 0x200000,
        }

        /// <summary>
        /// Shutdown Flags for ExitWindowsEx.
        /// </summary>
        /// <!-- Author TIPPO -->
        /// 
        /// <!-- Author TIPPO -->
        /// <remarks>
        /// New Flags ! Microsoft Windows Engineers Info:
        /// _When_((uFlags&(EWX_POWEROFF|EWX_SHUTDOWN|EWX_FORCE))!=0,
        /// __drv_preferredFunction("InitiateSystemShutdownEx",
        /// "Legacy API. Rearchitect to avoid Reboot"))
        /// WINUSERAPI
        /// BOOL
        /// WINAPI
        /// ExitWindowsEx(_In_ UINT uFlags, _In_ DWORD dwReason);
        /// </remarks>
        internal enum EWX_SHUTDOWN_FLAGS
        {
            /// <summary>
            /// 
            /// </summary>
            EWX_LOGOFF              = 0x00000000,
            EWX_SHUTDOWN            = 0x00000001,
            EWX_REBOOT              = 0x00000002,
            EWX_FORCE               = 0x00000004,
            EWX_POWEROFF            = 0x00000008,
            EWX_FORCEIFHUNG         = 0x00000010,
            EWX_HYBRID_SHUTDOWN     = 0x00400000,
            // NEW ! Flag
            EWX_QUICKRESOLVE        = 0x00000020, 
            // Windows give Function for registered Application into System,
            // RegisterApplicationWindows(string AppName);
            // after reboot, Windows start the Application.
            // NEW ! Flag
            EWX_RESTARTAPPS         = 0x00000040, 
            // NEW ! Flag
            EWX_BOOTOPTIONS         = 0x01000000,
            // NEW ! Windows 10 SDK 19546.0
            // NEW ! Flag ! NOTE: Windows 10 - 2020 - Build 19551.1005
            EWX_CHECK_SAFE_FOR_SERVER = 0x08000000

        }



        internal enum SECURITY_INFORMATION
        {
            OWNER_SECURITY_INFORMATION = 0x01,
            GROUP_SECURITY_INFORMATION = 0x02,
            DACL_SECURITY_INFORMATION = 0x04,
            SACL_SECURITY_INFORMATION = 0x08
        }

        [StructLayout(LayoutKind.Sequential)]
        internal class SECURITY_ATTRIBUTES
        {
            internal int nLength;

            internal unsafe byte* pSecurityDescriptor = null;

            internal int bInheritHandle;
        }


        [StructLayout(LayoutKind.Sequential)]
        internal class TokenPrivileges
        {
            public int PrivilegeCount = 1;

            public LUID Luid;

            public int Attributes;
        }


        [StructLayout(LayoutKind.Sequential)]
        internal class VS_FIXEDFILEINFO
        {
            public int dwSignature;

            public int dwStructVersion;

            public int dwFileVersionMS;

            public int dwFileVersionLS;

            public int dwProductVersionMS;

            public int dwProductVersionLS;

            public int dwFileFlagsMask;

            public int dwFileFlags;

            public int dwFileOS;

            public int dwFileType;

            public int dwFileSubtype;

            public int dwFileDateMS;

            public int dwFileDateLS;
        }






        #endregion




        // same Windows System Structures
        #region ### Windows Operation System - Structures ###

        /*-------------------------------------------------------------
         * Standard for all Structs are .Sequential!
         * Different to C++ in C# is the storage byte for structs,
         * C# structs never be null/0, are no members everytime 1 byte.
         * storage byte for managed the struct in C#.
         */

        /*
                internal struct SID
                {
                    byte Revision;
                    byte SubAuthorityCount;
                    SID_IDENTIFIER_AUTHORITY IdentifierAuthority;
                    IntPtr SubAuthority[];
                    uint SubAuthority[ANYSIZE_ARRAY];
                }
                */

        internal struct SID_IDENTIFIER_AUTHORITY
        {
            public byte[] Value;
        }
        

        /// <summary>
        /// Structure Point
        /// </summary>
        internal struct Point
        {
            /// <summary>
            /// 
            /// </summary>
            public int X;
            /// <summary>
            /// 
            /// </summary>
            public int Y;
        }

        /// <summary>
        /// Structure SystemTime
        /// 
        /// Call GetSystemTime() is System Time Clock
        /// 
        /// and
        /// Your Culture means the two letter ISO and special three letter ISO
        /// in .NET Framework the same.
        /// Germany: de-DE
        /// three letter ISO as dialect:
        /// den-WEN for the Spreewood People Sorbish/Wendish
        /// United Kingdom: en-EN
        /// USA: en-US
        /// 
        /// GetSystemTime are different to GetLocalTime in hours.
        /// Call GetLocalTime() is installed current Culture/Country Time Clock
        /// 
        /// General Information Date/Time:
        /// 
        /// nanoseconds
        /// string.format("{0:ffffff}")
        /// 
        /// Microsoft Developer write public constants and formule for Time/Date
        /// Leap Year, nanoseconds, public bombed .NET Time/Date: 23:59:60 - 9999
        /// 
        /// Same write Formule Gauss, but there same problem at years the Formule goes different.
        /// use better Formule Meeuws/Belgium.
        /// 
        /// IBMW Paris International Bureau of Measures and Weights and Atomic Clocks
        /// Atomic Clocks 250 - our German Atomic Clock change from Caesium to Light/Laser Factor 17
        /// Right Define for a second.
        /// (inside .NET Framework - 12 and 24 hour Clock: 
        /// 12 Hour Clock am and pm - AM = ante meridiem, PM = post meridiem)
        /// (German: Vormittag - Nachmittag)
        /// 
        /// 
        /// 
        /// TIPPO:
        /// For all Clocks give Atomc Clock Time (World: ca.400 Atomic Clocks)
        /// For Germany PTB Braunschweig/Berlin three Adresses for Computer/Server
        /// so everytime the correct Time Clock.
        /// Gecko: a PTB Time Clock App - https://uhr.ptb.de
        /// correct Time with Local Time different's in Milliseconds
        /// 
        /// Windows 10 / Server new great update with new Leap Second in USA direct,
        /// Information by Microsoft Website.
        /// 09:59:59 old - 09:59:60 Leap Second -> 10:00:00 new
        /// Webpage for show this:
        /// https://blogs.technet.microsoft.com/networking/2018/07/18/top10-ws2019-hatime/
        /// Europe at new year 2018/2019:
        /// For Germany, PTB Braunschweig/Berlin.
        /// 
        /// The Earth Rotation goes lowly.
        /// 
        /// </summary>
        internal struct SystemTime
        {
            /// <summary>
            /// get current year
            /// </summary>
            public short Year;
            /// <summary>
            /// get current month
            /// </summary>
            public short Month;
            /// <summary>
            /// get current day of week
            /// </summary>
            public short DayOfWeek;
            /// <summary>
            /// get current day
            /// </summary>
            public short Day;
            /// <summary>
            /// get current hour
            /// </summary>
            public short Hour;
            /// <summary>
            /// get current minute
            /// </summary>
            public short Minute;
            /// <summary>
            /// get current second
            /// </summary>
            public short Second;
            /// <summary>
            /// get current milliseconds
            /// </summary>
            public short Milliseconds;
        }

        /// <summary>
        /// Structure TimeZoneInformation
        /// </summary>
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
        internal struct TimeZoneInformation
        {
            [MarshalAs(UnmanagedType.I4)]
            public int Bias;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
            public string StandardName;

            public SystemTime StandardDate;

            [MarshalAs(UnmanagedType.I4)]
            public int StandardBias;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
            public string DaylightName;

            public SystemTime DaylightDate;

            [MarshalAs(UnmanagedType.I4)]
            public int DaylightBias;

            public TimeZoneInformation(DynamicTimeZoneInformation dtzi)
            {
                Bias = dtzi.Bias;
                StandardName = dtzi.StandardName;
                StandardDate = dtzi.StandardDate;
                StandardBias = dtzi.StandardBias;
                DaylightName = dtzi.DaylightName;
                DaylightDate = dtzi.DaylightDate;
                DaylightBias = dtzi.DaylightBias;
            }
        }

        /// <summary>
        /// Structure DynamicTimeZoneInformation
        /// </summary>
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
        internal struct DynamicTimeZoneInformation
        {
            [MarshalAs(UnmanagedType.I4)]
            public int Bias;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
            public string StandardName;

            public SystemTime StandardDate;

            [MarshalAs(UnmanagedType.I4)]
            public int StandardBias;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
            public string DaylightName;

            public SystemTime DaylightDate;

            [MarshalAs(UnmanagedType.I4)]
            public int DaylightBias;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
            public string TimeZoneKeyName;

            [MarshalAs(UnmanagedType.Bool)]
            public bool DynamicDaylightTimeDisabled;
        }

        /// <summary>
        /// Structure RegistryTimeZoneInformation
        /// </summary>
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
        internal struct RegistryTimeZoneInformation
        {
            [MarshalAs(UnmanagedType.I4)]
            public int Bias;

            [MarshalAs(UnmanagedType.I4)]
            public int StandardBias;

            [MarshalAs(UnmanagedType.I4)]
            public int DaylightBias;

            public SystemTime StandardDate;

            public SystemTime DaylightDate;

            public RegistryTimeZoneInformation(TimeZoneInformation tzi)
            {
                Bias = tzi.Bias;
                StandardDate = tzi.StandardDate;
                StandardBias = tzi.StandardBias;
                DaylightDate = tzi.DaylightDate;
                DaylightBias = tzi.DaylightBias;
            }

            public RegistryTimeZoneInformation(byte[] bytes)
            {
                if (bytes != null && bytes.Length == 44)
                {
                    Bias = BitConverter.ToInt32(bytes, 0);
                    StandardBias = BitConverter.ToInt32(bytes, 4);
                    DaylightBias = BitConverter.ToInt32(bytes, 8);
                    StandardDate.Year = BitConverter.ToInt16(bytes, 12);
                    StandardDate.Month = BitConverter.ToInt16(bytes, 14);
                    StandardDate.DayOfWeek = BitConverter.ToInt16(bytes, 16);
                    StandardDate.Day = BitConverter.ToInt16(bytes, 18);
                    StandardDate.Hour = BitConverter.ToInt16(bytes, 20);
                    StandardDate.Minute = BitConverter.ToInt16(bytes, 22);
                    StandardDate.Second = BitConverter.ToInt16(bytes, 24);
                    StandardDate.Milliseconds = BitConverter.ToInt16(bytes, 26);
                    DaylightDate.Year = BitConverter.ToInt16(bytes, 28);
                    DaylightDate.Month = BitConverter.ToInt16(bytes, 30);
                    DaylightDate.DayOfWeek = BitConverter.ToInt16(bytes, 32);
                    DaylightDate.Day = BitConverter.ToInt16(bytes, 34);
                    DaylightDate.Hour = BitConverter.ToInt16(bytes, 36);
                    DaylightDate.Minute = BitConverter.ToInt16(bytes, 38);
                    DaylightDate.Second = BitConverter.ToInt16(bytes, 40);
                    DaylightDate.Milliseconds = BitConverter.ToInt16(bytes, 42);
                    return;
                }
                throw new ArgumentException("Argument_Invalid REG_TZI_FORMAT", "bytes");
            }
        }

        /// <summary>
        /// Struct Operation System Version Info
        /// </summary>
        /// <!-- Author TIPPO -->
        /// Please us better our Visual.Function.Library.dll,
        /// use inside the new C++ Headerfile VersionHelper.h from Windows 10 SDK,
        /// complete Functions for use them.
        /// <!-- Author TIPPO -->
        /// <remarks>
        /// two ways for a struct: declare struct or class
        /// NOTE: structs storage are never null/0 in Visual C#,
        /// Visual C# set a storage 1 byte for managed the Structure!,
        /// if members or not! 
        /// </remarks>
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
        internal struct OSVERSIONINFOEX
        {
            public int OSVersionInfoSize;

            public int MajorVersion;

            public int MinorVersion;

            public int BuildNumber;

            public int PlatformId;

            // NOTE: .NET have NO fixed strings, so you must marshal !
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
            public string CSDVersion;

            public ushort ServicePackMajor;

            public ushort ServicePackMinor;

            public short SuiteMask;

            public byte ProductType;

            public byte Reserved;
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
        internal struct VersionInfo
        {
            

            public static int version_major;
            public static int version_minor;
            public static int version_build;
            public static int version_subbuild;
            public static string version_string = vos.Version;
            public static string author;
            public static string comments;
            public static string company_name = vos.Company;
            public static string file_description = vos.Description;
            public static string internal_name;
            public static string legal_copyright = vos.Copyright;
            public static string original_filename = vos.AsmFQName;
            public static string product_name = vos.Product;
        };








        /// <summary>
        /// Structure SYSTEM_INFO
        /// </summary>
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
        internal struct SYSTEM_INFO
        {
            public ushort wProcessorArchitecture;

            public ushort wReserved;

            public int dwPageSize;

            public IntPtr lpMinimumApplicationAddress;

            public IntPtr lpMaximumApplicationAddress;

            public IntPtr dwActiveProcessorMask;

            public int dwNumberOfProcessors;

            public int dwProcessorType;

            public int dwAllocationGranularity;

            public short wProcessorLevel;

            public short wProcessorRevision;
        }

        



        /// <summary>
        /// Structure FILE_TIME
        /// </summary>
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
        internal struct FILE_TIME
        {
            public uint ftTimeLow;

            public uint ftTimeHigh;

            public FILE_TIME(long fileTime)
            {
                ftTimeLow = (uint)fileTime;
                ftTimeHigh = (uint)(fileTime >> 32);
            }

            public long ToTicks()
            {
                return (long)(((ulong)ftTimeHigh << 32) + ftTimeLow);
            }
        }

        /// <summary>
        /// Structure LUID
        /// </summary>
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
        internal struct LUID
        {
            public uint LowPart;

            public uint HighPart;
        }

        /// <summary>
        /// Structure LUID_AND_ATTRIBUTES
        /// </summary>
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
        internal struct LUID_AND_ATTRIBUTES
        {
            public LUID Luid;

            public uint Attributes;
        }



        /// <summary>
        /// Structure SID_AND_ATTRIBUTES
        /// </summary>
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
        internal struct SID_AND_ATTRIBUTES
        {
            public IntPtr Sid;

            public uint Attributes;

            public static readonly long SizeOf = Marshal.SizeOf(typeof(SID_AND_ATTRIBUTES));
        }

        /// <summary>
        /// Structure TOKEN_PRIVILEGES
        /// </summary>
        public struct TOKEN_PRIVILEGES
        {
            /// <summary>
            /// Member PrivilegeCount
            /// </summary>
            public int PrivilegeCount;

            /// <summary>
            /// Member LUID_AND_ATTRIBUTES Array Privileges
            /// Array set on size 1 - const size
            /// </summary>
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
            public LUID_AND_ATTRIBUTES[] Privileges;

            /// <summary>
            /// NOTE! without public is private,
            /// while private have protection of degree.
            /// so by private compiler make three points under membername.
            /// Visual C# Compiler is running 'Under the Hood', make by OK,
            /// Fore End compile, is a better Back End Compile and faster.
            /// NOTE: Compile parse and check syntax the codeline directly,
            /// if error, the yellow lamp on the left side.
            /// </summary>
            public LUID Luid;


        }







        /// <summary>
        /// Structure TOKEN_GROUPS
        /// </summary>
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
        internal struct TOKEN_GROUPS
        {
            public uint GroupCount;

            public SID_AND_ATTRIBUTES Groups;
        }

        /// <summary>
        /// Structure TOKEN_PRIMARY_GROUP
        /// </summary>
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
        internal struct TOKEN_PRIMARY_GROUP
        {
            public IntPtr PrimaryGroup;
        }

        /// <summary>
        /// Structure TOKEN_PRIVILEGE
        /// </summary>
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
        internal struct TOKEN_PRIVILEGE
        {
            public uint PrivilegeCount;

            public LUID_AND_ATTRIBUTES Privilege;
        }

        /// <summary>
        /// Structure TOKEN_SOURCE
        /// </summary>
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
        internal struct TOKEN_SOURCE
        {
            private const int TOKEN_SOURCE_LENGTH = 8;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
            public char[] Name;

            public LUID SourceIdentifier;
        }

        /// <summary>
        /// Structure TOKEN_STATISTICS
        /// </summary>
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
        internal struct TOKEN_STATISTICS
        {
            public LUID TokenId;

            public LUID AuthenticationId;

            public long ExpirationTime;

            public uint TokenType;

            public uint ImpersonationLevel;

            public uint DynamicCharged;

            public uint DynamicAvailable;

            public uint GroupCount;

            public uint PrivilegeCount;

            public LUID ModifiedId;
        }

        /// <summary>
        /// Structure TOKEN_USER
        /// </summary>
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
        internal struct TOKEN_USER
        {
            public SID_AND_ATTRIBUTES User;
        }

        /// <summary>
        /// ! OLD ! Struct MEMORYSTATUS for Windows Operation System before Windows 7
        /// </summary>
        internal struct MEMORYSTATUS
        {
            public uint dwLength;

            public uint dwMemoryLoad;

            public uint dwTotalPhys;

            public uint dwAvailPhys;

            public uint dwTotalPageFile;

            public uint dwAvailPageFile;

            public uint dwTotalVirtual;

            public uint dwAvailVirtual;
        }

        /// <summary>
        /// Structure MEMORYSTATUSEX
        /// </summary>
        /// <!-- Author TIPPO -->
        /// Queries via WMI, 
        /// if(MemoryLoad goes to 100%) "Close any Application that not work!"
        /// Set in Windows Operation System short version with Lambda Operator =>
        /// total => ms.totalPhys;
        /// <!-- Author TIPPO -->
        /// <remarks>
        /// Visual C# change .Auto to .Ansi !, Windows 10 inside unicode, so set .Unicode!
        /// All Windows Functions and Strutures with end Ex 
        /// are Windows Operation System Functions and call it permently in Time,
        /// so write a Wrapper Methods for it.
        /// </remarks>
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
        internal struct MEMORYSTATUSEX
        {
            public int length;                  // signed integer value 2.147.483.648 +/- .647
                                                // unsigned integer value 4.294.967.295
            public int memoryLoad;              // in % Procent

            public ulong totalPhys;             //

            public ulong availPhys;             //

            public ulong totalPageFile;         // Block unsigned long greatest Value 18.446.744.073.709.551.615
                                                // Intel longdouble is greather, but not all supported this datatype.
                                                // 80 BIT 3,4*(10^4932) to 1.1(10^+4932)
                                                //
                                                // Intel Processor public 80BIT, secure for overflow by 64BIT Values.
                                                // signed long value 9.223.372.036.854.775.808 - .807 +
                                                // special datatype - decimal - by Visual C# for financial methods,
                                                // 79.228.162.514.264.337.593.543.950.335 +/-
            public ulong availPageFile;         //

            public ulong totalVirtual;          //

            public ulong availVirtual;          //

            public ulong availExtendedVirtual;  //
        }

        /// <summary>
        /// Structure MEMORY_BASIC_INFORMATION
        /// </summary>
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
        internal struct MEMORY_BASIC_INFORMATION
        {
            public unsafe void* BaseAddress;

            public unsafe void* AllocationBase;

            public uint AllocationProtect;

            public UIntPtr RegionSize;

            public uint State;

            public uint Protect;

            public uint Type;
        }

        /// <summary>
        /// Structure NlsVersionInfoEx
        /// </summary>
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
        internal struct NlsVersionInfoEx
        {
            public int dwNLSVersionInfoSize;

            public int dwNLSVersion;

            public int dwDefinedVersion;

            public int dwEffectiveId;

            public Guid guidCustomVersion;
        }

        /// <summary>
        /// Structure COORD
        /// </summary>
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
        internal struct COORD
        {
            public short X;

            public short Y;
        }

        /// <summary>
        /// Structure SMALL_RECT
        /// </summary>
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
        internal struct SMALL_RECT
        {
            public short Left;

            public short Top;

            public short Right;

            public short Bottom;
        }


        /// <summary>
        /// Structure KeyEventRecord
        /// </summary>
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
        internal struct KeyEventRecord
        {
            public bool keyDown;

            public short repeatCount;

            public short virtualKeyCode;

            public short virtualScanCode;

            public char uChar;

            public int controlKeyState;
        }

        /// <summary>
        /// Struct FLASHWINFO for flash the given Window
        /// internal declared struct, but the members must be public declared,
        /// if not the members no access ! all HIDDEN.
        /// private is degree of protection.
        /// </summary>
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
        internal struct FLASHWINFO
        {

            // size of structure, in bytes
            // if set class as struct, you can this value set.
            //
            // [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
            // internal class FLASHWINFO
            // {
            //      public uint cbsize = this(FLASHWINFO);
            // }
            public uint cbSize;

            // means the WindowHandle = HWND
            public IntPtr WindowHandle;

            // FLASHW_CAPTION    = Flash the Caption in Window
            // FLASHW_TRAY       = Flas the Task Bar
            // FLASHW_ALL        = Flash both windows caption and task bar
            // FLASHW_TIMER     = Flash continuously, until the FLASHW_STOP flag is set.
            // FLASHW_TIMERNOFG = Flash continuously, until the window comes to the foreground
            public uint dwFlags;

            //Number of times to flash the window
            public uint uCount;

            // rate at which window is to be flashed, in milliseconds.
            // if dwTimeout is zero, the function uses the default cursor blink rate.
            public uint dwTimeout;

        }

        /// <summary>
        /// SECURITY_DESCRIPTOR
        /// </summary>
        /// <!-- Author Tipplin -->
        /// Methods: SetFileObjectSecurity
        /// <!-- Author Tipplin -->
        /// <remarks>
        /// !NOTE! without Modi: public, internal 
        /// the struct is private and have shield protection.
        /// No access allowed from outside.
        /// The Structmembers must set with public the same.
        /// </remarks>
        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
        internal struct SECURITY_DESCRIPTOR
        {
            /// <summary>
            /// 
            /// </summary>
            public byte revision;
            /// <summary>
            /// 
            /// </summary>
            public byte size;
            /// <summary>
            /// 
            /// </summary>
            public short control;
            /// <summary>
            /// 
            /// </summary>
            public IntPtr owner;
            /// <summary>
            /// 
            /// </summary>
            public IntPtr group;
            /// <summary>
            /// 
            /// </summary>
            public IntPtr sacl;
            /// <summary>
            /// 
            /// </summary>
            public IntPtr dacl;
        }

        /// <summary>
        /// 
        /// </summary>
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
        internal struct MSG
        {
            /// <summary>
            /// 
            /// </summary>
            public IntPtr hwnd;
            /// <summary>
            /// 
            /// </summary>
            public uint message;
            /// <summary>
            /// 
            /// </summary>
            public UIntPtr wParam;
            /// <summary>
            /// 
            /// </summary>
            public IntPtr lParam;
            /// <summary>
            /// 
            /// </summary>
            public int time;
            /// <summary>
            /// point to Struct POINT
            /// </summary>
            public POINT pt;

            // set only for the MAC Computer macOSX
            #if _MAC
                int lPrivate;
            #endif
        }

        /// <summary>
        /// 
        /// </summary>
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
        internal struct POINT
        {
            /// <summary>
            /// 
            /// </summary>
            public FIXED x;
            /// <summary>
            /// 
            /// </summary>
            public FIXED y;
        }

        /// <summary>
        /// 
        /// </summary>
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
        internal struct FIXED
        {
            /// <summary>
            /// 
            /// </summary>
            public short fract;
            /// <summary>
            /// 
            /// </summary>
            public short value;
        }

        /// <summary>
        /// SOFTDISTINFO Structure for SoftwareUpdateMessageBox(.); 
        /// </summary>
        /// <!-- Author Tipplin -->
        /// Two ways write Structure:
        /// 1. struct   -Structname- value
        /// 2. class    -Structname- reference
        /// set directly size of structure.
        /// If Struct is modi internal, the members must be public written, 
        /// if not, no access on Members.
        /// ATTENTION ! standard for all, is private in Visual C#,
        /// private have degree of protection, no access in/out.
        /// uint dwAdState; - see three pionts under Membersname, declare as private!
        /// 
        /// 
        /// ---------------------------------------------------------------------------------
        /// Always by Visual C# use unicode!, is better in code.
        /// CharSet.Auto, Visual C# Compiler change to CharSet.Ansi !.
        /// ---------------------------------------------------------------------------------
        /// Windows Operation System 10 in 2020 with Unicode Version 12.0,
        /// (emojis, katmojis, symbols in Windows 10 - 2020 - katmoji's with chat symbols...)
        /// ---------------------------------------------------------------------------------
        /// <!-- Author Tipplin -->
        /// <remarks>
        /// SoftwareMessageBox is an Windows Operation System Function,
        /// he look at Webserver, is there an new Version for Application or
        /// new update, new Fixes.
        /// </remarks>
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
        internal struct SOFTDISTINFO
        {

            /// <summary>
            /// set size of Structure.
            /// </summary>
            public ulong cbSize;

            public uint dwFlags;

            public uint dwAdState;

            public string szTitle;

            public string szAbstract;

            public string szHREF;

            public uint dwInstalledVersionMS;

            public uint dwInstalledVersionLS;

            public uint dwUpdateVersionMS;

            public uint dwUpdateVersionLS;

            public uint dwAdvertisedVersionMS;

            public uint dwAdvertisedVersionLS;

            public uint dwReserved;
        }
        
        
        
        
        
        
        
        
        
        
        #endregion

        // class SafeNativeMethods after NEW Microsoft Guideline

    } // end of class::NativeMethods

    // same Windows System DLL's
    #region ### Windows Operation System - Functions ###

    /*--------------------------------------------------------------------------
     * ! NOTE !
     *--------------------------------------------------------------------------
     * Windows 10 goes open source -parts on GitHub with sourcecodes in C++, C#
     *--------------------------------------------------------------------------
     * Windows Implementation Libraries - Microsoft WIL -
     * Calculator
     * Window Terminal
     * 
     * old Windows File Manager in C++
     * 
     * 
     * 
     */

    //-------------------------------------------------------------------------
    // NEW! Microsoft Guideline for native Methods from native DLL's:
    // Automatic set Visual Studio 2017 or higher:
    // Microsoft.Portability, Microsoft.Design and 
    // at Time Microsoft.Globalization.
    //
    // Do check all Code with Code Analyizer. (Left Side lineNumber, comes a Yellow Lamp
    // is the Compiler, make syntax, Keyword check and more, the Compiler run directly in
    // new Visual Studio, line to line make precompiled Code, better and faster Backend Compile.)
    // All .NET Compiler runs "Under the Hood" !.
    // Your choice:
    // Visual C++ - Project for .NET with CLR and .Net Framework
    // here no Headerfiles, can use [DllImportAttribute("user32.dll")]
    // 
    // Visual C++ - Project for native with C++ Headerfiles.
    // write C code or mixed Code. For only C code use Preprocessor:
    //
    // Assume C declarations for C++
    // if without extern "C" so he created mangled names.
    // extern "C" with defined filed prototypes, this functions with parametern
    // stand in the Exported File.
    //
    // You can set in Configuration Properties under point C/C++ 
    // expand __stdcall(/Gz) as extra.
    // To proof the exported Functions, use the Tool Dependency Walker (32/64BIT)
    // show all exported Functions and dependency dynamic link libraries.
    //
    // have more than one or same Headerfile, the compiler see it and compile only one time no more!
    // #ifndef __VFL_H__
    // #define __VFL_H__
    //-----------Libraryname short version
    //
    //
    // #ifdef __cplusplus
    //
    // extern "C" {
    //
    //
    // #endif
    // 
    // set here C prototypes
    // 
    // 
    // 
    // #endif //  end of header __VFL_H__
    //
    // Microsoft Developer
    // make one headerfile for all other Headerfiles as Standard.
    //
    //*****************************************************************************
    // GLOBAL_STANDARD_HEADER_FILES.h
    // Take more performance, make one Header for all Standard-Header-files,
    // Windows Headerfiles, C++ Runtime HeaderFiles and more...
    //*****************************************************************************
    //
    //-----------------------------------------------------------------------------
    // #pragma for Visual C++ Compiler compile this Headerfiles one time, NO MORE!!
    //-----------------------------------------------------------------------------
    // #pragma once 
    // 
    // very better one Headerfile for all Standard-Header-Files,
    // so the Compiler, compile this File once.
    //-----------------------------------------------------------------------------
    // #ifndef _GLOBAL_STANDARD_HEADER_FILES_H_
    // #define _GLOBAL_STANDARD_HEADER_FILES_H_
    //
    // set pragma once, so the Compiler compile only one time this Headerfile.
    // #pragma once
    // #pragma region Windows Operation System Headerfiles
    // .NET CallingConvention: .stdcall
    //      set here all Windows Headerfiles
    // #endregion
    // #pragma region C++ Runtime Libraries
    // .NET CallingConvention: .cdecl (C++ Runtime with mangled names)
    //      set here all C++ Headerfiles
    // #endregion
    //
    // #endif // _GLOBAL_STANDARD_HEADER_FILES_H_
    //
    //
    // class SafeNativeMethods, is one of three classes about native Windows Methods,
    // Generally Windows Methods written in C and C++, CallingConvention is standard call / .stdcall
    // this call have a Security Attribute [SuppressUnmanagedCodeSecurity], that means a Security Check
    // for all Methods by User Call, ? with Stackwalk.
    // SafeNativeMethods - NO dangerous calls and NO Risk.
    //
    // All Windows Functions like here are public written in .NET Framework, so you can't use them !,
    // so as Visual C# Wrapper Method.
    // see at at GetMessage(int errorCode) with FormatMessage written, but highest Chars is 512 Chars.
    // SafeHandles not for use directly from .NET Framework, own implemenation make!
    // Dangerous Handles, give returned value 0 and -1 or other value !, so Microsoft Developer write SafeHandles,
    // !again! all Handles must be closed at end !, open handles dangerous!, no again access! access denied!.
    //
    // #pragma region for C++ 
    // #pragma region ### that's NOT allowed in C++ ###
    //
    // #region for C# 
    // #region ### advapi32.dll --- Windows System Dll - Registry Functions, ### in C# allowed!

    //----------------- THAT's NEW --------------------------------------------
    // One class of three, Microsoft want it!
    // that's new, [Security Attribute]
    // Allows managed code to call into unmanaged code without a stack walk.
    // SafeNativeMethods NO Dangerous and NO Risk for User Call.
    //-------------------------------------------------------------------------

    /// <summary>
    /// Class UnsafeNativeMethods written for all 
    /// Windows Operation System Functions
    /// </summary>
    /// <remarks>
    /// 
    /// A lot of Windows Functions in .NET Framework but all internal written, no for use!,
    /// wrapper methods inside DllImportAttribute.
    /// All other have written here for use it!,
    /// Visual.Operation.System.dll as assembly with Attribute 
    /// [assembly: InternalsVisibleTo("Visual.Galaxy.Framework", AllInternalsVisible = true)]
    /// so you can use all internal Methods in Visual.Galaxy.Framework -
    /// 
    /// Most Windows Operation System Functions on PInvoke
    /// --------------------------------------------------
    /// http://www.pinvoke.net/
    /// 
    /// GitHub Project Vanara PInvoke - Windows.NET
    /// Vanara.Core
    /// Vanara.PInvoke.Shared
    /// Vanara.PInvoke.AdUI
    /// Vanara.PInvoke.BITS
    /// Vanara.PInvoke.Cabinet
    /// Vanara.PInvoke.Kernel32
    /// Vanara.PInvoke.Shell32
    /// Vanare.PInvoke.User32
    /// 
    /// 
    /// </remarks>
    internal static class UnsafeNativeMethods
    {

        #region ### advapi32.dll --- Windows System Dll - Registry Functions, ###

        //********************************************************************************************************
        // can use Registry Functions, but all as Wrapper in .NET - 
        // Class Registry plus Class RegistrySecurity with right-system.
        // to watch Registry entries for foreign changes, give Function RegistryNofication, 
        // but not realtime! now after change he signaled,
        // Registry entry was change.(before Windows 10, TIPPO make update!)
        // Registry Security now: watch, add, delete, change, readonly, read/write, set as Flag!
        // Windows 10 OS-Build 17134 - SetFileSecurity(FileName, SecurityDescriptor);
        // !again! hide the your Directory with two sign - $dirname.~subname, so this NO show in Windows Explorer!
        // same for all System file in Windows. 
        // C:\$WINDOWS.~BT\Sources - ~BT is the file folder
        // simple secure!
        //*********************************************************************************************************

        //*********************************************************************************************************
        // CallingConventions:
        // ! NOTE ! Set by CharSet now Unicode for Windows 10 (Windows NT 10.0), 
        // ! NOTE ! The CallingCovention .Winapi doesn't normally support now!
        // Windows Operation Systems supports only .StdCall ---> C++ Project with C Declaration
        // Other Languages can out of the CallingCovention .Auto,
        // ! Visual C# marked all CallingConvention.Auto, all Methods and types with CallingConvention.Ansi
        // Windows Operation System 98 and ME all CallingConvention.Ansi as Standard-Value !.
        // Windows Operation System NT, 2000, XP and Server 2003 all CallingConvention.Unicode as Standard-Value !.
        // Common Language Runtime with CallingConvention.Auto as Standard-Value !.
        //
        //*********************************************************************************************************


        /*--------------------------------------------------------------------------------------------------------
         * ! ATTENTION !
         * Visual C# Compiler parse the text, or here the Dynamic Link Library is written correct, make compare!
         * in \system32 dir with all dll's plus names, isn't correct make message "The Libname isn't correct"
         * -------------------------------------------------------------------------------------------------------
         * Microsoft Name Convention:
         * Visual C#
         * The first Letter must be upper ! by Methodname.
         * if use printf, write Printf
         * sample:
         * [DllImport("mscrt.dll", EntryPoint = "printf", SetLastError = true, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
         * internal static extern int Printf(string format, params Object[] args);
         * params always as last parameter ! - Object array for all dataytpes ! - args for variadic arguments.
         * -------------------------------------------------------------------------------------------------------
         * 
         * 
         */


        /// <summary>
        /// Set File Security for given File
        /// </summary>
        /// <param name="lpFileName"></param>
        /// <param name="SecurityInformation"></param>
        /// <param name="SecurityDescriptor"></param>
        /// <returns></returns>
        [DllImport("advapi32.dll", EntryPoint = "SetFileSecurityW", SetLastError = true, BestFitMapping = false, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        internal static extern bool SetFileSecurity(
                                                    [MarshalAs(UnmanagedType.LPWStr)]
                                                    string lpFileName,
                                                    IntPtr SecurityInformation,
                                                    IntPtr SecurityDescriptor);

        /// <summary>
        /// Decrypt a given Path/File
        /// </summary>
        /// <param name="path"></param>
        /// <param name="reservedMustBeZero"></param>
        /// <returns>
        /// 
        /// </returns>
        [DllImport("advapi32.dll", EntryPoint = "DecryptFile", SetLastError = true, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        internal static extern bool DecryptFile(string path, int reservedMustBeZero);

        /// <summary>
        /// Encrypt a given Path/File
        /// </summary>
        /// <param name="path"></param>
        /// <returns>
        /// 
        /// </returns>
        [DllImport("advapi32.dll", EntryPoint = "EncryptFile", SetLastError = true, CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        internal static extern bool EncryptFile(string path);

        /// <summary>
        /// Connect to a remote Registry on this remote Computer
        /// </summary>
        /// <param name="machineName">Set Computername</param>
        /// <param name="key">Set key</param>
        /// <param name="result">set result</param>
        /// <returns></returns>
        [DllImport("advapi32.dll", EntryPoint = "RegConnectRegistry", SetLastError = true, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        internal static extern int RegConnectRegistry(string machineName, SafeHandle key, out SafeHandle result);

        /// <summary>
        /// Lookup Account Name
        /// </summary>
        /// <param name="machineName"></param>
        /// <param name="accountName"></param>
        /// <param name="sid"></param>
        /// <param name="sidLen"></param>
        /// <param name="domainName"></param>
        /// <param name="domainNameLen"></param>
        /// <param name="peUse"></param>
        /// <returns></returns>
        [DllImport("advapi32.dll", EntryPoint = "LookupAccountName", SetLastError = true, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        internal static extern bool LookupAccountName(string machineName, string accountName, byte[] sid, ref int sidLen, [Out] StringBuilder domainName, ref uint domainNameLen, out int peUse);

        /// <summary>
        /// Lookup Account Sid
        /// </summary>
        /// <param name="lpSystemName"></param>
        /// <param name="Sid"></param>
        /// <param name="lpName"></param>
        /// <param name="cchName"></param>
        /// <param name="ReferencedDomainName"></param>
        /// <param name="cchReferencedDomainName"></param>
        /// <param name="peUse"></param>
        /// <returns></returns>
        [DllImport("advapi32.dll", EntryPoint = "LookupAccountSid", SetLastError = true, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        internal static extern bool LookupAccountSid(
                                                      string lpSystemName,
                                                      [MarshalAs(UnmanagedType.LPArray)] byte[] Sid,
                                                      StringBuilder lpName,
                                                      ref uint cchName,
                                                      StringBuilder ReferencedDomainName,
                                                      ref uint cchReferencedDomainName,
                                                      out SID_NAME_USE peUse);

        /// <summary>
        /// Convert String Sid To Sid
        /// </summary>
        /// <param name="StringSid"></param>
        /// <param name="Sid"></param>
        /// <returns></returns>
        [DllImport("advapi32.dll", EntryPoint = "ConvertStringSidToSidW", SetLastError = true, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        internal static extern bool ConvertStringSidToSid(
                                                            [MarshalAs(UnmanagedType.LPWStr)]
                                                            string StringSid,  
                                                            out IntPtr Sid);




       // [DllImport("advapi32.dll", EntryPoint = "", SetLastError = true, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]



        /// <summary>
        /// Adjust Token Privileges
        /// </summary>
        /// <param name="TokenHandle">Set GetCurrentThread()</param>
        /// <param name="DisableAllPrivileges">set true/false for disable/enable</param>
        /// <param name="NewState"></param>
        /// <param name="BufferLength"></param>
        /// <param name="PreviousState"></param>
        /// <param name="ReturnLength"></param>
        /// <returns></returns>
        [DllImport("advapi32.dll", EntryPoint = "AdjustTokenPrivileges", SetLastError = true, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        internal static extern bool AdjustTokenPrivileges(  IntPtr TokenHandle, 
                                                            bool DisableAllPrivileges, 
                                                            ref TOKEN_PRIVILEGE NewState, 
                                                            int BufferLength, 
                                                            [In, Out] ref TOKEN_PRIVILEGE PreviousState, 
                                                            [In, Out] ref int ReturnLength);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Luid"></param>
        /// <returns></returns>
        [DllImport("advapi32.dll", EntryPoint = "AllocateLocallyUniqueId", SetLastError = true, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        internal static extern bool AllocateLocallyUniqueId(ref LUID Luid);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="TokenHandle"></param>
        /// <param name="SidToCheck"></param>
        /// <param name="IsMember"></param>
        /// <returns></returns>
        [DllImport("advapi32.dll", EntryPoint = "CheckTokenMembership", SetLastError = true, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        internal static extern bool CheckTokenMembership(IntPtr TokenHandle, byte[] SidToCheck, bool IsMember);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="lpSystemName"></param>
        /// <param name="lpName"></param>
        /// <param name="pLuid"></param>
        /// <returns></returns>
        [DllImport("advapi32.dll", EntryPoint = "LookupPrivilegeValue", SetLastError = true, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        internal static extern bool LookupPrivilegeValue(string lpSystemName, string lpName, IntPtr pLuid);


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ClientToken"></param>
        /// <param name="RequiredPrivileges"></param>
        /// <param name="pfResult"></param>
        /// <returns></returns>
        [DllImport("advapi32.dll", EntryPoint = "PrivilegeCheck", SetLastError = true, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern bool PrivilegeCheck(IntPtr ClientToken, IntPtr RequiredPrivileges, ref int pfResult);

        /// <summary>
        /// Initiates a shutdown and optional restart of the specified computer, 
        /// and optionally records the reason for the shutdown.
        /// </summary>
        /// <param name="lpMachineName">The network name of the computer to be shut down. 
        /// If lpMachineName is NULL or an empty string, 
        /// the function shuts down the local computer.
        /// </param>
        /// <param name="lpMessage">
        /// The message to be displayed in the shutdown dialog box. 
        /// This parameter can be NULL if no message is required.
        /// </param>
        /// <param name="dwTimeout">The length of time that the shutdown dialog box should be displayed, in seconds.</param>
        /// <param name="bForceAppsClosed">If this parameter is TRUE, 
        /// applications with unsaved changes are to be forcibly closed. 
        /// If this parameter is FALSE, the system displays a dialog box instructing the user to close the applications.
        /// </param>
        /// <param name="bRebootAfterShutdown">If this parameter is TRUE, the computer is to restart immediately after shutting down. 
        /// If this parameter is FALSE, the system flushes all caches to disk and safely powers down the system.</param>
        /// <param name="dwReason">The reason for initiating the shutdown. </param>
        /// <returns></returns>
        [DllImport("advapi32.dll", EntryPoint = "InitiateSystemShutdownExW", SetLastError = true, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        internal static extern bool InitiateSystemShutdownEx(
                                                              [MarshalAs(UnmanagedType.LPWStr)]
                                                              string lpMachineName,
                                                              [MarshalAs(UnmanagedType.LPWStr)]
                                                              string lpMessage,
                                                              uint dwTimeout,
                                                              bool bForceAppsClosed,
                                                              bool bRebootAfterShutdown,
                                                              SHTDN_REASON_CODES dwReason);
        /*
          fResult = InitiateSystemShutdown(
          NULL,    // shut down local computer 
          lpMsg,   // message for user
          30,      // time-out period, in seconds 
          FALSE,   // ask user to close apps 
          TRUE);   // reboot after shutdown 
          */

        
        [DllImport("advapi32.dll", EntryPoint = "OpenProcessToken", SetLastError = true, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        internal static extern bool OpenProcessToken(IntPtr ProcessHandle, uint DesiredAccess, IntPtr TokenHandle);




        #endregion


        #region ### kernel32.dll --- Windows Sytem Dll - kernel, allocation, storage, memory functions ###



        /// <summary>
        /// Register Service Process
        /// </summary>
        /// <!-- Author Tipplin 🧑-->
        /// 
        /// <!-- Author Tipplin 🧑-->
        /// <param name="ProcessID">
        /// This Parameter want the Program ID,
        /// unique ID for Application in Program.
        /// can set Windows Function GetCurrentProcessID();
        /// </param>
        /// <param name="Registered">
        /// 0 - register in System
        /// 1 - register delete in System
        /// </param>
        /// <remarks>
        /// RegisterServiceProcess(GetCurrentProcessID, 1);
        /// the current Task is hidden in the Taskmanager,
        /// don't show the program task.
        /// Want show the Task in Taskmanager set it 
        /// RegisterServiceProcess(GetCurrentProcessID, 0);
        /// so Task-Manager show the process and Programname.
        /// </remarks>
        /// <return>
        /// 
        /// </return>
        [DllImport("kernel32.dll", EntryPoint = "RegisterServiceProcess", SetLastError = true, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        internal static extern int RegisterServiceProcess(IntPtr ProcessID, bool Registered);

        /// <summary>
        /// Get System Info
        /// </summary>
        /// <param name="lpSystemInfo"></param>
        [DllImport("kernel32.dll", EntryPoint = "GetNativeSystemInfo", SetLastError = true, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        internal static extern void GetNativeSystemInfo(ref SYSTEM_INFO lpSystemInfo);

        /// <summary>
        /// Get Current Process
        /// </summary>
        /// <returns></returns>
        [DllImport("kernel32.dll", EntryPoint = "GetCurrentProcess", SetLastError = true, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        internal static extern IntPtr GetCurrentProcess();

        /// <summary>
        /// Format Message
        /// </summary>
        /// <param name="dwFlags"></param>
        /// <param name="lpSource"></param>
        /// <param name="dwMessageId"></param>
        /// <param name="dwLanguageId"></param>
        /// <param name="lpBuffer"></param>
        /// <param name="nSize"></param>
        /// <param name="va_list_arguments"></param>
        /// <returns></returns>
        [DllImport("kernel32.dll", EntryPoint = "FormatMessage", SetLastError = true, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        internal static extern int FormatMessage(int dwFlags, IntPtr lpSource, uint dwMessageId, int dwLanguageId, StringBuilder lpBuffer, int nSize, IntPtr va_list_arguments);

        /// <summary>
        /// Local Allocate Memory
        /// </summary>
        /// <param name="uFlags"></param>
        /// <param name="sizetdwBytes"></param>
        /// <returns></returns>
        [DllImport("kernel32.dll", EntryPoint = "LocalAlloc", SetLastError = true, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        internal static extern IntPtr LocalAlloc(int uFlags, UIntPtr sizetdwBytes);

        /// <summary>
        /// Local Free Memory
        /// </summary>
        /// <param name="handle"></param>
        /// <returns></returns>
        [DllImport("kernel32.dll", EntryPoint = "LocalFree", SetLastError = true, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        internal static extern IntPtr LocalFree(IntPtr handle);

        /// <summary>
        /// Zero Memory
        /// </summary>
        /// <param name="address"></param>
        /// <param name="length"></param>
        [DllImport("kernel32.dll", EntryPoint = "RtlZeroMemory", SetLastError = true, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        internal static extern void ZeroMemory(IntPtr address, UIntPtr length);

        /// <summary>
        /// GetProcAdress
        /// </summary>
        /// <param name="hModule"></param>
        /// <param name="methodName"></param>
        /// <returns></returns>
        [DllImport("kernel32.dll", EntryPoint = "GetProcAdress", SetLastError = true, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        internal static extern IntPtr GetProcAdress(IntPtr hModule, string methodName);

        /// <summary>
        /// GetModuleHandle
        /// </summary>
        /// <param name="moduleName"></param>
        /// <returns></returns>
        [DllImport("kernel32.dll", EntryPoint = "GetModuleHandle", SetLastError = true, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        internal static extern IntPtr GetModuleHandle(string moduleName);

        /// <summary>
        /// GetTempPath
        /// </summary>
        /// <param name="bufferLen"></param>
        /// <param name="buffer"></param>
        /// <returns></returns>
        [DllImport("kernel32.dll", EntryPoint = "GetTempPath", SetLastError = true, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        internal static extern uint GetTempPath(int bufferLen, StringBuilder buffer);

        /// <summary>
        /// Get Disk Free Space Values
        /// </summary>
        /// <!-- Author TIPPO -->
        /// The Function is Windows Operation System Special,
        /// at Time the OS make query for free Spaces.
        /// So write Wrapper Method for this Function.
        /// <!-- Author TIPPO -->
        /// <param name="DriveLetter"></param>
        /// <param name="FreeBytesAvailable"></param>
        /// <param name="TotalNumberofBytes"></param>
        /// <param name="TotalNumberofFreeBytes"></param>
        /// <remarks>
        /// Visual C# Datatype ulong is unsigned 64-bit integer
        /// Visual C++ Datatype equalvent ulonglong, both have the same Value.
        /// </remarks>
        /// <returns>
        /// 
        /// </returns>
        [DllImport("kernel32.dll", EntryPoint = "GetDiskFreeSpaceExW", SetLastError = true, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        internal static extern bool GetDiskFreeSpaceEx(string DriveLetter, out ulong FreeBytesAvailable, out ulong TotalNumberofBytes, out ulong TotalNumberofFreeBytes);

        /// <summary>
        /// Fatal Application exit
        /// </summary>
        /// <param name="uAction">Set zero</param>
        /// <param name="lpMessageText">Set Message text</param>
        [DllImport("kernel32.dll", EntryPoint = "FatalAppExit", SetLastError = true, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        internal static extern void FatalAppExit(
                                                    uint uAction,
                                                    [MarshalAs(UnmanagedType.LPTStr)]
                                                    string lpMessageText);




        /// <summary>
        /// 
        /// </summary>
        /// <param name="drive"></param>
        /// <returns></returns>
        [DllImport("kernel32.dll", EntryPoint = "GetDriveType", SetLastError = true, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        internal static extern int GetDriveType(string drive);

        /// <summary>
        /// SetVolumeLabel
        /// </summary>
        /// <param name="driveLetter"></param>
        /// <param name="volumeName"></param>
        /// <returns></returns>
        [DllImport("kernel32.dll", EntryPoint = "SetVolumeLabel", SetLastError = true, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        internal static extern bool SetVolumeLabel(string driveLetter, string volumeName);

        /// <summary>
        /// SetFileTime
        /// </summary>
        /// <param name="hFile"></param>
        /// <param name="creationTime"></param>
        /// <param name="lastAccessTime"></param>
        /// <param name="lastWriteTime"></param>
        /// <returns></returns>
        [DllImport("kernel32.dll", EntryPoint = "SetFileTime", SetLastError = true, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        internal unsafe static extern bool SetFileTime(IntPtr hFile, ref FILE_TIME creationTime, ref FILE_TIME lastAccessTime, ref FILE_TIME lastWriteTime);

        /// <summary>
        /// GetFileSize
        /// </summary>
        /// <param name="hFile"></param>
        /// <param name="highSize"></param>
        /// <returns></returns>
        [DllImport("kernel32.dll", EntryPoint = "GetFileSize", SetLastError = true, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        internal static extern int GetFileSize(IntPtr hFile, out int highSize);

        /// <summary>
        /// LockFile an given File for temporarly, lock File for other users, begin with Work.
        /// </summary>
        /// <!-- Author Tipplin -->
        /// Make sure after work and save, message to others Users 'Note the Work was change by me...'
        /// is better so the other User see your changes.
        /// than unlock the File for other Users.
        /// <!-- Author Tipplin -->
        /// <param name="handle"></param>
        /// <param name="offsetLow"></param>
        /// <param name="offsetHigh"></param>
        /// <param name="countLow"></param>
        /// <param name="countHigh"></param>
        /// <returns></returns>
        [DllImport("kernel32.dll", EntryPoint = "LockFile", SetLastError = true, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        internal static extern bool LockFile(IntPtr handle, int offsetLow, int offsetHigh, int countLow, int countHigh);

        /// <summary>
        /// UnlockFileSize
        /// </summary>
        /// <param name="handle"></param>
        /// <param name="offsetLow"></param>
        /// <param name="offsetHigh"></param>
        /// <param name="countLow"></param>
        /// <param name="countHigh"></param>
        /// <returns></returns>
        [DllImport("kernel32.dll", EntryPoint = "UnlockFile", SetLastError = true, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        internal static extern bool UnlockFile(IntPtr handle, int offsetLow, int offsetHigh, int countLow, int countHigh);

        /// <summary>
        /// CopyFile
        /// </summary>
        /// <param name="src"></param>
        /// <param name="dst"></param>
        /// <param name="failIfExists"></param>
        /// <returns></returns>
        [DllImport("kernel32.dll", EntryPoint = "SetVolumeLabel", SetLastError = true, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        internal static extern bool CopyFile(string src, string dst, bool failIfExists);

        /// <summary>
        /// DeleteFile
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        [DllImport("kernel32.dll", EntryPoint = "DeleteFile", SetLastError = true, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        internal static extern bool DeleteFile(string path);

        /// <summary>
        /// ReplaceFile
        /// </summary>
        /// <param name="replacedFileName"></param>
        /// <param name="replacementFileName"></param>
        /// <param name="backupFileName"></param>
        /// <param name="dwReplaceFlags"></param>
        /// <param name="lpExclude"></param>
        /// <param name="lpReserved"></param>
        /// <returns></returns>
        [DllImport("kernel32.dll", EntryPoint = "ReplaceFile", SetLastError = true, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        internal static extern bool ReplaceFile(string replacedFileName, string replacementFileName, string backupFileName, int dwReplaceFlags, IntPtr lpExclude, IntPtr lpReserved);

        /// <summary>
        /// GetCurrentDirectory
        /// </summary>
        /// <param name="nBufferLength"></param>
        /// <param name="lpBuffer"></param>
        /// <returns></returns>
        [DllImport("kernel32.dll", EntryPoint = "GetCurrentDirectory", SetLastError = true, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        internal static extern int GetCurrentDirectory(int nBufferLength, StringBuilder lpBuffer);

        /// <summary>
        /// SetFileAttributes
        /// </summary>
        /// <param name="name"></param>
        /// <param name="attr"></param>
        /// <returns></returns>
        [DllImport("kernel32.dll", EntryPoint = "SetFileAttributes", SetLastError = true, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        internal static extern bool SetFileAttributes(string name, int attr);

        /// <summary>
        /// GetLogicalDrives
        /// </summary>
        /// <returns></returns>
        [DllImport("kernel32.dll", EntryPoint = "GetLogicalDrives", SetLastError = true, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        internal static extern int GetLogicalDrives();

        /// <summary>
        /// GetTempFileName
        /// </summary>
        /// <param name="tmpPath"></param>
        /// <param name="prefix"></param>
        /// <param name="uniqueIdOrZero"></param>
        /// <param name="tmpFileName"></param>
        /// <returns></returns>
        [DllImport("kernel32.dll", EntryPoint = "GetTempFileName", SetLastError = true, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        internal static extern uint GetTempFileName(string tmpPath, string prefix, uint uniqueIdOrZero, StringBuilder tmpFileName);

        /// <summary>
        /// RemoveDirectory
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        [DllImport("kernel32.dll", EntryPoint = "RemoveDirectory", SetLastError = true, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        internal static extern bool RemoveDirectory(string path);

        /// <summary>
        /// SetCurrentDirectory
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        [DllImport("kernel32.dll", EntryPoint = "SetCurrentDirectory", SetLastError = true, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        internal static extern bool SetCurrentDirectory(string path);

        /// <summary>
        /// GetCurrentProcessId
        /// </summary>
        /// <returns></returns>
        [DllImport("kernel32.dll", EntryPoint = "GetCurrentProcessId", SetLastError = true, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        internal static extern uint GetCurrentProcessId();

        /// <summary>
        /// GetProcessIdOfThread
        /// </summary>
        /// <param name="handle"></param>
        /// <returns></returns>
        [DllImport("kernel32.dll", EntryPoint = "GetProcessIdOfThread", SetLastError = true, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        internal static extern uint GetProcessIdOfThread(IntPtr handle);

        /// <summary>
        /// Beep with Frequency and Duration
        /// </summary>
        /// <!-- Author TIPPO -->
        /// !NOTE! same Frequency doesn't hear our ear!.
        /// !NOTE! same Frequency are bad for Animals!.
        /// <!-- Author TIPPO -->
        /// <param name="frequency">Set the Frequency max. 32767</param>
        /// <param name="duration">Set the Duration for seconds</param>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>
        /// 
        /// </returns>
        [DllImport("kernel32.dll", EntryPoint = "Beep", SetLastError = true, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        internal static extern bool Beep(int frequency, int duration);

        /// <summary>
        /// GlobalMemoryStatusEx
        /// </summary>
        /// <!-- Author Tipplin -->
        /// 
        /// <!-- Author Tipplin -->
        /// <param name="lpBuffer"></param>
        /// <remarks>
        /// Write Windows Operation System Functions as wrapper Methods everytime ! in Visual C#.
        /// All Functions with end Ex are Operation System Calls, he calls them permament.
        /// make Query about Status! - Memory Status now? Storage free ?
        /// </remarks>
        [DllImport("kernel32.dll", EntryPoint = "GlobalMemoryStatusEx", SetLastError = true, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        internal static extern void GlobalMemoryStatusEx(ref MEMORYSTATUSEX lpBuffer);

        /// <summary>
        /// Get Tick Count at start Windows
        /// </summary>
        /// <remarks>
        /// NOTE: (source: Microsoft Developer)
        /// DON'T USE GetTickCount !, after 49 days overflow!
        /// GetTickCount64 is secure.
        /// </remarks>
        /// <returns>
        /// returns integer value as milliseconds
        /// </returns>
        [DllImport("kernel32.dll", EntryPoint = "GetTickCount64", SetLastError = true, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        internal static extern ulong GetTickCount64();

        /// <summary>
        /// Get Exit Code for current Process
        /// </summary>
        /// <!-- Author Tipplin 🧑 -->
        /// nice, Microsoft open Win32.SafeHandles for free use, 
        /// before was internal written in .NET Framework.
        /// Better safe Handles, most Windows Handles returned 0 or -1 = invalid handles !
        /// ATTENTION! DON'T FORGET CLOSE THE HANDLE ! - Forgotten and App close, the Handle is now open continue !.
        /// Windows: CloseHandle(IntPtr WindowsHandle)
        /// <!-- Author Tipplin 🧑 -->
        /// <param name="processHandle">Set Handle</param>
        /// <param name="exitCode">out exitcode</param>
        /// <returns>
        /// 
        /// </returns>
        [DllImport("kernel32.dll", EntryPoint = "GetExitCodeProcess", SetLastError = true, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern bool GetExitCodeProcess(Microsoft.Win32.SafeHandles.SafeProcessHandle processHandle, out int exitCode);


        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool GetProcessTimes(Microsoft.Win32.SafeHandles.SafeProcessHandle handle, out long creation, out long exit, out long kernel, out long user);


        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool GetThreadTimes(Microsoft.Win32.SafeHandles.SafeProcessHandle handle, out long creation, out long exit, out long kernel, out long user);





        /// <summary>
        /// Load Library
        /// </summary>
        /// <remarks>
        /// use for Network Library, that given returned Network Errors with Description string
        /// first the Network Library must load.
        /// </remarks>
        /// <returns>
        /// 
        /// </returns>
        [DllImport("kernel32.dll", EntryPoint = "LoadLibraryExW", SetLastError = true, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        internal static extern IntPtr LoadLibraryEx(
                                                     [MarshalAs(UnmanagedType.LPWStr)]
                                                         string LibFileName,
                                                     IntPtr hFile,
                                                     uint dwflags);

        /// <summary>
        /// Lock current Workstation on current Computer
        /// </summary>
        /// <!-- Author TIPPO -->
        /// Windows 10 Professional more Features as Home Edition:
        /// Windows Firewall with more Security Settings.(at Install the Firewall is off! actived it)
        /// Firewall was better as first come. If he found unsecure App, he block the App before execute.
        /// More Network Dll's at October Update 2018:
        /// WinSTAT.dll - 
        /// Windows Server Client Dll for Windows 10.
        /// !NOTE! don't forget your License Client and Server!.
        /// Microsoft Trigger running.
        /// <!-- Author TIPPO -->
        /// <remarks>
        /// Windows 10 Professional Edition works as Workstation,
        /// while now is Multi User System, one User or more on one Computer.
        /// Only Admin or Account Operator can add Users to System.
        /// 
        /// </remarks> 
        /// <returns>
        /// 
        /// </returns>
        [DllImport("kernel32.dll", EntryPoint = "LockWorkstation", SetLastError = true, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        internal static extern bool LockWorkstation();

        /// <summary>
        /// Search File with Path
        /// </summary>
        /// <!-- Author TIPPO -->
        /// The fast Method to search a File.
        /// <!-- Author TIPPO -->
        /// <param name="lpPath"></param>
        /// <param name="lpFileName"></param>
        /// <param name="lpExtension"></param>
        /// <param name="nBufferLength"></param>
        /// <param name="lpBuffer"></param>
        /// <param name="lpFilePart"></param>
        /// <remarks>
        /// Tip  Starting with Windows 10, version 1607, 
        /// for the unicode version of this function (SearchPathW), 
        /// you can opt-in to remove the MAX_PATH limitation. 
        /// See the "Maximum Path Length Limitation" section 
        /// of Naming Files, Paths, and Namespaces for details.
        /// </remarks>
        /// <returns>
        /// 
        /// </returns>
        [DllImport("kernel32.dll", EntryPoint = "SearchPathW", SetLastError = true, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        internal static extern uint SearchPath(
                                                string lpPath,
                                                string lpFileName,
                                                string lpExtension,
                                                int nBufferLength,
                                                StringBuilder lpBuffer,
                                                IntPtr lpFilePart);

        /// <summary>
        /// Get Volume Information
        /// </summary>
        /// <param name="RootPathName"></param>
        /// <param name="VolumeNameBuffer"></param>
        /// <param name="VolumeNameSize"></param>
        /// <param name="VolumeSerialNumber"></param>
        /// <param name="MaximumComponentLength"></param>
        /// <param name="FileSystemFlags"></param>
        /// <param name="FileSystemNameBuffer"></param>
        /// <param name="nFileSystemNameSize"></param>
        /// <returns></returns>
        [DllImport("kernel32.dll", EntryPoint = "GetVolumeInformationW", SetLastError = true, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        internal extern static bool GetVolumeInformation(

                                                         string RootPathName,
                                                         StringBuilder VolumeNameBuffer,
                                                         int VolumeNameSize,
                                                         out uint VolumeSerialNumber,
                                                         out uint MaximumComponentLength,
                                                         out FileSystemFeature FileSystemFlags,
                                                         StringBuilder FileSystemNameBuffer,
                                                         int nFileSystemNameSize);

        /// <summary>
        /// Set Computername with Extensions
        /// </summary>
        /// <param name="NameType">Set DNS Format-type</param>
        /// <param name="lpBuffer">Buffer</param>
        /// <returns></returns>
        [DllImport("kernel32.dll", EntryPoint = "SetComputerNameEx", SetLastError = true, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        internal static extern bool SetComputerNameEx(
                                                       COMPUTER_NAME_FORMAT NameType,
                                                       string lpBuffer);


        /// <summary>
        /// Set Computer Name Expand 2 - Netbios
        /// </summary>
        /// <!-- Author Tipplin -->
        /// NOTE! Windows 10 Function OS-Build 17134
        /// <!-- Author Tipplin-->
        /// <param name="NameType"></param>
        /// <param name="lpBuffer"></param>
        /// <remarks>
        /// StringBuilder have various Parameters
        /// for C++ Buffers:
        /// int capacity = 255;
        /// StringBuilder sb = StringBuilder(capacity);
        /// StringBuilder is 3000x faster as string.
        /// </remarks>
        /// <returns>
        /// 
        /// </returns>
        [DllImport("kernel32.dll", EntryPoint = "SetComputerNameEx2", SetLastError = true, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        internal static extern bool SetComputerNameEx2(
                                                       COMPUTER_NAME_FORMAT NameType,
                                                       StringBuilder lpBuffer);





        // wrong first letter written, message compiler "is extern marked but have no DllImportAttribute"
        // înternal - internal !

        /// <summary>
        /// Register Application for Restart
        /// </summary>
        /// <!-- Author TIPPO -->
        /// with this Method you can register your 
        /// Application in Windows Operation System for restart by shutdown, reboot,
        /// Windows startup and start this Application.
        /// Same function is RegisterWindowMessage(string MessageText),
        /// if set and run, Windows returned integer value for MessageText !.
        /// set constant in Project, use SendMessage(WM_BOARDCAST, integervalue,...);
        /// he send the Message to all open Window. 
        /// Can use as Admin Messages: 
        /// "Please close all App's, make in x minutes a Shutdown's for new App Update"...
        /// Windows Membership on Computer:
        /// Administrator have all Rights in Windows Operation System ! No, Member User!.
        /// Windows 10 lock same Folders.
        /// <!-- Author TIPPO -->
        /// <param name="pwzCommandline"></param>
        /// <param name="dwFlags"></param>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>
        /// 
        /// </returns>
        [DllImport("kernel32.dll", EntryPoint = "RegisterApplicationRestart", SetLastError = true, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        internal static extern long RegisterApplicationRestart(
                                                                [MarshalAs(UnmanagedType.LPWStr)]
                                                                string pwzCommandline,
                                                                uint dwFlags);

        // SleepEx
        // same as Sleep, second parameter bAlertable = false/true
        // true, after seconds wake up the thread and continue

        /// <summary>
        /// Sleep Extension
        /// </summary>
        /// <!-- Author Tippo -->
        /// set bAlertable on true, after Sleep interval value continue the Thread
        /// <!-- Author Tippo -->
        /// <param name="dwMilliseconds">Set Milliseconds</param>
        /// <param name="bAlertable">Set true or false</param>
        /// <remarks>
        /// SleepEx with call with asteric operator
        /// SleepEx(2000 * Methodname, false);
        /// or
        /// SleepEx(2000 * MessageBox(.), false ); 
        /// </remarks>
        /// <returns>
        /// 
        /// </returns>
        [DllImport("kernel32.dll", EntryPoint = "SleepEx", SetLastError = true, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        internal static extern uint SleepEx(uint dwMilliseconds, bool bAlertable);


        //------------- SPECIALs -----------------------------------------------
        // Sleep too in .NET Framework - syncron - Task.Delay is asyncron same ! 
        //
        // Sleep hold thread for milliseconds, 
        // than he call the Method with the operator asterics *
        // 
        // thread wait 5 seconds after he calls the Method.
        // Sleep(5000 * MethodnameCall);
        // 
        // Console App practicable for hold Statement, Messages, better as timer
        //----------------------------------------------------------------------
        
        /// <summary>
        /// Sleep
        /// </summary>
        /// <!-- Author Tipplin -->
        /// Sleep is syncron! - Task.Delay is asyncron
        /// Sleep with call with asteric operator
        /// Sleep(2000 * Methodname);
        /// or
        /// Sleep(2000 * MessageBox(.) );
        /// <!-- Author Tipplin-->
        /// <param name="dwMilliseconds">Set Milliseconds</param>
        /// <remarks>
        /// 
        /// </remarks>
        [DllImport("kernel32.dll", EntryPoint = "Sleep", SetLastError = true, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        internal static extern void Sleep(uint dwMilliseconds);

        /// <summary>
        /// GetLastError
        /// </summary>
        /// <!-- Author Tipplin -->
        /// GetLastError as compability
        /// <!-- Author Tipplin-->
        /// <remarks>
        /// GetLastError in .NET Framework as .GetLastWinError()
        /// Retrieves the calling thread's last-error code value. 
        /// The last-error code is maintained on a per-thread basis. 
        /// NOTE! Multiple threads do not overwrite each other's last-error code.
        /// 
        /// Windows 10 new function - RestoreLastError()
        /// 
        /// </remarks>
        /// <returns>
        /// 
        /// </returns>
        [DllImport("kernel32.dll", EntryPoint = "GetLastError", SetLastError = true, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        internal static extern uint GetLastError();

        /// <summary>
        /// Close Handle
        /// </summary>
        /// <param name="hObject"></param>
        /// <returns></returns>
        [DllImport("kernel32.dll", EntryPoint = "GetLastError", SetLastError = true, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        internal static extern bool CloseHandle(IntPtr hObject);

        /// <summary>
        /// Is Debugger present in System
        /// </summary>
        /// <returns></returns>
        [DllImport("kernel32.dll", EntryPoint = "IsDebuggerPresent", SetLastError = true, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        internal static extern bool IsDebuggerPresent();

        /// <summary>
        /// Determines whether the specified process is being debugged.
        /// </summary>
        /// <param name="hProcess"></param>
        /// <param name="pbDebuggerPresent"></param>
        /// <returns></returns>
        [DllImport("kernel32.dll", EntryPoint = "CheckRemoteDebuggerPresent", SetLastError = true, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        internal static extern bool CheckRemoteDebuggerPresent(IntPtr hProcess, bool pbDebuggerPresent);



        /// <summary>
        /// IsWow64Process2
        /// </summary>
        /// <!-- Author Tipplin -->
        /// New Function at Windows 10 
        /// <!-- Author Tipplin -->
        /// <param name="hProcess"></param>
        /// <param name="pProcessMachine"></param>
        /// <param name="pNativeMachine"></param>
        /// <remarks>
        /// Determines whether the specified process is running under WOW64; 
        /// also returns additional machine process and architecture information.
        /// 
        /// enum WOW64PROCESS_MACHINE pProcessMachine
        /// Alpha_AXP
        /// IMAGE_FILE_MACHINE_ALPHA = 0x0184,
        /// enum WOW64PROCESS_MACHINE pNativeMachine
        /// 
        /// </remarks>
        /// <returns>
        /// 
        /// </returns>
        [DllImport("kernel32.dll", EntryPoint = "IsWow64Process2", SetLastError = true, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        internal static extern bool IsWow64Process2(IntPtr hProcess,  WOW64PROCESS_MACHINE pProcessMachine, WOW64PROCESS_MACHINE pNativeMachine);

        /// <summary>
        /// Is Wow64 Guestmachine Supported
        /// </summary>
        /// <!-- Author Tipplin -->
        /// New Function at Windows 10 - Version 1709
        /// <!-- Author Tipplin -->
        /// <param name="WowGuestMachine"></param>
        /// <param name="MachineIsSupported"></param>
        /// <remarks>
        /// Determines which architectures are supported (under WOW64) on the given machine architecture.
        /// </remarks>
        /// <returns>
        /// On success, returns S_OK; 
        /// otherwise
        /// returns an error. 
        /// use GetWinLastError() in .NET - GetLastError() in C++ - to get error code
        /// </returns>
        [DllImport("kernel32.dll", EntryPoint = "IsWow64GuestMachineSupported", SetLastError = true, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        internal unsafe static extern long IsWow64GuestMachineSupported(WOW64PROCESS_MACHINE WowGuestMachine,  bool* MachineIsSupported);

        /// <summary>
        /// Is Processor FeaturePresent
        /// </summary>
        /// <!-- Author Tipplin -->
        /// Before Windows 10 not all Features queries.
        /// <!-- Author Tipplin -->
        /// <param name="pfp">Set Enum Feature Flags for Query is present.</param>
        /// <remarks>
        /// Determines whether the specified processor feature is supported by the current computer.
        /// </remarks>
        /// <returns>
        /// true is present the Feature
        /// false is not present the Feature.
        /// </returns>
        [DllImport("kernel32.dll", EntryPoint = "IsProcessorFeaturePresent", SetLastError = true, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        internal static extern bool IsProcessorFeaturePresent(PROCESSOR_FEATURE_PRESENT pfp);

        /// <summary>
        /// SetProcessAffinityMask
        /// </summary>
        /// <!-- Author Tipplin -->
        /// Microsoft Tool: CPU 0 to CPU 63 - manually, automatic, none
        /// CPU 0 hand offs, everytime for Operation System,
        /// check box control
        /// CPU1 O - runs In/Out Operations
        /// CPU2 O - calculation
        /// CPU3 O - background tasks
        /// ...
        /// 4 Processors
        /// -------------------------------------------------------------------
        /// the user end the Application, you must set
        /// via class Application (System.Windows.Form ca. 300 classes)
        /// set Application.QuitAllowed is a property (true/false),
        /// can the user ends the Application ? plus show a Message!
        /// "At Time you can't close the Application, a Thread/Work is running"
        /// Give short running threads and long running threads:
        /// long running thread is Microsoft SQL Server.
        /// MASK for CPU's Threads, Turbo-Mode MASK 0x3 for short time,
        /// priority is REALTIME, after work set down on NORMAL!
        /// Intel Processors internal 80BIT no overflow.
        /// Intel Datatype longdouble - NO Microsoft Support!
        /// Intel Random Generator in Processors (use with C++ Headerfiles)
        /// returned 16/32/64 BIT Random Values, everytime NEW!
        /// Intel Processor -name- have an Harddrive 
        /// on Chipset 64 Gigabytes like SSD Architecure.
        /// If you shutdown the System the datas are save on Processor SSD.
        /// 
        /// -------------------------------------------------------------------
        /// ----------- simplesample ------------------------------------------
        /// distributed work on different threads:
        /// ----------------------- CurrentThread on CPU 2 - MASK - 
        /// SetProcessAffinityMask(GetCurrentThread, 0x2);
        /// -------------------------------------------------------------------
        /// <!-- Author Tipplin -->
        /// <param name="hProcess"></param>
        /// <param name="dwProcessAffinityMask"></param>
        /// <remarks>
        /// The affinity mask for the threads of the process.
        /// On a system with more than 64 processors, the affinity mask must specify processors in a single processor group.
        /// </remarks>
        /// <returns>
        /// 
        /// </returns>
        [DllImport("kernel32.dll", EntryPoint = "SetProcessAffinityMask", SetLastError = true, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        internal unsafe static extern bool SetProcessAffinityMask(IntPtr hProcess, uint* dwProcessAffinityMask);




        #endregion


        #region ### ntdll.dll --- Windows System Dll - NT functions ###



        #endregion


        #region ### user32.dll --- Windows Operation System Dll - Functions ###

        /*
            * Windows OS Flags for ExitWindowsEx()
            * 
            * Flags at next Windows 10 SDK 18272
            * don't use at time, OS in develop!
            * NEW Windows 10 SDK 18282 -
            * ----------------------------------------------
            * #define EWX_LOGOFF                  0x00000000
            * #define EWX_SHUTDOWN                0x00000001
            * #define EWX_REBOOT                  0x00000002
            * #define EWX_FORCE                   0x00000004
            * #define EWX_POWEROFF                0x00000008
            * #define EWX_FORCEIFHUNG             0x00000010
            * #define EWX_HYBRID_SHUTDOWN         0x00400000
            * 
            * #define EWX_QUICKRESOLVE            0x00000020 NEW ! Flag
            * 
            * #define EWX_RESTARTAPPS             0x00000040 NEW ! Flag
            * Windows give Function for registered Application into System,
            * RegisterApplicationWindows(string AppName);
            * after reboot, Windows start the Application.
            * 
            * #define EWX_BOOTOPTIONS             0x01000000 NEW ! Flag
            * 
            * #define EWX_LOGOFF                  0x00000000
            * 
            * Windows 10 - 2019 - OS-Build 18309 SDK Preview
            * #define EWX_ARSO                    0x04000000 NEW ! Flag
            * 
            * 
            * 
            * ------------------------------------------------------------------
            * 
            * // System directive for Assembly and Win32Exception
            * using System.ComponentModel;
            * 
            * class Win32Exception - catch Windows Errors
            * catch(Win32Exception ex)when(ex.NativeCode == 0x000000c5)
            * {
            *   // statement ofr Access denied
            * }
            * 
            * 
            * Ermitteln der Klartext-Fehlerbeschreibung:
            * strErrorMessage = new Win32Exception(intLastErrorCode).Message
            * 
            * 
            * -----------------------------------------------------------------
            * Reason means
            * Major                Minor
            * Application          Update_Planned, Hotfix, Bugfix, Security fix      
            * Hardware
            * Software
            * System
            * 
            * ExitWindowsEx(EWX_REBOOT, Application | Update_Planned);
            * 
            * Shut down the system and force all applications to close. 
            * make flags for Windows Operation System what your want,
            * here Application as Major Reason, than upgrade planned.
            * 
            * ExitWindowsEx(EWX_SHUTDOWN | EWX_FORCE, SHTDN_REASON_MAJOR_APPLICATION | SHTDN_REASON_MINOR_UPGRADE | SHTDN_REASON_FLAG_PLANNED)) 
            * internal int SHTDN_REASON_MAJOR_APPLICATION = 0x00040000;
            * Minor Reason - Hotfix for your Software Product: (Planned)" A planned restart or shutdown to install a hot fix.
            * internal int SHTDN_REASON_MINOR_HOTFIX = 0x00000011;
            * Uninstall Hotfix
            * internal int SHTDN_REASON_MINOR_HOTFIX_UNINSTALL = 0x00000017;
            * Security Fix - "Security issue" The computer needs to be shut down due to a security issue. 
            * internal int SHTDN_REASON_MINOR_SECURITYFIX = 0x00000012;
            * internal int SHTDN_REASON_MINOR_SECURITYFIX_UNINSTALL = 0x00000018;
            * 
            * "Application: Unresponsive" An unplanned restart or shutdown to troubleshoot an unresponsive application.
            * SHTDN_REASON_MAJOR_APPLICATION | SHTDN_REASON_MINOR_HUNG 
            * 
            * "Application: Installation (Planned)" A planned restart or shutdown to perform application installation.
            * SHTDN_REASON_MAJOR_APPLICATION | SHTDN_REASON_MINOR_INSTALLATION | SHTDN_REASON_FLAG_PLANNED 
            * 
            *  "Application: Maintenance (Unplanned)" An unplanned restart or shutdown to service an application.
            * SHTDN_REASON_MAJOR_APPLICATION | SHTDN_REASON_MINOR_MAINTENANCE
            * 
            * "Application: Maintenance (Planned)" A planned restart or shutdown to perfor planned maintenance on an application.
            * SHTDN_REASON_MAJOR_APPLICATION | SHTDN_REASON_MINOR_MAINTENANCE | SHTDN_REASON_FLAG_PLANNED
            * 
            * "Application: Unstable" An unplanned restart or shutdown to troubleshoot an unstable application. 
            * SHTDN_REASON_MAJOR_APPLICATION | SHTDN_REASON_MINOR_UNSTABLE 
            *
            * 
            * New Windows UMBRELLA Libraries is a single link library that exports a subset of Win32 API's
            * 
            * API-MS-WIN-CORE-APIQUERY-L1-1-0.DLL
            * 
            * 
            * 
            * 
            * 
            * 
           */

        /// <summary>
        /// Exit Windows now and end with flags and reasons
        /// </summary>
        /// <!-- Author Tipplin -->
        /// NOTE: 
        /// Use now the New Windows 10 SDK 18362.0 Release this SDK is fix,
        /// with download at Windows Downlaod Center.
        /// (Windows 10 OS-Build 18362 is fix Release Preview, 
        /// only the Revision increment by Microsoft after cleanup by Bugs. 
        /// at Time OS-Build 18362 and Revision 86 after Bugsfixes, 
        /// Windows 10 May Update 2019 Build 18362, Revisions are cumulative updates !)
        /// 
        /// NEW The ExitWindowsEx rearchitect by Windows Developer team.
        /// _When_((uFlags(EWX_POWEROFF|EWX_SHUTDOWN|EWX_FORCE))!=0,
        /// __drv_preferredFunction("InitiateSystemShutdownEx", "Legacy API. Rearchitect to avoid Reboot"))
        /// 
        /// 
        /// write for Parameter dwReason (DWORD - C#: uint) 
        /// an Enumerator SHTDN_REASON_CODES - Shutdown Reason Codes
        /// 
        /// The Flags
        /// EWX_LOGOFF                  0x00000000
        /// EWX_SHUTDOWN                0x00000001
        /// EWX_REBOOT                  0x00000002
        /// EWX_FORCE                   0x00000004
        /// EWX_POWEROFF                0x00000008
        /// EWX_FORCEIFHUNG             0x00000010
        /// EWX_HYBRID_SHUTDOWN         0x00400000
        /// 
        /// New Flags
        /// EWX_BOOTOPTIONS             0x01000000
        /// EWX_QUICKRESOLVE            0x00000020
        /// EWX_RESTARTAPPS             0x00000040
        /// EWX_ARSO                    0x04000000
        /// ! NEW Flag ! Windows 10 - SDK Build 19546.0
        /// EWX_CHECK_SAFE_FOR_SERVER   0x08000000
        /// 
        /// <!-- Author Tipplin -->
        /// <param name="uFlags">Set Flag</param>
        /// <param name="dwReason">Set Major and Minor Reasons</param>
        /// <remarks>
        /// dwreason use for many Works, upgrades planned, security fix, bug fix...
        /// 
        /// </remarks>
        /// <returns>
        /// 
        /// </returns>
        [DllImport("user32.dll", EntryPoint = "ExitWindowsEx", SetLastError = true, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        internal static extern bool ExitWindowsEx(EWX_SHUTDOWN_FLAGS uFlags, SHTDN_REASON_CODES dwReason);


        /// <summary>
        /// Switch to a other Window
        /// </summary>
        /// <param name="WindowHandle">Set the Window Handle</param>
        /// <param name="fUnknown">
        /// A TRUE for this parameter indicates that the window is 
        /// being switched to using the Alt / Ctl + Tab key sequence. 
        /// This parameter should be FALSE otherwise.</param>
        /// <returns></returns>
        [DllImport("user32.dll", EntryPoint = "SwitchToThisWindow", SetLastError = true, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        internal static extern bool SwitchToThisWindow(IntPtr WindowHandle, bool fUnknown);

        /// <summary>
        /// Change the Window Text as Caption
        /// </summary>
        /// <param name="WindowHandle"></param>
        /// <param name="NewWindowText"></param>
        /// <returns></returns>
        [DllImport("user32.dll", EntryPoint = "SetWindowTextW", SetLastError = true, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        internal static extern bool SetWindowText(
                                                    IntPtr WindowHandle,
                                                    [MarshalAs(UnmanagedType.LPWStr)]
                                                    string NewWindowText);

        /// <summary>
        /// Register your Messagetext in Windows
        /// </summary>
        /// <param name="Message"></param>
        /// <returns>
        /// Windows returned a integer value for this MessageText for use!.
        /// </returns>
        [DllImport("user32.dll", EntryPoint = "RegisterWindowMessageW", SetLastError = true, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        internal static extern int RegisterWindowMessage(
                                                            [MarshalAs(UnmanagedType.LPWStr)]
                                                            string Message);

        /// <summary>
        /// Flash the given Window
        /// </summary>
        /// <remarks>
        /// Flash Caption or all or Frame
        /// set in Struct
        /// </remarks>
        /// <returns>
        /// 
        /// </returns>
        [DllImport("user32.dll", EntryPoint = "FlashWindowEx", SetLastError = true, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        internal static extern bool FlashWindowEx(FLASHWINFO pfwi);

        /// <summary>
        /// Set Last Error Extend
        /// </summary>
        /// <!-- Author TIPPO -->
        /// All Windows Operation Systems Functions with extention Ex,
        /// write en Wrapper Method, while Windows permanent calls internal this Functions.
        /// ! NOTE ! this is in new Windows 10 SDK OS-Build 18272 - 19H1 - 2019
        /// before this OS, the Error-Type is ignore!
        /// Can use this Method in Debug Mode for Dynamic Link Library loading
        /// is failed: set SLE_ERROR or SLE_WARNING.
        /// <!-- Author TIPPO -->
        /// <param name="dwErrCode">Set the errorcode</param>
        /// <param name="dwType">Set the Error-Type from Enumerator SLE</param>
        /// <remarks>
        /// Windows 10 SDK 18362
        /// SLE is written as Enumerator: 
        /// SLE_ERROR
        /// type is error
        /// SLE_MINORERROR
        /// type is minorerror
        /// SLE_WARNING
        /// type is warning
        /// </remarks>
        [DllImport("user32.dll", EntryPoint = "SetLastErrorEx", SetLastError = true, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        internal static extern void SetLastErrorEx(int dwErrCode, SLE dwType);

        

        /// <summary>
        /// Get Classname for Window
        /// </summary>
        /// <param name="WindowHandle"></param>
        /// <param name="lpClassName"></param>
        /// <param name="nMaxCount"></param>
        /// <returns></returns>
        [DllImport("user32.dll", EntryPoint = "GetClassName", SetLastError = true, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        internal static extern int GetClassName(
                                                IntPtr WindowHandle,
                                                StringBuilder lpClassName,
                                                int nMaxCount);

        /// <summary>
        /// Is Windows Visible
        /// </summary>
        /// <param name="WindowHandle"></param>
        /// <returns></returns>
        [DllImport("user32.dll", EntryPoint = "IsWindowVisible", SetLastError = true, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        internal static extern bool IsWindowVisible(IntPtr WindowHandle);

        /// <summary>
        /// Sets the specified window's show state.
        /// </summary>
        /// <param name="WindowHandle">
        /// Set Windows Handle for bound to parent Window with this.handle in Form.
        /// or 
        /// set IntPtr.Zero for not bound
        /// </param>
        /// <param name="nCmdShow">
        /// 
        /// </param>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>
        /// 
        /// </returns>
        [DllImport("user32.dll", EntryPoint = "IsWindowVisible", SetLastError = true, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        internal static extern bool ShowWindow(IntPtr WindowHandle, SHOW_FLAGS nCmdShow);

        /// <summary>
        /// SetUserObjectSecurity
        /// </summary>
        /// <param name="hObj"></param>
        /// <param name="pSIRequested"></param>
        /// <param name="pSID"></param>
        /// <returns></returns>
        [DllImport("user32.dll", EntryPoint = "SetUserObjectSecurity", SetLastError = true, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        internal static extern bool SetUserObjectSecurity(IntPtr hObj, ref SECURITY_INFORMATION pSIRequested, ref SECURITY_DESCRIPTOR pSID);

        /// <summary>
        /// Is Hung Application Window ?
        /// IsHungAppWindow
        /// </summary>
        /// <param name="WindowHandle">Set Window Handle</param>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>
        /// 
        /// </returns>
        [DllImport("user32.dll", EntryPoint = "IsHungAppWindow", SetLastError = true, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        internal static extern bool IsHungAppWindow(IntPtr WindowHandle);

        /// <summary>
        /// Print given Window
        /// </summary>
        /// <param name="WindowHandle">Set WindowHandle</param>
        /// <param name="hdcBlt">Pointer DC Printer</param>
        /// <param name="nFlags">Flags</param>
        /// <returns></returns>
        [DllImport("user32.dll", EntryPoint = "PrintWindow", SetLastError = true, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        internal static extern bool PrintWindow(IntPtr WindowHandle, IntPtr hdcBlt, uint nFlags);

        /// <summary>
        /// Sets the specified window's show state.
        /// </summary>
        /// <param name="WindowHandle">A handle to the window.</param>
        /// <param name="CmdShow">
        /// Controls how the window is to be shown. 
        /// This parameter is ignored the first time an application calls ShowWindow, 
        /// if the program that launched the application provides a STARTUPINFO structure. 
        /// Otherwise, the first time ShowWindow is called, 
        /// the value should be the value obtained by the WinMain function in its nCmdShow parameter. 
        /// In subsequent calls, this parameter can be one of the following values.
        /// </param>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>
        /// If the window was previously visible, the return value is nonzero.
        /// If the window was previously hidden, the return value is zero.
        /// </returns>
        [DllImport("user32.dll", EntryPoint = "ShowWindow", SetLastError = true, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        internal static extern bool ShowWindow(IntPtr WindowHandle,  int CmdShow);



        /// <summary>
        /// GetMessage
        /// </summary>
        /// <param name="lpMsg"></param>
        /// <param name="WindowHandle"></param>
        /// <param name="wMsgFilterMin"></param>
        /// <param name="wMsgFilterMax"></param>
        /// <returns></returns>
        [DllImport("user32.dll", EntryPoint = "GetMessageW", SetLastError = true, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        internal static extern bool GetMessage(ref MSG lpMsg, IntPtr WindowHandle, uint wMsgFilterMin, uint wMsgFilterMax);

        /// <summary>
        /// Set Message Queue
        /// </summary>
        /// <param name="cMessagesMax"></param>
        /// <returns></returns>
        [DllImport("user32.dll", EntryPoint = "GetMessageW", SetLastError = true, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        internal static extern bool SetMessageQueue( int cMessagesMax);

        /// <summary>
        /// Send Message Timeout
        /// </summary>
        /// <!-- Author Tipplin -->
        /// Sends the specified message to one or more windows.
        /// <!-- Author Tipplin -->
        /// <param name="WindowHandle">
        /// A handle to the window whose window procedure will receive the message.
        /// If this parameter is HWND_BROADCAST ((HWND)0xffff), 
        /// the message is sent to all top-level windows in the system, 
        /// including disabled or invisible unowned windows. 
        /// The function does not return until each window has timed out.
        /// Therefore, the total wait time can be up to the value of 
        /// uTimeout multiplied by the number of top-level windows.
        /// </param>
        /// <param name="Msg">
        /// The message to be sent.
        /// For lists of the system-provided messages, see System-Defined Messages.
        /// </param>
        /// <param name="wParam">
        /// Any additional message-specific information.
        /// </param>
        /// <param name="lParam">
        /// Any additional message-specific information.
        /// </param>
        /// <param name="fuFlags">
        /// The behavior of this function. This parameter can be one or more of the following values.
        /// </param>
        /// <param name="uTimeout">
        /// The duration of the time-out period, in milliseconds.
        /// If the message is a broadcast message, 
        /// each window can use the full time-out period. 
        /// For example, if you specify a five second time-out period and 
        /// there are three top-level windows that fail to process the message, 
        /// you could have up to a 15 second delay.
        /// </param>
        /// <param name="lpdwResult">
        /// The result of the message processing. 
        /// The value of this parameter depends on the message that is specified.
        /// </param>
        /// <remarks>
        /// If the function succeeds, the return value is nonzero.
        /// SendMessageTimeout does not provide information about individual windows timing out 
        /// if HWND_BROADCAST is used.If the function fails or times out, 
        /// the return value is 0. 
        /// To get extended error information, call GetLastError.
        /// If GetLastError returns ERROR_TIMEOUT, then the function timed out.
        /// </remarks>
        /// <returns>
        /// The function calls the window procedure for the specified window and, 
        /// if the specified window belongs to a different thread, 
        /// does not return until the window procedure has processed the message or 
        /// the specified time-out period has elapsed.
        /// If the window receiving the message belongs to the same queue as the current thread, 
        /// the window procedure is called directly—the time-out value is ignored.
        /// This function considers that a thread is not responding 
        /// if it has not called GetMessage or a similar function within five seconds
        /// The system only does marshalling for system messages (those in the range 0 to (WM_USER-1)). 
        /// To send other messages(those >= WM_USER) to another process, you must do custom marshalling.
        /// </returns>
        [DllImport("user32.dll", EntryPoint = "SendMessageTimeoutW", SetLastError = true, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        internal static extern long SendMessageTimeout(IntPtr WindowHandle,
                                                        uint Msg,
                                                        IntPtr wParam,
                                                        IntPtr lParam,
                                                        uint fuFlags,
                                                        uint uTimeout,
                                                        IntPtr lpdwResult);




        [DllImport("user32.dll", EntryPoint = "SendMessageW", SetLastError = true, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        internal static extern long SendMessage(IntPtr WindowHandle,
                                                 uint Msg,
                                                 IntPtr wParam,
                                                 IntPtr lParam);










        #endregion


        #region ### secur32.dll --- Windows System Dll - Lsa, Security,



        /// <summary>
        /// GetComputerNameEx
        /// </summary>
        /// <param name="NameType"></param>
        /// <param name="lpBuffer"></param>
        /// <param name="nSize"></param>
        /// <remarks>
        /// Retrieves a NetBIOS or DNS name associated with the local computer. 
        /// The names are established at system startup, when the system reads them from the registry.
        /// </remarks>
        /// <returns>
        /// returned not false or true, while a Special Windows Boolean is 1 byte only,
        /// in Visual C# use byte as datatype returned 0 or 1.
        /// </returns>
        [DllImport("secur32.dll", EntryPoint = "GetComputerNameExW", SetLastError = true, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        internal static extern byte GetComputerNameEx(
                                                       COMPUTER_NAME_FORMAT NameType,
                                                       StringBuilder lpBuffer,
                                                       int nSize);

        /// <summary>
        /// Get Computername extention 2
        /// </summary>
        /// <!-- Author TIPPO -->
        /// NOTE! Only at Windows 10 Operation System !
        /// NetBIOS and DNS System
        /// NOTE: 
        /// Windows 10 Professional Edition only !, while is as Workstation works.
        /// Windows 10 Professional Edition more and more Network, Cloud, Server Functionality inside have.
        /// (Sample: Windows Server Client Library for Windows 10 Professional, but you must have the CAL License !.
        /// Download free: Remote Server Administration Tools for Windows 10 Professional, many Server Tools:
        /// Install done: Windows 10 Server Dashbroad - Server Websites, create new Servergroup and many more...)
        /// 
        /// 
        /// <!-- Author TIPPO -->
        /// <param name="NameType"></param>
        /// <param name="lpBuffer"></param>
        /// <param name="nSize"></param>
        /// <remarks>
        /// NOTE! Only at Windows 10 Operation System !
        /// </remarks>
        /// <returns>
        /// returned not false or true, while a Special Windows Boolean is 1 byte only,
        /// in Visual C# use byte as datatype returned 0 or 1. 
        /// </returns>
        [DllImport("secur32.dll", EntryPoint = "GetComputerNameEx2W", SetLastError = true, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        internal static extern byte GetComputerNameEx2(
                                                        COMPUTER_NAME_FORMAT NameType,
                                                        StringBuilder lpBuffer,
                                                        int nSize);

        /// <summary>
        /// SetComputerName
        /// </summary>
        /// <param name="lpComputerName">Set Computername here</param>
        /// <remarks>
        /// Set Computername that will take effect the next time the Computer is started. 
        /// </remarks>
        /// <returns>
        /// returned false or true set computername or not!
        /// </returns>
        [DllImport("secur32.dll", EntryPoint = "SetComputerNameW", SetLastError = true, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        internal static extern bool SetComputerName(
                                                        [MarshalAs(UnmanagedType.LPWStr)]
                                                        string lpComputerName);




        /// <summary>
        /// GetUsernameEx
        /// </summary>
        /// <!-- Author TIPPO -->
        /// ! ATTENTION ! This Methods in ONLY in Windows 10 Operation System, more Information.
        /// While Windows 10 a Multi User System is now!, one User or more on one Computer, own User Datebase.
        /// Windows 10 October Update 2018 the LogIn change Screen Sig In - with/without Photo, name or Nickname
        /// Fingerprint, Face detection, PIN, Password (NOTE: change to PIN, No Password Insert)
        /// severely handicapped and paraplegic: Eye-Control, means the Eyes can execute commands.
        /// but must the Eye Device too.
        /// For control, check Windows Operation System make query is Windows 10 ?
        /// 
        /// 
        /// 
        /// <!-- Author TIPPO -->
        /// <remarks>
        /// !NOTE! same Windows Functions have boolean as return value, but there is special bool in Windows is only 1 byte !.
        /// (Windows datatypes internal: real, float, string[], )
        /// so set NO bool for this Methods, so set byte - here byte GetUserNameEx2 - Only in Windows 10 -
        /// </remarks>
        /// <param name="NameType"></param>
        /// <param name="lpBuffer"></param>
        /// <param name="nSize"></param>
        /// <returns>
        /// returned not false or true, while a Special Windows Boolean is 1 byte only,
        /// in Visual C# use byte as datatype returned 0 or 1. 
        /// </returns>
        [DllImport("secur32.dll", EntryPoint = "GetUserNameExW", SetLastError = true, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        internal static extern byte GetUserNameEx(
                                                        EXTENDED_NAME_FORMAT NameType,
                                                        StringBuilder lpBuffer,
                                                        Int64 nSize);

        /// <summary>
        /// Sets a new NetBIOS or DNS name for the local computer. 
        /// Name changes made by SetComputerNameEx 
        /// do not take effect until the user restarts the computer.
        /// </summary>
        /// <param name="NameType">Set enum type</param>
        /// <param name="lpBuffer">Set the new name</param>
        /// <returns></returns>
        [DllImport("secur32.dll", EntryPoint = "SetUserNameExW", SetLastError = true, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        internal static extern byte SetUserNameEx(
                                                        EXTENDED_NAME_FORMAT NameType,
                                                        [MarshalAs(UnmanagedType.LPWStr)]
                                                        string lpBuffer);


        /// <summary>
        /// Set Username with Extension 2
        /// </summary>
        /// <param name="NameType"></param>
        /// <param name="lpBuffer"></param>
        /// <remarks>
        ///  ATTENTION ! GetComputerNameEx2 at Windows 10 only !
        /// </remarks>
        /// <returns>
        /// returned not false or true, while a Special Windows Boolean is 1 byte only,
        /// in Visual C# use byte as datatype returned 0 or 1. 
        /// </returns>
        [DllImport("secur32.dll", EntryPoint = "SetUserNameEx2", SetLastError = true, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        internal static extern byte SetUserNameEx2(
                                                        EXTENDED_NAME_FORMAT NameType,
                                                        int lpBuffer);












        #endregion


        #region ### user32.dll --- Windows System Dll - user functions ###

        /*
              ***  WinUser.h - user32.dll - from Windows 10 SDK 18309 ***
        WINUSERAPI
        BOOL
        WINAPI
        SetUserObjectSecurity(
            _In_ HANDLE hObj,
            _In_ PSECURITY_INFORMATION pSIRequested,
            _In_ PSECURITY_DESCRIPTOR pSID);

        WINUSERAPI
        BOOL
        WINAPI
        IsHungAppWindow( 
        _In_ HWND hwnd); // A handle to the window to be tested.

        Determines whether the system considers that a specified application is not responding. 
        An application is considered to be not responding if it is not waiting for input, 
        is not in startup processing, and 
        has not called PeekMessage within the internal timeout period of 5 seconds.
        Return Value
        Type: Type: BOOL
        The return value is TRUE if the window stops responding; otherwise, it is FALSE. 
        Ghost windows always return TRUE.





        WINUSERAPI
        BOOL
        WINAPI
        GetMessageW(
            _Out_ LPMSG lpMsg,
            _In_opt_ HWND hWnd,
            _In_ UINT wMsgFilterMin,
            _In_ UINT wMsgFilterMax);


        WINUSERAPI
        BOOL
        WINAPI
        SetMessageQueue( _In_ int cMessagesMax);


                WINUSERAPI
                LRESULT
        WINAPI
        SendMessageTimeoutW(
            _In_ HWND hWnd,
            _In_ UINT Msg,
            _In_ WPARAM wParam,
            _In_ LPARAM lParam,
            _In_ UINT fuFlags,
            _In_ UINT uTimeout,
            _Out_opt_ PDWORD_PTR lpdwResult);

                WINUSERAPI
        long
        WINAPI
        BroadcastSystemMessageExW(
            _In_ DWORD flags,
            _Inout_opt_ LPDWORD lpInfo,
            _In_ UINT Msg,
            _In_ WPARAM wParam,
            _In_ LPARAM lParam,
            _Out_opt_ PBSMINFO pbsmInfo);

        // Broadcast Special Message Recipient list

        #define BSM_ALLCOMPONENTS       0x00000000
        #define BSM_VXDS                0x00000001
        #define BSM_NETDRIVER           0x00000002
        #define BSM_INSTALLABLEDRIVERS  0x00000004
        #define BSM_APPLICATIONS        0x00000008 // all Applications
        #define BSM_ALLDESKTOPS         0x00000010

        //Broadcast Special Message Flags
        #define BSF_QUERY               0x00000001
        #define BSF_IGNORECURRENTTASK   0x00000002
        #define BSF_FLUSHDISK           0x00000004
        #define BSF_NOHANG              0x00000008
        #define BSF_POSTMESSAGE         0x00000010
        #define BSF_FORCEIFHUNG         0x00000020
        #define BSF_NOTIMEOUTIFNOTHUNG  0x00000040
        #define BSF_ALLOWSFW            0x00000080
        #define BSF_SENDNOTIFYMESSAGE   0x00000100

        #define BSF_RETURNHDESK         0x00000200
        #define BSF_LUID                0x00000400


        WINUSERAPI
        BOOL
        WINAPI
        PrintWindow(
            _In_ HWND hwnd,
            _In_ HDC hdcBlt,
            _In_ UINT nFlags);

            The PrintWindow function copies a visual window into 
            the specified device context (DC), typically a printer DC.

        WINAPI
        IsCharAlphaW(
            _In_ WCHAR ch);

        WINUSERAPI
        BOOL
        WINAPI
        IsCharAlphaNumericW(
            _In_ WCHAR ch);

        WINUSERAPI
        BOOL
        WINAPI
        IsCharUpperW(
            _In_ WCHAR ch);

        WINUSERAPI
        BOOL
        WINAPI
        IsCharLowerW(
            _In_ WCHAR ch);

        WINUSERAPI
        HWND
        WINAPI
        SetFocus(
            _In_opt_ HWND hWnd);


        WINUSERAPI
        HWND
        WINAPI
        SetActiveWindow(
            _In_ HWND hWnd);

        WINUSERAPI
        BOOL
        WINAPI
        UpdateWindow(
            _In_ HWND hWnd);

        WINUSERAPI
        VOID
        WINAPI
        SwitchToThisWindow(
            _In_ HWND hwnd,
            _In_ BOOL fUnknown);

        WINUSERAPI
        BOOL
        WINAPI
        AllowSetForegroundWindow(
            _In_ DWORD dwProcessId);


        WINUSERAPI
        BOOL
        WINAPI
        LockSetForegroundWindow(
            _In_ UINT uLockCode);

        #define LSFW_LOCK       1
        #define LSFW_UNLOCK     2

        WINUSERAPI
        BOOL
        WINAPI
        SetWindowTextW(
            _In_ HWND hWnd,
            _In_opt_ LPCWSTR lpString);

  
        System Sounds (idChild of system SOUND notification)
 
        #define SOUND_SYSTEM_STARTUP            1
        #define SOUND_SYSTEM_SHUTDOWN           2
        #define SOUND_SYSTEM_BEEP               3
        #define SOUND_SYSTEM_ERROR              4
        #define SOUND_SYSTEM_QUESTION           5
        #define SOUND_SYSTEM_WARNING            6
        #define SOUND_SYSTEM_INFORMATION        7
        #define SOUND_SYSTEM_MAXIMIZE           8
        #define SOUND_SYSTEM_MINIMIZE           9
        #define SOUND_SYSTEM_RESTOREUP          10
        #define SOUND_SYSTEM_RESTOREDOWN        11
        #define SOUND_SYSTEM_APPSTART           12
        #define SOUND_SYSTEM_FAULT              13
        #define SOUND_SYSTEM_APPEND             14
        #define SOUND_SYSTEM_MENUCOMMAND        15
        #define SOUND_SYSTEM_MENUPOPUP          16
        #define CSOUND_SYSTEM                   16


        System Alerts (indexChild of system ALERT notification)
         
        #define ALERT_SYSTEM_INFORMATIONAL      1       // MB_INFORMATION
        #define ALERT_SYSTEM_WARNING            2       // MB_WARNING
        #define ALERT_SYSTEM_ERROR              3       // MB_ERROR
        #define ALERT_SYSTEM_QUERY              4       // MB_QUESTION
        #define ALERT_SYSTEM_CRITICAL           5       // HardSysErrBox
        #define CALERT_SYSTEM                   6

                WINUSERAPI
                BOOL
        WINAPI
        ShutdownBlockReasonCreate(
            _In_ HWND hWnd,
            _In_ LPCWSTR pwszReason);



            Defines a new window message that is guaranteed to be unique throughout the system. The message value can be used when sending or posting messages.
            UINT RegisterWindowMessageW(
            LPCWSTR lpString); // The message to be registered.



            */

        /// <summary>
        /// GetKeyState
        /// </summary>
        /// <param name="virtualKeyCode"></param>
        /// <returns></returns>
        [DllImport("user32.dll", EntryPoint = "GetKeyState", SetLastError = true, CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        internal static extern short GetKeyState(int virtualKeyCode);

        /// <summary>
        /// GetProcessWindowStation
        /// </summary>
        /// <returns></returns>
        [DllImport("user32.dll", EntryPoint = "GetProcessWindowStation", SetLastError = true, CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        internal static extern IntPtr GetProcessWindowStation();

        
        /// <summary>
        /// DestroyWindow
        /// </summary>
        /// <param name="hWnd"></param>
        /// <returns></returns>
        [DllImport("user32.dll", EntryPoint = "DestroyWindow", SetLastError = true, CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        internal static extern bool DestroyWindow(IntPtr hWnd);

        /// <summary>
        /// SetForegroundWindow
        /// </summary>
        /// <param name="hWnd"></param>
        /// <returns></returns>
        [DllImport("user32.dll", EntryPoint = "SetForegroundWindow", SetLastError = true, CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        internal static extern bool SetForegroundWindow(IntPtr hWnd);

        /// <summary>
        /// Find Window
        /// </summary>
        /// <param name="lpClassName"></param>
        /// <param name="lpWindowName"></param>
        /// <returns></returns>
        [DllImport("user32.dll", EntryPoint = "FindWindowW", SetLastError = true, CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        internal static extern IntPtr FindWindow(
                                                    [MarshalAs(UnmanagedType.LPWStr)]
                                                    string lpClassName,
                                                    [MarshalAs(UnmanagedType.LPWStr)]
                                                    string lpWindowName);

        /// <summary>
        /// Messagebox with Timeout
        /// </summary>
        /// <!-- Authpr TIPPO -->
        /// 
        /// <!-- Author TIPPO -->
        /// <param name="WindowHandle">Set Window Handle for Parent Window with (bound) this.handle or set IntPtr.Zero for not bound.</param>
        /// <param name="Text">Set Messagebox text</param>
        /// <param name="Title">Set Messagebox Title</param>
        /// <param name="type">Own famous Styles as Enumerator in a intellisense Window</param>
        /// <param name="wLanguageId">Set 0</param>
        /// <param name="milliseconds">Set Timerout interval in Milliseconds - TIP: 1000 - max. 5000</param>
        /// <remarks>
        /// MessageBox close automatic after Timeoutinterval (milliseconds)
        /// without User Action.
        /// </remarks>
        /// <returns>
        /// 
        /// </returns>
        [DllImport("user32.dll", EntryPoint = "MessageBoxTimeoutW", SetLastError = true, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        static extern int MessageBoxTimeout(IntPtr WindowHandle, 
                                            [MarshalAs(UnmanagedType.LPWStr)]
                                            string Text,
                                            [MarshalAs(UnmanagedType.LPWStr)]
                                            string Title, 
                                            STYLES type, 
                                            int wLanguageId, 
                                            int milliseconds);



#endregion


        #region ### shell32.dll --- Windows System Dll - shell functions, ###

        /// <summary>
        /// Trash
        /// </summary>
        /// <param name="WindowHandle"></param>
        /// <param name="pszRootPath"></param>
        /// <param name="dwFlags"></param>
        /// <returns></returns>
        [DllImport("shell32.dll", EntryPoint = "SHEmptyRecycleBinW", SetLastError = true, CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        internal static extern long SHEmptyRecycleBin( 
                                                        IntPtr WindowHandle,
                                                        [MarshalAs(UnmanagedType.LPWStr)]
                                                        string pszRootPath,
                                                        SHERB_TRASH dwFlags);
        
        /// <summary>
        /// Windows Operation System Restriction Function
        /// </summary>
        /// <!-- Author Tipplin -->
        /// -------------------------------------------------------
        /// Please hand off for beginners !
        /// Only for System-Administrators !
        /// -------------------------------------------------------
        /// While Restriction Value at runtime is active,
        /// so the setting Restriction not allowed the User to run.
        /// -------------------------------------------------------
        /// Use from Windows 10 SDK 18309, but note in later 
        /// Version, Microsoft can remove old Functions.
        /// <!-- Author Tipplin -->
        /// <param name="rest"></param>
        /// <remarks>
        /// Very Dangerous for other users!, please don't use it!
        /// ONLY SYSTEM-ADMINISTRATORS !.
        /// In Windows Operation System Administrators have the Full right's on Computer,
        /// not Member User, Windows 10 lock same Folders/files !.
        /// For System-tools an little Help, Main-Menu > Windows-System > command line tool (cmd.exe) > right click > run as administrator
        /// Tipplin Tip: Main-Menu move then right mouse click have a extra menue.
        /// </remarks>
        /// <returns>
        /// 
        /// </returns>
        [DllImport("shell32.dll", EntryPoint = "SHRestricted", SetLastError = true, CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        internal static extern uint SHRestricted(ref RESTRICTIONS rest);

        



        #endregion

        #region ### Wininet.dll - Internet Functions ###



        /// <summary>
        /// [InternetCheckConnection is available for use in the 
        /// operating systems specified in the Requirements section. 
        /// It may be altered or unavailable in subsequent versions. 
        /// Instead, use NetworkInformation.GetInternetConnectionProfile or the NLM Interfaces. ]
        /// Allows an application to check if a connection to the Internet can be established
        /// </summary>
        /// <param name="lpszUrl"></param>
        /// <param name="dwFlags"></param>
        /// <param name="dwReserved"></param>
        /// <returns></returns>
        [DllImport("Wininet.dll", EntryPoint = "InternetCheckConnectionW", SetLastError = true, CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        internal static extern bool InternetCheckConnection(
                                                            [MarshalAs(UnmanagedType.LPWStr)]
                                                            string lpszUrl,
                                                            uint dwFlags,
                                                            uint dwReserved);

        // Creates a URL from its component parts.

        /// <summary>
        /// 
        /// </summary>
        /// <param name="lpUrlComponents"></param>
        /// <param name="dwFlags"></param>
        /// <param name="lpszUrl"></param>
        /// <param name="lpdwUrlLength"></param>
        /// <returns></returns>
        [DllImport("Wininet.dll", EntryPoint = "InternetCreateUrlW", SetLastError = true, CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        internal static extern bool InternetCreateUrl(
                                                        IntPtr lpUrlComponents,
                                                        uint dwFlags,
                                                        [MarshalAs(UnmanagedType.LPWStr)]
                                                        string lpszUrl,
                                                        uint lpdwUrlLength);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="lpszURL"></param>
        /// <param name="hwndParent"></param>
        /// <param name="dwFlags"></param>
        /// <returns></returns>
        [DllImport("Wininet.dll", EntryPoint = "InternetCreateUrlW", SetLastError = true, CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        internal static extern bool InternetGoOnline(
                                                        [MarshalAs(UnmanagedType.LPWStr)]
                                                        string lpszURL,
                                                        IntPtr hwndParent,
                                                        uint dwFlags);
        [DllImport("Wininet.dll", EntryPoint = "InternetCreateUrlW", SetLastError = true, CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        internal static extern void InternetOpenUrl(
                                                      IntPtr hInternet,
                                                      [MarshalAs(UnmanagedType.LPWStr)]
                                                      string lpszUrl,
                                                      [MarshalAs(UnmanagedType.LPWStr)]
                                                      string lpszHeaders,
                                                      uint dwHeadersLength,
                                                      uint dwFlags,
                                                      uint dwContext);

        #endregion


        #region ### NT.dll ###

        //
        //  Crc32 and Crc64 routines that use standardized algorithms
        //

        /*
         * USA have now leap second October 2018 - 05:59:59 old - new 05:59:60 - 05:60:00
         * Earth is running slowly.
         * For Europe and Germany: PTB Braunschweig/Berlin end of 2018
         * Syncronization Clock with them with three Network Addresses, PC and Server.
         * 
         * NEW ! Functions in Windows 10 - 2019 - 19H1 -
         * DON'T USE AT TIME !
         * 
         * NEW ! Datatypes float128, Register128 and more...
         * under foreward! 128BIT for next Big Data's
         * 
         * Yottabyte, Zettabyte factor 17 - International Bureau of Measurement and Weights in Paris:
         * Gigabyte wrong Description - Gibi Byte = Giga Binary Byte
         * Gigabyte different value to the right Giga Binary Byte is the correctness Value
         * 
         * 
         * 
        /// <summary>
        /// CRC32
        /// </summary>
        /// <param name="Buffer"></param>
        /// <param name="Size"></param>
        /// <param name="InitialCrc"></param>
        /// <returns></returns>
        [DllImport("nt.dll", EntryPoint = "RtlCrc32", SetLastError = true, CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        internal static extern uint RtlCrc32(IntPtr Buffer, int Size, uint InitialCrc);

        /// <summary>
        /// CRC64
        /// </summary>
        /// <param name="Buffer"></param>
        /// <param name="Size"></param>
        /// <param name="InitialCrc"></param>
        /// <returns></returns>
        [DllImport("nt.dll", EntryPoint = "RtlCrc32", SetLastError = true, CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        internal static extern ulong RtlCrc64(IntPtr Buffer, int Size, ulong InitialCrc);
        
        */

        #endregion

        #region ### Shdocvw.dll ###

        /// <summary>
        /// Software Update MessageBox
        /// </summary>
        /// <!-- Author Tipplin -->
        /// 
        /// <!-- Author Tipplin-->
        /// <param name="WindowHandle">Set Handle: unbound IntPtr.Zero, bound to parent window: this.Handle</param>
        /// <param name="pszDistUnit"></param>
        /// <param name="dwFlags"></param>
        /// <param name="psdi"></param>
        /// <remarks>
        /// Visual C++ SDK Headerfile: shlobj.h
        /// The Windows Operation System Function SoftwareMessageBox 
        /// show you 'is there a newer Version for an Application on WebServer', 
        /// via Channels he looks on WebServer into Channel if there is newer Version,
        /// You can set on Webserver your Application once for multiple Download-Updates.
        /// Microsoft IIS is Webserver, he programmable.
        /// </remarks>
        /// <returns>
        /// 
        /// </returns>
        [DllImport("Shdocvw.dll", EntryPoint = "SoftwareUpdateMessageBox", SetLastError = true, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        internal static extern uint SoftwareUpdateMessageBox(IntPtr WindowHandle,
                                                            // The string value containing the identifier for the code distribution unit. 
                                                            // For ActiveX controls, pszDistUnit is typically a GUID.
                                                            [MarshalAs(UnmanagedType.LPWStr)]
                                                            string pszDistUnit,
                                                            // Reserved. Must be set to zero.
                                                            uint dwFlags,
                                                            // A pointer to a SOFTDISTINFO structure that, 
                                                            // when this method returns successfully, receives the update information. 
                                                            // The cbSize member must be initialized to the sizeof(SOFTDISTINFO).
                                                            ref SOFTDISTINFO psdi);




        #endregion

        // 
        // Microsoft make change the programming language by same functions from C++ to Rust,
        // in time many security problems wit C++ Functions in Memory.
        // Rust come with security functions.
        //
        // Use here Microsoft C Runtime Library - mscrt.dll - 64 Bit Version !.
        // !NOTE! If Operation System is Windows 10 Professional more than one C/C++ Runtimes !
        // at Time by Windows 10 October Update 2018.
        // 
        // Windows 10 System Compoment - ucrt.dll - universal c runtime library -
        // equa. is vcruntime140.dll in Visual Studio - Windows is written with Visual Studio.
        // 
        // ucrt.h as headerfiles in Windows 10 SDK in:
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17763.0\ucr
        // 
        // ucrt with sourcecodes:
        // C:\Program Files (x86)\Windows Kits\10\Source\10.0.17763.0\ucr
        // 
        // Windows Error Numbers with description
        // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17763.0\shared
        // INFO ! catch the Windows Operation System Error with:
        // Class Win32Exception
        // .NET Framework: try/catch/finally block and filtermethod 
        // catch(Win32Exception exe)if(ex.Number == -2100000) or when(ex.Number == 0x000000c5){...}
        // 
        // 
        // Give mixed Runtimes C and C++ by C++ Classes with mangled Names and pure C Functions,
        // see with Dependency Walker (32/64BIT) - Functions 64BIT at Name.
        // 
        // Attribute set for no Security Check and without Stackwalk,
        // Microsoft Statement: no dangerous and risk for User Call.
        // [SuppressUnmanagedCodeSecurityAttribute]
        // but ATTENTION, set not by all class or Method!
        // 

        #region ### amsi.dll - Anti Malware Scan Interface - Windows 10 May Update 2019 - SDK 18362 -

        /// <summary>
        /// Windows 10 Professional Defender Security Center
        /// AMSI - Anti Malware Scan Interface - amsi.h, amsi.dll -
        /// same Functions for use in our App's.
        /// Anti Virus - is Virus Scanner is better as before!
        /// Anti Trojan Scan:
        /// Tippo download an .zip from CodeProject, after Download the trojan scanner scan the .zip,
        /// Danger Trojan found !. Remove NOW directly or Quarantine.
        /// Ransomware - save your Data's on OneDrive -
        /// Kernel Isolation - Anti bad code smuggling -
        /// NOTE: Only Administrator Right can actived the this!
        /// Network and Firewall Security:
        /// Network: NOTE: Only Administrator Right can actived the this!
        /// Domain Network
        /// Private Network
        /// Public Network
        /// 
        /// Windows Defender Firewall avanted Extention, is better as before!.
        /// But NOTE, the Firewall off after install Windows 10 Professional.
        /// Please note!, set only at begin Standard Settings for Beginners,
        /// one error at setting, the Firewall can blocked the System, sample by Download.
        /// 
        /// </summary>
        /// <!-- Author Tippo 🧑 -->
        /// -----------------------------------------------------------------------
        /// NOTE: 
        /// New at Windows 10 May Update 2019 - 18362.116 - 21.05.2019 - Official -
        /// for use check your Operation System.
        /// -----------------------------------------------------------------------
        /// Enumerator for AMSI_RESULT
        /// AMSI = Anti Malware Scan Interface
        /// amsi.h - SDK 18362 - amsi on Website
        /// -----------------------------------------------------------------------
        /// <!-- Author Tippo 🧑 -->
        /// <remarks>
        /// he AMSI_RESULT enumeration specifies the types of results returned by scans.
        /// </remarks>
        internal enum AMSI_RESULT
        {
            /// <summary>
            /// Known good. No detection found, and the result is likely not going to change after a future definition update.
            /// </summary>
            AMSI_RESULT_CLEAN = 0,
            /// <summary>
            /// No detection found, but the result might change after a future definition update.
            /// </summary>
            AMSI_RESULT_NOT_DETECTED = 1,
            /// <summary>
            /// Administrator policy blocked this content on this machine (beginning of range).
            /// </summary>
            AMSI_RESULT_BLOCKED_BY_ADMIN_START = 0x4000,
            /// <summary>
            /// Administrator policy blocked this content on this machine (end of range).
            /// </summary>
            AMSI_RESULT_BLOCKED_BY_ADMIN_END = 0x4fff,
            /// <summary>
            /// Detection found. The content is considered malware and should be blocked.
            /// </summary>
            AMSI_RESULT_DETECTED = 32768
        };


        // AmsiResultIsMalware(r) ((r) >= AMSI_RESULT_DETECTED)



        /// <summary>
        /// - Amsi-Anti Malware Scan Interface - Result Is Malware
        /// </summary>
        /// <!-- Author Tippo 🧑 -->
        /// NOTE: only on Windows 10 May Update 2019 - OS-Build 18362.116 - Official Version -
        /// <!-- Author Tippo 🧑 -->
        /// <param name="Result"></param>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>
        /// 
        /// </returns>
        [DllImport("amsi.dll", EntryPoint = "AmsiResultIsMalware", SetLastError = true, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        internal static extern bool AmsiResultIsMalware(uint Result);

        /// <summary>
        /// Scans a string for malware.
        /// </summary>
        /// <!-- Author Tippo 🧑 -->
        /// 
        /// <!-- Author Tippo 🧑 -->
        /// <param name="amsiContext"></param>
        /// <param name="ScanString"></param>
        /// <param name="ContentName"></param>
        /// <param name="amsiSession"></param>
        /// <param name="result"></param>
        /// <remarks>
        /// Website AMSI with Functions for use.
        /// https://docs.microsoft.com/en-us/windows/desktop/api/amsi/nf-amsi-amsiopensession
        /// </remarks>
        /// <returns></returns>
        [DllImport("amsi.dll", EntryPoint = "AmsiScanString", SetLastError = true, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        internal static extern long AmsiScanString(/*HAMSICONTEXT*/ IntPtr amsiContext,
                                                    [MarshalAs(UnmanagedType.LPWStr)]
                                                    /*LPCWSTR*/ string ScanString,
                                                    [MarshalAs(UnmanagedType.LPWStr)]
                                                    /*LPCWSTR*/ string ContentName,
                                                    /*HAMSISESSION*/ IntPtr amsiSession,
                                                    AMSI_RESULT result);

        /// <summary>
        /// Initialize the AMSI API.
        /// </summary>
        /// <!-- Author Tippo 🧑 -->
        /// Anti Malware Scan Interface, Function for use it !
        /// <!-- Author Tippo 🧑 --> 
        /// <param name="AppName"></param>
        /// <param name="AmsiContext"></param>
        /// <remarks>
        /// 📌
        /// </remarks>
        /// <returns>
        /// 
        /// </returns>
        [DllImport("amsi.dll", EntryPoint = "AmsiInitialize", SetLastError = true, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        internal static extern long AmsiInitialize(
                                                    [MarshalAs(UnmanagedType.LPWStr)]
                                                    /*LPCWSTR*/
                                                    string AppName, 
                                                    /*HAMSICONTEXT* */ 
                                                    IntPtr AmsiContext);





        #endregion



        #region ### Visual Function Library.dll ###

        // Use native Visual Function Library.dll
        // </summary>
        // <!-- Author Tipplin -->
        // Visual C#:
        // [DllImport("VFL.dll", EntryPoint = "vgfVFLMsgBox", SetLastError = true, 
        // CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        // 
        // same in C++ by switch /clr - support common language runtime .NET
        // then without C++ Headerfiles.
        // 
        // Visual C++.NET:
        // [DllImport("VFL.dll", EntryPoint = "vgfVFLMsgBox", SetLastError::true, 
        // CharSet::CharSet.Unicode, CallingConvention::CallingConvention.StdCall)]
        // 
        // 
        // Set CharSet as Unicode everytime by Visual C#, 
        // Visual C# change .Auto to .Ansi everytime internal.
        // next Windows is only unicode ! International Signs
        // Germany, Autriche and Switzerland 
        // 
        // Special stupid "German Umlauts", can use UTF8/UTF16,
        // Tipplin have create comments in markdown file, 
        // paper from Dr. Knittel (CBM) for German Umlauts written in German and English.
        // NOTE: Common Language Runtime works IN/OUT with UTF16.
        /*-----------------------------------------------------------------------------
         * TIPPOTIP - want use internals from a Assembly lock / NOT visible! 
         * with keyword internal by class, method, 
         * ----------------------------------------------------------------------------
         * property set following Attribute in AssemblyInfo.cs file:
         * [assembly: InternalsVisibleTo("assemblyname without .dll")]
         * ----------------------------------------------------------------------------
         */






        /*
        UINT SCPSTDCALL  scpLicCountCalls();
        //-----------------------------------------------------------------------------
        VOID SCPSTDCALL  scpLicDLLCalls();
        //-----------------------------------------------------------------------------
        LPTSTR SCPSTDCALL  scpLicGetComputerName();
        //-----------------------------------------------------------------------------
        LPTSTR SCPSTDCALL  scpLicGetUserName();
        //-----------------------------------------------------------------------------
        LPTSTR SCPSTDCALL  scpLicGetFileInfoDrive(

                                                    const char* pszFileName);
        //-----------------------------------------------------------------------------
        LPTSTR SCPSTDCALL  scpLicGetFileInfoLastAccess(

                                                    const char* pszFileName);
        //-----------------------------------------------------------------------------
        LPTSTR SCPSTDCALL  scpLicGetFileInfoModified(

                                                    const char* pszFileName);
        //-----------------------------------------------------------------------------
        LPTSTR SCPSTDCALL  scpLicGetFileInfoSize(

                                                    const char* pszFileName);
        //-----------------------------------------------------------------------------
        LPTSTR SCPSTDCALL  scpLicGetCompanyName();
        //-----------------------------------------------------------------------------
        LPTSTR SCPSTDCALL  scpLicGetStringRes(UINT iResID);
        //-----------------------------------------------------------------------------
        LONG64 SCPSTDCALL  scpLicInitialize(LPINSTALLINFORM pII);
        //-----------------------------------------------------------------------------
        VOID SCPSTDCALL  scpLicLicenseMsgBox(
                                             LPTSTR pszAppName,
                                             INT iSCPYear,
                                             INT iLicInfoYear);
        //-----------------------------------------------------------------------------
        INT SCPSTDCALL  scpLicLicenseMsgBoxDLL(
                                                LPTSTR pszDLLName,
                                                INT iSCPYear,
                                                INT iLicInfoYear);
        //-----------------------------------------------------------------------------
        VOID SCPSTDCALL  scpLicLicenseMsgBoxE(
                                                 LPTSTR pszDLLName,
                                                 INT iMSYear1,
                                                 INT iMSYear2,
                                                 INT iSCPYear,
                                                 INT iLicInfoYear);
        //-----------------------------------------------------------------------------
        INT SCPSTDCALL  scpLicLicenseMsgBoxQ(
                                                LPTSTR pszAppName,
                                                INT iSCPYear,
                                                INT iLicInfoYear);
        //-----------------------------------------------------------------------------
        INT SCPSTDCALL  scpLicMsgBoxLicenseDLLE(
                                                LPTSTR pszDLLName,
                                                INT iSCPYear,
                                                INT iSCPLicDLLYear);
        //-----------------------------------------------------------------------------
        UINT SCPSTDCALL  scpLicNoLicenseBox(
                                             LPTSTR pszAppName,
                                             INT iSCPYear1,
                                             INT iSCPYear2);
        //-----------------------------------------------------------------------------
        CString SCPSTDCALL  scpLicRandomString(
                                                INT iLength,
                                                INT iType);
        //-----------------------------------------------------------------------------
        LPTSTR SCPSTDCALL  scpLicRegKeyFileGenerate(
                                               LPTSTR pszRegString,
                                               LPTSTR pszGenerationCode,
                                               ULONG64 ul64RandomSeed,
                                               LPTSTR pszFileName);
        //-----------------------------------------------------------------------------
        LPTSTR SCPSTDCALL  scpLicRegKeyFileValidate(
                           LPTSTR pszFileName,
                           LPTSTR pszValidationCode,
                           LPTSTR pszName,
                           ULONG64 ul64Key,
                           INT iMaxStringSize,
                           resl::REGISTRATION_KEY_VALIDATION_RESULTS rk);
        //-----------------------------------------------------------------------------
        LPTSTR SCPSTDCALL  scpLicRegKeyGenerate(
                                               LPTSTR pszRegString,
                                               LPTSTR pszGenerationCode,
                                               ULONG64 ul64RandomSeed);
        //-----------------------------------------------------------------------------
        LPTSTR SCPSTDCALL  scpLicRegKeyNewCodeSet(
                                               LPTSTR pszGenerationCode);
        //-----------------------------------------------------------------------------
        LPTSTR SCPSTDCALL  scpLicRenameFile(
                                               LPCTSTR szOldName,
                                               LPCTSTR szNewName);
        //-----------------------------------------------------------------------------
        LPTSTR SCPSTDCALL  scpLicRenameFileDir(
                                               LPCTSTR szOldName,
                                               LPCTSTR szNewName);
        //-----------------------------------------------------------------------------
        BOOL SCPSTDCALL  scpLicSetCompanyName(LPTSTR pszCompanyName);
        //-----------------------------------------------------------------------------
        BOOL SCPSTDCALL  scpLicVerifyLicFile(LPTSTR pszLicFileName);
        //-----------------------------------------------------------------------------
        BOOL SCPSTDCALL  scpLicVerifyLicNumber(
                                                 LPTSTR pszPassword,
                                                 LPTSTR pszUserName);
        //-----------------------------------------------------------------------------
        */
        //
        // Use native Visual Function Library.dll
        //
        // <!-- Author Tipplin -->
        // Visual C#:
        // [DllImport("VFL.dll", EntryPoint = "vgfVFLMsgBox", SetLastError = true, 
        // CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        // 
        // same in C++ by switch /clr - support common language runtime .NET
        // then without C++ Headerfiles.
        // 
        // Visual C++.NET:
        // [DllImport("VFL.dll", EntryPoint = "vgfVFLMsgBox", SetLastError::true, 
        // CharSet::CharSet.Unicode, CallingConvention::CallingConvention.StdCall)]
        // 
        // 
        // Set CharSet as Unicode everytime by Visual C#, 
        // Visual C# change .Auto to .Ansi everytime internal.
        // next Windows is only unicode ! International Signs
        // Germany, Autriche and Switzerland 
        // 
        // Special stupid "German Umlauts", can use UTF8/UTF16,
        // Tipplin have create comments in markdown file, 
        // paper from Dr. Knittel (CBM) for German Umlauts written in German and English.
        // NOTE: Common Language Runtime works IN/OUT with UTF16.
        // <!--Author Tipplin -->
        //-----------------------------------------------------------------------------
        // Visual.Function.Library.dll written C, for .NET and Visual C#
        //
        //-----------------------------------------------------------------------------
        // Use inside the CharSet = CharSet.Unicode, while Visual C# make by .Auto
        // convert to .Ansi, NOTE! at Windows Operation System Team in next Windows OS
        // use only unicode! - unicode with UTF8, UTF16, UTF32 (only algor.) -
        // Common Language Runtime IN/OUT works UTF16 and sign @ as UTF16
        // @ for formatting by urls: \\..\\..\\
        // @"\server\...\...\"
        //-----------------------------------------------------------------------------
        // \ backward slash - Windows System
        // / forward slash - HTML, Websites
        //
        //-----------------------------------------------------------------------------
        // Compiler make to reverse the DllImportAttribute
        // [DllImport("VFL.dll", EntryPoint = "vgfVOLMsgBox", SetLastError = true, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        // reverse:
        // [DllImport("VFL.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode, EntryPoint = "vgfVOLMsgBox", SetLastError = true)]
        // ! don't forget!, SetLastError only for C++, C# - not for Java and Visual Basic.NET.
        // Windows 10 with GetLastError -> GetWinLastError (.NET)
        // Windows 10 new with RestoreLastError.
        //
        // For Visual C++.NET Developer the same for DllImport without Headerfiles and switch  /clr for common language runtime 
        // [DllImport("mscrt.dll", EntryPoint = "printf", SetLastError::true, CharSet::CharSet.Unicode, CallingConvention::CallingConvention.StdCall)]
        // extern static int Printf(string ^ Format, ...) 
        // Note! Microsoft Name Convention! - The first Letter must be upper ! by Functionname.
        // For all manged names, C/C++ Runtimes Functions (printf, scan, _kbhit...)
        //
        // [DllImport("VFL.dll", EntryPoint = "vgfVOLMsgBox", SetLastError::true, CharSet::CharSet.Unicode, CallingConvention::CallingConvention.Cdecl)]
        //----------------------------------------------------------------------------------------------------------------------------------------------------

        // <summary>
        // MessageBox from our famous Visual.Function.Library.dll written in C.
        // </summary>
        // <!-- Author TIPPO -->
        // -------------------------------------------------------------------
        // At next in new Project an better MessageBox as this old Style,
        // Project "" - WPFMessageBox with many Features:
        // -------------------------------------------------------------------
        // WPFMessageBox: 3D Icons, Hyperlink, Clipboard, Copy, Scrollbar, 
        // Expand WPFMessageBox to Full Window at Left Corner 
        // Black Field click and make it greather,
        // Timeout, set value and the WPFMessageBox 
        // close automatic by no User Action!.
        // -------------------------------------------------------------------
        // (NOTE: same was in Windows Operation System 
        // as MessageBoxTimeout Function)
        // -------------------------------------------------------------------
        // (NOTE: STOPPED a Thread with Thread.Sleep or 
        // Sleep Function can write this:
        // 
        // Thread.Sleep(5000 * MessageBox("After OK Click, Thread continue!", 
        // "Thread", OK, Icon...) );
        // 
        // * asteric as operator, so sleep the Thread 
        // 5 seconds and than the MessageBox shows the Message.
        // 
        // Thread.Sleep(5000 * MethodName(parameters) );
        // -------------------------------------------------------------------
        // * asteric as operator, so sleep the Thread 5 seconds and 
        // than execute the Call/Method.
        // -------------------------------------------------------------------
        // Many Timers in .NET Framework without any Control!
        // 
        // Timers Timer;
        // Timer(interval, parameter, Call, x);
        // The Timer execute after TimeInterval any time this Call, 
        // don't forget the Timer.Stop!,
        // Forget the Timer runs continue.
        // -------------------------------------------------------------------
        // Same in Mobile Class Vibrator as Timer, 
        // forget Timer.Stop - Phone any time vibrate.
        // -------------------------------------------------------------------






        /// <summary>
        /// Show Windows MessageBox 
        /// </summary>
        /// <param name="lpszText">set MessageBox Text</param>
        /// <param name="lpszTitel">set MessageBox Title</param>
        /// <param name="styles">set miscellous Flags</param>
        /// <!-- Author Tipplin 🧑 -->
        /// miscellous Flags from me, written as Enumerator:
        /// Button, Icon, ForegroundWindow, Window Lock: ApplicationModal, SystemModal or TaskModal
        /// <!-- Author Tipplin 🧑 -->
        /// <returns>
        /// 
        /// </returns>
        [DllImport("VFL.dll", EntryPoint = "vgfVFLMsgBox", SetLastError = true, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        internal static extern uint VFLMsgBox(
                                               // LPWSTR (wchar_t) must be marshalling, by LPSTR can set string directly.
                                               [MarshalAs(UnmanagedType.LPWStr)]
                                               string lpszText,
                                               // LPWSTR (wchar_t) must be marshalling, by LPSTR can set string directly.
                                               [MarshalAs(UnmanagedType.LPWStr)]
                                               string lpszTitel,
                                               // Enumerator like VB for C#, show in Method as Parameter at .point, than a intellisense Window.
                                               STYLES styles);



        /// <summary>
        /// Show MessageBox with predefined Messagetext.
        /// </summary>
        /// <param name="TextID">Set integer value 1 to 25</param>
        /// <!-- Author TIPPO -->
        /// Tippo idea set predefined Messagetext in char array, written in a C Library.
        /// <!-- Author TIPPO -->
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>
        /// 
        /// </returns>
        [DllImport("VFL.dll", EntryPoint = "vgfVFLMessageBox", SetLastError = true, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        internal static extern int VFLMessageBox(int TextID);


        /// <summary>
        /// Set Privilege for User
        /// </summary>
        /// <!-- Author TIPPO -->
        /// NOTE! you must have Administrators Rights !
        /// for set Privileges.
        /// <!-- Author TIPPO -->
        /// <param name="lpszPrivilegeName">Set Privilege Name</param>
        /// <param name="bEnablePrivilege">Set Enable Privileges with true/false</param>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>
        /// returned successfully true/0, failure false/1
        /// </returns>
        [DllImport("VFL.dll", EntryPoint = "vgfVFLSetUserPrivilege", SetLastError = true, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        internal static extern bool VFLSetUserPrivilege(
                                                            [MarshalAs(UnmanagedType.LPTStr)]
                                                            string lpszPrivilegeName,
                                                            bool bEnablePrivilege);

        /// <summary>
        /// Start directly an executable File .exe
        /// </summary>
        /// <param name="AppName">Set Applicationname</param>
        /// <!-- Author TIPPO -->
        /// 
        /// <!-- Author TIPPO -->
        /// <remarks>
        /// Use CreateProcess for executable the app
        /// </remarks>
        /// <returns>
        /// 
        /// </returns>
        [DllImport("VFL.dll", EntryPoint = "vgfVFLStartDirectEXE", SetLastError = true, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        internal static extern bool VFLStartDirectEXE(
                                                        [MarshalAs(UnmanagedType.LPTStr)]
                                                        string AppName);


        #endregion

        #region ### Visual License Library.dll ###

        /// <summary>
        /// Verify the License File
        /// </summary>
        /// <!-- Author Tipplin -->
        /// Set constant License Text Entry
        /// Copyright © 2019 by VGF-KernelTeam and Christian 'TIPPO' Kurs.
        /// if NOT in our License File, terminate!
        /// <!-- Author Tipplin -->
        /// <param name="LicFile">Set License File Name</param>
        /// <remarks>
        /// make great License System for optimal save!
        /// </remarks>
        /// <returns>
        /// 
        /// </returns>
        [DllImport("VLL.dll", EntryPoint = "VLLLicVerifyLicFile", SetLastError = true, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        internal static extern bool VLLLicVerifyLicFile(
                                                         [MarshalAs(UnmanagedType.LPWStr)]
                                                         string LicFile
                                                         );
        #endregion


    } // END::OF::CLASS::UnsafeNativeMethods


    

    internal static class NativeRuntimeMethods
    {
        /*-----------------------------------------------------------------------------------
         * Use here only the Microsoft C/C++ Runtime Library 64 BIT ! mscrt.dll - unicode ---
         * TIPPOCHECK:
         * Microsoft Runtime Libraries more than one written, at Build 17763
         *-----------------------------------------------------------------------------------
         * C++ Reference Website
         * http://www.cplusplus.com/reference/cstring/strlen/
         *---------------------------------------------------------------------------------*/
        #region ### Microsoft C/C++ Runtime Library Functions - ! NOTE ! are ONLY 64BIT - ###


        /// <summary>
        /// Use here Microsoft C Runtime Library - mscrt.dll - 64 Bit Version !.
        /// exit, terminate process complete, call and caller.
        /// exit(errorcode); 
        /// All in Windows SDK: All with begin ERROR_
        /// </summary>
        [DllImport("mscrt.dll", EntryPoint = "exit", SetLastError = true, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void NRMExit();

        /// <summary>
        /// Use here Microsoft C Runtime Library - mscrt.dll - 64 Bit Version !.
        /// mscrt.dll
        /// _cexit, Performs cleanup operations and returns without terminating the process.
        /// </summary>
        [DllImport("mscrt.dll", EntryPoint = "_cexit", SetLastError = true, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void NRMCExit();

        /// <summary>
        /// Use here Microsoft C Runtime Library - mscrt.dll - 64 Bit Version !.
        /// exit, terminate process complete, call and caller.
        /// exit(errorcode); All in Windows SDK: All with begin ERROR_ 
        /// 1150 is The specifies program requires a newer Version of Windows Operation System.
        /// ERROR_OLD_WIN_VERSION = 1150L
        /// </summary>
        /// <!-- Author Tipplin -->
        /// Enumerator EXIT_CODES by cancel or error in Method, in App...
        /// <!-- Author Tipplin -->
        /// <param name="exitcode">Set EXIT_CODE for exitcode</param>
        /// <remarks>
        /// sample:
        /// NRMExit(EXIT_CODES.ERROR_FUNCTION_NOT_CALLED);
        /// All at Time in Enumerator from SDK 18309.
        /// </remarks>
        [DllImport("mscrt.dll", EntryPoint = "_Exit", SetLastError = true, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int NRMExit(EXIT_CODES exitcode);

        /// <summary>
        /// Use here Microsoft C Runtime Library - mscrt.dll - 64 Bit Version !.
        /// mscrt.dll
        /// kbhit, keyboard hit, hit any taste
        /// </summary>
        [DllImport("mscrt.dll", EntryPoint = "kbhit", SetLastError = true, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool NRMKeyboardHit();

        //----------------------------------------------------------------------------
        // Random Number Generator functions from Visual C++ Runtime Library ! 64BIT !
        // Intel Processor Skylake with internal Random Number Generator,
        // 16BIT, 32BIT and 64BIT Random Numbers returned, everytime new!
        // Intel give C++ Headerfiles for use them !
        // Encryption Functions
        // TIPPOTIP: German National IT Centre in Germany by Bonn
        // give The State of IT Security in Germany 2018
        // German Federal Office for Security in Information Technology
        // Very Good for Development in Security Functions, Crypto, Web,
        //
        // same samples on GitHub. Free Downlaod all BSI Documents, BSI Checklists,
        //
        // Best at Last: Newsletter, Warnings to all Programs with Problems,
        // Warnings for malware, phising and more.... every day new!
        //----------------------------------------------------------------------------

        /// <summary>
        /// Random Number Generator switch on
        /// </summary>
        /// <!-- Author Tipplin -->
        /// NOTE: Microsoft Name Rule:
        /// at Method-Declaration the first letter must be lower !
        /// <!-- Author Tipplin -->
        /// <returns></returns>
        [DllImport("mscrt.dll", EntryPoint = "rand_s", SetLastError = true, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int NRMRand();

        /// <summary>
        /// Random Number Generator create it!
        /// </summary>
        /// <returns></returns>
        [DllImport("mscrt.dll", EntryPoint = "srand", SetLastError = true, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int NRMSrand(int r);

        /// <summary>
        /// Runtime Function getchar
        /// </summary>
        /// <returns></returns>
        [DllImport("mscrt.dll", EntryPoint = "getchar", SetLastError = true, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int NRMGetChar();

        /// <summary>
        /// Runtime Function strlen
        /// </summary>
        /// <param name="str"></param>
        /// <returns>
        /// Returns the length of the C string str.
        /// </returns>
        [DllImport("mscrt.dll", EntryPoint = "strlen", SetLastError = true, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int NRMStrlen(string str);




        #endregion

    } // end of class:.NativeRuntimeMethods


    /// <summary>
    /// Apple mac OSX
    /// </summary>
    /// <!-- Author Tipplin 🧑 -->
    /// MAC native Methods from System Lib dynamic library
    /// Miguel de Icazar Mr. MONO - XAMARIN - Apple iOS SDK -
    /// (before was by Novell - Microsoft Xamarin)
    /// MONO Framework crossover Framework to Apple Systems, Google Android
    /// NEW MONO Game Framework - create your Games - in Channel Video New PACMAN GAME.
    /// <!-- Author Tipplin 🧑 -->
    /// <remarks>
    /// Apple MAC both Systems - macOS and Windows 10 Partition
    /// but have problems new Apple ADFS.
    /// 'The War is over'
    /// Apple supports iTunes and iCloud on Windows 10,
    /// download at Apple Software Center.
    /// </remarks>
    internal static class MacNativeMethods
    {
        /*
         * Apple macOS X Functions for use
         * source: Miguel de Icaza Chief Technical Fellow of XAMARIN
         * 
         */

        /// <summary>
        /// System Control by Name
        /// </summary>
        /// <!-- Author Tipplin -->
        /// System DLL Apple MAC 
        /// - .dylib = dynamic library
        /// - .syslib = system library
        /// - .so = shared objects
        /// 
        /// NOTE: The MAC Computer have two partions, macOS and Windows 10,
        /// Windows 10 in special folder, you can use both Operation System.
        /// Tim Cook and Sayta Nadella Meeting "The War is over", make Partnership.
        /// Apple Software Center - Download Center for Windows 10 -
        /// Apple iTunes for Windows 10 and Apple iCloud for Windows 10
        /// <!-- Author Tipplin -->
        /// <param name="property"></param>
        /// <param name="output"></param>
        /// <param name="oldLen"></param>
        /// <param name="newp"></param>
        /// <param name="newlen"></param>
        /// <returns></returns>
        [DllImport("/usr/lib/libSystem.dylib", EntryPoint = "sysctlbyname")]
        internal static extern int Sysctlbyname(
                                                  [MarshalAs(UnmanagedType.LPStr)]
                                                  string property, 
                                                  IntPtr output, 
                                                  IntPtr oldLen, 
                                                  IntPtr newp, 
                                                  uint newlen);

        /// <summary>
        /// MAC Method Uname
        /// </summary>
        /// <!-- Author TIPPLIN -->
        /// Source by Miguel de Icaza: Use Mac functions on Windows / Visual Studio Solution
        /// Apple libc dynamic link Library
        /// Google libc as 32 BIT Library and libc64 
        /// as 64 Library both as Runtimes on Smartphones.
        /// Google Document Guideline: both on Phone as official Google Android Device !.
        /// Failed one no Google Android Device ! Like China! runs only Kernelmode!
        /// 
        /// <!-- Author TIPPLIN -->
        /// <param name="buf"></param>
        /// <returns>
        /// 
        /// </returns>
        [DllImport("libc", EntryPoint = "uname")]
        internal static extern int Uname(IntPtr buf);

        /// <summary>
        /// Is Running on a MAC
        /// </summary>
        /// <!-- Author TIPPLIN -->
        /// MAC have an Partition Windows 10, so you can use both systems.
        /// <!-- Author TIPPLIN -->
        /// <returns></returns>
        internal static bool IsRunningOnMac()
        {
            IntPtr intPtr = IntPtr.Zero;
            try
            {
                intPtr = Marshal.AllocHGlobal(8192);
                if (Uname(intPtr) == 0 && Marshal.PtrToStringAnsi(intPtr) == "Darwin")
                {
                    return true;
                }
            }
            catch
            {
            }
            finally
            {
                if (intPtr != IntPtr.Zero)
                {
                    Marshal.FreeHGlobal(intPtr);
                }
            }
            return false;

        } // END::OF::METHOD::IsRunningOnMac



    } // END::OF:CLASS::MacNativeMethods






        #endregion

    } // END::OF::NAMESPACE::Visual.Operation.System.Native
      //*****************************************************************************
      //***************** END OF FILE WindowsOperationSystem.cs *********************
      //*****************************************************************************
