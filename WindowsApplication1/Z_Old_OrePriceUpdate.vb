Imports System.Configuration
Imports MySql.Data.MySqlClient

Public Class Z_Old_OrePriceUpdate
    Dim Mysqlconn As MySqlConnection
    Dim cmd As MySqlCommand



    Private Sub Update_Prices_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Update_Prices_Button.Click
        Mysqlconn = New MySqlConnection()
        Mysqlconn.ConnectionString = "server=yhi.is-a-guru.com;Uid=YHI;Pwd=miningore;database=YHI"

        Try
            Mysqlconn.Open()
            cmd = New MySqlCommand()
            cmd.Connection = Mysqlconn
            cmd.CommandText = "update_mining_prices"
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.AddWithValue("@veldspar_isk", Veldspar_Isk.Text)
            cmd.Parameters.AddWithValue("@concentrated_veldspar_isk", Concentrated_Veldspar_Isk.Text)
            cmd.Parameters.AddWithValue("@dense_veldspar_isk", Dense_Veldspar_Isk.Text)
            cmd.Parameters.AddWithValue("@scordite_isk", Scordite_Isk.Text)
            cmd.Parameters.AddWithValue("@condensed_scordite_isk", Condensed_Scordite_Isk.Text)
            cmd.Parameters.AddWithValue("@massive_scordite_isk", Massive_Scordite_Isk.Text)
            cmd.Parameters.AddWithValue("@pyroxeres_isk", Pyroxeres_Isk.Text)
            cmd.Parameters.AddWithValue("@solid_pyroxeres_isk", Solid_Pyroxeres_Isk.Text)
            cmd.Parameters.AddWithValue("@viscous_pyroxeres_isk", Viscous_Pyroxeres_Isk.Text)
            cmd.Parameters.AddWithValue("@plagioclase_isk", Plagioclase_Isk.Text)
            cmd.Parameters.AddWithValue("@azure_plagioclase_isk", Azure_Plagioclase_Isk.Text)
            cmd.Parameters.AddWithValue("@rich_plagioclase_isk", Rich_Plagioclase_Isk.Text)
            cmd.Parameters.AddWithValue("@omber_isk", Omber_Isk.Text)
            cmd.Parameters.AddWithValue("@silvery_omber_isk", Silvery_Omber_Isk.Text)
            cmd.Parameters.AddWithValue("@golden_omber_isk", Golden_Omber_Isk.Text)
            cmd.Parameters.AddWithValue("@kernite_isk", Kernite_Isk.Text)
            cmd.Parameters.AddWithValue("@luminous_kernite_isk", Luminous_Kernite_Isk.Text)
            cmd.Parameters.AddWithValue("@fiery_kernite_isk", Fiery_Kernite_Isk.Text)
            cmd.Parameters.AddWithValue("@jaspet_isk", Jaspet_Isk.Text)
            cmd.Parameters.AddWithValue("@pure_jaspet_isk", Pure_Jaspet_Isk.Text)
            cmd.Parameters.AddWithValue("@pristine_jaspet_isk", Pristine_Jaspet_Isk.Text)
            cmd.Parameters.AddWithValue("@hemorphite_isk", Hemorphite_Isk.Text)
            cmd.Parameters.AddWithValue("@vivid_hemorphite_isk", Vivid_Hemorphite_Isk.Text)
            cmd.Parameters.AddWithValue("@radiant_hemorphite_isk", Radiant_Hemorphite_Isk.Text)
            cmd.Parameters.AddWithValue("@hedbergite_isk", Hedbergite_Isk.Text)
            cmd.Parameters.AddWithValue("@vitric_hedbergite_isk", Vitric_Hedbergite_Isk.Text)
            cmd.Parameters.AddWithValue("@glazed_hedbergite_isk", Glazed_Hedbergite_Isk.Text)
            cmd.Parameters.AddWithValue("@gneiss_isk", Gneiss_Isk.Text)
            cmd.Parameters.AddWithValue("@iridescent_gneiss_isk", Iridescent_Gneiss_Isk.Text)
            cmd.Parameters.AddWithValue("@prismatic_gneiss_isk", Prismatic_Gneiss_Isk.Text)
            cmd.Parameters.AddWithValue("@dark_ochre_isk", Dark_Ochre_Isk.Text)
            cmd.Parameters.AddWithValue("@onyx_ochre_isk", Onyx_Ochre_Isk.Text)
            cmd.Parameters.AddWithValue("@obsidian_ochre_isk", Obsidian_Ochre_Isk.Text)
            cmd.Parameters.AddWithValue("@crokite_isk", Crokite_Isk.Text)
            cmd.Parameters.AddWithValue("@sharp_crokite_isk", Sharp_Crokite_Isk.Text)
            cmd.Parameters.AddWithValue("@crystalline_crokite_isk", Crystalline_Crokite_Isk.Text)
            cmd.Parameters.AddWithValue("@spodumain_isk", Spodumain_Isk.Text)
            cmd.Parameters.AddWithValue("@bright_spodumain_isk", Bright_Spodumain_Isk.Text)
            cmd.Parameters.AddWithValue("@gleaming_spodumain_isk", Gleaming_Spodumain_Isk.Text)
            cmd.Parameters.AddWithValue("@bistot_isk", Bistot_Isk.Text)
            cmd.Parameters.AddWithValue("@triclinic_bistot_isk", Triclinic_Bistot_Isk.Text)
            cmd.Parameters.AddWithValue("@monoclinic_bistot_isk", Monoclinic_Bistot_Isk.Text)
            cmd.Parameters.AddWithValue("@arkonor_isk", Arkonor_Isk.Text)
            cmd.Parameters.AddWithValue("@crimson_arkonor_isk", Crimson_Arkonor_Isk.Text)
            cmd.Parameters.AddWithValue("@prime_arkonor_isk", Prime_Arkonor_Isk.Text)
            cmd.Parameters.AddWithValue("@mercoxit_isk", Mercoxit_Isk.Text)
            cmd.Parameters.AddWithValue("@magma_mercoxit_isk", Magma_Mercoxit_Isk.Text)
            cmd.Parameters.AddWithValue("@vitreous_mercoxit_isk", Vitreous_Mercoxit_Isk.Text)
            cmd.Parameters.AddWithValue("@white_glaze_isk", White_Glaze_Isk.Text)
            cmd.Parameters.AddWithValue("@pristine_white_glaze_isk", Pristine_White_Glaze_Isk.Text)
            cmd.Parameters.AddWithValue("@glacial_mass_isk", Glacial_Mass_Isk.Text)
            cmd.Parameters.AddWithValue("@smooth_glacial_mass_isk", Smooth_Glacial_Mass_Isk.Text)
            cmd.Parameters.AddWithValue("@blue_ice_isk", Blue_Ice_Isk.Text)
            cmd.Parameters.AddWithValue("@thick_blue_ice_isk", Thick_Blue_Ice_Isk.Text)
            cmd.Parameters.AddWithValue("@clear_icicle_isk", Clear_Icicle_Isk.Text)
            cmd.Parameters.AddWithValue("@enriched_clear_icicle_isk", Enriched_Clear_Icicle_Isk.Text)
            cmd.Parameters.AddWithValue("@glare_crust_isk", Glare_Crust_Isk.Text)
            cmd.Parameters.AddWithValue("@dark_glitter_isk", Dark_Glitter_Isk.Text)
            cmd.Parameters.AddWithValue("@gelidus_isk", Gelidus_Isk.Text)
            cmd.Parameters.AddWithValue("@krystallos_isk", Krystallos_Isk.Text)
            cmd.Parameters.AddWithValue("@tritanium_isk", Tritanium_Isk.Text)
            cmd.Parameters.AddWithValue("@pyerite_isk", Pyerite_Isk.Text)
            cmd.Parameters.AddWithValue("@mexallon_isk", Mexallon_Isk.Text)
            cmd.Parameters.AddWithValue("@isogen_isk", Isogen_Isk.Text)
            cmd.Parameters.AddWithValue("@nocxium_isk", Nocxium_Isk.Text)
            cmd.Parameters.AddWithValue("@zydrine_isk", Zydrine_Isk.Text)
            cmd.Parameters.AddWithValue("@megacyte_isk", Megacyte_Isk.Text)
            cmd.Parameters.AddWithValue("@morphite_isk", Morphite_Isk.Text)
            cmd.Parameters.AddWithValue("@heavy_water_isk", Heavy_Water_Isk.Text)
            cmd.Parameters.AddWithValue("@helium_isotopes_isk", Helium_Isotopes_Isk.Text)
            cmd.Parameters.AddWithValue("@hydrogen_isotopes_isk", Hydrogen_Isotopes_Isk.Text)
            cmd.Parameters.AddWithValue("@liquid_ozone_isk", Liquid_Ozone_Isk.Text)
            cmd.Parameters.AddWithValue("@nitrogen_isotopes_isk", Nitrogen_Isotopes_Isk.Text)
            cmd.Parameters.AddWithValue("@oxygen_isotopes_isk", Oxygen_Isotopes_Isk.Text)
            cmd.Parameters.AddWithValue("@strontium_clathrates_isk", Strontium_Clathrates_Isk.Text)

            cmd.ExecuteNonQuery()

            MessageBox.Show("Prices Updated")

        Catch myerror As MySqlException
            MessageBox.Show(myerror.Message)
        Finally
            Mysqlconn.Dispose()
        End Try
    End Sub

    Private Sub Clear_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Clear_Button.Click
        Calc_Clear_All()
    End Sub

    Private Sub Calc_Clear_All()
        Veldspar_Isk.Text = "0"
        Concentrated_Veldspar_Isk.Text = "0"
        Dense_Veldspar_Isk.Text = "0"
        Scordite_Isk.Text = "0"
        Condensed_Scordite_Isk.Text = "0"
        Massive_Scordite_Isk.Text = "0"
        Pyroxeres_Isk.Text = "0"
        Solid_Pyroxeres_Isk.Text = "0"
        Viscous_Pyroxeres_Isk.Text = "0"
        Plagioclase_Isk.Text = "0"
        Azure_Plagioclase_Isk.Text = "0"
        Rich_Plagioclase_Isk.Text = "0"
        Omber_Isk.Text = "0"
        Silvery_Omber_Isk.Text = "0"
        Golden_Omber_Isk.Text = "0"
        Kernite_Isk.Text = "0"
        Luminous_Kernite_Isk.Text = "0"
        Fiery_Kernite_Isk.Text = "0"
        Jaspet_Isk.Text = "0"
        Pure_Jaspet_Isk.Text = "0"
        Pristine_Jaspet_Isk.Text = "0"
        Hemorphite_Isk.Text = "0"
        Vivid_Hemorphite_Isk.Text = "0"
        Radiant_Hemorphite_Isk.Text = "0"
        Hedbergite_Isk.Text = "0"
        Vitric_Hedbergite_Isk.Text = "0"
        Glazed_Hedbergite_Isk.Text = "0"
        Gneiss_Isk.Text = "0"
        Iridescent_Gneiss_Isk.Text = "0"
        Prismatic_Gneiss_Isk.Text = "0"
        Dark_Ochre_Isk.Text = "0"
        Onyx_Ochre_Isk.Text = "0"
        Obsidian_Ochre_Isk.Text = "0"
        Crokite_Isk.Text = "0"
        Sharp_Crokite_Isk.Text = "0"
        Crystalline_Crokite_Isk.Text = "0"
        Spodumain_Isk.Text = "0"
        Bright_Spodumain_Isk.Text = "0"
        Gleaming_Spodumain_Isk.Text = "0"
        Bistot_Isk.Text = "0"
        Triclinic_Bistot_Isk.Text = "0"
        Monoclinic_Bistot_Isk.Text = "0"
        Arkonor_Isk.Text = "0"
        Crimson_Arkonor_Isk.Text = "0"
        Prime_Arkonor_Isk.Text = "0"
        Mercoxit_Isk.Text = "0"
        Magma_Mercoxit_Isk.Text = "0"
        Vitreous_Mercoxit_Isk.Text = "0"
        Tritanium_Isk.Text = "0"
        Pyerite_Isk.Text = "0"
        Mexallon_Isk.Text = "0"
        Isogen_Isk.Text = "0"
        Nocxium_Isk.Text = "0"
        Zydrine_Isk.Text = "0"
        Megacyte_Isk.Text = "0"
        Morphite_Isk.Text = "0"
        White_Glaze_Isk.Text = "0"
        Pristine_White_Glaze_Isk.Text = "0"
        Glacial_Mass_Isk.Text = "0"
        Smooth_Glacial_Mass_Isk.Text = "0"
        Blue_Ice_Isk.Text = "0"
        Thick_Blue_Ice_Isk.Text = "0"
        Clear_Icicle_Isk.Text = "0"
        Enriched_Clear_Icicle_Isk.Text = "0"
        Glare_Crust_Isk.Text = "0"
        Dark_Glitter_Isk.Text = "0"
        Gelidus_Isk.Text = "0"
        Krystallos_Isk.Text = "0"
        Helium_Isotopes_Isk.Text = "0"
        Hydrogen_Isotopes_Isk.Text = "0"
        Nitrogen_Isotopes_Isk.Text = "0"
        Oxygen_Isotopes_Isk.Text = "0"
        Heavy_Water_Isk.Text = "0"
        Liquid_Ozone_Isk.Text = "0"
        Strontium_Clathrates_Isk.Text = "0"
    End Sub

    Private Sub Solid_Pyroxeres_Isk_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Solid_Pyroxeres_Isk.TextChanged

    End Sub

    Private Sub OrePriceUpdate_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Call Stored Procedure
        'Take values from resultset and make textboxe.text = SP field value
        Mysqlconn = New MySqlConnection()
        Mysqlconn.ConnectionString = "server=yhi.is-a-guru.com;Uid=YHI;Pwd=miningore;database=YHI"
        Mysqlconn.Open()
        cmd = New MySqlCommand()
        cmd.Connection = Mysqlconn

        Dim sqlStripCmd As New MySqlCommand("ore_price_population", Mysqlconn)

        sqlStripCmd.CommandType = CommandType.StoredProcedure
        'Dim sdrstripcmd As MySqlDataReader = sqlStripCmd.ExecuteReader()

        'Veldspar_Isk.Text = sdrstripcmd.GetString("Veldspar")
        Dim getDetailsDA = New MySqlDataAdapter
        Dim getDetailsDS As New DataSet
        getDetailsDA.SelectCommand = sqlStripCmd
        getDetailsDA.Fill(getDetailsDS, "getDetails")
        Veldspar_Isk.Text = getDetailsDS.Tables(0).Rows(0).Item("Veldspar").ToString
        Concentrated_Veldspar_Isk.Text = getDetailsDS.Tables(0).Rows(0).Item("Concentrated_Veldspar").ToString
        Dense_Veldspar_Isk.Text = getDetailsDS.Tables(0).Rows(0).Item("Dense_Veldspar").ToString
        Scordite_Isk.Text = getDetailsDS.Tables(0).Rows(0).Item("Scordite").ToString
        Condensed_Scordite_Isk.Text = getDetailsDS.Tables(0).Rows(0).Item("Condensed_Scordite").ToString
        Massive_Scordite_Isk.Text = getDetailsDS.Tables(0).Rows(0).Item("Massive_Scordite").ToString
        Pyroxeres_Isk.Text = getDetailsDS.Tables(0).Rows(0).Item("Pyroxeres").ToString
        Solid_Pyroxeres_Isk.Text = getDetailsDS.Tables(0).Rows(0).Item("Solid_Pyroxeres").ToString
        Viscous_Pyroxeres_Isk.Text = getDetailsDS.Tables(0).Rows(0).Item("Viscous_Pyroxeres").ToString
        Plagioclase_Isk.Text = getDetailsDS.Tables(0).Rows(0).Item("Plagioclase").ToString
        Azure_Plagioclase_Isk.Text = getDetailsDS.Tables(0).Rows(0).Item("Azure_Plagioclase").ToString
        Rich_Plagioclase_Isk.Text = getDetailsDS.Tables(0).Rows(0).Item("Rich_Plagioclase").ToString
        Omber_Isk.Text = getDetailsDS.Tables(0).Rows(0).Item("Omber").ToString
        Silvery_Omber_Isk.Text = getDetailsDS.Tables(0).Rows(0).Item("Silvery_Omber").ToString
        Golden_Omber_Isk.Text = getDetailsDS.Tables(0).Rows(0).Item("Golden_Omber").ToString
        Kernite_Isk.Text = getDetailsDS.Tables(0).Rows(0).Item("Kernite").ToString
        Luminous_Kernite_Isk.Text = getDetailsDS.Tables(0).Rows(0).Item("Luminous_Kernite").ToString
        Fiery_Kernite_Isk.Text = getDetailsDS.Tables(0).Rows(0).Item("Fiery_Kernite").ToString
        Jaspet_Isk.Text = getDetailsDS.Tables(0).Rows(0).Item("Jaspet").ToString
        Pure_Jaspet_Isk.Text = getDetailsDS.Tables(0).Rows(0).Item("Pure_Jaspet").ToString
        Pristine_Jaspet_Isk.Text = getDetailsDS.Tables(0).Rows(0).Item("Pristine_Jaspet").ToString
        Hemorphite_Isk.Text = getDetailsDS.Tables(0).Rows(0).Item("Hemorphite").ToString
        Vivid_Hemorphite_Isk.Text = getDetailsDS.Tables(0).Rows(0).Item("Vivid_Hemorphite").ToString
        Radiant_Hemorphite_Isk.Text = getDetailsDS.Tables(0).Rows(0).Item("Radiant_Hemorphite").ToString
        Hedbergite_Isk.Text = getDetailsDS.Tables(0).Rows(0).Item("Hedbergite").ToString
        Vitric_Hedbergite_Isk.Text = getDetailsDS.Tables(0).Rows(0).Item("Vitric_Hedbergite").ToString
        Glazed_Hedbergite_Isk.Text = getDetailsDS.Tables(0).Rows(0).Item("Glazed_Hedbergite").ToString
        Gneiss_Isk.Text = getDetailsDS.Tables(0).Rows(0).Item("Gneiss").ToString
        Iridescent_Gneiss_Isk.Text = getDetailsDS.Tables(0).Rows(0).Item("Iridescent_Gneiss").ToString
        Prismatic_Gneiss_Isk.Text = getDetailsDS.Tables(0).Rows(0).Item("Prismatic_Gneiss").ToString
        Dark_Ochre_Isk.Text = getDetailsDS.Tables(0).Rows(0).Item("Dark_Ochre").ToString
        Onyx_Ochre_Isk.Text = getDetailsDS.Tables(0).Rows(0).Item("Onyx_Ochre").ToString
        Obsidian_Ochre_Isk.Text = getDetailsDS.Tables(0).Rows(0).Item("Obsidian_Ochre").ToString
        Crokite_Isk.Text = getDetailsDS.Tables(0).Rows(0).Item("Crokite").ToString
        Sharp_Crokite_Isk.Text = getDetailsDS.Tables(0).Rows(0).Item("Sharp_Crokite").ToString
        Crystalline_Crokite_Isk.Text = getDetailsDS.Tables(0).Rows(0).Item("Crystalline_Crokite").ToString
        Spodumain_Isk.Text = getDetailsDS.Tables(0).Rows(0).Item("Spodumain").ToString
        Bright_Spodumain_Isk.Text = getDetailsDS.Tables(0).Rows(0).Item("Bright_Spodumain").ToString
        Gleaming_Spodumain_Isk.Text = getDetailsDS.Tables(0).Rows(0).Item("Gleaming_Spodumain").ToString
        Bistot_Isk.Text = getDetailsDS.Tables(0).Rows(0).Item("Bistot").ToString
        Triclinic_Bistot_Isk.Text = getDetailsDS.Tables(0).Rows(0).Item("Triclinic_Bistot").ToString
        Monoclinic_Bistot_Isk.Text = getDetailsDS.Tables(0).Rows(0).Item("Monoclinic_Bistot").ToString
        Arkonor_Isk.Text = getDetailsDS.Tables(0).Rows(0).Item("Arkonor").ToString
        Crimson_Arkonor_Isk.Text = getDetailsDS.Tables(0).Rows(0).Item("Crimson_Arkonor").ToString
        Prime_Arkonor_Isk.Text = getDetailsDS.Tables(0).Rows(0).Item("Prime_Arkonor").ToString
        Mercoxit_Isk.Text = getDetailsDS.Tables(0).Rows(0).Item("Mercoxit").ToString
        Magma_Mercoxit_Isk.Text = getDetailsDS.Tables(0).Rows(0).Item("Magma_Mercoxit").ToString
        Vitreous_Mercoxit_Isk.Text = getDetailsDS.Tables(0).Rows(0).Item("Vitreous_Mercoxit").ToString
        White_Glaze_Isk.Text = getDetailsDS.Tables(0).Rows(0).Item("White_Glaze").ToString
        Pristine_White_Glaze_Isk.Text = getDetailsDS.Tables(0).Rows(0).Item("Pristine_White_Glaze").ToString
        Glacial_Mass_Isk.Text = getDetailsDS.Tables(0).Rows(0).Item("Glacial_Mass").ToString
        Smooth_Glacial_Mass_Isk.Text = getDetailsDS.Tables(0).Rows(0).Item("Smooth_Glacial_Mass").ToString
        Blue_Ice_Isk.Text = getDetailsDS.Tables(0).Rows(0).Item("Blue_Ice").ToString
        Thick_Blue_Ice_Isk.Text = getDetailsDS.Tables(0).Rows(0).Item("Thick_Blue_Ice").ToString
        Clear_Icicle_Isk.Text = getDetailsDS.Tables(0).Rows(0).Item("Clear_Icicle").ToString
        Enriched_Clear_Icicle_Isk.Text = getDetailsDS.Tables(0).Rows(0).Item("Enriched_Clear_Icicle").ToString
        Glare_Crust_Isk.Text = getDetailsDS.Tables(0).Rows(0).Item("Glare_Crust").ToString
        Dark_Glitter_Isk.Text = getDetailsDS.Tables(0).Rows(0).Item("Dark_Glitter").ToString
        Gelidus_Isk.Text = getDetailsDS.Tables(0).Rows(0).Item("Gelidus").ToString
        Krystallos_Isk.Text = getDetailsDS.Tables(0).Rows(0).Item("Krystallos").ToString
        Tritanium_Isk.Text = getDetailsDS.Tables(0).Rows(0).Item("Tritanium").ToString
        Pyerite_Isk.Text = getDetailsDS.Tables(0).Rows(0).Item("Pyerite").ToString
        Mexallon_Isk.Text = getDetailsDS.Tables(0).Rows(0).Item("Mexallon").ToString
        Isogen_Isk.Text = getDetailsDS.Tables(0).Rows(0).Item("Isogen").ToString
        Nocxium_Isk.Text = getDetailsDS.Tables(0).Rows(0).Item("Nocxium").ToString
        Zydrine_Isk.Text = getDetailsDS.Tables(0).Rows(0).Item("Zydrine").ToString
        Megacyte_Isk.Text = getDetailsDS.Tables(0).Rows(0).Item("Megacyte").ToString
        Morphite_Isk.Text = getDetailsDS.Tables(0).Rows(0).Item("Morphite").ToString
        Heavy_Water_Isk.Text = getDetailsDS.Tables(0).Rows(0).Item("Heavy_Water").ToString
        Helium_Isotopes_Isk.Text = getDetailsDS.Tables(0).Rows(0).Item("Helium_Isotopes").ToString
        Hydrogen_Isotopes_Isk.Text = getDetailsDS.Tables(0).Rows(0).Item("Hydrogen_Isotopes").ToString
        Liquid_Ozone_Isk.Text = getDetailsDS.Tables(0).Rows(0).Item("Liquid_Ozone").ToString
        Nitrogen_Isotopes_Isk.Text = getDetailsDS.Tables(0).Rows(0).Item("Nitrogen_Isotopes").ToString
        Oxygen_Isotopes_Isk.Text = getDetailsDS.Tables(0).Rows(0).Item("Oxygen_Isotopes").ToString
        Strontium_Clathrates_Isk.Text = getDetailsDS.Tables(0).Rows(0).Item("Strontium_Clathrates").ToString


    End Sub
End Class