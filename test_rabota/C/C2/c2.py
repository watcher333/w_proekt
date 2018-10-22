# -*- coding: utf8 -*- 
import glob
import os
import shutil
import statistics
import collections
import time
import tqdm  # $ pip install tqdm
import progressbar
import sys

#path='c:\\sait2\\'
path=sys.argv[1]
folder = []
z_files=[]
z_folder=[]
i=0
j=0
x=0
from progressbar import ProgressBar
pbar = ProgressBar()

from collections import Counter
for i in os.walk(path):
   folder.append(i)
#print(folder)   

for address, dirs, files in pbar(folder):
   for file in files:
      if file.find(".")>-1 :
         str=file.split(".")
         z_files.append(str[1])
      else :
            z_files.append(file)
      if os.path.exists(address+'\\'+file):      
         os.remove(address+'\\'+file)
    
print("Files - ","\n",Counter(z_files),"\n\n")

for address, dirs, files in folder:
   for subdirname in dirs:
      z_folder.append(subdirname)
      if os.path.exists(address+'\\'+subdirname) and len(os.listdir(address+'\\'+subdirname))==0 :
         os.rmdir(address+'\\'+subdirname)
print("Folder - ",len(z_folder),"\n")

#clean other
if len(os.listdir(path))>0 :
   shutil.rmtree(path, ignore_errors=False, onerror=None)
   if os.path.exists(path)==False :
      os.mkdir(path)

pbar.finish()         
