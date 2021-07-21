Imports ADODB
Module Structure_Functions

    Public IniFile As String = Application.StartupPath & "\Inf.ini"
    Public INI As New ini(IniFile)

#Region "Server Config"
    Public Structure Server_Config
        Public ipaddress As String
        Public port As Long
        Public username As String
        Public password As String
        Public dbname As String
        Public iSok As Boolean
    End Structure
    Public Function Get_Server_Config() As Server_Config
        Dim x As New Server_Config
        x.ipaddress = INI.GetString("SERVER CONFIG", "IPADDRESS", vbNullString)
        x.dbname = INI.GetString("SERVER CONFIG", "DBNAME", "RWDB")
        x.port = INI.GetInteger("SERVER CONFIG", "PORT", 3306)
        x.username = INI.GetString("SERVER CONFIG", "USERNAME", "root")
        x.password = INI.GetString("SERVER CONFIG", "PASSWORD", vbNullString)
        x.iSok = True
        Return x
    End Function
#End Region

#Region "Local Config"
    Public Structure Local_Config
        Public ipaddress As String
        Public Port As Long
        Public Username As String
        Public Password As String
        Public DBname As String
        Public IsOk As Boolean
    End Structure

    Public Function Get_Local_Config() As Local_Config
        Dim x As New Local_Config
        x.ipaddress = INI.GetString("LOCAL CONFIG", "IPADDRESS", "127.0.0.1")
        x.DBname = INI.GetString("LOCAL CONFIG", "DBNAME", "RWDB")
        x.Port = INI.GetInteger("LOCAL CONFIG", "PORT", 3306)
        x.Username = INI.GetString("LOCAL CONFIG", "USERNAME", "root")
        x.Password = INI.GetString("LOCAL CONFIG", "PASSWORD", vbNullString)
        x.IsOk = True
        Return x
    End Function

#End Region

#Region "Camera Config"
    Public Structure Camera_Config
        Public CamIP As String
        Public CamPort As Integer
        Public CamUser As String
        Public CamPass As String
        Public CamCapture As Integer
        Public CamChanel As Integer
        Public CamCapture2 As Integer
        Public CamChanel2 As Integer
        Public IsOk As Boolean
    End Structure

    Public Function Get_Camera_Config() As Camera_Config
        Dim x As New Camera_Config
        x.CamIP = INI.GetString("CAMERA", "IPADDRESS", vbNullString)
        x.CamPort = INI.GetInteger("CAMERA", "PORT", 8000)
        x.CamUser = INI.GetString("CAMERA", "USERNAME", "admin")
        x.CamPass = INI.GetString("CAMERA", "PASSWORD", "12345")
        x.CamCapture = INI.GetInteger("CAMERA", "CAPTURE", 1)
        x.CamCapture2 = INI.GetInteger("CAMERA", "CAPTURE2", 2)
        x.CamChanel = INI.GetInteger("CAMERA", "CHANEL", 1)
        x.CamChanel2 = INI.GetInteger("CAMERA", "CHANEL2", 2)
        x.IsOk = True
        Return x
    End Function
#End Region

#Region "Barrier Config"

    Public Structure Barrier_Config
        Public Address As String
        Public Port As Integer
        Public Port2 As Integer
        Public Delay As Integer
        Public LoopAddress As String
        Public Loop1 As Integer
        Public Loop2 As Integer
        Public Loop3 As Integer
        Public IsOk As Boolean
    End Structure

    Public Function Get_Barrier_Config() As Barrier_Config
        Dim x As New Barrier_Config
        x.Address = INI.GetString("BARRIER", "ADDRESS", "378")
        x.Port = INI.GetInteger("BARRIER", "PORT", 255)
        x.Port2 = INI.GetInteger("BARRIER", "PORT2", 255)
        x.Delay = INI.GetInteger("BARRIER", "DELAY", 300)
        x.LoopAddress = INI.GetString("BARRIER", "LoopAddress", "379")
        x.Loop1 = INI.GetInteger("BARRIER", "Loop1", 0)
        x.Loop2 = INI.GetInteger("BARRIER", "Loop2", 0)
        x.Loop3 = INI.GetInteger("BARRIER", "Loop3", 0)
        x.IsOk = True
        Return x
    End Function

#End Region

