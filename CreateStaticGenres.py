# Program: Create tsv for genres for a static table

import os
import pandas as pd

os.system('cls')

titleBasics = pd.read_csv('IntermediateTSVs/shrinkedTitleBasicsSeperateGenres.tsv', sep='\t')

# This gives the following columns:
    # tconst (string) - alphanumeric unique identifier of the title
    # titleType (string) - the type/format of the title (e.g. movie, short, tvseries, tvepisode, video, etc)
    # primaryTitle (string) - the more popular title / the title used by the filmmakers on promotional materials at the point of release
    # originalTitle (string) - original title, in the original language
    # isAdult (boolean) - 0: non-adult title; 1: adult title
    # startYear (YYYY) - represents the release year of a title. In the case of TV Series, it is the series start year
    # endYear (YYYY) - TV Series end year. '\N' for all other title types
    # runtimeMinutes - primary runtime of the title, in minutes
    # genres (string array) - includes up to three genres associated with the title

# Drop all columns that aren't genres
titleBasics.drop(['tconst' ,'titleType' ,'primaryTitle', 'originalTitle', 'isAdult', 'startYear',
                  'endYear', 'runtimeMinutes'], 
                 axis=1, inplace=True)

# Then drop duplicates
titleBasics.drop_duplicates(keep="first", subset=None, inplace=True)
# Output to TSV
titleBasics.to_csv('StaticGenres.tsv', sep="\t")
