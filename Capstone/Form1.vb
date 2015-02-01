Imports System.IO

Public Class AlienAlbert
    Dim CurrentStateID As Integer 'stores state array index number to variable (like primary key)
    Dim Score As Integer = 0
    Dim NewRandom As New Random 'store as variable for better preformance 


    Public Structure StateInfo
        Dim StateName As String
        Dim Capital As String
        Dim Top As Integer
        Dim Left As Integer
        'like a table
    End Structure

    Dim StateArray(49) As StateInfo
    Dim Visited As List(Of Integer) = New List(Of Integer) ' <---creates empty list, otherwise it is null

    Private Sub GenerateNextState() 'checks the list of visited and when it find an ID that is not in visited it assigns a new ID
        Dim NewID As Integer


        Do While Visited.Contains(NewID)
            NewID = NewRandom.Next(50)

        Loop

        CurrentStateID = NewID
        Visited.Add(CurrentStateID)

    End Sub

    Function GetCurrentState()
        Return StateArray(CurrentStateID)
    End Function







    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        NewRandom.Next(50) 'Attempt to not generate Ohio as the first state, but didn't work. This 
        'happens in our Random Numbers Demo too.


        My.Computer.Audio.Play(My.Resources.UFO_Landing_SoundBible_com_1015457638, AudioPlayMode.Background)



        Dim Ohio As StateInfo
        Ohio.StateName = "Ohio"
        Ohio.Capital = "Columbus"
        Ohio.Top = 290
        Ohio.Left = 565
        StateArray(0) = Ohio

        Dim Alabama As StateInfo

        Alabama.StateName = "Alabama"
        Alabama.Capital = "Montgomery"
        Alabama.Top = 440
        Alabama.Left = 550
        StateArray(1) = Alabama


        Dim Alaska As StateInfo

        Alaska.StateName = "Alaska"
        Alaska.Capital = "Juneau"
        Alaska.Top = 30
        Alaska.Left = 75
        StateArray(2) = Alaska

        Dim Arizona As StateInfo

        Arizona.StateName = "Arizona"
        Arizona.Capital = "Phoenix"
        Arizona.Top = 420
        Arizona.Left = 220
        StateArray(3) = Arizona

        Dim Arkansas As StateInfo

        Arkansas.StateName = "Arkansas"
        Arkansas.Capital = "Little Rock"
        Arkansas.Top = 380
        Arkansas.Left = 475
        StateArray(4) = Arkansas

        Dim California As StateInfo

        California.StateName = "California"
        California.Capital = "Sacramento"
        California.Top = 350
        California.Left = 130
        StateArray(5) = California

        Dim Colorado As StateInfo

        Colorado.StateName = "Colorado"
        Colorado.Capital = "Denver"
        Colorado.Top = 300
        Colorado.Left = 290
        StateArray(6) = Colorado

        Dim Connecticut As StateInfo
        Connecticut.StateName = "Connecticut"
        Connecticut.Capital = "Hartford"
        Connecticut.Top = 239
        Connecticut.Left = 678
        StateArray(7) = Connecticut

        Dim Delaware As StateInfo

        Delaware.StateName = "Delaware"
        Delaware.Capital = "Dover"
        Delaware.Top = 285
        Delaware.Left = 660
        StateArray(8) = Delaware

        Dim Florida As StateInfo

        Florida.StateName = "Florida"
        Florida.Capital = "Tallahassee"
        Florida.Top = 470
        Florida.Left = 600
        StateArray(9) = Florida

        Dim Georgia As StateInfo
        Georgia.StateName = "Geogia"
        Georgia.Capital = "Atlanta"
        Georgia.Top = 440
        Georgia.Left = 600
        StateArray(10) = Georgia


        Dim Hawaii As StateInfo
        Hawaii.StateName = "Hawaii"
        Hawaii.Capital = "Honolulu"
        Hawaii.Top = 280
        Hawaii.Left = 50
        StateArray(11) = Hawaii

        Dim Idaho As StateInfo
        Idaho.StateName = "Idaho"
        Idaho.Capital = "Boise"
        Idaho.Top = 220
        Idaho.Left = 200
        StateArray(12) = Idaho

        Dim Illinois As StateInfo
        Illinois.StateName = "Illinois"
        Illinois.Capital = "Springfield"
        Illinois.Top = 290
        Illinois.Left = 500
        StateArray(13) = Illinois

        Dim Indiana As StateInfo
        Indiana.StateName = "Indiana"
        Indiana.Capital = "Indianapolis"
        Indiana.Top = 290
        Indiana.Left = 535
        StateArray(14) = Indiana

        Dim Iowa As StateInfo
        Iowa.StateName = "Iowa"
        Iowa.Capital = "Des Moines"
        Iowa.Top = 275
        Iowa.Left = 460
        StateArray(15) = Iowa

        Dim Kansas As StateInfo
        Kansas.StateName = "Kansas"
        Kansas.Capital = "Topeka"
        Kansas.Top = 330
        Kansas.Left = 400
        StateArray(16) = Kansas

        Dim Kentucky As StateInfo
        Kentucky.StateName = "Kentucky"
        Kentucky.Capital = "Frankfort"
        Kentucky.Top = 340
        Kentucky.Left = 550
        StateArray(17) = Kentucky

        Dim Louisiana As StateInfo
        Louisiana.StateName = "Louisiana"
        Louisiana.Capital = "Baton Rouge"
        Louisiana.Top = 450
        Louisiana.Left = 460
        StateArray(18) = Louisiana

        Dim Maine As StateInfo
        Maine.StateName = "Maine"
        Maine.Capital = "Augusta"
        Maine.Top = 178
        Maine.Left = 698
        StateArray(19) = Maine

        Dim Maryland As StateInfo
        Maryland.StateName = "Maryland"
        Maryland.Capital = "Annapolis"
        Maryland.Top = 285
        Maryland.Left = 645
        StateArray(20) = Maryland

        Dim Massachusetts As StateInfo
        Massachusetts.StateName = "Massachusetts"
        Massachusetts.Capital = "Boston"
        Massachusetts.Top = 225
        Massachusetts.Left = 678
        StateArray(21) = Massachusetts


        Dim Michigan As StateInfo
        Michigan.StateName = "Michigan"
        Michigan.Capital = "Lansing"
        Michigan.Top = 200
        Michigan.Left = 535
        StateArray(22) = Michigan

        Dim Minnesota As StateInfo
        Minnesota.StateName = "Minnesota"
        Minnesota.Capital = "Saint Paul"
        Minnesota.Top = 200
        Minnesota.Left = 440
        StateArray(23) = Minnesota

        Dim Mississippi As StateInfo
        Mississippi.StateName = "Mississippi"
        Mississippi.Capital = "Jackson"
        Mississippi.Top = 440
        Mississippi.Left = 500

        StateArray(24) = Mississippi

        Dim Missouri As StateInfo
        Missouri.StateName = "Missouri"
        Missouri.Capital = "Jefferson City"
        Missouri.Top = 330
        Missouri.Left = 450
        StateArray(25) = Missouri

        Dim Montana As StateInfo
        Montana.StateName = "Montana"
        Montana.Capital = "Helena"
        Montana.Top = 190
        Montana.Left = 290
        StateArray(26) = Montana


        Dim Nebraska As StateInfo
        Nebraska.StateName = "Nebraska"
        Nebraska.Capital = "Lincoln"
        Nebraska.Top = 280
        Nebraska.Left = 400
        StateArray(27) = Nebraska


        Dim Nevada As StateInfo
        Nevada.StateName = "Nevada"
        Nevada.Capital = "Carson City"
        Nevada.Top = 315
        Nevada.Left = 170
        StateArray(28) = Nevada

        Dim NewHampshire As StateInfo
        NewHampshire.StateName = "New Hampshire"
        NewHampshire.Capital = "Concord"
        NewHampshire.Top = 200
        NewHampshire.Left = 688
        StateArray(29) = NewHampshire

        Dim NewJersey As StateInfo
        NewJersey.StateName = "New Jersey"
        NewJersey.Capital = "Trenton"
        NewJersey.Top = 260
        NewJersey.Left = 660
        StateArray(30) = NewJersey

        Dim NewYork As StateInfo
        NewYork.StateName = "New York"
        NewYork.Capital = "Albany"
        NewYork.Top = 230
        NewYork.Left = 635
        StateArray(31) = NewYork

        Dim NewMexico As StateInfo
        NewMexico.StateName = "New Mexico"
        NewMexico.Capital = "Santa Fe"
        NewMexico.Top = 420
        NewMexico.Left = 275
        StateArray(32) = NewMexico

        Dim NorthCarolina As StateInfo
        NorthCarolina.StateName = "North Carolina"
        NorthCarolina.Capital = "Raleigh"
        NorthCarolina.Top = 360
        NorthCarolina.Left = 635
        StateArray(33) = NorthCarolina

        Dim NorthDakota As StateInfo
        NorthDakota.StateName = "North Dakota"
        NorthDakota.Capital = "Bismark"
        NorthDakota.Top = 175
        NorthDakota.Left = 380
        StateArray(34) = NorthDakota


        Dim Oklahoma As StateInfo
        Oklahoma.StateName = "Oklahoma"
        Oklahoma.Capital = "Oklahoma City"
        Oklahoma.Top = 390
        Oklahoma.Left = 420
        StateArray(35) = Oklahoma

        Dim Oregon As StateInfo
        Oregon.StateName = "Oregon"
        Oregon.Capital = "Salem"
        Oregon.Top = 190
        Oregon.Left = 145
        StateArray(36) = Oregon

        Dim Pennsylvania As StateInfo
        Pennsylvania.StateName = "Pennsylvania"
        Pennsylvania.Capital = "Harrisburg"
        Pennsylvania.Top = 270
        Pennsylvania.Left = 635
        StateArray(37) = Pennsylvania

        Dim RhodeIsland As StateInfo
        RhodeIsland.StateName = "Rhode Island"
        RhodeIsland.Capital = "Providence"
        RhodeIsland.Top = 239
        RhodeIsland.Left = 695
        StateArray(38) = RhodeIsland

        Dim SouthCarolina As StateInfo
        SouthCarolina.StateName = "South Carolina"
        SouthCarolina.Capital = "Columbia"
        SouthCarolina.Top = 400
        SouthCarolina.Left = 620
        StateArray(39) = SouthCarolina

        Dim SouthDakota As StateInfo
        SouthDakota.StateName = "South Dakota"
        SouthDakota.Capital = "Pierre"
        SouthDakota.Top = 230
        SouthDakota.Left = 380
        StateArray(40) = SouthDakota

        Dim Tennessee As StateInfo
        Tennessee.StateName = "Tennessee"
        Tennessee.Capital = "Nashville"
        Tennessee.Top = 370
        Tennessee.Left = 550
        StateArray(41) = Tennessee

        Dim Texas As StateInfo
        Texas.StateName = "Texas"
        Texas.Capital = "Austin"
        Texas.Top = 485
        Texas.Left = 390
        StateArray(42) = Texas


        Dim Utah As StateInfo
        Utah.StateName = "Utah"
        Utah.Capital = "Salt Lake City"
        Utah.Top = 310
        Utah.Left = 220
        StateArray(43) = Utah


        Dim Vermont As StateInfo
        Vermont.StateName = "Vermont"
        Vermont.Capital = "Montpelier"
        Vermont.Top = 200
        Vermont.Left = 670
        StateArray(44) = Vermont

        Dim Virginia As StateInfo
        Virginia.StateName = "Virginia"
        Virginia.Capital = "Richmond"
        Virginia.Top = 325
        Virginia.Left = 635
        StateArray(45) = Virginia


        Dim Washington As StateInfo
        Washington.StateName = "Washington"
        Washington.Capital = "Olympus"
        Washington.Top = 150
        Washington.Left = 150
        StateArray(46) = Washington

        Dim Wisconsin As StateInfo
        Wisconsin.StateName = "Wisconsin"
        Wisconsin.Capital = "Madison"
        Wisconsin.Top = 230
        Wisconsin.Left = 480
        StateArray(47) = Wisconsin

        Dim WestVirginia As StateInfo
        WestVirginia.StateName = "West Virginia"
        WestVirginia.Capital = "Charleston"
        WestVirginia.Top = 315
        WestVirginia.Left = 595
        StateArray(48) = WestVirginia

        Dim Wyoming As StateInfo
        Wyoming.StateName = "Wyoming"
        Wyoming.Capital = "Cheyenne"
        Wyoming.Top = 250
        Wyoming.Left = 290
        StateArray(49) = Wyoming




    End Sub




    Private Sub btnMoveAlien_Click(sender As Object, e As EventArgs) Handles btnMoveAlien.Click

        If Visited.Count >= MissionLength Then
            btnScore_Click(sender, e)

        Else



            GenerateNextState()

            Dim CurrentState As StateInfo = GetCurrentState()

            Dim Counter As Double

            My.Computer.Audio.Play(My.Resources.Laser_SoundBible_com_602495617, AudioPlayMode.Background)

            If AlienUser.Top > CurrentState.Top Then
                'Move "upward" by decreasing distance from Top
                For Counter = AlienUser.Top To CurrentState.Top Step -0.0001

                    AlienUser.Top = Counter
                Next
            Else
                'Move "downward" by increasing distance from Top
                For Counter = AlienUser.Top To CurrentState.Top Step 0.0001

                    AlienUser.Top = Counter
                Next
            End If

            If AlienUser.Left > CurrentState.Left Then
                'Move to the left.
                For Counter = AlienUser.Left To CurrentState.Left Step -0.0001
                    AlienUser.Left = Counter
                Next
            Else
                'Move to the right.
                For Counter = AlienUser.Left To CurrentState.Left Step 0.0001
                    AlienUser.Left = Counter
                Next
            End If
            'InputBox("What is the Capital of this State?")
            If InputBox("What is the Capital of " & CurrentState.StateName & "?") = CurrentState.Capital Then

                MessageBox.Show("That is correct!")
                Score = Score + 1

            Else
                MessageBox.Show("Incorrect, the capital of " & CurrentState.StateName & " is " & CurrentState.Capital)

            End If

            'Const NumOfStates = 49
            'Dim Count As Integer
            'Dim NextState As StateInfo
            'For Count = 1 To NumOfStates
            '    NextState.Capital = InputBox("What is the capital of this state?")



        End If
    End Sub

   

    Private Sub btnMission_Click(sender As Object, e As EventArgs) Handles btnMission.Click
        AboutAlienAlbert.Show()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MissionSelect.Close()
        Me.Close()
    End Sub


    Private Sub btnScore_Click(sender As Object, e As EventArgs) Handles btnScore.Click
        MessageBox.Show("Your Score is: " & CStr(Score))
    End Sub

    Private Sub btnSaveScore_Click(sender As Object, e As EventArgs) Handles btnSaveScore.Click
        Dim PlayerScore As StreamWriter
        Dim strScoreFileName As String
        Dim NewScore As Integer = Score

        strScoreFileName = InputBox("Enter your initials followed by .txt: ")
        If Not strScoreFileName.EndsWith(".txt") Then
            MessageBox.Show("file name must end in '.txt'")
        Else
            'attempt to append first and then it creates a file
            Try
                'If this works, the file already exists.
                PlayerScore = File.AppendText(strScoreFileName)
                PlayerScore.WriteLine(CStr(NewScore))
                PlayerScore.Close()

            Catch ex1 As Exception
                'The file doesn't already exist.
                Try
                    'If this works, the file can be created.
                    PlayerScore = File.CreateText(strScoreFileName)
                    For Each Row As String In Score.ToString
                        PlayerScore.WriteLine(Row)

                    Next
                    PlayerScore.Close()

                Catch ex2 As Exception
                    MessageBox.Show("file cannot be created")

                End Try

            End Try




        End If


    End Sub
End Class
