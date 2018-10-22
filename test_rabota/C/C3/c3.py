# -*- coding: utf8 -*- 
import statistics
import collections
import copy
import os
import zipfile

def zamena(file,x,y,tt) :
    z=[]
    x=x[0:-1]
    y=y+"="
    array = list(open(file))
    for line in array:
        str_new=""
        if line.find(x)>-1 and line.find(y)>-1 :
            #print(line)
            str=line.split(" ")
            for line2 in str :
                #print(line2)
                if line2.find(y)>-1 :
                    if line2.find("\">")>-1 :
                        line2=line2[0:-2]+tt+"\">"
                    else :
                        line2=line2[0:-1]+tt+"\""
                str_new=str_new+line2+" "
          #print(str_new)
        #print(str_new)
        if len(str_new)>0 :
            line=str_new
        z.append(line)

    f = open(file, 'w')
    for line in z:
        f.write(line)
        print(line)
    
    f.close()

z = zipfile.ZipFile('test.zip', 'r')
z.extractall()
z.close()

zamena('test\\file.xml',"<tag>","name","1") #дописываем 1
zamena('test\\glavny.xml',"<tag1>","name","b8ubbiuvbiueg") #дописываем b8ubbiuvbiueg
zamena('test\\ne_sovsem_glany.xml',"<tag>","name","$%^$^$%^$^") #дописываем $%^$^$%^$^

if os.path.exists('test\\dir') :
    os.rename('test\\dir', 'test\\dir1')
    
z = zipfile.ZipFile('test.zip', 'w')        
for root, dirs, files in os.walk('test'):
    for file in files:
        z.write(os.path.join(root,file))
    for dir1 in dirs:
        z.write(os.path.join(root,dir1))         

z.close()  

