import json, requests, sys, math

base_url = 'https://api.openweathermap.org/data/2.5/weather?'
city = "Gulfport"
API_KEY = "6801dbf1bc662e96661431e15a720cb5"
url = base_url + "q=" + city + "&appid=" + API_KEY
response = requests.get(url)


if response.status_code == 200:
    data = response.json()
    main = data['main']
    temperature = main['temp']
    humidity = main['humidity']
    pressure = main['pressure']
    report = data['weather']

    temperature = ((temperature - 273.15) * 9/5 + 32)

    print(f"city: {city}")
    print(f"temperature (F): {temperature}")
    print(f"humidity: {humidity}")
    print(f"pressure: {pressure}")
    print (f"weather report: {report[0]['description']}")
else:
    print("Error in the HTTP request")