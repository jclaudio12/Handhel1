Imports System.Text
Imports System.Drawing
Imports System.Threading
Imports ZSDK_API.Printer
Imports System
Imports System.IO
Imports InTheHand.net
Imports System.Runtime.InteropServices
Imports ZSDK_API.Comm
Imports ZSDK_API.ApiException
Imports InTheHand.Net.Sockets
Imports InTheHand.Net.Bluetooth
Imports System.IO.Ports


Public Class Form1
    Inherits System.Windows.Forms.Form
    Public enc As String

    Private Sub Test_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Test.Click
        Try
            ' SendZplOverBluetooth("0C61CF24B288")
            'SendCpclOverBluetooth("0C61CF24B288")
            temp_imp("0C61CF24B074")
            'Dim myMacAddress As String = "0C61CF24B288"

            'Dim zebraPrinterConnection As ZebraPrinterConnection = New SerialPrinterConnection("COM5")
            'zebraPrinterConnection.Open()
            'Dim printer As ZebraPrinter = ZebraPrinterFactory.GetInstance(zebraPrinterConnection)
            'Dim zplCadena As String = ""
            'Dim zplCadena2 As String = ""
            'zplCadena += "! 0 200 200 240 1\r\n"
            'zplCadena += "LABEL\r\n"
            'zplCadena += "CONTRAST 0\r\n"
            'zplCadena += "TONE 0\r\n"
            'zplCadena += "SPEED 5\r\n"
            'zplCadena += "SETFF 10\r\n"
            'zplCadena += "PAGE-WIDTH 380\r\n"
            'zplCadena += "BAR-SENSE\r\n"
            'zplCadena += ";// PAGE 0000000003800240\r\n"
            'zplCadena += "BOX 56 9 280 63 1\r\n"
            'zplCadena += ";//{{BEGIN-BT\r\n"
            'zplCadena += "T 0 0 93 17 Texto de prueba.\r\n"
            'zplCadena += "T 0 0 93 37 Funciona!\r\n"
            'zplCadena += ";//{{END-BT\r\n"

            'zplCadena2 += "T 7 0 122 215 Funciona\r\n"
            ''zplCadena2 += "FORM\r\n";
            'zplCadena2 += "PRINT\r\n"

            'zebraPrinterConnection.Write(Encoding.Default.GetBytes(zplCadena))
            ''printer.GetGraphicsUtil().PrintImage("\\Prueba1.jpg", 250, 0, -1, -1, True)
            'printer.GetFileUtil().SendFileContents(zplCadena)
            'zebraPrinterConnection.Write(Encoding.Default.GetBytes(zplCadena2))

            'zebraPrinterConnection.Close()
        Catch f As Exception
            ' Handle communications error here.
            Console.Write(f.StackTrace)
        End Try
    End Sub
    Private Sub SendZplOverBluetooth(ByVal theBtMacAddress As [String])
        'Dim pText As New StringBuilder
        'pText.AppendLine("N")   ' Nuevo documento
        'pText.AppendLine("D15") ' Densidad
        'pText.AppendLine("S1")  ' Velocidad
        'pText.AppendLine("A30,120,0,4,2,1,N,""print text""") ' imprime texto
        'pText.AppendLine("B30,20,0,1,2,5,80,N,""print barcode""") ' imprime codigo de barra
        'pText.AppendLine("P1") ' número de veces que imprime
        'RawPrinter.SendToPrinter("zebra printing", pText.ToString, "\\printerserver\printername") 'imprime el string

        Try
            ' Instantiate a connection for given Bluetooth(R) MAC Address.
            Dim thePrinterConn As ZebraPrinterConnection = New BluetoothPrinterConnection(theBtMacAddress)

            ' Open the connection - physical connection is established here.
            thePrinterConn.Open()

            ' Defines the ZPL data to be sent.
            Dim zplData As [String] = "^XA^FO20,20^A0N,25,25^FDThis is a ZPL test.^FS^XZ"

            ' Send the data to a printer as a byte array.
            thePrinterConn.Write(Encoding.[Default].GetBytes(zplData))

            ' Make sure the data got to the printer before closing the connection
            Thread.Sleep(500)

            ' Close the connection to release resources.


            thePrinterConn.Close()
        Catch e As Exception

            ' Handle communications error here.
            Console.Write(e.StackTrace)
        End Try

    End Sub
    Private Sub SendCpclOverBluetooth(ByVal theBtMacAddress As [String])
        Try
            ' Instantiate a connection for given Bluetooth(R) MAC Address.
            Dim thePrinterConn As ZebraPrinterConnection = New BluetoothPrinterConnection(theBtMacAddress)

            ' Open the connection - physical connection is established here.
            thePrinterConn.Open()

            ' Defines the CPCL data to be sent.
            Dim cpclData As [String] = "! 0 200 200 406 1" & vbCr & vbLf & "TEXT 4 0 30 40 Prueba EPSA." & vbCr & vbLf & "FORM" & vbCr & vbLf & "PRINT" & vbCr & vbLf

            ' Send the data to printer as a byte array.
            thePrinterConn.Write(Encoding.[Default].GetBytes(cpclData))

            'Make sure the data got to the printer before closing the connection
            Thread.Sleep(500)

            ' Close the connection to release resources.


            thePrinterConn.Close()
        Catch e As Exception

            ' Handle communications error here.
            Console.Write(e.StackTrace)
        End Try
    End Sub
    Private Sub temp_imp(ByVal theBtMacAddress As [String])
        Try
            ' Instantiate a connection for given Bluetooth(R) MAC Address.
            Dim thePrinterConn As ZebraPrinterConnection = New BluetoothPrinterConnection(theBtMacAddress)

            ' Open the connection - physical connection is established here.
            thePrinterConn.Open()

            ' Defines the CPCL data to be sent.
            'Dim cpclData As [String] = "! 0 200 200 210 1" & vbCr & vbLf & "TEXT 4 0 30 40 Prueba EPSA." & vbCr & vbLf & "FORM" & vbCr & vbLf & "PRINT" & vbCr & vbLf

            ' Send the data to printer as a byte array.
            'thePrinterConn.Write(Encoding.[Default].GetBytes(cpclData))
            '-- Dim cpclLabel As Byte() = Encoding.[Default].GetBytes("! 0 200 200 406 1" & vbCrLf & "ON-FEED IGNORE" & vbCrLf & "BOX 20 20 380 380 8" & vbCrLf & "T 0 6 137 177 TEST" & vbCrLf & "PRINT" & vbCrLf)

            ' Dim pag As String = """! 0 200 200 200 1"" & vbCrLf & ""PAGE-WIDTH 600 "" & vbCrLf & ""CENTER"" & vbCrLf & ""T 5 0 1 10 EL PILAR S.A."" & vbCrLf & ""PRINT"" & vbCrLf"
            Dim star = "! 0 200 200 200 1"
            Dim page = "PAGE-WIDTH 600"
            Dim aling = "CENTER"
            Dim print = "PRINT" & vbCrLf
            Dim v = vbCrLf

            Dim x = 2
            If x = 1 Then
                Dim empresa = "T 5 0 1 10 EL PILAR S.A."
                enc = star & v & page & v & aling & v & empresa & v & print & v
            Else
                Dim empresa2 = "T 5 0 1 10 MONTE MARIA S.A."
                enc = star & v & page & v & aling & v & empresa2 & v & print & v
            End If
            'Dim cpclLabel As Byte() = Encoding.[Default].GetBytes("! 0 200 200 600 1" & vbCrLf & "PAGE-WIDTH 600" & vbCrLf & "CENTER" & vbCrLf & "T 4 0 1 10 INGENIO EL PILAR S.A." & vbCrLf & "T 5 0 1 55 NOTA ENVIO DE CAÑA TRAMERO" & vbCrLf & "LEFT" & vbCrLf & "T 5 0 1 90 NO. ENVIO: 000704" & vbCrLf & "T 5 0 300 90 SERIE:11AIT" & vbCrLf & "T 5 0 1 120 FECHA: 28/12/2018 00:13" & vbCrLf & "T 5 0 1 150 FINCA: 306 SANTA ISABEL SININA NO. 1" & vbCrLf & "T 5 0 1 180 CROQUIS: 00000000" & vbCrLf & "T 5 0 1 210 ORDEN CORTE: 00001498" & vbCrLf & "T 5 0 1 240 TRANSPORTISTA: 0561" & vbCrLf & "T 5 0 1 270 PILOTO: 001" & vbCrLf & "T 5 0 1 300 VEHICULO: 017" & vbCrLf & "T 5 0 300 300 PLACAS: 960BBB" & vbCrLf & "T 5 0 1 330 STICKER: " & vbCrLf & "T 5 0 1 360 FRENTE: 302" & vbCrLf & "T 5 0 1 390 BOLETA DE TRANSPORTE: 0000000" & vbCrLf & "T 5 0 1 420 RUTA: 001" & vbCrLf & "T 5 0 1 450 CONTRATISTA: 0679" & vbCrLf & "T 5 0 1 480 HORA DE DESPACHO: 00:13" & vbCrLf & "T 5 0 1 510 CUADRILLA: 1" & vbCrLf & "PRINT" & vbCrLf)
            'Dim cpclLabel As Byte() = Encoding.[Default].GetBytes("! 0 200 200 200 1" & vbCrLf & "PAGE-WIDTH 600" & vbCrLf & "CENTER" & vbCrLf & "T 5 0 1 10 EL PILAR S.A." & vbCrLf & "PRINT" & vbCrLf)
            'Dim cpclLabel As Byte() = Encoding.[Default].GetBytes("! 0 200 200 200 1" & vbCrLf & "PAGE-WIDTH 600" & vbCrLf & "CENTER" & vbCrLf & "T 5 0 1 10 EL PILAR S.A." & vbCrLf & "PRINT" & vbCrLf)

            Dim cpclLabel As Byte() = Encoding.[Default].GetBytes(enc)


            ' Dim cpclLabe2 As Byte() = Encoding.[Default].GetBytes("! 0 200 200 50 1" & vbCrLf & "PAG-WIDTH 600" & vbCrLf & "CENTER" & vbCrLf & "T 4 0 1 90 Envios Caña Tramero" & vbCrLf & "PRINT" & vbCrLf)
            'Dim cpclLabel As Byte() = Encoding.[Default].GetBytes("! 0 200 200 210 1" & vbCrLf & "ON-FEED IGNORE" & vbCrLf & "T 0 6 137 177 TEST" & vbCrLf & "PRINT" & vbCrLf)

            ''Dim cpclDataQR As [String] = "! 0 200 200 500 1" & vbCr & vbLf & "B QR 10 100 M 2 U 10 " & vbCr & vbLf & "MA,QR Code Prueba_EPSA" & vbCr & vbLf & "ENDQR" & vbCr & vbLf & "FORM" & vbCr & vbLf & "PRINT" & vbCr & vbLf
            'Dim cpclDataQR As [String] = "! 0 200 200 500 1" & vbCr & vbLf & "B QR 10 100 M 2 U 10 " & vbCr & vbLf & "MA,QR code EPSA123 " & vbCr & vbLf & "ENDQR" & vbCr & vbLf & "T 4 0 10 10 QR code EPSA123 " & vbCr & vbLf & "FORM" & vbCr & vbLf & "PRINT" & vbCr & vbLf
            'Dim cpclDataQR As [String] = "! 0 200 200 500 1" & vbCr & vbLf & "B QR 10 100 M 2 U 10 " & vbCr & vbLf & "MA,QR code EPSA123 " & vbCr & vbLf & "ENDQR" & vbCr & vbLf & "T 4 0 10 10 QR code EPSA123 " & vbCr & vbLf & "PRINT" & vbCr & vbLf

            ' prueba tamaño fuente


            thePrinterConn.Write(cpclLabel, 0, cpclLabel.Length)
            'thePrinterConn.Write(cpclLabe2, 0, cpclLabe2.Length)

            'thePrinterConn.Write(Encoding.[Default].GetBytes(cpclDataQR))
            'Make sure the data got to the printer before closing the connection
            Thread.Sleep(500)

            ' Close the connection to release resources.


            thePrinterConn.Close()
        Catch e As Exception

            ' Handle communications error here.
            Console.Write(e.StackTrace)
        End Try

    End Sub



End Class
