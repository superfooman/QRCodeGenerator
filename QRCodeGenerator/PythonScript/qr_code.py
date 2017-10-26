import csv
import urllib

# Generate QR code using the Google Chart REST API:
# https://developers.google.com/chart/infographics/docs/qr_codes
root_url = 'https://chart.googleapis.com/chart?'

def generate_qr_code(message):
    query = dict(cht='qr', chs='300x300', chl=message)
    url = root_url + urllib.urlencode(query)
    url_open = urllib.urlopen(url)
    image = url_open.read()
    url_open.close()
    return image

def save_qr_code_image(image, file_path):
    file_name = '%s' % (file_path)
    with open (file_name, 'wb') as image_file:
        image_file.write(image)