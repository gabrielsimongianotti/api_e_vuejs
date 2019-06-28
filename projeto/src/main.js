import Vue from 'vue'
import App from './App'
import VueRouter from 'vue-router'

import VueMaterial from 'vue-material'
import 'vue-material/dist/vue-material.css'

import Frequencias from './components/Frequencias.vue'
import Solicitacoes from './components/Solicitacoes.vue'
import Medico from './components/Medico.vue'
import Paciente from './components/Paciente.vue'

Vue.config.productionTip = false
Vue.use(VueMaterial)
Vue.use(VueRouter)

const routes = [
  { path: '/frequencias', component: Frequencias },
  { path: '/solicitacoes', component: Solicitacoes },
  { path: '/medico', component: Medico },
  { path: '/paciente', component: Paciente }
]

const router = new VueRouter({
  routes
})

Vue.material.registerTheme('default', {
  primary: 'blue',
  accent: 'red',
  warn: 'red'
})

/* eslint-disable no-new */
new Vue({
  router,
  render: h => h(App)
}).$mount('#app')
