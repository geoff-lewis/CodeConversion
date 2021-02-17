Imports System.Globalization
Imports System.Windows.Data

''' <summary>
''' Simplified version of LossIncidentTypeToIconConverter
''' </summary>
<ValueConversion(GetType(LossIncidentType), GetType(Object))>
Public Class LossIncidentTypeToIconConverter
    Implements IValueConverter

    Public Function Convert(value As Object, targetType As Type, parameter As Object, culture As CultureInfo) As Object Implements IValueConverter.Convert

        Select Case CType(value, LossIncidentType)

            Case LossIncidentType.Leak
                Return "LeakIndicationIcon"

            Case LossIncidentType.Theft
                Return "TheftIndicationIcon"

        End Select

        Return Nothing

    End Function

    Public Function ConvertBack(value As Object, targetType As Type, parameter As Object, culture As CultureInfo) As Object Implements IValueConverter.ConvertBack
        Return value
    End Function
End Class