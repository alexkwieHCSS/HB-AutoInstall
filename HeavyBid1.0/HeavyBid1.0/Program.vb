'
' Created by Ranorex
' User: alex.kwie
' Date: 3/9/2018
' Time: 3:05 PM
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'

Imports Microsoft.VisualBasic
Imports System
Imports System.Threading
Imports System.Drawing
Imports System.Collections.Generic
Imports System.Text.RegularExpressions
Imports WinForms = System.Windows.Forms

Imports Ranorex
Imports Ranorex.Core
Imports Ranorex.Core.Reporting
Imports Ranorex.Core.Testing

Namespace HeavyBid1._
    Module Program

        <STAThread()> _
        Function Main() As Integer
            ' Uncomment the following 3 lines if you want to automate Windows apps
            ' by starting the test executable directly
            'If Util.IsRestartRequiredForWinAppAccess Then
            '    Return Util.RestartWithUiAccess()
            'End If

            Keyboard.AbortKey = System.Windows.Forms.Keys.Pause
            Dim errorNumber As Integer = 0

            Try
                errorNumber = TestSuiteRunner.Run(GetType(Program), Environment.CommandLine)
            Catch e As Exception
                Report.Error("Unexpected exception occurred: " + e.ToString())
                errorNumber = -1
            End Try

            Return errorNumber

            End Function
    End Module
End Namespace
