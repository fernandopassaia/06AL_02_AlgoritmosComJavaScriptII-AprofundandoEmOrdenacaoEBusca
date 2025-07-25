const oleosMotor = require('./oleosMotor');

function mergeSort(array, incremento = 0) {
    console.log(`nível de aninhamento: ${incremento}`);
    console.log(array);
    console.log(' ');
  if (array.length > 1) {
    const meio = Math.floor(array.length / 2);
    // Recursão - O método chama ele mesmo para dividir o array
    // cada chamada gera uma "nova instancia" e vai somando na consta parte1 e parte2
    const parte1 = mergeSort(array.slice(0, meio), incremento + 1);
    const parte2 = mergeSort(array.slice(meio), incremento + 1);
    array = ordena(parte1, parte2); //conforme ele vai quebrando vai ordenando
  }

  return array;
}

function ordena(parte1, parte2) {
    console.log('**** Função Ordena ****');
    console.log('Parte 1:', parte1);
    console.log('Parte 2:', parte2);
  let posicaoAtualParte1 = 0;
  let posicaoAtualParte2 = 0;
  const resultado = [];

  while (posicaoAtualParte1 < parte1.length && posicaoAtualParte2 < parte2.length) {
    let oleoAtualParte1 = parte1[posicaoAtualParte1];
    let oleoAtualParte2 = parte2[posicaoAtualParte2];

    if (oleoAtualParte1.valor < oleoAtualParte2.valor) {
      resultado.push(oleoAtualParte1);
      posicaoAtualParte1++;
    } else {
      resultado.push(oleoAtualParte2);
      posicaoAtualParte2++;
    }
  }

  // o resultado contém todos os elementos de parte1 e parte2, porém, pode ser que ainda tenha elementos faltando
  // note que a condicao é posicaoAtualParte1 < parte1.length && posicaoAtualParte2 < parte2.length, as duas condicoes
  // precisam ser verdadeiras - caso saia, pode ser que sobre items em algum dos arrays
  // então, se parte1 ainda tiver elementos, adiciona ao resultado, caso contrário,
  // adiciona os elementos restantes de parte2
  const resultadoConcat = resultado.concat(posicaoAtualParte1 < parte1.length 
    ? parte1.slice(posicaoAtualParte1) // se tiver algo sobrando na Parte1, adicione o que tiver da posicaoAtualParte1 até o final
    : parte2.slice(posicaoAtualParte2)); //senao, os itens estao sobrando na Parte2, adicione o que tiver da posicaoAtualParte2 até o final
    console.log('Resultado Ordena:', resultadoConcat);
    console.log(' ');
    return resultadoConcat;    
}

console.log(mergeSort(oleosMotor));