#Region "Network Config"
    Public Structure Network_Config
        Public IsPing As Boolean
        Public NetPooling As Boolean
        Public NetOffline As Boolean
        Public NetForceServer As Boolean
        Public IsOk As Boolean
    End Structure

    Public Function Get_Network_Config() As Network_Config
        Dim x As New Network_Config
        x.IsPing = INI.GetBoolean("NETWORK CONFIG", "PING TEST", False)
        x.NetForceServer = INI.GetBoolean("NETWORK CONFIG", "SFORCE", False)
        x.NetOffline = INI.GetBoolean("NETWORK CONFIG", "OFFLINE", False)
        x.NetPooling = INI.GetBoolean("NETWORK CONFIG", "POOLING", False)
        x.IsOk = True
        Return x
    End Function



#End Region

#Region "OR Number Config"
    Public Structure OR_Config
        Public OR_NUM As Long
        Public IsOk As Boolean
    End Structure
    Public Function Get_OR_Config()
        Dim x As New OR_Config
        x.OR_NUM = INI.GetInteger("ORNUM", "ORNUM", 1)
        x.IsOk = True
        Return x
    End Function
#End Region

#Region "Pole Display Config"
    Public Structure PD_Config
        Public COM As String
        Public Line1 As String
        Public Line2 As String
        Public IsOk As Boolean
    End Structure
    Public Function Get_PD_Config()
        Dim x As New PD_Config
        x.COM = INI.GetString("POLED", "COM", "COM1")
        x.Line1 = INI.GetString("POLED", "LINE1", "WELCOME @ ISA.INC")
        x.Line2 = INI.GetString("POLED", "LINE2", "THANK YOU")
        x.IsOk = True
        Return x
    End Function
#End Region

#Region "POS Reference Config"
    Public Structure POS_Config
        Public Station As String
        Public MachineNum As String
        Public Serial As String
        Public Accr As String
        Public AccrDate As Date
        Public PermitDate As Date
        Public POStitle As String
        Public POSlocation As String
        Public CashinHand As String
        Public OperatedBy As String
        Public IsOk As Boolean
    End Structure

    Public Function Get_POS_Config() As POS_Config
        Dim x As New POS_Config
        x.Station = INI.GetString("POS CONFIG", "STATION", "POS-1")
        x.POStitle = INI.GetString("POS CONFIG", "TITTLE", "ISA PARKING SYSTEM")
        x.Accr = INI.GetString("POS CONFIG", "ACCR", "042-006539714-00050440451")
        x.AccrDate = INI.GetString("POS CONFIG", "ACCRDate", "2011-03-21")
        x.PermitDate = INI.GetString("POS CONFIG", "PermitDate", "2016-05-05")
        x.MachineNum = INI.GetString("POS CONFIG", "MN", "-")
        x.Serial = INI.GetString("POS CONFIG", "SERIAL", "TBN6152906")
        x.POSlocation = INI.GetString("POS CONFIG", "LOCATION", "-")
        x.CashinHand = INI.GetInteger("POS CONFIG", "CIH", 0)
        x.OperatedBy = INI.GetString("POS CONFIG", "OPERATOR", "")
        x.IsOk = True
        Return x
    End Function
#End Region

#Region "Printer Config"
    Public Structure Printer_Config
        Public PrintCopy As Integer
        Public PrinterName As String
        Public IsOk As Boolean
    End Structure

    Public Function Get_Printer_Config() As Printer_Config
        Dim x As New Printer_Config
        x.PrintCopy = INI.GetInteger("PRINTER SET", "COPY", 1)
        x.PrinterName = INI.GetString("PRINTER SET", "PRINTER", vbNullString)
        x.IsOk = True
        Return x
    End Function
#End Region

#Region "POS Settings Config"
    Public Structure POS_SETTING
        Public Enable_Task As Boolean
        Public IS_Opendrawer As Boolean
        Public Is_CAMON As Boolean
        Public IsOk As Boolean
    End Structure

    Public Function Get_POS_SETTING() As POS_SETTING
        Dim x As New POS_SETTING
        x.Enable_Task = INI.GetBoolean("POS SET", "ENATSK", True)
        x.Is_CAMON = INI.GetBoolean("POS SET", "CAMON", True)
        x.IS_Opendrawer = INI.GetBoolean("POS SET", "DRAWER", True)
        x.IsOk = True
        Return x
    End Function

#End Region

