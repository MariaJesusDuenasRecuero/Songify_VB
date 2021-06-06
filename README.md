## Project Database [2020-2021]


The database to be managed will contain a series of tables to store information about users, artists, albums, songs, plays and favorite artists of the users.
The following figure describes the relational schema of the database to be used.
The file with the database can be found on master branch.

The following image will show the Relational model of the database:

![esquema](https://user-images.githubusercontent.com/72667996/120924467-320cd400-c6d4-11eb-93cb-3721e1c0eac6.PNG)



Developed in visual basic language

Tables and attributes names are self-explaining, so no extra details about the
content is commented excepting:
• SONGS.lenght represents the number of seconds the song lasts.
• ALBUMS.cover and ARTISTS.image represent an operating system path where the album cover image and artist image are located respectively.


The main functionalities of the system are:
• It will allow selecting the file containing the database to work with.
• When starting the application, the user will be selected by his identifier (email). At any time during the use of the program it will be allowed to change the user.
• It will allow managing (inserting, updating and deleting) the data related to the system management (ALBUMS, ARTISTS, SONGS, and USERS tables). All the data will be collected using the corresponding form(s).
• Browsing through the available artists, albums and songs, loading the content dynamically (e.g., selecting an artist loads the list of its albums; selecting an album loads the list of its songs).
• Each selected item will show its related information in the database (name, country, date of publication, etc.). Additionally:
  o When selecting an artist, it will be displayed if the current user has marked it as a favorite.
  o When selecting an album, its total length will be displayed in an appropriate time format (e.g., 43:27 or 1:21:52).
  o When selecting an artist or an album, its corresponding image or cover will be displayed.
  o When selecting a song, its length will be displayed in an appropriate time format (e.g., 43:27 or 1:21:52).
• Playing a song back (in fact, simulating it – there is no need to create a complex multimedia system).
• Showing the playback history of a song.
• Mark/unmark an artist as favorite.
• The system will also be able to solve the following queries from the data stored in the database and to show the results in an appropriate way:
  o List of artists sorted by number of playbacks (in general and allowing filtering by country).
  o List of songs sorted by number of playbacks.
  o List of artists most listened to by a user (between 2 given dates).
  o List of users sorted by time using the application (based on total duration of songs played back).
  o Playback time of a user's favorite artists.
