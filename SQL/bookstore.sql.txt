IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [BookStoresDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [BookStoresDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [BookStoresDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [BookStoresDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [BookStoresDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [BookStoresDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [BookStoresDB] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [BookStoresDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [BookStoresDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [BookStoresDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [BookStoresDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [BookStoresDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [BookStoresDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [BookStoresDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [BookStoresDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [BookStoresDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [BookStoresDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [BookStoresDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [BookStoresDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [BookStoresDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [BookStoresDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [BookStoresDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [BookStoresDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [BookStoresDB] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [BookStoresDB] SET  MULTI_USER 
GO
ALTER DATABASE [BookStoresDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [BookStoresDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [BookStoresDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [BookStoresDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [BookStoresDB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [BookStoresDB] SET QUERY_STORE = OFF
GO
USE [BookStoresDB]
GO
/****** Object:  UserDefinedDataType [dbo].[empid]    Script Date: 5/22/2020 9:29:33 AM ******/
CREATE TYPE [dbo].[empid] FROM [char](9) NOT NULL
GO
/****** Object:  UserDefinedDataType [dbo].[id]    Script Date: 5/22/2020 9:29:33 AM ******/
CREATE TYPE [dbo].[id] FROM [varchar](11) NOT NULL
GO
/****** Object:  UserDefinedDataType [dbo].[tid]    Script Date: 5/22/2020 9:29:33 AM ******/
CREATE TYPE [dbo].[tid] FROM [varchar](6) NOT NULL
GO
/****** Object:  Table [dbo].[Author]    Script Date: 5/22/2020 9:29:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Author](
	[author_id] [int] IDENTITY(1,1) NOT NULL,
	[last_name] [varchar](40) NOT NULL,
	[first_name] [varchar](20) NOT NULL,
	[phone] [char](12) NOT NULL,
	[address] [varchar](40) NULL,
	[city] [varchar](20) NULL,
	[state] [char](2) NULL,
	[zip] [char](5) NULL,
	[email_address] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[author_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Book]    Script Date: 5/22/2020 9:29:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Book](
	[book_id] [int] IDENTITY(1,1) NOT NULL,
	[title] [varchar](80) NOT NULL,
	[type] [char](12) NOT NULL,
	[pub_id] [int] NOT NULL,
	[price] [money] NULL,
	[advance] [money] NULL,
	[royalty] [int] NULL,
	[ytd_sales] [int] NULL,
	[notes] [varchar](200) NULL,
	[published_date] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[book_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BookAuthor]    Script Date: 5/22/2020 9:29:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BookAuthor](
	[author_id] [int] NOT NULL,
	[book_id] [int] NOT NULL,
	[author_order] [tinyint] NULL,
	[royality_percentage] [int] NULL,
 CONSTRAINT [PK_BookAuthor] PRIMARY KEY CLUSTERED 
(
	[author_id] ASC,
	[book_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Job]    Script Date: 5/22/2020 9:29:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Job](
	[job_id] [smallint] IDENTITY(1,1) NOT NULL,
	[job_desc] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[job_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Publisher]    Script Date: 5/22/2020 9:29:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Publisher](
	[pub_id] [int] IDENTITY(1,1) NOT NULL,
	[publisher_name] [varchar](40) NULL,
	[city] [varchar](20) NULL,
	[state] [char](2) NULL,
	[country] [varchar](30) NULL,
PRIMARY KEY CLUSTERED 
(
	[pub_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RefreshToken]    Script Date: 5/22/2020 9:29:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RefreshToken](
	[token_id] [int] IDENTITY(1,1) NOT NULL,
	[user_id] [int] NOT NULL,
	[token] [varchar](200) NOT NULL,
	[expiry_date] [datetime] NOT NULL,
 CONSTRAINT [PK_RefreshToken] PRIMARY KEY CLUSTERED 
(
	[token_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Role]    Script Date: 5/22/2020 9:29:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Role](
	[role_id] [smallint] IDENTITY(1,1) NOT NULL,
	[role_desc] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[role_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sale]    Script Date: 5/22/2020 9:29:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sale](
	[sale_id] [int] IDENTITY(1,1) NOT NULL,
	[store_id] [char](4) NOT NULL,
	[order_num] [varchar](20) NOT NULL,
	[order_date] [datetime] NOT NULL,
	[quantity] [smallint] NOT NULL,
	[pay_terms] [varchar](12) NOT NULL,
	[book_id] [int] NOT NULL,
 CONSTRAINT [PK_Sale2] PRIMARY KEY CLUSTERED 
(
	[sale_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Store]    Script Date: 5/22/2020 9:29:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Store](
	[store_id] [char](4) NOT NULL,
	[store_name] [varchar](40) NULL,
	[store_address] [varchar](40) NULL,
	[city] [varchar](20) NULL,
	[state] [char](2) NULL,
	[zip] [char](5) NULL,
 CONSTRAINT [UPK_storeid] PRIMARY KEY CLUSTERED 
(
	[store_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User]    Script Date: 5/22/2020 9:29:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[user_id] [int] IDENTITY(1,1) NOT NULL,
	[email_address] [varchar](100) NOT NULL,
	[password] [varchar](100) NOT NULL,
	[source] [varchar](100) NOT NULL,
	[first_name] [varchar](20) NULL,
	[middle_name] [char](1) NULL,
	[last_name] [varchar](30) NULL,
	[role_id] [smallint] NOT NULL,
	[pub_id] [int] NOT NULL,
	[hire_date] [datetime] NULL
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Author] ON 
GO
INSERT [dbo].[Author] ([author_id], [last_name], [first_name], [phone], [address], [city], [state], [zip], [email_address]) VALUES (1, N'Bennet', N'Abraham', N'415 658-9932', NULL, N'Berkeley', NULL, NULL, N'abraham.bennet@gmail.com')
GO
INSERT [dbo].[Author] ([author_id], [last_name], [first_name], [phone], [address], [city], [state], [zip], [email_address]) VALUES (2, N'Stringer', N'Dirk', N'415 843-2991', N'5420 Telegraph Av.', N'Oakland', N'CA', N'94609', N'dirk.stringer@gmail.com')
GO
INSERT [dbo].[Author] ([author_id], [last_name], [first_name], [phone], [address], [city], [state], [zip], [email_address]) VALUES (3, N'McBadden', N'Heather', N'707 448-4982', N'301 Putnam', N'Vacaville', N'CA', N'95688', N'heather.mcbadden@gmail.com')
GO
INSERT [dbo].[Author] ([author_id], [last_name], [first_name], [phone], [address], [city], [state], [zip], [email_address]) VALUES (4, N'del Castillo', N'Innes', N'615 996-8275', N'2286 Cram Pl. #86', N'Ann Arbor', N'MI', N'48105', N'innes.del castillo@gmail.com')
GO
INSERT [dbo].[Author] ([author_id], [last_name], [first_name], [phone], [address], [city], [state], [zip], [email_address]) VALUES (5, N'White', N'Johnson', N'408 496-7223', N'10932 Bigge Rd.', N'Menlo Park', N'CA', N'94025', N'johnson.white@gmail.com')
GO
INSERT [dbo].[Author] ([author_id], [last_name], [first_name], [phone], [address], [city], [state], [zip], [email_address]) VALUES (6, N'Karsen', N'Livia', N'415 534-9219', N'5720 McAuley St.', N'Oakland', N'CA', N'94609', N'livia.karsen@gmail.com')
GO
INSERT [dbo].[Author] ([author_id], [last_name], [first_name], [phone], [address], [city], [state], [zip], [email_address]) VALUES (7, N'Green', N'Marjorie', N'415 986-7020', N'309 63rd St. #411', N'Oakland', N'CA', N'94618', N'marjorie.green@gmail.com')
GO
INSERT [dbo].[Author] ([author_id], [last_name], [first_name], [phone], [address], [city], [state], [zip], [email_address]) VALUES (8, N'Smith', N'Meander', N'913 843-0462', N'10 Mississippi Dr.', N'Lawrence', N'KS', N'66044', N'meander.smith@gmail.com')
GO
INSERT [dbo].[Author] ([author_id], [last_name], [first_name], [phone], [address], [city], [state], [zip], [email_address]) VALUES (9, N'O''Leary', N'Michael', N'408 286-2428', N'22 Cleveland Av. #14', N'San Jose', N'CA', N'95128', N'michael.o''leary@gmail.com')
GO
INSERT [dbo].[Author] ([author_id], [last_name], [first_name], [phone], [address], [city], [state], [zip], [email_address]) VALUES (10, N'DeFrance', N'Michel', N'219 547-9982', N'3 Balding Pl.', N'Gary', N'IN', N'46403', N'michel.defrance@gmail.com')
GO
INSERT [dbo].[Author] ([author_id], [last_name], [first_name], [phone], [address], [city], [state], [zip], [email_address]) VALUES (11, N'Greene', N'Morningstar', N'615 297-2723', N'22 Graybar House Rd.', N'Nashville', N'TN', N'37215', N'morningstar.greene@gmail.com')
GO
INSERT [dbo].[Author] ([author_id], [last_name], [first_name], [phone], [address], [city], [state], [zip], [email_address]) VALUES (12, N'Yokomoto', N'Akiko', N'415 935-4228', N'3 Silver Ct.', N'Walnut Creek', N'CA', N'94595', N'akiko.yokomoto@gmail.com')
GO
INSERT [dbo].[Author] ([author_id], [last_name], [first_name], [phone], [address], [city], [state], [zip], [email_address]) VALUES (13, N'Blotchet-Halls', N'Reginald', N'503 745-6402', N'55 Hillsdale Bl.', N'Corvallis', N'OR', N'97330', N'reginald.blotchet-halls@gmail.com')
GO
INSERT [dbo].[Author] ([author_id], [last_name], [first_name], [phone], [address], [city], [state], [zip], [email_address]) VALUES (14, N'Hunter', N'Sheryl', N'415 836-7128', N'3410 Blonde St.', N'Palo Alto', N'CA', N'94301', N'sheryl.hunter@gmail.com')
GO
INSERT [dbo].[Author] ([author_id], [last_name], [first_name], [phone], [address], [city], [state], [zip], [email_address]) VALUES (15, N'MacFeather', N'Stearns', N'415 354-7128', N'44 Upland Hts.', N'Oakland', N'CA', N'94612', N'stearns.macfeather@gmail.com')
GO
INSERT [dbo].[Author] ([author_id], [last_name], [first_name], [phone], [address], [city], [state], [zip], [email_address]) VALUES (16, N'Panteley', N'Sylvia', N'301 946-8853', N'1956 Arlington Pl.', N'Rockville', N'MD', N'20853', N'sylvia.panteley@gmail.com')
GO
INSERT [dbo].[Author] ([author_id], [last_name], [first_name], [phone], [address], [city], [state], [zip], [email_address]) VALUES (17, N'Ringer', N'Albert', N'801 826-0752', N'67 Seventh Av.', N'Salt Lake City', N'UT', N'84152', N'albert.ringer@gmail.com')
GO
INSERT [dbo].[Author] ([author_id], [last_name], [first_name], [phone], [address], [city], [state], [zip], [email_address]) VALUES (18, N'Dull', N'Ann', N'415 836-7128', N'3410 Blonde St.', N'Palo Alto', N'CA', N'94301', N'ann.dull@gmail.com')
GO
INSERT [dbo].[Author] ([author_id], [last_name], [first_name], [phone], [address], [city], [state], [zip], [email_address]) VALUES (19, N'Ringer', N'Anne', N'801 826-0752', N'67 Seventh Av.', N'Salt Lake City', N'UT', N'84152', N'anne.ringer@gmail.com')
GO
INSERT [dbo].[Author] ([author_id], [last_name], [first_name], [phone], [address], [city], [state], [zip], [email_address]) VALUES (20, N'Gringlesby', N'Burt', N'707 938-6445', N'PO Box 792', N'Covelo', N'CA', N'95428', N'burt.gringlesby@gmail.com')
GO
INSERT [dbo].[Author] ([author_id], [last_name], [first_name], [phone], [address], [city], [state], [zip], [email_address]) VALUES (21, N'Locksley', N'Charlene', N'415 585-4620', N'18 Broadway Av.', N'San Francisco', N'CA', N'94130', N'charlene.locksley@gmail.com')
GO
INSERT [dbo].[Author] ([author_id], [last_name], [first_name], [phone], [address], [city], [state], [zip], [email_address]) VALUES (22, N'Carson', N'Cheryl', N'415 548-7723', N'589 Darwin Ln.', N'Berkeley', N'CA', N'94705', N'cheryl.carson@gmail.com')
GO
SET IDENTITY_INSERT [dbo].[Author] OFF
GO
SET IDENTITY_INSERT [dbo].[Book] ON 
GO
INSERT [dbo].[Book] ([book_id], [title], [type], [pub_id], [price], [advance], [royalty], [ytd_sales], [notes], [published_date]) VALUES (1, N'The Busy Executive''s Database Guide', N'business    ', 1, 19.9900, 5000.0000, 10, 4095, N'An overview of available database systems with emphasis on common business applications. Illustrated.', CAST(N'1991-06-12T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[Book] ([book_id], [title], [type], [pub_id], [price], [advance], [royalty], [ytd_sales], [notes], [published_date]) VALUES (2, N'Cooking with Computers: Surreptitious Balance Sheets', N'business    ', 1, 11.9500, 5000.0000, 10, 3876, N'Helpful hints on how to use your electronic resources to the best advantage.', CAST(N'1991-06-09T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[Book] ([book_id], [title], [type], [pub_id], [price], [advance], [royalty], [ytd_sales], [notes], [published_date]) VALUES (3, N'You Can Combat Computer Stress!', N'business    ', 2, 2.9900, 10125.0000, 24, 18722, N'The latest medical and psychological techniques for living with the electronic office. Easy-to-understand explanations.', CAST(N'1991-06-30T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[Book] ([book_id], [title], [type], [pub_id], [price], [advance], [royalty], [ytd_sales], [notes], [published_date]) VALUES (4, N'Straight Talk About Computers', N'business    ', 2, 19.9900, 5000.0000, 10, 4095, N'Annotated analysis of what computers can do for you: a no-hype guide for the critical user.', CAST(N'1991-06-22T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[Book] ([book_id], [title], [type], [pub_id], [price], [advance], [royalty], [ytd_sales], [notes], [published_date]) VALUES (5, N'Silicon Valley Gastronomic Treats', N'mod_cook    ', 2, 19.9900, 0.0000, 12, 2032, N'Favorite recipes for quick, easy, and elegant meals.', CAST(N'1991-06-09T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[Book] ([book_id], [title], [type], [pub_id], [price], [advance], [royalty], [ytd_sales], [notes], [published_date]) VALUES (6, N'The Gourmet Microwave', N'mod_cook    ', 2, 2.9900, 15000.0000, 24, 22246, N'Traditional French gourmet recipes adapted for modern microwave cooking.', CAST(N'1991-06-18T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[Book] ([book_id], [title], [type], [pub_id], [price], [advance], [royalty], [ytd_sales], [notes], [published_date]) VALUES (7, N'The Psychology of Computer Cooking', N'UNDECIDED   ', 3, NULL, NULL, NULL, NULL, NULL, CAST(N'2019-10-08T09:43:33.670' AS DateTime))
GO
INSERT [dbo].[Book] ([book_id], [title], [type], [pub_id], [price], [advance], [royalty], [ytd_sales], [notes], [published_date]) VALUES (8, N'But Is It User Friendly?', N'popular_comp', 4, 22.9500, 7000.0000, 16, 8780, N'A survey of software for the naive user, focusing on the ''friendliness'' of each.', CAST(N'1991-06-30T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[Book] ([book_id], [title], [type], [pub_id], [price], [advance], [royalty], [ytd_sales], [notes], [published_date]) VALUES (9, N'Secrets of Silicon Valley', N'popular_comp', 4, 20.0000, 8000.0000, 10, 4095, N'Muckraking reporting on the world''s largest computer hardware and software manufacturers.', CAST(N'1994-06-12T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[Book] ([book_id], [title], [type], [pub_id], [price], [advance], [royalty], [ytd_sales], [notes], [published_date]) VALUES (10, N'Net Etiquette', N'popular_comp', 4, NULL, NULL, NULL, NULL, N'A must-read for computer conferencing.', CAST(N'2019-10-08T09:43:33.670' AS DateTime))
GO
INSERT [dbo].[Book] ([book_id], [title], [type], [pub_id], [price], [advance], [royalty], [ytd_sales], [notes], [published_date]) VALUES (11, N'Computer Phobic AND Non-Phobic Individuals: Behavior Variations', N'psychology  ', 5, 21.5900, 7000.0000, 10, 375, N'A must for the specialist, this book examines the difference between those who hate and fear computers and those who don''t.', CAST(N'1991-10-21T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[Book] ([book_id], [title], [type], [pub_id], [price], [advance], [royalty], [ytd_sales], [notes], [published_date]) VALUES (12, N'Is Anger the Enemy?', N'psychology  ', 6, 10.9500, 2275.0000, 12, 2045, N'Carefully researched study of the effects of strong emotions on the body. Metabolic charts included.', CAST(N'1991-06-15T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[Book] ([book_id], [title], [type], [pub_id], [price], [advance], [royalty], [ytd_sales], [notes], [published_date]) VALUES (13, N'Life Without Fear', N'psychology  ', 7, 7.0000, 6000.0000, 10, 111, N'New exercise, meditation, and nutritional techniques that can reduce the shock of daily interactions. Popular audience. Sample menus included, exercise video available separately.', CAST(N'1991-10-05T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[Book] ([book_id], [title], [type], [pub_id], [price], [advance], [royalty], [ytd_sales], [notes], [published_date]) VALUES (14, N'Prolonged Data Deprivation: Four Case Studies', N'psychology  ', 7, 19.9900, 2000.0000, 10, 4072, N'What happens when the data runs dry?  Searching evaluations of information-shortage effects.', CAST(N'1991-06-12T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[Book] ([book_id], [title], [type], [pub_id], [price], [advance], [royalty], [ytd_sales], [notes], [published_date]) VALUES (15, N'Emotional Security: A New Algorithm', N'psychology  ', 7, 7.9900, 4000.0000, 10, 3336, N'Protecting yourself and your loved ones from undue emotional stress in the modern world. Use of computer and nutritional aids emphasized.', CAST(N'1991-06-12T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[Book] ([book_id], [title], [type], [pub_id], [price], [advance], [royalty], [ytd_sales], [notes], [published_date]) VALUES (16, N'Onions, Leeks, and Garlic: Cooking Secrets of the Mediterranean', N'trad_cook   ', 8, 20.9500, 7000.0000, 10, 375, N'Profusely illustrated in color, this makes a wonderful gift book for a cuisine-oriented friend.', CAST(N'1991-10-21T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[Book] ([book_id], [title], [type], [pub_id], [price], [advance], [royalty], [ytd_sales], [notes], [published_date]) VALUES (17, N'Fifty Years in Buckingham Palace Kitchens', N'trad_cook   ', 8, 11.9500, 4000.0000, 14, 15096, N'More anecdotes from the Queen''s favorite cook describing life among English royalty. Recipes, techniques, tender vignettes.', CAST(N'1991-06-12T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[Book] ([book_id], [title], [type], [pub_id], [price], [advance], [royalty], [ytd_sales], [notes], [published_date]) VALUES (18, N'Sushi, Anyone?', N'trad_cook   ', 8, 14.9900, 8000.0000, 10, 4095, N'Detailed instructions on how to make authentic Japanese sushi in your spare time.', CAST(N'1991-06-12T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[Book] ([book_id], [title], [type], [pub_id], [price], [advance], [royalty], [ytd_sales], [notes], [published_date]) VALUES (41, N'You Can Combat Computer Stress!', N'business    ', 40, 2.9900, 10125.0000, 24, 18722, N'The latest medical and psychological techniques for living with the electronic office. Easy-to-understand explanations.', CAST(N'1991-06-30T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[Book] ([book_id], [title], [type], [pub_id], [price], [advance], [royalty], [ytd_sales], [notes], [published_date]) VALUES (42, N'Straight Talk About Computers', N'business    ', 40, 19.9900, 5000.0000, 10, 4095, N'Annotated analysis of what computers can do for you: a no-hype guide for the critical user.', CAST(N'1991-06-22T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[Book] ([book_id], [title], [type], [pub_id], [price], [advance], [royalty], [ytd_sales], [notes], [published_date]) VALUES (43, N'Silicon Valley Gastronomic Treats', N'mod_cook    ', 40, 19.9900, 0.0000, 12, 2032, N'Favorite recipes for quick, easy, and elegant meals.', CAST(N'1991-06-09T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[Book] ([book_id], [title], [type], [pub_id], [price], [advance], [royalty], [ytd_sales], [notes], [published_date]) VALUES (44, N'The Gourmet Microwave', N'mod_cook    ', 40, 2.9900, 15000.0000, 24, 22246, N'Traditional French gourmet recipes adapted for modern microwave cooking.', CAST(N'1991-06-18T00:00:00.000' AS DateTime))
GO
SET IDENTITY_INSERT [dbo].[Book] OFF
GO
INSERT [dbo].[BookAuthor] ([author_id], [book_id], [author_order], [royality_percentage]) VALUES (1, 1, 1, NULL)
GO
INSERT [dbo].[BookAuthor] ([author_id], [book_id], [author_order], [royality_percentage]) VALUES (4, 5, 1, NULL)
GO
INSERT [dbo].[BookAuthor] ([author_id], [book_id], [author_order], [royality_percentage]) VALUES (5, 14, 1, NULL)
GO
INSERT [dbo].[BookAuthor] ([author_id], [book_id], [author_order], [royality_percentage]) VALUES (6, 11, 1, NULL)
GO
INSERT [dbo].[BookAuthor] ([author_id], [book_id], [author_order], [royality_percentage]) VALUES (7, 1, 2, NULL)
GO
INSERT [dbo].[BookAuthor] ([author_id], [book_id], [author_order], [royality_percentage]) VALUES (7, 3, 1, NULL)
GO
INSERT [dbo].[BookAuthor] ([author_id], [book_id], [author_order], [royality_percentage]) VALUES (9, 2, 2, NULL)
GO
INSERT [dbo].[BookAuthor] ([author_id], [book_id], [author_order], [royality_percentage]) VALUES (9, 18, 2, NULL)
GO
INSERT [dbo].[BookAuthor] ([author_id], [book_id], [author_order], [royality_percentage]) VALUES (10, 6, 1, NULL)
GO
INSERT [dbo].[BookAuthor] ([author_id], [book_id], [author_order], [royality_percentage]) VALUES (12, 18, 1, NULL)
GO
INSERT [dbo].[BookAuthor] ([author_id], [book_id], [author_order], [royality_percentage]) VALUES (13, 17, 1, NULL)
GO
INSERT [dbo].[BookAuthor] ([author_id], [book_id], [author_order], [royality_percentage]) VALUES (14, 9, 2, NULL)
GO
INSERT [dbo].[BookAuthor] ([author_id], [book_id], [author_order], [royality_percentage]) VALUES (15, 2, 1, NULL)
GO
INSERT [dbo].[BookAuthor] ([author_id], [book_id], [author_order], [royality_percentage]) VALUES (15, 11, 2, NULL)
GO
INSERT [dbo].[BookAuthor] ([author_id], [book_id], [author_order], [royality_percentage]) VALUES (16, 16, 1, NULL)
GO
INSERT [dbo].[BookAuthor] ([author_id], [book_id], [author_order], [royality_percentage]) VALUES (17, 12, 1, NULL)
GO
INSERT [dbo].[BookAuthor] ([author_id], [book_id], [author_order], [royality_percentage]) VALUES (17, 13, 1, NULL)
GO
INSERT [dbo].[BookAuthor] ([author_id], [book_id], [author_order], [royality_percentage]) VALUES (18, 9, 1, NULL)
GO
INSERT [dbo].[BookAuthor] ([author_id], [book_id], [author_order], [royality_percentage]) VALUES (19, 6, 2, NULL)
GO
INSERT [dbo].[BookAuthor] ([author_id], [book_id], [author_order], [royality_percentage]) VALUES (19, 12, 2, NULL)
GO
INSERT [dbo].[BookAuthor] ([author_id], [book_id], [author_order], [royality_percentage]) VALUES (20, 18, 3, NULL)
GO
INSERT [dbo].[BookAuthor] ([author_id], [book_id], [author_order], [royality_percentage]) VALUES (21, 10, 1, NULL)
GO
INSERT [dbo].[BookAuthor] ([author_id], [book_id], [author_order], [royality_percentage]) VALUES (21, 15, 1, NULL)
GO
INSERT [dbo].[BookAuthor] ([author_id], [book_id], [author_order], [royality_percentage]) VALUES (22, 8, 1, NULL)
GO
SET IDENTITY_INSERT [dbo].[Job] ON 
GO
INSERT [dbo].[Job] ([job_id], [job_desc]) VALUES (1, N'New Hire - Job not specified')
GO
INSERT [dbo].[Job] ([job_id], [job_desc]) VALUES (2, N'Chief Executive Officer')
GO
INSERT [dbo].[Job] ([job_id], [job_desc]) VALUES (3, N'Business Operations Manager')
GO
INSERT [dbo].[Job] ([job_id], [job_desc]) VALUES (4, N'Chief Financial Officier')
GO
INSERT [dbo].[Job] ([job_id], [job_desc]) VALUES (5, N'Publisher')
GO
INSERT [dbo].[Job] ([job_id], [job_desc]) VALUES (6, N'Managing Editor')
GO
INSERT [dbo].[Job] ([job_id], [job_desc]) VALUES (7, N'Marketing Manager')
GO
INSERT [dbo].[Job] ([job_id], [job_desc]) VALUES (8, N'Public Relations Manager')
GO
INSERT [dbo].[Job] ([job_id], [job_desc]) VALUES (9, N'Acquisitions Manager')
GO
INSERT [dbo].[Job] ([job_id], [job_desc]) VALUES (10, N'Productions Manager')
GO
INSERT [dbo].[Job] ([job_id], [job_desc]) VALUES (11, N'Operations Manager')
GO
INSERT [dbo].[Job] ([job_id], [job_desc]) VALUES (12, N'Editor')
GO
INSERT [dbo].[Job] ([job_id], [job_desc]) VALUES (13, N'Sales Representative')
GO
INSERT [dbo].[Job] ([job_id], [job_desc]) VALUES (14, N'Designer')
GO
SET IDENTITY_INSERT [dbo].[Job] OFF
GO
SET IDENTITY_INSERT [dbo].[Publisher] ON 
GO
INSERT [dbo].[Publisher] ([pub_id], [publisher_name], [city], [state], [country]) VALUES (1, N'New Moon Books', N'Boston', N'MA', N'USA')
GO
INSERT [dbo].[Publisher] ([pub_id], [publisher_name], [city], [state], [country]) VALUES (2, N'Binnet & Hardley', N'Washington', N'DC', N'USA')
GO
INSERT [dbo].[Publisher] ([pub_id], [publisher_name], [city], [state], [country]) VALUES (3, N'Algodata Infosystems', N'Berkeley', N'CA', N'USA')
GO
INSERT [dbo].[Publisher] ([pub_id], [publisher_name], [city], [state], [country]) VALUES (4, N'Five Lakes Publishing', N'Chicago', N'IL', N'USA')
GO
INSERT [dbo].[Publisher] ([pub_id], [publisher_name], [city], [state], [country]) VALUES (5, N'Ramona Publishers', N'Dallas', N'TX', N'USA')
GO
INSERT [dbo].[Publisher] ([pub_id], [publisher_name], [city], [state], [country]) VALUES (6, N'GGG&G', N'M?nchen', NULL, N'Germany')
GO
INSERT [dbo].[Publisher] ([pub_id], [publisher_name], [city], [state], [country]) VALUES (7, N'Scootney Books', N'New York', N'NY', N'USA')
GO
INSERT [dbo].[Publisher] ([pub_id], [publisher_name], [city], [state], [country]) VALUES (8, N'Lucerne Publishing', N'Paris', NULL, N'France')
GO
INSERT [dbo].[Publisher] ([pub_id], [publisher_name], [city], [state], [country]) VALUES (40, N'Binnet & Hardley - Test', N'Washington', N'DC', N'USA')
GO
SET IDENTITY_INSERT [dbo].[Publisher] OFF
GO
SET IDENTITY_INSERT [dbo].[RefreshToken] ON 
GO
INSERT [dbo].[RefreshToken] ([token_id], [user_id], [token], [expiry_date]) VALUES (1, 44, N'IKNELFYm0+Fsz9aK+vq5BftKRqZFEkxLf7RZ1qtbn7E=', CAST(N'2020-08-01T14:56:58.480' AS DateTime))
GO
INSERT [dbo].[RefreshToken] ([token_id], [user_id], [token], [expiry_date]) VALUES (2, 44, N'AsSHV3yHj+Jo2007Aa1sizw7XZsmXOGYi3Ir8dLi9xc=', CAST(N'2020-08-01T17:03:01.197' AS DateTime))
GO
INSERT [dbo].[RefreshToken] ([token_id], [user_id], [token], [expiry_date]) VALUES (3, 44, N'rQS6HSa0VhIaGjMPh7RnuygjJGqLCEVudjDhOPCv05M=', CAST(N'2020-08-01T17:13:17.863' AS DateTime))
GO
INSERT [dbo].[RefreshToken] ([token_id], [user_id], [token], [expiry_date]) VALUES (4, 44, N'bVmg2+b3aAlp7/BEkYwNJHNCb2Z6BHX9BBwcHhahshs=', CAST(N'2020-08-01T20:34:25.517' AS DateTime))
GO
INSERT [dbo].[RefreshToken] ([token_id], [user_id], [token], [expiry_date]) VALUES (5, 44, N'F3xHYQLqYdxjTv3jpjPRz1uNSMJ+tfT0kK1iZ715sxk=', CAST(N'2020-08-01T20:35:57.443' AS DateTime))
GO
INSERT [dbo].[RefreshToken] ([token_id], [user_id], [token], [expiry_date]) VALUES (6, 44, N'atFNFc3EecWsQxHaKS/4XhxvBkPC/36g/APOzbzyW/k=', CAST(N'2020-08-01T20:36:50.623' AS DateTime))
GO
INSERT [dbo].[RefreshToken] ([token_id], [user_id], [token], [expiry_date]) VALUES (7, 44, N'yfsZ/Dky//B2zZNWK3bWP8u8vHe+1iSvLJtmZK+HUtE=', CAST(N'2020-08-01T20:38:08.463' AS DateTime))
GO
INSERT [dbo].[RefreshToken] ([token_id], [user_id], [token], [expiry_date]) VALUES (8, 44, N'28IxDMmdk/RNhO8F12yb40TV4qOpUT3Z+Kc5cGYUINw=', CAST(N'2020-08-01T20:39:56.153' AS DateTime))
GO
INSERT [dbo].[RefreshToken] ([token_id], [user_id], [token], [expiry_date]) VALUES (9, 44, N'HiwkO/JEeEFsDFQo407i50npoVEFRImx/NP3aHFanps=', CAST(N'2020-08-01T20:49:46.363' AS DateTime))
GO
INSERT [dbo].[RefreshToken] ([token_id], [user_id], [token], [expiry_date]) VALUES (10, 44, N'G9igLN2exfdmYXR6P+Efjzx/7eglX7gppog/fm/wQd0=', CAST(N'2020-08-02T21:13:17.880' AS DateTime))
GO
INSERT [dbo].[RefreshToken] ([token_id], [user_id], [token], [expiry_date]) VALUES (11, 44, N'S391nKaorNmbmGKzCPT+CNUTx7ifzr8oT3RhlzNpZ1Y=', CAST(N'2020-08-02T21:22:44.653' AS DateTime))
GO
INSERT [dbo].[RefreshToken] ([token_id], [user_id], [token], [expiry_date]) VALUES (12, 44, N'633jjRj8MD3Xa4hyhT9bYfyMDJ99LwmlfFm2F3ffEVc=', CAST(N'2020-08-03T17:50:17.500' AS DateTime))
GO
INSERT [dbo].[RefreshToken] ([token_id], [user_id], [token], [expiry_date]) VALUES (13, 44, N'Ia5L/zg//GyHWk2O31oKXYSe8lFpvf0WdHGSoS4A8eA=', CAST(N'2020-08-03T18:09:02.530' AS DateTime))
GO
INSERT [dbo].[RefreshToken] ([token_id], [user_id], [token], [expiry_date]) VALUES (14, 44, N'EGLzkO7Qzf72hyMpbtjAqNIVR9AV5jYd9vudaYpGIHo=', CAST(N'2020-08-03T18:09:17.723' AS DateTime))
GO
INSERT [dbo].[RefreshToken] ([token_id], [user_id], [token], [expiry_date]) VALUES (15, 44, N'Y4I+e/uKfduzDL7mcHGrsFSOxD5gX+dMrFvLUiPhyOQ=', CAST(N'2020-08-03T20:24:39.950' AS DateTime))
GO
INSERT [dbo].[RefreshToken] ([token_id], [user_id], [token], [expiry_date]) VALUES (16, 44, N'KgKoCkdrBR+3iI/wye24zqDnxoSLNoRbqzDl32026pE=', CAST(N'2020-08-03T20:25:34.800' AS DateTime))
GO
INSERT [dbo].[RefreshToken] ([token_id], [user_id], [token], [expiry_date]) VALUES (17, 44, N'K9Gra3zezCTUppJ6LkuSeZxm8hIVKX9cQZfiqcYiqDc=', CAST(N'2020-08-03T20:29:28.760' AS DateTime))
GO
INSERT [dbo].[RefreshToken] ([token_id], [user_id], [token], [expiry_date]) VALUES (18, 44, N'Okq1RLz84vH9hsEMCmR3RcI/1zHSTl0fUtBsDgOrFM8=', CAST(N'2020-08-03T21:09:39.207' AS DateTime))
GO
INSERT [dbo].[RefreshToken] ([token_id], [user_id], [token], [expiry_date]) VALUES (19, 44, N'atJbdlwVS4O5EhJQgiyjJevl41E7ApAtqj8290ZrfOo=', CAST(N'2020-08-03T21:15:16.537' AS DateTime))
GO
INSERT [dbo].[RefreshToken] ([token_id], [user_id], [token], [expiry_date]) VALUES (20, 44, N'uWKxFdkFpSsZXRkX+3kJ9GPOD6ha+yJeBxJ8zVt87Dw=', CAST(N'2020-08-03T21:45:37.877' AS DateTime))
GO
INSERT [dbo].[RefreshToken] ([token_id], [user_id], [token], [expiry_date]) VALUES (21, 44, N'iLuVvX/di9tjM2AxS4YX02CJZAeVd9FPRobL9uzIFG4=', CAST(N'2020-08-03T21:46:12.010' AS DateTime))
GO
INSERT [dbo].[RefreshToken] ([token_id], [user_id], [token], [expiry_date]) VALUES (22, 44, N'uJQmi9zTCeV2DdWivep/QKYnxiKTE2yCN4oIx72mavo=', CAST(N'2020-08-03T21:47:13.663' AS DateTime))
GO
INSERT [dbo].[RefreshToken] ([token_id], [user_id], [token], [expiry_date]) VALUES (23, 44, N'/6sjSMT4w5bEPNzejKxKLVo7Mfw6uttFE7bGVg5GCJQ=', CAST(N'2020-08-03T21:47:57.470' AS DateTime))
GO
INSERT [dbo].[RefreshToken] ([token_id], [user_id], [token], [expiry_date]) VALUES (24, 44, N'wzK0Fa63mMvbIfAsIVxt/LaLRkhblzvhTbCuMuZU3dc=', CAST(N'2020-08-03T21:51:40.457' AS DateTime))
GO
INSERT [dbo].[RefreshToken] ([token_id], [user_id], [token], [expiry_date]) VALUES (27, 44, N'g8A3zspkGEdLxla02zLAPp9uEogZnRi1PCN6bHkZoSo=', CAST(N'2020-08-03T22:20:37.570' AS DateTime))
GO
INSERT [dbo].[RefreshToken] ([token_id], [user_id], [token], [expiry_date]) VALUES (38, 44, N'qpZYaNh3Cl5vN4vTH32ZtL0fdYVTqY8o9AzRUjMQlRg=', CAST(N'2020-08-04T20:07:32.577' AS DateTime))
GO
INSERT [dbo].[RefreshToken] ([token_id], [user_id], [token], [expiry_date]) VALUES (39, 44, N'ylq6rmOtTvnQn02HE33DNP33De0xOzXZPwDid02NVaA=', CAST(N'2020-08-04T20:08:31.803' AS DateTime))
GO
INSERT [dbo].[RefreshToken] ([token_id], [user_id], [token], [expiry_date]) VALUES (46, 44, N'Nuq04VbGmGvnNy8UvomLzHtnvJLb8Is6UpCNZ1JiOsk=', CAST(N'2020-08-05T19:11:51.903' AS DateTime))
GO
INSERT [dbo].[RefreshToken] ([token_id], [user_id], [token], [expiry_date]) VALUES (47, 44, N'eqFFatGg9llIKzBJCWGnjYJVzWKV7A5KSLC7RIa+jyY=', CAST(N'2020-08-05T21:16:51.227' AS DateTime))
GO
INSERT [dbo].[RefreshToken] ([token_id], [user_id], [token], [expiry_date]) VALUES (48, 44, N'EPUVq3Lu7a8R33G3Iuxa9MXVX+UVCKPuRRDeMBwVFik=', CAST(N'2020-08-05T21:34:07.493' AS DateTime))
GO
INSERT [dbo].[RefreshToken] ([token_id], [user_id], [token], [expiry_date]) VALUES (49, 44, N'XOPbFEy0ewHJWLPDBQj/yCKpekjDOGbg2scHnU7zjdM=', CAST(N'2020-08-05T21:36:37.397' AS DateTime))
GO
INSERT [dbo].[RefreshToken] ([token_id], [user_id], [token], [expiry_date]) VALUES (50, 44, N'ZXtcWEDbFo1HnemOUamXurHOXMGd3i5kD09zNkXhZT4=', CAST(N'2020-08-05T21:36:51.007' AS DateTime))
GO
INSERT [dbo].[RefreshToken] ([token_id], [user_id], [token], [expiry_date]) VALUES (51, 44, N'leezk+drF5OcmnY30MQ82sEh92UVyVX0+PVBxr7LaU0=', CAST(N'2020-08-05T21:39:23.913' AS DateTime))
GO
INSERT [dbo].[RefreshToken] ([token_id], [user_id], [token], [expiry_date]) VALUES (52, 44, N'EosJklV2GgqYaU4xHMh8Cb/bsO3zB148SuaBhuauckE=', CAST(N'2020-08-05T21:41:21.320' AS DateTime))
GO
INSERT [dbo].[RefreshToken] ([token_id], [user_id], [token], [expiry_date]) VALUES (53, 44, N'W/g9u9xwSfz68bGU+tB9G67/yfJaeT8kGbB4pcYl7Lo=', CAST(N'2020-08-05T21:41:29.883' AS DateTime))
GO
INSERT [dbo].[RefreshToken] ([token_id], [user_id], [token], [expiry_date]) VALUES (54, 44, N'nV+/PpKBGkWl4QydHTlnIcEL0sDLyfUOzG0UFqcUgF8=', CAST(N'2020-08-05T21:46:39.610' AS DateTime))
GO
INSERT [dbo].[RefreshToken] ([token_id], [user_id], [token], [expiry_date]) VALUES (55, 44, N'76vdJOSuCEcqltYMhzCPkLFmwy8Zu+S3/6m0TBuz9vI=', CAST(N'2020-08-05T21:48:12.223' AS DateTime))
GO
INSERT [dbo].[RefreshToken] ([token_id], [user_id], [token], [expiry_date]) VALUES (56, 44, N'4eqbyZfmvFcwHxWN28z2jb+oEHpxDvlZhbgQ6kraRK4=', CAST(N'2020-08-05T21:50:30.313' AS DateTime))
GO
INSERT [dbo].[RefreshToken] ([token_id], [user_id], [token], [expiry_date]) VALUES (58, 44, N'EYy87lChfq8XuefExKgFaM4+Xc9sFKgVQexTqilKTYI=', CAST(N'2020-08-05T21:55:07.563' AS DateTime))
GO
INSERT [dbo].[RefreshToken] ([token_id], [user_id], [token], [expiry_date]) VALUES (60, 44, N'E1kj8hiU0+zHXenLyn1lWyqWWYeQsRCW6Yvl4m8vgPA=', CAST(N'2020-08-07T13:14:07.467' AS DateTime))
GO
INSERT [dbo].[RefreshToken] ([token_id], [user_id], [token], [expiry_date]) VALUES (61, 44, N'C4xf7EYxlxHfnM+cbWEbTBu+ZPmu0G1i3TnttdDzaZE=', CAST(N'2020-08-07T13:16:59.540' AS DateTime))
GO
INSERT [dbo].[RefreshToken] ([token_id], [user_id], [token], [expiry_date]) VALUES (62, 44, N'aGkq4FKz73dgSd6pjkAk75GceGA41CTwo74hocU2Z8M=', CAST(N'2020-08-07T13:21:22.960' AS DateTime))
GO
INSERT [dbo].[RefreshToken] ([token_id], [user_id], [token], [expiry_date]) VALUES (63, 44, N'POER3BZcduKVaDMv8EFHy3nt84BnErjb0e4IE5XdIyM=', CAST(N'2020-08-07T13:23:01.790' AS DateTime))
GO
INSERT [dbo].[RefreshToken] ([token_id], [user_id], [token], [expiry_date]) VALUES (64, 44, N'597TxztgHKfG2oCwYglJoalF+5YS05sK4lTsIDqDEgQ=', CAST(N'2020-08-07T13:23:39.050' AS DateTime))
GO
INSERT [dbo].[RefreshToken] ([token_id], [user_id], [token], [expiry_date]) VALUES (65, 44, N'dUSbJRloBXPEbaA7xii2jUbL6Q4nOiZEDJ1MnLQb5F4=', CAST(N'2020-08-07T13:27:07.133' AS DateTime))
GO
INSERT [dbo].[RefreshToken] ([token_id], [user_id], [token], [expiry_date]) VALUES (66, 7, N'KFHZlQ05b6Hl8wSquKDTHYZTBSQ8QJPru18CENJ75Ek=', CAST(N'2020-08-07T13:56:09.517' AS DateTime))
GO
INSERT [dbo].[RefreshToken] ([token_id], [user_id], [token], [expiry_date]) VALUES (67, 44, N'XIlwEGO5mbah1d9hRpR3jZWmG38C5CUtC5yCC1Zcyvc=', CAST(N'2020-08-07T13:56:18.667' AS DateTime))
GO
INSERT [dbo].[RefreshToken] ([token_id], [user_id], [token], [expiry_date]) VALUES (68, 44, N'AAdQtm5TDNRwwVn9lS6M3z6SJzn+u2GGtxHKMefc/vU=', CAST(N'2020-08-07T13:58:11.623' AS DateTime))
GO
INSERT [dbo].[RefreshToken] ([token_id], [user_id], [token], [expiry_date]) VALUES (69, 7, N'hVRPAj1k2kHzmwwGmKkwuM9Y6dnEqOhde+oIMKBB7OI=', CAST(N'2020-08-07T13:58:23.343' AS DateTime))
GO
INSERT [dbo].[RefreshToken] ([token_id], [user_id], [token], [expiry_date]) VALUES (70, 44, N'HpT0ZdqapDc0xpsq9+JKXxJ2UIIRjW1q0QeN77Dx28A=', CAST(N'2020-08-07T14:02:45.060' AS DateTime))
GO
INSERT [dbo].[RefreshToken] ([token_id], [user_id], [token], [expiry_date]) VALUES (71, 7, N'I3SkDL6e24IZ7twoVJZ4+hQijuhc6LniNoRLZ3dr2ts=', CAST(N'2020-08-07T14:13:26.730' AS DateTime))
GO
INSERT [dbo].[RefreshToken] ([token_id], [user_id], [token], [expiry_date]) VALUES (72, 44, N'bAQWdHBONRhTXRD4xnfA2w5E6UK+24t8ifsoaD4sK9E=', CAST(N'2020-08-07T14:29:52.223' AS DateTime))
GO
INSERT [dbo].[RefreshToken] ([token_id], [user_id], [token], [expiry_date]) VALUES (73, 7, N'HEREZTf0nVIA+vkyLhCZjXm1OpEQ4jrT/FLBj55L7+4=', CAST(N'2020-08-07T14:30:05.330' AS DateTime))
GO
INSERT [dbo].[RefreshToken] ([token_id], [user_id], [token], [expiry_date]) VALUES (74, 44, N'7Si4x36QCI3V1w+LZCR61lX67PdovkLAa0aVJHzpwnc=', CAST(N'2020-08-07T14:36:40.253' AS DateTime))
GO
INSERT [dbo].[RefreshToken] ([token_id], [user_id], [token], [expiry_date]) VALUES (75, 7, N'xEd3KnaEwZJvdr0Hgwbt9ggo15lioa15wBumQppdCmg=', CAST(N'2020-08-07T14:36:53.507' AS DateTime))
GO
INSERT [dbo].[RefreshToken] ([token_id], [user_id], [token], [expiry_date]) VALUES (76, 44, N'4yWPEjDJ9F+qu8SVKptUYTweQQj2hek7V9BFsja3RVY=', CAST(N'2020-08-07T14:41:15.977' AS DateTime))
GO
INSERT [dbo].[RefreshToken] ([token_id], [user_id], [token], [expiry_date]) VALUES (77, 44, N'3axmN4vmVjojhLtFswnptbO/y7cNryqpbbEnjz/8eGY=', CAST(N'2020-08-07T14:43:24.977' AS DateTime))
GO
INSERT [dbo].[RefreshToken] ([token_id], [user_id], [token], [expiry_date]) VALUES (78, 7, N'aOPNoL8jYHeaLJHzmu2Baysx82G1grUakRnuig+Vr+s=', CAST(N'2020-08-07T14:43:36.637' AS DateTime))
GO
INSERT [dbo].[RefreshToken] ([token_id], [user_id], [token], [expiry_date]) VALUES (79, 44, N'Jdl/TPNCNJVM+yJNYD25/Hdok7jmbYG7Dx2S8lowu9c=', CAST(N'2020-08-07T15:50:07.583' AS DateTime))
GO
INSERT [dbo].[RefreshToken] ([token_id], [user_id], [token], [expiry_date]) VALUES (80, 7, N'+1cl/ECOqyKx4becLCCFtWEyYHbabXW92wwclpbpTgI=', CAST(N'2020-08-07T16:27:10.397' AS DateTime))
GO
INSERT [dbo].[RefreshToken] ([token_id], [user_id], [token], [expiry_date]) VALUES (81, 44, N'2czprFhUXlLGNWn2ul8Tlh/zbtHVDz98O+mNuPqlmk0=', CAST(N'2020-08-07T16:45:39.093' AS DateTime))
GO
INSERT [dbo].[RefreshToken] ([token_id], [user_id], [token], [expiry_date]) VALUES (82, 7, N'LGfSe0S1gU+BBcZxPGpztlBL9kPWDyfqMedjfiMmBZE=', CAST(N'2020-08-07T16:45:45.563' AS DateTime))
GO
INSERT [dbo].[RefreshToken] ([token_id], [user_id], [token], [expiry_date]) VALUES (83, 44, N'LzVVJ+UjoGRl5xAUaL5p3frnP9NDu1I3SoPVm+Rrudk=', CAST(N'2020-08-07T16:46:23.260' AS DateTime))
GO
INSERT [dbo].[RefreshToken] ([token_id], [user_id], [token], [expiry_date]) VALUES (84, 7, N'U8d/3cW3Fwzsp88332qmIMGMOQpuYdJ8EHmTnWozUmc=', CAST(N'2020-08-07T16:50:12.863' AS DateTime))
GO
INSERT [dbo].[RefreshToken] ([token_id], [user_id], [token], [expiry_date]) VALUES (85, 44, N'dGDhogck4tqIK9/E+5GBsWU226xCxBZYEhz2RirgLkc=', CAST(N'2020-08-07T16:50:19.660' AS DateTime))
GO
INSERT [dbo].[RefreshToken] ([token_id], [user_id], [token], [expiry_date]) VALUES (86, 7, N'xsFQH9YMd+WCB5L670HC7iDygnzHCaczt+GyZthu8YQ=', CAST(N'2020-08-07T16:50:25.617' AS DateTime))
GO
INSERT [dbo].[RefreshToken] ([token_id], [user_id], [token], [expiry_date]) VALUES (87, 44, N'JL4lG71Nx5F8kv32kabMfVsjvDDpsbRsjPMzP/gl0bA=', CAST(N'2020-08-07T16:50:55.187' AS DateTime))
GO
INSERT [dbo].[RefreshToken] ([token_id], [user_id], [token], [expiry_date]) VALUES (88, 7, N'7IfzXqQ3z2/akKUVw1v+SXWLMpXHJUozWzNK71YUXHM=', CAST(N'2020-08-07T16:52:29.600' AS DateTime))
GO
INSERT [dbo].[RefreshToken] ([token_id], [user_id], [token], [expiry_date]) VALUES (89, 44, N'jO/fUe0KV5JgjEkAbX9mqB3ngXBpZcebmT18ZdbB8ag=', CAST(N'2020-08-07T16:53:00.630' AS DateTime))
GO
INSERT [dbo].[RefreshToken] ([token_id], [user_id], [token], [expiry_date]) VALUES (90, 7, N'm2zWoW5RP/gJZiI1zEVp19rpSV9XJ3/RgFw6fhd/WPs=', CAST(N'2020-08-07T16:53:50.353' AS DateTime))
GO
INSERT [dbo].[RefreshToken] ([token_id], [user_id], [token], [expiry_date]) VALUES (91, 44, N'kDyCQ9Ve9CApsFgrrSpnKqme6URLVBEVmmLneUE1D4g=', CAST(N'2020-08-07T16:55:45.507' AS DateTime))
GO
INSERT [dbo].[RefreshToken] ([token_id], [user_id], [token], [expiry_date]) VALUES (92, 44, N'XTZtBcpW1M8PeMwsYtzy/zSCH783BJWEV2k8POy9XI0=', CAST(N'2020-08-07T17:10:47.700' AS DateTime))
GO
INSERT [dbo].[RefreshToken] ([token_id], [user_id], [token], [expiry_date]) VALUES (93, 44, N'XrZQ3HGHTUiZ1Dyter2NTXOMqgLcN8BavNUoVfZBdas=', CAST(N'2020-08-07T17:18:53.510' AS DateTime))
GO
INSERT [dbo].[RefreshToken] ([token_id], [user_id], [token], [expiry_date]) VALUES (94, 44, N'wL9I3hz/OD6TVKpPScM81Z35MEM1IYj7l8EB1Pk+qyA=', CAST(N'2020-08-07T17:24:09.780' AS DateTime))
GO
INSERT [dbo].[RefreshToken] ([token_id], [user_id], [token], [expiry_date]) VALUES (95, 44, N'4tZSTsIFBclmLieMRq4HUruKiqsE1ec82pq9ddZeOgE=', CAST(N'2020-08-07T17:38:44.047' AS DateTime))
GO
INSERT [dbo].[RefreshToken] ([token_id], [user_id], [token], [expiry_date]) VALUES (96, 7, N'P1hobEvedcsEAPy/iB5ipg1CovJv+4R927qqAY/czCM=', CAST(N'2020-08-07T17:38:53.093' AS DateTime))
GO
INSERT [dbo].[RefreshToken] ([token_id], [user_id], [token], [expiry_date]) VALUES (97, 44, N'Q1OTBSVHIFM11KJZZnpMc1gP5dWTJ5A2HJj6/yhM4FU=', CAST(N'2020-08-07T17:40:45.660' AS DateTime))
GO
INSERT [dbo].[RefreshToken] ([token_id], [user_id], [token], [expiry_date]) VALUES (98, 7, N'9I6iDVqirbrz0+IHU59mZulwf5aodewdy3Ym6LvZZS4=', CAST(N'2020-08-07T17:42:11.617' AS DateTime))
GO
INSERT [dbo].[RefreshToken] ([token_id], [user_id], [token], [expiry_date]) VALUES (99, 7, N'ycNGnAVJ4aVuKLu15GQtBefWMvcfz/Auvw5ePPhZhyk=', CAST(N'2020-08-09T16:33:43.427' AS DateTime))
GO
INSERT [dbo].[RefreshToken] ([token_id], [user_id], [token], [expiry_date]) VALUES (100, 44, N'DJvdaGAMghzGN9ZeGSISBNDP/Sflg6kKuyxtFYw2BV0=', CAST(N'2020-08-09T16:33:52.547' AS DateTime))
GO
INSERT [dbo].[RefreshToken] ([token_id], [user_id], [token], [expiry_date]) VALUES (101, 7, N'NKoDcTEFvnAHx7fbJPPGiY9svYmJpnZbkYiWqDWL3sI=', CAST(N'2020-08-09T16:37:34.327' AS DateTime))
GO
INSERT [dbo].[RefreshToken] ([token_id], [user_id], [token], [expiry_date]) VALUES (102, 44, N'ReEMsdwIH49B+WV2F8Dh6+yg6qnZreiRV+k7iz6q7AQ=', CAST(N'2020-08-09T16:38:31.430' AS DateTime))
GO
INSERT [dbo].[RefreshToken] ([token_id], [user_id], [token], [expiry_date]) VALUES (103, 44, N'm5aR5iT/xuMM2Nz1xG8OmipCjWKTc6WgoWofqnmfsBM=', CAST(N'2020-08-09T17:07:59.380' AS DateTime))
GO
INSERT [dbo].[RefreshToken] ([token_id], [user_id], [token], [expiry_date]) VALUES (104, 44, N'd10HbGGx/M5+7HkJ0+2spnzJM8Mir3Xe33omdRi9dWQ=', CAST(N'2020-08-09T17:14:00.963' AS DateTime))
GO
INSERT [dbo].[RefreshToken] ([token_id], [user_id], [token], [expiry_date]) VALUES (105, 44, N'+CsZf1ilu14mvx/SEw/UnrWSdMKlFMhIBcdis+Gm3gc=', CAST(N'2020-08-09T17:17:13.730' AS DateTime))
GO
INSERT [dbo].[RefreshToken] ([token_id], [user_id], [token], [expiry_date]) VALUES (106, 44, N'dy1+e7kGyitGlI9C8xu+l2MTLOwi1a2p0dioqX4rfsU=', CAST(N'2020-08-09T17:22:57.997' AS DateTime))
GO
INSERT [dbo].[RefreshToken] ([token_id], [user_id], [token], [expiry_date]) VALUES (107, 44, N'O7cN1uWxqwy8dp0eMTiGRgPgf+mKFzuRwq56TJRP8QE=', CAST(N'2020-08-09T17:23:26.907' AS DateTime))
GO
INSERT [dbo].[RefreshToken] ([token_id], [user_id], [token], [expiry_date]) VALUES (108, 7, N'WS3Ep6mXLW7B7sTfvyV1E35sUIzRuF5Qfah4ZDiHfcw=', CAST(N'2020-08-10T12:13:51.787' AS DateTime))
GO
INSERT [dbo].[RefreshToken] ([token_id], [user_id], [token], [expiry_date]) VALUES (109, 44, N'EzV+4wdUlW+pRhaC1LcEQdaVEtZKdWT9x2Zq3cL/0/E=', CAST(N'2020-08-10T12:18:25.223' AS DateTime))
GO
INSERT [dbo].[RefreshToken] ([token_id], [user_id], [token], [expiry_date]) VALUES (110, 44, N'8zuS8Zs4Ib3ZEeevn2FoC21tdG86jz7IYxX4Zn4GxH8=', CAST(N'2020-08-10T12:19:53.117' AS DateTime))
GO
INSERT [dbo].[RefreshToken] ([token_id], [user_id], [token], [expiry_date]) VALUES (111, 44, N'hltV4n9Rd9sNkuhmf4L9tep0m7pAan1d25yoIR2THSo=', CAST(N'2020-08-10T12:27:34.993' AS DateTime))
GO
INSERT [dbo].[RefreshToken] ([token_id], [user_id], [token], [expiry_date]) VALUES (112, 4, N'a+1NFvCljuxIy18Ugy5TmHGUCcov1+pmwSq74o0r0uY=', CAST(N'2020-08-10T12:28:04.930' AS DateTime))
GO
INSERT [dbo].[RefreshToken] ([token_id], [user_id], [token], [expiry_date]) VALUES (113, 5, N'iRlbyzWhCKROx0U2fqE/Xjjb1Cf24M/D2KhfzLOdHRs=', CAST(N'2020-08-10T12:34:43.240' AS DateTime))
GO
INSERT [dbo].[RefreshToken] ([token_id], [user_id], [token], [expiry_date]) VALUES (114, 4, N'AVmh78f6Kgbh4TpLWYJbdfOTFoHMl/4IV3fnzzfgzGc=', CAST(N'2020-08-10T12:44:07.240' AS DateTime))
GO
INSERT [dbo].[RefreshToken] ([token_id], [user_id], [token], [expiry_date]) VALUES (115, 44, N'3gGsqwaEZ8Yizn3NHdmZfVHkfEj9oGV2ZCMH+g5+Vqc=', CAST(N'2020-08-10T12:47:12.097' AS DateTime))
GO
INSERT [dbo].[RefreshToken] ([token_id], [user_id], [token], [expiry_date]) VALUES (116, 44, N'Ayod7L4btX32SvP05Kd3TllS8TjMXrYsv4gE9hym10g=', CAST(N'2020-08-10T12:47:19.370' AS DateTime))
GO
INSERT [dbo].[RefreshToken] ([token_id], [user_id], [token], [expiry_date]) VALUES (117, 44, N'pUd4yasMeNnMXfllbIgixLEAr7M9ikVqtVBqbzdh7fk=', CAST(N'2020-08-10T12:51:50.100' AS DateTime))
GO
INSERT [dbo].[RefreshToken] ([token_id], [user_id], [token], [expiry_date]) VALUES (118, 7, N'kUcTRLsMN4coJ6HUDiQeFNLMPElkPjI3zARKu77BWVc=', CAST(N'2020-08-10T12:58:23.270' AS DateTime))
GO
INSERT [dbo].[RefreshToken] ([token_id], [user_id], [token], [expiry_date]) VALUES (119, 7, N'ZfsdVmi2dk0p8+m4iW5oXM2ih2tWnumL5xJ1QO6LAIw=', CAST(N'2020-08-10T13:00:33.770' AS DateTime))
GO
INSERT [dbo].[RefreshToken] ([token_id], [user_id], [token], [expiry_date]) VALUES (120, 44, N'qmIJliu4k+l+W3AkQip5MUbqn9RmT+u9KFIkM4XEUiU=', CAST(N'2020-08-10T13:00:42.013' AS DateTime))
GO
INSERT [dbo].[RefreshToken] ([token_id], [user_id], [token], [expiry_date]) VALUES (121, 7, N'I+CBviqUx4hFTteJjlmKbnUinWJ5c+vvWvNN2M7DBeE=', CAST(N'2020-08-10T13:02:33.443' AS DateTime))
GO
INSERT [dbo].[RefreshToken] ([token_id], [user_id], [token], [expiry_date]) VALUES (122, 44, N'2Ipc8qY8QsWF2Xpvwj8QE746JwIrJPWYzLNoEWv/2Io=', CAST(N'2020-08-10T13:02:40.467' AS DateTime))
GO
INSERT [dbo].[RefreshToken] ([token_id], [user_id], [token], [expiry_date]) VALUES (123, 7, N'n/3RQrrdefHGaJMmvMuw5yHQ8Mz8kICg/kTlbSOGHFk=', CAST(N'2020-08-10T13:13:01.197' AS DateTime))
GO
INSERT [dbo].[RefreshToken] ([token_id], [user_id], [token], [expiry_date]) VALUES (124, 7, N'AM6b8hVnmWKUKVz5yu8KQQpmyDH04uZL4LIs8YUhSeE=', CAST(N'2020-08-10T17:58:32.323' AS DateTime))
GO
INSERT [dbo].[RefreshToken] ([token_id], [user_id], [token], [expiry_date]) VALUES (125, 44, N'zBHd7j9VHsv/bssswhB2OO3ZHX9vCQ2UUHZd4vG/N88=', CAST(N'2020-08-10T17:59:03.337' AS DateTime))
GO
INSERT [dbo].[RefreshToken] ([token_id], [user_id], [token], [expiry_date]) VALUES (126, 12, N'4t9Kdbnfn3HVIadxKdCuZCuUbkvuS87dt3YF8IBi6HU=', CAST(N'2020-08-10T17:59:48.660' AS DateTime))
GO
INSERT [dbo].[RefreshToken] ([token_id], [user_id], [token], [expiry_date]) VALUES (127, 44, N'AIb/rTQmPcQwIaQiM8x8XdMRc7VogS8L1JW1qgEXaYQ=', CAST(N'2020-08-10T18:01:55.527' AS DateTime))
GO
INSERT [dbo].[RefreshToken] ([token_id], [user_id], [token], [expiry_date]) VALUES (128, 7, N'K9f4TaI4PmqFIzt4uGneuknroEQfz94s/NE3CCUqqjU=', CAST(N'2020-08-10T18:02:15.310' AS DateTime))
GO
INSERT [dbo].[RefreshToken] ([token_id], [user_id], [token], [expiry_date]) VALUES (129, 44, N'r+7HOw27uL6JSmCKmfXMwtzPFB4wvcbGph76q1hua+k=', CAST(N'2020-08-10T18:04:26.097' AS DateTime))
GO
INSERT [dbo].[RefreshToken] ([token_id], [user_id], [token], [expiry_date]) VALUES (130, 7, N'd7PrlBiK2FlIUUsdWOVmAIZOfR0Najl9Z5nXtX5g4fg=', CAST(N'2020-08-10T18:05:03.357' AS DateTime))
GO
INSERT [dbo].[RefreshToken] ([token_id], [user_id], [token], [expiry_date]) VALUES (131, 12, N'IXsypXgIshjdkN52bvZm0r8Lar3dTfCnZHyRwx1JgfU=', CAST(N'2020-08-10T18:05:37.833' AS DateTime))
GO
INSERT [dbo].[RefreshToken] ([token_id], [user_id], [token], [expiry_date]) VALUES (132, 44, N'I/VnfOMI8sgUF/3atZChH7AeJV9E21lqK5mG1nvPVPw=', CAST(N'2020-08-10T18:07:31.223' AS DateTime))
GO
INSERT [dbo].[RefreshToken] ([token_id], [user_id], [token], [expiry_date]) VALUES (133, 12, N'kjjwGFD/S6gAmJ0M7h1cgHwhXc7z9F87bm7+CI4Q/hw=', CAST(N'2020-08-10T18:07:44.177' AS DateTime))
GO
INSERT [dbo].[RefreshToken] ([token_id], [user_id], [token], [expiry_date]) VALUES (134, 7, N'9sG9X7IvJQg+0EQLPFfE++Fa+CiiiDJUn93h0K2Yco4=', CAST(N'2020-08-10T18:20:23.793' AS DateTime))
GO
INSERT [dbo].[RefreshToken] ([token_id], [user_id], [token], [expiry_date]) VALUES (135, 12, N'W3Cmhtc4FPF05oc3MqsP/di7Jc5qYrMU3FQWBRpN534=', CAST(N'2020-08-10T18:20:28.907' AS DateTime))
GO
INSERT [dbo].[RefreshToken] ([token_id], [user_id], [token], [expiry_date]) VALUES (136, 12, N'GeBLa0lLXZ+tQ2/C2TBi5j9dl91eViMLFzygMe5lGG0=', CAST(N'2020-08-10T18:25:50.877' AS DateTime))
GO
INSERT [dbo].[RefreshToken] ([token_id], [user_id], [token], [expiry_date]) VALUES (137, 7, N'z39yycjCdowg5bjZGeXNoTpx4n2Y43dt1Z8O8NVKuzg=', CAST(N'2020-08-10T18:25:59.723' AS DateTime))
GO
INSERT [dbo].[RefreshToken] ([token_id], [user_id], [token], [expiry_date]) VALUES (138, 12, N'ImLBzfkYpclBPBZP894+MOTQXR/TZkkf/y5J9K42p8k=', CAST(N'2020-08-10T18:26:23.993' AS DateTime))
GO
INSERT [dbo].[RefreshToken] ([token_id], [user_id], [token], [expiry_date]) VALUES (139, 7, N'RBSRmTFuvaYFyDpnWY2yo9E7uQe60BuWHlBNslDsT9M=', CAST(N'2020-08-10T18:26:35.093' AS DateTime))
GO
INSERT [dbo].[RefreshToken] ([token_id], [user_id], [token], [expiry_date]) VALUES (140, 7, N'nrrD50fW+KpJWcqrBvR/gfOsveEhZpGJ8XDZ/KW3s+U=', CAST(N'2020-08-10T18:37:42.113' AS DateTime))
GO
INSERT [dbo].[RefreshToken] ([token_id], [user_id], [token], [expiry_date]) VALUES (141, 12, N'5MXOcmm5iaWYKyaQXZowSkLZAQ/d+sKALwZKFDT60b4=', CAST(N'2020-08-10T18:37:49.430' AS DateTime))
GO
INSERT [dbo].[RefreshToken] ([token_id], [user_id], [token], [expiry_date]) VALUES (142, 12, N'EOsUGQ1h7cPRQ5peBRXqljLxsPNyDR9PVVZQKRbRQD0=', CAST(N'2020-08-10T18:41:23.937' AS DateTime))
GO
INSERT [dbo].[RefreshToken] ([token_id], [user_id], [token], [expiry_date]) VALUES (143, 7, N'igIelwiotjYvnS4ymCDX49LCxhhRRlJSoEoDo6INK/0=', CAST(N'2020-08-10T18:41:29.893' AS DateTime))
GO
INSERT [dbo].[RefreshToken] ([token_id], [user_id], [token], [expiry_date]) VALUES (144, 12, N'j7MzZt+pFrnDltjdsAvAK/Sw1InXI5D9HfEgEi7K5xk=', CAST(N'2020-08-10T18:41:59.523' AS DateTime))
GO
INSERT [dbo].[RefreshToken] ([token_id], [user_id], [token], [expiry_date]) VALUES (145, 12, N'DwyXMpUjtQLtgTkEKrRKeNoUa7+i68/HecTfI2gya4c=', CAST(N'2020-08-10T18:47:53.527' AS DateTime))
GO
INSERT [dbo].[RefreshToken] ([token_id], [user_id], [token], [expiry_date]) VALUES (146, 7, N'b/fllAtpbUkGjGpvIuqSfGQnWCwwf/ULeLjTPjb/v5w=', CAST(N'2020-08-10T18:48:05.207' AS DateTime))
GO
INSERT [dbo].[RefreshToken] ([token_id], [user_id], [token], [expiry_date]) VALUES (147, 12, N'n8ukEGqZ0T8U8eqlVqpV709ckrbpyZMFmu+O4gbsiJY=', CAST(N'2020-08-10T18:48:29.340' AS DateTime))
GO
INSERT [dbo].[RefreshToken] ([token_id], [user_id], [token], [expiry_date]) VALUES (148, 12, N'Qkfl5D0yC2BN9ujOMSQzcM+DYq9Yr+I+P3dK8iSQnE8=', CAST(N'2020-08-10T18:49:11.973' AS DateTime))
GO
INSERT [dbo].[RefreshToken] ([token_id], [user_id], [token], [expiry_date]) VALUES (149, 7, N'FVamv689iv7opj5qrtamLII/2kDfBHsqKmjbAHPN7gE=', CAST(N'2020-08-10T18:49:25.590' AS DateTime))
GO
INSERT [dbo].[RefreshToken] ([token_id], [user_id], [token], [expiry_date]) VALUES (150, 7, N'tTg8vLGzAwGugHXwppVc7vk79Ru/BYYjPnrB2BrVvgc=', CAST(N'2020-08-12T12:20:30.350' AS DateTime))
GO
INSERT [dbo].[RefreshToken] ([token_id], [user_id], [token], [expiry_date]) VALUES (151, 44, N'L7WxDoKbEqYsV2BgEVlqU4o01qS203eBtwzGEZBIYxU=', CAST(N'2020-08-12T12:20:41.167' AS DateTime))
GO
INSERT [dbo].[RefreshToken] ([token_id], [user_id], [token], [expiry_date]) VALUES (152, 7, N'3EY69SX3pSKxGKhDkfvWiiqfD9SSH3qXHamxRAz8j2U=', CAST(N'2020-08-12T12:20:50.980' AS DateTime))
GO
INSERT [dbo].[RefreshToken] ([token_id], [user_id], [token], [expiry_date]) VALUES (153, 7, N'9in7nSpDJJ2ZpYSGcbCqtkEMacHzwHDoszmeuCBFkXc=', CAST(N'2020-08-12T12:36:44.340' AS DateTime))
GO
INSERT [dbo].[RefreshToken] ([token_id], [user_id], [token], [expiry_date]) VALUES (154, 7, N'rYWuPfWoid0R3FrObVttyIv8bpgI3YptC4wbDy37p8U=', CAST(N'2020-10-14T12:43:59.713' AS DateTime))
GO
INSERT [dbo].[RefreshToken] ([token_id], [user_id], [token], [expiry_date]) VALUES (155, 7, N'pybNBPVJoGX1eQiouYYFSLcz3f3lvbA6CcmpSHXnaTI=', CAST(N'2020-10-14T15:57:58.220' AS DateTime))
GO
INSERT [dbo].[RefreshToken] ([token_id], [user_id], [token], [expiry_date]) VALUES (156, 7, N'4I1uBtmIM3wXe5Hx2SkhQQ9fNjZXX2QV36OcWkzSSZo=', CAST(N'2020-10-28T20:32:51.887' AS DateTime))
GO
INSERT [dbo].[RefreshToken] ([token_id], [user_id], [token], [expiry_date]) VALUES (157, 44, N'aOhDCZrw16x2PhiZXv+gOkj/IIaQdZWGJewYTSLFdzw=', CAST(N'2020-10-28T20:39:16.577' AS DateTime))
GO
INSERT [dbo].[RefreshToken] ([token_id], [user_id], [token], [expiry_date]) VALUES (158, 7, N'zRIse09xRzzdyt3Sp25F/mEu/VgQvpck4D9xg58uvQ8=', CAST(N'2020-10-28T20:40:12.830' AS DateTime))
GO
INSERT [dbo].[RefreshToken] ([token_id], [user_id], [token], [expiry_date]) VALUES (159, 7, N'gkmfKapD9YObDNsHg3pkR7SaeomM8LijpiUq/0TGiTw=', CAST(N'2020-10-28T20:48:01.097' AS DateTime))
GO
INSERT [dbo].[RefreshToken] ([token_id], [user_id], [token], [expiry_date]) VALUES (160, 7, N'Lnd7eITN5UzggvNmogzOsbG3zHPSKwLXNu5fv+4ikcs=', CAST(N'2020-10-30T10:45:19.503' AS DateTime))
GO
INSERT [dbo].[RefreshToken] ([token_id], [user_id], [token], [expiry_date]) VALUES (161, 7, N'OZNMMcH2j4WU26LGTwGFtEmRbBdkK8vLYwN0WRg9Cho=', CAST(N'2020-11-02T12:42:45.707' AS DateTime))
GO
INSERT [dbo].[RefreshToken] ([token_id], [user_id], [token], [expiry_date]) VALUES (162, 7, N'4fjXIdErcHPW14eAnygsWV0skbllE3HiDY7l64k8meE=', CAST(N'2020-11-11T18:50:30.857' AS DateTime))
GO
INSERT [dbo].[RefreshToken] ([token_id], [user_id], [token], [expiry_date]) VALUES (163, 7, N'Dk4cy++khPlBByfn398WITTKYU86Fr6k51DtyEYgRpE=', CAST(N'2020-11-16T17:35:17.447' AS DateTime))
GO
INSERT [dbo].[RefreshToken] ([token_id], [user_id], [token], [expiry_date]) VALUES (164, 7, N'/fIrjSYKAUR7ZiJuviv+JuiKwBepMfGIVa3CBSjw1y0=', CAST(N'2020-11-16T17:37:35.717' AS DateTime))
GO
SET IDENTITY_INSERT [dbo].[RefreshToken] OFF
GO
SET IDENTITY_INSERT [dbo].[Role] ON 
GO
INSERT [dbo].[Role] ([role_id], [role_desc]) VALUES (1, N'Shopkeeper')
GO
INSERT [dbo].[Role] ([role_id], [role_desc]) VALUES (2, N'CEO')
GO
INSERT [dbo].[Role] ([role_id], [role_desc]) VALUES (3, N'Business Operations Manager')
GO
INSERT [dbo].[Role] ([role_id], [role_desc]) VALUES (4, N'Chief Financial Officier')
GO
INSERT [dbo].[Role] ([role_id], [role_desc]) VALUES (5, N'Publisher')
GO
INSERT [dbo].[Role] ([role_id], [role_desc]) VALUES (6, N'Managing Editor')
GO
INSERT [dbo].[Role] ([role_id], [role_desc]) VALUES (7, N'Marketing Manager')
GO
INSERT [dbo].[Role] ([role_id], [role_desc]) VALUES (8, N'Public Relations Manager')
GO
INSERT [dbo].[Role] ([role_id], [role_desc]) VALUES (9, N'Acquisitions Manager')
GO
INSERT [dbo].[Role] ([role_id], [role_desc]) VALUES (10, N'Productions Manager')
GO
INSERT [dbo].[Role] ([role_id], [role_desc]) VALUES (11, N'Operations Manager')
GO
INSERT [dbo].[Role] ([role_id], [role_desc]) VALUES (12, N'Editor')
GO
INSERT [dbo].[Role] ([role_id], [role_desc]) VALUES (13, N'Sales Representative')
GO
INSERT [dbo].[Role] ([role_id], [role_desc]) VALUES (14, N'Designer')
GO
SET IDENTITY_INSERT [dbo].[Role] OFF
GO
SET IDENTITY_INSERT [dbo].[Sale] ON 
GO
INSERT [dbo].[Sale] ([sale_id], [store_id], [order_num], [order_date], [quantity], [pay_terms], [book_id]) VALUES (1, N'6380', N'6871', CAST(N'1994-09-14T00:00:00.000' AS DateTime), 5, N'Net 60', 1)
GO
INSERT [dbo].[Sale] ([sale_id], [store_id], [order_num], [order_date], [quantity], [pay_terms], [book_id]) VALUES (2, N'6380', N'722a', CAST(N'1994-09-13T00:00:00.000' AS DateTime), 3, N'Net 60', 12)
GO
INSERT [dbo].[Sale] ([sale_id], [store_id], [order_num], [order_date], [quantity], [pay_terms], [book_id]) VALUES (3, N'7066', N'A2976', CAST(N'1993-05-24T00:00:00.000' AS DateTime), 50, N'Net 30', 9)
GO
INSERT [dbo].[Sale] ([sale_id], [store_id], [order_num], [order_date], [quantity], [pay_terms], [book_id]) VALUES (4, N'7066', N'QA7442.3', CAST(N'1994-09-13T00:00:00.000' AS DateTime), 75, N'ON invoice', 12)
GO
INSERT [dbo].[Sale] ([sale_id], [store_id], [order_num], [order_date], [quantity], [pay_terms], [book_id]) VALUES (5, N'7067', N'D4482', CAST(N'1994-09-14T00:00:00.000' AS DateTime), 10, N'Net 60', 12)
GO
INSERT [dbo].[Sale] ([sale_id], [store_id], [order_num], [order_date], [quantity], [pay_terms], [book_id]) VALUES (6, N'7067', N'P2121', CAST(N'1992-06-15T00:00:00.000' AS DateTime), 40, N'Net 30', 16)
GO
INSERT [dbo].[Sale] ([sale_id], [store_id], [order_num], [order_date], [quantity], [pay_terms], [book_id]) VALUES (7, N'7067', N'P2121', CAST(N'1992-06-15T00:00:00.000' AS DateTime), 20, N'Net 30', 17)
GO
INSERT [dbo].[Sale] ([sale_id], [store_id], [order_num], [order_date], [quantity], [pay_terms], [book_id]) VALUES (8, N'7067', N'P2121', CAST(N'1992-06-15T00:00:00.000' AS DateTime), 20, N'Net 30', 18)
GO
INSERT [dbo].[Sale] ([sale_id], [store_id], [order_num], [order_date], [quantity], [pay_terms], [book_id]) VALUES (9, N'7131', N'N914008', CAST(N'1994-09-14T00:00:00.000' AS DateTime), 20, N'Net 30', 12)
GO
INSERT [dbo].[Sale] ([sale_id], [store_id], [order_num], [order_date], [quantity], [pay_terms], [book_id]) VALUES (10, N'7131', N'N914014', CAST(N'1994-09-14T00:00:00.000' AS DateTime), 25, N'Net 30', 6)
GO
INSERT [dbo].[Sale] ([sale_id], [store_id], [order_num], [order_date], [quantity], [pay_terms], [book_id]) VALUES (11, N'7131', N'P3087a', CAST(N'1993-05-29T00:00:00.000' AS DateTime), 20, N'Net 60', 11)
GO
INSERT [dbo].[Sale] ([sale_id], [store_id], [order_num], [order_date], [quantity], [pay_terms], [book_id]) VALUES (12, N'7131', N'P3087a', CAST(N'1993-05-29T00:00:00.000' AS DateTime), 25, N'Net 60', 13)
GO
INSERT [dbo].[Sale] ([sale_id], [store_id], [order_num], [order_date], [quantity], [pay_terms], [book_id]) VALUES (13, N'7131', N'P3087a', CAST(N'1993-05-29T00:00:00.000' AS DateTime), 15, N'Net 60', 14)
GO
INSERT [dbo].[Sale] ([sale_id], [store_id], [order_num], [order_date], [quantity], [pay_terms], [book_id]) VALUES (14, N'7131', N'P3087a', CAST(N'1993-05-29T00:00:00.000' AS DateTime), 25, N'Net 60', 15)
GO
INSERT [dbo].[Sale] ([sale_id], [store_id], [order_num], [order_date], [quantity], [pay_terms], [book_id]) VALUES (15, N'7896', N'QQ2299', CAST(N'1993-10-28T00:00:00.000' AS DateTime), 15, N'Net 60', 4)
GO
INSERT [dbo].[Sale] ([sale_id], [store_id], [order_num], [order_date], [quantity], [pay_terms], [book_id]) VALUES (16, N'7896', N'TQ456', CAST(N'1993-12-12T00:00:00.000' AS DateTime), 10, N'Net 60', 5)
GO
INSERT [dbo].[Sale] ([sale_id], [store_id], [order_num], [order_date], [quantity], [pay_terms], [book_id]) VALUES (17, N'7896', N'X999', CAST(N'1993-02-21T00:00:00.000' AS DateTime), 35, N'ON invoice', 3)
GO
INSERT [dbo].[Sale] ([sale_id], [store_id], [order_num], [order_date], [quantity], [pay_terms], [book_id]) VALUES (18, N'8042', N'423LL922', CAST(N'1994-09-14T00:00:00.000' AS DateTime), 15, N'ON invoice', 6)
GO
INSERT [dbo].[Sale] ([sale_id], [store_id], [order_num], [order_date], [quantity], [pay_terms], [book_id]) VALUES (19, N'8042', N'423LL930', CAST(N'1994-09-14T00:00:00.000' AS DateTime), 10, N'ON invoice', 1)
GO
INSERT [dbo].[Sale] ([sale_id], [store_id], [order_num], [order_date], [quantity], [pay_terms], [book_id]) VALUES (20, N'8042', N'P723', CAST(N'1993-03-11T00:00:00.000' AS DateTime), 25, N'Net 30', 2)
GO
INSERT [dbo].[Sale] ([sale_id], [store_id], [order_num], [order_date], [quantity], [pay_terms], [book_id]) VALUES (21, N'8042', N'QA879.1', CAST(N'1993-05-22T00:00:00.000' AS DateTime), 30, N'Net 30', 8)
GO
INSERT [dbo].[Sale] ([sale_id], [store_id], [order_num], [order_date], [quantity], [pay_terms], [book_id]) VALUES (37, N'7896', N'X999', CAST(N'1993-02-21T00:00:00.000' AS DateTime), 35, N'ON invoice', 41)
GO
INSERT [dbo].[Sale] ([sale_id], [store_id], [order_num], [order_date], [quantity], [pay_terms], [book_id]) VALUES (38, N'7896', N'QQ2299', CAST(N'1993-10-28T00:00:00.000' AS DateTime), 15, N'Net 60', 42)
GO
INSERT [dbo].[Sale] ([sale_id], [store_id], [order_num], [order_date], [quantity], [pay_terms], [book_id]) VALUES (39, N'7896', N'TQ456', CAST(N'1993-12-12T00:00:00.000' AS DateTime), 10, N'Net 60', 43)
GO
INSERT [dbo].[Sale] ([sale_id], [store_id], [order_num], [order_date], [quantity], [pay_terms], [book_id]) VALUES (40, N'7131', N'N914014', CAST(N'1994-09-14T00:00:00.000' AS DateTime), 25, N'Net 30', 44)
GO
INSERT [dbo].[Sale] ([sale_id], [store_id], [order_num], [order_date], [quantity], [pay_terms], [book_id]) VALUES (41, N'8042', N'423LL922', CAST(N'1994-09-14T00:00:00.000' AS DateTime), 15, N'ON invoice', 44)
GO
SET IDENTITY_INSERT [dbo].[Sale] OFF
GO
INSERT [dbo].[Store] ([store_id], [store_name], [store_address], [city], [state], [zip]) VALUES (N'6380', N'Eric the Read Books', N'788 Catamaugus Ave.', N'Seattle', N'WA', N'98056')
GO
INSERT [dbo].[Store] ([store_id], [store_name], [store_address], [city], [state], [zip]) VALUES (N'7066', N'Barnum''s', N'567 Pasadena Ave.', N'Tustin', N'CA', N'92789')
GO
INSERT [dbo].[Store] ([store_id], [store_name], [store_address], [city], [state], [zip]) VALUES (N'7067', N'News & Brews', N'577 First St.', N'Los Gatos', N'CA', N'96745')
GO
INSERT [dbo].[Store] ([store_id], [store_name], [store_address], [city], [state], [zip]) VALUES (N'7131', N'Doc-U-Mat: Quality Laundry and Books', N'24-A Avogadro Way', N'Remulade', N'WA', N'98014')
GO
INSERT [dbo].[Store] ([store_id], [store_name], [store_address], [city], [state], [zip]) VALUES (N'7896', N'Fricative Bookshop', N'89 Madison St.', N'Fremont', N'CA', N'90019')
GO
INSERT [dbo].[Store] ([store_id], [store_name], [store_address], [city], [state], [zip]) VALUES (N'8042', N'Bookbeat', N'679 Carson St.', N'Portland', N'OR', N'89076')
GO
SET IDENTITY_INSERT [dbo].[User] ON 
GO
INSERT [dbo].[User] ([user_id], [email_address], [password], [source], [first_name], [middle_name], [last_name], [role_id], [pub_id], [hire_date]) VALUES (1, N'paolo.accorti@gmail.com', N'd58a7cfca32529d3f53ce8bdbf71bb0b', N'APPC', N'Paolo', N'M', N'Accorti', 13, 2, CAST(N'1992-08-27T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[User] ([user_id], [email_address], [password], [source], [first_name], [middle_name], [last_name], [role_id], [pub_id], [hire_date]) VALUES (2, N'pedro.afonso@gmail.com', N'99680688bb6c5c55aa7704fa89994095', N'APPC', N'Pedro', N'S', N'Afonso', 14, 3, CAST(N'1990-12-24T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[User] ([user_id], [email_address], [password], [source], [first_name], [middle_name], [last_name], [role_id], [pub_id], [hire_date]) VALUES (3, N'victoria.ashworth@gmail.com', N'f5542ce2319d45bf4582342d638550b8', N'APPC', N'Victoria', N'P', N'Ashworth', 6, 2, CAST(N'1990-09-13T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[User] ([user_id], [email_address], [password], [source], [first_name], [middle_name], [last_name], [role_id], [pub_id], [hire_date]) VALUES (4, N'helen.bennett@gmail.com', N'e9d232a1852b692a7e9508c65b6171f7', N'APPC', N'Helen', N' ', N'Bennett', 12, 2, CAST(N'1989-09-21T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[User] ([user_id], [email_address], [password], [source], [first_name], [middle_name], [last_name], [role_id], [pub_id], [hire_date]) VALUES (5, N'lesley.brown@gmail.com', N'97034cedc8690b3d70718a6d64967853', N'APPC', N'Lesley', N' ', N'Brown', 7, 2, CAST(N'1991-02-13T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[User] ([user_id], [email_address], [password], [source], [first_name], [middle_name], [last_name], [role_id], [pub_id], [hire_date]) VALUES (6, N'francisco.chang@gmail.com', N'4daa15ca8dd722ded8dfef31b87b3233', N'APPC', N'Francisco', N' ', N'Chang', 4, 7, CAST(N'1990-11-03T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[User] ([user_id], [email_address], [password], [source], [first_name], [middle_name], [last_name], [role_id], [pub_id], [hire_date]) VALUES (7, N'philip.cramer@gmail.com', N'33a7ce1b2f70fcbe4f7c2730d9885aab', N'APPC', N'Philip', N'T', N'Cramer', 5, 7, CAST(N'1989-11-11T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[User] ([user_id], [email_address], [password], [source], [first_name], [middle_name], [last_name], [role_id], [pub_id], [hire_date]) VALUES (8, N'aria.cruz@gmail.com', N'2caea50eb5d005293d0a1746f0388cba', N'APPC', N'Aria', N' ', N'Cruz', 10, 3, CAST(N'1991-10-26T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[User] ([user_id], [email_address], [password], [source], [first_name], [middle_name], [last_name], [role_id], [pub_id], [hire_date]) VALUES (9, N'ann.devon@gmail.com', N'234b4b2c43255c1e28d02e1f01e1ee23', N'APPC', N'Ann', N'M', N'Devon', 3, 7, CAST(N'1991-07-16T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[User] ([user_id], [email_address], [password], [source], [first_name], [middle_name], [last_name], [role_id], [pub_id], [hire_date]) VALUES (10, N'anabela.domingues@gmail.com', N'054aeb2a3b1551828768bcdb1a0ecc74', N'APPC', N'Anabela', N'R', N'Domingues', 8, 2, CAST(N'1993-01-27T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[User] ([user_id], [email_address], [password], [source], [first_name], [middle_name], [last_name], [role_id], [pub_id], [hire_date]) VALUES (11, N'peter.franken@gmail.com', N'e1ed3cb33f2f095867c915d25c8aee89', N'APPC', N'Peter', N'H', N'Franken', 10, 2, CAST(N'1992-05-17T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[User] ([user_id], [email_address], [password], [source], [first_name], [middle_name], [last_name], [role_id], [pub_id], [hire_date]) VALUES (12, N'paul.henriot@gmail.com', N'd15e9e8be1cc996882eea7b67bc5d364', N'APPC', N'Paul', N'X', N'Henriot', 5, 2, CAST(N'1993-08-19T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[User] ([user_id], [email_address], [password], [source], [first_name], [middle_name], [last_name], [role_id], [pub_id], [hire_date]) VALUES (13, N'carlos.hernadez@gmail.com', N'e26c377138dd65707e55711d5719210d', N'APPC', N'Carlos', N'F', N'Hernadez', 5, 8, CAST(N'1989-04-21T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[User] ([user_id], [email_address], [password], [source], [first_name], [middle_name], [last_name], [role_id], [pub_id], [hire_date]) VALUES (14, N'palle.ibsen@gmail.com', N'11201f7c203af329c5dee673ec03ca37', N'APPC', N'Palle', N'D', N'Ibsen', 7, 1, CAST(N'1993-05-09T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[User] ([user_id], [email_address], [password], [source], [first_name], [middle_name], [last_name], [role_id], [pub_id], [hire_date]) VALUES (15, N'karla.jablonski@gmail.com', N'68aaf122ba1446d333c5004e2641df57', N'APPC', N'Karla', N'J', N'Jablonski', 9, 8, CAST(N'1994-03-11T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[User] ([user_id], [email_address], [password], [source], [first_name], [middle_name], [last_name], [role_id], [pub_id], [hire_date]) VALUES (16, N'karin.josephs@gmail.com', N'056bdfd398f36d86ed8fd9145af278f8', N'APPC', N'Karin', N'F', N'Josephs', 14, 1, CAST(N'1992-10-17T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[User] ([user_id], [email_address], [password], [source], [first_name], [middle_name], [last_name], [role_id], [pub_id], [hire_date]) VALUES (17, N'matti.karttunen@gmail.com', N'119f79b2dc29583362ed6d03d8f5aa0f', N'APPC', N'Matti', N'G', N'Karttunen', 6, 1, CAST(N'1994-05-01T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[User] ([user_id], [email_address], [password], [source], [first_name], [middle_name], [last_name], [role_id], [pub_id], [hire_date]) VALUES (18, N'pirkko.koskitalo@gmail.com', N'3d257bb8efeac632b4e662b614364ff0', N'APPC', N'Pirkko', N'O', N'Koskitalo', 10, 8, CAST(N'1993-11-29T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[User] ([user_id], [email_address], [password], [source], [first_name], [middle_name], [last_name], [role_id], [pub_id], [hire_date]) VALUES (19, N'janine.labrune@gmail.com', N'03ecb265eb54ac869609f6a57d3aa7bb', N'APPC', N'Janine', N'Y', N'Labrune', 5, 6, CAST(N'1991-05-26T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[User] ([user_id], [email_address], [password], [source], [first_name], [middle_name], [last_name], [role_id], [pub_id], [hire_date]) VALUES (20, N'maria.larsson@gmail.com', N'510e7119883fcb468e0a1fa1e99058ad', N'APPC', N'Maria', N' ', N'Larsson', 7, 3, CAST(N'1992-03-27T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[User] ([user_id], [email_address], [password], [source], [first_name], [middle_name], [last_name], [role_id], [pub_id], [hire_date]) VALUES (21, N'yoshi.latimer@gmail.com', N'888d74a96e5ed2a4efa21bf067472fd1', N'APPC', N'Yoshi', N' ', N'Latimer', 12, 3, CAST(N'1989-06-11T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[User] ([user_id], [email_address], [password], [source], [first_name], [middle_name], [last_name], [role_id], [pub_id], [hire_date]) VALUES (22, N'laurence.lebihan@gmail.com', N'cb944a302015a3c86c43639c4af2026e', N'APPC', N'Laurence', N'A', N'Lebihan', 2, 1, CAST(N'1990-06-03T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[User] ([user_id], [email_address], [password], [source], [first_name], [middle_name], [last_name], [role_id], [pub_id], [hire_date]) VALUES (23, N'elizabeth.lincoln@gmail.com', N'e5c88db5d2234d599be77523eb7ab673', N'APPC', N'Elizabeth', N'N', N'Lincoln', 14, 2, CAST(N'1990-07-24T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[User] ([user_id], [email_address], [password], [source], [first_name], [middle_name], [last_name], [role_id], [pub_id], [hire_date]) VALUES (24, N'patricia.mckenna@gmail.com', N'be0f9d4835cfc4de3dfcb2fc46f24b45', N'APPC', N'Patricia', N'C', N'McKenna', 11, 8, CAST(N'1989-08-01T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[User] ([user_id], [email_address], [password], [source], [first_name], [middle_name], [last_name], [role_id], [pub_id], [hire_date]) VALUES (25, N'roland.mendel@gmail.com', N'7de8683294688271c520323ecf01b44b', N'APPC', N'Roland', N' ', N'Mendel', 11, 1, CAST(N'1991-09-05T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[User] ([user_id], [email_address], [password], [source], [first_name], [middle_name], [last_name], [role_id], [pub_id], [hire_date]) VALUES (26, N'rita.muller@gmail.com', N'9412be5c9cdb4c3b4f5c03775fc495ab', N'APPC', N'Rita', N'B', N'Muller', 5, 4, CAST(N'1993-10-09T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[User] ([user_id], [email_address], [password], [source], [first_name], [middle_name], [last_name], [role_id], [pub_id], [hire_date]) VALUES (27, N'helvetius.nagy@gmail.com', N'bfb106bd88053e860a99ee73b2239c86', N'APPC', N'Helvetius', N'A', N'Nagy', 7, 8, CAST(N'1993-03-19T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[User] ([user_id], [email_address], [password], [source], [first_name], [middle_name], [last_name], [role_id], [pub_id], [hire_date]) VALUES (28, N'timothy.o''rourke@gmail.com', N'd069d253d23a4e2a76df5e5347444446', N'APPC', N'Timothy', N'P', N'O''Rourke', 13, 1, CAST(N'1988-06-19T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[User] ([user_id], [email_address], [password], [source], [first_name], [middle_name], [last_name], [role_id], [pub_id], [hire_date]) VALUES (29, N'sven.ottlieb@gmail.com', N'89dd2a3836149f102826e5ea773d3265', N'APPC', N'Sven', N'K', N'Ottlieb', 5, 3, CAST(N'1991-04-05T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[User] ([user_id], [email_address], [password], [source], [first_name], [middle_name], [last_name], [role_id], [pub_id], [hire_date]) VALUES (30, N'miguel.paolino@gmail.com', N'9f52fa84113b54c17ff3c2610ea9847b', N'APPC', N'Miguel', N'A', N'Paolino', 11, 3, CAST(N'1992-12-07T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[User] ([user_id], [email_address], [password], [source], [first_name], [middle_name], [last_name], [role_id], [pub_id], [hire_date]) VALUES (31, N'paula.parente@gmail.com', N'c004780d86ce69ef12822167521e4fe2', N'APPC', N'Paula', N'S', N'Parente', 8, 3, CAST(N'1994-01-19T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[User] ([user_id], [email_address], [password], [source], [first_name], [middle_name], [last_name], [role_id], [pub_id], [hire_date]) VALUES (32, N'manuel.pereira@gmail.com', N'c7ecd3c9c5ad1d70697c47c4fa435f57', N'APPC', N'Manuel', N' ', N'Pereira', 8, 8, CAST(N'1989-01-09T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[User] ([user_id], [email_address], [password], [source], [first_name], [middle_name], [last_name], [role_id], [pub_id], [hire_date]) VALUES (33, N'maria.pontes@gmail.com', N'a0103b06f708acce6eabdeb2de09c6dc', N'APPC', N'Maria', N'J', N'Pontes', 5, 5, CAST(N'1989-03-01T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[User] ([user_id], [email_address], [password], [source], [first_name], [middle_name], [last_name], [role_id], [pub_id], [hire_date]) VALUES (34, N'martine.rance@gmail.com', N'6affb38e556e039b12d05994475323cb', N'APPC', N'Martine', N' ', N'Rance', 9, 2, CAST(N'1992-02-05T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[User] ([user_id], [email_address], [password], [source], [first_name], [middle_name], [last_name], [role_id], [pub_id], [hire_date]) VALUES (35, N'diego.roel@gmail.com', N'8d21a5250e2663f4ca84b7c526e680a5', N'APPC', N'Diego', N'W', N'Roel', 6, 3, CAST(N'1991-12-16T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[User] ([user_id], [email_address], [password], [source], [first_name], [middle_name], [last_name], [role_id], [pub_id], [hire_date]) VALUES (36, N'annette.roulet@gmail.com', N'46bc7cb510e1be6f2bf1e44611f424ac', N'APPC', N'Annette', N' ', N'Roulet', 6, 8, CAST(N'1990-02-21T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[User] ([user_id], [email_address], [password], [source], [first_name], [middle_name], [last_name], [role_id], [pub_id], [hire_date]) VALUES (37, N'mary.saveley@gmail.com', N'8b44843fcbb7c2ad1ab6e415473cb42f', N'APPC', N'Mary', N'M', N'Saveley', 8, 1, CAST(N'1993-06-29T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[User] ([user_id], [email_address], [password], [source], [first_name], [middle_name], [last_name], [role_id], [pub_id], [hire_date]) VALUES (38, N'carine.schmitt@gmail.com', N'c9935fafb77671eb170adb8bfde3257f', N'APPC', N'Carine', N'G', N'Schmitt', 13, 3, CAST(N'1992-07-07T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[User] ([user_id], [email_address], [password], [source], [first_name], [middle_name], [last_name], [role_id], [pub_id], [hire_date]) VALUES (39, N'margaret.smith@gmail.com', N'79cb518362503b10c4f8b0fae2dc055c', N'APPC', N'Margaret', N'A', N'Smith', 9, 3, CAST(N'1988-09-29T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[User] ([user_id], [email_address], [password], [source], [first_name], [middle_name], [last_name], [role_id], [pub_id], [hire_date]) VALUES (40, N'howard.snyder@gmail.com', N'3b11f056c1d81d7835feaa7592148656', N'APPC', N'Howard', N'A', N'Snyder', 12, 1, CAST(N'1988-11-19T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[User] ([user_id], [email_address], [password], [source], [first_name], [middle_name], [last_name], [role_id], [pub_id], [hire_date]) VALUES (41, N'martin.sommer@gmail.com', N'daed6b81dbbe4e29674198d08cdd9e22', N'APPC', N'Martin', N'F', N'Sommer', 10, 1, CAST(N'1990-04-13T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[User] ([user_id], [email_address], [password], [source], [first_name], [middle_name], [last_name], [role_id], [pub_id], [hire_date]) VALUES (42, N'gary.thomas@gmail.com', N'2ab391bb9a0ef6e0c49aab21a7e296ea', N'APPC', N'Gary', N'H', N'Thomas', 9, 1, CAST(N'1988-08-09T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[User] ([user_id], [email_address], [password], [source], [first_name], [middle_name], [last_name], [role_id], [pub_id], [hire_date]) VALUES (43, N'daniel.tonini@gmail.com', N'8d5d7d3510cb778173c99f91d76a413b', N'APPC', N'Daniel', N'B', N'Tonini', 11, 2, CAST(N'1990-01-01T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[User] ([user_id], [email_address], [password], [source], [first_name], [middle_name], [last_name], [role_id], [pub_id], [hire_date]) VALUES (44, N'john.smith@gmail.com', N'8be7dbd7237e2e0bf90ff81b8ff44333', N'APPC', N'John', N'F', N'Smith', 1, 8, CAST(N'2020-01-03T09:47:58.470' AS DateTime))
GO
SET IDENTITY_INSERT [dbo].[User] OFF
GO
/****** Object:  Index [PK_user_id_2]    Script Date: 5/22/2020 9:29:33 AM ******/
ALTER TABLE [dbo].[User] ADD  CONSTRAINT [PK_user_id_2] PRIMARY KEY NONCLUSTERED 
(
	[user_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Author] ADD  DEFAULT ('UNKNOWN') FOR [phone]
GO
ALTER TABLE [dbo].[Book] ADD  DEFAULT ('UNDECIDED') FOR [type]
GO
ALTER TABLE [dbo].[Book] ADD  DEFAULT (getdate()) FOR [published_date]
GO
ALTER TABLE [dbo].[Job] ADD  DEFAULT ('New Position - title not formalized yet') FOR [job_desc]
GO
ALTER TABLE [dbo].[Publisher] ADD  DEFAULT ('USA') FOR [country]
GO
ALTER TABLE [dbo].[Role] ADD  DEFAULT ('New Position - title not formalized yet') FOR [role_desc]
GO
ALTER TABLE [dbo].[User] ADD  DEFAULT ((1)) FOR [role_id]
GO
ALTER TABLE [dbo].[User] ADD  DEFAULT ((1)) FOR [pub_id]
GO
ALTER TABLE [dbo].[User] ADD  DEFAULT (getdate()) FOR [hire_date]
GO
ALTER TABLE [dbo].[Book]  WITH CHECK ADD FOREIGN KEY([pub_id])
REFERENCES [dbo].[Publisher] ([pub_id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[BookAuthor]  WITH CHECK ADD FOREIGN KEY([author_id])
REFERENCES [dbo].[Author] ([author_id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[BookAuthor]  WITH CHECK ADD FOREIGN KEY([book_id])
REFERENCES [dbo].[Book] ([book_id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[RefreshToken]  WITH CHECK ADD FOREIGN KEY([user_id])
REFERENCES [dbo].[User] ([user_id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Sale]  WITH CHECK ADD FOREIGN KEY([book_id])
REFERENCES [dbo].[Book] ([book_id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Sale]  WITH CHECK ADD FOREIGN KEY([store_id])
REFERENCES [dbo].[Store] ([store_id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[User]  WITH CHECK ADD FOREIGN KEY([role_id])
REFERENCES [dbo].[Role] ([role_id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[User]  WITH CHECK ADD FOREIGN KEY([pub_id])
REFERENCES [dbo].[Publisher] ([pub_id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Author]  WITH CHECK ADD CHECK  (([zip] like '[0-9][0-9][0-9][0-9][0-9]'))
GO
USE [master]
GO
ALTER DATABASE [BookStoresDB] SET  READ_WRITE 
GO