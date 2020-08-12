/*********************************************************************************
*	Copyright © 2019 by VGF-KernelTeam and Christian 'TIPPO' Kurs.
*			All Rights Reserved.
*
*   Parts of Copyright by Microsoft Corporation with Permission.
*   Many Thanks for this Help !
* 
*--------------------------------------------------------------------------------
* 2019 good year for Tipplin:
* -------------------------------------------------------------------------------
* Senior Member of Windows Kernel Team Blog
* directly contact with Windows Kernel Developers.
* New in Kernel, little parts of code of lines, Memory Manager...
* 
* 2019 - Nomination Windows Insider 2019 in July - are in MVP !
* 
* Windows 10 goes AI / KI, and more and more Networking.
* 
*********************************************************************************/
/*
    This software is the confidential and proprietary information of
    VGF-KernelTeam - ("Confidential Information").  You shall not
    disclose such Confidential Information and shall use it only in
    accordance with the terms of the License Agreement you entered into
    with VGF-KernelTeam.

    VGF-KERNELTEAM MAKES NO REPRESENTATIONS OR WARRANTIES ABOUT THE SUITABILITY OF
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

/**************************************************************************************************
    MAC, macOS, watchOS, tvOS is a registered trademark of Apple Computer, Inc. 
    ! NOTE ! iOS is a registered trademark of Cisco Corporation.
    Intel is a registered trademark of Intel Corporation. 

    Active Desktop, ActiveX, Authenticode, BackOffice, FoxPro, FrontPage, 
    Visual Studio, Jscript, Microsoft, Microsoft Press, MSDN, MS-DOS, MSN, 
    Outlook, PivotTable, PowerPoint, Visual Basic, Visual C++, Visual FoxPro, 
    Visual InterDev, Visual J++, J#, Visual Studio, Win32, Windows, 
    and Windows NT are either registered trademarks or 
    trademarks of Microsoft Corporation in the United States and/or other countries.
    -----------------------------------------------------------------------------------------------
    ! ATTENTION ! write for Export ! 
    This software is subject to the U.S. Export Administration Regulations and 
    other U.S. law, and may not be exported or re-exported to certain countries 
    ( Cuba, Iran, North Korea, Sudan, Syria, and the Crimea region of Ukraine) or 
    to persons or entities prohibited from receiving U.S. exports 
    (including Denied Parties, Specially Designated Nationals, 
    and entities on the Bureau of Export Administration Entity List or 
    involved with missile technology or nuclear, chemical or biological weapons).

    © 1982 - 2019 Microsoft Corporation. All rights reserved.

****************************************************************************************************/

/*-----------------------------------------------------------------------------
 * All Directives of .NET Framework - All Begins with System.
 *
 *---------------------------------------------------------------------------*/ 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security;
using System.Runtime.InteropServices;

