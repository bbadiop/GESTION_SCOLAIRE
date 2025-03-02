# Application de Gestion Scolaire en C# (Windows Forms)

## Description
Ce projet est une application Windows Forms développée en C# pour la gestion complète d'un établissement scolaire. Elle permet de gérer les étudiants, les classes, les cours, les matières, les professeurs, les notes académiques, et les utilisateurs avec des rôles spécifiques (Administrateur, Directeur d'Études, Agent, Professeur). L'application inclut une **authentification à deux facteurs (A2F) par SMS** pour renforcer la sécurité.

## Fonctionnalités
- **Authentification sécurisée** : Connexion avec mot de passe et A2F par SMS.
- **Gestion des étudiants** : Ajout, modification, suppression, recherche et tri.
- **Gestion des classes, cours, matières et professeurs** : CRUD complet et associations.
- **Gestion des notes** : Saisie des notes, calcul des moyennes, relevés de notes.
- **Génération de rapports** : Export des relevés de notes en PDF ou Excel.
- **Base de données** : Conception relationnelle avec SQL Server.

## Technologies Utilisées
- **Langage** : C# (Windows Forms)
- **Base de Données** : SQL Server
- **API SMS** : Twilio ou Nexmo (pour l'A2F)
- **Génération de PDF** : iTextSharp
- **Génération d'Excel** : EPPlus
- **Environnement de Développement** : Visual Studio

## Comment Utiliser le Projet

### Prérequis
- Visual Studio 2019 ou ultérieur.
- SQL Server (local ou distant).
- Compte Twilio ou Nexmo pour l'API SMS.
  
## Captures d'Écran
![Écran de Connexion]()
![Gestion des Étudiants]()

## Installation

1. Clonez le repository :
   ```bash

   git clone https://github.com/votre-utilisateur/nom-du-repo.git

## 2.Configurer la Base de Données :

Exécutez le script SQL "DatabaseScript.sql" pour créer la base de données.

## 3.Configurer l'API SMS :

Configurer la chaîne de connexion dans le fichier app.config.

![image](https://github.com/user-attachments/assets/df5d3830-50bf-4de6-b2db-5294b4c98030)

Ajouter les clés d'API Twilio ou Nexmo dans le fichier de configuration.

## 4.Lancer l'Application :

Ouvrir la solution dans Visual Studio.

Compiler et exécuter le projet.

## 5.Structure du Projet

![image](https://github.com/user-attachments/assets/bd8da7f5-b07d-4f40-9408-a2f43a21eb2a)

## 6.Contribuer

```Les contributions sont les bienvenues ! Pour contribuer :

Forkez le repository.

Créez une branche pour votre fonctionnalité (git checkout -b nouvelle-fonctionnalite).

Committez vos changements (git commit -m 'Ajout d'une nouvelle fonctionnalité').

Pushez la branche (git push origin nouvelle-fonctionnalite).

Ouvrez une Pull Request.
----------------------------------------------------------------------

Auteur
Ahmadou Bamba F.M Diop - bbadiop
Awa Talla Sene - awatalla1
