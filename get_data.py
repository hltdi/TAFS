"""
This file is part of TAFS.

    Copyleft 2022, 2023.
    Abnet Shimeles <abutihere@gmail.com> and Michael Gasser <gasser@indiana.edu>.

    TAFS is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    TAFS is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with morfo.  If not, see <http://www.gnu.org/licenses/>.
--------------------------------------------------------------------
get_data.py
Getting data from CACO (and other corpora?).

Author: Michael Gasser <gasser@indiana.edu>
"""

import os, re

CACO_DIR = os.path.join(os.path.dirname(__file__), 'datasets', 'CACO')
PUNCTUATION = "“‘”’–—:;/,<>?.!%$()[]{}|#@&*_+=\"፡።፣፤፥፦፧፨"
NUMERAL_RE = re.compile('(\w*?)(\d+(?:[\d,]*)(?:\.\d+)?)(\w*?)')

def get_batches(nbatches=10, nsentences=50, start=0, directory='', sort=False,
                filter_sentences=True, min_length=3, max_length=7, max_punc=1, max_num=0,
                readfile="CACO_3-7tok.txt", writefile='CACO_3-7tok', batch_start=0):
    '''
    Create nbatches of sentences with nsentences in each from the file at readfile in
    the CACO directory unless directory is specified, starting at sentence start,
    if filter_sentences is True, filtering out those sentences which
    (1) do not end in sentence-final punctuation
    (2) are not between min_length and max_length in length
    (3) have more than max_punc punctuation characters
    (4) have more tokens containing numerals than max_num
    If sort is True, sort the sentences by length first.
    If writefile is not empty, write the raw sentences to a series of files, naming them
    with the ending  _B{n}.txt, starting with n=batch_start.
    '''
    directory = directory or CACO_DIR
    with open(os.path.join(directory, readfile), encoding='utf8') as file:
#        data = [l.strip().split() for l in file.readlines()][start:]
        data = [l for l in file.readlines()][start:]
        nsentences = nsentences or len(data)
        end = start
        if sort:
            data.sort(key=lambda x: len(x))
        batches = []
        if not filter_sentences:
            batches = []
            batchstart  = start
            for batchi in range(nbatches):
                batch = data[batchstart:batchstart+nsentences]
                batches.append(batch)
                batchstart += nsentences
                end += batchstart
        else:
            sentid = 0
            for batchi in range(nbatches):
                batch = []
                while len(batch) < nsentences and sentid < len(data):
                    sentence = data[sentid].split()
                    sentid += 1
                    end += 1
                    ntoks = len(sentence)
                    if ntoks < min_length or ntoks > max_length:
                        # Sentence is too short or too long
                        continue
                    if sentence[-1] not in '።?!':
                        # No sentence-final punctuation at end
                        continue
                    if count_punc(sentence) > max_punc:
                        # Sentence has too many punctuation characters
                        continue
                    if count_num(sentence) > max_num:
                        # Sentence has at least one token containing a numeral
                        continue
                    batch.append(' '.join(sentence))
                batches.append(batch)
        if writefile:
            for batchi, batch in enumerate(batches):
                writefile0 = "{}_B{}.txt".format(writefile, batchi+batch_start)
                print("** Writing batch to {}".format(writefile0))
                with open(os.path.join(CACO_DIR, writefile0), 'w', encoding='utf8') as file:
                    for sentence in batch:
                        print(sentence, file=file)
            return end, None
        return end, batches

def count_punc(sentence):
    """
    Number of punctuation characters in sentence (list of strings).
    """
    return len([w for w in sentence if w in PUNCTUATION])

def count_num(sentence):
    """
    Number of tokens in sentence (list of strings) that contain numerals.
    """
    return len([w for w in sentence if NUMERAL_RE.fullmatch(w)])
