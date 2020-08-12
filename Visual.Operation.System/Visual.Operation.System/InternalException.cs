/******************************************************************************
*	Copyright © 2019 by VGF-KernelTeam and Christian 'TIPPO' Kurs.
*			All Rights Reserved.
*
*   Parts of Copyright by Microsoft Corporation with Permission.
*   Many Thanks for this Help !
* 
*******************************************************************************/

/******************************************************************************
 * This software is the confidential and 
 * proprietary information of VGF-KernelTeam - ("Confidential Information").
 * You shall not disclose such Confidential Information and shall use it only 
 * in accordance with the terms of the License Agreement 
 * you entered into with VGF-KernelTeam.
 * 
 * VGF-KERNELTEAM MAKES NO REPRESENTATIONS OR WARRANTIES ABOUT THE SUITABILITY 
 * OF
 * THE SOFTWARE, EITHER EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE
 * IMPLIED WARRANTIES OF MERCHANTABILITY, 
 * FITNESS FOR A PARTICULAR PURPOSE, OR NON-INFRINGEMENT.
 * 
 * VGF-KERNELTEAM SHALL NOT BE LIABLE FOR ANY DAMAGES SUFFERED 
 * BY LICENSEE AS A RESULT OF USING, MODIFYING OR 
 * DISTRIBUTING THIS SOFTWARE OR ITS DERIVATIVES.
 * 
 * Copyright_Version_1.0_BETA
 * 
 * This file is the same as x that comes with y,
 * except that the has been changed so that it is compilable
 * under more than just
 * 
 *******************************************************************************/

/*******************************************************************************
    MAC, macOS, watchOS, tvOS is a registered trademark of Apple Computer, Inc. 
    ! NOTE ! iOS is a registered trademark of Cisco Corporation.
    Intel is a registered trademark of Intel Corporation. 

    Active Desktop, ActiveX, Authenticode, BackOffice, FoxPro, FrontPage, 
    Visual Studio, Jscript, Microsoft, Microsoft Press, MSDN, MS-DOS, MSN, 
    Outlook, PivotTable, PowerPoint, Visual Basic, Visual C++, Visual FoxPro, 
    Visual InterDev, Visual J++, J#, Visual Studio, Win32, Windows, 
    and Windows NT are either registered trademarks or 
    trademarks of Microsoft Corporation 
    in the United States and/or other countries.
    ---------------------------------------------------------------------------
    ! ATTENTION ! write for Export ! 
    ---------------------------------------------------------------------------
    This software is subject to the U.S. Export Administration Regulations and 
    other U.S. law, and may not be exported or re-exported to certain countries 
    ( Cuba, Iran, North Korea, Sudan, Syria, and the Crimea region of Ukraine) 
    or 
    to persons or entities prohibited from receiving U.S. exports 
    (including Denied Parties, Specially Designated Nationals, 
    and entities on the Bureau of Export Administration Entity List or 
    involved with missile technology or nuclear, chemical or biological weapons)

    © 1982 - 2019 Microsoft Corporation. All rights reserved.

*******************************************************************************/

// .NET Framework Directives - namespaces -
// grayed directives not in use !
//
// That's is the .NET Base Assembly - all Types, Objects
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// write here your Namespaces / Directives from Project-Solution

// this is not a assembly/directive, is only namespace from other Visual C# filename.cs
// in this Project-Solution, classname same as namespace written all with static




