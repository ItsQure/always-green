#noahsewell
#this project will grab quotes of the day and upload them to my github in order to make my work flow be always green

import requests
import os
from bs4 import BeautifulSoup


url = 'https://www.insightoftheday.com'

#will likely need html content parser in order to grab the quotes of the day

r = requests.get(url)
content = BeautifulSoup(r.content,'html5lib')
f = open("demofile3.txt", "w")
f.write(content.prettify())
f.close()
f = 	open("demofile3.txt", "r")
print(f.read())

run_git = os.system("git add *")
run_git = os.system("git commit -m \"added daily change\"")
run_git = os.system("git push origin")


