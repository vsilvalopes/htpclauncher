Imports System.Xml
Public Class Form1

    Dim MediaCenter As Object
    Dim GameCenter As Object
    Dim Steam As Object


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Button1.BackgroundImage = My.Resources.xbmc_off
        Button1.BackgroundImageLayout = ImageLayout.Stretch

        Button2.BackgroundImage = My.Resources.steam_off
        Button2.BackgroundImageLayout = ImageLayout.Stretch

        Button3.BackgroundImage = My.Resources.gameex_off
        Button3.BackgroundImageLayout = ImageLayout.Stretch

        Dim xmlDoc As XmlDocument = New XmlDocument
        xmlDoc.Load(Application.StartupPath + "\config.xml")

        Dim Principal = xmlDoc.DocumentElement

        MediaCenter = Principal("MediaCenter").InnerText
        GameCenter = Principal("GameCenter").InnerText
        Steam = Principal("Steam").InnerText

    End Sub

    Private Sub Button1_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.GotFocus
        Button1.BackgroundImage = My.Resources.xbmc_on
        Button1.BackgroundImageLayout = ImageLayout.Stretch
    End Sub

    Private Sub Button1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.LostFocus
        Button1.BackgroundImage = My.Resources.xbmc_off
        Button1.BackgroundImageLayout = ImageLayout.Stretch
    End Sub

    Private Sub Button2_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.GotFocus
        Button2.BackgroundImage = My.Resources.steam_on
        Button2.BackgroundImageLayout = ImageLayout.Stretch
    End Sub

    Private Sub Button2_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.LostFocus
        Button2.BackgroundImage = My.Resources.steam_off
        Button2.BackgroundImageLayout = ImageLayout.Stretch
    End Sub

    Private Sub Button3_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button3.GotFocus
        Button3.BackgroundImage = My.Resources.gameex_on
        Button3.BackgroundImageLayout = ImageLayout.Stretch
    End Sub

    Private Sub Button3_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button3.LostFocus
        Button3.BackgroundImage = My.Resources.gameex_off
        Button3.BackgroundImageLayout = ImageLayout.Stretch
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim dblRetVal As Double
        dblRetVal = Shell(MediaCenter, vbMaximizedFocus)
        End
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim dblRetVal As Double
        dblRetVal = Shell(Steam, vbMaximizedFocus)
        End
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim dblRetVal As Double
        dblRetVal = Shell(GameCenter, vbMaximizedFocus)
        End
    End Sub
End Class