//-----------------------------------------------------------------------------
//
//
//-----------------------------------------------------------------------------
namespace Visual.Operation.System.InternalException
{
    /// <summary>
    /// Class Internal Exception
    /// </summary>
    /// <!-- Author TIPPO-->
    /// <remarks>
    /// insert VBNumber as info
    /// insert
    /// </remarks>
    internal static class InternalException
    {
        /*
        public enum vbErrors : Int64
        {
            None = 0,

            ReturnWOGoSub = 3,

            IllegalFuncCall = 5,

            Overflow = 6,

            OutOfMemory = 7,

            OutOfBounds = 9,

            ArrayLocked = 10,

            DivByZero = 11,

            TypeMismatch = 13,

            OutOfStrSpace = 14,

            ExprTooComplex = 16,

            CantContinue = 17,

            UserInterrupt = 18,

            ResumeWOErr = 20,

            OutOfStack = 28,

            UN_DONE = 29,

            UndefinedProc = 35

        TooManyClients = 47

        DLLLoadErr = 48

        DLLBadCallingConv = 49

        InternalError = 51

        BadFileNameOrNumber = 52

        FileNotFound = 53

        BadFileMode = 54

        FileAlreadyOpen = 55

        IOError = 57

        FileAlreadyExists = 58

        BadRecordLen = 59

        DiskFull = 61

        EndOfFile = 62

        BadRecordNum = 63

        TooManyFiles = 67

        DevUnavailable = 68

        PermissionDenied = 70

        DiskNotReady = 71

        DifferentDrive = 74

        PathFileAccess = 75

        PathNotFound = 76

        ObjNotSet = 91

        IllegalFor = 92

        BadPatStr = 93

        CantUseNull = 94

        UserDefined = 95

        AdviseLimit = 96

        BadCallToFriendFunction = 97

        CantPassPrivateObject = 98

        DLLCallException = 99

        DoesntImplementICollection = 100

        Abort = 287

        InvalidFileFormat = 321

        CantCreateTmpFile = 322

        InvalidResourceFormat = 325

        InvalidPropertyValue = 380

        InvalidPropertyArrayIndex = 381

        SetNotSupportedAtRuntime = 382

        SetNotSupported = 383

        NeedPropertyArrayIndex = 385

        SetNotPermitted = 387

        GetNotSupportedAtRuntime = 393

        GetNotSupported = 394

        PropertyNotFound = 422

        NoSuchControlOrProperty = 423

        NotObject = 424

        CantCreateObject = 429

        OLENotSupported = 430

        OLEFileNotFound = 432

        OLENoPropOrMethod = 438

        OLEAutomationError = 440

        LostTLB = 442

        OLENoDefault = 443

        ActionNotSupported = 445

        NamedArgsNotSupported = 446

        LocaleSettingNotSupported = 447

        NamedParamNotFound = 448

        ParameterNotOptional = 449

        FuncArityMismatch = 450

        NotEnum = 451

        InvalidOrdinal = 452

        InvalidDllFunctionName = 453

        CodeResourceNotFound = 454

        CodeResourceLockError = 455

        DuplicateKey = 457

        InvalidTypeLibVariable = 458

        ObjDoesNotSupportEvents = 459

        InvalidClipboardFormat = 460

        IdentNotMember = 461

        ServerNotFound = 462

        ObjNotRegistered = 463

        InvalidPicture = 481

        PrinterError = 482

        CantSaveFileToTemp = 735

        SearchTextNotFound = 744

        ReplacementsTooLong = 746

        NotYetImplemented = 32768

        FileNotFoundWithName = 40243

        CantFindDllEntryPoint = 59201

        SeekErr = 32771

        ReadFault = 32772

        WriteFault = 32773

        BadFunctionId = 32774

        FileLockViolation = 32775

        ShareRequired = 32789

        BufferTooSmall = 32790

        InvDataRead = 32792

        UnsupFormat = 32793

        RegistryAccess = 32796

        LibNotRegistered = 32797

        Usage = 32799

        UndefinedType = 32807

        QualifiedNameDisallowed = 32808

        InvalidState = 32809

        WrongTypeKind = 32810

        ElementNotFound = 32811

        AmbiguousName = 32812

        ModNameConflict = 32813

        UnknownLcid = 32814

        BadModuleKind = 35005

        NoContainingLib = 35009

        BadTypeId = 35010

        BadLibId = 35011

        Eof = 35012

        SizeTooBig = 35013

        ExpectedFuncNotModule = 35015

        ExpectedFuncNotRecord = 35016

        ExpectedFuncNotProject = 35017

        ExpectedFuncNotVar = 35018

        ExpectedTypeNotProj = 35019

        UnsuitableFuncPropMatch = 35020

        BrokenLibRef = 35021

        UnsupportedTypeLibFeature = 35022

        ModuleAsType = 35024

        InvalidTypeInfoKind = 35025

        InvalidTypeLibFunction = 35026

        OperationNotAllowedInDll = 40035

        CompileError = 40036

        CantEvalWatch = 40037

        MissingVbaTypeLib = 40038

        UserReset = 40040

        MissingEndBrack = 40041,

            IncorrectTypeChar = 40042,

            InvalidNumLit = 40043,

            IllegalChar = 40044,

            IdTooLong = 40045,

            StatementTooComplex = 40046,

            ExpectedTokens = 40047,

            InconsistentPropFuncs = 40067,

            CircularType = 40068,

            AccessViolation = 0x80004003, // This is E_POINTER.  This is what VB6 returns from err.Number when calling into a .NET assembly that throws an AccessViolation

            LastTrappable = ReplacementsTooLong

        }


        internal Exception MakeException(Int64 Number, string Description, bool VBDefinedError)
        {

            VBDefinedError = true;
            


            switch(Number)
                {


                case (long)InternalErrorsNumbers..None:
                break;
                case (long)InternalErrorsNumbers..ReturnWOGoSub: _

                case (long)InternalErrorsNumbers..ResumeWOErr:

                case (long)InternalErrorsNumbers..CantUseNull: _

                case (long)InternalErrorsNumbers..DoesntImplementICollection:

                    return new InvalidOperationException(Description);



                case (long)InternalErrorsNumbers..IllegalFuncCall, _

                    vbErrors.NamedParamNotFound, _

                    vbErrors.NamedArgsNotSupported, _

                    vbErrors.ParameterNotOptional

                    Return New ArgumentException(Description)



                case (long)InternalErrorsNumbers..OLENoPropOrMethod

                    Return New MissingMemberException(Description)



                case (long)InternalErrorsNumbers..Overflow

                    Return New OverflowException(Description)



                case (long)InternalErrorsNumbers..OutOfMemory, vbErrors.OutOfStrSpace

                    Return New OutOfMemoryException(Description)



                case (long)InternalErrorsNumbers..OutOfBounds

                    Return New IndexOutOfRangeException(Description)



                case (long)InternalErrorsNumbers..DivByZero

                    Return New DivideByZeroException(Description)



                case (long)InternalErrorsNumbers..TypeMismatch

                    Return New InvalidCastException(Description)



                case (long)InternalErrorsNumbers..OutOfStack

                    Return New StackOverflowException(Description)



                case (long)InternalErrorsNumbers..DLLLoadErr

                    Return New TypeLoadException(Description)



                case (long)InternalErrorsNumbers..FileNotFound

                    Return New IO.FileNotFoundException(Description)



                case (long)InternalErrorsNumbers..EndOfFile

                    Return New IO.EndOfStreamException(Description)



                case (long)InternalErrorsNumbers..IOError, _

                    vbErrors.BadFileNameOrNumber, _

                    vbErrors.BadFileMode, _

                    vbErrors.FileAlreadyOpen, _

                    vbErrors.FileAlreadyExists, _

                    vbErrors.BadRecordLen, _

                    vbErrors.DiskFull, _

                    vbErrors.BadRecordNum, _

                    vbErrors.TooManyFiles, _

                    vbErrors.DevUnavailable, _

                    vbErrors.PermissionDenied, _

                    vbErrors.DiskNotReady, _

                    vbErrors.DifferentDrive, _

                    vbErrors.PathFileAccess

                    Return New IO.IOException(Description)



                case (long)InternalErrorsNumbers..PathNotFound, _

                    vbErrors.OLEFileNotFound

                    Return New IO.FileNotFoundException(Description)



                case (long)InternalErrorsNumbers..ObjNotSet

                    Return New NullReferenceException(Description)



                case (long)InternalErrorsNumbers..PropertyNotFound

                    Return New MissingFieldException(Description)



                case (long)InternalErrorsNumbers..CantCreateObject, _

                    vbErrors.ServerNotFound

                    Return New Exception(Description)



                case (long)InternalErrorsNumbers..AccessViolation

                    Return New AccessViolationException() 'We never want a custom description here.  Use the localized message that comes for free inside the exception



                Case Else

                    'Fall below to default

                    VBDefinedError = False

                    Return New Exception(Description)

            }



            VBDefinedError = false;

            return new Exception(Description);



        }


        internal static class InternalErrorException
        {




            public void new(string Message)
            {
                    MyBase.new(message);

            }



        Public Sub New(ByVal message As String, ByVal innerException As System.Exception)

            MyBase.New(message, innerException)

        End Sub



        ' default constructor

        Public Sub New()

            MyBase.New(GetResourceString(SR.InternalError_VisualBasicRuntime))

        End Sub

    */

