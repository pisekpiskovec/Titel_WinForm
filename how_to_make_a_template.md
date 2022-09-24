The process of creating a template file is simple. All you need to do is create the file with `.templ` extension.
Inside of that file, you'll need to fill 18 lines containing all metadata.

line 01 → Artist (can add multiple artists, for spliting `|` is used)
line 02 → Title
line 03 → Album
line 04 → Date (Year)(number) values: <0; 9999>
line 05 → Track (number) values: <0; 500>
line 06 → Disc (number) values: <0; 500>
line 07 → Genre (can add multiple genres, for spliting `|` is used)
line 08 → Album artist (can add multiple artists, for spliting `|` is used)
line 09 → Composer (can add multiple composers, for spliting `|` is used)
line 10 → Remixer

line 11 → Rating (number) values: values: <0; 255>
line 12 → Maximal rating (number) values: <0; 100>
line 13 → Spotify rating (number) values: <0; 255>
line 14 → Most played song in Spotify album (number) values: <0; 4000000000>
line 15 → YouTube rating (number) values: <0; 255>
line 16 → Soundcloud rating (number) values: <0; 255>

line 17 → Album art mode values: ["null", "empty", "custom", "my", "file", "own", "skip", ""]
line 18 → Album art path
