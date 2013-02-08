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
	
	public Query(string Source) : base(Source){}
	
	public Query(string Source, string Version) : base(Source, Version){}
        
	public Query(string Source, string Version, Boolean New) : base(Source, Version, New){}
        
	public Query(string Source, string Version, Boolean New, Boolean Compress) : base(Source, Version, New, Compress){}
