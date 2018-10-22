import statistics
import collections
import copy

i=0
j=0
y=0
mas_zps=[]
z=[]
from collections import Counter
array = list(open('log'))
for line in array:
   str=line.split("|")
   
   if int(str[3])>400 or str[4].find("error")>-1 :
      j=j+1
   z.insert(i,str[2])
   str_time_begin=str[0].split(" ")
   str_time_end=str[1].split(" ")
    
   begin_second=str_time_begin[1].split(":")
   end_second=str_time_end[1].split(":")
    
   time_begin_second=int(begin_second[0])*3600+int(begin_second[1])*60+int(begin_second[2])
   time_end_second=int(end_second[0])*3600+int(end_second[1])*60+int(end_second[2])
   mas_zps.insert(i,time_end_second-time_begin_second)
#  print(time_begin_second,time_end_second,mas_zps[i])
   i=i+1
print("max zapros(sec) -",max(mas_zps),"\n","min zapros(sec) -",min(mas_zps),"\n","srednee_arifmet -",statistics.mean(mas_zps)
      ,"\n","median -",statistics.median(mas_zps),"\n","%_errors -",(j*100)/i,"\n",Counter(z))



    
    