import math
from collections import Counter

pontinhos = [
    ((1, 1), 'M'),  # A
    ((2, 1), 'M'),  # B
    ((1, 2), 'M'),  # C
    ((5, 5), 'C'),  # D
    ((6, 5), 'C'),  # E
    ((5, 6), 'C'),  # F
    ((6, 6), 'M')   # G (anomalia)
]

# Faz as medidas
def regua(p1, p2):
    return math.sqrt((p1[0] - p2[0])**2 + (p1[1] - p2[1])**2)

# Auto explicativo né??
def classefica(pontoNovo, k):
    distancias = []

    # Calcula distância para todos os pontos
    for ponto, classe in pontinhos:
        d = regua(pontoNovo, ponto)
        distancias.append((d, classe))

    # Ordena por menor distância
    distancias.sort(key=lambda x: x[0])

    # Pega os Kas mais próximos
    amiguinhos = distancias[:k]

    # Contar
    classes = [classe for _, classe in amiguinhos]
    contador = Counter(classes)

    # Retorna a classe mais comum
    return contador.most_common(1)[0][0], amiguinhos


# V1 (2,2)
print("V1 com K=1:", classefica((2, 2), 1))
print("V1 com K=3:", classefica((2, 2), 3))

print()

# V3 (6,7)
print("V3 com K=1:", classefica((6, 7), 1))
print("V3 com K=3:", classefica((6, 7), 3))