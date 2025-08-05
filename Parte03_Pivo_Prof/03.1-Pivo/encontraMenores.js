const listaLivros = require('./array')

function encontraMenores(pivo, array) {
  let menores = 0;

  for(let atual = 0; atual < array.length; atual++) {
    let produtoAtual = array[atual]
    if (produtoAtual.preco < pivo.preco) {
      menores++
    }
  }

  trocaLugar(array, array.indexOf(pivo), menores)
  return array
}

function trocaLugar(array, de, para) {
  const elem1 = array[de]
  const elem2 = array[para]

  array[para] = elem1
  array[de] = elem2
}

function divideNoPivo(array) {
  let pivo = array[Math.floor(array.length / 2)]; //pego bem no meio do array
  encontraMenores(pivo, array); // coloco todos os menores que o pivo a esquerda
  let valoresMenores = 0;

  for(let analisando = 0; analisando < array.length; analisando++) {
    let atual = array[analisando];
    // atual !== pivo evito que o pivo seja analisado e trocado de lugar
    if(atual.preco <= pivo.preco && atual !== pivo) {
      trocaLugar(array, analisando, valoresMenores)
      valoresMenores++ //aumento o indice para que ele nao mexa no anterior
    }
  }

  return array;
}

// console.log(divideNoPivo(listaLivros));
// console.log(encontraMenores(listaLivros[2], listaLivros));

module.exports = trocaLugar;