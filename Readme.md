SqLiteQuery
===========

Français
--------

- Librairie DLL pour faciliter la gestion de base SqLite sous .Net.
- Pévus pour Visual Studio 2012 - x86.


Installation
------------
- Aller sur http://system.data.sqlite.org/index.html/doc/trunk/www/downloads.wiki
- Télécharger et installer sqlite-netFx45-setup-bundle-x86-2012-1.0.84.0.exe


Base
----
- Ajouter en référence au projet SqLiteQuery.dll
- Ajouter la directive suivante dans la fichier ou vous souhaiter utiliser la DLL :
	using SqLiteQuery;

	
Variables minimum
-----------------
1) Crée une instance de Query 

	Query Q = new Query("Source.db");
	
2) Crée une variables d'Exception
	
	Exception E;
	
Notes : La variable d'exception sert a récupérer les erreurs lors de requêtes.

Requêtes disponibles
--------------------
A Venir.

Requêtes personnalisé sans retour
---------------------------------
	
	 Q.ExecuteQuery("QUERY", E);
	 
Notes : Retourne une Boolean.

Constructeur possibles
----------------------
	
	public Query (string source): base (source) {}

	public Query (string source, string version): base (source, version) {}

	public Query (string source, string version, string password): base (source, version, password) {}

	public Query (string source, string version, string password, new Boolean): base (Source, Version, Password, New) {}

	public Query (string source, string version, string password, new Boolean, Boolean Compress): base (Source, Version, Password, New, Compress) {}




English
--------

- Library DLL to facilitate database management SqLite under. Net.
- Pévus for Visual Studio 2012 - x86.


Installation
------------
- Go http://system.data.sqlite.org/index.html/doc/trunk/www/downloads.wiki
- Download and install sqlite-netFx45-setup-bundle-x86-2012-1.0.84.0.exe


Base
----
- Add a reference to the project SqLiteQuery.dll
- Add the following directive in the file or you want to use the DLL:
	using SqLiteQuery;


Variables minimum
-----------------
1) Create an instance of Query

	Query Q = new Query ("Source.db");

2) Create a variable Exception

	Exception E;

Note: The exception variable is used to retrieve the errors in queries.

Queries available
--------------------
Coming.

Custom requests without return
---------------------------------

	Q.ExecuteQuery ("QUERY", E);

Notes: Returns a Boolean.

Constructor
----------------------

	public Query (string source): base (source) {}

	public Query (string source, string version): base (source, version) {}

	public Query (string source, string version, string password): base (source, version, password) {}

	public Query (string source, string version, string password, new Boolean): base (Source, Version, Password, New) {}

	public Query (string source, string version, string password, new Boolean, Boolean Compress): base (Source, Version, Password, New, Compress) {}