        /*
                public static int VOLThrowException(int ErrorCode)
                {
                    try
                    {             
                    }
                    catch(SystemException ex)when(ex is IndexOutOfRangeException | ex is InsufficientMemoryException | ex is InvalidOperationException)
                    {

                    }

                }

            */

        public enum InternalErrorsNumbers : long
        {
            None = 0,

            ReturnWOGoSub = 3,

            IllegalFuncCall = 5,

            Overflow = 6,

            OutOfMemory = 7,

            OutOfBounds = 9,

            ArrayLocked = 10,

            DivByZero = 11,

            TypeMismatch = 13,

            OutOfStrSpace = 14,

            ExprTooComplex = 16,

            CantContinue = 17,

            UserInterrupt = 18,

            ResumeWOErr = 20,

            OutOfStack = 28,

            UNDONE = 29,

            UndefinedProc = 35,

            TooManyClients = 47,

            DLLLoadErr = 48,

            DLLBadCallingConv = 49,

            InternalError = 51,

            BadFileNameOrNumber = 52,

            FileNotFound = 53,

            BadFileMode = 54,

            FileAlreadyOpen = 55,

            IOError = 57,

            FileAlreadyExists = 58,

            BadRecordLen = 59,

            DiskFull = 61,

            EndOfFile = 62,

