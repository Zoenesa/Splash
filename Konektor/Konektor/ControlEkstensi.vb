Imports System.IO
Imports System.Reflection

Public NotInheritable Class ControlEkstensi

    Public Shared Sub Extract(Current_Namespace As String, Extract_Path As String, internalFilePath As String, Resource_Name As String)
        Dim ass As Assembly = Assembly.GetExecutingAssembly()
        Using s = ass.GetManifestResourceStream(Current_Namespace + "." + (If(internalFilePath = String.Empty, String.Empty, internalFilePath + ".")) + Resource_Name)
            Using r As New BinaryReader(s)
                Using fs As New FileStream(Extract_Path + "\" + Resource_Name, FileMode.OpenOrCreate)
                    Using w As New BinaryWriter(fs)
                        w.Write(r.ReadBytes(CInt(s.Length)))
                    End Using
                End Using
            End Using
        End Using
    End Sub

    Public Overloads Shared Sub DoubleBuffered(datagrid As System.Windows.Forms.DataGridView, Setting As Boolean)
        Dim dgvType As Type = datagrid.[GetType]()
        Dim propInfo As PropertyInfo = dgvType.GetProperty("DoubleBuffered", BindingFlags.Instance Or BindingFlags.NonPublic)
        propInfo.SetValue(datagrid, Setting, Nothing)

    End Sub

    Public Overloads Shared Sub DoubelBuffered(ByVal control As System.Windows.Forms.Control, ByVal enable As Boolean)
        control.GetType.GetProperty("DoubleBuffered", (BindingFlags.NonPublic Or BindingFlags.Instance)).SetValue(control, Nothing)
    End Sub

End Class

