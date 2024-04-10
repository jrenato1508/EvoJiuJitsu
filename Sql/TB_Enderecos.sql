USE [EvoJiuJitsu]
GO

/****** Object:  Table [dbo].[Enderecos]    Script Date: 10/04/2024 11:39:27 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Enderecos](
	[Id] [uniqueidentifier] NOT NULL,
	[AtletaId] [uniqueidentifier] NOT NULL,
	[Logradouro] [varchar](100) NOT NULL,
	[Numero] [varchar](100) NOT NULL,
	[Complemento] [varchar](100) NULL,
	[Cep] [varchar](100) NOT NULL,
	[Bairro] [varchar](100) NOT NULL,
	[Cidade] [varchar](100) NOT NULL,
	[Estado] [varchar](100) NOT NULL,
 CONSTRAINT [PK_Enderecos] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Enderecos]  WITH CHECK ADD  CONSTRAINT [FK_Enderecos_Atletas_AtletaId] FOREIGN KEY([AtletaId])
REFERENCES [dbo].[Atletas] ([Id])
GO

ALTER TABLE [dbo].[Enderecos] CHECK CONSTRAINT [FK_Enderecos_Atletas_AtletaId]
GO


INSERT INTO [Enderecos] VALUES
('396457bf-98cd-4520-8602-3104877e48ea',	'0957D419-B2B2-4719-8B3F-013E4A104769',	N'Alameda da Paz'					,737,	null, 66822600	,N'Águas Negras (Icoaraci)'		,N'Belém'	,N'PA'),
('a27eac2c-548b-40f2-a35b-13824a0e8ab5',	'C173E867-79BE-47BA-9B2C-02EFC167F396',	N'Avenida Roberto Camelier'			,536,	null, 66025442	,N'Jurunas'						,N'Belém'	,N'PA'),
('d5168836-0500-4e8f-95e2-d088c14e2b61',	'ED344C24-E636-4F75-DAD4-08DC502BE6FC',	N'Alameda Esperança'				,951,	null, 66825834	,N'Tapanã (Icoaraci)'			,N'Belém'	,N'PA'),
('298be4a3-7f46-4174-808a-aa8b7f3c94e6',	'87C457B0-7614-4B37-047B-08DC528C413F',	N'Avenida Conjunto Universitário'	,676,	null, 66070015	,N'Terra Firme'					,N'Belém'	,N'PA'),
('e5fa8cc7-1ba2-4bad-8fef-2f3310d1956b',	'5A50AAAE-ADD4-4E1B-7DBA-08DC531249B4',	N'Rua Vinte e Cinco A'				,162,	null, 66110072	,N'Maracangalha'				,N'Belém'	,N'PA'),
('70f69d2f-ec6c-4417-8366-ca996249126a',	'87B18EAE-BA18-4216-1F17-08DC532B09CF',	N'Quadra B'							,756,	null, 66820862	,N'Tenoné'						,N'Belém'	,N'PA'),
('ab69a5bb-8725-45d0-8124-cd78717d31fa',	'D8ED7462-E751-4BF6-8EEE-08DC5403C498',	N'Quadra Quatro'					,989,	null, 66820066	,N'Tenoné'						,N'Belém'	,N'PA'),
('a8eb47b5-8a9d-4bda-9489-000275cafca5',	'27F3DA18-6DCB-49C1-8EEF-08DC5403C498',	N'Alameda Quatorze'					,419,	null, 66831014	,N'Tapanã (Icoaraci)'			,N'Belém'	,N'PA'),
('6ccdd187-bfe4-4f07-ad44-c2e208273d2e',	'401AB8ED-0943-42BD-8EF0-08DC5403C498',	N'Bloco Oito'						,179,	null, 66090470	,N'São Brás'					,N'Belém'	,N'PA'),
('3d1cba00-9c33-43f6-8682-2c4e1233e21f',	'E77586F4-7F7C-48B6-8EF1-08DC5403C498',	N'Vila Atayde'						,733,	null, 66025377	,N'Jurunas'						,N'Belém'	,N'PA'),
('ff4c7128-d269-4054-9cb3-c0e2360c71dc',	'6ADB185F-BF03-4C04-8EF2-08DC5403C498',	N'Passagem Bela Belém'				,506,	null, 66117375	,N'Barreiro'					,N'Belém'	,N'PA'),
('2304a73a-84dc-4aaa-8860-8ade251b8cd1',	'C2AA52DC-09CD-4CDA-8EF3-08DC5403C498',	N'Vila Maceió'						,515,	null, 66025144	,N'Jurunas'						,N'Belém'	,N'PA'),
('21072084-3409-4c8a-9eb6-16f8b74650df',	'8DDD7187-504B-42E9-8EF4-08DC5403C498',	N'Passagem H-2'						,865,	null, 66623271	,N'Marambaia'					,N'Belém'	,N'PA'),
('389109a4-b016-451c-a287-1a47841669dc',	'E1925844-972B-4A3F-94E6-08DC540F6AF8',	N'Passagem São Luiz'				,700,	null, 66820031	,N'Tenoné'						,N'Belém'	,N'PA'),
('1b25d2b0-8115-4485-8eff-1a8bd95f8e5e',	'569A601E-69DF-4768-A218-09AE111BE084',	N'Alameda Dois'						,264,	null, 66670150	,N'Coqueiro'					,N'Belém'	,N'PA'),
('15eac9e7-15ac-4660-a6d9-c60226a7f580',	'71DDB81E-314E-460A-9F3B-145C162C1C31',	N'Passagem São Pedro'				,836,	null, 66643500	,N'São Clemente'				,N'Belém'	,N'PA'),
('f2dd1578-0e46-4f2a-801d-b090d4e677a8',	'534BD1D0-6F55-461A-94B4-173BD44C4FCA',	N'Alameda Souza'					,612,	null, 66810269	,N'Cruzeiro (Icoaraci)'			,N'Belém'	,N'PA'),
('c2c02f47-c4e0-4008-b295-926a9aed5067',	'CA15A03A-ACCB-454B-BC1A-1C07E4DBA0C0',	N'Alameda Sessenta'					,242,	null, 66831060	,N'Tapanã (Icoaraci)'			,N'Belém'	,N'PA'),
('1d92fbf7-5871-4b68-a786-60afa67387d0',	'2CD837C1-9A6D-4563-B718-27437D927426',	N'Passagem da Olaria'				,919,	null, 66816060	,N'Pratinha (Icoaraci)'			,N'Belém'	,N'PA'),
('ed611659-7084-4fd7-b5f6-540331fb4a32',	'9FEB1D64-CA3B-4133-950E-3147B5909EA3',	N'Travessa Mauriti'					,768,	null, 66083000	,N'Telégrafo Sem Fio'			,N'Belém'	,N'PA'),
('b6ef8fb1-4190-41b7-8203-8e2dc0a93085',	'0F855F4E-A54E-4A04-AAD6-33AE83E3C066',	N'Avenida Jáder Barbalho'			,309,	null, 66843650	,N'Água Boa (Outeiro)'			,N'Belém'	,N'PA'),
('052c76f2-a7f9-4897-95b6-4e98bb5f4d63',	'A01112C1-350B-4589-B912-369ADFE14ECF',	N'Travessa dos Tupinambás'			,242,	null, 66033124	,N'Jurunas'						,N'Belém'	,N'PA'),
('613bb6d2-4e19-4ea0-9bd6-6b37a458a9f4',	'5243000B-2E97-4F58-8F9C-37538C16CD12',	N'Passagem Irmãos Pires'			,449,	null, 66025030	,N'Jurunas'						,N'Belém'	,N'PA'),
('549035d8-a9a4-4edf-8d39-bcd8e7b7725a',	'C5DF9CEA-B327-42F1-AB82-3B09E5A9A327',	N'Passagem João Batista'			,522,	null, 66822690	,N'Águas Negras (Icoaraci)'		,N'Belém'	,N'PA'),
('50acea00-2dcb-4171-aa83-f405f2c6ab2c',	'28FA72EB-D62E-499D-A4C2-408A8CEFD742',	N'Rua Antônio Tavernard'			,348,	null, 66920750	,N'São Francisco (Mosqueiro)'	,N'Belém'	,N'PA'),
('0ff01f02-e9dd-45fd-a0b1-2a862a8a0293',	'96C9BFC2-07B9-430F-9E59-4341C5266817',	N'Vila Conceição'					,231,	null, 66073140	,N'Guamá'						,N'Belém'	,N'PA'),
('a143e970-688d-484f-aa72-a5d6500501c5',	'241A839E-1373-43BA-B9DC-4A2811C40EA1',	N'Rua Jaime Teixeira'				,414,	null, 66821560	,N'Parque Guajará (Icoaraci)'	,N'Belém'	,N'PA'),
('953169b0-a860-413f-adf7-ed245a777733',	'A2AC2FD3-3A0D-44EB-9EB5-4F372451EEFF',	N'Rua Projetada'					,621,	null, 66912050	,N'Mangueiras (Mosqueiro)'		,N'Belém'	,N'PA'),
('b548dad4-eacd-426a-8c7c-9a1efdc1c3de',	'E95D607E-0651-46D2-9EFF-553B5BF7D316',	N'Alameda Quinze de Agosto'			,947,	null, 66635285	,N'Parque Verde'				,N'Belém'	,N'PA'),
('13ab02ae-8d80-405f-bbff-eb459b366a35',	'ABEED231-D85D-4D28-99F4-5C4BB25D9602',	N'Passagem Santo André'				,353,	null, 66645470	,N'Castanheira'					,N'Belém'	,N'PA'),
('ed86504f-e338-4a10-8681-e59750d2aa53',	'B9AB831C-4CE2-49CF-9313-5DDCB242FE5A',	N'Rua Tiradentes'					,737,	null, 66123390	,N'Sacramenta'					,N'Belém'	,N'PA'),
('b8776a68-7da0-4cbe-8382-5f8bc3836023',	'F80E8CF4-CCFD-42FB-A8BC-5F8897A90688',	N'Vila Souza'						,113,	null, 66023080	,N'Cidade Velha'				,N'Belém'	,N'PA'),
('ef2e78ed-927e-4ce8-a995-2b1ff00b3704',	'D4077536-F75E-4A9B-975A-671FA3C7628E',	N'Rua T-4'							,718,	null, 66625295	,N'Cabanagem'					,N'Belém'	,N'PA'),
('f8bac621-74b5-48d1-90a0-a31af2f038d7',	'782DB413-81D5-4570-850F-6A49B3DC0233',	N'Vila Jacob'						,872,	null, 66079471	,N'Terra Firme'					,N'Belém'	,N'PA'),
('6115179a-7b89-4b3c-aab0-42c6c6e0bcd8',	'DB41C940-D892-4EBE-AA10-6C1FECC45120',	N'Travessa Chico Mendes'			,460,	null, 66640060	,N'Mangueirão'					,N'Belém'	,N'PA'),
('2a954cd3-8421-483c-951b-8dcbafc1a9a4',	'03E9A9D6-A535-4EBB-B183-7E67729C8B0E',	N'Alameda Silva'					,959,	null, 66825530	,N'Tapanã (Icoaraci)'			,N'Belém'	,N'PA'),
('b2fcda5c-c5e9-471b-bfff-dd42121a350d',	'00FAAC70-CFFD-4029-AB66-81AE9CF216C5',	N'Avenida Maracanã'					,892,	null, 66620260	,N'Marambaia'					,N'Belém'	,N'PA'),
('93dd7d5c-f0b7-4a02-ad5c-9fb71f210ac9',	'3717C3E2-CDBA-4397-95A5-828DB696EA72',	N'Vila Julianor'					,526,	null, 66033050	,N'Batista Campos'				,N'Belém'	,N'PA'),
('c329a1c3-91df-4736-97a9-1327c1ae9abc',	'CBD17310-CDC4-4932-B657-83574C5F4C7A',	N'Alameda Inten'					,678,	null, 66073260	,N'Guamá'						,N'Belém'	,N'PA'),
('5c34c2ad-bbc6-4630-a2ab-37135e744ee1',	'E60DD04C-1A28-4910-8787-83C7FEFC6213',	N'Travessa Apinagés'				,130,	null, 66033263	,N'Batista Campos'				,N'Belém'	,N'PA'),
('953e11f2-cb33-4dea-8e8b-6d1a26320aff',	'A55768B0-3194-40E2-8B5A-8ACCFA7CDCB7',	N'Vila Vicente de Carvalho'			,957,	null, 66032280	,N'Condor'						,N'Belém'	,N'PA'),
('c9625c52-7f33-4159-9b63-6fe136368c6a',	'A2924CF7-65D2-48F6-A14B-8DD5C37AA919',	N'Alameda E'						,703,	null, 66815152	,N'Maracacuera (Icoaraci)'		,N'Belém'	,N'PA'),
('dc39c211-5fe5-4376-be4e-ffafe16ab818',	'D24ED323-1D3D-41AE-8174-92D15E10DA70',	N'Passagem Roso Danin'				,899,	null, 66070415	,N'Canudos'						,N'Belém'	,N'PA'),
('576f48b4-3037-40dd-aeb6-60fbd4c65cbf',	'3B19A6A8-D619-4017-94C0-92D645B0353A',	N'Rua WF-6'							,393,	null, 66633610	,N'Parque Verde'				,N'Belém'	,N'PA'),
('d454e067-58a5-45ec-b019-4adaa99a94d2',	'7C80CB9F-D65B-4AB9-A3AC-9692AF0676EA',	N'Quadra Vinte e Um'				,637,	null, 66110122	,N'Maracangalha'				,N'Belém'	,N'PA'),
('1476a5ed-1710-448c-8cc0-b574f8c2d62f',	'721914A4-ED02-4F88-954E-99B77883FAED',	N'Avenida Alcindo Cacela'			,892,	null, 66045197	,N'Cremação'					,N'Belém'	,N'PA'),
('f449e325-63f4-406e-8d21-3ab6c8b1b5d9',	'0212AF65-90B4-40DE-9F2B-99E339116F73',	N'Rodovia Augusto Montenegro'		,866,	null, 66820000	,N'Tenoné'						,N'Belém'	,N'PA'),
('e0b4baf0-a8f4-41dc-8afc-f09d5e19fc3f',	'40AEE91C-8445-44B5-A0FD-9B9600084A56',	N'Vila John Engelhard'				,645,	null, 66816730	,N'Pratinha (Icoaraci)'			,N'Belém'	,N'PA'),
('16abd423-dbc7-4f1d-8dfc-6a7751ec4c42',	'6CD9FFAB-4001-4DD1-BB8A-9CB3DA82BEE5',	N'Vila Beijoca'						,166,	null, 66050030	,N'Umarizal'					,N'Belém'	,N'PA'),
('5ad1758f-5ed2-49b9-8f3b-a4393e70a69d',	'46B3D092-CA5E-483F-A023-9F8E722E8B0C',	N'Alameda Décima Primeira'			,910,	null, 66670820	,N'Coqueiro'					,N'Belém'	,N'PA'),
('31f91939-1489-4016-a0b3-ac8051713dd7',	'040A0AF8-3251-4553-80CD-A1AE1CB4D048',	N'Vila Cecília Meireles'			,437,	null, 66032390	,N'Condor'						,N'Belém'	,N'PA'),
('abc4752d-09e8-4ef5-8e7f-c99e400c8cd2',	'17BF6396-3385-4683-8DD1-A25A3C7E6861',	N'Passagem C-2'						,979,	null, 66623255	,N'Marambaia'					,N'Belém'	,N'PA'),
('75365eed-3a09-4ed8-bc63-087c2ec9c4be',	'445166AD-0FF3-48CC-86C8-A627A841F648',	N'Passagem Nossa Senhora Aparecida'	,856,	null, 66454559	,N'Castanheira'					,N'Belém'	,N'PA'),
('49fe3205-4ebb-4545-a4b0-cfaedc2adc0c',	'267E434B-C888-4C9A-88C2-ADD96CEE7C4E',	N'Vila Zico'						,275,	null, 66026463	,N'Jurunas'						,N'Belém'	,N'PA'),
('e1db3383-c2a1-4001-8386-0ceb8080e56a',	'220F85D0-18C6-4270-8E37-AE4777BB5FAA',	N'Conjunto Jardim Sevilha'			,581,	null, 66635210	,N'Parque Verde'				,N'Belém'	,N'PA'),
('e94835c8-add7-47b2-945b-6a7f6086c135',	'3D9D7EB8-DDC8-4269-82BA-B5F6B661B4B7',	N'Vila José de Alencar'				,640,	null, 66032185	,N'Condor'						,N'Belém'	,N'PA'),
('df597ef6-88cf-47cd-bbcd-9328a2de873d',	'873E8AD6-233C-44A8-8C1A-B6C7B9616964',	N'Passagem Secundária'				,699,	null, 66055600	,N'Umarizal'					,N'Belém'	,N'PA'),
('ae4efb02-c80c-4664-acd7-3436069cd06e',	'1199018E-AA2E-46F8-A40B-B8C11CB697F5',	N'Vila Lene Bandeira'				,341,	null, 66830648	,N'Tapanã (Icoaraci)'			,N'Belém'	,N'PA'),
('fa8e57d4-7714-4c24-9207-7102a424205b',	'A12AA38A-E354-40BD-B522-B9824B24790D',	N'Rua Veiga Cabral'					,264,	null, 66023735	,N'Cidade Velha'				,N'Belém'	,N'PA'),
('6f5e7569-732c-4940-af54-53efc6162d28',	'C3437EC2-A5CC-4D93-A4B7-B9C99BAE9062',	N'Vila Quadros'						,473,	null, 66812385	,N'Ponta Grossa (Icoaraci)'		,N'Belém'	,N'PA'),
('9f9995fa-d8ca-430a-96ef-ca046b2456aa',	'076E6A6A-2AB8-484A-8D30-BFAE5C6AF446',	N'Quadra Dois'						,877,	null, 66640850	,N'Mangueirão'					,N'Belém'	,N'PA'),
('ef3e8a8e-95bc-4f48-9f03-b5d4ef81416f',	'12288751-35BD-4396-B9C7-C0C1656B9C56',	N'Passagem São José de Ribamar'		,279,	null, 66033090	,N'Jurunas'						,N'Belém'	,N'PA'),
('2787feaf-8a05-4885-8bac-d1f1dfd255ab',	'964B3508-8E63-4F74-A519-D1C0E47E7B5C',	N'Vila Talita'						,496,	null, 66026218	,N'Jurunas'						,N'Belém'	,N'PA'),
('da7541b9-9103-487f-8744-a98dd45a5352',	'79349800-F4EE-4643-811D-D40394DF7A38',	N'Vila Santa Rita Durão'			,494,	null, 66032100	,N'Condor'						,N'Belém'	,N'PA'),
('78dac3e1-9527-446c-9239-e544ec4c67cd',	'EBF4BC5B-7A4C-4C70-827B-D921CC51CEF2',	N'Alameda Princesa Isabel II'		,582,	null, 66811150	,N'Agulha (Icoaraci)'			,N'Belém'	,N'PA'),
('3a4ea445-a58b-4ca1-a623-5c10e4ffbc1d',	'F6ECFCF4-D256-4FC1-86B7-E0784A662BF4',	N'Rua WM-13'						,759,	null, 66633680	,N'Parque Verde'				,N'Belém'	,N'PA'),
('633fbca2-f05c-4c30-a249-de27d2e6a406',	'854505E3-D1A1-49FC-A558-E661C8C6F335',	N'Passagem Primeiro de Maio'		,531,	null, 66077540	,N'Terra Firme'					,N'Belém'	,N'PA'),
('4cfc7265-1fb7-4095-80d2-c474d08f78f0',	'F217AB4D-E031-44E2-96B4-E9594274CD1E',	N'Travessa Sete'					,978,	null, 66820806	,N'Tenoné'						,N'Belém'	,N'PA'),
('708d4d20-ef72-4d32-a0bf-7141e2858e79',	'9211E315-E33D-4DE0-83BC-E9FD4FCD49B5',	N'Vila Sobral'						,673,	null, 66083095	,N'Pedreira'					,N'Belém'	,N'PA'),
('99974a63-277c-45ec-b124-0c35a7873a33',	'D864BAB7-913B-4C2D-A70C-EEA956F0D0C2',	N'Rua Santo Amaro'					,293,	null, 66113836	,N'Telégrafo Sem Fio'			,N'Belém'	,N'PA'),
('0a67e297-a3b9-4208-97e8-8e66b523b3eb',	'C9F9FA07-5A22-427C-B217-F598533FA255',	N'Rua Amazonas'						,876,	null, 66617550	,N'Val-de-Cães'					,N'Belém'	,N'PA'),
('aa6ba002-4e2a-4474-a445-0746702e1b20',	'86AC83FB-C88B-41E3-BFD4-FD962E68D2F0',	N'Rua Lauro Sodré'					,128,	null, 66077291	,N'Terra Firme'					,N'Belém'	,N'PA'),
('8de55081-5771-45c3-96fb-36b046d9c811',	'0013A885-5925-487F-B9B5-FF1BA8FDE780',	N'Rua Osvaldo Cruz'					,336,	null, 66053200	,N'Reduto'						,N'Belém'	,N'PA'),
('c6d3250e-5d70-447b-b61f-c49620f6f5c8',	'1F5157A1-6D9B-457C-A122-FF61DC8DD3F2',	N'Conjunto Jardim Primavera'		,531,	null, 66830350	,N'Tapanã (Icoaraci)'			,N'Belém'	,N'PA'),
('cf603e45-5384-4820-af2d-c3fc8f5f8a66',	'B0635237-0AC3-492A-B70C-FF78F99D9BC8',	N'Travessa São José'				,953,	null, 66821135	,N'Parque Guajará (Icoaraci)'	,N'Belém'	,N'PA')