            BadRecordNum = 63,

            TooManyFiles = 67,

            DevUnavailable = 68,

            PermissionDenied = 70,

            DiskNotReady = 71,

            DifferentDrive = 74,

            PathFileAccess = 75,

            PathNotFound = 76,

            ObjNotSet = 91,

            IllegalFor = 92,

            BadPatStr = 93,

            CantUseNull = 94,

            UserDefined = 95,

            AdviseLimit = 96,

            BadCallToFriendFunction = 97,

            CantPassPrivateObject = 98,

            DLLCallException = 99,

            DoesntImplementICollection = 100,

            Abort = 287,

            InvalidFileFormat = 321,

            CantCreateTmpFile = 322,

            InvalidResourceFormat = 325,

            InvalidPropertyValue = 380,

            InvalidPropertyArrayIndex = 381,

            SetNotSupportedAtRuntime = 382,

            SetNotSupported = 383,

            NeedPropertyArrayIndex = 385,

            SetNotPermitted = 387,

            GetNotSupportedAtRuntime = 393,

            GetNotSupported = 394,

            PropertyNotFound = 422,

            NoSuchControlOrProperty = 423,

            NotObject = 424,

            CantCreateObject = 429,

            OLENotSupported = 430,

            OLEFileNotFound = 432,

            OLENoPropOrMethod = 438,

            OLEAutomationError = 440,

            LostTLB = 442,

            OLENoDefault = 443,

            ActionNotSupported = 445,

            NamedArgsNotSupported = 446,

            LocaleSettingNotSupported = 447,

            NamedParamNotFound = 448,

            ParameterNotOptional = 449,

            FuncArityMismatch = 450,

            NotEnum = 451,

            InvalidOrdinal = 452,

            InvalidDllFunctionName = 453,

            CodeResourceNotFound = 454,

            CodeResourceLockError = 455,

            DuplicateKey = 457,

            InvalidTypeLibVariable = 458,

            ObjDoesNotSupportEvents = 459,

            InvalidClipboardFormat = 460,

            IdentNotMember = 461,

            ServerNotFound = 462,

            ObjNotRegistered = 463,

            InvalidPicture = 481,

            PrinterError = 482,

            CantSaveFileToTemp = 735,

            SearchTextNotFound = 744,

            ReplacementsTooLong = 746,

            NotYetImplemented = 32768,

            FileNotFoundWithName = 40243,

            CantFindDllEntryPoint = 59201,

            SeekErr = 32771,

            ReadFault = 32772,

            WriteFault = 32773,

            BadFunctionId = 32774,

            FileLockViolation = 32775,

            ShareRequired = 32789,

            BufferTooSmall = 32790,

            InvDataRead = 32792,

            UnsupFormat = 32793,

            RegistryAccess = 32796,

            LibNotRegistered = 32797,

            Usage = 32799,

            UndefinedType = 32807,

            QualifiedNameDisallowed = 32808,

            InvalidState = 32809,

            WrongTypeKind = 32810,

            ElementNotFound = 32811,

            AmbiguousName = 32812,

            ModNameConflict = 32813,

            UnknownLcid = 32814,

            BadModuleKind = 35005,

            NoContainingLib = 35009,

            BadTypeId = 35010,

            BadLibId = 35011,

            Eof = 35012,

            SizeTooBig = 35013,

            ExpectedFuncNotModule = 35015,

            ExpectedFuncNotRecord = 35016,

            ExpectedFuncNotProject = 35017,

            ExpectedFuncNotVar = 35018,

            ExpectedTypeNotProj = 35019,