/*-----------------------------------------------------------------------------
 * All Directives of .Net Framework for Windows Operation System:
 * Windows Directives, begins with Windows.
 * Special Windows Metadatas - .winmd, same as an Directive/Assembly.
 * Windows Operation System, .winmd in directory: \windows\system32\WinMetadata
 * Windows.AI.winmd - for Arti Inte / KI
 * Windows.Storage.winmd
 * ...
 * 
 *-----------------------------------------------------------------------------
 * Winodows Operation System - Windows Research Kernel - Info:
 * ----------------------------------------------------------------------------
 * Copyright (c) Microsoft Corporation. All rights reserved. 
 * You may only use this code if you agree to the terms of 
 * the Windows Research Kernel Source Code License agreement (see License.txt).
 * If you do not agree to the terms, do not use the code.
 * ----------------------------------------------------------------------------
 * Luid.c
 * This module implements the NT locally unique identifier services.
 * 
 *     ReturnStatus = ZwOpenKey( &LangGroupKey,

                              GENERIC_READ,

                              &NlsLangGroupObjA

                            );

    if (!NT_SUCCESS(ReturnStatus))

         goto Failed3;
...
    Failed3:

    ZwClose( SortKey );
----------------------------------------------------------------------------------------------------------
    // Establish the OBJECT_ATTRIBUTES for the guid object
    StringCchCopyW(ObjectName, WmiGuidObjectNameLength+1, WmiGuidObjectDirectory);

    StringCchPrintfW(&ObjectName[WmiGuidObjectDirectoryLength-1],

                         WmiGuidObjectNameLength-8,

                         L"%08x-%04x-%04x-%02x%02x-%02x%02x%02x%02x%02x%02x",

                         Guid->Data1, Guid->Data2, 

                         Guid->Data3,

                         Guid->Data4[0], Guid->Data4[1],

                         Guid->Data4[2], Guid->Data4[3],

                         Guid->Data4[4], Guid->Data4[5],

                         Guid->Data4[6], Guid->Data4[7]);

    if (IsEqualGUID(Guid, &InstId->Guid))

            {

                //

                // We found an entry for our guid so use its information

                *FirstInstanceId = InstId->BaseId;

                InstId->BaseId += InstanceCount;

                WmipLeaveSMCritSection();

                return(STATUS_SUCCESS);

            }

    VOID

__cdecl

_purecall()

{

    ASSERTMSG("_purecall() was called", FALSE);

    ExRaiseStatus(STATUS_NOT_IMPLEMENTED);

}

----------------------------------------------------------------------------------------------------------------
#define STARTING 0

#define STARTED 1

#define SHUTDOWN 2

----------------------------------------------------------------------------------------------------------------
    if (fileName.Length > MAXIMUM_FILENAME_LENGTH<<1) {

                        ExRaiseStatus( STATUS_INVALID_PARAMETER );

                    }

        // Check to ensure that the caller has either READ or WRITE access to
        // the file.  If not, cleanup and return an error.
        if (!SeComputeGrantedAccesses( grantedAccess, FILE_READ_DATA | FILE_WRITE_DATA )) {

            ObDereferenceObject( fileObject );

            return STATUS_ACCESS_DENIED;

        }
----------------------------------------------------------------------------------------------------------------
            // Carefully return the I/O status.
            try {

 #if defined(_WIN64)

                // If this is a32-bit thread, and the IO request is 
                // asynchronous, then the IOSB is 32-bit. Wow64 always sends
                // the 32-bit IOSB when the I/O is asynchronous.
                if (IopIsIosb32(ApcRoutine)) {

                    PIO_STATUS_BLOCK32 UserIosb32 = (PIO_STATUS_BLOCK32)IoStatusBlock;

                    

                    UserIosb32->Information = (ULONG)localIoStatus.Information;

                    UserIosb32->Status = (NTSTATUS)localIoStatus.Status;

                } else {

                    *IoStatusBlock = localIoStatus;

                }

#else

                *IoStatusBlock = localIoStatus;

#endif

            } except( EXCEPTION_EXECUTE_HANDLER ) {

                localIoStatus.Status = GetExceptionCode();

                localIoStatus.Infor



-----------------------------------------------------------------------------------------
NT Kernel source:

try...

Ist man sich ganz sicher, das codeparts zu keinem Fehler führen, 
muss man nicht einen Exceptionhandler schreiben.

Exceptionhandler:
Angebracht bei Buffers,

oder so:

if abfrage ! verneinung NT_SUCCESS ob gleich 0,
nicht, zu Label Mark gehen und cleanup machen.
 
if (!NT_SUCCESS(ReturnStatus))

         goto Failed3;
...
    Failed3:
    cleanup:
    - return <value>;
    - statement
    - Exceptionhandler call
    - return <message>;

-----------------------------------------------------------------------------------------
Windows 10 Kernel Source - 2016 - Windows Research Kernel Source Code written in C -
-----------------------------------------------------------------------------------------
internal 64 BIT always:
// Only 64 BIT System
#if defined(_WIN64)

        SharedUserData->TickCountQuad = NewTickCount.QuadPart;

// 32BIT System
#else
        SharedUserData->TickCount.LowPart   = NewTickCount.LowPart;
        SharedUserData->TickCount.High1Time = NewTickCount.HighPart;
#endif

// N.B. There is no global tick count variable on AMD64.
#if defined(_X86_)

        KeTickCount.High2Time = NewTickCount.HighPart;
        KeTickCount.LowPart   = NewTickCount.LowPart;
        KeTickCount.High1Time = NewTickCount.HighPart;
#endif

#if defined(_AMD64_)
        SharedUserData->InterruptTime.High2Time = InterruptTime.HighPart;
        *((volatile ULONG64 *)&SharedUserData->InterruptTime) = InterruptTime.QuadPart;
#else
        SharedUserData->InterruptTime.High2Time = InterruptTime.HighPart;
        SharedUserData->InterruptTime.LowPart   = InterruptTime.LowPart;
        SharedUserData->InterruptTime.High1Time = InterruptTime.HighPart;
#endif

---------------------------------------------------------------------------------------
Count ! verneinung bei increment/decrement +-
ULONG Count = 30000;

if (!Count--) 
{
  Count = 30000;

  if (KeTryToAcquireSpinLockAtDpcLevel(&KiFreezeLockBackup) == TRUE) 
  {
                KiFreezeFlag |= FREEZE_BACKUP;
                break;
  }

}
----------------------------------------------------------------------------------------
The primary NTOS source components included in the WRK are organized as follows:
(Windows 10 - 2016 - Operation System - Kernel Source Code)
    cache\  - cache manager
    config\ - registry implementation
    dbgk\   - user-mode debugger support
    ex\     - executive functions (kernel heap, synchronization, time)
    fsrtl\  - file system run-time support
    io\     - I/O manager
    ke\     - scheduler, CPU management, low-level synchronization
    lpc\    - local procedure call implementation
    mm\     - virtual memory manager
    ob\     - kernel object manager
    ps\     - process/thread support
    se\     - security functions
    accessck.c
    This Module implements the access check procedures.  Both NtAccessCheck
    and SeAccessCheck check to is if a user (denoted by an input token) can
    be granted the desired access rights to object protected by a security
    descriptor and an optional object owner.  Both procedures use a common
    local procedure to do the test.
    SepAccessCheck 

    wmi\    - Windows Management Instrumentation

    inc\    - NTOS-only include files
    rtl\    - kernel run-time support
    init\   - kernel startup

The NTOS kernel implements the basic OS functions
for processes, threads, virtual memory and cache managers, I/O management,
the registry, executive functions such as the kernel heap and synchronization,
the object manager, the local procedure call mechanism, the security reference
monitor, low-level CPU management (thread scheduling, Asynchronous and Deferred
Procedure calls, interrupt/trap handling, exceptions), etc.

The NT Hardware Abstraction Layer, file systems, network stacks, and device
drivers are implemented separately from NTOS and loaded into kernel mode
as dynamic libraries.  Sources for these dynamic components are not included
in the WRK, but some are available in various development kits published
by Microsoft, such as the Installable File System (IFS) Kit and the
Windows Driver Development Kit (DDK).





------------------------------------------------------------------------------------------





 *
 *
 * 
 * 
 * 
 */






