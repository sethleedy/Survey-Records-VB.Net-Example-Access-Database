Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DsSurvey.Survey' table. You can move, or remove it, as needed.
        Me.SurveyTableAdapter.Fill(Me.DsSurvey.Survey)

        Label1.Text = bindingNavigator1.CountItem.Text.subString(3)

    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Try
            SurveyBindingSource.EndEdit()
            SurveyTableAdapter.Update(DsSurvey.Survey)
            MessageBox.Show("Saved")
            Me.SurveyTableAdapter.Fill(Me.DsSurvey.Survey)
            Label1.Text = BindingNavigator1.CountItem.Text
        Catch ex As Exception
            MessageBox.Show("Error")
        End Try
    End Sub

 
    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click

        BindingNavigatorMovePreviousItem.PerformClick()
        Label1.Text = BindingNavigator1.CountItem.Text.Substring(3)

    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        BindingNavigatorMoveNextItem.PerformClick()
        Label1.Text = BindingNavigator1.CountItem.Text.Substring(3)
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        BindingNavigatorAddNewItem.PerformClick()

        Label1.Text = BindingNavigator1.CountItem.Text.Substring(3)

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        BindingNavigatorDeleteItem.PerformClick()
        Label1.Text = BindingNavigator1.CountItem.Text.Substring(3)
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ToolStripButton1.PerformClick()
        Label1.Text = BindingNavigator1.CountItem.Text.Substring(3)
    End Sub
End Class
