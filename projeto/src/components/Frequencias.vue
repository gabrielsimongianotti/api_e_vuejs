<template>
  <div id="paciente">
    <div id ="add">
      <a href="#/CadastroFrequencias"><img src="../assets/add.png"></a> 
    </div>
     <card solicitacoes=1000 dtVerificacao="20/07/2000" batimentoCardiaco=90 pressaoMaximo=80 pressaoMinimo=50 sintoma='dor de cabeça' medicamento='charope'/>
     <card solicitacoes=1000 dtVerificacao="20/07/2000" batimentoCardiaco=90 pressaoMaximo=80 pressaoMinimo=50 sintoma='dor de cabeça' medicamento='charope'/>
     <card solicitacoes=1000 dtVerificacao="20/07/2000" batimentoCardiaco=90 pressaoMaximo=80 pressaoMinimo=50 sintoma='dor de cabeça' medicamento='charope'/>
  </div>
</template>

<script>
  import card from './CardFrequencias.vue'

  export default {
    name: 'paciente',
    components: {
      card
    }
  }
</script>

<style>
#add{
  text-align: right;
  margin: -30px 2% 0% 0%;
  position: relative;
}
</style>
