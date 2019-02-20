Public Class Form1
    Private Sub tombolPelanggan_MouseHover(sender As Object, e As EventArgs) Handles tombolPelanggan.MouseHover
        panelPelanggan.BackColor = Color.FromArgb(255, 192, 255, 192)
    End Sub

    Private Sub tombolPelanggan_MouseLeave(sender As Object, e As EventArgs) Handles tombolPelanggan.MouseLeave
        panelPelanggan.BackColor = Color.Transparent
    End Sub

    Private Sub tombolCatatMeter_MouseHover(sender As Object, e As EventArgs) Handles tombolCatatMeter.MouseHover
        panelCatatMeter.BackColor = Color.FromArgb(255, 192, 255, 192)
    End Sub

    Private Sub tombolCatatMeter_MouseLeave(sender As Object, e As EventArgs) Handles tombolCatatMeter.MouseLeave
        panelCatatMeter.BackColor = Color.Transparent
    End Sub

    Private Sub tombolKasir_MouseHover(sender As Object, e As EventArgs) Handles tombolKasir.MouseHover
        panelKasir.BackColor = Color.FromArgb(255, 192, 255, 192)
    End Sub

    Private Sub tombolKasir_MouseLeave(sender As Object, e As EventArgs) Handles tombolKasir.MouseLeave
        panelKasir.BackColor = Color.Transparent
    End Sub

    Private Sub tombolLaporan_MouseHover(sender As Object, e As EventArgs) Handles tombolLaporan.MouseHover
        panelLaporan.BackColor = Color.FromArgb(255, 192, 255, 192)
    End Sub

    Private Sub tombolLaporan_MouseLeave(sender As Object, e As EventArgs) Handles tombolLaporan.MouseLeave
        panelLaporan.BackColor = Color.Transparent
    End Sub

    Private Sub tombolSetting_MouseHover(sender As Object, e As EventArgs) Handles tombolSetting.MouseHover
        panelSetting.BackColor = Color.FromArgb(255, 192, 255, 192)
    End Sub

    Private Sub tombolSetting_MouseLeave(sender As Object, e As EventArgs) Handles tombolSetting.MouseLeave
        panelSetting.BackColor = Color.Transparent
    End Sub

    Private Sub tombolPelanggan_Click(sender As Object, e As EventArgs) Handles tombolPelanggan.Click
        panelMenuPelanggan.Visible = True
        panelMenuCatatMeter.Visible = False
        panelMenuKasir.Visible = False
        panelMenuLaporan.Visible = False
    End Sub

    Private Sub tombolCatatMeter_Click(sender As Object, e As EventArgs) Handles tombolCatatMeter.Click
        panelMenuPelanggan.Visible = False
        panelMenuCatatMeter.Visible = True
        panelMenuKasir.Visible = False
        panelMenuLaporan.Visible = False
    End Sub

    Private Sub tombolKasir_Click(sender As Object, e As EventArgs) Handles tombolKasir.Click
        panelMenuPelanggan.Visible = False
        panelMenuCatatMeter.Visible = False
        panelMenuKasir.Visible = True
        panelMenuLaporan.Visible = False
    End Sub

    Private Sub tombolLaporan_Click(sender As Object, e As EventArgs) Handles tombolLaporan.Click
        panelMenuPelanggan.Visible = False
        panelMenuCatatMeter.Visible = False
        panelMenuKasir.Visible = False
        panelMenuLaporan.Visible = True
    End Sub
End Class
