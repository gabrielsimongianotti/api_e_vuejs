<template>
  <div id="paciente">
    <div id ="add">
      <a href="#/CadastroSolicitacoes"><img src="../assets/add.png"></a> 
    </div>
    <card codigo=1 cartao=1000 crm=1 dtAtendimento="20/07/2000"/>
    <card codigo=2 cartao=1001 crm=2 dtAtendimento="19/09/1990"/>
    <card codigo=3 cartao=1002 crm=3 dtAtendimento="10/11/1996"/>
    <card codigo=4 cartao=1003 crm=4 dtAtendimento="01/04/1999"/>
    <card codigo=5 cartao=1004 crm=5 dtAtendimento="02/02/1998"/>
  </div>
</template>

<script>
  import card from './CardSolicitacoes.vue'

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
   width:"320";
   height:"205";
}
</style>
