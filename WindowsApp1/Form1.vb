Imports System
Imports System.Xml
Imports System.Diagnostics

Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)
    End Sub

    Private Sub CheckedListBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub NumericUpDown2_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown2.ValueChanged

    End Sub

    Private Sub CheckBox8_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox8.CheckedChanged

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim screenWidth As Integer = Screen.PrimaryScreen.Bounds.Width
        Dim screenHeight As Integer = Screen.PrimaryScreen.Bounds.Height
        NumericUpDown4.Value = screenWidth
        NumericUpDown5.Value = screenHeight
    End Sub

    Private Sub CheckBox9_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox9.CheckedChanged

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub CheckBox10_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox10.CheckedChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim settings As New XmlWriterSettings()
        settings.Indent = True

        Dim filePath As String

        filePath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) & "\Activision\Madagascar 2\Config.xml"


        ' Initialize the XmlWriter.
        Dim XmlWrt As XmlWriter = XmlWriter.Create("alchemy.xml", settings)

        With XmlWrt

            ' Write the Xml declaration.
            .WriteStartDocument()

            ' Write a comment.
            .WriteComment("Madagascar 2 Trainer by CowHax")

            ' Write the root element.
            .WriteStartElement("root")

            ' Begin category Anim
            .WriteStartElement("Anim")

            ' The nodes.
            If CheckBox2.CheckState = 1 Then
                .WriteAttributeString("enableJointGraphSupport", "true")
            Else
                .WriteAttributeString("enableJointGraphSupport", "false")
            End If

            If CheckBox1.CheckState = 1 Then
                .WriteAttributeString("enableBone0MvmWrite", "true")
            Else
                .WriteAttributeString("enableBone0MvmWrite", "false")
            End If

            If CheckBox3.CheckState = 1 Then
                .WriteAttributeString("enableInNodeActorUpdate", "true")
            Else
                .WriteAttributeString("enableInNodeActorUpdate", "false")
            End If

            ' The end of Anim.
            .WriteEndElement()

            ' Begin category Core
            .WriteStartElement("Core")

            ' The nodes.
            If CheckBox4.CheckState = 1 Then
                .WriteAttributeString("blindObjects", "true")
            Else
                .WriteAttributeString("blindObjects", "false")
            End If

            If CheckBox5.CheckState = 1 Then
                .WriteAttributeString("enableCycleFrequencyScaling", "true")
            Else
                .WriteAttributeString("enableCycleFrequencyScaling", "false")
            End If

            ' The end of this node.
            .WriteEndElement()

            ' Begin category Gfx
            .WriteStartElement("Gfx")

            ' The  nodes.
            If CheckBox7.CheckState = 1 Then
                .WriteAttributeString("softwareBlending", "true")
            Else
                .WriteAttributeString("softwareBlending", "false")
            End If

            .WriteAttributeString("dynamicVertexBufferSize", NumericUpDown1.Value)
            .WriteAttributeString("presentationInterval", NumericUpDown2.Value)


            ' The end of Gfx.
            .WriteEndElement()

            ' Begin category Sg
            .WriteStartElement("Sg")

            ' The nodes.
            .WriteAttributeString("geometryAttrListSize", NumericUpDown3.Value)

            ' The end of Sg.
            .WriteEndElement()

            ' Begin category Tfb
            .WriteStartElement("Tfb")

            ' The nodes.
            .WriteAttributeString("startLevel", ComboBox1.Text)

            If CheckBox8.CheckState = 1 Then
                .WriteAttributeString("useGameCamera", "true")
            Else
                .WriteAttributeString("useGameCamera", "false")
            End If

            If CheckBox9.CheckState = 1 Then
                .WriteAttributeString("menuAtStart", "true")
            Else
                .WriteAttributeString("menuAtStart", "false")
            End If

            If CheckBox10.CheckState = 1 Then
                .WriteAttributeString("debug", "true")
            Else
                .WriteAttributeString("debug", "false")
            End If


            ' The end of Tfb.
            .WriteEndElement()

            ' Close the XmlTextWriter.
            .WriteEndDocument()
            .Close()

        End With


        MessageBox.Show("Engine settings saved.")

        ' Initialize the XmlWriter.
        Dim XmlWrt2 As XmlWriter = XmlWriter.Create("Config.xml", settings)

        With XmlWrt2

            ' Write the Xml declaration.
            .WriteStartDocument()

            ' Write a comment.
            .WriteComment("Madagascar 2 Trainer by CowHax")

            ' Write the root element.
            .WriteStartElement("r")

            ' Begin category s1
            .WriteStartElement("s")

            ' The nodes.

            .WriteAttributeString("id", "ScreenWidth")
            .WriteString(NumericUpDown4.Value)

            ' The end of s1.
            .WriteEndElement()

            ' Begin category s2
            .WriteStartElement("s")

            ' The nodes.

            .WriteAttributeString("id", "ScreenHeight")
            .WriteString(NumericUpDown5.Value)

            ' The end of s2.
            .WriteEndElement()

            ' Begin category s3
            .WriteStartElement("s")

            ' The nodes.

            .WriteAttributeString("id", "VideoQuality")
            .WriteString(TrackBar1.Value)

            ' The end of s3.
            .WriteEndElement()

            ' Begin category s4
            .WriteStartElement("s")

            ' The nodes.

            .WriteAttributeString("id", "VideoSettingsSet")
            .WriteString(1)

            ' The end of s4.
            .WriteEndElement()

            ' Close the XmlTextWriter.
            .WriteEndDocument()
            .Close()

        End With

        ' Moves and replaces Config.xml
        If My.Computer.FileSystem.FileExists(filePath) Then
            My.Computer.FileSystem.DeleteFile(filePath)
            My.Computer.FileSystem.MoveFile("Config.xml", filePath)
        Else
            My.Computer.FileSystem.MoveFile("Config.xml", filePath)
        End If
        MessageBox.Show("Graphic settings saved.")
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged

    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox4.CheckedChanged

    End Sub

    Private Sub CheckBox5_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox5.CheckedChanged

    End Sub

    Private Sub CheckBox7_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox7.CheckedChanged

    End Sub

    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown1.ValueChanged

    End Sub

    Private Sub NumericUpDown3_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown3.ValueChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        CheckBox1.CheckState = 1
        CheckBox2.CheckState = 0
        CheckBox3.CheckState = 1
        CheckBox4.CheckState = 1
        CheckBox5.CheckState = 0
        CheckBox7.CheckState = 0
        CheckBox8.CheckState = 1
        CheckBox9.CheckState = 1
        CheckBox10.CheckState = 0
        NumericUpDown1.Value = 2500000
        NumericUpDown2.Value = 1
        NumericUpDown3.Value = 25000
        NumericUpDown4.Value = 640
        NumericUpDown5.Value = 480
        TrackBar1.Value = 1
        ComboBox1.Text = "title"
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub NumericUpDown5_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown5.ValueChanged

    End Sub

    Private Sub NumericUpDown4_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown4.ValueChanged

    End Sub

    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim mad2launcher As Process
        mad2launcher = New Process()
        mad2launcher.Start("Mad2.exe")
    End Sub
End Class
