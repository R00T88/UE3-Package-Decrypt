Module UE3_PACKAGE_ANALISYS

    Private Const HEADER_MAGIC = -1641380927

    ' Package Flags
    Public Const PF_AllowDownload = &H1
    Public Const PF_ClientOptional = &H2
    Public Const PF_ServerSideOnly = &H4
    Public Const PF_BrokenLinks = &H8
    Public Const PF_Cooked = &H8
    Public Const PF_Unsecure = &H10
    Public Const PF_Encrypted = &H20
    Public Const PF_Need = &H8000
    Public Const PF_Map = &H20000
    Public Const PF_Script = &H200000
    Public Const PF_Debug = &H400000
    Public Const PF_Imports = &H800000
    Public Const PF_Compressed = &H2000000
    Public Const PF_FullyCompressed = &H4000000
    Public Const PF_NoExportsData = &H20000000
    Public Const PF_Stripped = &H40000000
    Public Const PF_Protected = &H80000000

    ' Package Flags Compressed
    Public Const PF_Compressed_ZLIB = &H1
    Public Const PF_Compressed_LZO = &H2
    Public Const PF_Compressed_LZX = &H4

    ' Object Flags High
    Public Const OF_H_Obsolete = &H20
    Public Const OF_H_Final = &H80
    Public Const OF_H_PerObjectLocalized = &H100
    Public Const OF_H_PropertiesObject = &H200
    Public Const OF_H_ArchetypeObject = &H400
    Public Const OF_H_RemappedName = &H800

    ' Object Flags Low
    Public Const OF_L_Transactional = &H1
    Public Const OF_L_Public = &H4
    Public Const OF_L_PropertiesObject = &H200
    Public Const OF_L_LoadForClient = &H10000
    Public Const OF_L_LoadForServer = &H20000
    Public Const OF_L_LoadForEdit = &H40000
    Public Const OF_L_Standalone = &H80000
    Public Const OF_L_NotForClient = &H100000
    Public Const OF_L_NotForServer = &H200000
    Public Const OF_L_NotForEditg = &H400000
    Public Const OF_L_HasStack = &H2000000
    Public Const OF_L_Native = &H4000000
    Public Const OF_L_Marked = &H8000000

    ' Export Flag
    Public Const EF_ForcedExport = &H1

    ' Function Flags
    Public Const FF_Final = &H1
    Public Const FF_Defined = &H2
    Public Const FF_Iterator = &H4
    Public Const FF_PreOperator = &H10
    Public Const FF_Net = &H40
    Public Const FF_NetReliable = &H80
    Public Const FF_Exec = &H200
    Public Const FF_Native = &H400
    Public Const FF_Event = &H800
    Public Const FF_Operator = &H1000
    Public Const FF_Static = &H2000
    Public Const FF_NoExport = &H4000
    Public Const FF_OptionalParameters = &H4000
    Public Const FF_Const = &H8000
    Public Const FF_Invariant = &H10000
    Public Const FF_Public = &H20000
    Public Const FF_Private = &H40000
    Public Const FF_Protected = &H80000
    Public Const FF_Delegate = &H100000
    Public Const FF_NetServer = &H200000
    Public Const FF_NetClient = &H1000000
    Public Const FF_DLLImport = &H2000000

    ' Class Flags
    Public Const CF_Abstract = &H1
    Public Const CF_Compiled = &H2
    Public Const CF_Config = &H4
    Public Const CF_Transient = &H8
    Public Const CF_Parsed = &H10
    Public Const CF_Localized = &H20
    Public Const CF_SafeReplace = &H40
    Public Const CF_RuntimeStatic = &H80
    Public Const CF_NoExport = &H100
    Public Const CF_Placeable = &H200
    Public Const CF_PerObjectConfig = &H400
    Public Const CF_NativeReplication = &H800
    Public Const CF_EditInlineNew = &H1000
    Public Const CF_CollapseCategories = &H2000
    Public Const CF_ExportStructs = &H4000
    Public Const CF_Instanced = &H200000
    Public Const CF_HideDropDown = &H400000
    Public Const CF_HasComponents = &H400000
    Public Const CF_CacheExempt = &H800000
    Public Const CF_Hidden = &H800000
    Public Const CF_ParseConfig = &H1000000
    Public Const CF_Deprecated = &H1000000
    Public Const CF_HideDropDown2 = &H2000000
    Public Const CF_Exported = &H4000000
    Public Const CF_NativeOnly = &H20000000

    ' Struct Flags
    Public Const SF_Native = &H1
    Public Const SF_Export = &H2
    Public Const SF_Long = &H4
    Public Const SF_HasComponents = &H4
    Public Const SF_Init = &H8
    Public Const SF_Transient = &H8
    Public Const SF_Atomic = &H10
    Public Const SF_Immutable = &H20
    Public Const SF_StrictConfig = &H40
    Public Const SF_ImmutableWhenCooked = &H80
    Public Const SF_AtomicWhenCooked = &H100

    ' Property Flags Low
    Public Const PF_L_Editable = &H1
    Public Const PF_L_Const = &H2
    Public Const PF_L_Input = &H4
    Public Const PF_L_ExportObject = &H8
    Public Const PF_L_OptionalParm = &H10
    Public Const PF_L_Net = &H20
    Public Const PF_L_EditConstArray = &H40
    Public Const PF_L_EditFixedSize = &H40
    Public Const PF_L_Parm = &H80
    Public Const PF_L_OutParm = &H100
    Public Const PF_L_SkipParm = &H200
    Public Const PF_L_ReturnParm = &H400
    Public Const PF_L_CoerceParm = &H800
    Public Const PF_L_Native = &H1000
    Public Const PF_L_Transient = &H2000
    Public Const PF_L_Config = &H4000
    Public Const PF_L_Localized = &H8000
    Public Const PF_L_Travel = &H10000
    Public Const PF_L_EditConst = &H20000
    Public Const PF_L_GlobalConfig = &H40000
    Public Const PF_L_Component = &H80000
    Public Const PF_L_OnDemand = &H100000
    Public Const PF_L_Init = &H100000
    Public Const PF_L_New = &H200000
    Public Const PF_L_DuplicateTransient = &H200000
    Public Const PF_L_NeedCtorLink = &H400000
    Public Const PF_L_NoExport = &H800000
    Public Const PF_L_Cache = &H1000000
    Public Const PF_L_NoImport = &H1000000
    Public Const PF_L_EditorData = &H2000000
    Public Const PF_L_NoClear = &H2000000
    Public Const PF_L_EditInline = &H4000000
    Public Const PF_L_EdFindable = &H8000000
    Public Const PF_L_EditInlineUse = &H10000000
    Public Const PF_L_Deprecated = &H20000000
    Public Const PF_L_EditInlineNotify = &H40000000
    Public Const PF_L_DataBinding = &H40000000
    Public Const PF_L_SerializeText = &H80000000
    Public Const PF_L_Automated = &H80000000

    ' Property Flags High
    Public Const PF_H_RepNotify = &H1
    Public Const PF_H_Interp = &H2
    Public Const PF_H_NonTransactional = &H4
    Public Const PF_H_EditorOnly = &H8
    Public Const PF_H_NotForConsole = &H10
    Public Const PF_H_RepRetry = &H20
    Public Const PF_H_PrivateWrite = &H40
    Public Const PF_H_ProtectedWrite = &H80
    Public Const PF_H_Archetype = &H100
    Public Const PF_H_EditHide = &H200
    Public Const PF_H_EditTextBox = &H400
    Public Const PF_H_CrossLevelPassive = &H1000
    Public Const PF_H_CrossLevelActive = &H2000

    ' State Flags
    Public Const SF_Editable = &H1
    Public Const SF_Auto = &H2
    Public Const SF_Simulated = &H4

    ' UE3 Token
    Public Const EX_LocalVariable = &H0
    Public Const EX_InstanceVariable = &H1
    Public Const EX_DefaultVariable = &H2
    Public Const EX_Return = &H4
    Public Const EX_Switch = &H5
    Public Const EX_Jump = &H6
    Public Const EX_JumpIfNot = &H7
    Public Const EX_Stop = &H8
    Public Const EX_Assert = &H9
    Public Const EX_Case = &HA
    Public Const EX_Nothing = &HB
    Public Const EX_LabelTable = &HC
    Public Const EX_GotoLabel = &HD
    Public Const EX_EatReturnValue = &HE
    Public Const EX_Let = &HF
    Public Const EX_DynArrayElement = &H10
    Public Const EX_New = &H11
    Public Const EX_ClassContext = &H12
    Public Const EX_Metacast = &H13
    Public Const EX_LetBool = &H14
    Public Const EX_EndParmValue = &H15
    Public Const EX_EndFunctionParms = &H16
    Public Const EX_Self = &H17
    Public Const EX_Skip = &H18
    Public Const EX_Context = &H19
    Public Const EX_ArrayElement = &H1A
    Public Const EX_VirtualFunction = &H1B
    Public Const EX_FinalFunction = &H1C
    Public Const EX_IntConst = &H1D
    Public Const EX_FloatConst = &H1E
    Public Const EX_StringConst = &H1F
    Public Const EX_ObjectConst = &H20
    Public Const EX_NameConst = &H21
    Public Const EX_RotationConst = &H22
    Public Const EX_VectorConst = &H23
    Public Const EX_ByteConst = &H24
    Public Const EX_IntZero = &H25
    Public Const EX_IntOne = &H26
    Public Const EX_True = &H27
    Public Const EX_False = &H28
    Public Const EX_NativeParm = &H29
    Public Const EX_NoObject = &H2A
    Public Const EX_IntConstByte = &H2C
    Public Const EX_BoolVariable = &H2D
    Public Const EX_DynamicCast = &H2E
    Public Const EX_Iterator = &H2F
    Public Const EX_IteratorPop = &H30
    Public Const EX_IteratorNext = &H31
    Public Const EX_StructCmpEq = &H32
    Public Const EX_StructCmpNe = &H33
    Public Const EX_UnicodeStringConst = &H34
    Public Const EX_StructMember = &H35
    Public Const EX_DynArrayLength = &H36
    Public Const EX_GlobalFunction = &H37
    Public Const EX_PrimitiveCast = &H38
    Public Const EX_DynArrayInsert = &H39
    Public Const EX_ReturnNothing = &H3A
    Public Const EX_EqualEqual_DelDel = &H3B
    Public Const EX_NotEqual_DelDel = &H3C
    Public Const EX_EqualEqual_DelFunc = &H3D
    Public Const EX_NotEqual_DelFunc = &H3E
    Public Const EX_EmptyDelegate = &H3F
    Public Const EX_DynArrayRemove = &H40
    Public Const EX_DebugInfo = &H41
    Public Const EX_DelegateFunction = &H42
    Public Const EX_DelegateProperty = &H43
    Public Const EX_LetDelegate = &H44
    Public Const EX_Conditional = &H45
    Public Const EX_DynArrayFind = &H46
    Public Const EX_DynArrayFindStruct = &H47
    Public Const EX_LocalOutVariable = &H48
    Public Const EX_DefaultParmValue = &H49
    Public Const EX_EmptyParmValue = &H4A
    Public Const EX_InstanceDelegate = &H4B
    Public Const EX_GoW_DefaultValue = &H50
    Public Const EX_InterfaceContext = &H51
    Public Const EX_InterfaceCast = &H52
    Public Const EX_EndOfScript = &H53
    Public Const EX_DynArrayAdd = &H54
    Public Const EX_DynArrayAddItem = &H55
    Public Const EX_DynArrayRemoveItem = &H56
    Public Const EX_DynArrayInsertItem = &H57
    Public Const EX_DynArrayIterator = &H58
    Public Const EX_ExtendedNative = &H60
    Public Const EX_FirstNative = &H70

    Private Const UNKNOWN_VAR_LENGHT = 12
    Private Const GUID_VAR_LENGHT = 16
    Private Const UNKNOWN_OBJECT_STACK_LENGHT = 22
    Private Const UNKNOWN_ENGINE_VERSION_LENGHT = 28

    Structure UE3_TABLES_NAMES
        Dim szName As String
        Dim dwFlag As UE3_OBJECTFLAGS
    End Structure

    Structure UE3_NAMEINDEX
        Dim dwIndex As Int32
        Dim dwNumber As Int32
    End Structure

    Structure UE3_NETOBJECTS
        Dim dwNetObject As Int32
    End Structure

    Structure UE3_OBJECTFLAGS
        Dim dwHighFlag As Int32
        Dim dwLowFlag As Int32
    End Structure

    Structure UE3_TABLES_EXPORTS
        Dim dwClassObject As Int32
        Dim dwSuperObject As Int32
        Dim dwOuterObject As Int32
        Dim pObjectName As UE3_NAMEINDEX
        Dim dwArchetypeObject As Int32
        Dim pObjectFlags As UE3_OBJECTFLAGS
        Dim dwSerialSize As Int32
        Dim dwSerialOffset As Int32
        Dim dwExportFlags As Int32
        Dim dwNetObjectsCount As Int32
        Dim dwPackageGUID() As Byte
        Dim dwUnknown000 As Int32
        Dim pNetObjects() As UE3_NETOBJECTS
    End Structure

    Structure UE3_TABLES_IMPORTS
        Dim pPackageName As UE3_NAMEINDEX
        Dim pClassName As UE3_NAMEINDEX
        Dim dwOuterObject As Int32
        Dim pObjectName As UE3_NAMEINDEX
    End Structure

    Structure UE3_TABLE_FUNCTIONS
        Dim dwExportIndex As Int32
        Dim dwNextObjectIndex As Int32
        Dim pUObjectDefaultProperties() As UE3_TABLE_UDEFAULTPROPERTIES
        Dim dwNextField As Int32
        Dim dwParentField As Int32
        Dim dwScriptText As Int32
        Dim dwChildren As Int32
        Dim dwCppText As Int32
        Dim dwLine As Int32
        Dim dwTextPos As Int32
        Dim dwByteScriptSize As Int32
        Dim dwDataScriptSize As Int32
        Dim dwByteScript() As Byte
        Dim dwByteScriptStartPosition As Int32
        Dim dwByteScriptEndPosition As Int32
        Dim dwNativeTokenIndex As Int16
        Dim dwOperPrecedence As Byte
        Dim dwFunctionFlags As Int32
        Dim dwRepOffset As Int16
        Dim pFriendlyName As UE3_NAMEINDEX
    End Structure

    Structure UE3_TABLE_CONSTS
        Dim dwExportIndex As Int32
        Dim dwNextObjectIndex As Int32
        Dim pUObjectDefaultProperties() As UE3_TABLE_UDEFAULTPROPERTIES
        Dim dwParentField As Int32
        Dim dwNextField As Int32
        Dim dwConstLenght As Int32
        Dim szValue As String
    End Structure

    Structure UE3_TABLE_ENUMS
        Dim dwExportIndex As Int32
        Dim dwNextObjectIndex As Int32
        Dim pUObjectDefaultProperties() As UE3_TABLE_UDEFAULTPROPERTIES
        Dim dwParentField As Int32
        Dim dwNextField As Int32
        Dim dwEnumLenght As Int32
        Dim pEnumValue() As UE3_NAMEINDEX
    End Structure

    Structure UE3_TMAP
        Dim pTK As UE3_NAMEINDEX
        Dim PTI As Int32
    End Structure

    Structure UE3_TMAP_2
        Dim pTK As Int32
        Dim PTI As Int32
    End Structure

    Structure UE3_TABLE_CLASSES
        Dim dwExportIndex As Int32
        Dim dwNextObjectIndex As Int32
        Dim dwNextField As Int32
        Dim dwParentField As Int32
        Dim dwScriptText As Int32
        Dim dwChildren As Int32
        Dim dwCppText As Int32
        Dim dwLine As Int32
        Dim dwTextPos As Int32
        Dim dwByteScriptSize As Int32
        Dim dwDataScriptSize As Int32
        Dim dwByteScript() As Byte
        Dim dwProbeMask As Int32
        Dim dwLabelTableOffset As Int16
        Dim dwStateFlags As Int32
        Dim dwStateMapSize As Int32
        Dim pStateMap() As UE3_TMAP
        Dim dwClassFlags As Int32
    End Structure

    Structure UE3_TABLE_UDEFAULTPROPERTIES
        Dim pNameIdx As UE3_NAMEINDEX
        Dim pTypeIdx As UE3_NAMEINDEX
        Dim dwPropertySize As Int32
        Dim dwArrayIdx As Int32
        Dim dwBoolValue As Byte
        Dim pInnerNameIdx As UE3_NAMEINDEX
        Dim pInnerValue() As Byte
    End Structure

    Structure UE3_TABLE_SCRIPTSTRUCTS
        Dim dwExportIndex As Int32
        Dim dwNextObjectIndex As Int32
        Dim pUObjectDefaultProperties() As UE3_TABLE_UDEFAULTPROPERTIES
        Dim dwNextField As Int32
        Dim dwParentField As Int32
        Dim dwScriptText As Int32
        Dim dwChildren As Int32
        Dim dwCppText As Int32
        Dim dwLine As Int32
        Dim dwTextPos As Int32
        Dim dwByteScriptSize As Int32
        Dim dwDataScriptSize As Int32
        Dim dwByteScript() As Byte
        Dim dwStructFlag As Int32
        Dim pUDefaultProperties() As UE3_TABLE_UDEFAULTPROPERTIES
    End Structure

    Structure UE3_TABLE_PROPERTIES
        Dim dwExportIndex As Int32
        Dim dwNextObjectIndex As Int32
        Dim pUObjectDefaultProperties() As UE3_TABLE_UDEFAULTPROPERTIES
        Dim dwParentField As Int32
        Dim dwNextField As Int32
        Dim dwArrayDim As Int16
        Dim dwElementSize As Int16
        Dim pFlag As UE3_OBJECTFLAGS
        Dim pCategoryIndex As UE3_NAMEINDEX
        Dim dwArrayEnumRef As Int32
        Dim dwRepOffset As Int16
    End Structure

    Structure UE3_TABLE_STATES
        Dim dwExportIndex As Int32
        Dim dwNextObjectIndex As Int32
        Dim pUObjectDefaultProperties() As UE3_TABLE_UDEFAULTPROPERTIES
        Dim dwNextField As Int32
        Dim dwParentField As Int32
        Dim dwScriptText As Int32
        Dim dwChildren As Int32
        Dim dwCppText As Int32
        Dim dwLine As Int32
        Dim dwTextPos As Int32
        Dim dwByteScriptSize As Int32
        Dim dwDataScriptSize As Int32
        Dim dwByteScript() As Byte
        Dim dwProbeMask As Int32
        Dim dwLabelTableOffset As Int16
        Dim dwStateFlags As Int32
        Dim dwStateMapSize As Int32
        Dim pStateMap() As UE3_TMAP
    End Structure

    Private Structure FGenerationInfo
        Dim dwExportCount As Int32
        Dim dwNameCount As Int32
        Dim dwNetObjectCount As Int32
    End Structure

    Private Structure FCompressedChunk
        Dim dwUncompressedOffset As Int32
        Dim dwUncompressedSize As Int32
        Dim dwCompressedOffset As Int32
        Dim dwCompressedSize As Int32
    End Structure

    Private Structure FCompressdChunkHeaderBlock
        Dim dwCompressedSize As Int32
        Dim dwUncompressedSize As Int32
    End Structure

    Private Structure FCompressedChunkHeader
        Dim dwSignature As Int32
        Dim dwBlockSize As Int32
        Dim dwCompressedSize As Int32
        Dim dwUncompressedSize As Int32
        Dim pFCompressdChunkHeaderBlock() As FCompressdChunkHeaderBlock
    End Structure

    Private Structure UE3_HEADER_PACKAGE_FORMAT
        Dim dwSignature As Int32
        Dim dwPackageVersion As Int16
        Dim dwLicenseeVersion As Int16
        Dim dwHeaderSize As Int32                   ' PackageVersion >= 249
        Dim dwFolderNameLenght As Int32
        Dim szFolderName() As Byte                ' PackageVersion >= 269
        Dim dwPackageFlag As Int32
        Dim dwNameCount As Int32
        Dim dwNameOffset As Int32
        Dim dwExportCount As Int32
        Dim dwExportOffset As Int32
        Dim dwImportCount As Int32
        Dim dwImportOffsert As Int32
        Dim dwDependsOffset As Int32                ' PackageVersion >= 415
        Dim dwSerialOffset As Int32
        Dim dwUnknownVar() As Byte                  ' PackageVersion >= 584
        Dim dwGUID() As Byte                        ' PackageVersion >= 68
        Dim dwFGenerationInfoCount As Int32
        Dim pFGenerationInfo() As FGenerationInfo   ' PackageVersion >= 68
        Dim dwEngineVersion As Int32                ' PackageVersion >= 245              
        Dim dwCookerVersion As Int32                ' PackageVersion >= 277
        Dim dwCompressionFlag As Int32              ' PackageVersion >= 334
        Dim dwFCompressedChunkCount As Int32
        Dim pFCompressedChunk() As FCompressedChunk
        Dim dwEndOfSection As Int32
        Dim dwGapBytes() As Byte
        Dim szGameName As String
        Dim bFullCompressed As Boolean
    End Structure

    Private szErrorMessage As String

    Private pUE3Header As UE3_HEADER_PACKAGE_FORMAT
    Private pFCompressedChunkHeader As FCompressedChunkHeader

    Public pUE3TablesNames() As UE3_TABLES_NAMES
    Public pUE3TablesExports() As UE3_TABLES_EXPORTS
    Public pUE3TablesImports() As UE3_TABLES_IMPORTS
    Public pUE3TablesFunctions() As UE3_TABLE_FUNCTIONS
    Public pUE3TablesConsts() As UE3_TABLE_CONSTS
    Public pUE3TablesEnums() As UE3_TABLE_ENUMS
    Public pUE3TablesClass() As UE3_TABLE_CLASSES
    Public pUE3TablesScriptStruct() As UE3_TABLE_SCRIPTSTRUCTS
    Public pUE3TablesProperties() As UE3_TABLE_PROPERTIES
    Public pUE3TablesStates() As UE3_TABLE_STATES

    Function DeserializePackage(ByVal szPackageName As String, ByVal szNewPackageName As String) As Integer

        Dim dwResult As Integer

        szErrorMessage = ""

        dwResult = ReadPackageHeader(szPackageName)

        If dwResult <> 0 Then
            Select Case dwResult
                Case -1
                    MsgBox("Percorso " + szPackageName + " non valido !", MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "ReadPackageHeader()")
                Case -2
                    MsgBox("Signature del file non valida !", MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "ReadPackageHeader()")
                Case -3
                    MsgBox("Compressione file non supportata !", MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "ReadPackageHeader()")
                Case -4
                    MsgBox(szErrorMessage, MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "ReadPackageHeader()")
            End Select
            Return -1
        End If

        If pUE3Header.bFullCompressed Then
            dwResult = DecompressFullCompression(szPackageName, szNewPackageName)

            If dwResult <> 0 Then
                Select Case dwResult
                    Case -1
                        MsgBox("Signature del file non valida !", MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "ReadPackageHeader()")
                    Case -2
                        MsgBox(szErrorMessage, MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "ReadPackageHeader()")
                End Select
                Return -1
            End If

            szPackageName = szNewPackageName

            dwResult = ReadPackageHeader(szPackageName)

            If dwResult <> 0 Then
                Select Case dwResult
                    Case -1
                        MsgBox("Percorso " + szPackageName + " non valido !", MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "ReadPackageHeader()")
                    Case -2
                        MsgBox("Signature del file non valida !", MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "ReadPackageHeader()")
                    Case -3
                        MsgBox("Compressione file non supportata !", MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "ReadPackageHeader()")
                    Case -4
                        MsgBox(szErrorMessage, MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "ReadPackageHeader()")
                End Select
                Return -1
            End If
        End If

        If pUE3Header.dwCompressionFlag <> 0 Then
            dwResult = WritePackageHeader(szNewPackageName)

            If dwResult <> 0 Then
                Select Case dwResult
                    Case -1
                        MsgBox(szErrorMessage, MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "WritePackageHeader()")
                End Select
                Return -1
            End If


            dwResult = ReadPackageChunkHeader(szPackageName, szNewPackageName)

            If dwResult <> 0 Then
                Select Case dwResult
                    Case -1
                        MsgBox("Non ci sono Chunk compressi !", MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "ReadPackageChunkHeader()")
                    Case -2
                        MsgBox("Signature Chunk non valida !", MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "ReadPackageChunkHeader()")
                    Case -3
                        MsgBox(szErrorMessage, MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "ReadPackageChunkHeader()")
                End Select
                Return -1
            End If
        Else
            szNewPackageName = szPackageName
        End If

        dwResult = ReadTableNames(szNewPackageName)

        If dwResult <> 0 Then
            Select Case dwResult
                Case -1
                    MsgBox("dwNameCount = 0 !", MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "ReadTableNames()")
                Case -2
                    MsgBox(szErrorMessage, MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "ReadTableNames()")
            End Select
            Return -1
        End If

        dwResult = ReadTableExports(szNewPackageName)

        If dwResult <> 0 Then
            Select Case dwResult
                Case -1
                    MsgBox("dwExportCount = 0 !", MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "ReadTableExports()")
                Case -2
                    MsgBox(szErrorMessage, MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "ReadTableExports()")
            End Select
            Return -1
        End If

        dwResult = ReadTableImports(szNewPackageName)

        If dwResult <> 0 Then
            Select Case dwResult
                Case -1
                    MsgBox("dwImportCount = 0 !", MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "ReadTableImports()")
                Case -2
                    MsgBox(szErrorMessage, MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "ReadTableImports()")
            End Select
            Return -1
        End If

        dwResult = ReadTableFunctions(szNewPackageName)

        If dwResult <> 0 Then
            If dwResult = -3 Then
                MsgBox(szErrorMessage, MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "ReadTableFunctions()")
                Return -1
            End If
        End If

        dwResult = ReadTableConsts(szNewPackageName)

        If dwResult <> 0 Then
            If dwResult = -3 Then
                MsgBox(szErrorMessage, MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "ReadTableConsts()")
                Return -1
            End If
        End If

        dwResult = ReadTableEnums(szNewPackageName)

        If dwResult <> 0 Then
            If dwResult = -3 Then
                MsgBox(szErrorMessage, MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "ReadTableEnums()")
                Return -1
            End If
        End If

        dwResult = ReadTableClasses(szNewPackageName)

        If dwResult <> 0 Then
            If dwResult = -3 Then
                MsgBox(szErrorMessage, MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "ReadTableClasses()")
                Return -1
            End If
        End If

        dwResult = ReadTableScriptStruct(szNewPackageName)

        If dwResult <> 0 Then
            If dwResult = -3 Then
                MsgBox(szErrorMessage, MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "ReadTableScriptStruct()")
                Return -1
            End If
        End If

        dwResult = ReadTableProperties(szNewPackageName)

        If dwResult <> 0 Then
            If dwResult = -3 Then
                MsgBox(szErrorMessage, MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "ReadTableProperties()")
                Return -1
            End If
        End If

        dwResult = ReadTableStates(szNewPackageName)

        If dwResult <> 0 Then
            If dwResult = -3 Then
                MsgBox(szErrorMessage, MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "ReadTableStates()")
                Return -1
            End If
        End If

        Return 0

    End Function

    Function GetGameName() As Boolean

        If pUE3Header.dwPackageVersion = 421 Then
            pUE3Header.szGameName = "Medal of Honor Airborne"
        ElseIf pUE3Header.dwPackageVersion = 433 Then
            pUE3Header.szGameName = "Frontlines Fuel of War"
        ElseIf pUE3Header.dwPackageVersion = 512 Then
            pUE3Header.szGameName = "Unreal Tournament 3"
        ElseIf pUE3Header.dwPackageVersion = 576 Then
            If pUE3Header.dwEngineVersion = 4601 Then
                pUE3Header.szGameName = "Homefront"
            ElseIf pUE3Header.dwEngineVersion = 4701 Then
                pUE3Header.szGameName = "CrimeCraft GangWars"
            End If
        ElseIf pUE3Header.dwPackageVersion = 742 Then
            pUE3Header.szGameName = "Bulletstorm"
        ElseIf pUE3Header.dwPackageVersion = 765 Then
            pUE3Header.szGameName = "Rising Storm Red Orchestra 2"
        ElseIf pUE3Header.dwPackageVersion = 859 Then
            If pUE3Header.dwEngineVersion = 9641 Then
                pUE3Header.szGameName = "Ravaged Zombie Apocalypse"
            ElseIf pUE3Header.dwEngineVersion = 9641 Then
                pUE3Header.szGameName = "America's Army: Proving Grounds"
            End If
        ElseIf pUE3Header.dwPackageVersion = 860 Then
            pUE3Header.szGameName = "Outlast"
        End If

    End Function

    Function ReadPackageHeader(ByVal szFilePath As String) As Integer

        Try
            Dim dwIndex As Integer

            If Dir(szFilePath, FileAttribute.Normal) = "" Then
                Return -1
            End If

            Dim pCurrStream As System.IO.Stream = New System.IO.FileStream(szFilePath, System.IO.FileMode.Open, System.IO.FileAccess.Read, System.IO.FileShare.Read)
            Dim pCurrBinaryStream As New System.IO.BinaryReader(pCurrStream, System.Text.Encoding.ASCII)

            pUE3Header.dwSignature = pCurrBinaryStream.ReadInt32()

            If pUE3Header.dwSignature <> HEADER_MAGIC Then
                pCurrBinaryStream.Close()
                pCurrStream.Close()
                Return -2
            End If

            pUE3Header.dwPackageVersion = pCurrBinaryStream.ReadInt16()
            pUE3Header.dwLicenseeVersion = pCurrBinaryStream.ReadInt16()

            If pUE3Header.dwPackageVersion = 0 Then
                pUE3Header.bFullCompressed = True
                pCurrBinaryStream.Close()
                pCurrStream.Close()
                Return 0
            End If

            If pUE3Header.dwPackageVersion >= 249 Then
                pUE3Header.dwHeaderSize = pCurrBinaryStream.ReadInt32()
            End If

            If pUE3Header.dwPackageVersion >= 269 Then
                pUE3Header.dwFolderNameLenght = pCurrBinaryStream.ReadInt32()
                pUE3Header.szFolderName = pCurrBinaryStream.ReadBytes(pUE3Header.dwFolderNameLenght)
            End If

            pUE3Header.dwPackageFlag = pCurrBinaryStream.ReadInt32()
            pUE3Header.dwNameCount = pCurrBinaryStream.ReadInt32()
            pUE3Header.dwNameOffset = pCurrBinaryStream.ReadInt32()
            pUE3Header.dwExportCount = pCurrBinaryStream.ReadInt32()
            pUE3Header.dwExportOffset = pCurrBinaryStream.ReadInt32()
            pUE3Header.dwImportCount = pCurrBinaryStream.ReadInt32()
            pUE3Header.dwImportOffsert = pCurrBinaryStream.ReadInt32()

            If pUE3Header.dwPackageVersion >= 415 Then
                pUE3Header.dwDependsOffset = pCurrBinaryStream.ReadInt32()
            End If

            If pUE3Header.dwPackageVersion >= 584 Then
                pUE3Header.dwSerialOffset = pCurrBinaryStream.ReadInt32()
                pUE3Header.dwUnknownVar = pCurrBinaryStream.ReadBytes(UNKNOWN_VAR_LENGHT)
            End If

            If pUE3Header.dwPackageVersion >= 68 Then
                pUE3Header.dwGUID = pCurrBinaryStream.ReadBytes(GUID_VAR_LENGHT)
            End If

            If pUE3Header.dwPackageVersion >= 68 Then
                pUE3Header.dwFGenerationInfoCount = pCurrBinaryStream.ReadInt32()

                ReDim pUE3Header.pFGenerationInfo(pUE3Header.dwFGenerationInfoCount - 1)

                For dwIndex = 0 To pUE3Header.dwFGenerationInfoCount - 1
                    pUE3Header.pFGenerationInfo(dwIndex).dwExportCount = pCurrBinaryStream.ReadInt32()
                    pUE3Header.pFGenerationInfo(dwIndex).dwNameCount = pCurrBinaryStream.ReadInt32()
                    pUE3Header.pFGenerationInfo(dwIndex).dwNetObjectCount = pCurrBinaryStream.ReadInt32()
                Next dwIndex
            End If

            If pUE3Header.dwPackageVersion >= 245 Then
                pUE3Header.dwEngineVersion = pCurrBinaryStream.ReadInt32()
            End If

            GetGameName()

            If pUE3Header.dwPackageVersion >= 277 Then
                pUE3Header.dwCookerVersion = pCurrBinaryStream.ReadInt32()
            End If

            If pUE3Header.dwEngineVersion = 3240 Then
                pCurrBinaryStream.ReadBytes(UNKNOWN_ENGINE_VERSION_LENGHT)
            End If

            If pUE3Header.dwPackageVersion >= 334 Then
                pUE3Header.dwCompressionFlag = pCurrBinaryStream.ReadInt32()

                If pUE3Header.dwCompressionFlag <> 0 And pUE3Header.dwCompressionFlag <> PF_Compressed_LZO Then
                    pCurrBinaryStream.Close()
                    pCurrStream.Close()
                    Return -3
                End If
            End If

            If pUE3Header.dwCompressionFlag <> 0 Then
                If pUE3Header.dwPackageVersion >= 334 Then
                    pUE3Header.dwFCompressedChunkCount = pCurrBinaryStream.ReadInt32()

                    ReDim pUE3Header.pFCompressedChunk(pUE3Header.dwFCompressedChunkCount - 1)

                    For dwIndex = 0 To pUE3Header.dwFCompressedChunkCount - 1
                        pUE3Header.pFCompressedChunk(dwIndex).dwUncompressedOffset = pCurrBinaryStream.ReadInt32()
                        pUE3Header.pFCompressedChunk(dwIndex).dwUncompressedSize = pCurrBinaryStream.ReadInt32()
                        pUE3Header.pFCompressedChunk(dwIndex).dwCompressedOffset = pCurrBinaryStream.ReadInt32()
                        pUE3Header.pFCompressedChunk(dwIndex).dwCompressedSize = pCurrBinaryStream.ReadInt32()
                    Next dwIndex
                End If
            End If

            If pUE3Header.dwPackageVersion = 742 Then
                pCurrBinaryStream.ReadInt32()
            End If

            pUE3Header.dwEndOfSection = pCurrBinaryStream.BaseStream.Position

            If pUE3Header.dwFCompressedChunkCount > 0 Then
                ReDim pUE3Header.dwGapBytes(pUE3Header.pFCompressedChunk(0).dwCompressedOffset - pUE3Header.dwEndOfSection)

                pUE3Header.dwGapBytes = pCurrBinaryStream.ReadBytes(pUE3Header.pFCompressedChunk(0).dwCompressedOffset - pUE3Header.dwEndOfSection)
            End If

            pCurrBinaryStream.Close()
            pCurrStream.Close()

            Return 0
        Catch ex As Exception
            szErrorMessage = ex.Message
            Return -4
        End Try

    End Function

    Function WritePackageHeader(ByVal szFilePath As String) As Integer

        Try
            Dim pCurrStream As System.IO.Stream = New System.IO.FileStream(szFilePath, System.IO.FileMode.Create, System.IO.FileAccess.ReadWrite, System.IO.FileShare.ReadWrite)
            Dim pCurrBinaryStream As New System.IO.BinaryWriter(pCurrStream, System.Text.Encoding.ASCII)

            pCurrBinaryStream.Write(pUE3Header.dwSignature)
            pCurrBinaryStream.Write(pUE3Header.dwPackageVersion)
            pCurrBinaryStream.Write(pUE3Header.dwLicenseeVersion)

            If pUE3Header.dwPackageVersion >= 249 Then
                pCurrBinaryStream.Write(pUE3Header.dwHeaderSize)
            End If

            If pUE3Header.dwPackageVersion >= 269 Then
                pCurrBinaryStream.Write(pUE3Header.dwFolderNameLenght)
                pCurrBinaryStream.Write(pUE3Header.szFolderName)
            End If

            If pUE3Header.dwPackageFlag And PF_Compressed Then
                pCurrBinaryStream.Write(pUE3Header.dwPackageFlag - PF_Compressed)
            Else
                pCurrBinaryStream.Write(pUE3Header.dwPackageFlag)
            End If

            pCurrBinaryStream.Write(pUE3Header.dwNameCount)
            pCurrBinaryStream.Write(pUE3Header.dwNameOffset)
            pCurrBinaryStream.Write(pUE3Header.dwExportCount)
            pCurrBinaryStream.Write(pUE3Header.dwExportOffset)
            pCurrBinaryStream.Write(pUE3Header.dwImportCount)
            pCurrBinaryStream.Write(pUE3Header.dwImportOffsert)

            If pUE3Header.dwPackageVersion >= 415 Then
                pCurrBinaryStream.Write(pUE3Header.dwDependsOffset)
            End If

            If pUE3Header.dwPackageVersion >= 584 Then
                pCurrBinaryStream.Write(pUE3Header.dwSerialOffset)
                pCurrBinaryStream.Write(pUE3Header.dwUnknownVar)
            End If

            If pUE3Header.dwPackageVersion >= 68 Then
                pCurrBinaryStream.Write(pUE3Header.dwGUID)
            End If

            If pUE3Header.dwPackageVersion >= 68 Then
                pCurrBinaryStream.Write(pUE3Header.dwFGenerationInfoCount)

                For dwIndex = 0 To pUE3Header.dwFGenerationInfoCount - 1
                    pCurrBinaryStream.Write(pUE3Header.pFGenerationInfo(dwIndex).dwExportCount)
                    pCurrBinaryStream.Write(pUE3Header.pFGenerationInfo(dwIndex).dwNameCount)
                    pCurrBinaryStream.Write(pUE3Header.pFGenerationInfo(dwIndex).dwNetObjectCount)
                Next dwIndex
            End If

            If pUE3Header.dwPackageVersion >= 245 Then
                pCurrBinaryStream.Write(pUE3Header.dwEngineVersion)
            End If

            If pUE3Header.dwEngineVersion = 3240 Then
                pCurrBinaryStream.Write(UNKNOWN_ENGINE_VERSION_LENGHT)
            End If

            If pUE3Header.dwPackageVersion >= 277 Then
                pCurrBinaryStream.Write(pUE3Header.dwCookerVersion)
            End If

            If pUE3Header.dwPackageVersion >= 334 Then
                If pUE3Header.dwCompressionFlag = 0 Then
                    pCurrBinaryStream.Write(0)
                Else
                    pCurrBinaryStream.Write(pUE3Header.dwCompressionFlag Mod PF_Compressed_LZO)
                End If
            End If

            pCurrBinaryStream.Write(0)

            If Not pUE3Header.dwGapBytes Is Nothing Then
                pCurrBinaryStream.Write(pUE3Header.dwGapBytes)
            End If

            pCurrBinaryStream.Close()
            pCurrStream.Close()

            Return 0
        Catch ex As Exception
            szErrorMessage = ex.Message
            Return -1
        End Try

    End Function

    Function ReadPackageChunkHeader(ByVal szFilePath As String, ByVal szNewFilePath As String) As Integer

        Try
            Dim dwIndex As Integer
            Dim dwIndexBlock As Integer
            Dim dwBlockCount As Integer
            Dim dwBlockStart As Integer
            Dim pCompressedData() As Byte
            Dim pUnCompressedData() As Byte

            If pUE3Header.pFCompressedChunk.Length = 0 Then
                Return -1
            End If

            Dim pCurrStream As System.IO.Stream = New System.IO.FileStream(szFilePath, System.IO.FileMode.Open, System.IO.FileAccess.Read, System.IO.FileShare.Read)
            Dim pCurrBinaryStream As New System.IO.BinaryReader(pCurrStream, System.Text.Encoding.ASCII)

            For dwIndex = 0 To pUE3Header.pFCompressedChunk.Length - 1
                pCurrBinaryStream.BaseStream.Position = pUE3Header.pFCompressedChunk(dwIndex).dwCompressedOffset

                pFCompressedChunkHeader.dwSignature = pCurrBinaryStream.ReadInt32()

                If pFCompressedChunkHeader.dwSignature <> HEADER_MAGIC Then
                    pCurrBinaryStream.Close()
                    pCurrStream.Close()
                    Return -2
                End If

                pFCompressedChunkHeader.dwBlockSize = pCurrBinaryStream.ReadInt32()
                pFCompressedChunkHeader.dwCompressedSize = pCurrBinaryStream.ReadInt32()
                pFCompressedChunkHeader.dwUncompressedSize = pCurrBinaryStream.ReadInt32()

                If pFCompressedChunkHeader.dwUncompressedSize Mod pFCompressedChunkHeader.dwBlockSize = 0 Then
                    dwBlockCount = Fix(pFCompressedChunkHeader.dwUncompressedSize / pFCompressedChunkHeader.dwBlockSize)
                Else
                    dwBlockCount = Fix(pFCompressedChunkHeader.dwUncompressedSize / pFCompressedChunkHeader.dwBlockSize) + 1
                End If

                dwBlockStart = pCurrBinaryStream.BaseStream.Position + (dwBlockCount * 8)

                pFCompressedChunkHeader.pFCompressdChunkHeaderBlock = Nothing

                ReDim pFCompressedChunkHeader.pFCompressdChunkHeaderBlock(dwBlockCount - 1)

                For dwIndexBlock = 0 To dwBlockCount - 1
                    pFCompressedChunkHeader.pFCompressdChunkHeaderBlock(dwIndexBlock).dwCompressedSize = pCurrBinaryStream.ReadInt32()
                    pFCompressedChunkHeader.pFCompressdChunkHeaderBlock(dwIndexBlock).dwUncompressedSize = pCurrBinaryStream.ReadInt32()

                    ReDim pCompressedData(pFCompressedChunkHeader.pFCompressdChunkHeaderBlock(dwIndexBlock).dwCompressedSize - 1)
                    ReDim pUnCompressedData(pFCompressedChunkHeader.pFCompressdChunkHeaderBlock(dwIndexBlock).dwUncompressedSize - 1)

                    Dim pTempCurrStream As System.IO.Stream = New System.IO.FileStream(szFilePath, System.IO.FileMode.Open, System.IO.FileAccess.Read, System.IO.FileShare.Read)
                    Dim pTempCurrBinaryStream As New System.IO.BinaryReader(pTempCurrStream, System.Text.Encoding.ASCII)

                    pTempCurrBinaryStream.BaseStream.Position = dwBlockStart
                    pTempCurrBinaryStream.BaseStream.Read(pCompressedData, 0, pFCompressedChunkHeader.pFCompressdChunkHeaderBlock(dwIndexBlock).dwCompressedSize)

                    ManagedLZO.MiniLZO.Decompress(pCompressedData, pUnCompressedData)

                    Dim pCurrStreamWrite As System.IO.Stream = New System.IO.FileStream(szNewFilePath, System.IO.FileMode.Open, System.IO.FileAccess.ReadWrite, System.IO.FileShare.ReadWrite)
                    Dim pCurrBinaryStreamWrite As New System.IO.BinaryWriter(pCurrStreamWrite, System.Text.Encoding.ASCII)

                    pCurrBinaryStreamWrite.BaseStream.Seek(0, IO.SeekOrigin.End)
                    pCurrBinaryStreamWrite.Write(pUnCompressedData)

                    pCurrBinaryStreamWrite.Close()
                    pCurrStreamWrite.Close()

                    pTempCurrBinaryStream.Close()
                    pTempCurrStream.Close()

                    pCompressedData = Nothing
                    pUnCompressedData = Nothing

                    dwBlockStart += pFCompressedChunkHeader.pFCompressdChunkHeaderBlock(dwIndexBlock).dwCompressedSize
                Next
            Next dwIndex

            pCurrBinaryStream.Close()
            pCurrStream.Close()

            Return 0
        Catch ex As Exception
            szErrorMessage = ex.Message
            Return -3
        End Try

    End Function

    Function DecompressFullCompression(szFilePath As String, szNewFilePath As String) As Integer

        Try
            Dim dwBlockCount As Integer
            Dim dwBlockStart As Integer
            Dim pCompressedData() As Byte
            Dim pUnCompressedData() As Byte
            Dim pFCompressedChunkHeader As FCompressedChunkHeader

            Dim pCurrStreamCreate As System.IO.Stream = New System.IO.FileStream(szNewFilePath, System.IO.FileMode.Create, System.IO.FileAccess.ReadWrite, System.IO.FileShare.ReadWrite)
            pCurrStreamCreate.Close()

            Dim pCurrStream As System.IO.Stream = New System.IO.FileStream(szFilePath, System.IO.FileMode.Open, System.IO.FileAccess.Read, System.IO.FileShare.Read)
            Dim pCurrBinaryStream As New System.IO.BinaryReader(pCurrStream, System.Text.Encoding.ASCII)

            pFCompressedChunkHeader.dwSignature = pCurrBinaryStream.ReadInt32()

            If pFCompressedChunkHeader.dwSignature <> HEADER_MAGIC Then
                pCurrBinaryStream.Close()
                pCurrStream.Close()
                Return -1
            End If

            pFCompressedChunkHeader.dwBlockSize = pCurrBinaryStream.ReadInt32()
            pFCompressedChunkHeader.dwCompressedSize = pCurrBinaryStream.ReadInt32()
            pFCompressedChunkHeader.dwUncompressedSize = pCurrBinaryStream.ReadInt32()

            If pFCompressedChunkHeader.dwUncompressedSize Mod pFCompressedChunkHeader.dwBlockSize = 0 Then
                dwBlockCount = Fix(pFCompressedChunkHeader.dwUncompressedSize / pFCompressedChunkHeader.dwBlockSize)
            Else
                dwBlockCount = Fix(pFCompressedChunkHeader.dwUncompressedSize / pFCompressedChunkHeader.dwBlockSize) + 1
            End If

            dwBlockStart = pCurrBinaryStream.BaseStream.Position + (dwBlockCount * 8)

            pFCompressedChunkHeader.pFCompressdChunkHeaderBlock = Nothing

            ReDim pFCompressedChunkHeader.pFCompressdChunkHeaderBlock(dwBlockCount - 1)

            For dwIndexBlock = 0 To dwBlockCount - 1
                pFCompressedChunkHeader.pFCompressdChunkHeaderBlock(dwIndexBlock).dwCompressedSize = pCurrBinaryStream.ReadInt32()
                pFCompressedChunkHeader.pFCompressdChunkHeaderBlock(dwIndexBlock).dwUncompressedSize = pCurrBinaryStream.ReadInt32()

                ReDim pCompressedData(pFCompressedChunkHeader.pFCompressdChunkHeaderBlock(dwIndexBlock).dwCompressedSize - 1)
                ReDim pUnCompressedData(pFCompressedChunkHeader.pFCompressdChunkHeaderBlock(dwIndexBlock).dwUncompressedSize - 1)

                Dim pTempCurrStream As System.IO.Stream = New System.IO.FileStream(szFilePath, System.IO.FileMode.Open, System.IO.FileAccess.Read, System.IO.FileShare.Read)
                Dim pTempCurrBinaryStream As New System.IO.BinaryReader(pTempCurrStream, System.Text.Encoding.ASCII)

                pTempCurrBinaryStream.BaseStream.Position = dwBlockStart
                pTempCurrBinaryStream.BaseStream.Read(pCompressedData, 0, pFCompressedChunkHeader.pFCompressdChunkHeaderBlock(dwIndexBlock).dwCompressedSize)

                ManagedLZO.MiniLZO.Decompress(pCompressedData, pUnCompressedData)

                Dim pCurrStreamWrite As System.IO.Stream = New System.IO.FileStream(szNewFilePath, System.IO.FileMode.Open, System.IO.FileAccess.ReadWrite, System.IO.FileShare.ReadWrite)
                Dim pCurrBinaryStreamWrite As New System.IO.BinaryWriter(pCurrStreamWrite, System.Text.Encoding.ASCII)

                pCurrBinaryStreamWrite.BaseStream.Seek(0, IO.SeekOrigin.End)
                pCurrBinaryStreamWrite.Write(pUnCompressedData)

                pCurrBinaryStreamWrite.Close()
                pCurrStreamWrite.Close()

                pTempCurrBinaryStream.Close()
                pTempCurrStream.Close()

                pCompressedData = Nothing
                pUnCompressedData = Nothing

                dwBlockStart += pFCompressedChunkHeader.pFCompressdChunkHeaderBlock(dwIndexBlock).dwCompressedSize
            Next

            pCurrBinaryStream.Close()
            pCurrStream.Close()

            Return 0
        Catch ex As Exception
            szErrorMessage = ex.Message
            Return -2
        End Try

    End Function

    Function ReadTableNames(ByVal szFilePath As String) As Integer

        Try
            Dim dwIndex As Integer
            Dim dwNameLenght As Int32
            Dim dwNamesByte() As Byte

            If pUE3Header.dwNameCount = 0 Then
                Return -1
            End If

            Dim pCurrStream As System.IO.Stream = New System.IO.FileStream(szFilePath, System.IO.FileMode.Open, System.IO.FileAccess.Read, System.IO.FileShare.Read)
            Dim pCurrBinaryStream As New System.IO.BinaryReader(pCurrStream, System.Text.Encoding.ASCII)

            ReDim pUE3TablesNames(pUE3Header.dwNameCount - 1)

            pCurrBinaryStream.BaseStream.Position = pUE3Header.dwNameOffset

            For dwIndex = 0 To pUE3Header.dwNameCount - 1
                dwNameLenght = pCurrBinaryStream.ReadInt32()

                ReDim dwNamesByte(dwNameLenght - 1)

                dwNamesByte = pCurrBinaryStream.ReadBytes(dwNameLenght)

                pUE3TablesNames(dwIndex).szName = Left(System.Text.Encoding.ASCII.GetString(dwNamesByte), dwNamesByte.Length - 1)
                pUE3TablesNames(dwIndex).dwFlag.dwHighFlag = pCurrBinaryStream.ReadInt32()
                pUE3TablesNames(dwIndex).dwFlag.dwLowFlag = pCurrBinaryStream.ReadInt32()

                dwNamesByte = Nothing
            Next dwIndex

            pCurrBinaryStream.Close()
            pCurrStream.Close()

            Return 0
        Catch ex As Exception
            szErrorMessage = ex.Message
            Return -2
        End Try

    End Function

    Function ReadTableExports(ByVal szFilePath As String) As Integer

        Try
            Dim dwIndex As Integer
            Dim dwTempIndex As Integer

            If pUE3Header.dwExportCount = 0 Then
                Return -1
            End If

            Dim pCurrStream As System.IO.Stream = New System.IO.FileStream(szFilePath, System.IO.FileMode.Open, System.IO.FileAccess.Read, System.IO.FileShare.Read)
            Dim pCurrBinaryStream As New System.IO.BinaryReader(pCurrStream, System.Text.Encoding.ASCII)

            ReDim pUE3TablesExports(pUE3Header.dwExportCount - 1)

            pCurrBinaryStream.BaseStream.Position = pUE3Header.dwExportOffset

            For dwIndex = 0 To pUE3Header.dwExportCount - 1
                pUE3TablesExports(dwIndex).dwClassObject = pCurrBinaryStream.ReadInt32()
                pUE3TablesExports(dwIndex).dwSuperObject = pCurrBinaryStream.ReadInt32()
                pUE3TablesExports(dwIndex).dwOuterObject = pCurrBinaryStream.ReadInt32()
                pUE3TablesExports(dwIndex).pObjectName.dwIndex = pCurrBinaryStream.ReadInt32()
                pUE3TablesExports(dwIndex).pObjectName.dwNumber = pCurrBinaryStream.ReadInt32()
                pUE3TablesExports(dwIndex).dwArchetypeObject = pCurrBinaryStream.ReadInt32()
                pUE3TablesExports(dwIndex).pObjectFlags.dwHighFlag = pCurrBinaryStream.ReadInt32()
                pUE3TablesExports(dwIndex).pObjectFlags.dwLowFlag = pCurrBinaryStream.ReadInt32()
                pUE3TablesExports(dwIndex).dwSerialSize = pCurrBinaryStream.ReadInt32()
                pUE3TablesExports(dwIndex).dwSerialOffset = pCurrBinaryStream.ReadInt32()

                If pUE3Header.dwPackageVersion = 512 Then
                    pCurrBinaryStream.ReadInt32()
                End If

                pUE3TablesExports(dwIndex).dwExportFlags = pCurrBinaryStream.ReadInt32()
                pUE3TablesExports(dwIndex).dwNetObjectsCount = pCurrBinaryStream.ReadInt32()

                ReDim pUE3TablesExports(dwIndex).dwPackageGUID(GUID_VAR_LENGHT - 1)

                pUE3TablesExports(dwIndex).dwPackageGUID = pCurrBinaryStream.ReadBytes(GUID_VAR_LENGHT)
                pUE3TablesExports(dwIndex).dwUnknown000 = pCurrBinaryStream.ReadInt32()

                If pUE3TablesExports(dwIndex).dwNetObjectsCount > 0 Then
                    ReDim pUE3TablesExports(dwIndex).pNetObjects(pUE3TablesExports(dwIndex).dwNetObjectsCount - 1)

                    For dwTempIndex = 0 To pUE3TablesExports(dwIndex).dwNetObjectsCount - 1
                        pUE3TablesExports(dwIndex).pNetObjects(dwTempIndex).dwNetObject = pCurrBinaryStream.ReadInt32()
                    Next dwTempIndex
                End If

            Next dwIndex

            pCurrBinaryStream.Close()
            pCurrStream.Close()

            Return 0
        Catch ex As Exception
            szErrorMessage = ex.Message
            Return -2
        End Try

    End Function

    Function ReadTableImports(ByVal szFilePath As String) As Integer

        Try
            Dim dwIndex As Integer

            If pUE3Header.dwImportCount = 0 Then
                Return -1
            End If

            Dim pCurrStream As System.IO.Stream = New System.IO.FileStream(szFilePath, System.IO.FileMode.Open, System.IO.FileAccess.Read, System.IO.FileShare.Read)
            Dim pCurrBinaryStream As New System.IO.BinaryReader(pCurrStream, System.Text.Encoding.ASCII)

            ReDim pUE3TablesImports(pUE3Header.dwImportCount - 1)

            pCurrBinaryStream.BaseStream.Position = pUE3Header.dwImportOffsert

            For dwIndex = 0 To pUE3Header.dwImportCount - 1
                pUE3TablesImports(dwIndex).pPackageName.dwIndex = pCurrBinaryStream.ReadInt32()
                pUE3TablesImports(dwIndex).pPackageName.dwNumber = pCurrBinaryStream.ReadInt32()
                pUE3TablesImports(dwIndex).pClassName.dwIndex = pCurrBinaryStream.ReadInt32()
                pUE3TablesImports(dwIndex).pClassName.dwNumber = pCurrBinaryStream.ReadInt32()
                pUE3TablesImports(dwIndex).dwOuterObject = pCurrBinaryStream.ReadInt32()
                pUE3TablesImports(dwIndex).pObjectName.dwIndex = pCurrBinaryStream.ReadInt32()
                pUE3TablesImports(dwIndex).pObjectName.dwNumber = pCurrBinaryStream.ReadInt32()
            Next dwIndex

            pCurrBinaryStream.Close()
            pCurrStream.Close()

            Return 0
        Catch ex As Exception
            szErrorMessage = ex.Message
            Return -2
        End Try

    End Function

    Function DefaultProperty(ByVal pCurrBinaryStream As System.IO.BinaryReader, ByVal dwIndex As Integer) As Boolean

        Dim dwCurrIndex As Int32 = pCurrBinaryStream.ReadInt32()
        Dim dwCurrNumber As Int32 = pCurrBinaryStream.ReadInt32()

        If pUE3TablesNames(dwCurrIndex).szName = "None" Then
            Return False
        Else
            Return True
        End If

    End Function

    Function GetObjectType(ByVal dwClassObject As Int32, ByVal szObjectTypeName As String) As Integer

        Try
            Dim dwTempIndex As Int32

            If dwClassObject > 0 Then
                dwTempIndex = dwClassObject - 1

                If pUE3TablesNames(pUE3TablesExports(dwTempIndex).pObjectName.dwIndex).szName = szObjectTypeName Then
                    Return 0
                Else
                    Return -1
                End If
            ElseIf dwClassObject < 0 Then
                dwTempIndex = -dwClassObject - 1

                If pUE3TablesNames(pUE3TablesImports(dwTempIndex).pObjectName.dwIndex).szName = szObjectTypeName Then
                    Return 0
                Else
                    Return -1
                End If
            Else
                If szObjectTypeName = "Class" Then
                    Return 0
                Else
                    Return -1
                End If
            End If

            Return -1
        Catch ex As Exception
            Return -2
        End Try

    End Function

    Function IsPropertyType(ByVal dwClassObject As Int32) As Integer

        Try
            Dim dwTempIndex As Int32

            If dwClassObject > 0 Then
                dwTempIndex = dwClassObject - 1

                If Right(pUE3TablesNames(pUE3TablesExports(dwTempIndex).pObjectName.dwIndex).szName, 8) = "Property" Then
                    Return 0
                Else
                    Return -1
                End If
            ElseIf dwClassObject < 0 Then
                dwTempIndex = -dwClassObject - 1

                If Right(pUE3TablesNames(pUE3TablesImports(dwTempIndex).pObjectName.dwIndex).szName, 8) = "Property" Then
                    Return 0
                Else
                    Return -1
                End If
            Else
                Return -1
            End If

            Return -1
        Catch ex As Exception
            Return -2
        End Try

    End Function

    Function ReadTableFunctions(ByVal szFilePath As String) As Integer

        Try
            Dim dwIndex As Integer
            Dim dwCount As Integer
            Dim dwCountDefaultProperties As Integer
            Dim dwBaseStreamOldPosition As Integer
            Dim pTempDefaultProperties As UE3_TABLE_UDEFAULTPROPERTIES

            If pUE3TablesExports.Length = 0 Then
                Return -1
            End If

            dwCount = 0

            For dwIndex = 0 To pUE3TablesExports.Length - 1
                If GetObjectType(pUE3TablesExports(dwIndex).dwClassObject, "Function") = 0 Then
                    dwCount += 1
                End If
            Next dwIndex

            If dwCount = 0 Then
                Return -2
            End If

            ReDim pUE3TablesFunctions(dwCount - 1)

            Dim pCurrStream As System.IO.Stream = New System.IO.FileStream(szFilePath, System.IO.FileMode.Open, System.IO.FileAccess.Read, System.IO.FileShare.Read)
            Dim pCurrBinaryStream As New System.IO.BinaryReader(pCurrStream, System.Text.Encoding.ASCII)

            dwCount = 0

            For dwIndex = 0 To pUE3TablesExports.Length - 1
                If GetObjectType(pUE3TablesExports(dwIndex).dwClassObject, "Function") = 0 Then
                    pCurrBinaryStream.BaseStream.Position = pUE3TablesExports(dwIndex).dwSerialOffset

                    pUE3TablesFunctions(dwCount).dwExportIndex = dwIndex
                    pUE3TablesFunctions(dwCount).dwNextObjectIndex = pCurrBinaryStream.ReadInt32()

                    If pUE3TablesExports(dwIndex).pObjectFlags.dwLowFlag And OF_L_HasStack Then
                        pCurrBinaryStream.ReadBytes(UNKNOWN_OBJECT_STACK_LENGHT)
                    End If

                    If DefaultProperty(pCurrBinaryStream, dwCount) Then
                        pCurrBinaryStream.BaseStream.Position -= 8

                        dwBaseStreamOldPosition = pCurrBinaryStream.BaseStream.Position
                        dwCountDefaultProperties = 0

                        pTempDefaultProperties.pNameIdx.dwIndex = pCurrBinaryStream.ReadInt32()
                        pTempDefaultProperties.pNameIdx.dwNumber = pCurrBinaryStream.ReadInt32()

                        While pUE3TablesNames(pTempDefaultProperties.pNameIdx.dwIndex).szName <> "None"

                            pTempDefaultProperties.pTypeIdx.dwIndex = pCurrBinaryStream.ReadInt32()
                            pTempDefaultProperties.pTypeIdx.dwNumber = pCurrBinaryStream.ReadInt32()
                            pTempDefaultProperties.dwPropertySize = pCurrBinaryStream.ReadInt32()
                            pTempDefaultProperties.dwArrayIdx = pCurrBinaryStream.ReadInt32()

                            If pUE3TablesNames(pTempDefaultProperties.pTypeIdx.dwIndex).szName = "BoolProperty" Then
                                If pUE3Header.dwPackageVersion = 433 Or pUE3Header.dwPackageVersion = 576 Then
                                    pTempDefaultProperties.dwBoolValue = pCurrBinaryStream.ReadInt32()
                                Else
                                    pTempDefaultProperties.dwBoolValue = pCurrBinaryStream.ReadByte()
                                End If
                            End If

                            If pUE3Header.dwPackageVersion = 512 Or pUE3Header.dwPackageVersion = 576 Then
                                If pUE3TablesNames(pTempDefaultProperties.pTypeIdx.dwIndex).szName = "StructProperty" Then
                                    pTempDefaultProperties.pInnerNameIdx.dwIndex = pCurrBinaryStream.ReadInt32()
                                    pTempDefaultProperties.pInnerNameIdx.dwNumber = pCurrBinaryStream.ReadInt32()
                                End If
                            Else
                                If pUE3TablesNames(pTempDefaultProperties.pTypeIdx.dwIndex).szName = "StructProperty" Or _
                                    pUE3TablesNames(pTempDefaultProperties.pTypeIdx.dwIndex).szName = "ByteProperty" Then
                                    pTempDefaultProperties.pInnerNameIdx.dwIndex = pCurrBinaryStream.ReadInt32()
                                    pTempDefaultProperties.pInnerNameIdx.dwNumber = pCurrBinaryStream.ReadInt32()
                                End If
                            End If

                            If pTempDefaultProperties.dwPropertySize > 0 Then
                                ReDim pTempDefaultProperties.pInnerValue(pTempDefaultProperties.dwPropertySize - 1)
                                pTempDefaultProperties.pInnerValue = pCurrBinaryStream.ReadBytes(pTempDefaultProperties.dwPropertySize)
                            End If

                            pTempDefaultProperties.pNameIdx.dwIndex = pCurrBinaryStream.ReadInt32()
                            pTempDefaultProperties.pNameIdx.dwNumber = pCurrBinaryStream.ReadInt32()

                            dwCountDefaultProperties += 1
                        End While

                        pTempDefaultProperties = Nothing
                        pCurrBinaryStream.BaseStream.Position = dwBaseStreamOldPosition

                        ReDim pUE3TablesFunctions(dwCount).pUObjectDefaultProperties(dwCountDefaultProperties - 1)

                        For dwTempIndex = 0 To pUE3TablesFunctions(dwCount).pUObjectDefaultProperties.Length - 1
                            pUE3TablesFunctions(dwCount).pUObjectDefaultProperties(dwTempIndex).pNameIdx.dwIndex = pCurrBinaryStream.ReadInt32()
                            pUE3TablesFunctions(dwCount).pUObjectDefaultProperties(dwTempIndex).pNameIdx.dwNumber = pCurrBinaryStream.ReadInt32()

                            If pUE3TablesNames(pUE3TablesFunctions(dwCount).pUObjectDefaultProperties(dwTempIndex).pNameIdx.dwIndex).szName <> "None" Then
                                pUE3TablesFunctions(dwCount).pUObjectDefaultProperties(dwTempIndex).pTypeIdx.dwIndex = pCurrBinaryStream.ReadInt32()
                                pUE3TablesFunctions(dwCount).pUObjectDefaultProperties(dwTempIndex).pTypeIdx.dwNumber = pCurrBinaryStream.ReadInt32()
                                pUE3TablesFunctions(dwCount).pUObjectDefaultProperties(dwTempIndex).dwPropertySize = pCurrBinaryStream.ReadInt32()
                                pUE3TablesFunctions(dwCount).pUObjectDefaultProperties(dwTempIndex).dwArrayIdx = pCurrBinaryStream.ReadInt32()

                                If pUE3TablesNames(pUE3TablesFunctions(dwCount).pUObjectDefaultProperties(dwTempIndex).pTypeIdx.dwIndex).szName = "BoolProperty" Then
                                    If pUE3Header.dwPackageVersion = 433 Or pUE3Header.dwPackageVersion = 576 Then
                                        pUE3TablesFunctions(dwCount).pUObjectDefaultProperties(dwTempIndex).dwBoolValue = pCurrBinaryStream.ReadInt32()
                                    Else
                                        pUE3TablesFunctions(dwCount).pUObjectDefaultProperties(dwTempIndex).dwBoolValue = pCurrBinaryStream.ReadByte()
                                    End If
                                End If

                                If pUE3Header.dwPackageVersion = 512 Or pUE3Header.dwPackageVersion = 576 Then
                                    If pUE3TablesNames(pUE3TablesFunctions(dwCount).pUObjectDefaultProperties(dwTempIndex).pTypeIdx.dwIndex).szName = "StructProperty" Then
                                        pUE3TablesFunctions(dwCount).pUObjectDefaultProperties(dwTempIndex).pInnerNameIdx.dwIndex = pCurrBinaryStream.ReadInt32()
                                        pUE3TablesFunctions(dwCount).pUObjectDefaultProperties(dwTempIndex).pInnerNameIdx.dwNumber = pCurrBinaryStream.ReadInt32()
                                    End If
                                Else
                                    If pUE3TablesNames(pUE3TablesFunctions(dwCount).pUObjectDefaultProperties(dwTempIndex).pTypeIdx.dwIndex).szName = "StructProperty" Or _
                                        pUE3TablesNames(pUE3TablesFunctions(dwCount).pUObjectDefaultProperties(dwTempIndex).pTypeIdx.dwIndex).szName = "ByteProperty" Then
                                        pUE3TablesFunctions(dwCount).pUObjectDefaultProperties(dwTempIndex).pInnerNameIdx.dwIndex = pCurrBinaryStream.ReadInt32()
                                        pUE3TablesFunctions(dwCount).pUObjectDefaultProperties(dwTempIndex).pInnerNameIdx.dwNumber = pCurrBinaryStream.ReadInt32()
                                    End If
                                End If

                                If pUE3TablesFunctions(dwCount).pUObjectDefaultProperties(dwTempIndex).dwPropertySize > 0 Then
                                    ReDim pUE3TablesFunctions(dwCount).pUObjectDefaultProperties(dwTempIndex).pInnerValue(pUE3TablesFunctions(dwCount).pUObjectDefaultProperties(dwTempIndex).dwPropertySize - 1)

                                    pUE3TablesFunctions(dwCount).pUObjectDefaultProperties(dwTempIndex).pInnerValue = pCurrBinaryStream.ReadBytes(pUE3TablesFunctions(dwCount).pUObjectDefaultProperties(dwTempIndex).dwPropertySize)
                                End If
                            Else
                                Exit For
                            End If

                        Next dwTempIndex
                    End If

                    If pUE3Header.dwPackageVersion = 421 Or pUE3Header.dwPackageVersion = 433 Or _
                        pUE3Header.dwPackageVersion = 512 Or pUE3Header.dwPackageVersion = 576 Or _
                        pUE3Header.dwPackageVersion = 742 Then
                        pUE3TablesFunctions(dwCount).dwParentField = pCurrBinaryStream.ReadInt32()
                        pUE3TablesFunctions(dwCount).dwNextField = pCurrBinaryStream.ReadInt32()
                    Else
                        pUE3TablesFunctions(dwCount).dwNextField = pCurrBinaryStream.ReadInt32()
                        pUE3TablesFunctions(dwCount).dwParentField = pCurrBinaryStream.ReadInt32()
                    End If

                    pUE3TablesFunctions(dwCount).dwScriptText = pCurrBinaryStream.ReadInt32()
                    pUE3TablesFunctions(dwCount).dwChildren = pCurrBinaryStream.ReadInt32()
                    pUE3TablesFunctions(dwCount).dwCppText = pCurrBinaryStream.ReadInt32()
                    pUE3TablesFunctions(dwCount).dwLine = pCurrBinaryStream.ReadInt32()
                    pUE3TablesFunctions(dwCount).dwTextPos = pCurrBinaryStream.ReadInt32()
                    pUE3TablesFunctions(dwCount).dwByteScriptSize = pCurrBinaryStream.ReadInt32()

                    If pUE3Header.dwPackageVersion = 421 Or pUE3Header.dwPackageVersion = 433 Or _
                        pUE3Header.dwPackageVersion = 512 Or pUE3Header.dwPackageVersion = 576 Then
                        If pUE3TablesFunctions(dwCount).dwByteScriptSize > 0 Then
                            ReDim pUE3TablesFunctions(dwCount).dwByteScript(pUE3TablesFunctions(dwCount).dwByteScriptSize - 1)

                            pUE3TablesFunctions(dwCount).dwByteScript = pCurrBinaryStream.ReadBytes(pUE3TablesFunctions(dwCount).dwByteScriptSize)

                            pUE3TablesFunctions(dwCount).dwByteScriptStartPosition = pCurrBinaryStream.BaseStream.Position - pUE3TablesFunctions(dwCount).dwByteScriptSize
                            pUE3TablesFunctions(dwCount).dwByteScriptEndPosition = pCurrBinaryStream.BaseStream.Position
                        End If
                    Else
                        pUE3TablesFunctions(dwCount).dwDataScriptSize = pCurrBinaryStream.ReadInt32()

                        If pUE3TablesFunctions(dwCount).dwDataScriptSize > 0 Then
                            ReDim pUE3TablesFunctions(dwCount).dwByteScript(pUE3TablesFunctions(dwCount).dwDataScriptSize - 1)

                            pUE3TablesFunctions(dwCount).dwByteScript = pCurrBinaryStream.ReadBytes(pUE3TablesFunctions(dwCount).dwDataScriptSize)

                            pUE3TablesFunctions(dwCount).dwByteScriptStartPosition = pCurrBinaryStream.BaseStream.Position - pUE3TablesFunctions(dwCount).dwDataScriptSize
                            pUE3TablesFunctions(dwCount).dwByteScriptEndPosition = pCurrBinaryStream.BaseStream.Position
                        End If
                    End If

                    pUE3TablesFunctions(dwCount).dwNativeTokenIndex = pCurrBinaryStream.ReadInt16()
                    pUE3TablesFunctions(dwCount).dwOperPrecedence = pCurrBinaryStream.ReadByte()
                    pUE3TablesFunctions(dwCount).dwFunctionFlags = pCurrBinaryStream.ReadInt32()

                    If pUE3TablesFunctions(dwCount).dwFunctionFlags And FF_Net Then
                        pUE3TablesFunctions(dwCount).dwRepOffset = pCurrBinaryStream.ReadInt16()
                    End If

                    pUE3TablesFunctions(dwCount).pFriendlyName.dwIndex = pCurrBinaryStream.ReadInt32()
                    pUE3TablesFunctions(dwCount).pFriendlyName.dwNumber = pCurrBinaryStream.ReadInt32()

                    dwCount += 1
                End If
            Next dwIndex

            pCurrBinaryStream.Close()
            pCurrStream.Close()

            Return 0
        Catch ex As Exception
            szErrorMessage = ex.Message
            Return -3
        End Try

    End Function

    Function ReadTableConsts(ByVal szFilePath As String) As Integer

        Try
            Dim dwIndex As Integer
            Dim dwCount As Integer
            Dim dwCountDefaultProperties As Integer
            Dim dwBaseStreamOldPosition As Integer
            Dim pTempDefaultProperties As UE3_TABLE_UDEFAULTPROPERTIES

            If pUE3TablesExports.Length = 0 Then
                Return -1
            End If

            dwCount = 0

            For dwIndex = 0 To pUE3TablesExports.Length - 1
                If GetObjectType(pUE3TablesExports(dwIndex).dwClassObject, "Const") = 0 Then
                    dwCount += 1
                End If
            Next dwIndex

            If dwCount = 0 Then
                Return -2
            End If

            ReDim pUE3TablesConsts(dwCount - 1)

            Dim pCurrStream As System.IO.Stream = New System.IO.FileStream(szFilePath, System.IO.FileMode.Open, System.IO.FileAccess.Read, System.IO.FileShare.Read)
            Dim pCurrBinaryStream As New System.IO.BinaryReader(pCurrStream, System.Text.Encoding.ASCII)

            dwCount = 0

            For dwIndex = 0 To pUE3TablesExports.Length - 1
                If GetObjectType(pUE3TablesExports(dwIndex).dwClassObject, "Const") = 0 Then
                    pCurrBinaryStream.BaseStream.Position = pUE3TablesExports(dwIndex).dwSerialOffset

                    pUE3TablesConsts(dwCount).dwExportIndex = dwIndex
                    pUE3TablesConsts(dwCount).dwNextObjectIndex = pCurrBinaryStream.ReadInt32()

                    If pUE3TablesExports(dwIndex).pObjectFlags.dwLowFlag And OF_L_HasStack Then
                        pCurrBinaryStream.ReadBytes(UNKNOWN_OBJECT_STACK_LENGHT)
                    End If

                    If DefaultProperty(pCurrBinaryStream, dwCount) Then
                        pCurrBinaryStream.BaseStream.Position -= 8

                        dwBaseStreamOldPosition = pCurrBinaryStream.BaseStream.Position
                        dwCountDefaultProperties = 0

                        pTempDefaultProperties.pNameIdx.dwIndex = pCurrBinaryStream.ReadInt32()
                        pTempDefaultProperties.pNameIdx.dwNumber = pCurrBinaryStream.ReadInt32()

                        While pUE3TablesNames(pTempDefaultProperties.pNameIdx.dwIndex).szName <> "None"

                            pTempDefaultProperties.pTypeIdx.dwIndex = pCurrBinaryStream.ReadInt32()
                            pTempDefaultProperties.pTypeIdx.dwNumber = pCurrBinaryStream.ReadInt32()
                            pTempDefaultProperties.dwPropertySize = pCurrBinaryStream.ReadInt32()
                            pTempDefaultProperties.dwArrayIdx = pCurrBinaryStream.ReadInt32()

                            If pUE3TablesNames(pTempDefaultProperties.pTypeIdx.dwIndex).szName = "BoolProperty" Then
                                If pUE3Header.dwPackageVersion = 433 Or pUE3Header.dwPackageVersion = 576 Then
                                    pTempDefaultProperties.dwBoolValue = pCurrBinaryStream.ReadInt32()
                                Else
                                    pTempDefaultProperties.dwBoolValue = pCurrBinaryStream.ReadByte()
                                End If
                            End If

                            If pUE3Header.dwPackageVersion = 512 Or pUE3Header.dwPackageVersion = 576 Then
                                If pUE3TablesNames(pTempDefaultProperties.pTypeIdx.dwIndex).szName = "StructProperty" Then
                                    pTempDefaultProperties.pInnerNameIdx.dwIndex = pCurrBinaryStream.ReadInt32()
                                    pTempDefaultProperties.pInnerNameIdx.dwNumber = pCurrBinaryStream.ReadInt32()
                                End If
                            Else
                                If pUE3TablesNames(pTempDefaultProperties.pTypeIdx.dwIndex).szName = "StructProperty" Or _
                                    pUE3TablesNames(pTempDefaultProperties.pTypeIdx.dwIndex).szName = "ByteProperty" Then
                                    pTempDefaultProperties.pInnerNameIdx.dwIndex = pCurrBinaryStream.ReadInt32()
                                    pTempDefaultProperties.pInnerNameIdx.dwNumber = pCurrBinaryStream.ReadInt32()
                                End If
                            End If

                            If pTempDefaultProperties.dwPropertySize > 0 Then
                                ReDim pTempDefaultProperties.pInnerValue(pTempDefaultProperties.dwPropertySize - 1)
                                pTempDefaultProperties.pInnerValue = pCurrBinaryStream.ReadBytes(pTempDefaultProperties.dwPropertySize)
                            End If

                            pTempDefaultProperties.pNameIdx.dwIndex = pCurrBinaryStream.ReadInt32()
                            pTempDefaultProperties.pNameIdx.dwNumber = pCurrBinaryStream.ReadInt32()

                            dwCountDefaultProperties += 1
                        End While

                        pTempDefaultProperties = Nothing
                        pCurrBinaryStream.BaseStream.Position = dwBaseStreamOldPosition

                        ReDim pUE3TablesConsts(dwCount).pUObjectDefaultProperties(dwCountDefaultProperties - 1)

                        For dwTempIndex = 0 To pUE3TablesConsts(dwCount).pUObjectDefaultProperties.Length - 1
                            pUE3TablesConsts(dwCount).pUObjectDefaultProperties(dwTempIndex).pNameIdx.dwIndex = pCurrBinaryStream.ReadInt32()
                            pUE3TablesConsts(dwCount).pUObjectDefaultProperties(dwTempIndex).pNameIdx.dwNumber = pCurrBinaryStream.ReadInt32()

                            If pUE3TablesNames(pUE3TablesConsts(dwCount).pUObjectDefaultProperties(dwTempIndex).pNameIdx.dwIndex).szName <> "None" Then
                                pUE3TablesConsts(dwCount).pUObjectDefaultProperties(dwTempIndex).pTypeIdx.dwIndex = pCurrBinaryStream.ReadInt32()
                                pUE3TablesConsts(dwCount).pUObjectDefaultProperties(dwTempIndex).pTypeIdx.dwNumber = pCurrBinaryStream.ReadInt32()
                                pUE3TablesConsts(dwCount).pUObjectDefaultProperties(dwTempIndex).dwPropertySize = pCurrBinaryStream.ReadInt32()
                                pUE3TablesConsts(dwCount).pUObjectDefaultProperties(dwTempIndex).dwArrayIdx = pCurrBinaryStream.ReadInt32()

                                If pUE3TablesNames(pUE3TablesConsts(dwCount).pUObjectDefaultProperties(dwTempIndex).pTypeIdx.dwIndex).szName = "BoolProperty" Then
                                    If pUE3Header.dwPackageVersion = 433 Or pUE3Header.dwPackageVersion = 576 Then
                                        pUE3TablesConsts(dwCount).pUObjectDefaultProperties(dwTempIndex).dwBoolValue = pCurrBinaryStream.ReadInt32()
                                    Else
                                        pUE3TablesConsts(dwCount).pUObjectDefaultProperties(dwTempIndex).dwBoolValue = pCurrBinaryStream.ReadByte()
                                    End If
                                End If

                                If pUE3Header.dwPackageVersion = 512 Or pUE3Header.dwPackageVersion = 576 Then
                                    If pUE3TablesNames(pUE3TablesConsts(dwCount).pUObjectDefaultProperties(dwTempIndex).pTypeIdx.dwIndex).szName = "StructProperty" Then
                                        pUE3TablesConsts(dwCount).pUObjectDefaultProperties(dwTempIndex).pInnerNameIdx.dwIndex = pCurrBinaryStream.ReadInt32()
                                        pUE3TablesConsts(dwCount).pUObjectDefaultProperties(dwTempIndex).pInnerNameIdx.dwNumber = pCurrBinaryStream.ReadInt32()
                                    End If
                                Else
                                    If pUE3TablesNames(pUE3TablesConsts(dwCount).pUObjectDefaultProperties(dwTempIndex).pTypeIdx.dwIndex).szName = "StructProperty" Or _
                                        pUE3TablesNames(pUE3TablesConsts(dwCount).pUObjectDefaultProperties(dwTempIndex).pTypeIdx.dwIndex).szName = "ByteProperty" Then
                                        pUE3TablesConsts(dwCount).pUObjectDefaultProperties(dwTempIndex).pInnerNameIdx.dwIndex = pCurrBinaryStream.ReadInt32()
                                        pUE3TablesConsts(dwCount).pUObjectDefaultProperties(dwTempIndex).pInnerNameIdx.dwNumber = pCurrBinaryStream.ReadInt32()
                                    End If
                                End If

                                If pUE3TablesConsts(dwCount).pUObjectDefaultProperties(dwTempIndex).dwPropertySize > 0 Then
                                    ReDim pUE3TablesConsts(dwCount).pUObjectDefaultProperties(dwTempIndex).pInnerValue(pUE3TablesConsts(dwCount).pUObjectDefaultProperties(dwTempIndex).dwPropertySize - 1)

                                    pUE3TablesConsts(dwCount).pUObjectDefaultProperties(dwTempIndex).pInnerValue = pCurrBinaryStream.ReadBytes(pUE3TablesConsts(dwCount).pUObjectDefaultProperties(dwTempIndex).dwPropertySize)
                                End If
                            Else
                                Exit For
                            End If

                        Next dwTempIndex
                    End If

                    If pUE3Header.dwPackageVersion = 421 Or pUE3Header.dwPackageVersion = 433 Or _
                        pUE3Header.dwPackageVersion = 512 Or pUE3Header.dwPackageVersion = 742 Then
                        pUE3TablesConsts(dwCount).dwParentField = pCurrBinaryStream.ReadInt32()
                        pUE3TablesConsts(dwCount).dwNextField = pCurrBinaryStream.ReadInt32()
                    Else
                        pUE3TablesConsts(dwCount).dwNextField = pCurrBinaryStream.ReadInt32()
                    End If

                    If pUE3Header.dwPackageVersion = 576 And pUE3Header.szGameName = "CrimeCraft GangWars" Then
                        pCurrBinaryStream.ReadInt32()
                    End If

                    pUE3TablesConsts(dwCount).dwConstLenght = pCurrBinaryStream.ReadInt32()

                    If pUE3TablesConsts(dwCount).dwConstLenght > 0 Then
                        pUE3TablesConsts(dwCount).szValue = System.Text.Encoding.ASCII.GetString(pCurrBinaryStream.ReadBytes(pUE3TablesConsts(dwCount).dwConstLenght - 1))
                    End If

                    dwCount += 1
                End If
            Next dwIndex

            pCurrBinaryStream.Close()
            pCurrStream.Close()

            Return 0
        Catch ex As Exception
            szErrorMessage = ex.Message
            Return -3
        End Try

    End Function

    Function ReadTableEnums(ByVal szFilePath As String) As Integer

        Try
            Dim dwIndex As Integer
            Dim dwCount As Integer
            Dim dwTempIndex As Integer
            Dim dwCountDefaultProperties As Integer
            Dim dwBaseStreamOldPosition As Integer
            Dim pTempDefaultProperties As UE3_TABLE_UDEFAULTPROPERTIES

            If pUE3TablesExports.Length = 0 Then
                Return -1
            End If

            dwCount = 0

            For dwIndex = 0 To pUE3TablesExports.Length - 1
                If GetObjectType(pUE3TablesExports(dwIndex).dwClassObject, "Enum") = 0 Then
                    dwCount += 1
                End If
            Next dwIndex

            If dwCount = 0 Then
                Return -2
            End If

            ReDim pUE3TablesEnums(dwCount - 1)

            Dim pCurrStream As System.IO.Stream = New System.IO.FileStream(szFilePath, System.IO.FileMode.Open, System.IO.FileAccess.Read, System.IO.FileShare.Read)
            Dim pCurrBinaryStream As New System.IO.BinaryReader(pCurrStream, System.Text.Encoding.ASCII)

            dwCount = 0

            For dwIndex = 0 To pUE3TablesExports.Length - 1
                If GetObjectType(pUE3TablesExports(dwIndex).dwClassObject, "Enum") = 0 Then
                    pCurrBinaryStream.BaseStream.Position = pUE3TablesExports(dwIndex).dwSerialOffset

                    pUE3TablesEnums(dwCount).dwExportIndex = dwIndex
                    pUE3TablesEnums(dwCount).dwNextObjectIndex = pCurrBinaryStream.ReadInt32()

                    If pUE3TablesExports(dwIndex).pObjectFlags.dwLowFlag And OF_L_HasStack Then
                        pCurrBinaryStream.ReadBytes(UNKNOWN_OBJECT_STACK_LENGHT)
                    End If

                    If DefaultProperty(pCurrBinaryStream, dwCount) Then
                        pCurrBinaryStream.BaseStream.Position -= 8

                        dwBaseStreamOldPosition = pCurrBinaryStream.BaseStream.Position
                        dwCountDefaultProperties = 0

                        pTempDefaultProperties.pNameIdx.dwIndex = pCurrBinaryStream.ReadInt32()
                        pTempDefaultProperties.pNameIdx.dwNumber = pCurrBinaryStream.ReadInt32()

                        While pUE3TablesNames(pTempDefaultProperties.pNameIdx.dwIndex).szName <> "None"

                            pTempDefaultProperties.pTypeIdx.dwIndex = pCurrBinaryStream.ReadInt32()
                            pTempDefaultProperties.pTypeIdx.dwNumber = pCurrBinaryStream.ReadInt32()
                            pTempDefaultProperties.dwPropertySize = pCurrBinaryStream.ReadInt32()
                            pTempDefaultProperties.dwArrayIdx = pCurrBinaryStream.ReadInt32()

                            If pUE3TablesNames(pTempDefaultProperties.pTypeIdx.dwIndex).szName = "BoolProperty" Then
                                If pUE3Header.dwPackageVersion = 433 Or pUE3Header.dwPackageVersion = 576 Then
                                    pTempDefaultProperties.dwBoolValue = pCurrBinaryStream.ReadInt32()
                                Else
                                    pTempDefaultProperties.dwBoolValue = pCurrBinaryStream.ReadByte()
                                End If

                            End If

                            If pUE3Header.dwPackageVersion = 512 Or pUE3Header.dwPackageVersion = 576 Then
                                If pUE3TablesNames(pTempDefaultProperties.pTypeIdx.dwIndex).szName = "StructProperty" Then
                                    pTempDefaultProperties.pInnerNameIdx.dwIndex = pCurrBinaryStream.ReadInt32()
                                    pTempDefaultProperties.pInnerNameIdx.dwNumber = pCurrBinaryStream.ReadInt32()
                                End If
                            Else
                                If pUE3TablesNames(pTempDefaultProperties.pTypeIdx.dwIndex).szName = "StructProperty" Or _
                                    pUE3TablesNames(pTempDefaultProperties.pTypeIdx.dwIndex).szName = "ByteProperty" Then
                                    pTempDefaultProperties.pInnerNameIdx.dwIndex = pCurrBinaryStream.ReadInt32()
                                    pTempDefaultProperties.pInnerNameIdx.dwNumber = pCurrBinaryStream.ReadInt32()
                                End If
                            End If

                            If pTempDefaultProperties.dwPropertySize > 0 Then
                                ReDim pTempDefaultProperties.pInnerValue(pTempDefaultProperties.dwPropertySize - 1)
                                pTempDefaultProperties.pInnerValue = pCurrBinaryStream.ReadBytes(pTempDefaultProperties.dwPropertySize)
                            End If

                            pTempDefaultProperties.pNameIdx.dwIndex = pCurrBinaryStream.ReadInt32()
                            pTempDefaultProperties.pNameIdx.dwNumber = pCurrBinaryStream.ReadInt32()

                            dwCountDefaultProperties += 1
                        End While

                        pTempDefaultProperties = Nothing
                        pCurrBinaryStream.BaseStream.Position = dwBaseStreamOldPosition

                        ReDim pUE3TablesEnums(dwCount).pUObjectDefaultProperties(dwCountDefaultProperties - 1)

                        For dwTempIndex = 0 To pUE3TablesEnums(dwCount).pUObjectDefaultProperties.Length - 1
                            pUE3TablesEnums(dwCount).pUObjectDefaultProperties(dwTempIndex).pNameIdx.dwIndex = pCurrBinaryStream.ReadInt32()
                            pUE3TablesEnums(dwCount).pUObjectDefaultProperties(dwTempIndex).pNameIdx.dwNumber = pCurrBinaryStream.ReadInt32()

                            If pUE3TablesNames(pUE3TablesEnums(dwCount).pUObjectDefaultProperties(dwTempIndex).pNameIdx.dwIndex).szName <> "None" Then
                                pUE3TablesEnums(dwCount).pUObjectDefaultProperties(dwTempIndex).pTypeIdx.dwIndex = pCurrBinaryStream.ReadInt32()
                                pUE3TablesEnums(dwCount).pUObjectDefaultProperties(dwTempIndex).pTypeIdx.dwNumber = pCurrBinaryStream.ReadInt32()
                                pUE3TablesEnums(dwCount).pUObjectDefaultProperties(dwTempIndex).dwPropertySize = pCurrBinaryStream.ReadInt32()
                                pUE3TablesEnums(dwCount).pUObjectDefaultProperties(dwTempIndex).dwArrayIdx = pCurrBinaryStream.ReadInt32()

                                If pUE3TablesNames(pUE3TablesEnums(dwCount).pUObjectDefaultProperties(dwTempIndex).pTypeIdx.dwIndex).szName = "BoolProperty" Then
                                    If pUE3Header.dwPackageVersion = 433 Or pUE3Header.dwPackageVersion = 576 Then
                                        pUE3TablesEnums(dwCount).pUObjectDefaultProperties(dwTempIndex).dwBoolValue = pCurrBinaryStream.ReadInt32()
                                    Else
                                        pUE3TablesEnums(dwCount).pUObjectDefaultProperties(dwTempIndex).dwBoolValue = pCurrBinaryStream.ReadByte()
                                    End If
                                End If

                                If pUE3Header.dwPackageVersion = 512 Or pUE3Header.dwPackageVersion = 576 Then
                                    If pUE3TablesNames(pUE3TablesEnums(dwCount).pUObjectDefaultProperties(dwTempIndex).pTypeIdx.dwIndex).szName = "StructProperty" Then
                                        pUE3TablesEnums(dwCount).pUObjectDefaultProperties(dwTempIndex).pInnerNameIdx.dwIndex = pCurrBinaryStream.ReadInt32()
                                        pUE3TablesEnums(dwCount).pUObjectDefaultProperties(dwTempIndex).pInnerNameIdx.dwNumber = pCurrBinaryStream.ReadInt32()
                                    End If
                                Else
                                    If pUE3TablesNames(pUE3TablesEnums(dwCount).pUObjectDefaultProperties(dwTempIndex).pTypeIdx.dwIndex).szName = "StructProperty" Or _
                                        pUE3TablesNames(pUE3TablesEnums(dwCount).pUObjectDefaultProperties(dwTempIndex).pTypeIdx.dwIndex).szName = "ByteProperty" Then
                                        pUE3TablesEnums(dwCount).pUObjectDefaultProperties(dwTempIndex).pInnerNameIdx.dwIndex = pCurrBinaryStream.ReadInt32()
                                        pUE3TablesEnums(dwCount).pUObjectDefaultProperties(dwTempIndex).pInnerNameIdx.dwNumber = pCurrBinaryStream.ReadInt32()
                                    End If
                                End If

                                If pUE3TablesEnums(dwCount).pUObjectDefaultProperties(dwTempIndex).dwPropertySize > 0 Then
                                    ReDim pUE3TablesEnums(dwCount).pUObjectDefaultProperties(dwTempIndex).pInnerValue(pUE3TablesEnums(dwCount).pUObjectDefaultProperties(dwTempIndex).dwPropertySize - 1)

                                    pUE3TablesEnums(dwCount).pUObjectDefaultProperties(dwTempIndex).pInnerValue = pCurrBinaryStream.ReadBytes(pUE3TablesEnums(dwCount).pUObjectDefaultProperties(dwTempIndex).dwPropertySize)
                                End If
                            Else
                                Exit For
                            End If

                        Next dwTempIndex
                    End If

                    If pUE3Header.dwPackageVersion = 421 Or pUE3Header.dwPackageVersion = 433 Or _
                        pUE3Header.dwPackageVersion = 512 Or pUE3Header.dwPackageVersion = 742 Then
                        pUE3TablesEnums(dwCount).dwParentField = pCurrBinaryStream.ReadInt32()
                        pUE3TablesEnums(dwCount).dwNextField = pCurrBinaryStream.ReadInt32()
                    Else
                        pUE3TablesEnums(dwCount).dwNextField = pCurrBinaryStream.ReadInt32()
                    End If

                    pUE3TablesEnums(dwCount).dwEnumLenght = pCurrBinaryStream.ReadInt32()

                    ReDim pUE3TablesEnums(dwCount).pEnumValue(pUE3TablesEnums(dwCount).dwEnumLenght - 1)

                    For dwTempIndex = 0 To pUE3TablesEnums(dwCount).dwEnumLenght - 1
                        pUE3TablesEnums(dwCount).pEnumValue(dwTempIndex).dwIndex = pCurrBinaryStream.ReadInt32()
                        pUE3TablesEnums(dwCount).pEnumValue(dwTempIndex).dwNumber = pCurrBinaryStream.ReadInt32()
                    Next dwTempIndex

                    dwCount += 1
                End If
            Next dwIndex

            pCurrBinaryStream.Close()
            pCurrStream.Close()

            Return 0
        Catch ex As Exception
            szErrorMessage = ex.Message
            Return -3
        End Try

    End Function

    Function ReadTableClasses(ByVal szFilePath As String) As Integer

        Try
            Dim dwIndex As Integer
            Dim dwCount As Integer
            Dim dwTempIndex As Integer

            If pUE3TablesExports.Length = 0 Then
                Return -1
            End If

            dwCount = 0

            For dwIndex = 0 To pUE3TablesExports.Length - 1
                If GetObjectType(pUE3TablesExports(dwIndex).dwClassObject, "Class") = 0 Then
                    dwCount += 1
                End If
            Next dwIndex

            If dwCount = 0 Then
                Return -2
            End If

            ReDim pUE3TablesClass(dwCount - 1)

            Dim pCurrStream As System.IO.Stream = New System.IO.FileStream(szFilePath, System.IO.FileMode.Open, System.IO.FileAccess.Read, System.IO.FileShare.Read)
            Dim pCurrBinaryStream As New System.IO.BinaryReader(pCurrStream, System.Text.Encoding.ASCII)

            dwCount = 0

            For dwIndex = 0 To pUE3TablesExports.Length - 1
                If GetObjectType(pUE3TablesExports(dwIndex).dwClassObject, "Class") = 0 Then
                    pCurrBinaryStream.BaseStream.Position = pUE3TablesExports(dwIndex).dwSerialOffset

                    pUE3TablesClass(dwCount).dwExportIndex = dwIndex
                    pUE3TablesClass(dwCount).dwNextObjectIndex = pCurrBinaryStream.ReadInt32()

                    If pUE3Header.dwPackageVersion = 421 Or pUE3Header.dwPackageVersion = 433 Or _
                        pUE3Header.dwPackageVersion = 512 Or pUE3Header.dwPackageVersion = 576 Or _
                        pUE3Header.dwPackageVersion = 742 Then
                        pUE3TablesClass(dwCount).dwParentField = pCurrBinaryStream.ReadInt32()
                        pUE3TablesClass(dwCount).dwNextField = pCurrBinaryStream.ReadInt32()
                    Else
                        pUE3TablesClass(dwCount).dwNextField = pCurrBinaryStream.ReadInt32()
                        pUE3TablesClass(dwCount).dwParentField = pCurrBinaryStream.ReadInt32()
                    End If

                    pUE3TablesClass(dwCount).dwScriptText = pCurrBinaryStream.ReadInt32()
                    pUE3TablesClass(dwCount).dwChildren = pCurrBinaryStream.ReadInt32()
                    pUE3TablesClass(dwCount).dwCppText = pCurrBinaryStream.ReadInt32()
                    pUE3TablesClass(dwCount).dwLine = pCurrBinaryStream.ReadInt32()
                    pUE3TablesClass(dwCount).dwTextPos = pCurrBinaryStream.ReadInt32()
                    pUE3TablesClass(dwCount).dwByteScriptSize = pCurrBinaryStream.ReadInt32()

                    If pUE3Header.dwPackageVersion = 421 Or pUE3Header.dwPackageVersion = 433 Or pUE3Header.dwPackageVersion = 512 Or pUE3Header.dwPackageVersion = 576 Then
                        If pUE3TablesClass(dwCount).dwByteScriptSize > 0 Then
                            ReDim pUE3TablesClass(dwCount).dwByteScript(pUE3TablesClass(dwCount).dwByteScriptSize - 1)

                            pUE3TablesClass(dwCount).dwByteScript = pCurrBinaryStream.ReadBytes(pUE3TablesClass(dwCount).dwByteScriptSize)
                        End If
                    Else
                        pUE3TablesClass(dwCount).dwDataScriptSize = pCurrBinaryStream.ReadInt32()

                        If pUE3TablesClass(dwCount).dwDataScriptSize > 0 Then
                            ReDim pUE3TablesClass(dwCount).dwByteScript(pUE3TablesClass(dwCount).dwDataScriptSize - 1)

                            pUE3TablesClass(dwCount).dwByteScript = pCurrBinaryStream.ReadBytes(pUE3TablesClass(dwCount).dwDataScriptSize)
                        End If
                    End If

                    If pUE3Header.dwPackageVersion = 421 Or pUE3Header.dwPackageVersion = 433 Or pUE3Header.dwPackageVersion = 512 Or pUE3Header.dwPackageVersion = 576 Then
                        pCurrBinaryStream.ReadBytes(UNKNOWN_VAR_LENGHT)
                    End If

                    pUE3TablesClass(dwCount).dwProbeMask = pCurrBinaryStream.ReadInt32()
                    pUE3TablesClass(dwCount).dwLabelTableOffset = pCurrBinaryStream.ReadInt16()
                    pUE3TablesClass(dwCount).dwStateFlags = pCurrBinaryStream.ReadInt32()
                    pUE3TablesClass(dwCount).dwStateMapSize = pCurrBinaryStream.ReadInt32()

                    If pUE3TablesClass(dwCount).dwStateMapSize > 0 Then
                        ReDim pUE3TablesClass(dwCount).pStateMap(pUE3TablesClass(dwCount).dwStateMapSize - 1)

                        For dwTempIndex = 0 To pUE3TablesClass(dwCount).dwStateMapSize - 1
                            pUE3TablesClass(dwCount).pStateMap(dwTempIndex).pTK.dwIndex = pCurrBinaryStream.ReadInt32()
                            pUE3TablesClass(dwCount).pStateMap(dwTempIndex).pTK.dwNumber = pCurrBinaryStream.ReadInt32()
                            pUE3TablesClass(dwCount).pStateMap(dwTempIndex).PTI = pCurrBinaryStream.ReadInt32()
                        Next dwTempIndex
                    End If

                    pUE3TablesClass(dwCount).dwClassFlags = pCurrBinaryStream.ReadInt32()

                    dwCount += 1
                End If
            Next dwIndex

            pCurrBinaryStream.Close()
            pCurrStream.Close()

            Return 0
        Catch ex As Exception
            szErrorMessage = ex.Message
            Return -3
        End Try

    End Function

    Function IsPropertyOf(ByVal dwOuterObject As Int32, ByVal szObjectName As String) As Integer

        Try
            Dim dwTempIndex As Int32

            If dwOuterObject > 0 Then
                dwTempIndex = dwOuterObject - 1

                If pUE3TablesNames(pUE3TablesExports(dwTempIndex).pObjectName.dwIndex).szName = szObjectName Then
                    Return 0
                Else
                    Return -1
                End If
            ElseIf dwOuterObject < 0 Then
                dwTempIndex = -dwOuterObject - 1

                If pUE3TablesNames(pUE3TablesImports(dwTempIndex).pObjectName.dwIndex).szName = szObjectName Then
                    Return 0
                Else
                    Return -1
                End If
            Else
                Return -1
            End If

            Return -1
        Catch ex As Exception
            Return -2
        End Try

    End Function

    Function ReadTableScriptStruct(ByVal szFilePath As String) As Integer

        Try
            Dim dwIndex As Integer
            Dim dwTempIndex As Integer
            Dim dwCount As Integer
            Dim dwCountDefaultProperties As Integer
            Dim dwBaseStreamOldPosition As Integer
            Dim pTempDefaultProperties As UE3_TABLE_UDEFAULTPROPERTIES

            If pUE3TablesExports.Length = 0 Then
                Return -1
            End If

            dwCount = 0

            For dwIndex = 0 To pUE3TablesExports.Length - 1
                If GetObjectType(pUE3TablesExports(dwIndex).dwClassObject, "ScriptStruct") = 0 Then
                    dwCount += 1
                End If
            Next dwIndex

            If dwCount = 0 Then
                Return -2
            End If

            ReDim pUE3TablesScriptStruct(dwCount - 1)

            Dim pCurrStream As System.IO.Stream = New System.IO.FileStream(szFilePath, System.IO.FileMode.Open, System.IO.FileAccess.Read, System.IO.FileShare.Read)
            Dim pCurrBinaryStream As New System.IO.BinaryReader(pCurrStream, System.Text.Encoding.ASCII)

            dwCount = 0

            For dwIndex = 0 To pUE3TablesExports.Length - 1
                If GetObjectType(pUE3TablesExports(dwIndex).dwClassObject, "ScriptStruct") = 0 Then
                    pCurrBinaryStream.BaseStream.Position = pUE3TablesExports(dwIndex).dwSerialOffset

                    pUE3TablesScriptStruct(dwCount).dwExportIndex = dwIndex
                    pUE3TablesScriptStruct(dwCount).dwNextField = pCurrBinaryStream.ReadInt32()

                    If pUE3TablesExports(dwIndex).pObjectFlags.dwLowFlag And OF_L_HasStack Then
                        pCurrBinaryStream.ReadBytes(UNKNOWN_OBJECT_STACK_LENGHT)
                    End If

                    If DefaultProperty(pCurrBinaryStream, dwCount) Then
                        pCurrBinaryStream.BaseStream.Position -= 8

                        dwBaseStreamOldPosition = pCurrBinaryStream.BaseStream.Position
                        dwCountDefaultProperties = 0

                        pTempDefaultProperties.pNameIdx.dwIndex = pCurrBinaryStream.ReadInt32()
                        pTempDefaultProperties.pNameIdx.dwNumber = pCurrBinaryStream.ReadInt32()

                        While pUE3TablesNames(pTempDefaultProperties.pNameIdx.dwIndex).szName <> "None"

                            pTempDefaultProperties.pTypeIdx.dwIndex = pCurrBinaryStream.ReadInt32()
                            pTempDefaultProperties.pTypeIdx.dwNumber = pCurrBinaryStream.ReadInt32()
                            pTempDefaultProperties.dwPropertySize = pCurrBinaryStream.ReadInt32()
                            pTempDefaultProperties.dwArrayIdx = pCurrBinaryStream.ReadInt32()

                            If pUE3TablesNames(pTempDefaultProperties.pTypeIdx.dwIndex).szName = "BoolProperty" Then
                                If pUE3Header.dwPackageVersion = 433 Or pUE3Header.dwPackageVersion = 576 Then
                                    pTempDefaultProperties.dwBoolValue = pCurrBinaryStream.ReadInt32()
                                Else
                                    pTempDefaultProperties.dwBoolValue = pCurrBinaryStream.ReadByte()
                                End If
                            End If

                            If pUE3Header.dwPackageVersion = 421 Or pUE3Header.dwPackageVersion = 433 Or pUE3Header.dwPackageVersion = 512 Or pUE3Header.dwPackageVersion = 576 Then
                                If pUE3TablesNames(pTempDefaultProperties.pTypeIdx.dwIndex).szName = "StructProperty" Then
                                    pTempDefaultProperties.pInnerNameIdx.dwIndex = pCurrBinaryStream.ReadInt32()
                                    pTempDefaultProperties.pInnerNameIdx.dwNumber = pCurrBinaryStream.ReadInt32()
                                End If
                            Else
                                If pUE3TablesNames(pTempDefaultProperties.pTypeIdx.dwIndex).szName = "StructProperty" Or _
                                    pUE3TablesNames(pTempDefaultProperties.pTypeIdx.dwIndex).szName = "ByteProperty" Then
                                    pTempDefaultProperties.pInnerNameIdx.dwIndex = pCurrBinaryStream.ReadInt32()
                                    pTempDefaultProperties.pInnerNameIdx.dwNumber = pCurrBinaryStream.ReadInt32()
                                End If
                            End If

                            If pTempDefaultProperties.dwPropertySize > 0 Then
                                ReDim pTempDefaultProperties.pInnerValue(pTempDefaultProperties.dwPropertySize - 1)
                                pTempDefaultProperties.pInnerValue = pCurrBinaryStream.ReadBytes(pTempDefaultProperties.dwPropertySize)
                            End If

                            pTempDefaultProperties.pNameIdx.dwIndex = pCurrBinaryStream.ReadInt32()
                            pTempDefaultProperties.pNameIdx.dwNumber = pCurrBinaryStream.ReadInt32()

                            dwCountDefaultProperties += 1
                        End While

                        pTempDefaultProperties = Nothing
                        pCurrBinaryStream.BaseStream.Position = dwBaseStreamOldPosition

                        ReDim pUE3TablesScriptStruct(dwCount).pUObjectDefaultProperties(dwCountDefaultProperties - 1)

                        For dwTempIndex = 0 To pUE3TablesScriptStruct(dwCount).pUObjectDefaultProperties.Length - 1
                            pUE3TablesScriptStruct(dwCount).pUObjectDefaultProperties(dwTempIndex).pNameIdx.dwIndex = pCurrBinaryStream.ReadInt32()
                            pUE3TablesScriptStruct(dwCount).pUObjectDefaultProperties(dwTempIndex).pNameIdx.dwNumber = pCurrBinaryStream.ReadInt32()

                            If pUE3TablesNames(pUE3TablesScriptStruct(dwCount).pUObjectDefaultProperties(dwTempIndex).pNameIdx.dwIndex).szName <> "None" Then
                                pUE3TablesScriptStruct(dwCount).pUObjectDefaultProperties(dwTempIndex).pTypeIdx.dwIndex = pCurrBinaryStream.ReadInt32()
                                pUE3TablesScriptStruct(dwCount).pUObjectDefaultProperties(dwTempIndex).pTypeIdx.dwNumber = pCurrBinaryStream.ReadInt32()
                                pUE3TablesScriptStruct(dwCount).pUObjectDefaultProperties(dwTempIndex).dwPropertySize = pCurrBinaryStream.ReadInt32()
                                pUE3TablesScriptStruct(dwCount).pUObjectDefaultProperties(dwTempIndex).dwArrayIdx = pCurrBinaryStream.ReadInt32()

                                If pUE3TablesNames(pUE3TablesScriptStruct(dwCount).pUObjectDefaultProperties(dwTempIndex).pTypeIdx.dwIndex).szName = "BoolProperty" Then
                                    If pUE3Header.dwPackageVersion = 433 Or pUE3Header.dwPackageVersion = 576 Then
                                        pUE3TablesScriptStruct(dwCount).pUObjectDefaultProperties(dwTempIndex).dwBoolValue = pCurrBinaryStream.ReadInt32()
                                    Else
                                        pUE3TablesScriptStruct(dwCount).pUObjectDefaultProperties(dwTempIndex).dwBoolValue = pCurrBinaryStream.ReadByte()
                                    End If
                                End If

                                If pUE3Header.dwPackageVersion = 421 Or pUE3Header.dwPackageVersion = 433 Or pUE3Header.dwPackageVersion = 512 Or pUE3Header.dwPackageVersion = 576 Then
                                    If pUE3TablesNames(pUE3TablesScriptStruct(dwCount).pUDefaultProperties(dwTempIndex).pTypeIdx.dwIndex).szName = "StructProperty" Then
                                        pTempDefaultProperties.pInnerNameIdx.dwIndex = pCurrBinaryStream.ReadInt32()
                                        pTempDefaultProperties.pInnerNameIdx.dwNumber = pCurrBinaryStream.ReadInt32()
                                    End If
                                Else
                                    If pUE3TablesNames(pUE3TablesScriptStruct(dwCount).pUObjectDefaultProperties(dwTempIndex).pTypeIdx.dwIndex).szName = "StructProperty" Or _
                                       pUE3TablesNames(pUE3TablesScriptStruct(dwCount).pUObjectDefaultProperties(dwTempIndex).pTypeIdx.dwIndex).szName = "ByteProperty" Then
                                        pUE3TablesScriptStruct(dwCount).pUObjectDefaultProperties(dwTempIndex).pInnerNameIdx.dwIndex = pCurrBinaryStream.ReadInt32()
                                        pUE3TablesScriptStruct(dwCount).pUObjectDefaultProperties(dwTempIndex).pInnerNameIdx.dwNumber = pCurrBinaryStream.ReadInt32()
                                    End If
                                End If

                                If pUE3TablesScriptStruct(dwCount).pUObjectDefaultProperties(dwTempIndex).dwPropertySize > 0 Then
                                    ReDim pUE3TablesScriptStruct(dwCount).pUObjectDefaultProperties(dwTempIndex).pInnerValue(pUE3TablesScriptStruct(dwCount).pUObjectDefaultProperties(dwTempIndex).dwPropertySize - 1)

                                    pUE3TablesScriptStruct(dwCount).pUObjectDefaultProperties(dwTempIndex).pInnerValue = pCurrBinaryStream.ReadBytes(pUE3TablesScriptStruct(dwCount).pUObjectDefaultProperties(dwTempIndex).dwPropertySize)
                                End If
                            Else
                                Exit For
                            End If

                        Next dwTempIndex
                    End If

                    If pUE3Header.dwPackageVersion = 421 Or pUE3Header.dwPackageVersion = 433 Or _
                        pUE3Header.dwPackageVersion = 512 Or pUE3Header.dwPackageVersion = 576 Or _
                        pUE3Header.dwPackageVersion = 742 Then
                        pUE3TablesScriptStruct(dwCount).dwParentField = pCurrBinaryStream.ReadInt32()
                        pUE3TablesScriptStruct(dwCount).dwNextField = pCurrBinaryStream.ReadInt32()
                    Else
                        pUE3TablesScriptStruct(dwCount).dwNextField = pCurrBinaryStream.ReadInt32()
                        pUE3TablesScriptStruct(dwCount).dwParentField = pCurrBinaryStream.ReadInt32()
                    End If

                    pUE3TablesScriptStruct(dwCount).dwScriptText = pCurrBinaryStream.ReadInt32()
                    pUE3TablesScriptStruct(dwCount).dwChildren = pCurrBinaryStream.ReadInt32()
                    pUE3TablesScriptStruct(dwCount).dwCppText = pCurrBinaryStream.ReadInt32()
                    pUE3TablesScriptStruct(dwCount).dwLine = pCurrBinaryStream.ReadInt32()
                    pUE3TablesScriptStruct(dwCount).dwTextPos = pCurrBinaryStream.ReadInt32()
                    pUE3TablesScriptStruct(dwCount).dwByteScriptSize = pCurrBinaryStream.ReadInt32()

                    If pUE3Header.dwPackageVersion = 421 Or pUE3Header.dwPackageVersion = 433 Or pUE3Header.dwPackageVersion = 512 Or pUE3Header.dwPackageVersion = 576 Then
                        If pUE3TablesScriptStruct(dwCount).dwByteScriptSize > 0 Then
                            ReDim pUE3TablesScriptStruct(dwCount).dwByteScript(pUE3TablesScriptStruct(dwCount).dwByteScriptSize - 1)

                            pUE3TablesScriptStruct(dwCount).dwByteScript = pCurrBinaryStream.ReadBytes(pUE3TablesScriptStruct(dwCount).dwByteScriptSize)
                        End If
                    Else
                        pUE3TablesScriptStruct(dwCount).dwDataScriptSize = pCurrBinaryStream.ReadInt32()

                        If pUE3TablesScriptStruct(dwCount).dwDataScriptSize > 0 Then
                            ReDim pUE3TablesScriptStruct(dwCount).dwByteScript(pUE3TablesScriptStruct(dwCount).dwDataScriptSize - 1)

                            pUE3TablesScriptStruct(dwCount).dwByteScript = pCurrBinaryStream.ReadBytes(pUE3TablesScriptStruct(dwCount).dwDataScriptSize)
                        End If
                    End If

                    pUE3TablesScriptStruct(dwCount).dwStructFlag = pCurrBinaryStream.ReadInt32()

                    If DefaultProperty(pCurrBinaryStream, dwCount) Then
                        pCurrBinaryStream.BaseStream.Position -= 8

                        dwBaseStreamOldPosition = pCurrBinaryStream.BaseStream.Position
                        dwCountDefaultProperties = 0

                        pTempDefaultProperties.pNameIdx.dwIndex = pCurrBinaryStream.ReadInt32()
                        pTempDefaultProperties.pNameIdx.dwNumber = pCurrBinaryStream.ReadInt32()

                        While pUE3TablesNames(pTempDefaultProperties.pNameIdx.dwIndex).szName <> "None"

                            pTempDefaultProperties.pTypeIdx.dwIndex = pCurrBinaryStream.ReadInt32()
                            pTempDefaultProperties.pTypeIdx.dwNumber = pCurrBinaryStream.ReadInt32()
                            pTempDefaultProperties.dwPropertySize = pCurrBinaryStream.ReadInt32()
                            pTempDefaultProperties.dwArrayIdx = pCurrBinaryStream.ReadInt32()

                            If pUE3TablesNames(pTempDefaultProperties.pTypeIdx.dwIndex).szName = "BoolProperty" Then
                                If pUE3Header.dwPackageVersion = 433 Or pUE3Header.dwPackageVersion = 576 Then
                                    pTempDefaultProperties.dwBoolValue = pCurrBinaryStream.ReadInt32()
                                Else
                                    pTempDefaultProperties.dwBoolValue = pCurrBinaryStream.ReadByte()
                                End If
                            End If

                            If pUE3Header.dwPackageVersion = 421 Or pUE3Header.dwPackageVersion = 433 Or pUE3Header.dwPackageVersion = 512 Or pUE3Header.dwPackageVersion = 576 Then
                                If pUE3TablesNames(pTempDefaultProperties.pTypeIdx.dwIndex).szName = "StructProperty" Then
                                    pTempDefaultProperties.pInnerNameIdx.dwIndex = pCurrBinaryStream.ReadInt32()
                                    pTempDefaultProperties.pInnerNameIdx.dwNumber = pCurrBinaryStream.ReadInt32()
                                End If
                            Else
                                If pUE3TablesNames(pTempDefaultProperties.pTypeIdx.dwIndex).szName = "StructProperty" Or _
                                    pUE3TablesNames(pTempDefaultProperties.pTypeIdx.dwIndex).szName = "ByteProperty" Then
                                    pTempDefaultProperties.pInnerNameIdx.dwIndex = pCurrBinaryStream.ReadInt32()
                                    pTempDefaultProperties.pInnerNameIdx.dwNumber = pCurrBinaryStream.ReadInt32()
                                End If
                            End If

                            If pTempDefaultProperties.dwPropertySize > 0 Then
                                ReDim pTempDefaultProperties.pInnerValue(pTempDefaultProperties.dwPropertySize - 1)
                                pTempDefaultProperties.pInnerValue = pCurrBinaryStream.ReadBytes(pTempDefaultProperties.dwPropertySize)
                            End If

                            pTempDefaultProperties.pNameIdx.dwIndex = pCurrBinaryStream.ReadInt32()
                            pTempDefaultProperties.pNameIdx.dwNumber = pCurrBinaryStream.ReadInt32()

                            dwCountDefaultProperties += 1
                        End While

                        pTempDefaultProperties = Nothing
                        pCurrBinaryStream.BaseStream.Position = dwBaseStreamOldPosition

                        ReDim pUE3TablesScriptStruct(dwCount).pUDefaultProperties(dwCountDefaultProperties - 1)

                        For dwTempIndex = 0 To pUE3TablesScriptStruct(dwCount).pUDefaultProperties.Length - 1
                            pUE3TablesScriptStruct(dwCount).pUDefaultProperties(dwTempIndex).pNameIdx.dwIndex = pCurrBinaryStream.ReadInt32()
                            pUE3TablesScriptStruct(dwCount).pUDefaultProperties(dwTempIndex).pNameIdx.dwNumber = pCurrBinaryStream.ReadInt32()

                            If pUE3TablesNames(pUE3TablesScriptStruct(dwCount).pUDefaultProperties(dwTempIndex).pNameIdx.dwIndex).szName <> "None" Then
                                pUE3TablesScriptStruct(dwCount).pUDefaultProperties(dwTempIndex).pTypeIdx.dwIndex = pCurrBinaryStream.ReadInt32()
                                pUE3TablesScriptStruct(dwCount).pUDefaultProperties(dwTempIndex).pTypeIdx.dwNumber = pCurrBinaryStream.ReadInt32()
                                pUE3TablesScriptStruct(dwCount).pUDefaultProperties(dwTempIndex).dwPropertySize = pCurrBinaryStream.ReadInt32()
                                pUE3TablesScriptStruct(dwCount).pUDefaultProperties(dwTempIndex).dwArrayIdx = pCurrBinaryStream.ReadInt32()

                                If pUE3TablesNames(pUE3TablesScriptStruct(dwCount).pUDefaultProperties(dwTempIndex).pTypeIdx.dwIndex).szName = "BoolProperty" Then
                                    If pUE3Header.dwPackageVersion = 433 Or pUE3Header.dwPackageVersion = 576 Then
                                        pUE3TablesScriptStruct(dwCount).pUDefaultProperties(dwTempIndex).dwBoolValue = pCurrBinaryStream.ReadInt32()
                                    Else
                                        pUE3TablesScriptStruct(dwCount).pUDefaultProperties(dwTempIndex).dwBoolValue = pCurrBinaryStream.ReadByte()
                                    End If
                                End If

                                If pUE3Header.dwPackageVersion = 421 Or pUE3Header.dwPackageVersion = 433 Or pUE3Header.dwPackageVersion = 512 Or pUE3Header.dwPackageVersion = 576 Then
                                    If pUE3TablesNames(pUE3TablesScriptStruct(dwCount).pUDefaultProperties(dwTempIndex).pTypeIdx.dwIndex).szName = "StructProperty" Then
                                        pTempDefaultProperties.pInnerNameIdx.dwIndex = pCurrBinaryStream.ReadInt32()
                                        pTempDefaultProperties.pInnerNameIdx.dwNumber = pCurrBinaryStream.ReadInt32()
                                    End If
                                Else
                                    If pUE3TablesNames(pUE3TablesScriptStruct(dwCount).pUDefaultProperties(dwTempIndex).pTypeIdx.dwIndex).szName = "StructProperty" Or _
                                        pUE3TablesNames(pUE3TablesScriptStruct(dwCount).pUDefaultProperties(dwTempIndex).pTypeIdx.dwIndex).szName = "ByteProperty" Then
                                        pUE3TablesScriptStruct(dwCount).pUDefaultProperties(dwTempIndex).pInnerNameIdx.dwIndex = pCurrBinaryStream.ReadInt32()
                                        pUE3TablesScriptStruct(dwCount).pUDefaultProperties(dwTempIndex).pInnerNameIdx.dwNumber = pCurrBinaryStream.ReadInt32()
                                    End If
                                End If

                                If pUE3TablesScriptStruct(dwCount).pUDefaultProperties(dwTempIndex).dwPropertySize > 0 Then
                                    ReDim pUE3TablesScriptStruct(dwCount).pUDefaultProperties(dwTempIndex).pInnerValue(pUE3TablesScriptStruct(dwCount).pUDefaultProperties(dwTempIndex).dwPropertySize - 1)

                                    pUE3TablesScriptStruct(dwCount).pUDefaultProperties(dwTempIndex).pInnerValue = pCurrBinaryStream.ReadBytes(pUE3TablesScriptStruct(dwCount).pUDefaultProperties(dwTempIndex).dwPropertySize)
                                End If
                            Else
                                Exit For
                            End If

                        Next dwTempIndex
                    End If

                    dwCount += 1
                End If
            Next dwIndex

            pCurrBinaryStream.Close()
            pCurrStream.Close()

            Return 0
        Catch ex As Exception
            szErrorMessage = ex.Message
            Return -3
        End Try

    End Function

    Function ReadTableProperties(ByVal szFilePath As String) As Integer

        Try
            Dim dwIndex As Integer
            Dim dwCount As Integer
            Dim dwCountDefaultProperties As Integer
            Dim dwBaseStreamOldPosition As Integer
            Dim pTempDefaultProperties As UE3_TABLE_UDEFAULTPROPERTIES

            If pUE3TablesExports.Length = 0 Then
                Return -1
            End If

            dwCount = 0

            For dwIndex = 0 To pUE3TablesExports.Length - 1
                If InStr(pUE3TablesNames(pUE3TablesExports(dwIndex).pObjectName.dwIndex).szName, "Default__", CompareMethod.Text) = 0 Then
                    If IsPropertyType(pUE3TablesExports(dwIndex).dwClassObject) = 0 Then
                        dwCount += 1
                    End If
                End If
            Next dwIndex

            If dwCount = 0 Then
                Return -2
            End If

            ReDim pUE3TablesProperties(dwCount - 1)

            Dim pCurrStream As System.IO.Stream = New System.IO.FileStream(szFilePath, System.IO.FileMode.Open, System.IO.FileAccess.Read, System.IO.FileShare.Read)
            Dim pCurrBinaryStream As New System.IO.BinaryReader(pCurrStream, System.Text.Encoding.ASCII)

            dwCount = 0

            For dwIndex = 0 To pUE3TablesExports.Length - 1
                If InStr(pUE3TablesNames(pUE3TablesExports(dwIndex).pObjectName.dwIndex).szName, "Default__", CompareMethod.Text) = 0 Then
                    If IsPropertyType(pUE3TablesExports(dwIndex).dwClassObject) = 0 Then
                        pCurrBinaryStream.BaseStream.Position = pUE3TablesExports(dwIndex).dwSerialOffset

                        pUE3TablesProperties(dwCount).dwExportIndex = dwIndex
                        pUE3TablesProperties(dwCount).dwNextObjectIndex = pCurrBinaryStream.ReadInt32()

                        If pUE3TablesExports(dwIndex).pObjectFlags.dwLowFlag And OF_L_HasStack Then
                            pCurrBinaryStream.ReadBytes(UNKNOWN_OBJECT_STACK_LENGHT)
                        End If

                        If DefaultProperty(pCurrBinaryStream, dwCount) Then
                            pCurrBinaryStream.BaseStream.Position -= 8

                            dwBaseStreamOldPosition = pCurrBinaryStream.BaseStream.Position
                            dwCountDefaultProperties = 0

                            pTempDefaultProperties.pNameIdx.dwIndex = pCurrBinaryStream.ReadInt32()
                            pTempDefaultProperties.pNameIdx.dwNumber = pCurrBinaryStream.ReadInt32()

                            While pUE3TablesNames(pTempDefaultProperties.pNameIdx.dwIndex).szName <> "None"

                                pTempDefaultProperties.pTypeIdx.dwIndex = pCurrBinaryStream.ReadInt32()
                                pTempDefaultProperties.pTypeIdx.dwNumber = pCurrBinaryStream.ReadInt32()
                                pTempDefaultProperties.dwPropertySize = pCurrBinaryStream.ReadInt32()
                                pTempDefaultProperties.dwArrayIdx = pCurrBinaryStream.ReadInt32()

                                If pUE3TablesNames(pTempDefaultProperties.pTypeIdx.dwIndex).szName = "BoolProperty" Then
                                    If pUE3Header.dwPackageVersion = 433 Or pUE3Header.dwPackageVersion = 576 Then
                                        pTempDefaultProperties.dwBoolValue = pCurrBinaryStream.ReadByte()
                                    Else
                                        pTempDefaultProperties.dwBoolValue = pCurrBinaryStream.ReadByte()
                                    End If
                                End If

                                If pUE3Header.dwPackageVersion = 421 Or pUE3Header.dwPackageVersion = 433 Or pUE3Header.dwPackageVersion = 512 Or pUE3Header.dwPackageVersion = 576 Then
                                    If pUE3TablesNames(pTempDefaultProperties.pTypeIdx.dwIndex).szName = "StructProperty" Then
                                        pTempDefaultProperties.pInnerNameIdx.dwIndex = pCurrBinaryStream.ReadInt32()
                                        pTempDefaultProperties.pInnerNameIdx.dwNumber = pCurrBinaryStream.ReadInt32()
                                    End If
                                Else
                                    If pUE3TablesNames(pTempDefaultProperties.pTypeIdx.dwIndex).szName = "StructProperty" Or _
                                        pUE3TablesNames(pTempDefaultProperties.pTypeIdx.dwIndex).szName = "ByteProperty" Then
                                        pTempDefaultProperties.pInnerNameIdx.dwIndex = pCurrBinaryStream.ReadInt32()
                                        pTempDefaultProperties.pInnerNameIdx.dwNumber = pCurrBinaryStream.ReadInt32()
                                    End If
                                End If

                                If pTempDefaultProperties.dwPropertySize > 0 Then
                                    ReDim pTempDefaultProperties.pInnerValue(pTempDefaultProperties.dwPropertySize - 1)
                                    pTempDefaultProperties.pInnerValue = pCurrBinaryStream.ReadBytes(pTempDefaultProperties.dwPropertySize)
                                End If

                                pTempDefaultProperties.pNameIdx.dwIndex = pCurrBinaryStream.ReadInt32()
                                pTempDefaultProperties.pNameIdx.dwNumber = pCurrBinaryStream.ReadInt32()

                                dwCountDefaultProperties += 1
                            End While

                            pTempDefaultProperties = Nothing
                            pCurrBinaryStream.BaseStream.Position = dwBaseStreamOldPosition

                            ReDim pUE3TablesProperties(dwCount).pUObjectDefaultProperties(dwCountDefaultProperties - 1)

                            For dwTempIndex = 0 To pUE3TablesProperties(dwCount).pUObjectDefaultProperties.Length - 1
                                pUE3TablesProperties(dwCount).pUObjectDefaultProperties(dwTempIndex).pNameIdx.dwIndex = pCurrBinaryStream.ReadInt32()
                                pUE3TablesProperties(dwCount).pUObjectDefaultProperties(dwTempIndex).pNameIdx.dwNumber = pCurrBinaryStream.ReadInt32()

                                If pUE3TablesNames(pUE3TablesProperties(dwCount).pUObjectDefaultProperties(dwTempIndex).pNameIdx.dwIndex).szName <> "None" Then
                                    pUE3TablesProperties(dwCount).pUObjectDefaultProperties(dwTempIndex).pTypeIdx.dwIndex = pCurrBinaryStream.ReadInt32()
                                    pUE3TablesProperties(dwCount).pUObjectDefaultProperties(dwTempIndex).pTypeIdx.dwNumber = pCurrBinaryStream.ReadInt32()
                                    pUE3TablesProperties(dwCount).pUObjectDefaultProperties(dwTempIndex).dwPropertySize = pCurrBinaryStream.ReadInt32()
                                    pUE3TablesProperties(dwCount).pUObjectDefaultProperties(dwTempIndex).dwArrayIdx = pCurrBinaryStream.ReadInt32()

                                    If pUE3TablesNames(pUE3TablesProperties(dwCount).pUObjectDefaultProperties(dwTempIndex).pTypeIdx.dwIndex).szName = "BoolProperty" Then
                                        If pUE3Header.dwPackageVersion = 433 Or pUE3Header.dwPackageVersion = 576 Then
                                            pUE3TablesProperties(dwCount).pUObjectDefaultProperties(dwTempIndex).dwBoolValue = pCurrBinaryStream.ReadInt32()
                                        Else
                                            pUE3TablesProperties(dwCount).pUObjectDefaultProperties(dwTempIndex).dwBoolValue = pCurrBinaryStream.ReadByte()
                                        End If
                                    End If

                                    If pUE3Header.dwPackageVersion = 421 Or pUE3Header.dwPackageVersion = 433 Or pUE3Header.dwPackageVersion = 512 Or pUE3Header.dwPackageVersion = 576 Then
                                        If pUE3TablesNames(pUE3TablesProperties(dwCount).pUObjectDefaultProperties(dwTempIndex).pTypeIdx.dwIndex).szName = "StructProperty" Then
                                            pUE3TablesProperties(dwCount).pUObjectDefaultProperties(dwTempIndex).pInnerNameIdx.dwIndex = pCurrBinaryStream.ReadInt32()
                                            pUE3TablesProperties(dwCount).pUObjectDefaultProperties(dwTempIndex).pInnerNameIdx.dwNumber = pCurrBinaryStream.ReadInt32()
                                        End If
                                    Else
                                        If pUE3TablesNames(pUE3TablesProperties(dwCount).pUObjectDefaultProperties(dwTempIndex).pTypeIdx.dwIndex).szName = "StructProperty" Or _
                                            pUE3TablesNames(pUE3TablesProperties(dwCount).pUObjectDefaultProperties(dwTempIndex).pTypeIdx.dwIndex).szName = "ByteProperty" Then
                                            pUE3TablesProperties(dwCount).pUObjectDefaultProperties(dwTempIndex).pInnerNameIdx.dwIndex = pCurrBinaryStream.ReadInt32()
                                            pUE3TablesProperties(dwCount).pUObjectDefaultProperties(dwTempIndex).pInnerNameIdx.dwNumber = pCurrBinaryStream.ReadInt32()
                                        End If
                                    End If

                                    If pUE3TablesProperties(dwCount).pUObjectDefaultProperties(dwTempIndex).dwPropertySize > 0 Then
                                        ReDim pUE3TablesProperties(dwCount).pUObjectDefaultProperties(dwTempIndex).pInnerValue(pUE3TablesProperties(dwCount).pUObjectDefaultProperties(dwTempIndex).dwPropertySize - 1)

                                        pUE3TablesProperties(dwCount).pUObjectDefaultProperties(dwTempIndex).pInnerValue = pCurrBinaryStream.ReadBytes(pUE3TablesProperties(dwCount).pUObjectDefaultProperties(dwTempIndex).dwPropertySize)
                                    End If
                                Else
                                    Exit For
                                End If

                            Next dwTempIndex
                        End If

                        If pUE3Header.dwPackageVersion = 421 Or pUE3Header.dwPackageVersion = 433 Or _
                            pUE3Header.dwPackageVersion = 512 Or pUE3Header.dwPackageVersion = 742 Then
                            pUE3TablesProperties(dwCount).dwParentField = pCurrBinaryStream.ReadInt32()
                            pUE3TablesProperties(dwCount).dwNextField = pCurrBinaryStream.ReadInt32()
                        Else
                            pUE3TablesProperties(dwCount).dwNextField = pCurrBinaryStream.ReadInt32()
                        End If

                        pUE3TablesProperties(dwCount).dwArrayDim = pCurrBinaryStream.ReadInt16()
                        pUE3TablesProperties(dwCount).dwElementSize = pCurrBinaryStream.ReadInt16()
                        pUE3TablesProperties(dwCount).pFlag.dwLowFlag = pCurrBinaryStream.ReadInt32()
                        pUE3TablesProperties(dwCount).pFlag.dwHighFlag = pCurrBinaryStream.ReadInt32()
                        pUE3TablesProperties(dwCount).pCategoryIndex.dwIndex = pCurrBinaryStream.ReadInt32()
                        pUE3TablesProperties(dwCount).pCategoryIndex.dwNumber = pCurrBinaryStream.ReadInt32()
                        pUE3TablesProperties(dwCount).dwArrayEnumRef = pCurrBinaryStream.ReadInt32()

                        If pUE3TablesProperties(dwCount).pFlag.dwLowFlag And PF_L_Net Then
                            pUE3TablesProperties(dwCount).dwRepOffset = pCurrBinaryStream.ReadInt16()
                        End If

                        dwCount += 1
                    End If
                End If
            Next dwIndex

            pCurrBinaryStream.Close()
            pCurrStream.Close()

            Return 0
        Catch ex As Exception
            szErrorMessage = ex.Message
            Return -3
        End Try

    End Function

    Function ReadTableStates(ByVal szFilePath As String) As Integer

        Try
            Dim dwIndex As Integer
            Dim dwCount As Integer
            Dim dwTempIndex As Integer
            Dim dwCountDefaultProperties As Integer
            Dim dwBaseStreamOldPosition As Integer
            Dim pTempDefaultProperties As UE3_TABLE_UDEFAULTPROPERTIES

            If pUE3TablesExports.Length = 0 Then
                Return -1
            End If

            dwCount = 0

            For dwIndex = 0 To pUE3TablesExports.Length - 1
                If GetObjectType(pUE3TablesExports(dwIndex).dwClassObject, "State") = 0 Then
                    dwCount += 1
                End If
            Next dwIndex

            If dwCount = 0 Then
                Return -2
            End If

            ReDim pUE3TablesStates(dwCount - 1)

            Dim pCurrStream As System.IO.Stream = New System.IO.FileStream(szFilePath, System.IO.FileMode.Open, System.IO.FileAccess.Read, System.IO.FileShare.Read)
            Dim pCurrBinaryStream As New System.IO.BinaryReader(pCurrStream, System.Text.Encoding.ASCII)

            dwCount = 0

            For dwIndex = 0 To pUE3TablesExports.Length - 1
                If GetObjectType(pUE3TablesExports(dwIndex).dwClassObject, "State") = 0 Then
                    pCurrBinaryStream.BaseStream.Position = pUE3TablesExports(dwIndex).dwSerialOffset

                    pUE3TablesStates(dwCount).dwExportIndex = dwIndex
                    pUE3TablesStates(dwCount).dwNextObjectIndex = pCurrBinaryStream.ReadInt32()

                    If pUE3TablesExports(dwIndex).pObjectFlags.dwLowFlag And OF_L_HasStack Then
                        pCurrBinaryStream.ReadBytes(UNKNOWN_OBJECT_STACK_LENGHT)
                    End If

                    If DefaultProperty(pCurrBinaryStream, dwCount) Then
                        pCurrBinaryStream.BaseStream.Position -= 8

                        dwBaseStreamOldPosition = pCurrBinaryStream.BaseStream.Position
                        dwCountDefaultProperties = 0

                        pTempDefaultProperties.pNameIdx.dwIndex = pCurrBinaryStream.ReadInt32()
                        pTempDefaultProperties.pNameIdx.dwNumber = pCurrBinaryStream.ReadInt32()

                        While pUE3TablesNames(pTempDefaultProperties.pNameIdx.dwIndex).szName <> "None"

                            pTempDefaultProperties.pTypeIdx.dwIndex = pCurrBinaryStream.ReadInt32()
                            pTempDefaultProperties.pTypeIdx.dwNumber = pCurrBinaryStream.ReadInt32()
                            pTempDefaultProperties.dwPropertySize = pCurrBinaryStream.ReadInt32()
                            pTempDefaultProperties.dwArrayIdx = pCurrBinaryStream.ReadInt32()

                            If pUE3TablesNames(pTempDefaultProperties.pTypeIdx.dwIndex).szName = "BoolProperty" Then
                                If pUE3Header.dwPackageVersion = 433 Or pUE3Header.dwPackageVersion = 576 Then
                                    pTempDefaultProperties.dwBoolValue = pCurrBinaryStream.ReadInt32()
                                Else
                                    pTempDefaultProperties.dwBoolValue = pCurrBinaryStream.ReadByte()
                                End If
                            End If

                            If pUE3Header.dwPackageVersion = 421 Or pUE3Header.dwPackageVersion = 433 Or pUE3Header.dwPackageVersion = 512 Or pUE3Header.dwPackageVersion = 576 Then
                                If pUE3TablesNames(pTempDefaultProperties.pTypeIdx.dwIndex).szName = "StructProperty" Then
                                    pTempDefaultProperties.pInnerNameIdx.dwIndex = pCurrBinaryStream.ReadInt32()
                                    pTempDefaultProperties.pInnerNameIdx.dwNumber = pCurrBinaryStream.ReadInt32()
                                End If
                            Else
                                If pUE3TablesNames(pTempDefaultProperties.pTypeIdx.dwIndex).szName = "StructProperty" Or _
                                    pUE3TablesNames(pTempDefaultProperties.pTypeIdx.dwIndex).szName = "ByteProperty" Then
                                    pTempDefaultProperties.pInnerNameIdx.dwIndex = pCurrBinaryStream.ReadInt32()
                                    pTempDefaultProperties.pInnerNameIdx.dwNumber = pCurrBinaryStream.ReadInt32()
                                End If
                            End If

                            If pTempDefaultProperties.dwPropertySize > 0 Then
                                ReDim pTempDefaultProperties.pInnerValue(pTempDefaultProperties.dwPropertySize - 1)
                                pTempDefaultProperties.pInnerValue = pCurrBinaryStream.ReadBytes(pTempDefaultProperties.dwPropertySize)
                            End If

                            pTempDefaultProperties.pNameIdx.dwIndex = pCurrBinaryStream.ReadInt32()
                            pTempDefaultProperties.pNameIdx.dwNumber = pCurrBinaryStream.ReadInt32()

                            dwCountDefaultProperties += 1
                        End While

                        pTempDefaultProperties = Nothing
                        pCurrBinaryStream.BaseStream.Position = dwBaseStreamOldPosition

                        ReDim pUE3TablesProperties(dwCount).pUObjectDefaultProperties(dwCountDefaultProperties - 1)

                        For dwTempIndex = 0 To pUE3TablesStates(dwCount).pUObjectDefaultProperties.Length - 1
                            pUE3TablesStates(dwCount).pUObjectDefaultProperties(dwTempIndex).pNameIdx.dwIndex = pCurrBinaryStream.ReadInt32()
                            pUE3TablesStates(dwCount).pUObjectDefaultProperties(dwTempIndex).pNameIdx.dwNumber = pCurrBinaryStream.ReadInt32()

                            If pUE3TablesNames(pUE3TablesStates(dwCount).pUObjectDefaultProperties(dwTempIndex).pNameIdx.dwIndex).szName <> "None" Then
                                pUE3TablesStates(dwCount).pUObjectDefaultProperties(dwTempIndex).pTypeIdx.dwIndex = pCurrBinaryStream.ReadInt32()
                                pUE3TablesStates(dwCount).pUObjectDefaultProperties(dwTempIndex).pTypeIdx.dwNumber = pCurrBinaryStream.ReadInt32()
                                pUE3TablesStates(dwCount).pUObjectDefaultProperties(dwTempIndex).dwPropertySize = pCurrBinaryStream.ReadInt32()
                                pUE3TablesStates(dwCount).pUObjectDefaultProperties(dwTempIndex).dwArrayIdx = pCurrBinaryStream.ReadInt32()

                                If pUE3TablesNames(pUE3TablesStates(dwCount).pUObjectDefaultProperties(dwTempIndex).pTypeIdx.dwIndex).szName = "BoolProperty" Then
                                    If pUE3Header.dwPackageVersion = 433 Or pUE3Header.dwPackageVersion = 576 Then
                                        pUE3TablesStates(dwCount).pUObjectDefaultProperties(dwTempIndex).dwBoolValue = pCurrBinaryStream.ReadInt32()
                                    Else
                                        pUE3TablesStates(dwCount).pUObjectDefaultProperties(dwTempIndex).dwBoolValue = pCurrBinaryStream.ReadByte()
                                    End If

                                End If

                                If pUE3Header.dwPackageVersion = 421 Or pUE3Header.dwPackageVersion = 433 Or pUE3Header.dwPackageVersion = 512 Or pUE3Header.dwPackageVersion = 576 Then
                                    If pUE3TablesNames(pUE3TablesStates(dwCount).pUObjectDefaultProperties(dwTempIndex).pTypeIdx.dwIndex).szName = "StructProperty" Then
                                        pUE3TablesStates(dwCount).pUObjectDefaultProperties(dwTempIndex).pInnerNameIdx.dwIndex = pCurrBinaryStream.ReadInt32()
                                        pUE3TablesStates(dwCount).pUObjectDefaultProperties(dwTempIndex).pInnerNameIdx.dwNumber = pCurrBinaryStream.ReadInt32()
                                    End If
                                Else
                                    If pUE3TablesNames(pUE3TablesStates(dwCount).pUObjectDefaultProperties(dwTempIndex).pTypeIdx.dwIndex).szName = "StructProperty" Or _
                                        pUE3TablesNames(pUE3TablesStates(dwCount).pUObjectDefaultProperties(dwTempIndex).pTypeIdx.dwIndex).szName = "ByteProperty" Then
                                        pUE3TablesStates(dwCount).pUObjectDefaultProperties(dwTempIndex).pInnerNameIdx.dwIndex = pCurrBinaryStream.ReadInt32()
                                        pUE3TablesStates(dwCount).pUObjectDefaultProperties(dwTempIndex).pInnerNameIdx.dwNumber = pCurrBinaryStream.ReadInt32()
                                    End If
                                End If

                                If pUE3TablesStates(dwCount).pUObjectDefaultProperties(dwTempIndex).dwPropertySize > 0 Then
                                    ReDim pUE3TablesStates(dwCount).pUObjectDefaultProperties(dwTempIndex).pInnerValue(pUE3TablesStates(dwCount).pUObjectDefaultProperties(dwTempIndex).dwPropertySize - 1)

                                    pUE3TablesStates(dwCount).pUObjectDefaultProperties(dwTempIndex).pInnerValue = pCurrBinaryStream.ReadBytes(pUE3TablesStates(dwCount).pUObjectDefaultProperties(dwTempIndex).dwPropertySize)
                                End If
                            Else
                                Exit For
                            End If

                        Next dwTempIndex
                    End If

                    If pUE3Header.dwPackageVersion = 421 Or pUE3Header.dwPackageVersion = 433 Or _
                        pUE3Header.dwPackageVersion = 512 Or pUE3Header.dwPackageVersion = 576 Or _
                        pUE3Header.dwPackageVersion = 742 Then
                        pUE3TablesStates(dwCount).dwParentField = pCurrBinaryStream.ReadInt32()
                        pUE3TablesStates(dwCount).dwNextField = pCurrBinaryStream.ReadInt32()
                    Else
                        pUE3TablesStates(dwCount).dwNextField = pCurrBinaryStream.ReadInt32()
                        pUE3TablesStates(dwCount).dwParentField = pCurrBinaryStream.ReadInt32()
                    End If

                    pUE3TablesStates(dwCount).dwScriptText = pCurrBinaryStream.ReadInt32()
                    pUE3TablesStates(dwCount).dwChildren = pCurrBinaryStream.ReadInt32()
                    pUE3TablesStates(dwCount).dwCppText = pCurrBinaryStream.ReadInt32()
                    pUE3TablesStates(dwCount).dwLine = pCurrBinaryStream.ReadInt32()
                    pUE3TablesStates(dwCount).dwTextPos = pCurrBinaryStream.ReadInt32()
                    pUE3TablesStates(dwCount).dwByteScriptSize = pCurrBinaryStream.ReadInt32()

                    If pUE3Header.dwPackageVersion = 421 Or pUE3Header.dwPackageVersion = 433 Or pUE3Header.dwPackageVersion = 512 Or pUE3Header.dwPackageVersion = 576 Then
                        If pUE3TablesStates(dwCount).dwByteScriptSize > 0 Then
                            ReDim pUE3TablesStates(dwCount).dwByteScript(pUE3TablesStates(dwCount).dwByteScriptSize - 1)

                            pUE3TablesStates(dwCount).dwByteScript = pCurrBinaryStream.ReadBytes(pUE3TablesStates(dwCount).dwByteScriptSize)
                        End If
                    Else
                        pUE3TablesStates(dwCount).dwDataScriptSize = pCurrBinaryStream.ReadInt32()

                        If pUE3TablesStates(dwCount).dwDataScriptSize > 0 Then
                            ReDim pUE3TablesStates(dwCount).dwByteScript(pUE3TablesStates(dwCount).dwDataScriptSize - 1)

                            pUE3TablesStates(dwCount).dwByteScript = pCurrBinaryStream.ReadBytes(pUE3TablesStates(dwCount).dwDataScriptSize)
                        End If
                    End If

                    If pUE3Header.dwPackageVersion = 421 Or pUE3Header.dwPackageVersion = 433 Or pUE3Header.dwPackageVersion = 512 Or pUE3Header.dwPackageVersion = 576 Then
                        pCurrBinaryStream.ReadBytes(UNKNOWN_VAR_LENGHT)
                    End If

                    pUE3TablesStates(dwCount).dwProbeMask = pCurrBinaryStream.ReadInt32()
                    pUE3TablesStates(dwCount).dwLabelTableOffset = pCurrBinaryStream.ReadInt16()
                    pUE3TablesStates(dwCount).dwStateFlags = pCurrBinaryStream.ReadInt32()
                    pUE3TablesStates(dwCount).dwStateMapSize = pCurrBinaryStream.ReadInt32()

                    If pUE3TablesStates(dwCount).dwStateMapSize > 0 Then
                        ReDim pUE3TablesStates(dwCount).pStateMap(pUE3TablesStates(dwCount).dwStateMapSize - 1)

                        For dwTempIndex = 0 To pUE3TablesStates(dwCount).dwStateMapSize - 1
                            pUE3TablesStates(dwCount).pStateMap(dwTempIndex).pTK.dwIndex = pCurrBinaryStream.ReadInt32()
                            pUE3TablesStates(dwCount).pStateMap(dwTempIndex).pTK.dwNumber = pCurrBinaryStream.ReadInt32()
                            pUE3TablesStates(dwCount).pStateMap(dwTempIndex).PTI = pCurrBinaryStream.ReadInt32()
                        Next dwTempIndex
                    End If

                    dwCount += 1
                End If
            Next dwIndex

            pCurrBinaryStream.Close()
            pCurrStream.Close()

            Return 0
        Catch ex As Exception
            szErrorMessage = ex.Message
            Return -3
        End Try

    End Function

    Function GetObjectNameByIndex(ByVal dwIndex As Int32) As String

        Try
            Dim dwTempIndex As Int32

            If dwIndex > 0 Then
                dwTempIndex = dwIndex - 1
                Return pUE3TablesNames(pUE3TablesExports(dwTempIndex).pObjectName.dwIndex).szName
            ElseIf dwIndex < 0 Then
                Return pUE3TablesNames(pUE3TablesImports(dwTempIndex).pObjectName.dwIndex).szName
            Else
                Return ""
            End If

            Return ""
        Catch ex As Exception
            Return ""
        End Try

    End Function

    Function InitDecodeToken(ByVal pScriptData As System.IO.BinaryReader, ByVal dwInitScript As Integer, ByVal dwEndScript As Integer) As String

        Dim szDecodedText As String = ""

        pScriptData.BaseStream.Position = dwInitScript

        While pScriptData.BaseStream.Position <> dwEndScript
            szDecodedText += DecodeToken(pScriptData)
        End While

        Return szDecodedText

    End Function

    Function DecodeToken(ByVal pScriptData As System.IO.BinaryReader) As String

        Dim dwCurrByte As Byte

        dwCurrByte = pScriptData.ReadByte()

        Select Case dwCurrByte
            Case EX_LocalVariable, EX_InstanceVariable, EX_NativeParm
                Return GetObjectNameByIndex(pScriptData.ReadInt32())
            Case EX_DefaultVariable
                Return "Default." + GetObjectNameByIndex(pScriptData.ReadInt32())
            Case EX_Return
                Return ReadToken_EX_Return(pScriptData)
            Case EX_Jump
                Return "goto J0x" + pScriptData.ReadInt16().ToString("X2")
            Case EX_Stop
                pScriptData.ReadInt16()
                Return ""
            Case EX_Assert
                Return "// Unknown ByteCode: " + dwCurrByte.ToString("X2")
            Case EX_JumpIfNot
                Return ReadToken_EX_JumpIfNot(pScriptData)
            Case EX_Nothing
                Return ""
            Case EX_GotoLabel
                Return ReadToken_EX_GoToLabel(pScriptData)
            Case EX_EatReturnValue
                pScriptData.ReadInt32()
                Return DecodeToken(pScriptData)
            Case EX_Let, EX_LetBool, EX_LetDelegate
                Return ReadToken_EX_Let(pScriptData)
            Case EX_EndParmValue
                Return ""
            Case EX_EndFunctionParms
                Return ")"
            Case EX_Self
                Return "self."
            Case EX_Skip
                pScriptData.ReadInt16()
                Return DecodeToken(pScriptData)
            Case EX_ArrayElement, EX_DynArrayElement
                Return ReadToken_EX_ArrayElement(pScriptData)
            Case EX_IntConst
                Return pScriptData.ReadInt32().ToString()
            Case EX_FloatConst
                Return pScriptData.ReadSingle().ToString()
            Case EX_StringConst
                Return """" + ReadToken_EX_StringConst(pScriptData) + """"
            Case EX_NameConst
                Return ReadToken_EX_NameConst(pScriptData)
            Case EX_RotationConst
                Return ReadToken_EX__RotationConst(pScriptData)
            Case EX_VectorConst
                Return ReadToken_EX__VectorConst(pScriptData)
            Case EX_ByteConst, EX_IntConstByte
                Return pScriptData.ReadByte().ToString()
            Case EX_IntZero
                Return "0"
            Case EX_IntOne
                Return "1"
            Case EX_True
                Return "true"
            Case EX_False
                Return "false"
            Case EX_NoObject, EX_EmptyDelegate
                Return "None"
            Case EX_BoolVariable
                Return DecodeToken(pScriptData)
            Case EX_DynArrayLength
                Return ReadToken_EX_DynArrayLength(pScriptData)
            Case EX_ReturnNothing
                Return "//" + GetObjectNameByIndex(pScriptData.ReadInt32())
            Case EX_LocalOutVariable
                Return ReadToken_EX_LocalOutVariable(pScriptData)
            Case EX_DefaultParmValue
                Return ReadToken_EX_DefaultParmValue(pScriptData)
            Case EX_EmptyParmValue
                Return ""
            Case EX_EndOfScript
                Return ""
            Case Else
                If dwCurrByte >= 96 Then
                    Return ReadNativeCall(dwCurrByte, pScriptData)
                Else
                    Return "// Unknown ByteCode: " + dwCurrByte.ToString("X2")
                End If
        End Select

    End Function

    Function ReadToken_EX_Return(ByVal pScriptData As System.IO.BinaryReader) As String

        Dim szReturnValue As String

        szReturnValue = DecodeToken(pScriptData)

        If InStr(szReturnValue, "//", CompareMethod.Text) > 0 Then
            Return "// return " + Right(szReturnValue, Len(szReturnValue) - 2)
        Else
            Return "return " + szReturnValue
        End If

    End Function

    Function ReadToken_EX_JumpIfNot(ByVal pScriptData As System.IO.BinaryReader) As String

        Dim JumpOffset As Int16
        Dim szCondition As String

        JumpOffset = pScriptData.ReadInt16()
        szCondition = DecodeToken(pScriptData)

        Return "if !(" + szCondition + ") goto J0x" + JumpOffset.ToString("X2")

    End Function

    Function ReadToken_EX_GoToLabel(ByVal pScriptData As System.IO.BinaryReader) As String

        Dim szOperand As String

        szOperand = DecodeToken(pScriptData)

        Return "goto " + szOperand

    End Function

    Function ReadToken_EX_Let(ByVal pScriptData As System.IO.BinaryReader) As String

        Dim szCurrName As String
        Dim szCurrValue As String

        szCurrName = DecodeToken(pScriptData)
        szCurrValue = DecodeToken(pScriptData)

        Return szCurrName + " = " + szCurrValue

    End Function

    Function ReadToken_EX_ArrayElement(ByVal pScriptData As System.IO.BinaryReader) As String

        Dim szElement As String
        Dim szArray As String

        szElement = DecodeToken(pScriptData)
        szArray = DecodeToken(pScriptData)

        Return szArray + "[ " + szElement + " ]"

    End Function

    Function ReadToken_EX_StringConst(ByVal pScriptData As System.IO.BinaryReader) As String

        Dim dwCurrChar As Char
        Dim szString As String = ""

        dwCurrChar = pScriptData.ReadChar()

        While dwCurrChar <> Nothing
            szString += dwCurrChar
            dwCurrChar = pScriptData.ReadChar()
        End While

        Return szString

    End Function

    Function ReadToken_EX_NameConst(ByVal pScriptData As System.IO.BinaryReader) As String

        Dim dwNameIndex As Integer
        Dim dwNameNumber As Integer

        dwNameIndex = pScriptData.ReadInt32()
        dwNameNumber = pScriptData.ReadInt32()

        Return pUE3TablesNames(dwNameIndex).szName + pUE3TablesNames(dwNameNumber).szName

    End Function

    Function ReadToken_EX__VectorConst(ByVal pScriptData As System.IO.BinaryReader) As String

        Dim szX As String
        Dim szY As String
        Dim szZ As String

        szX = pScriptData.ReadSingle().ToString()
        szY = pScriptData.ReadSingle().ToString()
        szZ = pScriptData.ReadSingle().ToString()

        Return "Vector(" + szX + ", " + szY + ", " + szZ + ")"

    End Function

    Function ReadToken_EX__RotationConst(ByVal pScriptData As System.IO.BinaryReader) As String

        Dim szX As String
        Dim szY As String
        Dim szZ As String

        szX = pScriptData.ReadInt32().ToString()
        szY = pScriptData.ReadInt32().ToString()
        szZ = pScriptData.ReadInt32().ToString()

        Return "Rotator(" + szX + ", " + szY + ", " + szZ + ")"

    End Function

    Function ReadToken_EX_DynArrayLength(ByVal pScriptData As System.IO.BinaryReader) As String

        Dim szOperand As String

        szOperand = DecodeToken(pScriptData)

        Return szOperand + ".Lenght"

    End Function

    Function ReadToken_EX_LocalOutVariable(ByVal pScriptData As System.IO.BinaryReader) As String
        Return GetObjectNameByIndex(pScriptData.ReadInt32())
    End Function

    Function ReadToken_EX_DefaultParmValue(ByVal pScriptData As System.IO.BinaryReader) As String

        Dim dwSize As Int16

        dwSize = pScriptData.ReadInt16()
        pScriptData.ReadBytes(dwSize)

        Return ""

    End Function

    Function ReadNativeCall(ByVal dwCurrByte As Byte, ByVal pScriptData As System.IO.BinaryReader) As String

        Dim dwNativeIndex As Integer
        Dim dwIndex As Integer
        Dim szFuncName As String
        Dim dwFuncFlag As Int32
        Dim dwOpPrecedence As Int32
        Dim bFound As Boolean
        Dim szPartAfterOperator As String
        Dim szPartBeforeOperator As String
        Dim dwCount As Integer
        Dim szNextParam As String
        Dim szResultParam As String

        If (dwCurrByte And 240) = 96 Then
            Dim dwNextByte As Byte = pScriptData.ReadByte()
            dwNativeIndex = ((dwCurrByte - 96) << 8) + dwNextByte
        Else
            dwNativeIndex = dwCurrByte
        End If

        bFound = False
        szFuncName = ""
        dwFuncFlag = 0

        For dwIndex = 0 To pUE3TablesFunctions.Length - 1
            If dwNativeIndex = pUE3TablesFunctions(dwIndex).dwNativeTokenIndex Then
                szFuncName = pUE3TablesNames(pUE3TablesFunctions(dwIndex).pFriendlyName.dwIndex).szName
                dwFuncFlag = pUE3TablesFunctions(dwIndex).dwFunctionFlags
                dwOpPrecedence = pUE3TablesFunctions(dwIndex).dwOperPrecedence
                bFound = True
                Exit For
            End If
        Next

        If Not bFound Then
            Return "// Unknown Native ByteCode: " + dwNativeIndex.ToString("X2")
        End If

        If dwFuncFlag And FF_PreOperator Then
            szPartAfterOperator = DecodeToken(pScriptData)
            pScriptData.ReadByte()
            Return szFuncName + szPartAfterOperator
        ElseIf dwFuncFlag And FF_Operator Then
            If dwOpPrecedence = 0 Then
                szPartAfterOperator = DecodeToken(pScriptData)
                pScriptData.ReadByte()
                Return szPartAfterOperator + szFuncName
            Else
                szPartAfterOperator = DecodeToken(pScriptData)
                szPartBeforeOperator = DecodeToken(pScriptData)
                pScriptData.ReadByte()
                Return szPartAfterOperator + " " + szFuncName + " " + szPartBeforeOperator
            End If
        End If

        dwCount = 0
        szNextParam = ""
        szResultParam = ""

        Do
            szNextParam = DecodeToken(pScriptData)
            szResultParam += szNextParam
            dwCount += 1
            If szNextParam <> ")" And szNextParam <> "" Then
                szResultParam += ", "
            End If
        Loop Until szNextParam = ")"

        If Right(szResultParam, 3) = ", )" Then
            szResultParam = Left(szResultParam, Len(szResultParam) - 3)
        End If

        Return szFuncName + "(" + szResultParam + ")"

    End Function

End Module
