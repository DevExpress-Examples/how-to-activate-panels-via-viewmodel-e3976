﻿Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Net
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Documents
Imports System.Windows.Input
Imports System.Windows.Media
Imports System.Windows.Media.Animation
Imports System.Windows.Shapes

Namespace ActivateViaViewModel.SL
    Partial Public Class MainPage
        Inherits UserControl

        Public Sub New()
            InitializeComponent()
            DataContext = New MainWindowViewModel()
        End Sub
    End Class
End Namespace