#Region "Magstripe Config"
    Public Structure MagStripe_Config
        Public StartIndex As Integer
        Public Lent As Integer
        Public IsOk As Boolean
    End Structure
    Public Function Get_MagStripe_Config() As MagStripe_Config
        Dim x As New MagStripe_Config
        x.StartIndex = INI.GetInteger("MAGST", "STARTINDEX", 11)
        x.Lent = INI.GetInteger("MAGST", "LEN", 13)
        x.IsOk = True
    End Function
#End Region

#Region "Backdoor Access Config"
    Public Structure BackDoor_Config
        Public Username As String
        Public Password As String
        Public IsOk As Boolean
    End Structure
    Public Function Get_BackDoor_Config() As BackDoor_Config
        Dim x As New BackDoor_Config
        x.Username = INI.GetString("BCKDOOR", "USERNAME", "admin")
        x.Password = INI.GetString("BCKDOOR", "PASSWORD", "12345")
        x.IsOk = True
        Return x
    End Function
#End Region

#Region "Super Password Config"
    Public Structure SuperPass_Config
        Public SuperPassword As String
        Public VersionCode As String
        Public IsOk As Boolean
    End Structure
    Public Function Get_SuperPassword_Config() As SuperPass_Config
        Dim x As New SuperPass_Config
        x.SuperPassword = INI.GetString("SUPER", "SN", vbNullString)
        x.VersionCode = INI.GetString("SUPER", "VC", vbNullString)
        Return x
    End Function
#End Region

#Region "Coupon Privilege"
    Public Structure Charging_Privilege
        Public ChName As String
    End Structure
    Public Function Get_Charging_Privilege() As Charging_Privilege
        Dim x As New Charging_Privilege
        x.ChName = INI.GetString("CHPRIV", "CHNAME", vbNullString)
        Return x
    End Function
#End Region

#Region "BusDate"
    Public Structure BusDate_Config
        Public Btime As Date
        Public Bdate As Date
    End Structure
    Public Function Get_CutOffTime() As BusDate_Config
        Dim x As New BusDate_Config
        x.Btime = CDate(INI.GetString("Bdate", "CutOff", Now.Date))
        x.Bdate = CDate(INI.GetString("Bdate", "Bdate", Now.Date))
        Return x
    End Function
#End Region

