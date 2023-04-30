# Program: Shrink the number of rows in titleBasics.tsv to make the project easier to manage

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

# Read write every other row to shink movies by half
shrinkFactor = 10
count = 0
import csv

# Open the TSV file for reading
with open("RawData/titleBasicsAll.tsv", newline="", encoding='utf-8') as tsvfileRead:
    reader = csv.reader(tsvfileRead, delimiter="\t")

    # Open a TSV file for writing
    with open("IntermediateTSVs/shrinkedTitleBasics.tsv", "w", newline="", encoding='utf-8') as tsvfileWrite:
        writer = csv.writer(tsvfileWrite, delimiter="\t")

        # Iterate over the rows of data
        for row in reader:

            # Write the data to the TSV file
            if count == 0 or count % shrinkFactor == 0:
                writer.writerow(row)
            count += 1

