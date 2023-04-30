# Program: Create a tsv with all the data our database application will need

import csv
import os
import pandas as pd

os.system('cls')

# ----------------- Step 1 get data on the titles -------------------------- #
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

# Size of the dataset
print('titles basics has {} titles'.format(titleBasics.shape[0]))
# Only keep rows that are movies
titleBasics = titleBasics[titleBasics['titleType'].str.contains('movie')]
# Size of dataset that are only movies
print('We removed everything that is not a movie, we now have {} movies'.format(titleBasics.shape[0]))

# Now we can drop columns we don't need
titleBasics.drop(['titleType' ,'originalTitle' ,'isAdult', 'endYear'], axis=1, inplace=True)

print('After step 1 columns (We narrow down data to only incude movies)')
print(list(titleBasics.columns))
print('After Step 1 {} rows'.format(titleBasics.shape[0]))

# ------------------- Step 2 Join Directors onto dataset ----------------------- #

titleCrew = pd.read_csv('RawData/titleCrewAll.tsv', sep='\t')

# This gives the following columns:
    # tconst (string) - alphanumeric unique identifier of the title
    # directors (array of nconsts) - director(s) of the given title
    # writers (array of nconsts) – writer(s) of the given title

# We are not using writers
titleCrew.drop(['writers'], axis=1, inplace=True)

# Now join the names to the director IDs
nameBasics = pd.read_csv('RawData/nameBasicsAll.tsv', sep='\t')

# NameBasicsAll has the following columns:
    # nconst (string) - alphanumeric unique identifier of the name/person
    # primaryName (string)– name by which the person is most often credited
    # birthYear – in YYYY format
    # deathYear – in YYYY format if applicable, else '\N'
    # primaryProfession (array of strings)– the top-3 professions of the person
    # knownForTitles (array of tconsts) – titles the person is known for

directorsWithNames = pd.merge(titleCrew, nameBasics, left_on="directors", right_on="nconst", how="inner")
# Now we need to join the name of the directors (primaryName) to the title basics using the title const id
# So we can drop everything except the title id and the name
directorsWithNames.drop(['directors' ,'nconst' ,'birthYear', 'deathYear', 'primaryProfession', 'knownForTitles'], axis=1, inplace=True)
finalOutput = pd.merge(directorsWithNames, titleBasics, left_on="tconst", right_on="tconst", how="inner")

# Rename some of the merged columns so they represent the data
finalOutput.rename(columns={"primaryName": "Director"}, inplace=True)
finalOutput.rename(columns={"primaryTitle": "Movie"}, inplace=True)
finalOutput.rename(columns={"startYear": "StartYear"}, inplace=True)
finalOutput.rename(columns={"runtimeMinutes": "RuntimeMinutes"}, inplace=True)
finalOutput.rename(columns={"genres": "Genres"}, inplace=True)

print('\nAfter step 2 columns (Inner join to only have movie data with directors)')
print(list(finalOutput.columns))
print('After Step 2 {} rows'.format(finalOutput.shape[0]))

# ------------------- Step 3 Join Actors onto dataset ----------------------- #

principlesAll = pd.read_csv('RawData/titlePrinciplesAll.tsv', sep='\t')

# Principles give the following columns:
    # tconst (string) - alphanumeric unique identifier of the title
    # ordering (integer) – a number to uniquely identify rows for a given titleId
    # nconst (string) - alphanumeric unique identifier of the name/person
    # category (string) - the category of job that person was in
    # job (string) - the specific job title if applicable, else '\N'
    # characters (string) - the name of the character played if applicable, else '\N'

# Filter the data so the only job value is actors
principlesAll = principlesAll[principlesAll['category'].str.contains('actor')]
# Find the name of each actor
actorsWithNames = pd.merge(principlesAll, nameBasics, left_on="nconst", right_on="nconst", how="inner")
# Drop uneeded columns
actorsWithNames.drop(['ordering','nconst','category','job', 'characters', 'birthYear', 'deathYear',
                      'deathYear', 'primaryProfession', 'knownForTitles'], axis=1, inplace=True)
# Change to actor name so we know what it refers to
actorsWithNames.rename(columns={"primaryName": "Actor"}, inplace=True)
# Merge with output
finalOutput = pd.merge(finalOutput, actorsWithNames, left_on="tconst", right_on="tconst", how="inner")

print('\nAfter step 3 columns (Inner join on actors, more rows created since many actors to 1 movie)')
print(list(finalOutput.columns))
print('After Step 3 {} rows'.format(finalOutput.shape[0]))

# -------------------- Step 4 Join Reviews onto dataset ------------------------ #

titleRatingsAll = pd.read_csv('RawData/titleRatings.tsv', sep='\t')

# title ratings contains the following columns
    # tconst (string) - alphanumeric unique identifier of the title
    # numVotes – weighted average of all the individual user ratings
    # numVotes - number of votes the title has received

# Merge with output
finalOutput = pd.merge(titleRatingsAll, finalOutput, left_on="tconst", right_on="tconst", how="inner")
# Adjust names to indicate that the ratings come from imdb
finalOutput.rename(columns={"averageRating": "AverageIMDbRating"}, inplace=True)
finalOutput.rename(columns={"numVotes": "NumIMDbVotes"}, inplace=True)

print('\nAfter step 4 columns (add reviews, less of the dataset had reviews so it shrinks)')
print(list(finalOutput.columns))
print('After Step 4 {} rows'.format(finalOutput.shape[0]))

# -------------------- Step 5 join language onto dataset ----------------------- #

titleAkasAll = pd.read_csv('RawData/titleAkasAll.tsv', sep='\t')

# titleAkas has the following columns:
    # titleId (string) - a tconst, an alphanumeric unique identifier of the title
    # ordering (integer) – a number to uniquely identify rows for a given titleId
    # title (string) – the localized title
    # region (string) - the region for this version of the title
    # language (string) - the language of the title
    # types (array) - Enumerated set of attributes for this alternative title. One or more of the following: "alternative", "dvd", "festival", "tv", "video", "working", "original", "imdbDisplay". New values may be added in the future without warning
    # attributes (array) - Additional terms to describe this alternative title, not enumerated
    # isOriginalTitle (boolean) – 0: not original title; 1: original title

# Drop everything except the titleId and the language
titleAkasAll.drop(['ordering','title','region','types', 'attributes', 'isOriginalTitle'], axis=1, inplace=True)
# Merge to final output
finalOutput = pd.merge(titleAkasAll, finalOutput, left_on="titleId", right_on="tconst", how="inner")
finalOutput.rename(columns={"language": "Language"}, inplace=True)
finalOutput.drop(['titleId','tconst'], axis=1, inplace=True)

print('\nFinal columns')
print(list(finalOutput.columns))
print('Final output {} rows'.format(finalOutput.shape[0]))

# ---------- Last step: post processing and writing to tsv ----------- #

# I think the join with actors and the join with the table with language/region were both 
# 1 to many relationships. This means that doing both the inner joins without inner joining multiple columns
# created some duplicate rows. So we should get rid of these duplicate rows. I know they are there from reading 
# the output files in the command line
finalOutput.drop_duplicates(keep="first", subset=None, inplace=True)
print('\nFinal output no duplicate rows {} rows'.format(finalOutput.shape[0]))

# Convert into a tsv
finalOutput.to_csv('MovieOutput.tsv', sep="\t")