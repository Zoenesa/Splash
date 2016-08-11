Imports System, System.Reflection, System.Text, System.Threading
Imports Microsoft, Microsoft.VisualBasic, Microsoft.VisualBasic.CompilerServices
Imports System.Runtime, System.Runtime.CompilerServices, System.Runtime.InteropServices
Imports Telerik, Telerik.WinControls.UI

Public Class FrmArrangeColumns

    Private Sub FrmArrangeColumns_Load(sender As Object, e As EventArgs) Handles Me.Load
        'btnRemAll.Visible = False
        'btnAppAll.Visible = False
        BufferMethod.DoubleBuffered(rFormDataListInvoice.dg, True)
        CurrentList.Items.Clear()
        'frmListInvoice.DataColumns()
        For i As Integer = 0 To rFormDataListInvoice.dg.Columns.Count - 1
            CurrentList.Items.Add(dg.Columns.Item(i).HeaderText)
        Next i
    End Sub

    Private Sub btnApply_Click(sender As Object, e As EventArgs) Handles btnApply.Click
        Dim List As New List(Of Object)
        For Each Item As Object In CurrentList.Items
            List.Add(Item)
        Next
        'Dim sb As StringBuilder

        Dim Num As Integer = 0
        Dim Num2 As Integer = CurrentList.Items.Count - 1
        Dim Values As String() = New String((CurrentList.Items.Count)) {}
        rFormDataListInvoice.dg.Columns.Clear()
        Dim Str As String = "Col"
        Do While (Num <= Num2)
            'Values(Num) = Conversions.ToString(List.IndexOf(CurrentList.Items.Item(Num).Text))
            rFormDataListInvoice.dg.Columns.Add(Str & (Num), CurrentList.Items.Item(Num).Text)
            Interlocked.Increment(Num)
        Loop
        Me.Close()
    End Sub

    Private Sub btnRem_Click(sender As Object, e As EventArgs) Handles btnRem.Click
        'RadLabel1.Text = "= " & CurrentList.Items.Count
        'RadLabel2.Text = "= " & dg.Columns.Count
        Dim List As New List(Of Object)
        For Each Item As Object In CurrentList.SelectedItems
            List.Add(Item)
        Next
        For Each Item As RadListDataItem In List
            HideList.Items.Add(Item.Text)
            CurrentList.Items.Remove(Item)
        Next
    End Sub

    Private Sub btnAppend_Click(sender As Object, e As EventArgs) Handles btnAppend.Click
        'RadLabel1.Text = "= " & CurrentList.Items.Count
        'RadLabel2.Text = "= " & dg.Columns.Count
        Dim List As New List(Of Object)
        For Each Item As Object In HideList.SelectedItems
            List.Add(Item)
        Next
        For Each Item As RadListDataItem In List
            CurrentList.Items.Add(Item.Text)
            HideList.Items.Remove(Item)
        Next
    End Sub

    Private Sub MoveLeftAll(ByVal sender As Object, e As EventArgs) Handles btnRemAll.Click
        'RadLabel1.Text = "= " & CurrentList.Items.Count
        'RadLabel2.Text = "= " & dg.Columns.Count
        HideList.Items.Clear()
        For Each Item As RadListDataItem In CurrentList.Items
            HideList.Items.Add(Item.Text)
        Next
        CurrentList.Items.Clear()

    End Sub

    Private Sub AddRightAll(ByVal sender As Object, e As EventArgs) Handles btnAppAll.Click
        'RadLabel1.Text = "= " & CurrentList.Items.Count
        'RadLabel2.Text = "= " & dg.Columns.Count
        CurrentList.Items.Clear()
        For Each Item As RadListDataItem In HideList.Items
            CurrentList.Items.Add(Item.Text)
        Next
        HideList.Items.Clear()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class

''' <summary>
''' method for remove any flickering on form loading
''' </summary>
''' <remarks></remarks>
Public NotInheritable Class BufferMethod
    Public Shared Sub DoubleBuffered(dgView As DataGridView, Setting As Boolean)
        Dim dgvType As Type = dgView.[GetType]()
        Dim propInfo As PropertyInfo = dgvType.GetProperty("DoubleBuffered", BindingFlags.Instance Or BindingFlags.NonPublic)
        propInfo.SetValue(dgView, Setting, Nothing)
    End Sub
End Class