            UnsuitableFuncPropMatch = 35020,

            BrokenLibRef = 35021,

            UnsupportedTypeLibFeature = 35022,

            ModuleAsType = 35024,

            InvalidTypeInfoKind = 35025,

            InvalidTypeLibFunction = 35026,

            OperationNotAllowedInDll = 40035,

            CompileError = 40036,

            CantEvalWatch = 40037,

            MissingVbaTypeLib = 40038,

            UserReset = 40040,

            MissingEndBrack = 40041,

            IncorrectTypeChar = 40042,

            InvalidNumLit = 40043,

            IllegalChar = 40044,

            IdTooLong = 40045,

            StatementTooComplex = 40046,

            ExpectedTokens = 40047,

            InconsistentPropFuncs = 40067,

            CircularType = 40068,

            AccessViolation = 0x80004003u, // This is E_POINTER.  This is what VB6 returns from err.Number when calling into a .NET assembly that throws an AccessViolation

            LastTrappable = ReplacementsTooLong

        }













        /*

        internal static Exception MakeException(long Number, string Description, bool DefinedError)
        {

            DefinedError = true;



            switch (Number)
            {

                case (long)InternalException.InternalErrorsNumbers.None:

                    break;
                case (long)InternalErrorsNumbers.ReturnWOGoSub:

                    break;
                case (long)InternalErrorsNumbers.ResumeWOErr:

                    break;
                case (long)InternalErrorsNumbers.CantUseNull:

                    break;
                case (long)InternalErrorsNumbers.DoesntImplementICollection:

                    break;
                case (long)InternalErrorsNumbers.IllegalFuncCall:

                    break;
                case (long)InternalErrorsNumbers.NamedParamNotFound:

                case (long)InternalErrorsNumbers.NamedArgsNotSupported:

                    break;
                case (long)InternalErrorsNumbers.ParameterNotOptional:

                    break;
                case (long)InternalErrorsNumbers.OLENoPropOrMethod:

                    break;
                case (long)InternalErrorsNumbers.Overflow:

                    break;
                case (long)InternalErrorsNumbers.OutOfMemory:

                    break;
                case (long)InternalErrorsNumbers.OutOfStrSpace:

                    break;
                case (long)InternalErrorsNumbers.OutOfBounds:

                    break;
                case (long)InternalErrorsNumbers.DivByZero:

                    break;
                case (long)InternalErrorsNumbers.TypeMismatch:

                    break;
                case (long)InternalErrorsNumbers.OutOfStack:

                    break;
                case (long)InternalErrorsNumbers.DLLLoadErr:

                    break;
                case (long)InternalErrorsNumbers.FileNotFound:

                    break;
                case (long)InternalErrorsNumbers.EndOfFile:

                    break;
                case (long)InternalErrorsNumbers.IOError:
                    
                        switch ((long)InternalErrorsNumbers.IOError)
                        {

                            case (long)InternalErrorsNumbers.BadFileNameOrNumber:

                                break;
                            case (long)InternalErrorsNumbers.BadFileMode:

                                break;
                            case (long)InternalErrorsNumbers.FileAlreadyOpen:

                                break;
                            case (long)InternalErrorsNumbers.FileAlreadyExists:

                            case (long)InternalErrorsNumbers.BadRecordLen:

                            case (long)InternalErrorsNumbers.DiskFull:

                            case (long)InternalErrorsNumbers.BadRecordNum:

                            case (long)InternalErrorsNumbers.TooManyFiles:

                            case (long)InternalErrorsNumbers.DevUnavailable:

                            case (long)InternalErrorsNumbers.PermissionDenied:

                            case (long)InternalErrorsNumbers.DiskNotReady:

                            case (long)InternalErrorsNumbers.DifferentDrive:

                            case (long)InternalErrorsNumbers.PathFileAccess:

                                break;
                            default:
                                break;
                        }
                    
                case (long)InternalErrorsNumbers.PathNotFound:


                    break;
                case (long)InternalErrorsNumbers.ObjNotSet:


                    break;
                case (long)InternalErrorsNumbers.PropertyNotFound:


                    break;
                case (long)InternalErrorsNumbers.CantCreateObject:

                    
                    break;
                case (long)InternalErrorsNumbers.AccessViolation:

                    break;
                default:
                    break;

            } // end of switch(Number)

        } // end of Method::MakeException



    } // end of class::InternalException

    */

    }


} // end of namespace::Visual.Operation.System.InternalException
