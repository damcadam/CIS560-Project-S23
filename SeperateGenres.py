# Program: titleBasicsAll.csv has the gernes in a list 'rock,jazz,ramRanch'. But we'd rather have 3 seperate rows
#           where the movie has 1 row per genre. This script creates a CSV to do that

import csv
import os

os.system('cls')

# titleBasicsAll has the following columns:
    # tconst (string) - alphanumeric unique identifier of the title
    # titleType (string) – the type/format of the title (e.g. movie, short, tvseries, tvepisode, video, etc)
    # primaryTitle (string) – the more popular title / the title used by the filmmakers on promotional materials at the point of release
    # originalTitle (string) - original title, in the original language
    # isAdult (boolean) - 0: non-adult title; 1: adult title
    # startYear (YYYY) – represents the release year of a title. In the case of TV Series, it is the series start year
    # endYear (YYYY) – TV Series end year. ‘\N’ for all other title types
    # runtimeMinutes – primary runtime of the title, in minutes
    # genres (string array) – includes up to three genres associated with the title

shrinkFactor = 2
count = 0
import csv

# Open the TSV file for reading
with open("IntermediateTSVs/shrinkedTitleBasics.tsv", newline="", encoding='utf-8') as tsvfileRead:
    reader = csv.reader(tsvfileRead, delimiter="\t")

    # Open a TSV file for writing
    with open("IntermediateTSVs/shrinkedTitleBasicsSeperateGenres.tsv", "w", newline="", encoding='utf-8') as tsvfileWrite:
        writer = csv.writer(tsvfileWrite, delimiter="\t")

        # Iterate over the rows of data
        for row in reader:
            # Seperate each genre out
            try:
                genresString = row[8]
            except IndexError:
                print('Data for this row did not parse right, not including it')
                print(row)
            genresList = genresString.split(',')

            # Grab each item from the row other than genres
            tconst = row[0]
            titleType = row[1]
            primaryTitle = row[2]
            originalTitle = row[3]
            isAdult = row[4]
            startYear = row[5]
            endYear = row[6]
            runtimeMinutes = row[7]

            # Write each genre to its own row
            for singleGenre in genresList:
                newRow = [tconst, titleType, primaryTitle, originalTitle, isAdult, 
                                startYear, endYear, runtimeMinutes, singleGenre]
                writer.writerow(newRow)

print('Complete!')
