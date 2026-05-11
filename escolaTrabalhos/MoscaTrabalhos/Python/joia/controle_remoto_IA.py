import cv2
import webbrowser # Biblioteca nativa para abrir sites
from keras.models import load_model
import numpy as np

# --- CONFIGURAÇÃO (A 'Caixa Preta') ---
modelo = load_model("keras_model.h5", compile=False)
classes = [linha.strip() for linha in open("labels.txt", "r")]
camera = cv2.VideoCapture(0)

print("Sistema pronto! Faça um gesto na câmera.")

while True:
    _, frame = camera.read()
    # Prepara a imagem para o modelo
    img = cv2.resize(frame, (224, 224))
    img = np.asarray(img, dtype=np.float32).reshape(1, 224, 224, 3)
    img = (img / 127.5) - 1

    # O Modelo faz a previsão
    previsao = modelo.predict(img, verbose=0)
    indice = np.argmax(previsao)
    nome_da_classe = classes[indice][2:] # Ex: "Joinha"

    # Mostra o que está vendo na tela
    cv2.putText(frame, nome_da_classe, (50, 50), cv2.FONT_HERSHEY_SIMPLEX, 1, (0, 255, 0), 2)
    cv2.imshow("IA do Aluno", frame)

    # --- AQUI É ONDE O ALUNO TRABALHA (Lógica Python) ---
    
    tecla = cv2.waitKey(1)
    
    if tecla == ord(' '): # Quando apertar ESPAÇO, executa o comando
        print(f"Comando detectado: {nome_da_classe}")
        
        if nome_da_classe == "joia":
            webbrowser.open("https://www.youtube.com")
            
        elif nome_da_classe == "soco":
            webbrowser.open("https://www.google.com")
            
        elif nome_da_classe == "PARE":
            print("Saindo...")
            break

camera.release()
cv2.destroyAllWindows()