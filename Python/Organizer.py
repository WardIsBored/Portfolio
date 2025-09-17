import os

mp4_files = [f for f in os.listdir('.') if f.endswith('.mp4')]
mp3_files = [f for f in os.listdir('.') if f.endswith('.mp3')]
png_files = [f for f in os.listdir('.') if f.endswith('.png')]
txt_files = [f for f in os.listdir('.') if f.endswith('.txt')]
jpg_files = [f for f in os.listdir('.') if f.endswith('.jpg')]
pdf_files = [f for f in os.listdir('.') if f.endswith('.pdf')]
zip_files = [f for f in os.listdir('.') if f.endswith('.zip')]

if not os.path.exists('Videos'):
    os.makedirs('Videos')
if not os.path.exists('Audios'):
    os.makedirs('Audios')
if not os.path.exists('Images'):
    os.makedirs('Images')
if not os.path.exists('Documents'):
    os.makedirs('Documents')
if not os.path.exists('Archives'):
    os.makedirs('Archives')

for file in mp4_files:
    os.rename(file, os.path.join('Videos', file))
for file in mp3_files:
    os.rename(file, os.path.join('Audios', file))
for file in png_files:
    os.rename(file, os.path.join('Images', file))
for file in jpg_files:
    os.rename(file, os.path.join('Images', file))
for file in txt_files:
    os.rename(file, os.path.join('Documents', file))
for file in pdf_files:
    os.rename(file, os.path.join('Documents', file))
for file in zip_files:
    os.rename(file, os.path.join('Archives', file))
print("Files have been organized into respective folders.")