Public Class Budget
    Private Sub Budget_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1_sted_saldo1.vStedSaldo_Primo' table. You can move, or remove it, as needed.
        'TODO: This line of code loads data into the 'Inteiro_Financial_InsightDataSetvHovedformål.vHovedformål' table. You can move, or remove it, as needed.
        Me.VHovedformålTableAdapter.Fill(Me.Inteiro_Financial_InsightDataSetvHovedformål.vHovedformål)
        'TODO: This line of code loads data into the 'Inteiro_Financial_InsightDataSetHovedfunktion.vHovedfunktion' table. You can move, or remove it, as needed.
        'TODO: This line of code loads data into the 'Inteiro_Financial_InsightDataSetvHovedkonto.vHovedkonto' table. You can move, or remove it, as needed.
        Me.VHovedkontoTableAdapter.Fill(Me.Inteiro_Financial_InsightDataSetvHovedkonto.vHovedkonto)
        'TODO: This line of code loads data into the 'Inteiro_Financial_InsightDataSetvRegkonto.vRegkonto' table. You can move, or remove it, as needed.
        Me.VRegkontoTableAdapter.Fill(Me.Inteiro_Financial_InsightDataSetvRegkonto.vRegkonto)
        'TODO: This line of code loads data into the 'Inteiro_Financial_InsightDataSetvDranst.vDranst' table. You can move, or remove it, as needed.
        Me.VDranstTableAdapter.Fill(Me.Inteiro_Financial_InsightDataSetvDranst.vDranst)
        'TODO: This line of code loads data into the 'Inteiro_Financial_InsightDataSetVG2.vG2' table. You can move, or remove it, as needed.
        Me.VG2TableAdapter.Fill(Me.Inteiro_Financial_InsightDataSetVG2.vG2)
        'TODO: This line of code loads data into the 'Inteiro_Financial_InsightDataSetG1.vG1' table. You can move, or remove it, as needed.
        Me.VG1TableAdapter.Fill(Me.Inteiro_Financial_InsightDataSetG1.vG1)
        'TODO: This line of code loads data into the 'Inteiro_Financial_InsightDataSetBrugerGruppe.vBrugerGruppe' table. You can move, or remove it, as needed.
        Me.VBrugerGruppeTableAdapter.Fill(Me.Inteiro_Financial_InsightDataSetBrugerGruppe.vBrugerGruppe)
        'TODO: This line of code loads data into the 'Inteiro_Financial_InsightDataSetBruger.vBruger' table. You can move, or remove it, as needed.
        Me.VBrugerTableAdapter.Fill(Me.Inteiro_Financial_InsightDataSetBruger.vBruger)
        'TODO: This line of code loads data into the 'Inteiro_Financial_InsightDataSetVersion.vVersion' table. You can move, or remove it, as needed.
        Me.VVersionTableAdapter.Fill(Me.Inteiro_Financial_InsightDataSetVersion.vVersion)
        'TODO: This line of code loads data into the 'Inteiro_Financial_InsightDataSet_vLikviditet.vLikviditetsbudget_Niveau_1' table. You can move, or remove it, as needed.
        Me.VLikviditetsbudget_Niveau_1TableAdapter.Fill(Me.Inteiro_Financial_InsightDataSet_vLikviditet.vLikviditetsbudget_Niveau_1)
        'TODO: This line of code loads data into the 'Inteiro_Financial_InsightDataSetLikviditet_2_1.Likviditetsbudget_Niveau_1_2' table. You can move, or remove it, as needed.
        Me.Likviditetsbudget_Niveau_1_2TableAdapter.Fill(Me.Inteiro_Financial_InsightDataSetLikviditet_2_1.Likviditetsbudget_Niveau_1_2)
        'TODO: This line of code loads data into the 'DataSet1_sted_saldo.vStedSaldo_Primo' table. You can move, or remove it, as needed.
        Me.VStedSaldo_PrimoTableAdapter.Fill(Me.DataSet1_sted_saldo.vStedSaldo_Primo)

    End Sub
End Class