// Set here other Directives/namespaces or namespaces with static class
// from other Csharp Files .cs in Project-Solution.
using static Visual.Operation.System.Internal.InternalUtilities.VOSInternalUtilities;

/*-----------------------------------------------------------------------------
 * TIPPOTIP - want use internals from a Assembly lock / NOT visible! 
 * with keyword internal by class, method, 
 * ----------------------------------------------------------------------------
 * property set following Attribute in AssemblyInfo.cs file:
 * [assembly: InternalsVisibleTo("assemblyname without .dll")]
 * ----------------------------------------------------------------------------
 */





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
namespace Visual.Function.Library
{

    /// <summary>
    /// Use native Visual Function Library.dll
    /// </summary>
    /// <!-- Author Tipplin -->
    /// Visual C#:
    /// [DllImport("VFL.dll", EntryPoint = "vgfVFLMsgBox", SetLastError = true, 
    /// CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
    /// 
    /// same in C++ by switch /clr - support common language runtime .NET
    /// then without C++ Headerfiles.
    /// 
    /// Visual C++.NET:
    /// [DllImport("VFL.dll", EntryPoint = "vgfVFLMsgBox", SetLastError::true, 
    /// CharSet::CharSet.Unicode, CallingConvention::CallingConvention.StdCall)]
    /// 
    /// 
    /// Set CharSet as Unicode everytime by Visual C#, 
    /// Visual C# change .Auto to .Ansi everytime internal.
    /// next Windows is only unicode ! International Signs
    /// Germany, Autriche and Switzerland 
    /// 
    /// Special stupid "German Umlauts", can use UTF8/UTF16,
    /// Tipplin have create comments in markdown file, 
    /// paper from Dr. Knittel (CBM) for German Umlauts written in German and English.
    /// NOTE: Common Language Runtime works IN/OUT with UTF16.
    /// <!--Author Tipplin -->
    public static class NativeVisualFunctionLibrary
    {

