Imports Newtonsoft.Json

Public Class Form1
    Private Const strSTUDENTFILE As String = "StudentList.json"
    Private StudentTable As New List(Of Student)
    Private names() As String = {"Aiden", "Alexander", "Anna", "Anthony", "Arlo", "Benjamin", "Bradley", "Brooks", "Chevy", "Collin", "Francis", "Holly", "Logan", "Matthew", "Michael", "Nathan", "Preston", "Srikar", "Tanmay", "Vincent", "Walker", "Zeph"}

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = Color.BlanchedAlmond
        PopulateStudentTable()
        PopulateStudentComboBox()
        UpdateValues()

    End Sub

    Private Sub PopulateStudentComboBox()
        'NEW Add Range - Takes an array so we converted our list to an array and put it in the combo box
        cboStudents.Items.AddRange(StudentTable.ToArray)
    End Sub

    Private Sub PopulateStudentTable()
        'Makes sure the file exists. 
        If IO.File.Exists(strSTUDENTFILE) Then
            LoadStudentTableFromFile()
        Else
            StartFresh()
        End If
    End Sub

    Private Sub LoadStudentTableFromFile()
        'Reading from file
        Dim reader As New IO.StreamReader(strSTUDENTFILE)
        Dim str As String = reader.ReadToEnd
        'NEW
        'Convert json file to collection of objects
        StudentTable = JsonConvert.DeserializeObject(Of List(Of Student))(str)
        reader.Close()
    End Sub

    Private Sub StartFresh()
        For Each s As String In names
            'add a new student object to our dictionary. 
            'For now we will use the name as the key because this list happens to be unique
            StudentTable.Add(New Student(s, New List(Of Donation)))
        Next
    End Sub

    Private Sub cboStudents_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboStudents.SelectedIndexChanged
        UpdateValues()
    End Sub

    Private Sub UpdateValues()
        Dim s As Student = cboStudents.SelectedItem
        'NEW IsNothing -> makes sure an object actually exists in the variable
        If Not IsNothing(s) Then
            LoadDonationListBox()
            lblStudentTotal.Text = s.GetTotalDonations().ToString("C2")
            'find total class donations
            lblClassTotal.Text = GetClassTotalDonations.ToString("C2")
        End If
        'Load the label with top donors
        PopulateTopDonors()
    End Sub

    Private Sub PopulateTopDonors()
        lblHighest.Text = ""
        'find the top 5 donors
        'Sort our list of students by donation
        'NEW Sorting a list of objects
        StudentTable.Sort(Function(x, y) y.GetTotalDonations.CompareTo(x.GetTotalDonations))
        Dim i As Integer = 0
        While i < 5 AndAlso StudentTable(i).GetTotalDonations > 0
            Dim s As Student = StudentTable(i)
            lblHighest.ForeColor = Color.Red
            lblHighest.Text = $"{lblHighest.Text}{s.Name.PadRight(10)} {s.GetTotalDonations.ToString("C2").PadLeft(8)}{vbNewLine}"
            i += 1
        End While
    End Sub

    Private Function GetClassTotalDonations() As Double
        Dim total As Double = 0
        'loop through students and sum total donations 
        For Each s As Student In StudentTable
            total = total + s.GetTotalDonations
        Next
        Return total
    End Function

    Private Sub LoadDonationListBox()
        lstStudentDonations.Items.Clear()
        Dim s As Student = cboStudents.SelectedItem
        lstStudentDonations.Items.AddRange(s.Donations.ToArray)
        lstStudentDonations.ForeColor = Color.Wheat
    End Sub

    Private Sub btnDonate_Click(sender As Object, e As EventArgs) Handles btnDonate.Click
        Dim amt As Double
        Dim valid As Boolean = Double.TryParse(txtDontionAMt.Text, amt)
        If valid Then
            Dim s As Student = cboStudents.SelectedItem
            s.Donations.Add(New Donation(amt, Date.Now))
        End If
        UpdateValues()
    End Sub

    Private Sub SaveFile()
        Dim json As String = JsonConvert.SerializeObject(cboStudents.Items)
        Dim writer = New IO.StreamWriter(strSTUDENTFILE)
        writer.Write(json)
        writer.Close()
    End Sub

    Private Sub Form1_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        SaveFile()
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        Dim s As Student = cboStudents.SelectedItem
        Dim d As Donation = lstStudentDonations.SelectedItem
        If Not IsNothing(s) AndAlso Not IsNothing(d) Then
            s.Donations.Remove(d)
            UpdateValues()
        End If


    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class

Public Class Student
    Private _name As String
    Private _donations As List(Of Donation)


    Public Sub New(name As String, donations As List(Of Donation))
        Me.Name = name
        Me.Donations = donations
    End Sub

    Public Property Name As String
        Get
            Return _name
        End Get
        Set(value As String)
            _name = value
        End Set
    End Property

    Public Property Donations As List(Of Donation)
        Get
            Return _donations
        End Get
        Set(value As List(Of Donation))
            _donations = value
        End Set
    End Property

    Public Function GetTotalDonations() As Double
        'loop through donations and sum the amounts
        Dim total As Double = 0
        For Each d As Donation In Donations
            total += d.Amount
        Next
        Return total
    End Function
    Public Overrides Function ToString() As String
        Return Name
    End Function
End Class

Public Class Donation
    Private _amount As Double
    Private _theDate As Date

    Public Property Amount As Double
        Get
            Return _amount
        End Get
        Set(value As Double)
            _amount = value
        End Set
    End Property

    Public Property TheDate As Date
        Get
            Return _theDate
        End Get
        Set(value As Date)
            _theDate = value
        End Set
    End Property

    Public Sub New(amount As Double, theDate As Date)
        Me.Amount = amount
        Me.TheDate = theDate
    End Sub

    Public Overrides Function ToString() As String
        Return Amount.ToString("C2").PadRight(10) & Me.TheDate.ToLocalTime
    End Function
End Class
