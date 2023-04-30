# Program: Create tsv for genres for a static table

import os
import pandas as pd

os.system('cls')

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

# Drop everything except the language
titleAkasAll.drop(['titleId','ordering','title','region','types', 'attributes', 'isOriginalTitle'], axis=1, inplace=True)

# Then drop duplicates
titleAkasAll.drop_duplicates(keep="first", subset=None, inplace=True)
# Output to TSV
titleAkasAll.to_csv('StaticLanguages.tsv', sep="\t")
