
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 10/26/2019 07:16:14
-- Generated from EDMX file: C:\Users\Thomas Kleist\source\repos\DLUPersistence-service-api\dlu-persistence-api\DiMPdotNetDevEntities.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [DiMPdotNetDev];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_tblBladeIGrupper_tblBladStamdata]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tblMedIGruppe] DROP CONSTRAINT [FK_tblBladeIGrupper_tblBladStamdata];
GO
IF OBJECT_ID(N'[dbo].[FK_tblBladStamdata_OrdrecheckSendeDagID_tblDage_DagID]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tblBladStamdata] DROP CONSTRAINT [FK_tblBladStamdata_OrdrecheckSendeDagID_tblDage_DagID];
GO
IF OBJECT_ID(N'[dbo].[FK_tblBladStamdata_UgedagID_tblDage_DagID]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tblBladStamdata] DROP CONSTRAINT [FK_tblBladStamdata_UgedagID_tblDage_DagID];
GO
IF OBJECT_ID(N'[dbo].[FK_tblBladStamdata_tblDelOmråde]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tblBladStamdata] DROP CONSTRAINT [FK_tblBladStamdata_tblDelOmråde];
GO
IF OBJECT_ID(N'[dbo].[FK_tblBladStamdata_tblGeoKoder]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tblBladStamdata] DROP CONSTRAINT [FK_tblBladStamdata_tblGeoKoder];
GO
IF OBJECT_ID(N'[dbo].[FK_tblBladStamdata_tblHovedGruppe]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tblBladStamdata] DROP CONSTRAINT [FK_tblBladStamdata_tblHovedGruppe];
GO
IF OBJECT_ID(N'[dbo].[FK_tblBladStamdata_tblPostNr]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tblBladStamdata] DROP CONSTRAINT [FK_tblBladStamdata_tblPostNr];
GO
IF OBJECT_ID(N'[dbo].[FK_tblBladStamdata_tblRegioner]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tblBladStamdata] DROP CONSTRAINT [FK_tblBladStamdata_tblRegioner];
GO
IF OBJECT_ID(N'[dbo].[FK_tblBladTillaeg_tblBladStamdata]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tblBladTillaeg] DROP CONSTRAINT [FK_tblBladTillaeg_tblBladStamdata];
GO
IF OBJECT_ID(N'[dbo].[FK_tblBladTillaeg_tblBladTillaegsType]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tblBladTillaeg] DROP CONSTRAINT [FK_tblBladTillaeg_tblBladTillaegsType];
GO
IF OBJECT_ID(N'[dbo].[FK_tblFejl_tblFejlTekst]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tblAnnoncekontrol] DROP CONSTRAINT [FK_tblFejl_tblFejlTekst];
GO
IF OBJECT_ID(N'[dbo].[FK_tblKonkurrentDækning_tblKonkurrenter]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tblKonkurrentDækning] DROP CONSTRAINT [FK_tblKonkurrentDækning_tblKonkurrenter];
GO
IF OBJECT_ID(N'[dbo].[FK_tblKonkurrentDækning_tblPostNr]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tblKonkurrentDækning] DROP CONSTRAINT [FK_tblKonkurrentDækning_tblPostNr];
GO
IF OBJECT_ID(N'[dbo].[FK_tblKontakter_tblKontaktTitler]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tblKontakter] DROP CONSTRAINT [FK_tblKontakter_tblKontaktTitler];
GO
IF OBJECT_ID(N'[dbo].[FK_tblKontakterArbOmråderPrKontakt_tblKontaktArbOmråder]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tblKontakterArbOmråderPrKontakt] DROP CONSTRAINT [FK_tblKontakterArbOmråderPrKontakt_tblKontaktArbOmråder];
GO
IF OBJECT_ID(N'[dbo].[FK_tblKontakterArbOmråderPrKontakt_tblKontakter]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tblKontakterArbOmråderPrKontakt] DROP CONSTRAINT [FK_tblKontakterArbOmråderPrKontakt_tblKontakter];
GO
IF OBJECT_ID(N'[dbo].[FK_tblKontakterPrBlad_tblBladStamdataKopi]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tblKontakterPrBlad] DROP CONSTRAINT [FK_tblKontakterPrBlad_tblBladStamdataKopi];
GO
IF OBJECT_ID(N'[dbo].[FK_tblKontakterPrBlad_tblKontakter]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tblKontakterPrBlad] DROP CONSTRAINT [FK_tblKontakterPrBlad_tblKontakter];
GO
IF OBJECT_ID(N'[dbo].[FK_tblKontaktFunktionerPrBlad_tblKontakterPrBlad]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tblKontaktFunktionerPrBlad] DROP CONSTRAINT [FK_tblKontaktFunktionerPrBlad_tblKontakterPrBlad];
GO
IF OBJECT_ID(N'[dbo].[FK_tblKontaktFunktionerPrBlad_tblKontaktFunktioner]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tblKontaktFunktionerPrBlad] DROP CONSTRAINT [FK_tblKontaktFunktionerPrBlad_tblKontaktFunktioner];
GO
IF OBJECT_ID(N'[dbo].[FK_tblMateriale_tblMedieplanNr]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tblMateriale] DROP CONSTRAINT [FK_tblMateriale_tblMedieplanNr];
GO
IF OBJECT_ID(N'[dbo].[FK_tblMedieplan_tblDPKulør]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tblMedieplan] DROP CONSTRAINT [FK_tblMedieplan_tblDPKulør];
GO
IF OBJECT_ID(N'[dbo].[FK_tblMedieplan_tblMedieplanNr]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tblMedieplan] DROP CONSTRAINT [FK_tblMedieplan_tblMedieplanNr];
GO
IF OBJECT_ID(N'[dbo].[FK_tblMedieplan_tblPlacering]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tblMedieplan] DROP CONSTRAINT [FK_tblMedieplan_tblPlacering];
GO
IF OBJECT_ID(N'[dbo].[FK_tblMedieplanLinjer_tblBladStamdata]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tblMedieplanLinjer] DROP CONSTRAINT [FK_tblMedieplanLinjer_tblBladStamdata];
GO
IF OBJECT_ID(N'[dbo].[FK_tblMedieplanLinjer_tblFejl]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tblMedieplanLinjer] DROP CONSTRAINT [FK_tblMedieplanLinjer_tblFejl];
GO
IF OBJECT_ID(N'[dbo].[FK_tblMedieplanLinjer_tblMateriale]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tblMedieplanLinjer] DROP CONSTRAINT [FK_tblMedieplanLinjer_tblMateriale];
GO
IF OBJECT_ID(N'[dbo].[FK_tblMedieplanLinjer_tblMedieplan]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tblMedieplanLinjer] DROP CONSTRAINT [FK_tblMedieplanLinjer_tblMedieplan];
GO
IF OBJECT_ID(N'[dbo].[FK_tblMedIGruppe_tblGrupper]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tblMedIGruppe] DROP CONSTRAINT [FK_tblMedIGruppe_tblGrupper];
GO
IF OBJECT_ID(N'[dbo].[FK_tblOrdreGebyrNavision_tblOrdreNavision]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tblOrdreGebyrNavision] DROP CONSTRAINT [FK_tblOrdreGebyrNavision_tblOrdreNavision];
GO
IF OBJECT_ID(N'[dbo].[FK_tblOrdreLinjerNavision_tblOrdreNavision]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tblOrdreLinjerNavision] DROP CONSTRAINT [FK_tblOrdreLinjerNavision_tblOrdreNavision];
GO
IF OBJECT_ID(N'[dbo].[FK_tblPostNrSøgning_tblPostNr]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tblPostNrSøgning] DROP CONSTRAINT [FK_tblPostNrSøgning_tblPostNr];
GO
IF OBJECT_ID(N'[dbo].[FK_tblPriser_tblBladStamdata]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tblPriser] DROP CONSTRAINT [FK_tblPriser_tblBladStamdata];
GO
IF OBJECT_ID(N'[dbo].[FK_tblPriser_tblPlacering]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tblPriser] DROP CONSTRAINT [FK_tblPriser_tblPlacering];
GO
IF OBJECT_ID(N'[dbo].[FK_tblPriser_tblPrislister]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tblPriser] DROP CONSTRAINT [FK_tblPriser_tblPrislister];
GO
IF OBJECT_ID(N'[dbo].[FK_tblPrislisterPrBladPrÅr_tblBladStamdata]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tblPrislisterPrBladPrÅr] DROP CONSTRAINT [FK_tblPrislisterPrBladPrÅr_tblBladStamdata];
GO
IF OBJECT_ID(N'[dbo].[FK_tblPrislisterPrBladPrÅr_tblPrislister]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tblPrislisterPrBladPrÅr] DROP CONSTRAINT [FK_tblPrislisterPrBladPrÅr_tblPrislister];
GO
IF OBJECT_ID(N'[dbo].[FK_tblPrislisterPrBladPrUge_tblBladStamdata]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tblPrislisterPrBladPrUge] DROP CONSTRAINT [FK_tblPrislisterPrBladPrUge_tblBladStamdata];
GO
IF OBJECT_ID(N'[dbo].[FK_tblPrislisterPrBladPrUge_tblPrislister]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tblPrislisterPrBladPrUge] DROP CONSTRAINT [FK_tblPrislisterPrBladPrUge_tblPrislister];
GO
IF OBJECT_ID(N'[dbo].[FK_tblStamBladBogHolderi_tblBladStamdata]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tblStamBladBogHolderi] DROP CONSTRAINT [FK_tblStamBladBogHolderi_tblBladStamdata];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[dtproperties]', 'U') IS NOT NULL
    DROP TABLE [dbo].[dtproperties];
GO
IF OBJECT_ID(N'[dbo].[KontaktTitler]', 'U') IS NOT NULL
    DROP TABLE [dbo].[KontaktTitler];
GO
IF OBJECT_ID(N'[dbo].[OpdateringsTekst]', 'U') IS NOT NULL
    DROP TABLE [dbo].[OpdateringsTekst];
GO
IF OBJECT_ID(N'[dbo].[sysdiagrams]', 'U') IS NOT NULL
    DROP TABLE [dbo].[sysdiagrams];
GO
IF OBJECT_ID(N'[dbo].[tblAnnoncekontrol]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tblAnnoncekontrol];
GO
IF OBJECT_ID(N'[dbo].[tblBladDækning]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tblBladDækning];
GO
IF OBJECT_ID(N'[dbo].[tblBladKommentar]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tblBladKommentar];
GO
IF OBJECT_ID(N'[dbo].[tblBladnavnMappingFraDO]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tblBladnavnMappingFraDO];
GO
IF OBJECT_ID(N'[dbo].[tblBladRabat]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tblBladRabat];
GO
IF OBJECT_ID(N'[dbo].[tblBladRabatter]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tblBladRabatter];
GO
IF OBJECT_ID(N'[dbo].[tblBladStamdata]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tblBladStamdata];
GO
IF OBJECT_ID(N'[dbo].[tblBladStamdataKopi]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tblBladStamdataKopi];
GO
IF OBJECT_ID(N'[dbo].[tblBladTillaeg]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tblBladTillaeg];
GO
IF OBJECT_ID(N'[dbo].[tblBladTillaegsType]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tblBladTillaegsType];
GO
IF OBJECT_ID(N'[dbo].[tblBladUdsendingKontakter]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tblBladUdsendingKontakter];
GO
IF OBJECT_ID(N'[dbo].[tblBrugerData]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tblBrugerData];
GO
IF OBJECT_ID(N'[dbo].[tblDage]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tblDage];
GO
IF OBJECT_ID(N'[dbo].[tblDelOmråde]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tblDelOmråde];
GO
IF OBJECT_ID(N'[dbo].[tblDPKulør]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tblDPKulør];
GO
IF OBJECT_ID(N'[dbo].[tblEjerforhold]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tblEjerforhold];
GO
IF OBJECT_ID(N'[dbo].[tblFakturaFejl]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tblFakturaFejl];
GO
IF OBJECT_ID(N'[dbo].[tblFakturaFejlTekst]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tblFakturaFejlTekst];
GO
IF OBJECT_ID(N'[dbo].[tblFaktureringsBilag]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tblFaktureringsBilag];
GO
IF OBJECT_ID(N'[dbo].[tblFejlTekst]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tblFejlTekst];
GO
IF OBJECT_ID(N'[dbo].[tblGeoKode]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tblGeoKode];
GO
IF OBJECT_ID(N'[dbo].[tblGrupper]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tblGrupper];
GO
IF OBJECT_ID(N'[dbo].[tblGruppeRabatter]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tblGruppeRabatter];
GO
IF OBJECT_ID(N'[dbo].[tblHovedGruppe]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tblHovedGruppe];
GO
IF OBJECT_ID(N'[dbo].[tblKonkurrentDækning]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tblKonkurrentDækning];
GO
IF OBJECT_ID(N'[dbo].[tblKonkurrenter]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tblKonkurrenter];
GO
IF OBJECT_ID(N'[dbo].[tblKontaktArbOmråder]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tblKontaktArbOmråder];
GO
IF OBJECT_ID(N'[dbo].[tblKontakter]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tblKontakter];
GO
IF OBJECT_ID(N'[dbo].[tblKontakterArbOmråderPrKontakt]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tblKontakterArbOmråderPrKontakt];
GO
IF OBJECT_ID(N'[dbo].[tblKontakterPrBlad]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tblKontakterPrBlad];
GO
IF OBJECT_ID(N'[dbo].[tblKontaktFunktioner]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tblKontaktFunktioner];
GO
IF OBJECT_ID(N'[dbo].[tblKontaktFunktionerPrBlad]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tblKontaktFunktionerPrBlad];
GO
IF OBJECT_ID(N'[dbo].[tblKontaktTitler]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tblKontaktTitler];
GO
IF OBJECT_ID(N'[dbo].[tblMateriale]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tblMateriale];
GO
IF OBJECT_ID(N'[dbo].[tblMedieplan]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tblMedieplan];
GO
IF OBJECT_ID(N'[dbo].[tblMedieplanÆndringer]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tblMedieplanÆndringer];
GO
IF OBJECT_ID(N'[dbo].[tblMedieplanLinjer]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tblMedieplanLinjer];
GO
IF OBJECT_ID(N'[dbo].[tblMedieplanNr]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tblMedieplanNr];
GO
IF OBJECT_ID(N'[dbo].[tblMedIGruppe]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tblMedIGruppe];
GO
IF OBJECT_ID(N'[dbo].[tblOphørtBlad]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tblOphørtBlad];
GO
IF OBJECT_ID(N'[dbo].[tblOrdreGebyrNavision]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tblOrdreGebyrNavision];
GO
IF OBJECT_ID(N'[dbo].[tblOrdreLinjerNavision]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tblOrdreLinjerNavision];
GO
IF OBJECT_ID(N'[dbo].[tblOrdreNavision]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tblOrdreNavision];
GO
IF OBJECT_ID(N'[dbo].[tblPlacering]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tblPlacering];
GO
IF OBJECT_ID(N'[dbo].[tblPostNr]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tblPostNr];
GO
IF OBJECT_ID(N'[dbo].[tblPostNrSøgning]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tblPostNrSøgning];
GO
IF OBJECT_ID(N'[dbo].[tblPriceAsking]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tblPriceAsking];
GO
IF OBJECT_ID(N'[dbo].[tblPriser]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tblPriser];
GO
IF OBJECT_ID(N'[dbo].[tblPrislister]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tblPrislister];
GO
IF OBJECT_ID(N'[dbo].[tblPrislisterPrBladPrÅr]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tblPrislisterPrBladPrÅr];
GO
IF OBJECT_ID(N'[dbo].[tblPrislisterPrBladPrUge]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tblPrislisterPrBladPrUge];
GO
IF OBJECT_ID(N'[dbo].[tblRegion]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tblRegion];
GO
IF OBJECT_ID(N'[dbo].[tblRemindereSendt]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tblRemindereSendt];
GO
IF OBJECT_ID(N'[dbo].[tblStamBladBogHolderi]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tblStamBladBogHolderi];
GO
IF OBJECT_ID(N'[dbo].[tblStambladKoncern]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tblStambladKoncern];
GO
IF OBJECT_ID(N'[dbo].[tblStambladKontakter]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tblStambladKontakter];
GO
IF OBJECT_ID(N'[dbo].[tblStambladUdsendingEmailTyper]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tblStambladUdsendingEmailTyper];
GO
IF OBJECT_ID(N'[dbo].[tblSupportBilag]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tblSupportBilag];
GO
IF OBJECT_ID(N'[dbo].[tblWEBeMails]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tblWEBeMails];
GO
IF OBJECT_ID(N'[dbo].[tblWEBForespørgsel]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tblWEBForespørgsel];
GO
IF OBJECT_ID(N'[dbo].[tblWEBForespørgselLinjer]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tblWEBForespørgselLinjer];
GO
IF OBJECT_ID(N'[dbo].[tblWEBSendTilKollega]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tblWEBSendTilKollega];
GO
IF OBJECT_ID(N'[dbo].[User]', 'U') IS NOT NULL
    DROP TABLE [dbo].[User];
GO
IF OBJECT_ID(N'[DiMPdotNetDevModelStoreContainer].[bladtlfogfaxkopi]', 'U') IS NOT NULL
    DROP TABLE [DiMPdotNetDevModelStoreContainer].[bladtlfogfaxkopi];
GO
IF OBJECT_ID(N'[DiMPdotNetDevModelStoreContainer].[delPriser]', 'U') IS NOT NULL
    DROP TABLE [DiMPdotNetDevModelStoreContainer].[delPriser];
GO
IF OBJECT_ID(N'[DiMPdotNetDevModelStoreContainer].[HerningFolkeblad]', 'U') IS NOT NULL
    DROP TABLE [DiMPdotNetDevModelStoreContainer].[HerningFolkeblad];
GO
IF OBJECT_ID(N'[DiMPdotNetDevModelStoreContainer].[tblAktiveVærdier]', 'U') IS NOT NULL
    DROP TABLE [DiMPdotNetDevModelStoreContainer].[tblAktiveVærdier];
GO
IF OBJECT_ID(N'[DiMPdotNetDevModelStoreContainer].[tblAktivGruppeVersion]', 'U') IS NOT NULL
    DROP TABLE [DiMPdotNetDevModelStoreContainer].[tblAktivGruppeVersion];
GO
IF OBJECT_ID(N'[DiMPdotNetDevModelStoreContainer].[tblFarveTillægWebApp]', 'U') IS NOT NULL
    DROP TABLE [DiMPdotNetDevModelStoreContainer].[tblFarveTillægWebApp];
GO
IF OBJECT_ID(N'[DiMPdotNetDevModelStoreContainer].[tblMmPrisWebApp]', 'U') IS NOT NULL
    DROP TABLE [DiMPdotNetDevModelStoreContainer].[tblMmPrisWebApp];
GO
IF OBJECT_ID(N'[DiMPdotNetDevModelStoreContainer].[tblPlannerPlaner]', 'U') IS NOT NULL
    DROP TABLE [DiMPdotNetDevModelStoreContainer].[tblPlannerPlaner];
GO
IF OBJECT_ID(N'[DiMPdotNetDevModelStoreContainer].[tempPriser]', 'U') IS NOT NULL
    DROP TABLE [DiMPdotNetDevModelStoreContainer].[tempPriser];
GO
IF OBJECT_ID(N'[DiMPdotNetDevModelStoreContainer].[tmpNyeDeadlines]', 'U') IS NOT NULL
    DROP TABLE [DiMPdotNetDevModelStoreContainer].[tmpNyeDeadlines];
GO
IF OBJECT_ID(N'[DiMPdotNetDevModelStoreContainer].[tnpOrdreNr]', 'U') IS NOT NULL
    DROP TABLE [DiMPdotNetDevModelStoreContainer].[tnpOrdreNr];
GO
IF OBJECT_ID(N'[DiMPdotNetDevModelStoreContainer].[tnpOrdreNr2]', 'U') IS NOT NULL
    DROP TABLE [DiMPdotNetDevModelStoreContainer].[tnpOrdreNr2];
GO
IF OBJECT_ID(N'[DiMPdotNetDevModelStoreContainer].[tnpOrdreNr3]', 'U') IS NOT NULL
    DROP TABLE [DiMPdotNetDevModelStoreContainer].[tnpOrdreNr3];
GO
IF OBJECT_ID(N'[DiMPdotNetDevModelStoreContainer].[AktiveUgeaviserMedAlleData]', 'U') IS NOT NULL
    DROP TABLE [DiMPdotNetDevModelStoreContainer].[AktiveUgeaviserMedAlleData];
GO
IF OBJECT_ID(N'[DiMPdotNetDevModelStoreContainer].[FakturaFejlFindes]', 'U') IS NOT NULL
    DROP TABLE [DiMPdotNetDevModelStoreContainer].[FakturaFejlFindes];
GO
IF OBJECT_ID(N'[DiMPdotNetDevModelStoreContainer].[FindFejlLinjer]', 'U') IS NOT NULL
    DROP TABLE [DiMPdotNetDevModelStoreContainer].[FindFejlLinjer];
GO
IF OBJECT_ID(N'[DiMPdotNetDevModelStoreContainer].[GammelAnnoncørID]', 'U') IS NOT NULL
    DROP TABLE [DiMPdotNetDevModelStoreContainer].[GammelAnnoncørID];
GO
IF OBJECT_ID(N'[DiMPdotNetDevModelStoreContainer].[LPRoller]', 'U') IS NOT NULL
    DROP TABLE [DiMPdotNetDevModelStoreContainer].[LPRoller];
GO
IF OBJECT_ID(N'[DiMPdotNetDevModelStoreContainer].[NavisionContact]', 'U') IS NOT NULL
    DROP TABLE [DiMPdotNetDevModelStoreContainer].[NavisionContact];
GO
IF OBJECT_ID(N'[DiMPdotNetDevModelStoreContainer].[NavisionContact2]', 'U') IS NOT NULL
    DROP TABLE [DiMPdotNetDevModelStoreContainer].[NavisionContact2];
GO
IF OBJECT_ID(N'[DiMPdotNetDevModelStoreContainer].[Salesperson]', 'U') IS NOT NULL
    DROP TABLE [DiMPdotNetDevModelStoreContainer].[Salesperson];
GO
IF OBJECT_ID(N'[DiMPdotNetDevModelStoreContainer].[UgeaviserTilGrid]', 'U') IS NOT NULL
    DROP TABLE [DiMPdotNetDevModelStoreContainer].[UgeaviserTilGrid];
GO
IF OBJECT_ID(N'[DiMPdotNetDevModelStoreContainer].[viewBlade]', 'U') IS NOT NULL
    DROP TABLE [DiMPdotNetDevModelStoreContainer].[viewBlade];
GO
IF OBJECT_ID(N'[DiMPdotNetDevModelStoreContainer].[viewBookingListe]', 'U') IS NOT NULL
    DROP TABLE [DiMPdotNetDevModelStoreContainer].[viewBookingListe];
GO
IF OBJECT_ID(N'[DiMPdotNetDevModelStoreContainer].[viewGrupper]', 'U') IS NOT NULL
    DROP TABLE [DiMPdotNetDevModelStoreContainer].[viewGrupper];
GO
IF OBJECT_ID(N'[DiMPdotNetDevModelStoreContainer].[viewLinjeDiff]', 'U') IS NOT NULL
    DROP TABLE [DiMPdotNetDevModelStoreContainer].[viewLinjeDiff];
GO
IF OBJECT_ID(N'[DiMPdotNetDevModelStoreContainer].[viewOrdre]', 'U') IS NOT NULL
    DROP TABLE [DiMPdotNetDevModelStoreContainer].[viewOrdre];
GO
IF OBJECT_ID(N'[DiMPdotNetDevModelStoreContainer].[viewOrdreErSendt]', 'U') IS NOT NULL
    DROP TABLE [DiMPdotNetDevModelStoreContainer].[viewOrdreErSendt];
GO
IF OBJECT_ID(N'[DiMPdotNetDevModelStoreContainer].[viewOrdreFIND]', 'U') IS NOT NULL
    DROP TABLE [DiMPdotNetDevModelStoreContainer].[viewOrdreFIND];
GO
IF OBJECT_ID(N'[DiMPdotNetDevModelStoreContainer].[viewOrdreIkkeSendt]', 'U') IS NOT NULL
    DROP TABLE [DiMPdotNetDevModelStoreContainer].[viewOrdreIkkeSendt];
GO
IF OBJECT_ID(N'[DiMPdotNetDevModelStoreContainer].[viewOrdreLinjer]', 'U') IS NOT NULL
    DROP TABLE [DiMPdotNetDevModelStoreContainer].[viewOrdreLinjer];
GO
IF OBJECT_ID(N'[DiMPdotNetDevModelStoreContainer].[viewOrdreLinjerFIND]', 'U') IS NOT NULL
    DROP TABLE [DiMPdotNetDevModelStoreContainer].[viewOrdreLinjerFIND];
GO
IF OBJECT_ID(N'[DiMPdotNetDevModelStoreContainer].[viewOrdreSendtManglerMateriale]', 'U') IS NOT NULL
    DROP TABLE [DiMPdotNetDevModelStoreContainer].[viewOrdreSendtManglerMateriale];
GO
IF OBJECT_ID(N'[DiMPdotNetDevModelStoreContainer].[viewOversigt]', 'U') IS NOT NULL
    DROP TABLE [DiMPdotNetDevModelStoreContainer].[viewOversigt];
GO
IF OBJECT_ID(N'[DiMPdotNetDevModelStoreContainer].[viewUpdateStatusIMedieplan]', 'U') IS NOT NULL
    DROP TABLE [DiMPdotNetDevModelStoreContainer].[viewUpdateStatusIMedieplan];
GO
IF OBJECT_ID(N'[DiMPdotNetDevModelStoreContainer].[viewUpdateStatusIMedieplanNr]', 'U') IS NOT NULL
    DROP TABLE [DiMPdotNetDevModelStoreContainer].[viewUpdateStatusIMedieplanNr];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'dtproperties'
CREATE TABLE [dbo].[dtproperties] (
    [id] int IDENTITY(1,1) NOT NULL,
    [objectid] int  NULL,
    [property] varchar(64)  NOT NULL,
    [value] varchar(255)  NULL,
    [uvalue] nvarchar(255)  NULL,
    [lvalue] varbinary(max)  NULL,
    [version] int  NOT NULL
);
GO

-- Creating table 'KontaktTitlers'
CREATE TABLE [dbo].[KontaktTitlers] (
    [id] int IDENTITY(1,1) NOT NULL,
    [titel] varchar(50)  NULL
);
GO

-- Creating table 'OpdateringsTeksts'
CREATE TABLE [dbo].[OpdateringsTeksts] (
    [LPVersion] nvarchar(10)  NOT NULL,
    [Beskrivelse] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'sysdiagrams'
CREATE TABLE [dbo].[sysdiagrams] (
    [name] nvarchar(128)  NOT NULL,
    [principal_id] int  NOT NULL,
    [diagram_id] int IDENTITY(1,1) NOT NULL,
    [version] int  NULL,
    [definition] varbinary(max)  NULL
);
GO

-- Creating table 'tblAnnoncekontrols'
CREATE TABLE [dbo].[tblAnnoncekontrols] (
    [MedieplanNr] int  NOT NULL,
    [UgeavisID] int  NOT NULL,
    [ErKontrolleret] bit  NOT NULL,
    [KontrolTidspunkt] datetime  NOT NULL,
    [KontrollørEmail] nvarchar(50)  NOT NULL,
    [KontrolleretAfDLU] bit  NOT NULL,
    [Fejlkode] tinyint  NOT NULL,
    [Ansvar] nvarchar(10)  NOT NULL,
    [IndrykketPåSide] nvarchar(10)  NOT NULL,
    [FaktureresTil] nvarchar(10)  NOT NULL,
    [SidePlacering] tinyint  NOT NULL
);
GO

-- Creating table 'tblBladDækning'
CREATE TABLE [dbo].[tblBladDækning] (
    [BladID] int  NOT NULL,
    [PostNr] int  NOT NULL,
    [Oplag] int  NOT NULL,
    [DækningsGrad] int  NOT NULL
);
GO

-- Creating table 'tblBladKommentars'
CREATE TABLE [dbo].[tblBladKommentars] (
    [id] int IDENTITY(1,1) NOT NULL,
    [bladid] int  NULL,
    [tekst] varchar(max)  NULL,
    [date] datetime  NOT NULL
);
GO

-- Creating table 'tblBladnavnMappingFraDOes'
CREATE TABLE [dbo].[tblBladnavnMappingFraDOes] (
    [BladID] int  NOT NULL,
    [DLUNavn] nvarchar(30)  NOT NULL,
    [Medie] nvarchar(30)  NOT NULL
);
GO

-- Creating table 'tblBladRabats'
CREATE TABLE [dbo].[tblBladRabats] (
    [id] int IDENTITY(1,1) NOT NULL,
    [ejerforholdid] int  NULL,
    [bladid] int  NULL,
    [rabat] float  NULL,
    [rabattype] int  NULL
);
GO

-- Creating table 'tblBladRabatters'
CREATE TABLE [dbo].[tblBladRabatters] (
    [id] int IDENTITY(1,1) NOT NULL,
    [bladid] int  NULL,
    [rabattype] int  NOT NULL,
    [pris] float  NOT NULL,
    [ejerforholdid] int  NULL
);
GO

-- Creating table 'tblBladStamdatas'
CREATE TABLE [dbo].[tblBladStamdatas] (
    [BladID] int  NOT NULL,
    [Navn] nchar(30)  NOT NULL,
    [Navn2] nvarchar(30)  NULL,
    [Adresse] nchar(30)  NULL,
    [Adresse2] nvarchar(30)  NULL,
    [PostNr] int  NULL,
    [Tlf] char(15)  NULL,
    [Fax] char(15)  NULL,
    [CVR] char(15)  NULL,
    [Kontaktperson] nvarchar(30)  NULL,
    [HovedgruppeID] tinyint  NULL,
    [MedlemMåned] tinyint  NULL,
    [MedlemÅr] tinyint  NULL,
    [Ejerforhold] nvarchar(30)  NOT NULL,
    [Koncern] nvarchar(30)  NULL,
    [Ophørt] bit  NOT NULL,
    [VisPåWWW] bit  NOT NULL,
    [RegionID] tinyint  NULL,
    [DelOmrådeID] tinyint  NULL,
    [DiMPDelOmrådeKode] nvarchar(2)  NULL,
    [GeoKodeID] tinyint  NULL,
    [Totalområde] int  NULL,
    [TotalområdePct] tinyint  NULL,
    [Primær] int  NULL,
    [PrimærPct] tinyint  NULL,
    [WWWDækningSomTekst] nvarchar(max)  NULL,
    [Oplag] int  NULL,
    [UgedagID] tinyint  NULL,
    [Format] nchar(15)  NULL,
    [OrdredeadlineTekst] nvarchar(20)  NULL,
    [OrdredeadlineRubrik] nvarchar(20)  NULL,
    [MaterialedeadlineTekst] nvarchar(20)  NULL,
    [MaterialedeadlineRubrik] nvarchar(20)  NULL,
    [OrdreEmail] nvarchar(200)  NULL,
    [OrdrecheckEmail] nvarchar(50)  NULL,
    [OrdrecheckSendeDagID] tinyint  NULL,
    [SendetidOrdrecheck] char(5)  NULL,
    [SendIndeværendeUge] bit  NULL,
    [StamdataEmail] nvarchar(50)  NULL,
    [PrisforespørgselEmails] nvarchar(200)  NULL,
    [OrienteringEmails] nvarchar(200)  NULL,
    [Emails] nvarchar(200)  NULL,
    [KontaktpersonerEmails] nvarchar(200)  NULL,
    [BogholderiEmails] nvarchar(200)  NULL,
    [MedieNetKode] varchar(15)  NULL,
    [MatGodtBeløb] tinyint  NULL,
    [Hjemmeside] varchar(100)  NULL,
    [RedaktionEmail] nvarchar(50)  NULL,
    [AnnonceEmail] nvarchar(50)  NULL,
    [MaterialeEmail] nvarchar(50)  NULL,
    [AnnonceKontrolEmail] nvarchar(50)  NULL,
    [BilagsbladeEmail] nvarchar(50)  NULL,
    [FakturaGruppeID] int  NOT NULL,
    [SalgsGruppeID] int  NULL,
    [GruppeRabat] varchar(max)  NULL,
    [SamannonceringsRabat] varchar(max)  NULL,
    [MåGiveFarveRabat] bit  NULL,
    [GiverWebTillæg] bit  NOT NULL,
    [OrdreDeadlineTekstDag] tinyint  NULL,
    [OrdreDeadlineTekstKl] nvarchar(5)  NULL,
    [MaterialeDeadlineTekstDag] tinyint  NULL,
    [MaterialeDeadlineTekstKl] nvarchar(5)  NULL,
    [OrdreDeadlineRubrikDag] tinyint  NULL,
    [OrdreDeadlineRubrikKl] nvarchar(5)  NULL,
    [MaterialeDeadlineRubrikDag] tinyint  NULL,
    [MaterialeDeadlineRubrikKl] nvarchar(5)  NULL,
    [Overført] bit  NOT NULL,
    [timestamp] binary(8)  NOT NULL
);
GO

-- Creating table 'tblBladStamdataKopis'
CREATE TABLE [dbo].[tblBladStamdataKopis] (
    [BladID] int  NOT NULL,
    [Navn] nvarchar(30)  NOT NULL,
    [Navn2] nvarchar(30)  NULL,
    [Adresse] nvarchar(30)  NOT NULL,
    [Adresse2] nvarchar(30)  NULL,
    [PostNr] int  NULL,
    [Tlf] char(15)  NOT NULL,
    [Fax] char(15)  NOT NULL,
    [CVR] char(15)  NULL,
    [FIK] nvarchar(15)  NULL,
    [Kontaktperson] nvarchar(30)  NULL,
    [HovedgruppeID] tinyint  NULL,
    [MedlemMåned] tinyint  NULL,
    [MedlemÅr] tinyint  NULL,
    [MedlemSiden] datetime  NULL,
    [Ejerforhold] nvarchar(30)  NOT NULL,
    [Ophørt] bit  NOT NULL,
    [VisPåWWW] bit  NOT NULL,
    [RegionID] tinyint  NULL,
    [DelOmrådeID] tinyint  NULL,
    [DiMPDelOmrådeKode] nvarchar(2)  NULL,
    [GeoKodeID] tinyint  NULL,
    [Totalområde] int  NULL,
    [TotalområdePct] tinyint  NULL,
    [Primær] int  NULL,
    [PrimærPct] tinyint  NULL,
    [WWWDækningSomTekst] nvarchar(max)  NULL,
    [Oplag] int  NULL,
    [UgedagID] tinyint  NULL,
    [Format] nchar(15)  NULL,
    [OrdreEmail] nvarchar(200)  NULL,
    [OrdrecheckEmail] nvarchar(50)  NULL,
    [OrdrecheckSendeDagID] tinyint  NULL,
    [SendetidOrdrecheck] char(5)  NULL,
    [SendIndeværendeUge] bit  NULL,
    [StamdataEmail] nvarchar(50)  NULL,
    [PrisforespørgselEmails] nvarchar(200)  NULL,
    [OrienteringEmails] nvarchar(200)  NULL,
    [Emails] nvarchar(200)  NULL,
    [KontaktpersonerEmails] nvarchar(200)  NULL,
    [BogholderiEmails] nvarchar(200)  NULL,
    [BogholderiKontaktperson] nvarchar(30)  NULL,
    [MedieNetKode] varchar(15)  NULL,
    [MatGodtBeløb] tinyint  NULL,
    [Hjemmeside] nvarchar(100)  NULL,
    [RedaktionEmail] nvarchar(50)  NULL,
    [AnnonceEmail] nvarchar(50)  NULL,
    [MaterialeEmail] nvarchar(50)  NULL,
    [AnnonceKontrolEmail] nvarchar(50)  NULL,
    [BilagsbladeEmail] nvarchar(50)  NULL,
    [FakturaGruppeID] int  NOT NULL,
    [SalgsGruppeID] int  NULL,
    [GruppeRabat] varchar(max)  NULL,
    [SamannonceringsRabat] varchar(max)  NULL,
    [MåGiveFarveRabat] bit  NULL,
    [GiverWebTillæg] bit  NULL,
    [OrdreDeadlineTekstDag] tinyint  NOT NULL,
    [OrdreDeadlineTekstKl] nvarchar(5)  NOT NULL,
    [MaterialeDeadlineTekstDag] tinyint  NOT NULL,
    [MaterialeDeadlineTekstKl] nvarchar(5)  NOT NULL,
    [OrdreDeadlineRubrikDag] tinyint  NOT NULL,
    [OrdreDeadlineRubrikKl] nvarchar(5)  NOT NULL,
    [MaterialeDeadlineRubrikDag] tinyint  NOT NULL,
    [MaterialeDeadlineRubrikKl] nvarchar(5)  NOT NULL,
    [Overført] bit  NOT NULL,
    [timestamp] binary(8)  NOT NULL
);
GO

-- Creating table 'tblBladTillaegs'
CREATE TABLE [dbo].[tblBladTillaegs] (
    [id] int IDENTITY(1,1) NOT NULL,
    [bladId] int  NULL,
    [typeId] int  NULL,
    [pris] float  NULL
);
GO

-- Creating table 'tblBladTillaegsTypes'
CREATE TABLE [dbo].[tblBladTillaegsTypes] (
    [id] int IDENTITY(1,1) NOT NULL,
    [type] varchar(150)  NULL
);
GO

-- Creating table 'tblBladUdsendingKontakters'
CREATE TABLE [dbo].[tblBladUdsendingKontakters] (
    [id] int IDENTITY(1,1) NOT NULL,
    [bladid] int  NULL,
    [navn] varchar(150)  NULL,
    [mail] varchar(50)  NULL,
    [telefonnummer] int  NULL,
    [type] int  NULL,
    [titel] int  NULL
);
GO

-- Creating table 'tblBrugerDatas'
CREATE TABLE [dbo].[tblBrugerDatas] (
    [Initialer] nvarchar(30)  NOT NULL,
    [SidsteLoginVersion] nvarchar(10)  NOT NULL,
    [NulstilLayout] bit  NOT NULL
);
GO

-- Creating table 'tblDages'
CREATE TABLE [dbo].[tblDages] (
    [DagID] tinyint IDENTITY(1,1) NOT NULL,
    [DagNavn] nvarchar(10)  NOT NULL,
    [DagType] char(1)  NOT NULL,
    [timestamp] binary(8)  NOT NULL
);
GO

-- Creating table 'tblDelOmråde'
CREATE TABLE [dbo].[tblDelOmråde] (
    [DelOmrådeID] tinyint IDENTITY(1,1) NOT NULL,
    [DelOmrådeKode] nchar(1)  NOT NULL,
    [DelOmrådeNavn] nvarchar(30)  NOT NULL,
    [DelOmrådeSortKey] tinyint  NOT NULL,
    [timestamp] binary(8)  NOT NULL
);
GO

-- Creating table 'tblDPKulør'
CREATE TABLE [dbo].[tblDPKulør] (
    [DPKulørID] tinyint IDENTITY(1,1) NOT NULL,
    [Kulør] nchar(10)  NOT NULL
);
GO

-- Creating table 'tblEjerforholds'
CREATE TABLE [dbo].[tblEjerforholds] (
    [EjerforholdID] int IDENTITY(1,1) NOT NULL,
    [Ejerforhold] nvarchar(30)  NOT NULL,
    [WebTillægTekst] decimal(10,4)  NOT NULL,
    [WebTillægRubrik] decimal(10,4)  NOT NULL
);
GO

-- Creating table 'tblFakturaFejls'
CREATE TABLE [dbo].[tblFakturaFejls] (
    [MedieplanNr] int  NOT NULL,
    [Version] smallint  NOT NULL,
    [UgeavisID] int  NOT NULL,
    [FejlKode] smallint  NOT NULL,
    [Ansvarlig] nvarchar(10)  NOT NULL
);
GO

-- Creating table 'tblFakturaFejlTeksts'
CREATE TABLE [dbo].[tblFakturaFejlTeksts] (
    [FejlKode] tinyint  NOT NULL,
    [FejlTekst] nvarchar(50)  NOT NULL
);
GO

-- Creating table 'tblFaktureringsBilags'
CREATE TABLE [dbo].[tblFaktureringsBilags] (
    [MedieplanNr] int  NOT NULL,
    [BemærkningNr] smallint  NOT NULL,
    [UgeavisNavn] nvarchar(30)  NOT NULL,
    [Oprettet] datetime  NOT NULL,
    [OprettetAf] varchar(10)  NOT NULL,
    [RettetAf] varchar(10)  NOT NULL,
    [RettetKl] datetime  NOT NULL,
    [ErRettet] bit  NOT NULL,
    [Tekst] nvarchar(max)  NULL
);
GO

-- Creating table 'tblFejlTeksts'
CREATE TABLE [dbo].[tblFejlTeksts] (
    [Fejlkode] tinyint  NOT NULL,
    [FejlTekst] nvarchar(50)  NOT NULL
);
GO

-- Creating table 'tblGeoKodes'
CREATE TABLE [dbo].[tblGeoKodes] (
    [GeoKodeID] tinyint IDENTITY(1,1) NOT NULL,
    [GeoKodeNavn] nvarchar(30)  NOT NULL,
    [GeoKodeSortKey] tinyint  NOT NULL,
    [timestamp] binary(8)  NOT NULL
);
GO

-- Creating table 'tblGruppers'
CREATE TABLE [dbo].[tblGruppers] (
    [GruppeID] int  NOT NULL,
    [GruppeNavn] nvarchar(50)  NOT NULL,
    [GruppeType] nchar(10)  NOT NULL,
    [AntalBladeForValg] tinyint  NOT NULL,
    [GruppeHovedbladID] int  NULL,
    [OrdreEmail] nvarchar(200)  NULL,
    [MaterialeModtager] nvarchar(50)  NULL,
    [Version] tinyint  NOT NULL,
    [timestamp] binary(8)  NOT NULL
);
GO

-- Creating table 'tblGruppeRabatters'
CREATE TABLE [dbo].[tblGruppeRabatters] (
    [RabatFormID] int IDENTITY(1,1) NOT NULL,
    [GruppeID] int  NOT NULL,
    [PlaceringID] tinyint  NOT NULL,
    [AntalFra] tinyint  NOT NULL,
    [AntalTil] tinyint  NOT NULL,
    [MmRabat] real  NULL,
    [FarveRabat] real  NULL,
    [MmPris] decimal(10,4)  NULL,
    [FarveMin] decimal(10,4)  NULL,
    [FarveMax] decimal(10,4)  NULL,
    [FarveTillæg] decimal(10,4)  NULL,
    [PrisInclFarver] decimal(10,4)  NULL,
    [Version] tinyint  NOT NULL
);
GO

-- Creating table 'tblHovedGruppes'
CREATE TABLE [dbo].[tblHovedGruppes] (
    [HovedGruppeID] tinyint IDENTITY(1,1) NOT NULL,
    [HovedGruppeNavn] varchar(30)  NOT NULL,
    [HovedGruppeSortKey] tinyint  NOT NULL,
    [timestamp] binary(8)  NOT NULL
);
GO

-- Creating table 'tblKonkurrentDækning'
CREATE TABLE [dbo].[tblKonkurrentDækning] (
    [KonkurrentID] tinyint  NOT NULL,
    [PostNr] int  NOT NULL,
    [Oplag] int  NOT NULL,
    [DækningsGrad] int  NOT NULL
);
GO

-- Creating table 'tblKonkurrenters'
CREATE TABLE [dbo].[tblKonkurrenters] (
    [KonkurrentID] tinyint  NOT NULL,
    [KonkurrentNavn] nvarchar(35)  NOT NULL,
    [KonkurentKode] nvarchar(10)  NOT NULL,
    [BladTypeMappingFraDO] nvarchar(50)  NOT NULL,
    [MedieMappingFraDO] nvarchar(50)  NOT NULL
);
GO

-- Creating table 'tblKontaktArbOmråder'
CREATE TABLE [dbo].[tblKontaktArbOmråder] (
    [ArbOmrådeID] int  NOT NULL,
    [ArbOmråde] nvarchar(30)  NOT NULL
);
GO

-- Creating table 'tblKontakters'
CREATE TABLE [dbo].[tblKontakters] (
    [KontaktID] int IDENTITY(1,1) NOT NULL,
    [Fornavn] nvarchar(50)  NOT NULL,
    [Efternavn] nvarchar(50)  NOT NULL,
    [TitelID] int  NULL,
    [Tlfnr] nvarchar(15)  NOT NULL,
    [Mobilnr] nvarchar(10)  NOT NULL,
    [Email] nvarchar(50)  NOT NULL
);
GO

-- Creating table 'tblKontakterPrBlads'
CREATE TABLE [dbo].[tblKontakterPrBlads] (
    [BladID] int  NOT NULL,
    [KontaktID] int  NOT NULL
);
GO

-- Creating table 'tblKontaktFunktioners'
CREATE TABLE [dbo].[tblKontaktFunktioners] (
    [FunktionID] int IDENTITY(1,1) NOT NULL,
    [Funktion] nvarchar(30)  NOT NULL
);
GO

-- Creating table 'tblKontaktTitlers'
CREATE TABLE [dbo].[tblKontaktTitlers] (
    [TitelID] int IDENTITY(1,1) NOT NULL,
    [Titel] nvarchar(30)  NOT NULL
);
GO

-- Creating table 'tblMateriales'
CREATE TABLE [dbo].[tblMateriales] (
    [MedieplanNr] int  NOT NULL,
    [UgeavisID] int  NOT NULL,
    [FilNavn] nvarchar(100)  NOT NULL,
    [ErSendt] bit  NOT NULL,
    [SkalSendes] bit  NOT NULL,
    [FilSti] nvarchar(250)  NOT NULL
);
GO

-- Creating table 'tblMedieplans'
CREATE TABLE [dbo].[tblMedieplans] (
    [MedieplanNr] int  NOT NULL,
    [Version] smallint  NOT NULL,
    [AnnoncørNo_] varchar(20)  NOT NULL,
    [BureauNo_] varchar(20)  NOT NULL,
    [Format1] tinyint  NOT NULL,
    [Format2] smallint  NOT NULL,
    [AntalFarver] tinyint  NOT NULL,
    [DPKulørID] tinyint  NOT NULL,
    [PlaceringID] tinyint  NOT NULL,
    [IndrykningsUge] tinyint  NOT NULL,
    [IndrykningsÅr] smallint  NOT NULL,
    [Beskrivelse] nvarchar(100)  NOT NULL,
    [Overskrift] nvarchar(30)  NOT NULL,
    [Kontaktperson] nvarchar(30)  NOT NULL,
    [KontaktpersonTilhører] tinyint  NOT NULL,
    [Fakturering] tinyint  NOT NULL,
    [RekvisitionsNr] nvarchar(30)  NOT NULL,
    [BilagsBladeTil] smallint  NOT NULL,
    [BilagsBladeTilNavn] nvarchar(30)  NOT NULL,
    [BilagsBladeTilAdresse] nvarchar(30)  NOT NULL,
    [BilagsBladeTilPostNr] int  NOT NULL,
    [BilagsBladeATT] nvarchar(30)  NOT NULL,
    [MaterialeGodtgørelseTil] tinyint  NOT NULL,
    [MaterialeFølgerFra] tinyint  NOT NULL,
    [MaterialeFølgerFraLeverandør] nvarchar(30)  NOT NULL,
    [BrugMaterialeFraUge] tinyint  NOT NULL,
    [MaterialeGodtgørelseAlle] bit  NOT NULL,
    [SikkerhedsGodt] bit  NOT NULL,
    [InfoGodt] bit  NOT NULL,
    [SamletPris] decimal(19,4)  NOT NULL,
    [OprettetDato] datetime  NOT NULL,
    [OrdreDato] datetime  NOT NULL,
    [KonsulentCode] varchar(10)  NOT NULL,
    [Status] tinyint  NOT NULL,
    [RettelserEfterAnnoncekontrol] bit  NOT NULL,
    [TilladFarveSærRabat] bit  NOT NULL,
    [TilladMmSærRabat] bit  NOT NULL,
    [Document_Type] tinyint  NOT NULL,
    [Credit_Reason] nvarchar(50)  NULL,
    [Previous_Version] int  NULL,
    [SammeMateriale] bit  NOT NULL,
    [KunForhandlerBundForskellig] bit  NOT NULL,
    [SammeBureauOrdreNr] bit  NOT NULL,
    [FællesBureauOrdreNr] nvarchar(30)  NOT NULL,
    [BemærkningTilAnnoncør] nvarchar(250)  NOT NULL,
    [BemærkningTilBlade] nvarchar(250)  NOT NULL,
    [WebTillægOpkræves] bit  NULL,
    [MiljøTillægOpkræves] bit  NULL,
    [OpkrævJyskeMiljøTillæg] bit  NULL,
    [OpkrævFynskeMiljøTillæg] bit  NULL,
    [OpkrævNorthMiljøTillæg] bit  NULL,
    [OpkrævDSVPMiljøTillæg] bit  NULL,
    [OpkrævNordjyskeTillæg] bit  NULL,
    [OpkrævJyskeMedierASTillæg] bit  NULL,
    [OpkrævHelsingørMiljøTillæg] bit  NULL
);
GO

-- Creating table 'tblMedieplanÆndringer'
CREATE TABLE [dbo].[tblMedieplanÆndringer] (
    [MedieplanNr] int  NOT NULL,
    [Version] smallint  NOT NULL,
    [ÆndringsTekst] varchar(max)  NULL
);
GO

-- Creating table 'tblMedieplanLinjers'
CREATE TABLE [dbo].[tblMedieplanLinjers] (
    [MedieplanNr] int  NOT NULL,
    [Version] smallint  NOT NULL,
    [UgeavisID] int  NOT NULL,
    [Mm] smallint  NOT NULL,
    [NormalMmPris] decimal(10,4)  NOT NULL,
    [MmPris] decimal(10,4)  NOT NULL,
    [MmRabat] real  NOT NULL,
    [MåGiveMmRabat] bit  NULL,
    [MmTotal] decimal(10,4)  NOT NULL,
    [FarveTillæg] decimal(10,4)  NOT NULL,
    [FarvePris] decimal(10,4)  NOT NULL,
    [FarveRabat] real  NOT NULL,
    [FarveMin] decimal(10,4)  NOT NULL,
    [FarveMax] decimal(10,4)  NOT NULL,
    [FarveTotal] decimal(10,4)  NOT NULL,
    [Total] decimal(10,4)  NOT NULL,
    [MåGiveMaterialeGodtgørelse] bit  NOT NULL,
    [SkalGiveMaterialeGodtgørelse] bit  NOT NULL,
    [MaterialeGodtgørelsePris] decimal(10,4)  NOT NULL,
    [TotalPris] decimal(19,4)  NULL,
    [ManueltÆndret] bit  NOT NULL,
    [ErWeekendGruppe] bit  NOT NULL,
    [WebtillægFaktureresHer] bit  NOT NULL,
    [SendeGruppe] nvarchar(50)  NOT NULL,
    [RabatGruppe] nvarchar(50)  NULL,
    [MedIGrupper] nvarchar(255)  NOT NULL,
    [BureauOrdreNr] nvarchar(30)  NOT NULL,
    [MaterialeNr] nvarchar(30)  NOT NULL,
    [Bemærkning] nvarchar(250)  NOT NULL,
    [MiljøTillæg] decimal(10,4)  NOT NULL,
    [TotalInclTillæg] decimal(10,4)  NOT NULL,
    [PrisLåst] bit  NOT NULL
);
GO

-- Creating table 'tblMedieplanNrs'
CREATE TABLE [dbo].[tblMedieplanNrs] (
    [MedieplanNr] int IDENTITY(1,1) NOT NULL,
    [AktivVersion] smallint  NOT NULL,
    [Status] tinyint  NOT NULL,
    [SupportBilagVedlagt] bit  NOT NULL,
    [SupportBilagVist] bit  NOT NULL,
    [FakturaBemærkning1] nvarchar(50)  NOT NULL,
    [FakturaBemærkning2] nvarchar(50)  NOT NULL,
    [FakturaBemærkning3] nvarchar(50)  NOT NULL,
    [MaterialeModtaget] bit  NOT NULL,
    [BrugtGruppeVersion] tinyint  NOT NULL,
    [OverførtFraPrisforespørgsel] bit  NOT NULL,
    [AnvendtMiljøTillæg] decimal(10,4)  NOT NULL,
    [AnvendtPrisberegningVersion] tinyint  NOT NULL,
    [Kommentar] nvarchar(250)  NOT NULL
);
GO

-- Creating table 'tblMedIGruppes'
CREATE TABLE [dbo].[tblMedIGruppes] (
    [GruppeID] int  NOT NULL,
    [ID] int  NOT NULL,
    [ErTillægsAvis] bit  NOT NULL,
    [Version] tinyint  NOT NULL
);
GO

-- Creating table 'tblOrdreGebyrNavisions'
CREATE TABLE [dbo].[tblOrdreGebyrNavisions] (
    [OrdreNr] int  NOT NULL,
    [Version] smallint  NOT NULL,
    [Document_Type] tinyint  NOT NULL,
    [Type] tinyint  NOT NULL,
    [BladId] int  NOT NULL,
    [Description] varchar(59)  NOT NULL,
    [Amount] decimal(19,4)  NOT NULL
);
GO

-- Creating table 'tblOrdreLinjerNavisions'
CREATE TABLE [dbo].[tblOrdreLinjerNavisions] (
    [OrdreNr] int  NOT NULL,
    [Version] smallint  NOT NULL,
    [Document_Type] tinyint  NOT NULL,
    [BladId] int  NOT NULL,
    [Mm] smallint  NOT NULL,
    [Format] varchar(30)  NOT NULL,
    [AnvendtPris] decimal(10,4)  NOT NULL,
    [SpecialRabat] real  NOT NULL,
    [FarveTillægsPris] decimal(10,4)  NOT NULL,
    [FarveTillægsRabat] real  NOT NULL,
    [MaterialeGodt] bit  NOT NULL,
    [TotalPris] decimal(19,4)  NOT NULL,
    [MaterialePris] decimal(10,4)  NOT NULL,
    [Previous_Order_No] int  NOT NULL,
    [Previous_Version] int  NULL,
    [FirstTime] datetime  NULL,
    [BureauOrdreNr] nvarchar(30)  NOT NULL
);
GO

-- Creating table 'tblOrdreNavisions'
CREATE TABLE [dbo].[tblOrdreNavisions] (
    [OrdreNr] int  NOT NULL,
    [Version] smallint  NOT NULL,
    [Document_Type] tinyint  NOT NULL,
    [AnnoncørID] varchar(20)  NOT NULL,
    [Uge] tinyint  NOT NULL,
    [AntalFarver] tinyint  NOT NULL,
    [OrdreDato] datetime  NOT NULL,
    [SamletPris] decimal(19,4)  NOT NULL,
    [SælgerKode] varchar(10)  NOT NULL,
    [SikkerhedsGodt] bit  NOT NULL,
    [InfoGodt] bit  NOT NULL,
    [BureauOrdreNr] nvarchar(30)  NOT NULL,
    [Bureau] varchar(20)  NOT NULL,
    [EnOrdre] tinyint  NOT NULL,
    [Status] tinyint  NOT NULL,
    [FakBem1] nvarchar(50)  NULL,
    [FakBem2] nvarchar(50)  NULL,
    [FakBem3] nvarchar(50)  NULL,
    [MaterialeGodtgørelseTil] tinyint  NOT NULL,
    [Previous_Order_No] int  NOT NULL,
    [Credit_Reason] nvarchar(50)  NULL,
    [Previous_Version] int  NULL,
    [Item_Description] nvarchar(30)  NULL,
    [Advertiser] nvarchar(50)  NULL,
    [Placement] nvarchar(50)  NULL,
    [SammeBureauOrdreNr] bit  NOT NULL
);
GO

-- Creating table 'tblPlacerings'
CREATE TABLE [dbo].[tblPlacerings] (
    [PlaceringID] tinyint  NOT NULL,
    [Betegnelse] nvarchar(30)  NOT NULL
);
GO

-- Creating table 'tblPostNrs'
CREATE TABLE [dbo].[tblPostNrs] (
    [PostNr] int  NOT NULL,
    [PostBy] nvarchar(30)  NOT NULL,
    [Husstande] int  NOT NULL,
    [MaxDækningsGrad] tinyint  NOT NULL
);
GO

-- Creating table 'tblPostNrSøgning'
CREATE TABLE [dbo].[tblPostNrSøgning] (
    [BrugerNavn] nvarchar(50)  NOT NULL,
    [PostNr] int  NOT NULL
);
GO

-- Creating table 'tblPriceAskings'
CREATE TABLE [dbo].[tblPriceAskings] (
    [id] int  NOT NULL,
    [stambladId] int  NULL,
    [name] varchar(100)  NULL,
    [telefon] int  NULL,
    [email] varchar(100)  NULL
);
GO

-- Creating table 'tblPrisers'
CREATE TABLE [dbo].[tblPrisers] (
    [BladID] int  NOT NULL,
    [PlaceringID] tinyint  NOT NULL,
    [År] smallint  NOT NULL,
    [PrislisteID] int  NOT NULL,
    [FormatFra] int  NOT NULL,
    [FormatTil] int  NOT NULL,
    [mmPris] decimal(10,4)  NULL,
    [FarvePris] decimal(10,4)  NULL,
    [FarveMin] decimal(10,4)  NULL,
    [FarveMax] decimal(10,4)  NULL,
    [Farve4Pris] decimal(10,4)  NULL,
    [Farve4Min] decimal(10,4)  NULL,
    [Farve4Max] decimal(10,4)  NULL,
    [ControlNavn] nvarchar(50)  NULL
);
GO

-- Creating table 'tblPrislisters'
CREATE TABLE [dbo].[tblPrislisters] (
    [PrislisteID] int IDENTITY(1,1) NOT NULL,
    [PrislisteNavn] nvarchar(50)  NOT NULL
);
GO

-- Creating table 'tblPrislisterPrBladPrÅr'
CREATE TABLE [dbo].[tblPrislisterPrBladPrÅr] (
    [BladID] int  NOT NULL,
    [År] smallint  NOT NULL,
    [PrislisteID] int  NOT NULL
);
GO

-- Creating table 'tblPrislisterPrBladPrUges'
CREATE TABLE [dbo].[tblPrislisterPrBladPrUges] (
    [BladID] int  NOT NULL,
    [Uge] tinyint  NOT NULL,
    [År] smallint  NOT NULL,
    [PrislisteID] int  NOT NULL
);
GO

-- Creating table 'tblRegions'
CREATE TABLE [dbo].[tblRegions] (
    [RegionID] tinyint IDENTITY(1,1) NOT NULL,
    [RegionNavn] nvarchar(30)  NOT NULL,
    [RegionSortKey] tinyint  NOT NULL,
    [timestamp] binary(8)  NOT NULL
);
GO

-- Creating table 'tblRemindereSendts'
CREATE TABLE [dbo].[tblRemindereSendts] (
    [MedieplanNr] int  NOT NULL,
    [UgeavisID] int  NOT NULL,
    [ReminderType] smallint  NOT NULL,
    [AntalRemindere] smallint  NOT NULL
);
GO

-- Creating table 'tblStambladKontakters'
CREATE TABLE [dbo].[tblStambladKontakters] (
    [id] int IDENTITY(1,1) NOT NULL,
    [StamBladId] int  NOT NULL,
    [KontakPersonNavn] varchar(100)  NOT NULL,
    [KontakPersonEmail] varchar(100)  NOT NULL,
    [KontakPersonTitel] varchar(100)  NOT NULL,
    [KontakPersonTelefon] varchar(100)  NOT NULL
);
GO

-- Creating table 'tblStambladUdsendingEmailTypers'
CREATE TABLE [dbo].[tblStambladUdsendingEmailTypers] (
    [id] int IDENTITY(1,1) NOT NULL,
    [titel] varchar(50)  NULL
);
GO

-- Creating table 'tblSupportBilags'
CREATE TABLE [dbo].[tblSupportBilags] (
    [MedieplanNr] int  NOT NULL,
    [IndrykningsUge] nvarchar(2)  NOT NULL,
    [MaterialeGodtgørelseTil] tinyint  NOT NULL,
    [MaterialeFølgerFra] tinyint  NOT NULL,
    [MaterialeFølgerFraLeverandør] nvarchar(30)  NOT NULL,
    [BrugMaterialeFraUge] nvarchar(2)  NOT NULL,
    [SammeMateriale] bit  NOT NULL,
    [KunForhandlerBundForskellig] bit  NOT NULL,
    [Fakturering] tinyint  NOT NULL,
    [BureauOrdresedlerLiggerIIndbakke] tinyint  NOT NULL,
    [Bilagsblade] tinyint  NOT NULL,
    [BilagsbladeAtt] nvarchar(30)  NOT NULL,
    [LøbendeOrdre] nvarchar(50)  NOT NULL,
    [BemærkningTilBlade] nvarchar(250)  NOT NULL,
    [BemærkningTilSupport] nvarchar(250)  NOT NULL,
    [Overskrift] nvarchar(30)  NOT NULL,
    [BilagsBladeTil] smallint  NOT NULL,
    [BilagsBladeTilNavn] nvarchar(30)  NOT NULL,
    [BilagsBladeTilAdresse] nvarchar(30)  NOT NULL,
    [BilagsBladeTilPostNr] int  NOT NULL
);
GO

-- Creating table 'tblWEBeMails'
CREATE TABLE [dbo].[tblWEBeMails] (
    [PersonID] int IDENTITY(1,1) NOT NULL,
    [eMail] nvarchar(100)  NOT NULL,
    [PersonNavn] nvarchar(100)  NULL
);
GO

-- Creating table 'tblWEBForespørgsel'
CREATE TABLE [dbo].[tblWEBForespørgsel] (
    [ForespørgselID] int IDENTITY(1,1) NOT NULL,
    [Type] tinyint  NOT NULL,
    [MedieplanNr] int  NOT NULL,
    [AnnoncørNo_] varchar(20)  NOT NULL,
    [Mediebureau] nvarchar(50)  NOT NULL,
    [KonsulentCode] varchar(10)  NOT NULL,
    [AntalBlade] tinyint  NOT NULL,
    [Format] nvarchar(10)  NOT NULL,
    [AntalFarver] tinyint  NOT NULL,
    [PlaceringID] tinyint  NOT NULL,
    [AntalIndrykninger] tinyint  NOT NULL,
    [SvarInden] datetime  NULL,
    [Afsluttet] bit  NOT NULL,
    [AntalUdsendinger] smallint  NOT NULL,
    [Bemærkning] nvarchar(2000)  NULL,
    [PlaceringUB] bit  NOT NULL
);
GO

-- Creating table 'tblWEBForespørgselLinjer'
CREATE TABLE [dbo].[tblWEBForespørgselLinjer] (
    [ForespørgselID] int  NOT NULL,
    [BladID] int  NOT NULL,
    [BesvaretAf] int  NULL,
    [DLUMmPris] decimal(19,4)  NOT NULL,
    [DLUMmRabat] float  NOT NULL,
    [DLUFarveTillæg] decimal(19,4)  NOT NULL,
    [DLUFarveRabat] float  NOT NULL,
    [PlaceringUB] tinyint  NOT NULL,
    [BladMmPris] decimal(19,4)  NOT NULL,
    [BladMmRabat] float  NOT NULL,
    [BladFarveTillæg] decimal(19,4)  NOT NULL,
    [BladFarveRabat] float  NOT NULL,
    [BladBemærkning] nvarchar(500)  NULL
);
GO

-- Creating table 'tblWEBSendTilKollegas'
CREATE TABLE [dbo].[tblWEBSendTilKollegas] (
    [PersonID] int  NOT NULL,
    [BladID] int  NOT NULL,
    [eMails] nvarchar(1000)  NOT NULL
);
GO

-- Creating table 'Users'
CREATE TABLE [dbo].[Users] (
    [userID] int IDENTITY(1,1) NOT NULL,
    [username] varchar(50)  NULL,
    [firstname] varchar(50)  NULL,
    [lastname] varchar(50)  NULL,
    [middlename] varchar(50)  NULL,
    [email] varchar(100)  NULL,
    [password] varchar(150)  NULL,
    [color] varchar(50)  NULL,
    [jobfunction] varchar(50)  NULL,
    [konsulentKode] varchar(50)  NULL
);
GO

-- Creating table 'bladtlfogfaxkopis'
CREATE TABLE [dbo].[bladtlfogfaxkopis] (
    [BladID] int  NOT NULL,
    [Tlf] char(15)  NOT NULL,
    [Fax] char(15)  NOT NULL
);
GO

-- Creating table 'delPrisers'
CREATE TABLE [dbo].[delPrisers] (
    [BladID] int  NOT NULL,
    [PlaceringID] tinyint  NOT NULL
);
GO

-- Creating table 'HerningFolkeblads'
CREATE TABLE [dbo].[HerningFolkeblads] (
    [BladID] int  NOT NULL,
    [Navn] nchar(30)  NOT NULL
);
GO

-- Creating table 'tblAktiveVærdier'
CREATE TABLE [dbo].[tblAktiveVærdier] (
    [GruppeVersion] tinyint  NOT NULL,
    [MiljøTillæg] decimal(10,4)  NOT NULL,
    [PrisberegningVersion] tinyint  NOT NULL,
    [BilagsBladeSendeUge] tinyint  NOT NULL
);
GO

-- Creating table 'tblAktivGruppeVersions'
CREATE TABLE [dbo].[tblAktivGruppeVersions] (
    [AktivVersion] tinyint  NOT NULL
);
GO

-- Creating table 'tblFarveTillægWebApp'
CREATE TABLE [dbo].[tblFarveTillægWebApp] (
    [BladID] int  NOT NULL,
    [farvePris] decimal(19,4)  NULL,
    [farveMin] smallint  NULL,
    [farveMax] smallint  NULL,
    [farve4Pris] decimal(19,4)  NULL,
    [farve4Min] smallint  NULL,
    [farve4Max] smallint  NULL,
    [Godkendt] bit  NULL,
    [PrisBemærkning] varchar(max)  NULL
);
GO

-- Creating table 'tblMmPrisWebApps'
CREATE TABLE [dbo].[tblMmPrisWebApps] (
    [BladID] int  NOT NULL,
    [Placering] tinyint  NOT NULL,
    [Pris] decimal(19,4)  NULL
);
GO

-- Creating table 'tblPlannerPlaners'
CREATE TABLE [dbo].[tblPlannerPlaners] (
    [PlannerID] int IDENTITY(1,1) NOT NULL,
    [BrugerNavn] nvarchar(50)  NOT NULL,
    [BrugerEmail] nvarchar(100)  NOT NULL,
    [Annoncør] nvarchar(50)  NOT NULL,
    [Bureau] nvarchar(50)  NOT NULL,
    [Format1] tinyint  NOT NULL,
    [Format2] smallint  NOT NULL,
    [AntalFarver] tinyint  NOT NULL,
    [Placering] nvarchar(20)  NOT NULL,
    [Ugeaviser] nvarchar(500)  NOT NULL,
    [MedieplanNr] int  NOT NULL,
    [KonsulentCode] varchar(10)  NOT NULL,
    [Oprettet] datetime  NOT NULL
);
GO

-- Creating table 'tempPrisers'
CREATE TABLE [dbo].[tempPrisers] (
    [BladID] int  NOT NULL,
    [PlaceringID] tinyint  NOT NULL,
    [År] smallint  NOT NULL,
    [PrislisteID] int  NOT NULL,
    [FormatFra] int  NOT NULL,
    [FormatTil] int  NOT NULL,
    [mmPris] decimal(10,4)  NULL,
    [FarvePris] decimal(10,4)  NULL,
    [FarveMin] decimal(10,4)  NULL,
    [FarveMax] decimal(10,4)  NULL,
    [Farve4Pris] decimal(10,4)  NULL,
    [Farve4Min] decimal(10,4)  NULL,
    [Farve4Max] decimal(10,4)  NULL,
    [ControlNavn] nvarchar(50)  NULL
);
GO

-- Creating table 'tmpNyeDeadlines'
CREATE TABLE [dbo].[tmpNyeDeadlines] (
    [BladID] int  NOT NULL,
    [Linje] smallint  NOT NULL,
    [OrdreDeadline] tinyint  NOT NULL,
    [OrdreTid] nvarchar(5)  NOT NULL,
    [MaterialeDeadline] tinyint  NOT NULL,
    [MaterialeTid] nvarchar(5)  NOT NULL
);
GO

-- Creating table 'tnpOrdreNrs'
CREATE TABLE [dbo].[tnpOrdreNrs] (
    [MedieplanNr] int  NOT NULL
);
GO

-- Creating table 'tnpOrdreNr2'
CREATE TABLE [dbo].[tnpOrdreNr2] (
    [MedieplanNr] int  NOT NULL
);
GO

-- Creating table 'tnpOrdreNr3'
CREATE TABLE [dbo].[tnpOrdreNr3] (
    [MedieplanNr] int  NOT NULL,
    [Version] smallint  NOT NULL
);
GO

-- Creating table 'AktiveUgeaviserMedAlleDatas'
CREATE TABLE [dbo].[AktiveUgeaviserMedAlleDatas] (
    [BladID] int  NOT NULL,
    [Navn] nchar(30)  NOT NULL,
    [Adresse] nchar(30)  NULL,
    [PostNr] int  NULL,
    [PostBy] nvarchar(30)  NULL,
    [Tlf] char(15)  NULL,
    [Fax] char(15)  NULL,
    [CVR] char(15)  NULL,
    [Kontaktperson] nvarchar(30)  NULL,
    [HovedGruppeNavn] varchar(30)  NULL,
    [MedlemMåned] tinyint  NULL,
    [MedlemÅr] tinyint  NULL,
    [Ejerforhold] nvarchar(30)  NOT NULL,
    [RegionNavn] nvarchar(30)  NULL,
    [DelOmrådeNavn] nvarchar(30)  NULL,
    [DiMPDelOmrådeKode] nvarchar(2)  NULL,
    [GeoKodeNavn] nvarchar(30)  NULL,
    [Totalområde] int  NULL,
    [TotalområdePct] tinyint  NULL,
    [Primær] int  NULL,
    [PrimærPct] tinyint  NULL,
    [WWWDækningSomTekst] nvarchar(max)  NULL,
    [Oplag] int  NULL,
    [Udgivelsesdag] nvarchar(10)  NULL,
    [Format] nchar(15)  NULL,
    [OrdredeadlineTekst] nvarchar(20)  NULL,
    [OrdredeadlineRubrik] nvarchar(20)  NULL,
    [MaterialedeadlineTekst] nvarchar(20)  NULL,
    [MaterialedeadlineRubrik] nvarchar(20)  NULL,
    [OrdreEmail] nvarchar(200)  NULL,
    [OrdrecheckEmail] nvarchar(50)  NULL,
    [OrdrecheckSendeDag] nvarchar(10)  NULL,
    [SendetidOrdrecheck] char(5)  NULL,
    [SendIndeværendeUge] bit  NULL,
    [StamdataEmail] nvarchar(50)  NULL,
    [PrisforespørgselEmails] nvarchar(200)  NULL,
    [OrienteringEmails] nvarchar(200)  NULL,
    [Emails] nvarchar(200)  NULL,
    [KontaktpersonerEmails] nvarchar(200)  NULL,
    [BogholderiEmails] nvarchar(200)  NULL,
    [MedieNetKode] varchar(15)  NULL,
    [Hjemmeside] varchar(100)  NULL,
    [RedaktionEmail] nvarchar(50)  NULL,
    [AnnonceEmail] nvarchar(50)  NULL,
    [MaterialeEmail] nvarchar(50)  NULL,
    [AnnonceKontrolEmail] nvarchar(50)  NULL,
    [BilagsbladeEmail] nvarchar(50)  NULL,
    [FakturaGruppe] nvarchar(50)  NULL,
    [GruppeRabat] varchar(max)  NULL,
    [SamannonceringsRabat] varchar(max)  NULL
);
GO

-- Creating table 'FakturaFejlFindes'
CREATE TABLE [dbo].[FakturaFejlFindes] (
    [MedieplanNr] int  NOT NULL,
    [UgeavisID] int  NOT NULL,
    [FejlSum] int  NULL
);
GO

-- Creating table 'FindFejlLinjers'
CREATE TABLE [dbo].[FindFejlLinjers] (
    [Mm] smallint  NOT NULL,
    [Navn] nchar(30)  NOT NULL,
    [MedieplanNr] int  NOT NULL,
    [AnnoncørNo_] varchar(20)  NOT NULL,
    [MmPris] decimal(10,4)  NOT NULL,
    [MmRabat] real  NOT NULL,
    [MmTotal] decimal(10,4)  NOT NULL,
    [FarvePris] decimal(10,4)  NOT NULL,
    [FarveRabat] real  NOT NULL,
    [FarveTotal] decimal(10,4)  NOT NULL,
    [Total] decimal(10,4)  NOT NULL,
    [SkalGiveMaterialeGodtgørelse] bit  NOT NULL,
    [MaterialeGodtgørelsePris] decimal(10,4)  NOT NULL,
    [Ansvar] char(1)  NOT NULL,
    [FejlTekst] nvarchar(50)  NOT NULL
);
GO

-- Creating table 'GammelAnnoncørID'
CREATE TABLE [dbo].[GammelAnnoncørID] (
    [No_] varchar(20)  NOT NULL,
    [Gammelt_AnnoncørID] int  NOT NULL,
    [Gammelt_Faktureres_til_ID] int  NOT NULL
);
GO

-- Creating table 'LPRollers'
CREATE TABLE [dbo].[LPRollers] (
    [User_ID] varchar(20)  NOT NULL,
    [Role_ID] varchar(20)  NOT NULL
);
GO

-- Creating table 'NavisionContacts'
CREATE TABLE [dbo].[NavisionContacts] (
    [No_] varchar(20)  NOT NULL,
    [Name] varchar(30)  NOT NULL,
    [Address] varchar(30)  NOT NULL,
    [Post_Code] varchar(20)  NOT NULL,
    [City] varchar(30)  NOT NULL,
    [Phone_No_] varchar(30)  NOT NULL,
    [Sikkerhedsgodtgørelse] tinyint  NOT NULL,
    [Infogodtgørelse] tinyint  NOT NULL,
    [VAT_Registration_No_] varchar(20)  NOT NULL,
    [EAN_nummer] varchar(13)  NOT NULL,
    [Salesperson_Code] varchar(10)  NOT NULL,
    [Bill_to_Contact_No_] varchar(20)  NOT NULL,
    [Payment_Terms_Code] varchar(10)  NOT NULL,
    [Deaktiveret] tinyint  NOT NULL,
    [Invoice_Document_Type] int  NOT NULL,
    [ContactNoFilter] varchar(100)  NOT NULL
);
GO

-- Creating table 'NavisionContact2'
CREATE TABLE [dbo].[NavisionContact2] (
    [No_] varchar(20)  NOT NULL,
    [Name] varchar(30)  NOT NULL
);
GO

-- Creating table 'Salespersons'
CREATE TABLE [dbo].[Salespersons] (
    [Code] varchar(30)  NULL,
    [Name] varchar(61)  NOT NULL,
    [E_Mail] varchar(80)  NOT NULL,
    [Phone_No_] varchar(30)  NOT NULL,
    [Status] int  NOT NULL,
    [SidsteLoginVersion] nvarchar(10)  NULL,
    [NulstilLayout] bit  NULL,
    [Rolle] varchar(20)  NULL
);
GO

-- Creating table 'UgeaviserTilGrids'
CREATE TABLE [dbo].[UgeaviserTilGrids] (
    [BladID] int  NOT NULL,
    [Navn] nchar(30)  NULL,
    [PostNr] int  NULL,
    [PostBy] nvarchar(30)  NOT NULL,
    [Oplag] int  NULL,
    [DækningsGrad] int  NULL,
    [RegionNavn] nvarchar(30)  NOT NULL,
    [RegionSortKey] tinyint  NOT NULL,
    [GeoKodeNavn] nvarchar(30)  NOT NULL,
    [GeoKodeSortKey] tinyint  NOT NULL,
    [HovedGruppeNavn] varchar(30)  NOT NULL,
    [HovedGruppeSortKey] tinyint  NOT NULL,
    [DelOmrådeNavn] nchar(1)  NOT NULL,
    [DelOmrådeSortKey] tinyint  NOT NULL,
    [DagNavn] nvarchar(10)  NULL,
    [GruppeNavn] nvarchar(30)  NOT NULL,
    [Navn2] nvarchar(30)  NULL,
    [Adresse] nchar(30)  NULL,
    [Adresse2] nvarchar(30)  NULL,
    [Tlf] char(15)  NULL,
    [Fax] char(15)  NULL,
    [CVR] char(15)  NULL,
    [Kontaktperson] nvarchar(30)  NULL,
    [OrdredeadlineTekst] nvarchar(20)  NULL,
    [OrdredeadlineRubrik] nvarchar(20)  NULL,
    [MaterialedeadlineTekst] nvarchar(20)  NULL,
    [MaterialedeadlineRubrik] nvarchar(20)  NULL
);
GO

-- Creating table 'viewBlades'
CREATE TABLE [dbo].[viewBlades] (
    [BladID] int  NOT NULL,
    [Navn] nchar(30)  NULL,
    [Adresse] nchar(30)  NULL,
    [PostNr] int  NULL,
    [Tlf] char(15)  NULL,
    [Fax] char(15)  NULL,
    [Email] nvarchar(50)  NULL,
    [GruppeID] int  NOT NULL,
    [CVR] char(15)  NULL,
    [MatGodt50] int  NOT NULL,
    [Homepage] varchar(100)  NULL,
    [Overført] bit  NOT NULL
);
GO

-- Creating table 'viewBookingListes'
CREATE TABLE [dbo].[viewBookingListes] (
    [MedieplanNr] int  NOT NULL,
    [Version] smallint  NOT NULL,
    [AnnoncørNo_] varchar(20)  NOT NULL,
    [BureauNo_] varchar(20)  NOT NULL,
    [Format] varchar(23)  NULL,
    [AntalFarver] tinyint  NOT NULL,
    [IndrykningsUge] tinyint  NOT NULL,
    [SamletPris] decimal(19,4)  NOT NULL,
    [KonsulentCode] varchar(10)  NOT NULL,
    [IndrykningsÅr] smallint  NOT NULL
);
GO

-- Creating table 'viewGruppers'
CREATE TABLE [dbo].[viewGruppers] (
    [GruppeID] int IDENTITY(1,1) NOT NULL,
    [GruppeHovedbladID] int  NULL,
    [GruppeNavn] nvarchar(50)  NOT NULL
);
GO

-- Creating table 'viewLinjeDiffs'
CREATE TABLE [dbo].[viewLinjeDiffs] (
    [MmPrisDiff] decimal(10,4)  NULL,
    [MmRabatDiff] real  NOT NULL,
    [FarvePrisDiff] decimal(10,4)  NULL,
    [FarveRabatDiff] real  NOT NULL,
    [MedieplanNr] int  NOT NULL,
    [Version] smallint  NOT NULL,
    [UgeavisID] int  NOT NULL,
    [MmTotalDiff] decimal(10,4)  NULL,
    [MatGodtDiff] decimal(10,4)  NULL,
    [MmTotal] decimal(10,4)  NOT NULL,
    [FarveTotal] decimal(10,4)  NOT NULL,
    [SikkerhedsGodt] bit  NOT NULL,
    [InfoGodt] bit  NOT NULL,
    [SkalGiveMaterialeGodtgørelse] bit  NOT NULL,
    [MaterialeGodtgørelsePris] decimal(10,4)  NOT NULL,
    [Mm] smallint  NOT NULL
);
GO

-- Creating table 'viewOrdres'
CREATE TABLE [dbo].[viewOrdres] (
    [OrdreNr] int  NOT NULL,
    [Version] smallint  NOT NULL,
    [Document_Type] tinyint  NOT NULL,
    [AnnoncørID] varchar(20)  NOT NULL,
    [Uge] tinyint  NOT NULL,
    [AntalFarver] tinyint  NOT NULL,
    [OrdreDato] datetime  NOT NULL,
    [SamletPris] decimal(19,4)  NOT NULL,
    [SælgerKode] varchar(10)  NOT NULL,
    [SikkerhedsGodt] bit  NOT NULL,
    [InfoGodt] bit  NOT NULL,
    [BureauOrdreNr] nvarchar(30)  NOT NULL,
    [Bureau] varchar(20)  NOT NULL,
    [EnOrdre] tinyint  NOT NULL,
    [Status] tinyint  NOT NULL,
    [FakBem1] nvarchar(50)  NULL,
    [FakBem2] nvarchar(50)  NULL,
    [FakBem3] nvarchar(50)  NULL,
    [MaterialeGodtgørelseTil] tinyint  NOT NULL,
    [Previous_Order_No] int  NOT NULL,
    [Credit_Reason] nvarchar(50)  NULL,
    [Previous_Version] int  NULL,
    [Item_Description] nvarchar(30)  NULL
);
GO

-- Creating table 'viewOrdreErSendts'
CREATE TABLE [dbo].[viewOrdreErSendts] (
    [MedieplanNr] int  NOT NULL,
    [Version] smallint  NOT NULL,
    [AnnoncørNo_] varchar(20)  NOT NULL,
    [BureauNo_] varchar(20)  NOT NULL,
    [Format] varchar(23)  NULL,
    [AntalFarver] tinyint  NOT NULL,
    [IndrykningsUge] tinyint  NOT NULL,
    [OrdreUdsendt] varchar(3)  NOT NULL,
    [MaterialeFra] nvarchar(30)  NULL,
    [MaterialeUdsendt] varchar(30)  NULL,
    [KonsulentCode] varchar(10)  NOT NULL
);
GO

-- Creating table 'viewOrdreFINDs'
CREATE TABLE [dbo].[viewOrdreFINDs] (
    [OrdreNr] int  NOT NULL,
    [Version] smallint  NOT NULL,
    [Document_Type] tinyint  NOT NULL,
    [AnnoncørID] varchar(20)  NOT NULL,
    [Uge] tinyint  NOT NULL,
    [AntalFarver] tinyint  NOT NULL,
    [OrdreDato] datetime  NOT NULL,
    [SamletPris] decimal(19,4)  NOT NULL,
    [SælgerKode] varchar(10)  NOT NULL,
    [SikkerhedsGodt] bit  NOT NULL,
    [InfoGodt] bit  NOT NULL,
    [BureauOrdreNr] nvarchar(30)  NOT NULL,
    [Bureau] varchar(20)  NOT NULL,
    [EnOrdre] tinyint  NOT NULL,
    [Status] tinyint  NOT NULL,
    [FakBem1] nvarchar(50)  NULL,
    [FakBem2] nvarchar(50)  NULL,
    [FakBem3] nvarchar(50)  NULL,
    [MaterialeGodtgørelseTil] tinyint  NOT NULL,
    [Previous_Order_No] int  NOT NULL,
    [Credit_Reason] nvarchar(50)  NULL,
    [Previous_Version] int  NULL
);
GO

-- Creating table 'viewOrdreIkkeSendts'
CREATE TABLE [dbo].[viewOrdreIkkeSendts] (
    [MedieplanNr] int  NOT NULL,
    [Version] smallint  NOT NULL,
    [AnnoncørNo_] varchar(20)  NOT NULL,
    [BureauNo_] varchar(20)  NOT NULL,
    [Format] varchar(23)  NULL,
    [AntalFarver] tinyint  NOT NULL,
    [IndrykningsUge] tinyint  NOT NULL,
    [OrdreUdsendt] varchar(3)  NOT NULL,
    [MaterialeFra] nvarchar(30)  NULL,
    [MaterialeUdsendt] varchar(32)  NULL,
    [KonsulentCode] varchar(10)  NOT NULL,
    [Overskrift] nvarchar(30)  NOT NULL,
    [Deadline] nvarchar(16)  NULL
);
GO

-- Creating table 'viewOrdreLinjers'
CREATE TABLE [dbo].[viewOrdreLinjers] (
    [OrdreNr] int  NOT NULL,
    [Version] smallint  NOT NULL,
    [Document_Type] tinyint  NOT NULL,
    [BladId] int  NOT NULL,
    [Format] varchar(30)  NOT NULL,
    [Mm] smallint  NOT NULL,
    [AnvendtPris] decimal(10,4)  NOT NULL,
    [SpecialRabat] real  NOT NULL,
    [FarveTillægsPris] decimal(10,4)  NOT NULL,
    [FarveTillægsRabat] real  NOT NULL,
    [MaterialeGodt] bit  NOT NULL,
    [TotalPris] decimal(19,4)  NOT NULL,
    [MaterialePris] decimal(10,4)  NOT NULL,
    [Previous_Order_No] int  NOT NULL,
    [Previous_Version] int  NULL
);
GO

-- Creating table 'viewOrdreLinjerFINDs'
CREATE TABLE [dbo].[viewOrdreLinjerFINDs] (
    [OrdreNr] int  NOT NULL,
    [Version] smallint  NOT NULL,
    [Document_Type] tinyint  NOT NULL,
    [BladId] int  NOT NULL,
    [Format] varchar(21)  NULL,
    [Mm] smallint  NOT NULL,
    [AnvendtPris] decimal(10,4)  NOT NULL,
    [SpecialRabat] real  NOT NULL,
    [FarveTillægsPris] decimal(10,4)  NOT NULL,
    [FarveTillægsRabat] real  NOT NULL,
    [MaterialeGodt] bit  NOT NULL,
    [TotalPris] decimal(19,4)  NULL,
    [MaterialePris] decimal(10,4)  NOT NULL
);
GO

-- Creating table 'viewOrdreSendtManglerMateriales'
CREATE TABLE [dbo].[viewOrdreSendtManglerMateriales] (
    [MedieplanNr] int  NOT NULL,
    [Version] smallint  NOT NULL,
    [AnnoncørNo_] varchar(20)  NOT NULL,
    [BureauNo_] varchar(20)  NOT NULL,
    [Format] varchar(23)  NULL,
    [AntalFarver] tinyint  NOT NULL,
    [IndrykningsUge] tinyint  NOT NULL,
    [OrdreUdsendt] varchar(3)  NOT NULL,
    [MaterialeFra] nvarchar(30)  NULL,
    [MaterialeUdsendt] varchar(32)  NULL,
    [KonsulentCode] varchar(10)  NOT NULL,
    [Overskrift] nvarchar(30)  NOT NULL,
    [Deadline] nvarchar(16)  NULL
);
GO

-- Creating table 'viewOversigts'
CREATE TABLE [dbo].[viewOversigts] (
    [MedieplanNr] int  NOT NULL,
    [Version] smallint  NOT NULL,
    [AnnoncørNo_] varchar(20)  NOT NULL,
    [BureauNo_] varchar(20)  NOT NULL,
    [Format] varchar(23)  NULL,
    [AntalFarver] tinyint  NOT NULL,
    [IndrykningsUge] tinyint  NOT NULL,
    [OrdreUdsendt] varchar(3)  NOT NULL,
    [MaterialeFra] nvarchar(30)  NULL,
    [MaterialeUdsendt] varchar(32)  NULL,
    [KonsulentCode] varchar(10)  NOT NULL,
    [Overskrift] nvarchar(30)  NOT NULL,
    [Deadline] nvarchar(16)  NULL
);
GO

-- Creating table 'viewUpdateStatusIMedieplans'
CREATE TABLE [dbo].[viewUpdateStatusIMedieplans] (
    [MedieplanNr] int  NOT NULL,
    [Version] smallint  NOT NULL,
    [Status] tinyint  NOT NULL
);
GO

-- Creating table 'viewUpdateStatusIMedieplanNrs'
CREATE TABLE [dbo].[viewUpdateStatusIMedieplanNrs] (
    [MedieplanNr] int IDENTITY(1,1) NOT NULL,
    [AktivVersion] smallint  NOT NULL,
    [Status] tinyint  NOT NULL
);
GO

-- Creating table 'tblOphørtBlad'
CREATE TABLE [dbo].[tblOphørtBlad] (
    [id] int  NOT NULL,
    [kommentar] varchar(max)  NULL,
    [bladid] int  NOT NULL,
    [ophørsdato] datetime  NOT NULL
);
GO

-- Creating table 'tblStamBladBogHolderis'
CREATE TABLE [dbo].[tblStamBladBogHolderis] (
    [id] int IDENTITY(1,1) NOT NULL,
    [Bladid] int  NULL,
    [NavisionId] varchar(50)  NULL,
    [NavisioID] varchar(50)  NULL,
    [Kontakt] nvarchar(50)  NULL
);
GO

-- Creating table 'tblStambladKoncerns'
CREATE TABLE [dbo].[tblStambladKoncerns] (
    [koncernId] int IDENTITY(1,1) NOT NULL,
    [koncern_name] varchar(50)  NOT NULL
);
GO

-- Creating table 'tblKontakterArbOmråderPrKontakt'
CREATE TABLE [dbo].[tblKontakterArbOmråderPrKontakt] (
    [tblKontaktArbOmråder_ArbOmrådeID] int  NOT NULL,
    [tblKontakters_KontaktID] int  NOT NULL
);
GO

-- Creating table 'tblKontaktFunktionerPrBlad'
CREATE TABLE [dbo].[tblKontaktFunktionerPrBlad] (
    [tblKontakterPrBlads_BladID] int  NOT NULL,
    [tblKontakterPrBlads_KontaktID] int  NOT NULL,
    [tblKontaktFunktioners_FunktionID] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [id], [property] in table 'dtproperties'
ALTER TABLE [dbo].[dtproperties]
ADD CONSTRAINT [PK_dtproperties]
    PRIMARY KEY CLUSTERED ([id], [property] ASC);
GO

-- Creating primary key on [id] in table 'KontaktTitlers'
ALTER TABLE [dbo].[KontaktTitlers]
ADD CONSTRAINT [PK_KontaktTitlers]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [LPVersion] in table 'OpdateringsTeksts'
ALTER TABLE [dbo].[OpdateringsTeksts]
ADD CONSTRAINT [PK_OpdateringsTeksts]
    PRIMARY KEY CLUSTERED ([LPVersion] ASC);
GO

-- Creating primary key on [diagram_id] in table 'sysdiagrams'
ALTER TABLE [dbo].[sysdiagrams]
ADD CONSTRAINT [PK_sysdiagrams]
    PRIMARY KEY CLUSTERED ([diagram_id] ASC);
GO

-- Creating primary key on [MedieplanNr], [UgeavisID] in table 'tblAnnoncekontrols'
ALTER TABLE [dbo].[tblAnnoncekontrols]
ADD CONSTRAINT [PK_tblAnnoncekontrols]
    PRIMARY KEY CLUSTERED ([MedieplanNr], [UgeavisID] ASC);
GO

-- Creating primary key on [BladID], [PostNr] in table 'tblBladDækning'
ALTER TABLE [dbo].[tblBladDækning]
ADD CONSTRAINT [PK_tblBladDækning]
    PRIMARY KEY CLUSTERED ([BladID], [PostNr] ASC);
GO

-- Creating primary key on [id] in table 'tblBladKommentars'
ALTER TABLE [dbo].[tblBladKommentars]
ADD CONSTRAINT [PK_tblBladKommentars]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [BladID] in table 'tblBladnavnMappingFraDOes'
ALTER TABLE [dbo].[tblBladnavnMappingFraDOes]
ADD CONSTRAINT [PK_tblBladnavnMappingFraDOes]
    PRIMARY KEY CLUSTERED ([BladID] ASC);
GO

-- Creating primary key on [id] in table 'tblBladRabats'
ALTER TABLE [dbo].[tblBladRabats]
ADD CONSTRAINT [PK_tblBladRabats]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'tblBladRabatters'
ALTER TABLE [dbo].[tblBladRabatters]
ADD CONSTRAINT [PK_tblBladRabatters]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [BladID] in table 'tblBladStamdatas'
ALTER TABLE [dbo].[tblBladStamdatas]
ADD CONSTRAINT [PK_tblBladStamdatas]
    PRIMARY KEY CLUSTERED ([BladID] ASC);
GO

-- Creating primary key on [BladID] in table 'tblBladStamdataKopis'
ALTER TABLE [dbo].[tblBladStamdataKopis]
ADD CONSTRAINT [PK_tblBladStamdataKopis]
    PRIMARY KEY CLUSTERED ([BladID] ASC);
GO

-- Creating primary key on [id] in table 'tblBladTillaegs'
ALTER TABLE [dbo].[tblBladTillaegs]
ADD CONSTRAINT [PK_tblBladTillaegs]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'tblBladTillaegsTypes'
ALTER TABLE [dbo].[tblBladTillaegsTypes]
ADD CONSTRAINT [PK_tblBladTillaegsTypes]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'tblBladUdsendingKontakters'
ALTER TABLE [dbo].[tblBladUdsendingKontakters]
ADD CONSTRAINT [PK_tblBladUdsendingKontakters]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [Initialer] in table 'tblBrugerDatas'
ALTER TABLE [dbo].[tblBrugerDatas]
ADD CONSTRAINT [PK_tblBrugerDatas]
    PRIMARY KEY CLUSTERED ([Initialer] ASC);
GO

-- Creating primary key on [DagID] in table 'tblDages'
ALTER TABLE [dbo].[tblDages]
ADD CONSTRAINT [PK_tblDages]
    PRIMARY KEY CLUSTERED ([DagID] ASC);
GO

-- Creating primary key on [DelOmrådeID] in table 'tblDelOmråde'
ALTER TABLE [dbo].[tblDelOmråde]
ADD CONSTRAINT [PK_tblDelOmråde]
    PRIMARY KEY CLUSTERED ([DelOmrådeID] ASC);
GO

-- Creating primary key on [DPKulørID] in table 'tblDPKulør'
ALTER TABLE [dbo].[tblDPKulør]
ADD CONSTRAINT [PK_tblDPKulør]
    PRIMARY KEY CLUSTERED ([DPKulørID] ASC);
GO

-- Creating primary key on [EjerforholdID] in table 'tblEjerforholds'
ALTER TABLE [dbo].[tblEjerforholds]
ADD CONSTRAINT [PK_tblEjerforholds]
    PRIMARY KEY CLUSTERED ([EjerforholdID] ASC);
GO

-- Creating primary key on [MedieplanNr], [Version], [UgeavisID] in table 'tblFakturaFejls'
ALTER TABLE [dbo].[tblFakturaFejls]
ADD CONSTRAINT [PK_tblFakturaFejls]
    PRIMARY KEY CLUSTERED ([MedieplanNr], [Version], [UgeavisID] ASC);
GO

-- Creating primary key on [FejlKode] in table 'tblFakturaFejlTeksts'
ALTER TABLE [dbo].[tblFakturaFejlTeksts]
ADD CONSTRAINT [PK_tblFakturaFejlTeksts]
    PRIMARY KEY CLUSTERED ([FejlKode] ASC);
GO

-- Creating primary key on [MedieplanNr], [BemærkningNr] in table 'tblFaktureringsBilags'
ALTER TABLE [dbo].[tblFaktureringsBilags]
ADD CONSTRAINT [PK_tblFaktureringsBilags]
    PRIMARY KEY CLUSTERED ([MedieplanNr], [BemærkningNr] ASC);
GO

-- Creating primary key on [Fejlkode] in table 'tblFejlTeksts'
ALTER TABLE [dbo].[tblFejlTeksts]
ADD CONSTRAINT [PK_tblFejlTeksts]
    PRIMARY KEY CLUSTERED ([Fejlkode] ASC);
GO

-- Creating primary key on [GeoKodeID] in table 'tblGeoKodes'
ALTER TABLE [dbo].[tblGeoKodes]
ADD CONSTRAINT [PK_tblGeoKodes]
    PRIMARY KEY CLUSTERED ([GeoKodeID] ASC);
GO

-- Creating primary key on [GruppeID], [Version] in table 'tblGruppers'
ALTER TABLE [dbo].[tblGruppers]
ADD CONSTRAINT [PK_tblGruppers]
    PRIMARY KEY CLUSTERED ([GruppeID], [Version] ASC);
GO

-- Creating primary key on [RabatFormID], [Version] in table 'tblGruppeRabatters'
ALTER TABLE [dbo].[tblGruppeRabatters]
ADD CONSTRAINT [PK_tblGruppeRabatters]
    PRIMARY KEY CLUSTERED ([RabatFormID], [Version] ASC);
GO

-- Creating primary key on [HovedGruppeID] in table 'tblHovedGruppes'
ALTER TABLE [dbo].[tblHovedGruppes]
ADD CONSTRAINT [PK_tblHovedGruppes]
    PRIMARY KEY CLUSTERED ([HovedGruppeID] ASC);
GO

-- Creating primary key on [KonkurrentID], [PostNr] in table 'tblKonkurrentDækning'
ALTER TABLE [dbo].[tblKonkurrentDækning]
ADD CONSTRAINT [PK_tblKonkurrentDækning]
    PRIMARY KEY CLUSTERED ([KonkurrentID], [PostNr] ASC);
GO

-- Creating primary key on [KonkurrentID] in table 'tblKonkurrenters'
ALTER TABLE [dbo].[tblKonkurrenters]
ADD CONSTRAINT [PK_tblKonkurrenters]
    PRIMARY KEY CLUSTERED ([KonkurrentID] ASC);
GO

-- Creating primary key on [ArbOmrådeID] in table 'tblKontaktArbOmråder'
ALTER TABLE [dbo].[tblKontaktArbOmråder]
ADD CONSTRAINT [PK_tblKontaktArbOmråder]
    PRIMARY KEY CLUSTERED ([ArbOmrådeID] ASC);
GO

-- Creating primary key on [KontaktID] in table 'tblKontakters'
ALTER TABLE [dbo].[tblKontakters]
ADD CONSTRAINT [PK_tblKontakters]
    PRIMARY KEY CLUSTERED ([KontaktID] ASC);
GO

-- Creating primary key on [BladID], [KontaktID] in table 'tblKontakterPrBlads'
ALTER TABLE [dbo].[tblKontakterPrBlads]
ADD CONSTRAINT [PK_tblKontakterPrBlads]
    PRIMARY KEY CLUSTERED ([BladID], [KontaktID] ASC);
GO

-- Creating primary key on [FunktionID] in table 'tblKontaktFunktioners'
ALTER TABLE [dbo].[tblKontaktFunktioners]
ADD CONSTRAINT [PK_tblKontaktFunktioners]
    PRIMARY KEY CLUSTERED ([FunktionID] ASC);
GO

-- Creating primary key on [TitelID] in table 'tblKontaktTitlers'
ALTER TABLE [dbo].[tblKontaktTitlers]
ADD CONSTRAINT [PK_tblKontaktTitlers]
    PRIMARY KEY CLUSTERED ([TitelID] ASC);
GO

-- Creating primary key on [MedieplanNr], [UgeavisID] in table 'tblMateriales'
ALTER TABLE [dbo].[tblMateriales]
ADD CONSTRAINT [PK_tblMateriales]
    PRIMARY KEY CLUSTERED ([MedieplanNr], [UgeavisID] ASC);
GO

-- Creating primary key on [MedieplanNr], [Version] in table 'tblMedieplans'
ALTER TABLE [dbo].[tblMedieplans]
ADD CONSTRAINT [PK_tblMedieplans]
    PRIMARY KEY CLUSTERED ([MedieplanNr], [Version] ASC);
GO

-- Creating primary key on [MedieplanNr], [Version] in table 'tblMedieplanÆndringer'
ALTER TABLE [dbo].[tblMedieplanÆndringer]
ADD CONSTRAINT [PK_tblMedieplanÆndringer]
    PRIMARY KEY CLUSTERED ([MedieplanNr], [Version] ASC);
GO

-- Creating primary key on [MedieplanNr], [Version], [UgeavisID] in table 'tblMedieplanLinjers'
ALTER TABLE [dbo].[tblMedieplanLinjers]
ADD CONSTRAINT [PK_tblMedieplanLinjers]
    PRIMARY KEY CLUSTERED ([MedieplanNr], [Version], [UgeavisID] ASC);
GO

-- Creating primary key on [MedieplanNr] in table 'tblMedieplanNrs'
ALTER TABLE [dbo].[tblMedieplanNrs]
ADD CONSTRAINT [PK_tblMedieplanNrs]
    PRIMARY KEY CLUSTERED ([MedieplanNr] ASC);
GO

-- Creating primary key on [GruppeID], [ID], [Version] in table 'tblMedIGruppes'
ALTER TABLE [dbo].[tblMedIGruppes]
ADD CONSTRAINT [PK_tblMedIGruppes]
    PRIMARY KEY CLUSTERED ([GruppeID], [ID], [Version] ASC);
GO

-- Creating primary key on [OrdreNr], [Version], [Document_Type], [Type], [BladId] in table 'tblOrdreGebyrNavisions'
ALTER TABLE [dbo].[tblOrdreGebyrNavisions]
ADD CONSTRAINT [PK_tblOrdreGebyrNavisions]
    PRIMARY KEY CLUSTERED ([OrdreNr], [Version], [Document_Type], [Type], [BladId] ASC);
GO

-- Creating primary key on [OrdreNr], [Version], [Document_Type], [BladId] in table 'tblOrdreLinjerNavisions'
ALTER TABLE [dbo].[tblOrdreLinjerNavisions]
ADD CONSTRAINT [PK_tblOrdreLinjerNavisions]
    PRIMARY KEY CLUSTERED ([OrdreNr], [Version], [Document_Type], [BladId] ASC);
GO

-- Creating primary key on [OrdreNr], [Version], [Document_Type] in table 'tblOrdreNavisions'
ALTER TABLE [dbo].[tblOrdreNavisions]
ADD CONSTRAINT [PK_tblOrdreNavisions]
    PRIMARY KEY CLUSTERED ([OrdreNr], [Version], [Document_Type] ASC);
GO

-- Creating primary key on [PlaceringID] in table 'tblPlacerings'
ALTER TABLE [dbo].[tblPlacerings]
ADD CONSTRAINT [PK_tblPlacerings]
    PRIMARY KEY CLUSTERED ([PlaceringID] ASC);
GO

-- Creating primary key on [PostNr] in table 'tblPostNrs'
ALTER TABLE [dbo].[tblPostNrs]
ADD CONSTRAINT [PK_tblPostNrs]
    PRIMARY KEY CLUSTERED ([PostNr] ASC);
GO

-- Creating primary key on [BrugerNavn], [PostNr] in table 'tblPostNrSøgning'
ALTER TABLE [dbo].[tblPostNrSøgning]
ADD CONSTRAINT [PK_tblPostNrSøgning]
    PRIMARY KEY CLUSTERED ([BrugerNavn], [PostNr] ASC);
GO

-- Creating primary key on [id] in table 'tblPriceAskings'
ALTER TABLE [dbo].[tblPriceAskings]
ADD CONSTRAINT [PK_tblPriceAskings]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [BladID], [PlaceringID], [År], [PrislisteID], [FormatFra] in table 'tblPrisers'
ALTER TABLE [dbo].[tblPrisers]
ADD CONSTRAINT [PK_tblPrisers]
    PRIMARY KEY CLUSTERED ([BladID], [PlaceringID], [År], [PrislisteID], [FormatFra] ASC);
GO

-- Creating primary key on [PrislisteID] in table 'tblPrislisters'
ALTER TABLE [dbo].[tblPrislisters]
ADD CONSTRAINT [PK_tblPrislisters]
    PRIMARY KEY CLUSTERED ([PrislisteID] ASC);
GO

-- Creating primary key on [BladID], [År], [PrislisteID] in table 'tblPrislisterPrBladPrÅr'
ALTER TABLE [dbo].[tblPrislisterPrBladPrÅr]
ADD CONSTRAINT [PK_tblPrislisterPrBladPrÅr]
    PRIMARY KEY CLUSTERED ([BladID], [År], [PrislisteID] ASC);
GO

-- Creating primary key on [BladID], [Uge], [År] in table 'tblPrislisterPrBladPrUges'
ALTER TABLE [dbo].[tblPrislisterPrBladPrUges]
ADD CONSTRAINT [PK_tblPrislisterPrBladPrUges]
    PRIMARY KEY CLUSTERED ([BladID], [Uge], [År] ASC);
GO

-- Creating primary key on [RegionID] in table 'tblRegions'
ALTER TABLE [dbo].[tblRegions]
ADD CONSTRAINT [PK_tblRegions]
    PRIMARY KEY CLUSTERED ([RegionID] ASC);
GO

-- Creating primary key on [MedieplanNr], [UgeavisID], [ReminderType] in table 'tblRemindereSendts'
ALTER TABLE [dbo].[tblRemindereSendts]
ADD CONSTRAINT [PK_tblRemindereSendts]
    PRIMARY KEY CLUSTERED ([MedieplanNr], [UgeavisID], [ReminderType] ASC);
GO

-- Creating primary key on [id] in table 'tblStambladKontakters'
ALTER TABLE [dbo].[tblStambladKontakters]
ADD CONSTRAINT [PK_tblStambladKontakters]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'tblStambladUdsendingEmailTypers'
ALTER TABLE [dbo].[tblStambladUdsendingEmailTypers]
ADD CONSTRAINT [PK_tblStambladUdsendingEmailTypers]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [MedieplanNr] in table 'tblSupportBilags'
ALTER TABLE [dbo].[tblSupportBilags]
ADD CONSTRAINT [PK_tblSupportBilags]
    PRIMARY KEY CLUSTERED ([MedieplanNr] ASC);
GO

-- Creating primary key on [PersonID] in table 'tblWEBeMails'
ALTER TABLE [dbo].[tblWEBeMails]
ADD CONSTRAINT [PK_tblWEBeMails]
    PRIMARY KEY CLUSTERED ([PersonID] ASC);
GO

-- Creating primary key on [ForespørgselID] in table 'tblWEBForespørgsel'
ALTER TABLE [dbo].[tblWEBForespørgsel]
ADD CONSTRAINT [PK_tblWEBForespørgsel]
    PRIMARY KEY CLUSTERED ([ForespørgselID] ASC);
GO

-- Creating primary key on [ForespørgselID], [BladID] in table 'tblWEBForespørgselLinjer'
ALTER TABLE [dbo].[tblWEBForespørgselLinjer]
ADD CONSTRAINT [PK_tblWEBForespørgselLinjer]
    PRIMARY KEY CLUSTERED ([ForespørgselID], [BladID] ASC);
GO

-- Creating primary key on [PersonID], [BladID] in table 'tblWEBSendTilKollegas'
ALTER TABLE [dbo].[tblWEBSendTilKollegas]
ADD CONSTRAINT [PK_tblWEBSendTilKollegas]
    PRIMARY KEY CLUSTERED ([PersonID], [BladID] ASC);
GO

-- Creating primary key on [userID] in table 'Users'
ALTER TABLE [dbo].[Users]
ADD CONSTRAINT [PK_Users]
    PRIMARY KEY CLUSTERED ([userID] ASC);
GO

-- Creating primary key on [BladID], [Tlf], [Fax] in table 'bladtlfogfaxkopis'
ALTER TABLE [dbo].[bladtlfogfaxkopis]
ADD CONSTRAINT [PK_bladtlfogfaxkopis]
    PRIMARY KEY CLUSTERED ([BladID], [Tlf], [Fax] ASC);
GO

-- Creating primary key on [BladID], [PlaceringID] in table 'delPrisers'
ALTER TABLE [dbo].[delPrisers]
ADD CONSTRAINT [PK_delPrisers]
    PRIMARY KEY CLUSTERED ([BladID], [PlaceringID] ASC);
GO

-- Creating primary key on [BladID], [Navn] in table 'HerningFolkeblads'
ALTER TABLE [dbo].[HerningFolkeblads]
ADD CONSTRAINT [PK_HerningFolkeblads]
    PRIMARY KEY CLUSTERED ([BladID], [Navn] ASC);
GO

-- Creating primary key on [GruppeVersion], [MiljøTillæg], [PrisberegningVersion], [BilagsBladeSendeUge] in table 'tblAktiveVærdier'
ALTER TABLE [dbo].[tblAktiveVærdier]
ADD CONSTRAINT [PK_tblAktiveVærdier]
    PRIMARY KEY CLUSTERED ([GruppeVersion], [MiljøTillæg], [PrisberegningVersion], [BilagsBladeSendeUge] ASC);
GO

-- Creating primary key on [AktivVersion] in table 'tblAktivGruppeVersions'
ALTER TABLE [dbo].[tblAktivGruppeVersions]
ADD CONSTRAINT [PK_tblAktivGruppeVersions]
    PRIMARY KEY CLUSTERED ([AktivVersion] ASC);
GO

-- Creating primary key on [BladID] in table 'tblFarveTillægWebApp'
ALTER TABLE [dbo].[tblFarveTillægWebApp]
ADD CONSTRAINT [PK_tblFarveTillægWebApp]
    PRIMARY KEY CLUSTERED ([BladID] ASC);
GO

-- Creating primary key on [BladID], [Placering] in table 'tblMmPrisWebApps'
ALTER TABLE [dbo].[tblMmPrisWebApps]
ADD CONSTRAINT [PK_tblMmPrisWebApps]
    PRIMARY KEY CLUSTERED ([BladID], [Placering] ASC);
GO

-- Creating primary key on [PlannerID], [BrugerNavn], [BrugerEmail], [Annoncør], [Bureau], [Format1], [Format2], [AntalFarver], [Placering], [Ugeaviser], [MedieplanNr], [KonsulentCode], [Oprettet] in table 'tblPlannerPlaners'
ALTER TABLE [dbo].[tblPlannerPlaners]
ADD CONSTRAINT [PK_tblPlannerPlaners]
    PRIMARY KEY CLUSTERED ([PlannerID], [BrugerNavn], [BrugerEmail], [Annoncør], [Bureau], [Format1], [Format2], [AntalFarver], [Placering], [Ugeaviser], [MedieplanNr], [KonsulentCode], [Oprettet] ASC);
GO

-- Creating primary key on [BladID], [PlaceringID], [År], [PrislisteID], [FormatFra], [FormatTil] in table 'tempPrisers'
ALTER TABLE [dbo].[tempPrisers]
ADD CONSTRAINT [PK_tempPrisers]
    PRIMARY KEY CLUSTERED ([BladID], [PlaceringID], [År], [PrislisteID], [FormatFra], [FormatTil] ASC);
GO

-- Creating primary key on [BladID], [Linje], [OrdreDeadline], [OrdreTid], [MaterialeDeadline], [MaterialeTid] in table 'tmpNyeDeadlines'
ALTER TABLE [dbo].[tmpNyeDeadlines]
ADD CONSTRAINT [PK_tmpNyeDeadlines]
    PRIMARY KEY CLUSTERED ([BladID], [Linje], [OrdreDeadline], [OrdreTid], [MaterialeDeadline], [MaterialeTid] ASC);
GO

-- Creating primary key on [MedieplanNr] in table 'tnpOrdreNrs'
ALTER TABLE [dbo].[tnpOrdreNrs]
ADD CONSTRAINT [PK_tnpOrdreNrs]
    PRIMARY KEY CLUSTERED ([MedieplanNr] ASC);
GO

-- Creating primary key on [MedieplanNr] in table 'tnpOrdreNr2'
ALTER TABLE [dbo].[tnpOrdreNr2]
ADD CONSTRAINT [PK_tnpOrdreNr2]
    PRIMARY KEY CLUSTERED ([MedieplanNr] ASC);
GO

-- Creating primary key on [MedieplanNr], [Version] in table 'tnpOrdreNr3'
ALTER TABLE [dbo].[tnpOrdreNr3]
ADD CONSTRAINT [PK_tnpOrdreNr3]
    PRIMARY KEY CLUSTERED ([MedieplanNr], [Version] ASC);
GO

-- Creating primary key on [BladID], [Navn], [Ejerforhold] in table 'AktiveUgeaviserMedAlleDatas'
ALTER TABLE [dbo].[AktiveUgeaviserMedAlleDatas]
ADD CONSTRAINT [PK_AktiveUgeaviserMedAlleDatas]
    PRIMARY KEY CLUSTERED ([BladID], [Navn], [Ejerforhold] ASC);
GO

-- Creating primary key on [MedieplanNr], [UgeavisID] in table 'FakturaFejlFindes'
ALTER TABLE [dbo].[FakturaFejlFindes]
ADD CONSTRAINT [PK_FakturaFejlFindes]
    PRIMARY KEY CLUSTERED ([MedieplanNr], [UgeavisID] ASC);
GO

-- Creating primary key on [Mm], [Navn], [MedieplanNr], [AnnoncørNo_], [MmPris], [MmRabat], [MmTotal], [FarvePris], [FarveRabat], [FarveTotal], [Total], [SkalGiveMaterialeGodtgørelse], [MaterialeGodtgørelsePris], [Ansvar], [FejlTekst] in table 'FindFejlLinjers'
ALTER TABLE [dbo].[FindFejlLinjers]
ADD CONSTRAINT [PK_FindFejlLinjers]
    PRIMARY KEY CLUSTERED ([Mm], [Navn], [MedieplanNr], [AnnoncørNo_], [MmPris], [MmRabat], [MmTotal], [FarvePris], [FarveRabat], [FarveTotal], [Total], [SkalGiveMaterialeGodtgørelse], [MaterialeGodtgørelsePris], [Ansvar], [FejlTekst] ASC);
GO

-- Creating primary key on [No_], [Gammelt_AnnoncørID], [Gammelt_Faktureres_til_ID] in table 'GammelAnnoncørID'
ALTER TABLE [dbo].[GammelAnnoncørID]
ADD CONSTRAINT [PK_GammelAnnoncørID]
    PRIMARY KEY CLUSTERED ([No_], [Gammelt_AnnoncørID], [Gammelt_Faktureres_til_ID] ASC);
GO

-- Creating primary key on [User_ID], [Role_ID] in table 'LPRollers'
ALTER TABLE [dbo].[LPRollers]
ADD CONSTRAINT [PK_LPRollers]
    PRIMARY KEY CLUSTERED ([User_ID], [Role_ID] ASC);
GO

-- Creating primary key on [No_], [Name], [Address], [Post_Code], [City], [Phone_No_], [Sikkerhedsgodtgørelse], [Infogodtgørelse], [VAT_Registration_No_], [EAN_nummer], [Salesperson_Code], [Bill_to_Contact_No_], [Payment_Terms_Code], [Deaktiveret], [Invoice_Document_Type], [ContactNoFilter] in table 'NavisionContacts'
ALTER TABLE [dbo].[NavisionContacts]
ADD CONSTRAINT [PK_NavisionContacts]
    PRIMARY KEY CLUSTERED ([No_], [Name], [Address], [Post_Code], [City], [Phone_No_], [Sikkerhedsgodtgørelse], [Infogodtgørelse], [VAT_Registration_No_], [EAN_nummer], [Salesperson_Code], [Bill_to_Contact_No_], [Payment_Terms_Code], [Deaktiveret], [Invoice_Document_Type], [ContactNoFilter] ASC);
GO

-- Creating primary key on [No_], [Name] in table 'NavisionContact2'
ALTER TABLE [dbo].[NavisionContact2]
ADD CONSTRAINT [PK_NavisionContact2]
    PRIMARY KEY CLUSTERED ([No_], [Name] ASC);
GO

-- Creating primary key on [Name], [E_Mail], [Phone_No_], [Status] in table 'Salespersons'
ALTER TABLE [dbo].[Salespersons]
ADD CONSTRAINT [PK_Salespersons]
    PRIMARY KEY CLUSTERED ([Name], [E_Mail], [Phone_No_], [Status] ASC);
GO

-- Creating primary key on [BladID], [PostBy], [RegionNavn], [RegionSortKey], [GeoKodeNavn], [GeoKodeSortKey], [HovedGruppeNavn], [HovedGruppeSortKey], [DelOmrådeNavn], [DelOmrådeSortKey], [GruppeNavn] in table 'UgeaviserTilGrids'
ALTER TABLE [dbo].[UgeaviserTilGrids]
ADD CONSTRAINT [PK_UgeaviserTilGrids]
    PRIMARY KEY CLUSTERED ([BladID], [PostBy], [RegionNavn], [RegionSortKey], [GeoKodeNavn], [GeoKodeSortKey], [HovedGruppeNavn], [HovedGruppeSortKey], [DelOmrådeNavn], [DelOmrådeSortKey], [GruppeNavn] ASC);
GO

-- Creating primary key on [BladID], [GruppeID], [MatGodt50], [Overført] in table 'viewBlades'
ALTER TABLE [dbo].[viewBlades]
ADD CONSTRAINT [PK_viewBlades]
    PRIMARY KEY CLUSTERED ([BladID], [GruppeID], [MatGodt50], [Overført] ASC);
GO

-- Creating primary key on [MedieplanNr], [Version], [AnnoncørNo_], [BureauNo_], [AntalFarver], [IndrykningsUge], [SamletPris], [KonsulentCode], [IndrykningsÅr] in table 'viewBookingListes'
ALTER TABLE [dbo].[viewBookingListes]
ADD CONSTRAINT [PK_viewBookingListes]
    PRIMARY KEY CLUSTERED ([MedieplanNr], [Version], [AnnoncørNo_], [BureauNo_], [AntalFarver], [IndrykningsUge], [SamletPris], [KonsulentCode], [IndrykningsÅr] ASC);
GO

-- Creating primary key on [GruppeID], [GruppeNavn] in table 'viewGruppers'
ALTER TABLE [dbo].[viewGruppers]
ADD CONSTRAINT [PK_viewGruppers]
    PRIMARY KEY CLUSTERED ([GruppeID], [GruppeNavn] ASC);
GO

-- Creating primary key on [MmRabatDiff], [FarveRabatDiff], [MedieplanNr], [Version], [UgeavisID], [MmTotal], [FarveTotal], [SikkerhedsGodt], [InfoGodt], [SkalGiveMaterialeGodtgørelse], [MaterialeGodtgørelsePris], [Mm] in table 'viewLinjeDiffs'
ALTER TABLE [dbo].[viewLinjeDiffs]
ADD CONSTRAINT [PK_viewLinjeDiffs]
    PRIMARY KEY CLUSTERED ([MmRabatDiff], [FarveRabatDiff], [MedieplanNr], [Version], [UgeavisID], [MmTotal], [FarveTotal], [SikkerhedsGodt], [InfoGodt], [SkalGiveMaterialeGodtgørelse], [MaterialeGodtgørelsePris], [Mm] ASC);
GO

-- Creating primary key on [OrdreNr], [Version], [Document_Type], [AnnoncørID], [Uge], [AntalFarver], [OrdreDato], [SamletPris], [SælgerKode], [SikkerhedsGodt], [InfoGodt], [BureauOrdreNr], [Bureau], [EnOrdre], [Status], [MaterialeGodtgørelseTil], [Previous_Order_No] in table 'viewOrdres'
ALTER TABLE [dbo].[viewOrdres]
ADD CONSTRAINT [PK_viewOrdres]
    PRIMARY KEY CLUSTERED ([OrdreNr], [Version], [Document_Type], [AnnoncørID], [Uge], [AntalFarver], [OrdreDato], [SamletPris], [SælgerKode], [SikkerhedsGodt], [InfoGodt], [BureauOrdreNr], [Bureau], [EnOrdre], [Status], [MaterialeGodtgørelseTil], [Previous_Order_No] ASC);
GO

-- Creating primary key on [MedieplanNr], [Version], [AnnoncørNo_], [BureauNo_], [AntalFarver], [IndrykningsUge], [OrdreUdsendt], [KonsulentCode] in table 'viewOrdreErSendts'
ALTER TABLE [dbo].[viewOrdreErSendts]
ADD CONSTRAINT [PK_viewOrdreErSendts]
    PRIMARY KEY CLUSTERED ([MedieplanNr], [Version], [AnnoncørNo_], [BureauNo_], [AntalFarver], [IndrykningsUge], [OrdreUdsendt], [KonsulentCode] ASC);
GO

-- Creating primary key on [OrdreNr], [Version], [Document_Type], [AnnoncørID], [Uge], [AntalFarver], [OrdreDato], [SamletPris], [SælgerKode], [SikkerhedsGodt], [InfoGodt], [BureauOrdreNr], [Bureau], [EnOrdre], [Status], [MaterialeGodtgørelseTil], [Previous_Order_No] in table 'viewOrdreFINDs'
ALTER TABLE [dbo].[viewOrdreFINDs]
ADD CONSTRAINT [PK_viewOrdreFINDs]
    PRIMARY KEY CLUSTERED ([OrdreNr], [Version], [Document_Type], [AnnoncørID], [Uge], [AntalFarver], [OrdreDato], [SamletPris], [SælgerKode], [SikkerhedsGodt], [InfoGodt], [BureauOrdreNr], [Bureau], [EnOrdre], [Status], [MaterialeGodtgørelseTil], [Previous_Order_No] ASC);
GO

-- Creating primary key on [MedieplanNr], [Version], [AnnoncørNo_], [BureauNo_], [AntalFarver], [IndrykningsUge], [OrdreUdsendt], [KonsulentCode], [Overskrift] in table 'viewOrdreIkkeSendts'
ALTER TABLE [dbo].[viewOrdreIkkeSendts]
ADD CONSTRAINT [PK_viewOrdreIkkeSendts]
    PRIMARY KEY CLUSTERED ([MedieplanNr], [Version], [AnnoncørNo_], [BureauNo_], [AntalFarver], [IndrykningsUge], [OrdreUdsendt], [KonsulentCode], [Overskrift] ASC);
GO

-- Creating primary key on [OrdreNr], [Version], [Document_Type], [BladId], [Format], [Mm], [AnvendtPris], [SpecialRabat], [FarveTillægsPris], [FarveTillægsRabat], [MaterialeGodt], [TotalPris], [MaterialePris], [Previous_Order_No] in table 'viewOrdreLinjers'
ALTER TABLE [dbo].[viewOrdreLinjers]
ADD CONSTRAINT [PK_viewOrdreLinjers]
    PRIMARY KEY CLUSTERED ([OrdreNr], [Version], [Document_Type], [BladId], [Format], [Mm], [AnvendtPris], [SpecialRabat], [FarveTillægsPris], [FarveTillægsRabat], [MaterialeGodt], [TotalPris], [MaterialePris], [Previous_Order_No] ASC);
GO

-- Creating primary key on [OrdreNr], [Version], [Document_Type], [BladId], [Mm], [AnvendtPris], [SpecialRabat], [FarveTillægsPris], [FarveTillægsRabat], [MaterialeGodt], [MaterialePris] in table 'viewOrdreLinjerFINDs'
ALTER TABLE [dbo].[viewOrdreLinjerFINDs]
ADD CONSTRAINT [PK_viewOrdreLinjerFINDs]
    PRIMARY KEY CLUSTERED ([OrdreNr], [Version], [Document_Type], [BladId], [Mm], [AnvendtPris], [SpecialRabat], [FarveTillægsPris], [FarveTillægsRabat], [MaterialeGodt], [MaterialePris] ASC);
GO

-- Creating primary key on [MedieplanNr], [Version], [AnnoncørNo_], [BureauNo_], [AntalFarver], [IndrykningsUge], [OrdreUdsendt], [KonsulentCode], [Overskrift] in table 'viewOrdreSendtManglerMateriales'
ALTER TABLE [dbo].[viewOrdreSendtManglerMateriales]
ADD CONSTRAINT [PK_viewOrdreSendtManglerMateriales]
    PRIMARY KEY CLUSTERED ([MedieplanNr], [Version], [AnnoncørNo_], [BureauNo_], [AntalFarver], [IndrykningsUge], [OrdreUdsendt], [KonsulentCode], [Overskrift] ASC);
GO

-- Creating primary key on [MedieplanNr], [Version], [AnnoncørNo_], [BureauNo_], [AntalFarver], [IndrykningsUge], [OrdreUdsendt], [KonsulentCode], [Overskrift] in table 'viewOversigts'
ALTER TABLE [dbo].[viewOversigts]
ADD CONSTRAINT [PK_viewOversigts]
    PRIMARY KEY CLUSTERED ([MedieplanNr], [Version], [AnnoncørNo_], [BureauNo_], [AntalFarver], [IndrykningsUge], [OrdreUdsendt], [KonsulentCode], [Overskrift] ASC);
GO

-- Creating primary key on [MedieplanNr], [Version], [Status] in table 'viewUpdateStatusIMedieplans'
ALTER TABLE [dbo].[viewUpdateStatusIMedieplans]
ADD CONSTRAINT [PK_viewUpdateStatusIMedieplans]
    PRIMARY KEY CLUSTERED ([MedieplanNr], [Version], [Status] ASC);
GO

-- Creating primary key on [MedieplanNr], [AktivVersion], [Status] in table 'viewUpdateStatusIMedieplanNrs'
ALTER TABLE [dbo].[viewUpdateStatusIMedieplanNrs]
ADD CONSTRAINT [PK_viewUpdateStatusIMedieplanNrs]
    PRIMARY KEY CLUSTERED ([MedieplanNr], [AktivVersion], [Status] ASC);
GO

-- Creating primary key on [id] in table 'tblOphørtBlad'
ALTER TABLE [dbo].[tblOphørtBlad]
ADD CONSTRAINT [PK_tblOphørtBlad]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'tblStamBladBogHolderis'
ALTER TABLE [dbo].[tblStamBladBogHolderis]
ADD CONSTRAINT [PK_tblStamBladBogHolderis]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [koncernId] in table 'tblStambladKoncerns'
ALTER TABLE [dbo].[tblStambladKoncerns]
ADD CONSTRAINT [PK_tblStambladKoncerns]
    PRIMARY KEY CLUSTERED ([koncernId] ASC);
GO

-- Creating primary key on [tblKontaktArbOmråder_ArbOmrådeID], [tblKontakters_KontaktID] in table 'tblKontakterArbOmråderPrKontakt'
ALTER TABLE [dbo].[tblKontakterArbOmråderPrKontakt]
ADD CONSTRAINT [PK_tblKontakterArbOmråderPrKontakt]
    PRIMARY KEY CLUSTERED ([tblKontaktArbOmråder_ArbOmrådeID], [tblKontakters_KontaktID] ASC);
GO

-- Creating primary key on [tblKontakterPrBlads_BladID], [tblKontakterPrBlads_KontaktID], [tblKontaktFunktioners_FunktionID] in table 'tblKontaktFunktionerPrBlad'
ALTER TABLE [dbo].[tblKontaktFunktionerPrBlad]
ADD CONSTRAINT [PK_tblKontaktFunktionerPrBlad]
    PRIMARY KEY CLUSTERED ([tblKontakterPrBlads_BladID], [tblKontakterPrBlads_KontaktID], [tblKontaktFunktioners_FunktionID] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Fejlkode] in table 'tblAnnoncekontrols'
ALTER TABLE [dbo].[tblAnnoncekontrols]
ADD CONSTRAINT [FK_tblFejl_tblFejlTekst]
    FOREIGN KEY ([Fejlkode])
    REFERENCES [dbo].[tblFejlTeksts]
        ([Fejlkode])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_tblFejl_tblFejlTekst'
CREATE INDEX [IX_FK_tblFejl_tblFejlTekst]
ON [dbo].[tblAnnoncekontrols]
    ([Fejlkode]);
GO

-- Creating foreign key on [MedieplanNr], [UgeavisID] in table 'tblMedieplanLinjers'
ALTER TABLE [dbo].[tblMedieplanLinjers]
ADD CONSTRAINT [FK_tblMedieplanLinjer_tblFejl]
    FOREIGN KEY ([MedieplanNr], [UgeavisID])
    REFERENCES [dbo].[tblAnnoncekontrols]
        ([MedieplanNr], [UgeavisID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_tblMedieplanLinjer_tblFejl'
CREATE INDEX [IX_FK_tblMedieplanLinjer_tblFejl]
ON [dbo].[tblMedieplanLinjers]
    ([MedieplanNr], [UgeavisID]);
GO

-- Creating foreign key on [ID] in table 'tblMedIGruppes'
ALTER TABLE [dbo].[tblMedIGruppes]
ADD CONSTRAINT [FK_tblBladeIGrupper_tblBladStamdata]
    FOREIGN KEY ([ID])
    REFERENCES [dbo].[tblBladStamdatas]
        ([BladID])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_tblBladeIGrupper_tblBladStamdata'
CREATE INDEX [IX_FK_tblBladeIGrupper_tblBladStamdata]
ON [dbo].[tblMedIGruppes]
    ([ID]);
GO

-- Creating foreign key on [OrdrecheckSendeDagID] in table 'tblBladStamdatas'
ALTER TABLE [dbo].[tblBladStamdatas]
ADD CONSTRAINT [FK_tblBladStamdata_OrdrecheckSendeDagID_tblDage_DagID]
    FOREIGN KEY ([OrdrecheckSendeDagID])
    REFERENCES [dbo].[tblDages]
        ([DagID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_tblBladStamdata_OrdrecheckSendeDagID_tblDage_DagID'
CREATE INDEX [IX_FK_tblBladStamdata_OrdrecheckSendeDagID_tblDage_DagID]
ON [dbo].[tblBladStamdatas]
    ([OrdrecheckSendeDagID]);
GO

-- Creating foreign key on [UgedagID] in table 'tblBladStamdatas'
ALTER TABLE [dbo].[tblBladStamdatas]
ADD CONSTRAINT [FK_tblBladStamdata_UgedagID_tblDage_DagID]
    FOREIGN KEY ([UgedagID])
    REFERENCES [dbo].[tblDages]
        ([DagID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_tblBladStamdata_UgedagID_tblDage_DagID'
CREATE INDEX [IX_FK_tblBladStamdata_UgedagID_tblDage_DagID]
ON [dbo].[tblBladStamdatas]
    ([UgedagID]);
GO

-- Creating foreign key on [DelOmrådeID] in table 'tblBladStamdatas'
ALTER TABLE [dbo].[tblBladStamdatas]
ADD CONSTRAINT [FK_tblBladStamdata_tblDelOmråde]
    FOREIGN KEY ([DelOmrådeID])
    REFERENCES [dbo].[tblDelOmråde]
        ([DelOmrådeID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_tblBladStamdata_tblDelOmråde'
CREATE INDEX [IX_FK_tblBladStamdata_tblDelOmråde]
ON [dbo].[tblBladStamdatas]
    ([DelOmrådeID]);
GO

-- Creating foreign key on [GeoKodeID] in table 'tblBladStamdatas'
ALTER TABLE [dbo].[tblBladStamdatas]
ADD CONSTRAINT [FK_tblBladStamdata_tblGeoKoder]
    FOREIGN KEY ([GeoKodeID])
    REFERENCES [dbo].[tblGeoKodes]
        ([GeoKodeID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_tblBladStamdata_tblGeoKoder'
CREATE INDEX [IX_FK_tblBladStamdata_tblGeoKoder]
ON [dbo].[tblBladStamdatas]
    ([GeoKodeID]);
GO

-- Creating foreign key on [HovedgruppeID] in table 'tblBladStamdatas'
ALTER TABLE [dbo].[tblBladStamdatas]
ADD CONSTRAINT [FK_tblBladStamdata_tblHovedGruppe]
    FOREIGN KEY ([HovedgruppeID])
    REFERENCES [dbo].[tblHovedGruppes]
        ([HovedGruppeID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_tblBladStamdata_tblHovedGruppe'
CREATE INDEX [IX_FK_tblBladStamdata_tblHovedGruppe]
ON [dbo].[tblBladStamdatas]
    ([HovedgruppeID]);
GO

-- Creating foreign key on [PostNr] in table 'tblBladStamdatas'
ALTER TABLE [dbo].[tblBladStamdatas]
ADD CONSTRAINT [FK_tblBladStamdata_tblPostNr]
    FOREIGN KEY ([PostNr])
    REFERENCES [dbo].[tblPostNrs]
        ([PostNr])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_tblBladStamdata_tblPostNr'
CREATE INDEX [IX_FK_tblBladStamdata_tblPostNr]
ON [dbo].[tblBladStamdatas]
    ([PostNr]);
GO

-- Creating foreign key on [RegionID] in table 'tblBladStamdatas'
ALTER TABLE [dbo].[tblBladStamdatas]
ADD CONSTRAINT [FK_tblBladStamdata_tblRegioner]
    FOREIGN KEY ([RegionID])
    REFERENCES [dbo].[tblRegions]
        ([RegionID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_tblBladStamdata_tblRegioner'
CREATE INDEX [IX_FK_tblBladStamdata_tblRegioner]
ON [dbo].[tblBladStamdatas]
    ([RegionID]);
GO

-- Creating foreign key on [bladId] in table 'tblBladTillaegs'
ALTER TABLE [dbo].[tblBladTillaegs]
ADD CONSTRAINT [FK_tblBladTillaeg_tblBladStamdata]
    FOREIGN KEY ([bladId])
    REFERENCES [dbo].[tblBladStamdatas]
        ([BladID])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_tblBladTillaeg_tblBladStamdata'
CREATE INDEX [IX_FK_tblBladTillaeg_tblBladStamdata]
ON [dbo].[tblBladTillaegs]
    ([bladId]);
GO

-- Creating foreign key on [UgeavisID] in table 'tblMedieplanLinjers'
ALTER TABLE [dbo].[tblMedieplanLinjers]
ADD CONSTRAINT [FK_tblMedieplanLinjer_tblBladStamdata]
    FOREIGN KEY ([UgeavisID])
    REFERENCES [dbo].[tblBladStamdatas]
        ([BladID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_tblMedieplanLinjer_tblBladStamdata'
CREATE INDEX [IX_FK_tblMedieplanLinjer_tblBladStamdata]
ON [dbo].[tblMedieplanLinjers]
    ([UgeavisID]);
GO

-- Creating foreign key on [BladID] in table 'tblPrisers'
ALTER TABLE [dbo].[tblPrisers]
ADD CONSTRAINT [FK_tblPriser_tblBladStamdata]
    FOREIGN KEY ([BladID])
    REFERENCES [dbo].[tblBladStamdatas]
        ([BladID])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [BladID] in table 'tblPrislisterPrBladPrÅr'
ALTER TABLE [dbo].[tblPrislisterPrBladPrÅr]
ADD CONSTRAINT [FK_tblPrislisterPrBladPrÅr_tblBladStamdata]
    FOREIGN KEY ([BladID])
    REFERENCES [dbo].[tblBladStamdatas]
        ([BladID])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [BladID] in table 'tblPrislisterPrBladPrUges'
ALTER TABLE [dbo].[tblPrislisterPrBladPrUges]
ADD CONSTRAINT [FK_tblPrislisterPrBladPrUge_tblBladStamdata]
    FOREIGN KEY ([BladID])
    REFERENCES [dbo].[tblBladStamdatas]
        ([BladID])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [BladID] in table 'tblKontakterPrBlads'
ALTER TABLE [dbo].[tblKontakterPrBlads]
ADD CONSTRAINT [FK_tblKontakterPrBlad_tblBladStamdataKopi]
    FOREIGN KEY ([BladID])
    REFERENCES [dbo].[tblBladStamdataKopis]
        ([BladID])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [typeId] in table 'tblBladTillaegs'
ALTER TABLE [dbo].[tblBladTillaegs]
ADD CONSTRAINT [FK_tblBladTillaeg_tblBladTillaegsType]
    FOREIGN KEY ([typeId])
    REFERENCES [dbo].[tblBladTillaegsTypes]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_tblBladTillaeg_tblBladTillaegsType'
CREATE INDEX [IX_FK_tblBladTillaeg_tblBladTillaegsType]
ON [dbo].[tblBladTillaegs]
    ([typeId]);
GO

-- Creating foreign key on [DPKulørID] in table 'tblMedieplans'
ALTER TABLE [dbo].[tblMedieplans]
ADD CONSTRAINT [FK_tblMedieplan_tblDPKulør]
    FOREIGN KEY ([DPKulørID])
    REFERENCES [dbo].[tblDPKulør]
        ([DPKulørID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_tblMedieplan_tblDPKulør'
CREATE INDEX [IX_FK_tblMedieplan_tblDPKulør]
ON [dbo].[tblMedieplans]
    ([DPKulørID]);
GO

-- Creating foreign key on [GruppeID], [Version] in table 'tblMedIGruppes'
ALTER TABLE [dbo].[tblMedIGruppes]
ADD CONSTRAINT [FK_tblMedIGruppe_tblGrupper]
    FOREIGN KEY ([GruppeID], [Version])
    REFERENCES [dbo].[tblGruppers]
        ([GruppeID], [Version])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_tblMedIGruppe_tblGrupper'
CREATE INDEX [IX_FK_tblMedIGruppe_tblGrupper]
ON [dbo].[tblMedIGruppes]
    ([GruppeID], [Version]);
GO

-- Creating foreign key on [KonkurrentID] in table 'tblKonkurrentDækning'
ALTER TABLE [dbo].[tblKonkurrentDækning]
ADD CONSTRAINT [FK_tblKonkurrentDækning_tblKonkurrenter]
    FOREIGN KEY ([KonkurrentID])
    REFERENCES [dbo].[tblKonkurrenters]
        ([KonkurrentID])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [PostNr] in table 'tblKonkurrentDækning'
ALTER TABLE [dbo].[tblKonkurrentDækning]
ADD CONSTRAINT [FK_tblKonkurrentDækning_tblPostNr]
    FOREIGN KEY ([PostNr])
    REFERENCES [dbo].[tblPostNrs]
        ([PostNr])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_tblKonkurrentDækning_tblPostNr'
CREATE INDEX [IX_FK_tblKonkurrentDækning_tblPostNr]
ON [dbo].[tblKonkurrentDækning]
    ([PostNr]);
GO

-- Creating foreign key on [TitelID] in table 'tblKontakters'
ALTER TABLE [dbo].[tblKontakters]
ADD CONSTRAINT [FK_tblKontakter_tblKontaktTitler]
    FOREIGN KEY ([TitelID])
    REFERENCES [dbo].[tblKontaktTitlers]
        ([TitelID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_tblKontakter_tblKontaktTitler'
CREATE INDEX [IX_FK_tblKontakter_tblKontaktTitler]
ON [dbo].[tblKontakters]
    ([TitelID]);
GO

-- Creating foreign key on [KontaktID] in table 'tblKontakterPrBlads'
ALTER TABLE [dbo].[tblKontakterPrBlads]
ADD CONSTRAINT [FK_tblKontakterPrBlad_tblKontakter]
    FOREIGN KEY ([KontaktID])
    REFERENCES [dbo].[tblKontakters]
        ([KontaktID])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_tblKontakterPrBlad_tblKontakter'
CREATE INDEX [IX_FK_tblKontakterPrBlad_tblKontakter]
ON [dbo].[tblKontakterPrBlads]
    ([KontaktID]);
GO

-- Creating foreign key on [MedieplanNr] in table 'tblMateriales'
ALTER TABLE [dbo].[tblMateriales]
ADD CONSTRAINT [FK_tblMateriale_tblMedieplanNr]
    FOREIGN KEY ([MedieplanNr])
    REFERENCES [dbo].[tblMedieplanNrs]
        ([MedieplanNr])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [MedieplanNr], [UgeavisID] in table 'tblMedieplanLinjers'
ALTER TABLE [dbo].[tblMedieplanLinjers]
ADD CONSTRAINT [FK_tblMedieplanLinjer_tblMateriale]
    FOREIGN KEY ([MedieplanNr], [UgeavisID])
    REFERENCES [dbo].[tblMateriales]
        ([MedieplanNr], [UgeavisID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_tblMedieplanLinjer_tblMateriale'
CREATE INDEX [IX_FK_tblMedieplanLinjer_tblMateriale]
ON [dbo].[tblMedieplanLinjers]
    ([MedieplanNr], [UgeavisID]);
GO

-- Creating foreign key on [MedieplanNr] in table 'tblMedieplans'
ALTER TABLE [dbo].[tblMedieplans]
ADD CONSTRAINT [FK_tblMedieplan_tblMedieplanNr]
    FOREIGN KEY ([MedieplanNr])
    REFERENCES [dbo].[tblMedieplanNrs]
        ([MedieplanNr])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [PlaceringID] in table 'tblMedieplans'
ALTER TABLE [dbo].[tblMedieplans]
ADD CONSTRAINT [FK_tblMedieplan_tblPlacering]
    FOREIGN KEY ([PlaceringID])
    REFERENCES [dbo].[tblPlacerings]
        ([PlaceringID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_tblMedieplan_tblPlacering'
CREATE INDEX [IX_FK_tblMedieplan_tblPlacering]
ON [dbo].[tblMedieplans]
    ([PlaceringID]);
GO

-- Creating foreign key on [MedieplanNr], [Version] in table 'tblMedieplanLinjers'
ALTER TABLE [dbo].[tblMedieplanLinjers]
ADD CONSTRAINT [FK_tblMedieplanLinjer_tblMedieplan]
    FOREIGN KEY ([MedieplanNr], [Version])
    REFERENCES [dbo].[tblMedieplans]
        ([MedieplanNr], [Version])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [OrdreNr], [Version], [Document_Type] in table 'tblOrdreGebyrNavisions'
ALTER TABLE [dbo].[tblOrdreGebyrNavisions]
ADD CONSTRAINT [FK_tblOrdreGebyrNavision_tblOrdreNavision]
    FOREIGN KEY ([OrdreNr], [Version], [Document_Type])
    REFERENCES [dbo].[tblOrdreNavisions]
        ([OrdreNr], [Version], [Document_Type])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [OrdreNr], [Version], [Document_Type] in table 'tblOrdreLinjerNavisions'
ALTER TABLE [dbo].[tblOrdreLinjerNavisions]
ADD CONSTRAINT [FK_tblOrdreLinjerNavision_tblOrdreNavision]
    FOREIGN KEY ([OrdreNr], [Version], [Document_Type])
    REFERENCES [dbo].[tblOrdreNavisions]
        ([OrdreNr], [Version], [Document_Type])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [PlaceringID] in table 'tblPrisers'
ALTER TABLE [dbo].[tblPrisers]
ADD CONSTRAINT [FK_tblPriser_tblPlacering]
    FOREIGN KEY ([PlaceringID])
    REFERENCES [dbo].[tblPlacerings]
        ([PlaceringID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_tblPriser_tblPlacering'
CREATE INDEX [IX_FK_tblPriser_tblPlacering]
ON [dbo].[tblPrisers]
    ([PlaceringID]);
GO

-- Creating foreign key on [PostNr] in table 'tblPostNrSøgning'
ALTER TABLE [dbo].[tblPostNrSøgning]
ADD CONSTRAINT [FK_tblPostNrSøgning_tblPostNr]
    FOREIGN KEY ([PostNr])
    REFERENCES [dbo].[tblPostNrs]
        ([PostNr])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_tblPostNrSøgning_tblPostNr'
CREATE INDEX [IX_FK_tblPostNrSøgning_tblPostNr]
ON [dbo].[tblPostNrSøgning]
    ([PostNr]);
GO

-- Creating foreign key on [PrislisteID] in table 'tblPrisers'
ALTER TABLE [dbo].[tblPrisers]
ADD CONSTRAINT [FK_tblPriser_tblPrislister]
    FOREIGN KEY ([PrislisteID])
    REFERENCES [dbo].[tblPrislisters]
        ([PrislisteID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_tblPriser_tblPrislister'
CREATE INDEX [IX_FK_tblPriser_tblPrislister]
ON [dbo].[tblPrisers]
    ([PrislisteID]);
GO

-- Creating foreign key on [PrislisteID] in table 'tblPrislisterPrBladPrÅr'
ALTER TABLE [dbo].[tblPrislisterPrBladPrÅr]
ADD CONSTRAINT [FK_tblPrislisterPrBladPrÅr_tblPrislister]
    FOREIGN KEY ([PrislisteID])
    REFERENCES [dbo].[tblPrislisters]
        ([PrislisteID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_tblPrislisterPrBladPrÅr_tblPrislister'
CREATE INDEX [IX_FK_tblPrislisterPrBladPrÅr_tblPrislister]
ON [dbo].[tblPrislisterPrBladPrÅr]
    ([PrislisteID]);
GO

-- Creating foreign key on [PrislisteID] in table 'tblPrislisterPrBladPrUges'
ALTER TABLE [dbo].[tblPrislisterPrBladPrUges]
ADD CONSTRAINT [FK_tblPrislisterPrBladPrUge_tblPrislister]
    FOREIGN KEY ([PrislisteID])
    REFERENCES [dbo].[tblPrislisters]
        ([PrislisteID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_tblPrislisterPrBladPrUge_tblPrislister'
CREATE INDEX [IX_FK_tblPrislisterPrBladPrUge_tblPrislister]
ON [dbo].[tblPrislisterPrBladPrUges]
    ([PrislisteID]);
GO

-- Creating foreign key on [tblKontaktArbOmråder_ArbOmrådeID] in table 'tblKontakterArbOmråderPrKontakt'
ALTER TABLE [dbo].[tblKontakterArbOmråderPrKontakt]
ADD CONSTRAINT [FK_tblKontakterArbOmråderPrKontakt_tblKontaktArbOmråder]
    FOREIGN KEY ([tblKontaktArbOmråder_ArbOmrådeID])
    REFERENCES [dbo].[tblKontaktArbOmråder]
        ([ArbOmrådeID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [tblKontakters_KontaktID] in table 'tblKontakterArbOmråderPrKontakt'
ALTER TABLE [dbo].[tblKontakterArbOmråderPrKontakt]
ADD CONSTRAINT [FK_tblKontakterArbOmråderPrKontakt_tblKontakter]
    FOREIGN KEY ([tblKontakters_KontaktID])
    REFERENCES [dbo].[tblKontakters]
        ([KontaktID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_tblKontakterArbOmråderPrKontakt_tblKontakter'
CREATE INDEX [IX_FK_tblKontakterArbOmråderPrKontakt_tblKontakter]
ON [dbo].[tblKontakterArbOmråderPrKontakt]
    ([tblKontakters_KontaktID]);
GO

-- Creating foreign key on [tblKontakterPrBlads_BladID], [tblKontakterPrBlads_KontaktID] in table 'tblKontaktFunktionerPrBlad'
ALTER TABLE [dbo].[tblKontaktFunktionerPrBlad]
ADD CONSTRAINT [FK_tblKontaktFunktionerPrBlad_tblKontakterPrBlad]
    FOREIGN KEY ([tblKontakterPrBlads_BladID], [tblKontakterPrBlads_KontaktID])
    REFERENCES [dbo].[tblKontakterPrBlads]
        ([BladID], [KontaktID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [tblKontaktFunktioners_FunktionID] in table 'tblKontaktFunktionerPrBlad'
ALTER TABLE [dbo].[tblKontaktFunktionerPrBlad]
ADD CONSTRAINT [FK_tblKontaktFunktionerPrBlad_tblKontaktFunktioner]
    FOREIGN KEY ([tblKontaktFunktioners_FunktionID])
    REFERENCES [dbo].[tblKontaktFunktioners]
        ([FunktionID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_tblKontaktFunktionerPrBlad_tblKontaktFunktioner'
CREATE INDEX [IX_FK_tblKontaktFunktionerPrBlad_tblKontaktFunktioner]
ON [dbo].[tblKontaktFunktionerPrBlad]
    ([tblKontaktFunktioners_FunktionID]);
GO

-- Creating foreign key on [Bladid] in table 'tblStamBladBogHolderis'
ALTER TABLE [dbo].[tblStamBladBogHolderis]
ADD CONSTRAINT [FK_tblStamBladBogHolderi_tblBladStamdata]
    FOREIGN KEY ([Bladid])
    REFERENCES [dbo].[tblBladStamdatas]
        ([BladID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_tblStamBladBogHolderi_tblBladStamdata'
CREATE INDEX [IX_FK_tblStamBladBogHolderi_tblBladStamdata]
ON [dbo].[tblStamBladBogHolderis]
    ([Bladid]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------