        #region ### Visual.Function.Library Dll - our famous C Functions Library ###

        /*
        
            //-----------------------------------------------------------------------------
            //	return value	for .NET	Functionname					parameter
            //-----------------------------------------------------------------------------
            // SCPSTDCALL is an define __stdcall
            //
            //-----------------------------------------------------------------------------
            //-------------------EXPORTED FUNCTION ----------------------------------------
            //-----------------------------------------------------------------------------
	            VOID			SCPSTDCALL	vgfVFLDLLCalls(UINT FreeCalls);
            //-----------------------------------------------------------------------------
	            VOID			SCPSTDCALL	vgfVFLDLLCalls2(INT iCalls);
            //-----------------------------------------------------------------------------
	            LPTSTR			SCPSTDCALL	vgfVFLGetStringRes(UINT uiResID);
            //-----------------------------------------------------------------------------
	            BOOL			SCPSTDCALL	vgfVFLIsDefaultPrinter(LPTSTR pszPrinterName);
            //-----------------------------------------------------------------------------
	            BOOL			SCPSTDCALL	vgfVFLIsProtectedFile(LPCWSTR pszProtFileName);
            //-----------------------------------------------------------------------------
	            BOOL			SCPSTDCALL	vgfVFLLicApiDelEmptyKey(
														            LPCTSTR szKey,
														            LPCTSTR szSubKey);
            //-----------------------------------------------------------------------------
	            BOOL			SCPSTDCALL	vgfVFLLicApiDeleteKey(
														            LPCTSTR szKey,
														            LPCTSTR szSubKey);
            //-----------------------------------------------------------------------------
	            BOOL			SCPSTDCALL	vgfVFLLicApiRegisterCount(
														            LPSTR pszKey,
														            LPSTR pszValue,
														            LPSTR pszData);
            //-----------------------------------------------------------------------------
	            BOOL			SCPSTDCALL	vgfVFLLicApiRegisterDT(
													            LPSTR pszKey,
													            LPSTR pszValue,
													            LPSTR pszData);
            //-----------------------------------------------------------------------------
	            BOOL			SCPSTDCALL	vgfVFLLicApiRegisterUser(
														            LPSTR pszKey,
														            LPSTR pszValue,
														            LPSTR pszData);
            //-----------------------------------------------------------------------------
	            BOOL			SCPSTDCALL	vgfVFLLicApiRegisterVerifyEntry(
																            LPSTR pszKey,
																            LPSTR pszValue,
																            LPSTR pszData);
            //-----------------------------------------------------------------------------
	            BOOL			SCPSTDCALL	vgfVFLRegisterString(
													            LPSTR pszKey,
													            LPSTR pszValue,
													            LPSTR pszData);
            //-----------------------------------------------------------------------------
            //-----------------------------------------------------------------------------
            //-----------------------------------------------------------------------------
	            VOID			SCPSTDCALL	vgfVFLTerminateProcess(LPTSTR pszAppName);
            //-----------------------------------------------------------------------------	
	            HRESULT			SCPSTDCALL	vgfVFLRegisterApplication(LPSTR pszAppName);
            //-----------------------------------------------------------------------------
	            HRESULT			SCPSTDCALL	vgfVFLUnregisterApplication(LPCTSTR pszAppName);
            //-----------------------------------------------------------------------------
	            VOID			SCPSTDCALL	vgfVFLWindows7Required();
            //-----------------------------------------------------------------------------
	            VOID			SCPSTDCALL	vgfVFLWindowsFeatureNotAvailable();
            //-----------------------------------------------------------------------------
	            LPTSTR			SCPSTDCALL	vgfVFLDisplaySystemVersion();
            //-----------------------------------------------------------------------------
	            USHORT			SCPSTDCALL	vgfVFLGetStringLength(LPSTR lpString);
            //-----------------------------------------------------------------------------
	            LPTSTR			SCPSTDCALL	vgfVFLGetComputerName();
            //-----------------------------------------------------------------------------
	            LPTSTR			SCPSTDCALL	vgfVFLGetUserName();
            //-----------------------------------------------------------------------------
	            LPTSTR			SCPSTDCALL	vgfVFLGetWindowsDirectory();
            //-----------------------------------------------------------------------------
	            BOOL			SCPSTDCALL	vgfVFLIsWindowMaximized(HWND hWndWindowHandle);
            //-----------------------------------------------------------------------------
	            BOOL			SCPSTDCALL	vgfVFLIsWindowMinimized(HWND hWndWindowHandle);
            //-----------------------------------------------------------------------------
	            VOID			SCPSTDCALL	vgfVFLIsUnicodeSupported();
            //-----------------------------------------------------------------------------
	            LPTSTR			SCPSTDCALL	vgfVFLSysMemoryPercentInUse();
            //-----------------------------------------------------------------------------
	            LPTSTR			SCPSTDCALL	vgfVFLSysAvailExtendedVirtualMemory();
            //-----------------------------------------------------------------------------
	            LPTSTR			SCPSTDCALL	vgfVFLSysTotalPhysMemory();
            //-----------------------------------------------------------------------------
	            LPTSTR			SCPSTDCALL	vgfVFLSysTotalVirtualMemory();
            //-----------------------------------------------------------------------------
	            LPTSTR			SCPSTDCALL	vgfVFLSysAvailVirtualMemory();
            //-----------------------------------------------------------------------------
	            LPTSTR			SCPSTDCALL	vgfVFLSysAvailPhysicalVirtualMemory();
            //-----------------------------------------------------------------------------
	            LPTSTR			SCPSTDCALL	vgfVFLSysAvailExtendedVirtualMemory();
            //-----------------------------------------------------------------------------
	            UINT			SCPSTDCALL	vgfVFLMsgBox(LPCWSTR lpszText,
											            LPCWSTR lpszTitle,
											            UINT Style);
            //-----------------------------------------------------------------------------
	            UINT			SCPSTDCALL	vgfVFLMessageBoxChoice(HWND WindowHandle,
													               LPCWSTR lpszText,
													               LPCWSTR lpszTitle,
													               UINT Style);
            //-----------------------------------------------------------------------------
	            UINT			SCPSTDCALL	vgfVFLMsgBoxSetup(	LPCWSTR lpszObject,
												            LPCWSTR lpszComponent,
												            LPCWSTR lpszBetaComponent);
            //-----------------------------------------------------------------------------
	            INT				SCPSTDCALL	vgfVFLMessageBox(INT TextID);
            //-----------------------------------------------------------------------------
	            BOOL			SCPSTDCALL	vgfVFLWindowAnimate(HWND WindowHandle, 
													            DWORD SlideTime);
            //-----------------------------------------------------------------------------
	            BOOL			SCPSTDCALL	vgfVFLWindowAnimateAction(HWND WindowHandle,
														            DWORD SlideTime,
														            INT AnimateAction);
            //-----------------------------------------------------------------------------
	            BOOL			SCPSTDCALL	vgfVFLLockWorkstation();
            //-----------------------------------------------------------------------------
	            BOOL			SCPSTDCALL	vgfVFLIsUserAdministrator();
            //-----------------------------------------------------------------------------
	            BOOL			SCPSTDCALL	vgfVFLCheckForSecretKeyStroke();
            //-----------------------------------------------------------------------------
	            BOOL			SCPSTDCALL	vgfVFLMultiBeep(DWORD Frequency, 
												            DWORD Duration);
            //-----------------------------------------------------------------------------
	            BOOL			SCPSTDCALL	vgfVFLStartDirectEXE(LPCTSTR AppName);
            //-----------------------------------------------------------------------------
	            INT				SCPSTDCALL	vgfVFLMessageBoxTimeout(LPCWSTR Text, 
									            LPCWSTR Title, UINT Icon, DWORD TimeOut);
            //-----------------------------------------------------------------------------
	            BOOL			SCPSTDCALL	vgfVFLIsWindows10ProfessionalInstalled();
            //-----------------------------------------------------------------------------
	            DWORD			SCPSTDCALL	vgfVFLThreadSleep(INT SleepTime);
            //-----------------------------------------------------------------------------
	            VOID			SCPSTDCALL	vgfVFLTippoInfo1();
            //-----------------------------------------------------------------------------
	            LPSTR			SCPSTDCALL	vgfVFLOSGetVersionInfo();
            //-----------------------------------------------------------------------------
	            BOOL			SCPSTDCALL	vgfVFLIsWindows10OnComputer();
            //-----------------------------------------------------------------------------
	            BOOL			SCPSTDCALL	vgfVFLIsWindows7OnComputer();
            //-----------------------------------------------------------------------------
	            BOOL			SCPSTDCALL	vgfVFLExecuteWebsiteDirectly(LPCTSTR pszUrlLinkName);
            //-----------------------------------------------------------------------------
	            BOOL			SCPSTDCALL	vgfVFLSetUserPrivilege(LPCTSTR lpszPrivilegeName, 
													            BOOL bEnablePrivilege);
            //-----------------------------------------------------------------------------
	            DWORD			SCPSTDCALL	vgfVFLWindows10OSBuildNumber();
            //-----------------------------------------------------------------------------
	            void			SCPSTDCALL  vgfVFLErrorExit(LPCWSTR lpszFunction);
            //-----------------------------------------------------------------------------
	            BOOL SCPSTDCALL vgfVFLCheckNetfxBuildNumber(const TCHAR *pszNetfxRegKeyName,
											            const TCHAR *pszNetfxRegKeyValue,
											            const int iRequestedVersionMajor,
											            const int iRequestedVersionMinor,
											            const int iRequestedVersionBuild,
											            const int iRequestedVersionRevision);

            //-----------------------------------------------------------------------------
	            BOOL			SCPSTDCALL	vgfVFLCheckNetfxVersionUsingMscoree(const TCHAR*);

            //-----------------------------------------------------------------------------
	            int				SCPSTDCALL	vgfVFLGetNetfxSPLevel(
											            const TCHAR *pszNetfxRegKeyName,
											            const TCHAR *pszNetfxRegValueName);
            //-----------------------------------------------------------------------------
	            BOOL			SCPSTDCALL	vgfVFLIsCurrentOSTabletMedCenter();
            //-----------------------------------------------------------------------------
	            BOOL			SCPSTDCALL vgfVFLIsNetfx10Installed();
            //-----------------------------------------------------------------------------
	            BOOL			SCPSTDCALL vgfVFLIsNetfx11Installed();
            //-----------------------------------------------------------------------------	
	            BOOL			SCPSTDCALL vgfVFLIsNetfx20Installed();
            //-----------------------------------------------------------------------------		
	            BOOL			SCPSTDCALL vgfVFLIsNetfx30Installed();
            //-----------------------------------------------------------------------------		
	            BOOL			SCPSTDCALL vgfVFLIsNetfx35Installed();
            //-----------------------------------------------------------------------------		
	            BOOL			SCPSTDCALL vgfVFLIsNetfx40ClientInstalled();
            //-----------------------------------------------------------------------------		
	            BOOL			SCPSTDCALL vgfVFLIsNetfx40FullInstalled();
            //-----------------------------------------------------------------------------		
	            BOOL			SCPSTDCALL vgfVFLIsNetfx45Installed();
            //-----------------------------------------------------------------------------		
	            BOOL			SCPSTDCALL vgfVFLIsNetfx451Installed();
            //-----------------------------------------------------------------------------		
	            BOOL			SCPSTDCALL vgfVFLIsNetfx452Installed();
            //-----------------------------------------------------------------------------		
	            BOOL			SCPSTDCALL vgfVFLIsNetfx46Installed();
            //-----------------------------------------------------------------------------		
	            BOOL			SCPSTDCALL vgfVFLIsNetfx461Installed();
            //-----------------------------------------------------------------------------		
	            BOOL			SCPSTDCALL vgfVFLIsNetfx462Installed();
            //-----------------------------------------------------------------------------		
	            BOOL			SCPSTDCALL vgfVFLIsNetfx47Installed();
            //-----------------------------------------------------------------------------	
	            BOOL			SCPSTDCALL vgfVFLIsNetfx471Installed();
            //-----------------------------------------------------------------------------		
	            BOOL			SCPSTDCALL vgfVFLIsNetfx472Installed();
            //-----------------------------------------------------------------------------	
	            BOOL			SCPSTDCALL vgfVFLIsNetfx473Installed();
            //-----------------------------------------------------------------------------	
	            BOOL			SCPSTDCALL vgfVFLIsNetfx48Installed();
            //-----------------------------------------------------------------------------
	            BOOL			SCPSTDCALL vgfVFLRegistryGetValue(HKEY hk, 
														            const TCHAR * pszKey,
														            const TCHAR * pszValue, 
														            DWORD dwType, 
														            LPBYTE data, 
														            DWORD dwSize);
            //-----------------------------------------------------------------------------
	            BOOL			SCPSTDCALL vgfVFLSetFileAttributeReadOnly(LPTSTR FileName);
            //-----------------------------------------------------------------------------	
	            VOID			SCPSTDCALL vgfVFLSetLastErrorEx(DWORD dwErrCode, DWORD dwType);







        */

