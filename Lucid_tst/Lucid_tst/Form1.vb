Imports System.IO.Ports
Imports System.Threading

Public Class Form1
    Dim time As Double

    Dim _counter As Integer = 0
    Dim myPort As Array  'COM Ports detected on the system will be stored here

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '--
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        GetIO()                                 'Get the feedback value
    End Sub
    Private Sub GetIO()
        Dim GetIo(4) As Byte   'Get-Voltage, see Page 22 en 23

        If SerialPort1.IsOpen Then
            '--------- prepare request to Lucid Control------
            GetIo(1) = &H46   'OPC= GetIoGroup
            GetIo(2) = &H0    'Channel 1

            'GetIo(3) = &H1C  'Voltage range 0-30,000 mV (2Bytes)
            GetIo(3) = &H1D  'Voltage range 0-100,000,000 mV (4Bytes)
            ' GetIo(3) = &H23   'Amp range 0-1,000,000 mAmp (4Bytes)
        End If
        GetIo(4) = &H0    'LEN

        '-------LucidControl AI4, Input module -------------
        Try
            SerialPort1.Write(GetIo, 1, 4)
            Thread.Sleep(10)
        Catch generatedExceptionName As TimeoutException
        End Try
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        'Find ports----------
        combo_Port1.SelectedIndex = -1  'To instruments
        combo_Port1.Items.Clear()
        Serial_setup()
    End Sub

    Private Sub Serial_setup()                  'Serial ports setup
        combo_Baud.Items.Clear()
        If (SerialPort1.IsOpen = True) Then     'Write to Instruments
            SerialPort1.DiscardInBuffer()       'Preventing exceptions
            SerialPort1.Close()
        End If

        Try
            myPort = SerialPort.GetPortNames() 'Get all com ports available
            For Each port In myPort
                combo_Port1.Items.Add(port)
            Next port
            combo_Port1.Text = CType(combo_Port1.Items.Item(0), String)    'Set cmbPort text to the first COM port detected
        Catch ex As Exception
            MsgBox("No COM ports detected")
        End Try

        combo_Baud.Items.Add(9600)     'Populate the cmbBaud Combo box to common baud rates used
        combo_Baud.Items.Add(19200)
        combo_Baud.Items.Add(38400)
        combo_Baud.Items.Add(57600)
        combo_Baud.Items.Add(115200)
        combo_Baud.SelectedIndex = 0    'Set cmbBaud text to 9600 Baud 
    End Sub

    Private Sub BtnConnect_Click(sender As System.Object, e As System.EventArgs) Handles Button12.Click
        'Connect
        If combo_Port1.Text.Length = 0 Then
            MsgBox("Sorry, did not find any connected Lucid Controllers")
        Else
            SerialPort1.PortName = combo_Port1.Text         'Set SerialPort1 to the selected COM port at startup
            SerialPort1.BaudRate = CInt(combo_Baud.Text)    'Set Baud rate to the selected value on
            SerialPort1.Parity = Parity.None
            SerialPort1.StopBits = StopBits.One
            SerialPort1.Handshake = Handshake.None
            SerialPort1.DataBits = 8                        'Open our serial port
            SerialPort1.ReadBufferSize = 8192               '4096
            SerialPort1.ReceivedBytesThreshold = 1
            SerialPort1.DiscardNull = True                 'important otherwise it will not work
            SerialPort1.ReadTimeout = 500
            SerialPort1.WriteTimeout = 500

            Try
                SerialPort1.Open()
                Button12.Enabled = False              'Disable Connect button
                Button12.BackColor = Color.Yellow
                Button12.Text = "OK connected"
                btnDisconnect.Enabled = True            'and Enable Disconnect button
            Catch ex As Exception
                MsgBox("Error 654 Open: " & ex.Message)
            End Try

            Label94.BackColor = CType(IIf(SerialPort1.IsOpen, Color.Yellow, Color.Red), Color)  'Port1
        End If
    End Sub

    Private Sub BtnDisconnect_Click(sender As System.Object, e As System.EventArgs) Handles btnDisconnect.Click
        'Disconnect ports
        Try
            SerialPort1.DiscardInBuffer()
            SerialPort1.Close()             'Close our Serial Port
            SerialPort1.Dispose()

            Button12.Enabled = True
            Button12.BackColor = Color.Red
            Label94.BackColor = Color.White 'Port 1

            Button12.Text = "Connect"
            btnDisconnect.Enabled = False
        Catch ex As Exception
            MsgBox("Error 104 Open: " & ex.Message)
        End Try
    End Sub

    Private Sub SerialPort1_DataReceived(sender As System.Object, e As SerialDataReceivedEventArgs) Handles SerialPort1.DataReceived
        Dim intext As String = String.Empty
        Dim intext_hex As String = String.Empty
        Dim status_code As String = String.Empty
        Dim bigE As String = String.Empty
        Dim status_OK As String = "00"
        Dim Value_channel_0_hex As String  'Lucid-Control AI4, 10V module
        Dim Value_channel_0_dec As Double  'Lucid-Control AI4, 10V module

        Try
            intext_hex = SerialPort1.ReadExisting                  'Read the data
            'intext_hex = String_Hex_to_ascii("0004" & "A0252600")  'Test value 2.50  (is OK)
            'intext_hex = String_Hex_to_ascii("0004" & "404b4c00")  'Test value 5.00  (is OK)
            'intext_hex = String_Hex_to_ascii("0004" & "40548900")  'Test value 9.00  (is OK)
            'intext_hex = String_Hex_to_ascii("0004" & "002D3101")  'Test value 20.0  (is OK)
            intext = String_ascii_to_Hex_ascii2(intext_hex)         'Convert data to hex
        Catch generatedExceptionName As TimeoutException
        End Try

        Invoke(Sub() TextBox39.Text = intext)

        '---------- instring OK then continue------
        If (intext.Length = 12) Then
            '---------- Test value -----------
            'intext = "0004" & "D0121300"                   'Test value +1.2500 Volt/mA
            'intext = "0004" & "A0252600"                   'Test value +2.5000 Volt/mA
            'intext = "0004" & "404b4c00"                   'Test value +5.000 Volt/mA
            'intext = "0004" & "40548900"                   'Test value +9.000 Volt/mA
            'intext = "0004" & "002D3101"                   'Test value +20.000 Volt/mA
            'intext = "0004" & "C0B4B3FF"                   'Test value -5.000 Volt/mA
            'intext = "0004" & "39FFFFFF"                   'Test value 0.000199 Volt/mA

            Value_channel_0_hex = intext.Substring(4, 8)    'Skip the 4 status bytes
            'MessageBox.Show(Value_channel_0_hex)
            '---- The received value is little-Endian (now reverse order)-----
            bigE = Value_channel_0_hex.Substring(6, 2)
            bigE &= Value_channel_0_hex.Substring(4, 2)
            bigE &= Value_channel_0_hex.Substring(2, 2)
            bigE &= Value_channel_0_hex.Substring(0, 2)

            '---------- calc the value---------
            Value_channel_0_dec = Convert.ToInt32(bigE, 16)         '[microVolt] Channel 0
            Value_channel_0_dec /= 10 ^ 6                           '[micro(V/A)-->Volt] 

            '--------- Present data--------------
            Try
                Invoke(Sub() TextBox38.Text = intext.Substring(4, 8))   'Hex 4 Bytes value
                Invoke(Sub() TextBox38.Text = bigE)                     'Hex 4 Bytes valueTextBox36
                Invoke(Sub() TextBox37.Text = Math.Round(Value_channel_0_dec, 2).ToString("0.000")) 'Value
            Catch ex As Exception
            End Try
        Else
            _counter += 1
            Invoke(Sub() Label1.Text = _counter.ToString & " statuscode=")
            SerialPort1.DiscardInBuffer()        'empty inbuffer
        End If
    End Sub
    'Public Function String_ascii_to_Hex_ascii(Data As String) As String
    '    Dim sVal As String = String.Empty
    '    Dim sHex As String = String.Empty
    '    'see http://stackoverflow.com/questions/14017007/how-to-convert-a-hexadecimal-value-to-ascii
    '    'Example string   Ascii HEX= 0x48 0x45 0x58 = 72 69 88
    '    'Used for information received from Lucid-Control modules
    '    'Convert ascii-String to Hex-string
    '    While Data.Length > 0
    '        sVal = Hex(Strings.Asc(Data.Substring(0, 1).ToString()))
    '        Data = Data.Substring(1)
    '        If sVal.Length < 2 Then
    '            sHex = sHex & "0" & sVal
    '        Else
    '            sHex = sHex & sVal
    '        End If
    '        'sHex = sHex & " "  'for testing
    '    End While
    '    Return sHex
    'End Function

    Public Function String_ascii_to_Hex_ascii2(str As String) As String
        Dim byteArray() As Byte
        Dim hexNumbers As Text.StringBuilder = New Text.StringBuilder
        'byteArray = System.Text.ASCIIEncoding.ASCII.GetBytes(str)
        byteArray = System.Text.Encoding.BigEndianUnicode.GetBytes(str)
        'For i As Integer = 0 To byteArray.Length - 1
        For i As Integer = 1 To byteArray.Length - 1 Step 2
            hexNumbers.Append(byteArray(i).ToString("x2"))
        Next
        Return (hexNumbers.ToString())
    End Function

    Public Function String_Hex_to_ascii(Data As String) As String
        Dim com As String = String.Empty
        'see http://stackoverflow.com/questions/14017007/how-to-convert-a-hexadecimal-value-to-ascii
        'Data = "484558"    'Example string   Ascii HEX= 0x48 0x45 0x58 = 72 69 88

        For x = 0 To Data.Length - 1 Step 2
            com &= ChrW("&H" & Data.Substring(x, 2))
        Next
        Return com
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Timer1.Enabled Then
            Timer1.Stop()       'Freeze
            Button1.Text = "Thaw"
        Else
            Timer1.Start()       'Freeze
            Button1.Text = "Freeze"
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        GetIO()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim intext As String = String.Empty
        Dim intext_hex As String = String.Empty
        Dim hex_str As String = "0123456789abcdef"
        Dim s1 As String

        s1 = "0004" & "404b4c00"
        intext_hex = String_Hex_to_ascii(s1)            'Test value 5.00 Volt (is OK)
        intext = String_ascii_to_Hex_ascii2(intext_hex) 'Convert data to hex
        MessageBox.Show(s1 & vbCrLf & intext)

        s1 = "0004" & "40548900"
        intext_hex = String_Hex_to_ascii(s1)            'Test value 9.00 Volt (is OK)
        intext = String_ascii_to_Hex_ascii2(intext_hex) 'Convert data to hex
        MessageBox.Show(s1 & vbCrLf & intext)

        For i = 0 To hex_str.Length - 1
            s1 = String.Empty
            For j = 0 To hex_str.Length - 1
                s1 &= hex_str.Substring(i, 1) & hex_str.Substring(j, 1)
            Next
            intext_hex = String_Hex_to_ascii(s1)            'Convert data to hex
            intext = String_ascii_to_Hex_ascii2(intext_hex) 'Convert data to hex
            MessageBox.Show(s1 & vbCrLf & intext)
        Next

    End Sub
End Class
