def clasedor(atb, hab, ps):

    if atb == "INT":
        #Oque vc usa?
        if hab == "Magia":
            #Voce faz itens?
            if ps == "Sim":
                return "Artifice"
            elif ps == "Não":
                return "Mago"
        elif hab == "Não":
            return "nada como assim voce usa o atributo de inteligencia e não usa magia bobão?!?"
        
        
    elif atb == "CAR":
        #Que tipo d magia
        if hab == "Magia Inata":
            #Vc usa musica?
            if ps == "Sim":
             return "Bardo"
            elif ps == "Não":
                return "Feiticeiro"
        elif hab == "Magia Divina":
            #Quem lhe da sua magia
            if ps == "Deus":
                return "Paladino"
            elif ps == "Diabo":
                return "Bruxo"
        elif hab == "Não":
            return "Burro"
        
        
    elif atb == "SAB":
        #Vc usa magia?
        if hab == "Sim":
            #Que tipo?
            if ps == "Divina":
                return "Clerigo"
            elif ps == "Natural":
                return "Druida"
            else:
                return "Burro"
        elif hab == "Não":
            return "Monge"
        
        
    elif atb == "FOR":
        #Vc usa sua raiva
        if hab == "Sim":
            return "Bárbaro"
        elif hab == "Não":
            return "Guerreiro"
        
        
    elif atb == "DEX":
        #Voce é furtivo
        if hab == "Sim":
            return "Ladino"
        elif hab == "Não":
            return "Ranger"
        
print("\nSeja bem vindo ao Classeador9000!\n \nO objetivo desse programa é, através de uma Árvore de Decisões, descobrir qual seria sua classe de Dungeons & Dragons.\n \nTente responder da forma mais básica e literal possível.\n")
atbTemp = input("Qual dessas características mais te define? Sua inteligência, seu carisma, sua sabedoria, sua força ou sua destreza? R: ")

if "inteligência" in atbTemp.lower() or "inteligencia" in atbTemp.lower():
    habTemp = input("O que mais te define, usar magia ou criar itens? R: ")
    if "não" in habTemp.lower()  or "nao" in habTemp.lower():
        resultado = clasedor("INT","Não","")
    elif "itens" in habTemp.lower():
        resultado = clasedor("INT","Magia","Sim")
    elif "magia" in habTemp.lower():
        resultado = clasedor("INT","Magia","Não")
        
elif "carisma" in atbTemp.lower():
    habTemp = input("Voce utiliza magia inata ou divina? R: ")
    if "inata" in habTemp.lower():
        psTemp = input("Você gosta bastante de musica? R: ")
        if "sim" in psTemp.lower() or "gosto" in psTemp.lower():
            resultado = clasedor("CAR","Magia Inata","Sim")
        else:
            resultado = clasedor("CAR","Magia Inata","Não")
    else:
        psTemp = input("Sua magia vem das trevas ou da luz? R: ")
        if "luz" in psTemp.lower():
            resultado = clasedor("CAR","Magia Divina","Deus")
        else:
            resultado = clasedor("CAR","Magia Divina","Diabo")
            
elif "sabedoria" in atbTemp.lower():
    habTemp = input("Voce utiliza magia? R: ")
    if "sim" in habTemp.lower():
        psTemp = input("Sua magia vem da natureza ou do divino R: ")
        if "natureza" in psTemp.lower():
            resultado = clasedor("SAB","sim","Natural")
        else:
            resultado = clasedor("SAB","sim","Divina")
    else:
        resultado = clasedor("SAB","Não","")

elif "força" in atbTemp.lower() or "forca" in atbTemp.lower():
    habTemp = input("Você usa sua raiva como arma? R: ")
    if "sim" in habTemp.lower():
        resultado = clasedor("FOR", "Sim","")
    else:
        resultado = clasedor("FOR", "Não","")

elif "destreza" in atbTemp.lower():
    habTemp = input("A sua furtividade é sua maior arma? R: ")
    if "sim" in habTemp .lower():
        resultado = clasedor("DES", "Sim","")
    else:
        resultado = clasedor("DES", "Não","")

print(f"Você, em Dungeons & Dragons, é um {resultado}! \n")