#Region "Promo"
    Public Structure Promo_Config
        Public Promo_Timein1 As Date
        Public Promo_Timein2 As Date
        Public Promo_Timeout1 As Date
        Public Promo_Timeout2 As Date
        Public Promo_Price As Double
        Public Promo_Enabled As Boolean
        Public Promo_Vehicle1 As String
        Public Promo_Vehicle2 As String
        Public Promo_Vehicle3 As String
        Public Promo_Vehicle4 As String
        Public Promo_Vehicle5 As String
        Public Promo_Vehicle6 As String
        Public Promo_Vehicle7 As String
        Public Promo_Vehicle8 As String
        Public Promo_Vehicle9 As String
        Public Promo_Vehicle0 As String

        Public Promo_Sunday As Boolean
        Public Promo_Monday As Boolean
        Public Promo_Tuesday As Boolean
        Public Promo_Wednesday As Boolean
        Public Promo_Thursday As Boolean
        Public Promo_Friday As Boolean
        Public Promo_Saturday As Boolean

        Public Promo_Holiday1 As String
        Public Promo_Holiday2 As String
        Public Promo_Holiday3 As String
        Public Promo_Holiday4 As String
        Public Promo_Holiday5 As String
        

    End Structure
    Public Function Get_Promo() As Promo_Config
        Dim x As New Promo_Config
        x.Promo_Timein1 = CDate(INI.GetString("PROMO", "i1", Now.ToShortTimeString))
        x.Promo_Timein2 = CDate(INI.GetString("PROMO", "i2", Now.ToShortTimeString))
        x.Promo_Timeout1 = CDate(INI.GetString("PROMO", "o1", Now.ToShortTimeString))
        x.Promo_Timeout2 = CDate(INI.GetString("PROMO", "o2", Now.ToShortTimeString))
        x.Promo_Price = CDbl(INI.GetString("PROMO", "Amount", 0))
        x.Promo_Enabled = CBool(INI.GetString("PROMO", "Enabled", True))
        x.Promo_Vehicle0 = CStr(INI.GetString("PROMO VEHICLES", "Vehicle0", vbNullString))
        x.Promo_Vehicle1 = CStr(INI.GetString("PROMO VEHICLES", "Vehicle1", vbNullString))
        x.Promo_Vehicle2 = CStr(INI.GetString("PROMO VEHICLES", "Vehicle2", vbNullString))
        x.Promo_Vehicle3 = CStr(INI.GetString("PROMO VEHICLES", "Vehicle3", vbNullString))
        x.Promo_Vehicle4 = CStr(INI.GetString("PROMO VEHICLES", "Vehicle4", vbNullString))
        x.Promo_Vehicle5 = CStr(INI.GetString("PROMO VEHICLES", "Vehicle5", vbNullString))
        x.Promo_Vehicle6 = CStr(INI.GetString("PROMO VEHICLES", "Vehicle6", vbNullString))
        x.Promo_Vehicle7 = CStr(INI.GetString("PROMO VEHICLES", "Vehicle7", vbNullString))
        x.Promo_Vehicle8 = CStr(INI.GetString("PROMO VEHICLES", "Vehicle8", vbNullString))
        x.Promo_Vehicle9 = CStr(INI.GetString("PROMO VEHICLES", "Vehicle9", vbNullString))
        x.Promo_Sunday = CBool(INI.GetString("PROMO DAYS", "Sunday", False))
        x.Promo_Monday = CBool(INI.GetString("PROMO DAYS", "Monday", False))
        x.Promo_Tuesday = CBool(INI.GetString("PROMO DAYS", "Tuesday", False))
        x.Promo_Wednesday = CBool(INI.GetString("PROMO DAYS", "Wednesday", False))
        x.Promo_Thursday = CBool(INI.GetString("PROMO DAYS", "Thursday", False))
        x.Promo_Friday = CBool(INI.GetString("PROMO DAYS", "Friday", False))
        x.Promo_Saturday = CBool(INI.GetString("PROMO DAYS", "Saturday", False))
        x.Promo_Holiday1 = (INI.GetString("NO PROMO DAYS", "Holiday1", vbNullString))
        x.Promo_Holiday2 = (INI.GetString("NO PROMO DAYS", "Holiday2", vbNullString))
        x.Promo_Holiday3 = (INI.GetString("NO PROMO DAYS", "Holiday3", vbNullString))
        x.Promo_Holiday4 = (INI.GetString("NO PROMO DAYS", "Holiday4", vbNullString))
        x.Promo_Holiday5 = (INI.GetString("NO PROMO DAYS", "Holiday5", vbNullString))
      
       
        Return x

    End Function

#End Region

#Region "Digital IO Config"
    Public Structure GPIO_Config
        Public FourWheels_Code As Integer
        Public TwoWheels_Code As Integer
        Public FourWheels_Button As Integer
        Public TwoWheels_Button As Integer
        Public Barrier_Pin As Integer
        Public Barrier_Pin2 As Integer
        Public VehFront_Pin As Integer
        Public GPIO_Delay As Integer
        Public GPIO_Delay2 As Integer
        Public Input_Pins As String
        Public Trigger_Times As Integer
        Public Trigger_Times2 As Integer

    End Structure

    Public Function Get_GPIO_Config() As GPIO_Config
        Dim x As New GPIO_Config
        x.FourWheels_Code = INI.GetInteger("GPIO", "CODE1", 255)
        x.FourWheels_Button = INI.GetInteger("GPIO", "BUTTON1", 255)
        x.TwoWheels_Code = INI.GetInteger("GPIO", "CODE2", 255)
        x.TwoWheels_Button = INI.GetInteger("GPIO", "BUTTON2", 255)
        x.Barrier_Pin = INI.GetInteger("GPIO", "BARPIN", 7)
        x.Barrier_Pin2 = INI.GetInteger("GPIO", "BARPIN2", 8)
        x.VehFront_Pin = INI.GetInteger("GPIO", "VFPIN", 255)
        x.GPIO_Delay = INI.GetInteger("GPIO", "DELAY", 500)
        x.GPIO_Delay2 = INI.GetInteger("GPIO", "DELAY2", 500)
        x.Input_Pins = INI.GetString("GPIO", "PINS", "01111111")
        x.Trigger_Times = INI.GetInteger("GPIO", "TIMES", 1)
        x.Trigger_Times2 = INI.GetInteger("GPIO", "TIMES2", 1)
        Return x
    End Function
#End Region

End Module