        #endregion

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

        /// <summary>
        /// MessageBox from our famous Visual.Function.Library.dll written in C.
        /// </summary>
        /// <!-- Author TIPPO -->
        /// -------------------------------------------------------------------
        /// At next in new Project an better MessageBox as this old Style,
        /// Project "" - WPFMessageBox with many Features:
        /// -------------------------------------------------------------------
        /// WPFMessageBox: 3D Icons, Hyperlink, Clipboard, Copy, Scrollbar, 
        /// Expand WPFMessageBox to Full Window at Left Corner 
        /// Black Field click and make it greather,
        /// Timeout, set value and the WPFMessageBox 
        /// close automatic by no User Action!.
        /// -------------------------------------------------------------------
        /// (NOTE: same was in Windows Operation System 
        /// as MessageBoxTimeout Function)
        /// -------------------------------------------------------------------
        /// (NOTE: STOPPED a Thread with Thread.Sleep or 
        /// Sleep Function can write this:
        /// 
        /// Thread.Sleep(5000 * MessageBox("After OK Click, Thread continue!", 
        /// "Thread", OK, Icon...) );
        /// 
        /// * asteric as operator, so sleep the Thread 
        /// 5 seconds and than the MessageBox shows the Message.
        /// 
        /// Thread.Sleep(5000 * MethodName(parameters) );
        /// -------------------------------------------------------------------
        /// * asteric as operator, so sleep the Thread 5 seconds and 
        /// than execute the Call/Method.
        /// -------------------------------------------------------------------
        /// Many Timers in .NET Framework without any Control!
        /// 
        /// Timers Timer;
        /// Timer(interval, parameter, Call, x);
        /// The Timer execute after TimeInterval any time this Call, 
        /// don't forget the Timer.Stop!,
        /// Forget the Timer runs continue.
        /// -------------------------------------------------------------------
        /// Same in Mobile Class Vibrator as Timer, 
        /// forget Timer.Stop - Phone any time vibrate.
        /// -------------------------------------------------------------------
        /// <!-- Author TIPPO -->
        /// <param name="lpszText">set here your Text</param>
        /// <param name="lpszTitel">set here your Title</param>
        /// <param name="styles">Enumerator Styles: 
        /// Button, Icon, SetForeground, SystemModal</param>
        /// set here the Style do you want
        /// 1 - 4
        /// OK Button
        /// 1 Critical Icon
        /// 2 Exclamation Icon
        /// 3 Information Icon
        /// 4 Question Icon
        /// 5 - 8
        /// YESNO
        /// 9 - 12
        /// ABORTRETRYIGNORE
        /// 
        /// <remarks>
        /// Note!, MessageBox from System with public Flags,
        /// MessageBox is alltime in Foreground and SystemModal,
        /// so the user must be closed, 
        /// before work continue with other App/Window.
        /// AppModal you can switch to other App/Window.
        /// </remarks>
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



    } // end of class::NativeVisualFunctionLibrary


    /// <summary>
    /// 
    /// </summary>
    public static class NativeLicenseFunction
    {
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








    } // end of class::NativeLicenseFunction



} // end of namespace:: Visual.Function.Library

//*****************************************************************************
//***************** END OF FILE NativeVisualFunctionLibrary.cs ****************
//*****************************************************************************